using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace System.Resources
{
	// Token: 0x02000284 RID: 644
	public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable
	{
		// Token: 0x06002E7E RID: 11902 RVA: 0x0009586B File Offset: 0x00093A6B
		internal ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache, bool permitDeserialization)
		{
			this._resCache = resCache;
			this._store = new BinaryReader(stream, Encoding.UTF8);
			this._ums = (stream as UnmanagedMemoryStream);
			this._permitDeserialization = permitDeserialization;
			this.ReadResources();
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000958A4 File Offset: 0x00093AA4
		private object DeserializeObject(int typeIndex)
		{
			if (!ResourceReader.AllowCustomResourceTypes)
			{
				throw new NotSupportedException(SR.ResourceManager_ReflectionNotAllowed);
			}
			if (!this._permitDeserialization)
			{
				throw new NotSupportedException(SR.NotSupported_ResourceObjectSerialization);
			}
			if (Volatile.Read<object>(ref this._binaryFormatter) == null && !this.<DeserializeObject>g__InitializeBinaryFormatterLocal|5_0())
			{
				throw new NotSupportedException(SR.BinaryFormatter_SerializationDisallowed);
			}
			Type type = this.FindType(typeIndex);
			object obj = ResourceReader.s_deserializeMethod(this._binaryFormatter, this._store.BaseStream);
			if (obj.GetType() != type)
			{
				throw new BadImageFormatException(SR.Format(SR.BadImageFormat_ResType_SerBlobMismatch, type.FullName, obj.GetType().FullName));
			}
			return obj;
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x0009594C File Offset: 0x00093B4C
		[RequiresDynamicCode("The native code for this instantiation might not be available at runtime.")]
		[RequiresUnreferencedCode("The CustomResourceTypesSupport feature switch has been enabled for this app which is being trimmed. Custom readers as well as custom objects on the resources file are not observable by the trimmer and so required assemblies, types and members may be removed.")]
		private bool InitializeBinaryFormatter()
		{
			if (Volatile.Read<Type>(ref ResourceReader.s_binaryFormatterType) == null || Volatile.Read<Func<object, Stream, object>>(ref ResourceReader.s_deserializeMethod) == null)
			{
				Type type = Type.GetType("System.Runtime.Serialization.Formatters.Binary.BinaryFormatter, System.Runtime.Serialization.Formatters", true);
				MethodInfo method = type.GetMethod("Deserialize", new Type[]
				{
					typeof(Stream)
				});
				MethodInfo method2 = typeof(ResourceReader).GetMethod("CreateUntypedDelegate", BindingFlags.Static | BindingFlags.NonPublic);
				object obj;
				if (method2 == null)
				{
					obj = null;
				}
				else
				{
					MethodBase methodBase = method2.MakeGenericMethod(new Type[]
					{
						type
					});
					object obj2 = null;
					object[] parameters = new MethodInfo[]
					{
						method
					};
					obj = methodBase.Invoke(obj2, parameters);
				}
				Func<object, Stream, object> value = (Func<object, Stream, object>)obj;
				Interlocked.CompareExchange<Type>(ref ResourceReader.s_binaryFormatterType, type, null);
				Interlocked.CompareExchange<Func<object, Stream, object>>(ref ResourceReader.s_deserializeMethod, value, null);
			}
			Volatile.Write<object>(ref this._binaryFormatter, Activator.CreateInstance(ResourceReader.s_binaryFormatterType));
			return ResourceReader.s_deserializeMethod != null;
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00095A1A File Offset: 0x00093C1A
		private static Func<object, Stream, object> CreateUntypedDelegate<TInstance>(MethodInfo method)
		{
			Func<TInstance, Stream, object> typedDelegate = (Func<TInstance, Stream, object>)Delegate.CreateDelegate(typeof(Func<TInstance, Stream, object>), null, method);
			return (object obj, Stream stream) => typedDelegate((TInstance)((object)obj), stream);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00095A48 File Offset: 0x00093C48
		private static bool ValidateReaderType(string readerType)
		{
			return ResourceManager.IsDefaultType(readerType, "System.Resources.ResourceReader");
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00095A58 File Offset: 0x00093C58
		[NullableContext(1)]
		public void GetResourceData(string resourceName, out string resourceType, out byte[] resourceData)
		{
			ArgumentNullException.ThrowIfNull(resourceName, "resourceName");
			if (this._resCache == null)
			{
				throw new InvalidOperationException(SR.ResourceReaderIsClosed);
			}
			int[] array = new int[this._numResources];
			int num = this.FindPosForResource(resourceName);
			if (num == -1)
			{
				throw new ArgumentException(SR.Format(SR.Arg_ResourceNameNotExist, resourceName));
			}
			lock (this)
			{
				for (int i = 0; i < this._numResources; i++)
				{
					this._store.BaseStream.Position = this._nameSectionOffset + (long)this.GetNamePosition(i);
					int num2 = this._store.Read7BitEncodedInt();
					if (num2 < 0)
					{
						throw new FormatException(SR.Format(SR.BadImageFormat_ResourcesNameInvalidOffset, num2));
					}
					this._store.BaseStream.Position += (long)num2;
					int num3 = this._store.ReadInt32();
					if (num3 < 0 || (long)num3 >= this._store.BaseStream.Length - this._dataSectionOffset)
					{
						throw new FormatException(SR.Format(SR.BadImageFormat_ResourcesDataInvalidOffset, num3));
					}
					array[i] = num3;
				}
				Array.Sort<int>(array);
				int num4 = Array.BinarySearch<int>(array, num);
				int num5 = (int)(((num4 < this._numResources - 1) ? ((long)array[num4 + 1] + this._dataSectionOffset) : this._store.BaseStream.Length) - ((long)num + this._dataSectionOffset));
				this._store.BaseStream.Position = this._dataSectionOffset + (long)num;
				ResourceTypeCode resourceTypeCode = (ResourceTypeCode)this._store.Read7BitEncodedInt();
				if (resourceTypeCode < ResourceTypeCode.Null || resourceTypeCode >= ResourceTypeCode.StartOfUserTypes + this._typeTable.Length)
				{
					throw new BadImageFormatException(SR.BadImageFormat_InvalidType);
				}
				resourceType = this.TypeNameFromTypeCode(resourceTypeCode);
				num5 -= (int)(this._store.BaseStream.Position - (this._dataSectionOffset + (long)num));
				byte[] array2 = this._store.ReadBytes(num5);
				if (array2.Length != num5)
				{
					throw new FormatException(SR.BadImageFormat_ResourceNameCorrupted);
				}
				resourceData = array2;
			}
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00095C88 File Offset: 0x00093E88
		[NullableContext(1)]
		public ResourceReader(string fileName)
		{
			this._resCache = new Dictionary<string, ResourceLocator>(FastResourceComparer.Default);
			this._store = new BinaryReader(new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.RandomAccess), Encoding.UTF8);
			try
			{
				this.ReadResources();
			}
			catch
			{
				this._store.Close();
				throw;
			}
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00095CF4 File Offset: 0x00093EF4
		[NullableContext(1)]
		public ResourceReader(Stream stream)
		{
			ArgumentNullException.ThrowIfNull(stream, "stream");
			if (!stream.CanRead)
			{
				throw new ArgumentException(SR.Argument_StreamNotReadable);
			}
			this._resCache = new Dictionary<string, ResourceLocator>(FastResourceComparer.Default);
			this._store = new BinaryReader(stream, Encoding.UTF8);
			this._ums = (stream as UnmanagedMemoryStream);
			this.ReadResources();
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x00095D58 File Offset: 0x00093F58
		internal static bool AllowCustomResourceTypes { get; }

		// Token: 0x06002E87 RID: 11911 RVA: 0x00095D5F File Offset: 0x00093F5F
		public void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00095D68 File Offset: 0x00093F68
		public void Dispose()
		{
			this.Close();
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00095D70 File Offset: 0x00093F70
		private void Dispose(bool disposing)
		{
			if (this._store != null)
			{
				this._resCache = null;
				if (disposing)
				{
					BinaryReader store = this._store;
					this._store = null;
					if (store != null)
					{
						store.Close();
					}
				}
				this._store = null;
				this._namePositions = null;
				this._nameHashes = null;
				this._ums = null;
				this._namePositionsPtr = null;
				this._nameHashesPtr = null;
			}
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00095DD3 File Offset: 0x00093FD3
		private unsafe static int ReadUnalignedI4(int* p)
		{
			return BinaryPrimitives.ReadInt32LittleEndian(new ReadOnlySpan<byte>((void*)p, 4));
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00095DE4 File Offset: 0x00093FE4
		private void SkipString()
		{
			int num = this._store.Read7BitEncodedInt();
			if (num < 0)
			{
				throw new BadImageFormatException(SR.BadImageFormat_NegativeStringLength);
			}
			this._store.BaseStream.Seek((long)num, SeekOrigin.Current);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00095E20 File Offset: 0x00094020
		private int GetNameHash(int index)
		{
			if (this._ums == null)
			{
				return this._nameHashes[index];
			}
			return ResourceReader.ReadUnalignedI4(this._nameHashesPtr + index);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00095E44 File Offset: 0x00094044
		private int GetNamePosition(int index)
		{
			int num;
			if (this._ums == null)
			{
				num = this._namePositions[index];
			}
			else
			{
				num = ResourceReader.ReadUnalignedI4(this._namePositionsPtr + index);
			}
			if (num < 0 || (long)num > this._dataSectionOffset - this._nameSectionOffset)
			{
				throw new FormatException(SR.Format(SR.BadImageFormat_ResourcesNameInvalidOffset, num));
			}
			return num;
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00095EA2 File Offset: 0x000940A2
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00095EAA File Offset: 0x000940AA
		[NullableContext(1)]
		public IDictionaryEnumerator GetEnumerator()
		{
			if (this._resCache == null)
			{
				throw new InvalidOperationException(SR.ResourceReaderIsClosed);
			}
			return new ResourceReader.ResourceEnumerator(this);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00095EC5 File Offset: 0x000940C5
		internal ResourceReader.ResourceEnumerator GetEnumeratorInternal()
		{
			return new ResourceReader.ResourceEnumerator(this);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00095ED0 File Offset: 0x000940D0
		internal int FindPosForResource(string name)
		{
			int num = FastResourceComparer.HashFunction(name);
			int i = 0;
			int num2 = this._numResources - 1;
			int num3 = -1;
			bool flag = false;
			while (i <= num2)
			{
				num3 = i + num2 >> 1;
				int nameHash = this.GetNameHash(num3);
				int num4;
				if (nameHash == num)
				{
					num4 = 0;
				}
				else if (nameHash < num)
				{
					num4 = -1;
				}
				else
				{
					num4 = 1;
				}
				if (num4 == 0)
				{
					flag = true;
					break;
				}
				if (num4 < 0)
				{
					i = num3 + 1;
				}
				else
				{
					num2 = num3 - 1;
				}
			}
			if (!flag)
			{
				return -1;
			}
			if (i != num3)
			{
				i = num3;
				while (i > 0 && this.GetNameHash(i - 1) == num)
				{
					i--;
				}
			}
			if (num2 != num3)
			{
				num2 = num3;
				while (num2 < this._numResources - 1 && this.GetNameHash(num2 + 1) == num)
				{
					num2++;
				}
			}
			lock (this)
			{
				int j = i;
				while (j <= num2)
				{
					this._store.BaseStream.Seek(this._nameSectionOffset + (long)this.GetNamePosition(j), SeekOrigin.Begin);
					if (this.CompareStringEqualsName(name))
					{
						int num5 = this._store.ReadInt32();
						if (num5 < 0 || (long)num5 >= this._store.BaseStream.Length - this._dataSectionOffset)
						{
							throw new FormatException(SR.Format(SR.BadImageFormat_ResourcesDataInvalidOffset, num5));
						}
						return num5;
					}
					else
					{
						j++;
					}
				}
			}
			return -1;
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00096038 File Offset: 0x00094238
		private unsafe bool CompareStringEqualsName(string name)
		{
			int num = this._store.Read7BitEncodedInt();
			if (num < 0)
			{
				throw new BadImageFormatException(SR.BadImageFormat_NegativeStringLength);
			}
			if (this._ums == null)
			{
				byte[] array = new byte[num];
				int num2;
				for (int i = num; i > 0; i -= num2)
				{
					num2 = this._store.Read(array, num - i, i);
					if (num2 == 0)
					{
						throw new BadImageFormatException(SR.BadImageFormat_ResourceNameCorrupted);
					}
				}
				return FastResourceComparer.CompareOrdinal(array, num / 2, name) == 0;
			}
			byte* positionPointer = this._ums.PositionPointer;
			this._ums.Seek((long)num, SeekOrigin.Current);
			if (this._ums.Position > this._ums.Length)
			{
				throw new BadImageFormatException(SR.BadImageFormat_ResourcesNameTooLong);
			}
			return FastResourceComparer.CompareOrdinal(positionPointer, num, name) == 0;
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000960F0 File Offset: 0x000942F0
		private unsafe string AllocateStringForNameIndex(int index, out int dataOffset)
		{
			long num = (long)this.GetNamePosition(index);
			int num2;
			byte[] array;
			lock (this)
			{
				this._store.BaseStream.Seek(num + this._nameSectionOffset, SeekOrigin.Begin);
				num2 = this._store.Read7BitEncodedInt();
				if (num2 < 0)
				{
					throw new BadImageFormatException(SR.BadImageFormat_NegativeStringLength);
				}
				if (this._ums != null)
				{
					if (this._ums.Position > this._ums.Length - (long)num2)
					{
						throw new BadImageFormatException(SR.Format(SR.BadImageFormat_ResourcesIndexTooLong, index));
					}
					char* positionPointer = (char*)this._ums.PositionPointer;
					bool isLittleEndian = BitConverter.IsLittleEndian;
					string result = new string(positionPointer, 0, num2 / 2);
					this._ums.Position += (long)num2;
					dataOffset = this._store.ReadInt32();
					if (dataOffset < 0 || (long)dataOffset >= this._store.BaseStream.Length - this._dataSectionOffset)
					{
						throw new FormatException(SR.Format(SR.BadImageFormat_ResourcesDataInvalidOffset, dataOffset));
					}
					return result;
				}
				else
				{
					array = new byte[num2];
					int num3;
					for (int i = num2; i > 0; i -= num3)
					{
						num3 = this._store.Read(array, num2 - i, i);
						if (num3 == 0)
						{
							throw new EndOfStreamException(SR.Format(SR.BadImageFormat_ResourceNameCorrupted_NameIndex, index));
						}
					}
					dataOffset = this._store.ReadInt32();
					if (dataOffset < 0 || (long)dataOffset >= this._store.BaseStream.Length - this._dataSectionOffset)
					{
						throw new FormatException(SR.Format(SR.BadImageFormat_ResourcesDataInvalidOffset, dataOffset));
					}
				}
			}
			return Encoding.Unicode.GetString(array, 0, num2);
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x000962D0 File Offset: 0x000944D0
		private object GetValueForNameIndex(int index)
		{
			long num = (long)this.GetNamePosition(index);
			object result;
			lock (this)
			{
				this._store.BaseStream.Seek(num + this._nameSectionOffset, SeekOrigin.Begin);
				this.SkipString();
				int num2 = this._store.ReadInt32();
				if (num2 < 0 || (long)num2 >= this._store.BaseStream.Length - this._dataSectionOffset)
				{
					throw new FormatException(SR.Format(SR.BadImageFormat_ResourcesDataInvalidOffset, num2));
				}
				if (this._version == 1)
				{
					result = this.LoadObjectV1(num2);
				}
				else
				{
					ResourceTypeCode resourceTypeCode;
					result = this.LoadObjectV2(num2, out resourceTypeCode);
				}
			}
			return result;
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00096390 File Offset: 0x00094590
		internal string LoadString(int pos)
		{
			string result;
			lock (this)
			{
				this._store.BaseStream.Seek(this._dataSectionOffset + (long)pos, SeekOrigin.Begin);
				string text = null;
				int num = this._store.Read7BitEncodedInt();
				if (this._version == 1)
				{
					if (num == -1)
					{
						return null;
					}
					if (this.FindType(num) != typeof(string))
					{
						throw new InvalidOperationException(SR.Format(SR.InvalidOperation_ResourceNotString_Type, this.FindType(num).FullName));
					}
					text = this._store.ReadString();
				}
				else
				{
					ResourceTypeCode resourceTypeCode = (ResourceTypeCode)num;
					if (resourceTypeCode != ResourceTypeCode.String && resourceTypeCode != ResourceTypeCode.Null)
					{
						string p;
						if (resourceTypeCode < ResourceTypeCode.StartOfUserTypes)
						{
							p = resourceTypeCode.ToString();
						}
						else
						{
							p = this.FindType(resourceTypeCode - ResourceTypeCode.StartOfUserTypes).FullName;
						}
						throw new InvalidOperationException(SR.Format(SR.InvalidOperation_ResourceNotString_Type, p));
					}
					if (resourceTypeCode == ResourceTypeCode.String)
					{
						text = this._store.ReadString();
					}
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x000964A4 File Offset: 0x000946A4
		internal object LoadObject(int pos)
		{
			object result;
			lock (this)
			{
				ResourceTypeCode resourceTypeCode;
				result = ((this._version == 1) ? this.LoadObjectV1(pos) : this.LoadObjectV2(pos, out resourceTypeCode));
			}
			return result;
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x000964F8 File Offset: 0x000946F8
		internal object LoadObject(int pos, out ResourceTypeCode typeCode)
		{
			object result;
			lock (this)
			{
				if (this._version == 1)
				{
					object obj = this.LoadObjectV1(pos);
					typeCode = ((obj is string) ? ResourceTypeCode.String : ResourceTypeCode.StartOfUserTypes);
					result = obj;
				}
				else
				{
					result = this.LoadObjectV2(pos, out typeCode);
				}
			}
			return result;
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x0009655C File Offset: 0x0009475C
		private object LoadObjectV1(int pos)
		{
			object result;
			try
			{
				result = this._LoadObjectV1(pos);
			}
			catch (EndOfStreamException inner)
			{
				throw new BadImageFormatException(SR.BadImageFormat_TypeMismatch, inner);
			}
			catch (ArgumentOutOfRangeException inner2)
			{
				throw new BadImageFormatException(SR.BadImageFormat_TypeMismatch, inner2);
			}
			return result;
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x000965AC File Offset: 0x000947AC
		private unsafe object _LoadObjectV1(int pos)
		{
			this._store.BaseStream.Seek(this._dataSectionOffset + (long)pos, SeekOrigin.Begin);
			int num = this._store.Read7BitEncodedInt();
			if (num == -1)
			{
				return null;
			}
			Type left = this.FindType(num);
			if (left == typeof(string))
			{
				return this._store.ReadString();
			}
			if (left == typeof(int))
			{
				return this._store.ReadInt32();
			}
			if (left == typeof(byte))
			{
				return this._store.ReadByte();
			}
			if (left == typeof(sbyte))
			{
				return this._store.ReadSByte();
			}
			if (left == typeof(short))
			{
				return this._store.ReadInt16();
			}
			if (left == typeof(long))
			{
				return this._store.ReadInt64();
			}
			if (left == typeof(ushort))
			{
				return this._store.ReadUInt16();
			}
			if (left == typeof(uint))
			{
				return this._store.ReadUInt32();
			}
			if (left == typeof(ulong))
			{
				return this._store.ReadUInt64();
			}
			if (left == typeof(float))
			{
				return this._store.ReadSingle();
			}
			if (left == typeof(double))
			{
				return this._store.ReadDouble();
			}
			if (left == typeof(DateTime))
			{
				return new DateTime(this._store.ReadInt64());
			}
			if (left == typeof(TimeSpan))
			{
				return new TimeSpan(this._store.ReadInt64());
			}
			if (left == typeof(decimal))
			{
				Span<int> span = new Span<int>(stackalloc byte[(UIntPtr)16], 4);
				for (int i = 0; i < span.Length; i++)
				{
					*span[i] = this._store.ReadInt32();
				}
				return new decimal(span);
			}
			return this.DeserializeObject(num);
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00096818 File Offset: 0x00094A18
		private object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			object result;
			try
			{
				result = this._LoadObjectV2(pos, out typeCode);
			}
			catch (EndOfStreamException inner)
			{
				throw new BadImageFormatException(SR.BadImageFormat_TypeMismatch, inner);
			}
			catch (ArgumentOutOfRangeException inner2)
			{
				throw new BadImageFormatException(SR.BadImageFormat_TypeMismatch, inner2);
			}
			return result;
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00096868 File Offset: 0x00094A68
		private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			this._store.BaseStream.Seek(this._dataSectionOffset + (long)pos, SeekOrigin.Begin);
			typeCode = (ResourceTypeCode)this._store.Read7BitEncodedInt();
			switch (typeCode)
			{
			case ResourceTypeCode.Null:
				return null;
			case ResourceTypeCode.String:
				return this._store.ReadString();
			case ResourceTypeCode.Boolean:
				return this._store.ReadBoolean();
			case ResourceTypeCode.Char:
				return (char)this._store.ReadUInt16();
			case ResourceTypeCode.Byte:
				return this._store.ReadByte();
			case ResourceTypeCode.SByte:
				return this._store.ReadSByte();
			case ResourceTypeCode.Int16:
				return this._store.ReadInt16();
			case ResourceTypeCode.UInt16:
				return this._store.ReadUInt16();
			case ResourceTypeCode.Int32:
				return this._store.ReadInt32();
			case ResourceTypeCode.UInt32:
				return this._store.ReadUInt32();
			case ResourceTypeCode.Int64:
				return this._store.ReadInt64();
			case ResourceTypeCode.UInt64:
				return this._store.ReadUInt64();
			case ResourceTypeCode.Single:
				return this._store.ReadSingle();
			case ResourceTypeCode.Double:
				return this._store.ReadDouble();
			case ResourceTypeCode.Decimal:
				return this._store.ReadDecimal();
			case ResourceTypeCode.DateTime:
				return DateTime.FromBinary(this._store.ReadInt64());
			case ResourceTypeCode.TimeSpan:
				return new TimeSpan(this._store.ReadInt64());
			case ResourceTypeCode.ByteArray:
			{
				int num = this._store.ReadInt32();
				if (num < 0)
				{
					throw new BadImageFormatException(SR.Format(SR.BadImageFormat_ResourceDataLengthInvalid, num));
				}
				if (this._ums == null)
				{
					if ((long)num > this._store.BaseStream.Length)
					{
						throw new BadImageFormatException(SR.Format(SR.BadImageFormat_ResourceDataLengthInvalid, num));
					}
					return this._store.ReadBytes(num);
				}
				else
				{
					if ((long)num > this._ums.Length - this._ums.Position)
					{
						throw new BadImageFormatException(SR.Format(SR.BadImageFormat_ResourceDataLengthInvalid, num));
					}
					byte[] array = new byte[num];
					this._ums.Read(array, 0, num);
					return array;
				}
				break;
			}
			case ResourceTypeCode.Stream:
			{
				int num2 = this._store.ReadInt32();
				if (num2 < 0)
				{
					throw new BadImageFormatException(SR.Format(SR.BadImageFormat_ResourceDataLengthInvalid, num2));
				}
				if (this._ums == null)
				{
					return new PinnedBufferMemoryStream(this._store.ReadBytes(num2));
				}
				if ((long)num2 > this._ums.Length - this._ums.Position)
				{
					throw new BadImageFormatException(SR.Format(SR.BadImageFormat_ResourceDataLengthInvalid, num2));
				}
				return new UnmanagedMemoryStream(this._ums.PositionPointer, (long)num2, (long)num2, FileAccess.Read);
			}
			}
			if (typeCode < ResourceTypeCode.StartOfUserTypes)
			{
				throw new BadImageFormatException(SR.BadImageFormat_TypeMismatch);
			}
			int typeIndex = typeCode - ResourceTypeCode.StartOfUserTypes;
			return this.DeserializeObject(typeIndex);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00096BA8 File Offset: 0x00094DA8
		[MemberNotNull("_typeTable")]
		[MemberNotNull("_typeNamePositions")]
		private void ReadResources()
		{
			try
			{
				this._ReadResources();
			}
			catch (EndOfStreamException inner)
			{
				throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted, inner);
			}
			catch (IndexOutOfRangeException inner2)
			{
				throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted, inner2);
			}
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00096BF4 File Offset: 0x00094DF4
		[MemberNotNull("_typeTable")]
		[MemberNotNull("_typeNamePositions")]
		private unsafe void _ReadResources()
		{
			if (this._store.ReadInt32() != ResourceManager.MagicNumber)
			{
				throw new ArgumentException(SR.Resources_StreamNotValid);
			}
			int num = this._store.ReadInt32();
			int num2 = this._store.ReadInt32();
			if (num2 < 0 || num < 0)
			{
				throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted);
			}
			if (num > 1)
			{
				this._store.BaseStream.Seek((long)num2, SeekOrigin.Current);
			}
			else
			{
				string text = this._store.ReadString();
				if (!ResourceReader.ValidateReaderType(text))
				{
					throw new NotSupportedException(SR.Format(SR.NotSupported_WrongResourceReader_Type, text));
				}
				this.SkipString();
			}
			int num3 = this._store.ReadInt32();
			if (num3 != 2 && num3 != 1)
			{
				throw new ArgumentException(SR.Format(SR.Arg_ResourceFileUnsupportedVersion, 2, num3));
			}
			this._version = num3;
			this._numResources = this._store.ReadInt32();
			if (this._numResources < 0)
			{
				throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted);
			}
			int num4 = this._store.ReadInt32();
			if (num4 < 0)
			{
				throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted);
			}
			this._typeTable = new Type[num4];
			this._typeNamePositions = new int[num4];
			for (int i = 0; i < num4; i++)
			{
				this._typeNamePositions[i] = (int)this._store.BaseStream.Position;
				this.SkipString();
			}
			int num5 = (int)this._store.BaseStream.Position & 7;
			if (num5 != 0)
			{
				for (int j = 0; j < 8 - num5; j++)
				{
					this._store.ReadByte();
				}
			}
			if (this._ums == null)
			{
				this._nameHashes = new int[this._numResources];
				for (int k = 0; k < this._numResources; k++)
				{
					this._nameHashes[k] = this._store.ReadInt32();
				}
			}
			else
			{
				int num6 = 4 * this._numResources;
				if (num6 < 0)
				{
					throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted);
				}
				this._nameHashesPtr = (int*)this._ums.PositionPointer;
				this._ums.Seek((long)num6, SeekOrigin.Current);
				byte* positionPointer = this._ums.PositionPointer;
			}
			if (this._ums == null)
			{
				this._namePositions = new int[this._numResources];
				for (int l = 0; l < this._numResources; l++)
				{
					int num7 = this._store.ReadInt32();
					if (num7 < 0)
					{
						throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted);
					}
					this._namePositions[l] = num7;
				}
			}
			else
			{
				int num8 = 4 * this._numResources;
				if (num8 < 0)
				{
					throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted);
				}
				this._namePositionsPtr = (int*)this._ums.PositionPointer;
				this._ums.Seek((long)num8, SeekOrigin.Current);
				byte* positionPointer2 = this._ums.PositionPointer;
			}
			this._dataSectionOffset = (long)this._store.ReadInt32();
			if (this._dataSectionOffset < 0L)
			{
				throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted);
			}
			this._nameSectionOffset = this._store.BaseStream.Position;
			if (this._dataSectionOffset < this._nameSectionOffset)
			{
				throw new BadImageFormatException(SR.BadImageFormat_ResourcesHeaderCorrupted);
			}
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00096F08 File Offset: 0x00095108
		private Type FindType(int typeIndex)
		{
			if (!ResourceReader.AllowCustomResourceTypes)
			{
				throw new NotSupportedException(SR.ResourceManager_ReflectionNotAllowed);
			}
			if (typeIndex < 0 || typeIndex >= this._typeTable.Length)
			{
				throw new BadImageFormatException(SR.BadImageFormat_InvalidType);
			}
			return this._typeTable[typeIndex] ?? this.<FindType>g__UseReflectionToGetTypeLocal|52_0(typeIndex);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00096F54 File Offset: 0x00095154
		[RequiresUnreferencedCode("The CustomResourceTypesSupport feature switch has been enabled for this app which is being trimmed. Custom readers as well as custom objects on the resources file are not observable by the trimmer and so required assemblies, types and members may be removed.")]
		private Type UseReflectionToGetType(int typeIndex)
		{
			long position = this._store.BaseStream.Position;
			Type result;
			try
			{
				this._store.BaseStream.Position = (long)this._typeNamePositions[typeIndex];
				string typeName = this._store.ReadString();
				this._typeTable[typeIndex] = Type.GetType(typeName, true);
				result = this._typeTable[typeIndex];
			}
			catch (FileNotFoundException innerException) when (!this._permitDeserialization)
			{
				throw new NotSupportedException(SR.NotSupported_ResourceObjectSerialization, innerException);
			}
			finally
			{
				this._store.BaseStream.Position = position;
			}
			return result;
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00097008 File Offset: 0x00095208
		private string TypeNameFromTypeCode(ResourceTypeCode typeCode)
		{
			if (typeCode < ResourceTypeCode.StartOfUserTypes)
			{
				return "ResourceTypeCode." + typeCode.ToString();
			}
			int num = typeCode - ResourceTypeCode.StartOfUserTypes;
			long position = this._store.BaseStream.Position;
			string result;
			try
			{
				this._store.BaseStream.Position = (long)this._typeNamePositions[num];
				result = this._store.ReadString();
			}
			finally
			{
				this._store.BaseStream.Position = position;
			}
			return result;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00097094 File Offset: 0x00095294
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceReader()
		{
			bool flag;
			ResourceReader.AllowCustomResourceTypes = (!AppContext.TryGetSwitch("System.Resources.ResourceManager.AllowCustomResourceTypes", out flag) || flag);
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000970B8 File Offset: 0x000952B8
		[CompilerGenerated]
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "InitializeBinaryFormatter will get trimmed out when AllowCustomResourceTypes is set to false. When set to true, we will already throw a warning for this feature switch, so we suppress this one in order forthe user to only get one error.")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "InitializeBinaryFormatter will get trimmed out when AllowCustomResourceTypes is set to false. When set to true, we will already throw a warning for this feature switch, so we suppress this one in order forthe user to only get one error.")]
		private bool <DeserializeObject>g__InitializeBinaryFormatterLocal|5_0()
		{
			return this.InitializeBinaryFormatter();
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000970C0 File Offset: 0x000952C0
		[CompilerGenerated]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "UseReflectionToGetType will get trimmed out when AllowCustomResourceTypes is set to false. When set to true, we will already throw a warning for this feature switch, so we suppress this one in order forthe user to only get one error.")]
		private Type <FindType>g__UseReflectionToGetTypeLocal|52_0(int typeIndex)
		{
			return this.UseReflectionToGetType(typeIndex);
		}

		// Token: 0x0400088C RID: 2188
		private readonly bool _permitDeserialization;

		// Token: 0x0400088D RID: 2189
		private object _binaryFormatter;

		// Token: 0x0400088E RID: 2190
		[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
		private static Type s_binaryFormatterType;

		// Token: 0x0400088F RID: 2191
		private static Func<object, Stream, object> s_deserializeMethod;

		// Token: 0x04000890 RID: 2192
		private BinaryReader _store;

		// Token: 0x04000891 RID: 2193
		internal Dictionary<string, ResourceLocator> _resCache;

		// Token: 0x04000892 RID: 2194
		private long _nameSectionOffset;

		// Token: 0x04000893 RID: 2195
		private long _dataSectionOffset;

		// Token: 0x04000894 RID: 2196
		private int[] _nameHashes;

		// Token: 0x04000895 RID: 2197
		private unsafe int* _nameHashesPtr;

		// Token: 0x04000896 RID: 2198
		private int[] _namePositions;

		// Token: 0x04000897 RID: 2199
		private unsafe int* _namePositionsPtr;

		// Token: 0x04000898 RID: 2200
		private Type[] _typeTable;

		// Token: 0x04000899 RID: 2201
		private int[] _typeNamePositions;

		// Token: 0x0400089A RID: 2202
		private int _numResources;

		// Token: 0x0400089B RID: 2203
		private UnmanagedMemoryStream _ums;

		// Token: 0x0400089C RID: 2204
		private int _version;

		// Token: 0x02000285 RID: 645
		internal sealed class ResourceEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06002EA4 RID: 11940 RVA: 0x000970C9 File Offset: 0x000952C9
			internal ResourceEnumerator(ResourceReader reader)
			{
				this._currentName = -1;
				this._reader = reader;
				this._dataPosition = -2;
			}

			// Token: 0x06002EA5 RID: 11941 RVA: 0x000970E8 File Offset: 0x000952E8
			public bool MoveNext()
			{
				if (this._currentName == this._reader._numResources - 1 || this._currentName == -2147483648)
				{
					this._currentIsValid = false;
					this._currentName = int.MinValue;
					return false;
				}
				this._currentIsValid = true;
				this._currentName++;
				return true;
			}

			// Token: 0x170008F3 RID: 2291
			// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x00097144 File Offset: 0x00095344
			public object Key
			{
				get
				{
					if (this._currentName == -2147483648)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
					}
					if (!this._currentIsValid)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
					}
					if (this._reader._resCache == null)
					{
						throw new InvalidOperationException(SR.ResourceReaderIsClosed);
					}
					return this._reader.AllocateStringForNameIndex(this._currentName, out this._dataPosition);
				}
			}

			// Token: 0x170008F4 RID: 2292
			// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x000971AB File Offset: 0x000953AB
			public object Current
			{
				get
				{
					return this.Entry;
				}
			}

			// Token: 0x170008F5 RID: 2293
			// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x000971B8 File Offset: 0x000953B8
			internal int DataPosition
			{
				get
				{
					return this._dataPosition;
				}
			}

			// Token: 0x170008F6 RID: 2294
			// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x000971C0 File Offset: 0x000953C0
			public DictionaryEntry Entry
			{
				get
				{
					if (this._currentName == -2147483648)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
					}
					if (!this._currentIsValid)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
					}
					if (this._reader._resCache == null)
					{
						throw new InvalidOperationException(SR.ResourceReaderIsClosed);
					}
					string key = this._reader.AllocateStringForNameIndex(this._currentName, out this._dataPosition);
					object obj = null;
					Dictionary<string, ResourceLocator> resCache = this._reader._resCache;
					lock (resCache)
					{
						ResourceLocator resourceLocator;
						if (this._reader._resCache.TryGetValue(key, out resourceLocator))
						{
							obj = resourceLocator.Value;
						}
					}
					if (obj == null)
					{
						if (this._dataPosition == -1)
						{
							obj = this._reader.GetValueForNameIndex(this._currentName);
						}
						else
						{
							obj = this._reader.LoadObject(this._dataPosition);
						}
					}
					return new DictionaryEntry(key, obj);
				}
			}

			// Token: 0x170008F7 RID: 2295
			// (get) Token: 0x06002EAA RID: 11946 RVA: 0x000972B4 File Offset: 0x000954B4
			public object Value
			{
				get
				{
					if (this._currentName == -2147483648)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumEnded);
					}
					if (!this._currentIsValid)
					{
						throw new InvalidOperationException(SR.InvalidOperation_EnumNotStarted);
					}
					if (this._reader._resCache == null)
					{
						throw new InvalidOperationException(SR.ResourceReaderIsClosed);
					}
					return this._reader.GetValueForNameIndex(this._currentName);
				}
			}

			// Token: 0x06002EAB RID: 11947 RVA: 0x00097315 File Offset: 0x00095515
			public void Reset()
			{
				if (this._reader._resCache == null)
				{
					throw new InvalidOperationException(SR.ResourceReaderIsClosed);
				}
				this._currentIsValid = false;
				this._currentName = -1;
			}

			// Token: 0x0400089E RID: 2206
			private readonly ResourceReader _reader;

			// Token: 0x0400089F RID: 2207
			private bool _currentIsValid;

			// Token: 0x040008A0 RID: 2208
			private int _currentName;

			// Token: 0x040008A1 RID: 2209
			private int _dataPosition;
		}
	}
}
