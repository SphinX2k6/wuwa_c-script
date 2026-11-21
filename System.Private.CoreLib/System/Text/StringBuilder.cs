using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Text
{
	// Token: 0x02000237 RID: 567
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class StringBuilder : ISerializable
	{
		// Token: 0x06002B54 RID: 11092 RVA: 0x00087C5B File Offset: 0x00085E5B
		public StringBuilder()
		{
			this.m_MaxCapacity = int.MaxValue;
			this.m_ChunkChars = new char[16];
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00087C7B File Offset: 0x00085E7B
		public StringBuilder(int capacity) : this(capacity, int.MaxValue)
		{
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x00087C89 File Offset: 0x00085E89
		[NullableContext(2)]
		public StringBuilder(string value) : this(value, 16)
		{
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00087C94 File Offset: 0x00085E94
		[NullableContext(2)]
		public StringBuilder(string value, int capacity) : this(value, 0, (value != null) ? value.Length : 0, capacity)
		{
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x00087CAC File Offset: 0x00085EAC
		[NullableContext(2)]
		public StringBuilder(string value, int startIndex, int length, int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			if (value == null)
			{
				value = string.Empty;
			}
			if (startIndex > value.Length - length)
			{
				throw new ArgumentOutOfRangeException("length", SR.ArgumentOutOfRange_IndexLength);
			}
			this.m_MaxCapacity = int.MaxValue;
			if (capacity == 0)
			{
				capacity = 16;
			}
			capacity = Math.Max(capacity, length);
			this.m_ChunkChars = GC.AllocateUninitializedArray<char>(capacity, false);
			this.m_ChunkLength = length;
			value.AsSpan(startIndex, length).CopyTo(this.m_ChunkChars);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00087D54 File Offset: 0x00085F54
		public StringBuilder(int capacity, int maxCapacity)
		{
			if (capacity > maxCapacity)
			{
				throw new ArgumentOutOfRangeException("capacity", SR.ArgumentOutOfRange_Capacity);
			}
			ArgumentOutOfRangeException.ThrowIfNegativeOrZero<int>(maxCapacity, "maxCapacity");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			if (capacity == 0)
			{
				capacity = Math.Min(16, maxCapacity);
			}
			this.m_MaxCapacity = maxCapacity;
			this.m_ChunkChars = GC.AllocateUninitializedArray<char>(capacity, false);
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00087DB4 File Offset: 0x00085FB4
		private StringBuilder(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			int num = 0;
			string text = null;
			int num2 = int.MaxValue;
			bool flag = false;
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				if (!(name == "m_MaxCapacity"))
				{
					if (!(name == "m_StringValue"))
					{
						if (name == "Capacity")
						{
							num = info.GetInt32("Capacity");
							flag = true;
						}
					}
					else
					{
						text = info.GetString("m_StringValue");
					}
				}
				else
				{
					num2 = info.GetInt32("m_MaxCapacity");
				}
			}
			if (text == null)
			{
				text = string.Empty;
			}
			if (num2 < 1 || text.Length > num2)
			{
				throw new SerializationException(SR.Serialization_StringBuilderMaxCapacity);
			}
			if (!flag)
			{
				num = Math.Min(Math.Max(16, text.Length), num2);
			}
			if (num < 0 || num < text.Length || num > num2)
			{
				throw new SerializationException(SR.Serialization_StringBuilderCapacity);
			}
			this.m_MaxCapacity = num2;
			this.m_ChunkChars = GC.AllocateUninitializedArray<char>(num, false);
			text.CopyTo(0, this.m_ChunkChars, 0, text.Length);
			this.m_ChunkLength = text.Length;
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00087ED8 File Offset: 0x000860D8
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			ArgumentNullException.ThrowIfNull(info, "info");
			info.AddValue("m_MaxCapacity", this.m_MaxCapacity);
			info.AddValue("Capacity", this.Capacity);
			info.AddValue("m_StringValue", this.ToString());
			info.AddValue("m_currentThread", 0);
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x00087F2F File Offset: 0x0008612F
		// (set) Token: 0x06002B5D RID: 11101 RVA: 0x00087F40 File Offset: 0x00086140
		public int Capacity
		{
			get
			{
				return this.m_ChunkChars.Length + this.m_ChunkOffset;
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(value, "value");
				if (value > this.MaxCapacity)
				{
					throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_Capacity);
				}
				if (value < this.Length)
				{
					throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_SmallCapacity);
				}
				if (this.Capacity != value)
				{
					char[] array = GC.AllocateUninitializedArray<char>(value - this.m_ChunkOffset, false);
					Array.Copy(this.m_ChunkChars, array, this.m_ChunkLength);
					this.m_ChunkChars = array;
				}
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x00087FBB File Offset: 0x000861BB
		public int MaxCapacity
		{
			get
			{
				return this.m_MaxCapacity;
			}
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00087FC3 File Offset: 0x000861C3
		public int EnsureCapacity(int capacity)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(capacity, "capacity");
			if (this.Capacity < capacity)
			{
				this.Capacity = capacity;
			}
			return this.Capacity;
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00087FE8 File Offset: 0x000861E8
		public override string ToString()
		{
			if (this.Length == 0)
			{
				return string.Empty;
			}
			string text = string.FastAllocateString(this.Length);
			StringBuilder stringBuilder = this;
			for (;;)
			{
				if (stringBuilder.m_ChunkLength > 0)
				{
					char[] chunkChars = stringBuilder.m_ChunkChars;
					int chunkOffset = stringBuilder.m_ChunkOffset;
					int chunkLength = stringBuilder.m_ChunkLength;
					if (chunkLength + chunkOffset > text.Length || chunkLength > chunkChars.Length)
					{
						break;
					}
					Buffer.Memmove<char>(Unsafe.Add<char>(text.GetRawStringData(), chunkOffset), MemoryMarshal.GetArrayDataReference<char>(chunkChars), (UIntPtr)((IntPtr)chunkLength));
				}
				stringBuilder = stringBuilder.m_ChunkPrevious;
				if (stringBuilder == null)
				{
					return text;
				}
			}
			throw new ArgumentOutOfRangeException("chunkLength", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00088078 File Offset: 0x00086278
		public string ToString(int startIndex, int length)
		{
			int length2 = this.Length;
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			if (startIndex > length2)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_StartIndexLargerThanLength);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			if (startIndex > length2 - length)
			{
				throw new ArgumentOutOfRangeException("length", SR.ArgumentOutOfRange_IndexLength);
			}
			string text = string.FastAllocateString(length);
			this.CopyTo(startIndex, new Span<char>(text.GetRawStringData(), text.Length), text.Length);
			return text;
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000880F2 File Offset: 0x000862F2
		public StringBuilder Clear()
		{
			this.Length = 0;
			return this;
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x000880FC File Offset: 0x000862FC
		// (set) Token: 0x06002B64 RID: 11108 RVA: 0x0008810C File Offset: 0x0008630C
		public int Length
		{
			get
			{
				return this.m_ChunkOffset + this.m_ChunkLength;
			}
			set
			{
				ArgumentOutOfRangeException.ThrowIfNegative<int>(value, "value");
				if (value > this.MaxCapacity)
				{
					throw new ArgumentOutOfRangeException("value", SR.ArgumentOutOfRange_SmallCapacity);
				}
				if (value == 0 && this.m_ChunkPrevious == null)
				{
					this.m_ChunkLength = 0;
					this.m_ChunkOffset = 0;
					return;
				}
				int num = value - this.Length;
				if (num > 0)
				{
					this.Append('\0', num);
					return;
				}
				StringBuilder stringBuilder = this.FindChunkForIndex(value);
				if (stringBuilder != this)
				{
					int num2 = Math.Min(this.Capacity, Math.Max(this.Length * 6 / 5, this.m_ChunkChars.Length)) - stringBuilder.m_ChunkOffset;
					if (num2 > stringBuilder.m_ChunkChars.Length)
					{
						char[] array = GC.AllocateUninitializedArray<char>(num2, false);
						Array.Copy(stringBuilder.m_ChunkChars, array, stringBuilder.m_ChunkLength);
						this.m_ChunkChars = array;
					}
					else
					{
						this.m_ChunkChars = stringBuilder.m_ChunkChars;
					}
					this.m_ChunkPrevious = stringBuilder.m_ChunkPrevious;
					this.m_ChunkOffset = stringBuilder.m_ChunkOffset;
				}
				this.m_ChunkLength = value - stringBuilder.m_ChunkOffset;
			}
		}

		// Token: 0x17000899 RID: 2201
		[IndexerName("Chars")]
		public char this[int index]
		{
			get
			{
				StringBuilder stringBuilder = this;
				int num;
				for (;;)
				{
					num = index - stringBuilder.m_ChunkOffset;
					if (num >= 0)
					{
						break;
					}
					stringBuilder = stringBuilder.m_ChunkPrevious;
					if (stringBuilder == null)
					{
						goto Block_3;
					}
				}
				if (num >= stringBuilder.m_ChunkLength)
				{
					throw new IndexOutOfRangeException();
				}
				return stringBuilder.m_ChunkChars[num];
				Block_3:
				throw new IndexOutOfRangeException();
			}
			set
			{
				StringBuilder stringBuilder = this;
				int num;
				for (;;)
				{
					num = index - stringBuilder.m_ChunkOffset;
					if (num >= 0)
					{
						break;
					}
					stringBuilder = stringBuilder.m_ChunkPrevious;
					if (stringBuilder == null)
					{
						goto Block_3;
					}
				}
				if (num >= stringBuilder.m_ChunkLength)
				{
					throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
				}
				stringBuilder.m_ChunkChars[num] = value;
				return;
				Block_3:
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLess);
			}
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000882A0 File Offset: 0x000864A0
		public StringBuilder.ChunkEnumerator GetChunks()
		{
			return new StringBuilder.ChunkEnumerator(this);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x000882A8 File Offset: 0x000864A8
		public StringBuilder Append(char value, int repeatCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(repeatCount, "repeatCount");
			if (repeatCount == 0)
			{
				return this;
			}
			char[] chunkChars = this.m_ChunkChars;
			int chunkLength = this.m_ChunkLength;
			if ((UIntPtr)chunkLength + (UIntPtr)repeatCount <= (UIntPtr)chunkChars.Length)
			{
				chunkChars.AsSpan(chunkLength, repeatCount).Fill(value);
				this.m_ChunkLength += repeatCount;
			}
			else
			{
				this.AppendWithExpansion(value, repeatCount);
			}
			return this;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x00088308 File Offset: 0x00086508
		private void AppendWithExpansion(char value, int repeatCount)
		{
			if (repeatCount + this.Length > this.m_MaxCapacity)
			{
				throw new ArgumentOutOfRangeException("repeatCount", SR.ArgumentOutOfRange_LengthGreaterThanCapacity);
			}
			char[] chunkChars = this.m_ChunkChars;
			int chunkLength = this.m_ChunkLength;
			int num = chunkChars.Length - chunkLength;
			if (num > 0)
			{
				chunkChars.AsSpan(chunkLength, num).Fill(value);
				this.m_ChunkLength = chunkChars.Length;
			}
			int num2 = repeatCount - num;
			this.ExpandByABlock(num2);
			this.m_ChunkChars.AsSpan(0, num2).Fill(value);
			this.m_ChunkLength = num2;
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00088394 File Offset: 0x00086594
		public StringBuilder Append([Nullable(2)] char[] value, int startIndex, int charCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			if (value == null)
			{
				if (startIndex == 0 && charCount == 0)
				{
					return this;
				}
				ArgumentNullException.Throw("value");
			}
			if (charCount > value.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("charCount", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (charCount != 0)
			{
				this.Append(ref value[startIndex], charCount);
			}
			return this;
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000883F6 File Offset: 0x000865F6
		public StringBuilder Append([Nullable(2)] string value)
		{
			if (value != null)
			{
				this.Append(value.GetRawStringData(), value.Length);
			}
			return this;
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00088410 File Offset: 0x00086610
		public StringBuilder Append([Nullable(2)] string value, int startIndex, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (value == null)
			{
				if (startIndex == 0 && count == 0)
				{
					return this;
				}
				ArgumentNullException.Throw("value");
			}
			if (count != 0)
			{
				if (startIndex > value.Length - count)
				{
					throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				this.Append(Unsafe.Add<char>(value.GetRawStringData(), startIndex), count);
			}
			return this;
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x0008847A File Offset: 0x0008667A
		public StringBuilder Append([Nullable(2)] StringBuilder value)
		{
			if (value != null && value.Length != 0)
			{
				return this.AppendCore(value, 0, value.Length);
			}
			return this;
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x00088498 File Offset: 0x00086698
		public StringBuilder Append([Nullable(2)] StringBuilder value, int startIndex, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (value == null)
			{
				if (startIndex == 0 && count == 0)
				{
					return this;
				}
				ArgumentNullException.Throw("value");
			}
			if (count == 0)
			{
				return this;
			}
			if (count > value.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			return this.AppendCore(value, startIndex, count);
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x000884FC File Offset: 0x000866FC
		private StringBuilder AppendCore(StringBuilder value, int startIndex, int count)
		{
			if (value == this)
			{
				return this.Append(value.ToString(startIndex, count));
			}
			if (this.Length + count > this.m_MaxCapacity)
			{
				throw new ArgumentOutOfRangeException("Capacity", SR.ArgumentOutOfRange_Capacity);
			}
			while (count > 0)
			{
				int num = Math.Min(this.m_ChunkChars.Length - this.m_ChunkLength, count);
				if (num == 0)
				{
					this.ExpandByABlock(count);
					num = count;
				}
				value.CopyTo(startIndex, new Span<char>(this.m_ChunkChars, this.m_ChunkLength, num), num);
				this.m_ChunkLength += num;
				startIndex += num;
				count -= num;
			}
			return this;
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x00088595 File Offset: 0x00086795
		public StringBuilder AppendLine()
		{
			return this.Append("\r\n");
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000885A2 File Offset: 0x000867A2
		public StringBuilder AppendLine([Nullable(2)] string value)
		{
			this.Append(value);
			return this.Append("\r\n");
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x000885B8 File Offset: 0x000867B8
		public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
			ArgumentNullException.ThrowIfNull(destination, "destination");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(destinationIndex, "destinationIndex");
			if (destinationIndex > destination.Length - count)
			{
				throw new ArgumentException(SR.ArgumentOutOfRange_OffsetOut);
			}
			this.CopyTo(sourceIndex, new Span<char>(destination).Slice(destinationIndex), count);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00088608 File Offset: 0x00086808
		[NullableContext(0)]
		public void CopyTo(int sourceIndex, Span<char> destination, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			if (sourceIndex > this.Length)
			{
				throw new ArgumentOutOfRangeException("sourceIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (sourceIndex > this.Length - count)
			{
				throw new ArgumentException(SR.Arg_LongerThanSrcString);
			}
			StringBuilder stringBuilder = this;
			int num = sourceIndex + count;
			int num2 = count;
			while (count > 0)
			{
				int num3 = num - stringBuilder.m_ChunkOffset;
				if (num3 >= 0)
				{
					num3 = Math.Min(num3, stringBuilder.m_ChunkLength);
					int num4 = count;
					int num5 = num3 - count;
					if (num5 < 0)
					{
						num4 += num5;
						num5 = 0;
					}
					num2 -= num4;
					count -= num4;
					new ReadOnlySpan<char>(stringBuilder.m_ChunkChars, num5, num4).CopyTo(destination.Slice(num2));
				}
				stringBuilder = stringBuilder.m_ChunkPrevious;
			}
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000886C0 File Offset: 0x000868C0
		public StringBuilder Insert(int index, [Nullable(2)] string value, int count)
		{
			return this.Insert(index, value.AsSpan(), count);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000886D0 File Offset: 0x000868D0
		private StringBuilder Insert(int index, ReadOnlySpan<char> value, int count)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(count, "count");
			int length = this.Length;
			if (index > length)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (value.IsEmpty || count == 0)
			{
				return this;
			}
			long num = (long)value.Length * (long)count;
			if (num > (long)(this.MaxCapacity - this.Length))
			{
				throw new OutOfMemoryException();
			}
			StringBuilder stringBuilder;
			int num2;
			this.MakeRoom(index, (int)num, out stringBuilder, out num2, false);
			while (count > 0)
			{
				this.ReplaceInPlaceAtChunk(ref stringBuilder, ref num2, MemoryMarshal.GetReference<char>(value), value.Length);
				count--;
			}
			return this;
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00088768 File Offset: 0x00086968
		public StringBuilder Remove(int startIndex, int length)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			if (length > this.Length - startIndex)
			{
				throw new ArgumentOutOfRangeException("length", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (this.Length == length && startIndex == 0)
			{
				this.Length = 0;
				return this;
			}
			if (length > 0)
			{
				StringBuilder stringBuilder;
				int num;
				this.Remove(startIndex, length, out stringBuilder, out num);
			}
			return this;
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000887CC File Offset: 0x000869CC
		public StringBuilder Append(bool value)
		{
			return this.Append(value.ToString());
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000887DC File Offset: 0x000869DC
		public StringBuilder Append(char value)
		{
			int chunkLength = this.m_ChunkLength;
			char[] chunkChars = this.m_ChunkChars;
			if (chunkChars.Length > chunkLength)
			{
				chunkChars[chunkLength] = value;
				this.m_ChunkLength++;
			}
			else
			{
				this.AppendWithExpansion(value);
			}
			return this;
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00088819 File Offset: 0x00086A19
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AppendWithExpansion(char value)
		{
			this.ExpandByABlock(1);
			this.m_ChunkChars[0] = value;
			this.m_ChunkLength++;
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00088839 File Offset: 0x00086A39
		[CLSCompliant(false)]
		public StringBuilder Append(sbyte value)
		{
			return this.AppendSpanFormattable<sbyte>(value);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x00088842 File Offset: 0x00086A42
		public StringBuilder Append(byte value)
		{
			return this.AppendSpanFormattable<byte>(value);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x0008884B File Offset: 0x00086A4B
		public StringBuilder Append(short value)
		{
			return this.AppendSpanFormattable<short>(value);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00088854 File Offset: 0x00086A54
		public StringBuilder Append(int value)
		{
			return this.AppendSpanFormattable<int>(value);
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x0008885D File Offset: 0x00086A5D
		public StringBuilder Append(long value)
		{
			return this.AppendSpanFormattable<long>(value);
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x00088866 File Offset: 0x00086A66
		public StringBuilder Append(float value)
		{
			return this.AppendSpanFormattable<float>(value);
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x0008886F File Offset: 0x00086A6F
		public StringBuilder Append(double value)
		{
			return this.AppendSpanFormattable<double>(value);
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00088878 File Offset: 0x00086A78
		public StringBuilder Append(decimal value)
		{
			return this.AppendSpanFormattable<decimal>(value);
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x00088881 File Offset: 0x00086A81
		[CLSCompliant(false)]
		public StringBuilder Append(ushort value)
		{
			return this.AppendSpanFormattable<ushort>(value);
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x0008888A File Offset: 0x00086A8A
		[CLSCompliant(false)]
		public StringBuilder Append(uint value)
		{
			return this.AppendSpanFormattable<uint>(value);
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x00088893 File Offset: 0x00086A93
		[CLSCompliant(false)]
		public StringBuilder Append(ulong value)
		{
			return this.AppendSpanFormattable<ulong>(value);
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x0008889C File Offset: 0x00086A9C
		private StringBuilder AppendSpanFormattable<T>(T value) where T : ISpanFormattable
		{
			ref T ptr = ref value;
			if (default(T) == null)
			{
				T t = value;
				ptr = ref t;
			}
			int num;
			if (ptr.TryFormat(this.RemainingCurrentChunk, out num, default(ReadOnlySpan<char>), null))
			{
				this.m_ChunkLength += num;
				return this;
			}
			return this.Append(value.ToString());
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x00088905 File Offset: 0x00086B05
		public StringBuilder Append([Nullable(2)] object value)
		{
			if (value != null)
			{
				return this.Append(value.ToString());
			}
			return this;
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00088918 File Offset: 0x00086B18
		public StringBuilder Append([Nullable(2)] char[] value)
		{
			if (value != null)
			{
				this.Append(MemoryMarshal.GetArrayDataReference<char>(value), value.Length);
			}
			return this;
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x0008892D File Offset: 0x00086B2D
		[NullableContext(0)]
		[return: Nullable(1)]
		public StringBuilder Append(ReadOnlySpan<char> value)
		{
			this.Append(MemoryMarshal.GetReference<char>(value), value.Length);
			return this;
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00088943 File Offset: 0x00086B43
		[NullableContext(0)]
		[return: Nullable(1)]
		public StringBuilder Append(ReadOnlyMemory<char> value)
		{
			return this.Append(value.Span);
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00007B62 File Offset: 0x00005D62
		public StringBuilder Append([InterpolatedStringHandlerArgument("")] ref StringBuilder.AppendInterpolatedStringHandler handler)
		{
			return this;
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00007B62 File Offset: 0x00005D62
		public StringBuilder Append([Nullable(2)] IFormatProvider provider, [InterpolatedStringHandlerArgument(new string[]
		{
			"",
			"provider"
		})] ref StringBuilder.AppendInterpolatedStringHandler handler)
		{
			return this;
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00088952 File Offset: 0x00086B52
		public StringBuilder AppendLine([InterpolatedStringHandlerArgument("")] ref StringBuilder.AppendInterpolatedStringHandler handler)
		{
			return this.AppendLine();
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00088952 File Offset: 0x00086B52
		public StringBuilder AppendLine([Nullable(2)] IFormatProvider provider, [InterpolatedStringHandlerArgument(new string[]
		{
			"",
			"provider"
		})] ref StringBuilder.AppendInterpolatedStringHandler handler)
		{
			return this.AppendLine();
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x0008895A File Offset: 0x00086B5A
		public StringBuilder AppendJoin([Nullable(2)] string separator, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			if (separator == null)
			{
				separator = string.Empty;
			}
			return this.AppendJoinCore<object>(separator.GetRawStringData(), separator.Length, values);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00088982 File Offset: 0x00086B82
		public StringBuilder AppendJoin([Nullable(2)] string separator, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> values)
		{
			if (separator == null)
			{
				separator = string.Empty;
			}
			return this.AppendJoinCore<object>(separator.GetRawStringData(), separator.Length, values);
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x000889A1 File Offset: 0x00086BA1
		public StringBuilder AppendJoin<[Nullable(2)] T>([Nullable(2)] string separator, IEnumerable<T> values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			if (separator == null)
			{
				separator = string.Empty;
			}
			return this.AppendJoinCore<T>(separator.GetRawStringData(), separator.Length, values);
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x000889C9 File Offset: 0x00086BC9
		public StringBuilder AppendJoin([Nullable(2)] string separator, [Nullable(new byte[]
		{
			1,
			2
		})] params string[] values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			if (separator == null)
			{
				separator = string.Empty;
			}
			return this.AppendJoinCore<string>(separator.GetRawStringData(), separator.Length, values);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x000889F1 File Offset: 0x00086BF1
		public StringBuilder AppendJoin([Nullable(2)] string separator, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<string> values)
		{
			if (separator == null)
			{
				separator = string.Empty;
			}
			return this.AppendJoinCore<string>(separator.GetRawStringData(), separator.Length, values);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00088A10 File Offset: 0x00086C10
		public StringBuilder AppendJoin(char separator, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return this.AppendJoinCore<object>(ref separator, 1, values);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00088A2A File Offset: 0x00086C2A
		public StringBuilder AppendJoin(char separator, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> values)
		{
			return this.AppendJoinCore<object>(ref separator, 1, values);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00088A36 File Offset: 0x00086C36
		public StringBuilder AppendJoin<[Nullable(2)] T>(char separator, IEnumerable<T> values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return this.AppendJoinCore<T>(ref separator, 1, values);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00088A4B File Offset: 0x00086C4B
		public StringBuilder AppendJoin(char separator, [Nullable(new byte[]
		{
			1,
			2
		})] params string[] values)
		{
			if (values == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.values);
			}
			return this.AppendJoinCore<string>(ref separator, 1, values);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00088A65 File Offset: 0x00086C65
		public StringBuilder AppendJoin(char separator, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<string> values)
		{
			return this.AppendJoinCore<string>(ref separator, 1, values);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x00088A74 File Offset: 0x00086C74
		private StringBuilder AppendJoinCore<T>(ref char separator, int separatorLength, IEnumerable<T> values)
		{
			using (IEnumerator<T> enumerator = values.GetEnumerator())
			{
				if (!enumerator.MoveNext())
				{
					return this;
				}
				T t = enumerator.Current;
				if (t != null)
				{
					this.Append(t.ToString());
				}
				while (enumerator.MoveNext())
				{
					this.Append(ref separator, separatorLength);
					t = enumerator.Current;
					if (t != null)
					{
						this.Append(t.ToString());
					}
				}
			}
			return this;
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x00088B0C File Offset: 0x00086D0C
		private unsafe StringBuilder AppendJoinCore<T>(ref char separator, int separatorLength, ReadOnlySpan<T> values)
		{
			if (values.IsEmpty)
			{
				return this;
			}
			if (*values[0] != null)
			{
				T t = *values[0];
				this.Append(t.ToString());
			}
			for (int i = 1; i < values.Length; i++)
			{
				this.Append(ref separator, separatorLength);
				if (*values[i] != null)
				{
					T t = *values[i];
					this.Append(t.ToString());
				}
			}
			return this;
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x00088BAB File Offset: 0x00086DAB
		public StringBuilder Insert(int index, [Nullable(2)] string value)
		{
			if (index > this.Length)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (value != null)
			{
				this.Insert(index, value.GetRawStringData(), value.Length);
			}
			return this;
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00088BDD File Offset: 0x00086DDD
		public StringBuilder Insert(int index, bool value)
		{
			return this.Insert(index, value.ToString().AsSpan(), 1);
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00088BF3 File Offset: 0x00086DF3
		[CLSCompliant(false)]
		public StringBuilder Insert(int index, sbyte value)
		{
			return this.InsertSpanFormattable<sbyte>(index, value);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00088BFD File Offset: 0x00086DFD
		public StringBuilder Insert(int index, byte value)
		{
			return this.InsertSpanFormattable<byte>(index, value);
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x00088C07 File Offset: 0x00086E07
		public StringBuilder Insert(int index, short value)
		{
			return this.InsertSpanFormattable<short>(index, value);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00088C11 File Offset: 0x00086E11
		public StringBuilder Insert(int index, char value)
		{
			if (index > this.Length)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			this.Insert(index, ref value, 1);
			return this;
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00088C37 File Offset: 0x00086E37
		public StringBuilder Insert(int index, [Nullable(2)] char[] value)
		{
			if (index > this.Length)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (value != null)
			{
				this.Insert(index, MemoryMarshal.GetArrayDataReference<char>(value), value.Length);
			}
			return this;
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x00088C68 File Offset: 0x00086E68
		public StringBuilder Insert(int index, [Nullable(2)] char[] value, int startIndex, int charCount)
		{
			int length = this.Length;
			if (index > length)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (value == null)
			{
				if (startIndex == 0 && charCount == 0)
				{
					return this;
				}
				ArgumentNullException.Throw("value");
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(startIndex, "startIndex");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(charCount, "charCount");
			if (startIndex > value.Length - charCount)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (charCount > 0)
			{
				this.Insert(index, ref value[startIndex], charCount);
			}
			return this;
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x00088CEC File Offset: 0x00086EEC
		public StringBuilder Insert(int index, int value)
		{
			return this.InsertSpanFormattable<int>(index, value);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00088CF6 File Offset: 0x00086EF6
		public StringBuilder Insert(int index, long value)
		{
			return this.InsertSpanFormattable<long>(index, value);
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00088D00 File Offset: 0x00086F00
		public StringBuilder Insert(int index, float value)
		{
			return this.InsertSpanFormattable<float>(index, value);
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00088D0A File Offset: 0x00086F0A
		public StringBuilder Insert(int index, double value)
		{
			return this.InsertSpanFormattable<double>(index, value);
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00088D14 File Offset: 0x00086F14
		public StringBuilder Insert(int index, decimal value)
		{
			return this.InsertSpanFormattable<decimal>(index, value);
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00088D1E File Offset: 0x00086F1E
		[CLSCompliant(false)]
		public StringBuilder Insert(int index, ushort value)
		{
			return this.InsertSpanFormattable<ushort>(index, value);
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00088D28 File Offset: 0x00086F28
		[CLSCompliant(false)]
		public StringBuilder Insert(int index, uint value)
		{
			return this.InsertSpanFormattable<uint>(index, value);
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00088D32 File Offset: 0x00086F32
		[CLSCompliant(false)]
		public StringBuilder Insert(int index, ulong value)
		{
			return this.InsertSpanFormattable<ulong>(index, value);
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x00088D3C File Offset: 0x00086F3C
		public StringBuilder Insert(int index, [Nullable(2)] object value)
		{
			if (value != null)
			{
				return this.Insert(index, value.ToString(), 1);
			}
			return this;
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x00088D51 File Offset: 0x00086F51
		[NullableContext(0)]
		[return: Nullable(1)]
		public StringBuilder Insert(int index, ReadOnlySpan<char> value)
		{
			if (index > this.Length)
			{
				throw new ArgumentOutOfRangeException("index", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (value.Length != 0)
			{
				this.Insert(index, MemoryMarshal.GetReference<char>(value), value.Length);
			}
			return this;
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00088D8C File Offset: 0x00086F8C
		private unsafe StringBuilder InsertSpanFormattable<T>(int index, T value) where T : ISpanFormattable
		{
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
			ref T ptr = ref value;
			if (default(T) == null)
			{
				T t = value;
				ptr = ref t;
			}
			int length;
			if (ptr.TryFormat(destination, out length, default(ReadOnlySpan<char>), null))
			{
				return this.Insert(index, destination.Slice(0, length), 1);
			}
			return this.Insert(index, value.ToString(), 1);
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00088E0C File Offset: 0x0008700C
		public StringBuilder AppendFormat([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			return this.AppendFormat(null, format, new ReadOnlySpan<object>(ref arg0));
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00088E20 File Offset: 0x00087020
		public StringBuilder AppendFormat([StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0, [Nullable(2)] object arg1)
		{
			TwoObjects twoObjects = new TwoObjects(arg0, arg1);
			return this.AppendFormat(null, format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<TwoObjects, object>(twoObjects, 2));
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00088E48 File Offset: 0x00087048
		[NullableContext(2)]
		[return: Nullable(1)]
		public StringBuilder AppendFormat([Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
		{
			ThreeObjects threeObjects = new ThreeObjects(arg0, arg1, arg2);
			return this.AppendFormat(null, format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<ThreeObjects, object>(threeObjects, 3));
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00088E70 File Offset: 0x00087070
		public StringBuilder AppendFormat([StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			if (args == null)
			{
				ArgumentNullException.Throw((format == null) ? "format" : "args");
			}
			return this.AppendFormat(null, format, args);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00088E92 File Offset: 0x00087092
		public StringBuilder AppendFormat([StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> args)
		{
			return this.AppendFormat(null, format, args);
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00088E9D File Offset: 0x0008709D
		public StringBuilder AppendFormat([Nullable(2)] IFormatProvider provider, [StringSyntax("CompositeFormat")] string format, [Nullable(2)] object arg0)
		{
			return this.AppendFormat(provider, format, new ReadOnlySpan<object>(ref arg0));
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00088EB0 File Offset: 0x000870B0
		[NullableContext(2)]
		[return: Nullable(1)]
		public StringBuilder AppendFormat(IFormatProvider provider, [Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1)
		{
			TwoObjects twoObjects = new TwoObjects(arg0, arg1);
			return this.AppendFormat(provider, format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<TwoObjects, object>(twoObjects, 2));
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00088ED8 File Offset: 0x000870D8
		[NullableContext(2)]
		[return: Nullable(1)]
		public StringBuilder AppendFormat(IFormatProvider provider, [Nullable(1)] [StringSyntax("CompositeFormat")] string format, object arg0, object arg1, object arg2)
		{
			ThreeObjects threeObjects = new ThreeObjects(arg0, arg1, arg2);
			return this.AppendFormat(provider, format, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<ThreeObjects, object>(threeObjects, 3));
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x00088F01 File Offset: 0x00087101
		public StringBuilder AppendFormat([Nullable(2)] IFormatProvider provider, [StringSyntax("CompositeFormat")] string format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			if (args == null)
			{
				ArgumentNullException.Throw((format == null) ? "format" : "args");
			}
			return this.AppendFormat(provider, format, args);
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00088F28 File Offset: 0x00087128
		public unsafe StringBuilder AppendFormat([Nullable(2)] IFormatProvider provider, [StringSyntax("CompositeFormat")] string format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			ICustomFormatter customFormatter = (ICustomFormatter)((provider != null) ? provider.GetFormat(typeof(ICustomFormatter)) : null);
			int i = 0;
			while (i < format.Length)
			{
				ReadOnlySpan<char> readOnlySpan = format.AsSpan(i);
				int num = readOnlySpan.IndexOfAny('{', '}');
				if (num < 0)
				{
					this.Append(readOnlySpan);
					return this;
				}
				this.Append(readOnlySpan.Slice(0, num));
				i += num;
				char c = format[i];
				char c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
				if (c == c2)
				{
					this.Append(c2);
					i++;
				}
				else
				{
					if (c != '{')
					{
						ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_UnexpectedClosingBrace);
					}
					int num2 = 0;
					bool flag = false;
					ReadOnlySpan<char> readOnlySpan2 = default(ReadOnlySpan<char>);
					int num3 = (int)(c2 - '0');
					if (num3 >= 10)
					{
						ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_ExpectedAsciiDigit);
					}
					c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
					if (c2 != '}')
					{
						while (char.IsAsciiDigit(c2))
						{
							if (num3 >= 1000000)
							{
								break;
							}
							num3 = num3 * 10 + (int)c2 - 48;
							c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
						}
						while (c2 == ' ')
						{
							c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
						}
						if (c2 == ',')
						{
							do
							{
								c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
							}
							while (c2 == ' ');
							if (c2 == '-')
							{
								flag = true;
								c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
							}
							num2 = (int)(c2 - '0');
							if (num2 >= 10)
							{
								ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_ExpectedAsciiDigit);
							}
							c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
							while (char.IsAsciiDigit(c2))
							{
								if (num2 >= 1000000)
								{
									break;
								}
								num2 = num2 * 10 + (int)c2 - 48;
								c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
							}
							while (c2 == ' ')
							{
								c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
							}
						}
						if (c2 != '}')
						{
							if (c2 != ':')
							{
								ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_UnclosedFormatItem);
							}
							int num4 = i;
							for (;;)
							{
								c2 = StringBuilder.<AppendFormat>g__MoveNext|116_0(format, ref i);
								if (c2 == '}')
								{
									break;
								}
								if (c2 == '{')
								{
									ThrowHelper.ThrowFormatInvalidString(i, ExceptionResource.Format_UnclosedFormatItem);
								}
							}
							num4++;
							readOnlySpan2 = format.AsSpan(num4, i - num4);
						}
					}
					i++;
					string text = null;
					string text2 = null;
					if (num3 >= args.Length)
					{
						ThrowHelper.ThrowFormatIndexOutOfRange();
					}
					object obj = *args[num3];
					if (customFormatter != null)
					{
						if (!readOnlySpan2.IsEmpty)
						{
							text2 = new string(readOnlySpan2);
						}
						text = customFormatter.Format(text2, obj, provider);
					}
					if (text == null)
					{
						if (flag || num2 == 0)
						{
							ISpanFormattable spanFormattable = obj as ISpanFormattable;
							int num5;
							if (spanFormattable != null && spanFormattable.TryFormat(this.RemainingCurrentChunk, out num5, readOnlySpan2, provider))
							{
								if (num5 > this.RemainingCurrentChunk.Length)
								{
									ThrowHelper.ThrowFormatInvalidString();
								}
								this.m_ChunkLength += num5;
								if (flag && num2 > num5)
								{
									this.Append(' ', num2 - num5);
									continue;
								}
								continue;
							}
						}
						IFormattable formattable = obj as IFormattable;
						if (formattable != null)
						{
							if (readOnlySpan2.Length != 0 && text2 == null)
							{
								text2 = new string(readOnlySpan2);
							}
							text = formattable.ToString(text2, provider);
						}
						else
						{
							text = ((obj != null) ? obj.ToString() : null);
						}
						if (text == null)
						{
							text = string.Empty;
						}
					}
					if (num2 <= text.Length)
					{
						this.Append(text);
					}
					else if (flag)
					{
						this.Append(text);
						this.Append(' ', num2 - text.Length);
					}
					else
					{
						this.Append(' ', num2 - text.Length);
						this.Append(text);
					}
				}
			}
			return this;
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00089264 File Offset: 0x00087464
		public StringBuilder AppendFormat<[Nullable(2)] TArg0>([Nullable(2)] IFormatProvider provider, CompositeFormat format, TArg0 arg0)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(1);
			return this.AppendFormat<TArg0, int, int>(provider, format, arg0, 0, 0, default(ReadOnlySpan<object>));
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00089298 File Offset: 0x00087498
		public StringBuilder AppendFormat<[Nullable(2)] TArg0, [Nullable(2)] TArg1>([Nullable(2)] IFormatProvider provider, CompositeFormat format, TArg0 arg0, TArg1 arg1)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(2);
			return this.AppendFormat<TArg0, TArg1, int>(provider, format, arg0, arg1, 0, default(ReadOnlySpan<object>));
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x000892CC File Offset: 0x000874CC
		public StringBuilder AppendFormat<[Nullable(2)] TArg0, [Nullable(2)] TArg1, [Nullable(2)] TArg2>([Nullable(2)] IFormatProvider provider, CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(3);
			return this.AppendFormat<TArg0, TArg1, TArg2>(provider, format, arg0, arg1, arg2, default(ReadOnlySpan<object>));
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x00089301 File Offset: 0x00087501
		public StringBuilder AppendFormat([Nullable(2)] IFormatProvider provider, CompositeFormat format, [Nullable(new byte[]
		{
			1,
			2
		})] params object[] args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			ArgumentNullException.ThrowIfNull(args, "args");
			return this.AppendFormat(provider, format, args);
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x00089328 File Offset: 0x00087528
		public unsafe StringBuilder AppendFormat([Nullable(2)] IFormatProvider provider, CompositeFormat format, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			2
		})] ReadOnlySpan<object> args)
		{
			ArgumentNullException.ThrowIfNull(format, "format");
			format.ValidateNumberOfArgs(args.Length);
			StringBuilder result;
			switch (args.Length)
			{
			case 0:
				result = this.AppendFormat<int, int, int>(provider, format, 0, 0, 0, args);
				break;
			case 1:
				result = this.AppendFormat<object, int, int>(provider, format, *args[0], 0, 0, args);
				break;
			case 2:
				result = this.AppendFormat<object, object, int>(provider, format, *args[0], *args[1], 0, args);
				break;
			default:
				result = this.AppendFormat<object, object, object>(provider, format, *args[0], *args[1], *args[2], args);
				break;
			}
			return result;
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000893D4 File Offset: 0x000875D4
		private unsafe StringBuilder AppendFormat<TArg0, TArg1, TArg2>(IFormatProvider provider, CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2, ReadOnlySpan<object> args)
		{
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(format._literalLength, format._formattedCount, this, provider);
			foreach (ValueTuple<string, int, int, string> valueTuple in format._segments)
			{
				string item = valueTuple.Item1;
				if (item != null)
				{
					appendInterpolatedStringHandler.AppendLiteral(item);
				}
				else
				{
					int item2 = valueTuple.Item2;
					switch (item2)
					{
					case 0:
						appendInterpolatedStringHandler.AppendFormatted<TArg0>(arg0, valueTuple.Item3, valueTuple.Item4);
						break;
					case 1:
						appendInterpolatedStringHandler.AppendFormatted<TArg1>(arg1, valueTuple.Item3, valueTuple.Item4);
						break;
					case 2:
						appendInterpolatedStringHandler.AppendFormatted<TArg2>(arg2, valueTuple.Item3, valueTuple.Item4);
						break;
					default:
						appendInterpolatedStringHandler.AppendFormatted(*args[item2], valueTuple.Item3, valueTuple.Item4);
						break;
					}
				}
			}
			return this.Append(ref appendInterpolatedStringHandler);
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000894B6 File Offset: 0x000876B6
		public StringBuilder Replace(string oldValue, [Nullable(2)] string newValue)
		{
			return this.Replace(oldValue, newValue, 0, this.Length);
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000894C7 File Offset: 0x000876C7
		[NullableContext(0)]
		[return: Nullable(1)]
		public StringBuilder Replace(ReadOnlySpan<char> oldValue, ReadOnlySpan<char> newValue)
		{
			return this.Replace(oldValue, newValue, 0, this.Length);
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000894D8 File Offset: 0x000876D8
		[NullableContext(2)]
		public bool Equals([NotNullWhen(true)] StringBuilder sb)
		{
			if (sb == null)
			{
				return false;
			}
			if (this.Length != sb.Length)
			{
				return false;
			}
			if (sb == this)
			{
				return true;
			}
			StringBuilder stringBuilder = this;
			int i = stringBuilder.m_ChunkLength;
			StringBuilder stringBuilder2 = sb;
			int j = stringBuilder2.m_ChunkLength;
			for (;;)
			{
				IL_2D:
				i--;
				j--;
				while (i < 0)
				{
					stringBuilder = stringBuilder.m_ChunkPrevious;
					if (stringBuilder != null)
					{
						i = stringBuilder.m_ChunkLength + i;
					}
					else
					{
						IL_63:
						while (j < 0)
						{
							stringBuilder2 = stringBuilder2.m_ChunkPrevious;
							if (stringBuilder2 == null)
							{
								break;
							}
							j = stringBuilder2.m_ChunkLength + j;
						}
						if (i < 0)
						{
							goto Block_7;
						}
						if (j < 0)
						{
							return false;
						}
						if (stringBuilder.m_ChunkChars[i] != stringBuilder2.m_ChunkChars[j])
						{
							return false;
						}
						goto IL_2D;
					}
				}
				goto IL_63;
			}
			Block_7:
			return j < 0;
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x00089570 File Offset: 0x00087770
		[NullableContext(0)]
		public bool Equals(ReadOnlySpan<char> span)
		{
			if (span.Length != this.Length)
			{
				return false;
			}
			StringBuilder stringBuilder = this;
			int num = 0;
			for (;;)
			{
				int chunkLength = stringBuilder.m_ChunkLength;
				num += chunkLength;
				if (!new ReadOnlySpan<char>(stringBuilder.m_ChunkChars, 0, chunkLength).EqualsOrdinal(span.Slice(span.Length - num, chunkLength)))
				{
					break;
				}
				stringBuilder = stringBuilder.m_ChunkPrevious;
				if (stringBuilder == null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000895CF File Offset: 0x000877CF
		public StringBuilder Replace(string oldValue, [Nullable(2)] string newValue, int startIndex, int count)
		{
			ArgumentException.ThrowIfNullOrEmpty(oldValue, "oldValue");
			return this.Replace(oldValue.AsSpan(), newValue.AsSpan(), startIndex, count);
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000895F4 File Offset: 0x000877F4
		[NullableContext(0)]
		[return: Nullable(1)]
		public unsafe StringBuilder Replace(ReadOnlySpan<char> oldValue, ReadOnlySpan<char> newValue, int startIndex, int count)
		{
			int length = this.Length;
			if (startIndex > length)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (count < 0 || startIndex > length - count)
			{
				throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (oldValue.Length == 0)
			{
				throw new ArgumentException(SR.Arg_EmptySpan, "oldValue");
			}
			Span<int> initialSpan = new Span<int>(stackalloc byte[(UIntPtr)512], 128);
			ValueListBuilder<int> valueListBuilder = new ValueListBuilder<int>(initialSpan);
			StringBuilder stringBuilder = this.FindChunkForIndex(startIndex);
			int num = startIndex - stringBuilder.m_ChunkOffset;
			IL_1CD:
			while (count > 0)
			{
				ReadOnlySpan<char> span = stringBuilder.m_ChunkChars.AsSpan(num, Math.Min(stringBuilder.m_ChunkLength - num, count));
				while (oldValue.Length <= span.Length)
				{
					int num2 = span.IndexOf(oldValue);
					if (num2 >= 0)
					{
						num += num2;
						valueListBuilder.Append(num);
						span = span.Slice(num2 + oldValue.Length);
						num += oldValue.Length;
						count -= num2 + oldValue.Length;
						if (count != 0)
						{
							continue;
						}
					}
					else
					{
						int num3 = span.Length - (oldValue.Length - 1);
						num += num3;
						count -= num3;
					}
					IL_15F:
					while (num < stringBuilder.m_ChunkLength && count > 0)
					{
						if (this.StartsWith(stringBuilder, num, count, oldValue))
						{
							valueListBuilder.Append(num);
							num += oldValue.Length;
							count -= oldValue.Length;
						}
						else
						{
							num++;
							count--;
						}
					}
					int num4 = num + stringBuilder.m_ChunkOffset;
					if (valueListBuilder.Length != 0)
					{
						this.ReplaceAllInChunk(valueListBuilder.AsSpan(), stringBuilder, oldValue.Length, newValue);
						num4 += (newValue.Length - oldValue.Length) * valueListBuilder.Length;
						valueListBuilder.Length = 0;
					}
					stringBuilder = this.FindChunkForIndex(num4);
					num = num4 - stringBuilder.m_ChunkOffset;
					goto IL_1CD;
				}
				goto IL_15F;
			}
			valueListBuilder.Dispose();
			return this;
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000897DE File Offset: 0x000879DE
		public StringBuilder Replace(char oldChar, char newChar)
		{
			return this.Replace(oldChar, newChar, 0, this.Length);
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000897F0 File Offset: 0x000879F0
		public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
		{
			int length = this.Length;
			if (startIndex > length)
			{
				throw new ArgumentOutOfRangeException("startIndex", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			if (count < 0 || startIndex > length - count)
			{
				throw new ArgumentOutOfRangeException("count", SR.ArgumentOutOfRange_IndexMustBeLessOrEqual);
			}
			int num = startIndex + count;
			StringBuilder stringBuilder = this;
			for (;;)
			{
				int num2 = num - stringBuilder.m_ChunkOffset;
				int num3 = startIndex - stringBuilder.m_ChunkOffset;
				if (num2 >= 0)
				{
					int num4 = Math.Max(num3, 0);
					int num5 = Math.Min(stringBuilder.m_ChunkLength, num2);
					stringBuilder.m_ChunkChars.AsSpan(num4, num5 - num4).Replace(oldChar, newChar);
				}
				if (num3 >= 0)
				{
					break;
				}
				stringBuilder = stringBuilder.m_ChunkPrevious;
			}
			return this;
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x00089892 File Offset: 0x00087A92
		[NullableContext(0)]
		[CLSCompliant(false)]
		[return: Nullable(1)]
		public unsafe StringBuilder Append(char* value, int valueCount)
		{
			ArgumentOutOfRangeException.ThrowIfNegative<int>(valueCount, "valueCount");
			this.Append(ref *value, valueCount);
			return this;
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000898A8 File Offset: 0x00087AA8
		private unsafe void Append(ref char value, int valueCount)
		{
			if (valueCount != 0)
			{
				char[] chunkChars = this.m_ChunkChars;
				int chunkLength = this.m_ChunkLength;
				if (chunkLength + valueCount <= chunkChars.Length)
				{
					ref char ptr = ref Unsafe.Add<char>(MemoryMarshal.GetArrayDataReference<char>(chunkChars), chunkLength);
					if (valueCount <= 2)
					{
						ptr = value;
						if (valueCount == 2)
						{
							*Unsafe.Add<char>(ref ptr, 1) = *Unsafe.Add<char>(ref value, 1);
						}
					}
					else
					{
						Buffer.Memmove<char>(ref ptr, ref value, (UIntPtr)((IntPtr)valueCount));
					}
					this.m_ChunkLength = chunkLength + valueCount;
					return;
				}
				this.AppendWithExpansion(ref value, valueCount);
			}
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x00089914 File Offset: 0x00087B14
		private void AppendWithExpansion(ref char value, int valueCount)
		{
			int num = this.Length + valueCount;
			if (num > this.m_MaxCapacity || num < valueCount)
			{
				throw new ArgumentOutOfRangeException("valueCount", SR.ArgumentOutOfRange_LengthGreaterThanCapacity);
			}
			int num2 = this.m_ChunkChars.Length - this.m_ChunkLength;
			if (num2 > 0)
			{
				new ReadOnlySpan<char>(ref value, num2).CopyTo(this.m_ChunkChars.AsSpan(this.m_ChunkLength));
				this.m_ChunkLength = this.m_ChunkChars.Length;
			}
			int num3 = valueCount - num2;
			this.ExpandByABlock(num3);
			new ReadOnlySpan<char>(Unsafe.Add<char>(ref value, num2), num3).CopyTo(this.m_ChunkChars);
			this.m_ChunkLength = num3;
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000899BC File Offset: 0x00087BBC
		private void Insert(int index, ref char value, int valueCount)
		{
			if (valueCount > 0)
			{
				StringBuilder stringBuilder;
				int num;
				this.MakeRoom(index, valueCount, out stringBuilder, out num, false);
				this.ReplaceInPlaceAtChunk(ref stringBuilder, ref num, ref value, valueCount);
			}
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000899E8 File Offset: 0x00087BE8
		private unsafe void ReplaceAllInChunk(ReadOnlySpan<int> replacements, StringBuilder sourceChunk, int removeCount, ReadOnlySpan<char> value)
		{
			long num = (long)(value.Length - removeCount) * (long)replacements.Length;
			int num2 = (int)num;
			if ((long)num2 != num)
			{
				throw new OutOfMemoryException();
			}
			StringBuilder stringBuilder = sourceChunk;
			int num3 = *replacements[0];
			if (num2 > 0)
			{
				this.MakeRoom(stringBuilder.m_ChunkOffset + num3, num2, out stringBuilder, out num3, true);
			}
			int num4 = 0;
			for (;;)
			{
				this.ReplaceInPlaceAtChunk(ref stringBuilder, ref num3, MemoryMarshal.GetReference<char>(value), value.Length);
				int num5 = *replacements[num4] + removeCount;
				num4++;
				if ((ulong)num4 >= (ulong)((long)replacements.Length))
				{
					break;
				}
				int num6 = *replacements[num4];
				if (num2 != 0)
				{
					this.ReplaceInPlaceAtChunk(ref stringBuilder, ref num3, ref sourceChunk.m_ChunkChars[num5], num6 - num5);
				}
				else
				{
					num3 += num6 - num5;
				}
			}
			if (num2 < 0)
			{
				this.Remove(stringBuilder.m_ChunkOffset + num3, -num2, out stringBuilder, out num3);
			}
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00089AC8 File Offset: 0x00087CC8
		private unsafe bool StartsWith(StringBuilder chunk, int indexInChunk, int count, ReadOnlySpan<char> value)
		{
			for (int i = 0; i < value.Length; i++)
			{
				if (count == 0)
				{
					return false;
				}
				if (indexInChunk >= chunk.m_ChunkLength)
				{
					chunk = this.Next(chunk);
					if (chunk == null)
					{
						return false;
					}
					indexInChunk = 0;
				}
				if (*value[i] != (ushort)chunk.m_ChunkChars[indexInChunk])
				{
					return false;
				}
				indexInChunk++;
				count--;
			}
			return true;
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00089B28 File Offset: 0x00087D28
		private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, ref char value, int count)
		{
			if (count != 0)
			{
				for (;;)
				{
					int num = Math.Min(chunk.m_ChunkLength - indexInChunk, count);
					new ReadOnlySpan<char>(ref value, num).CopyTo(chunk.m_ChunkChars.AsSpan(indexInChunk));
					indexInChunk += num;
					if (indexInChunk >= chunk.m_ChunkLength)
					{
						chunk = this.Next(chunk);
						indexInChunk = 0;
					}
					count -= num;
					if (count == 0)
					{
						break;
					}
					value = Unsafe.Add<char>(ref value, num);
				}
			}
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00089B9C File Offset: 0x00087D9C
		private StringBuilder FindChunkForIndex(int index)
		{
			StringBuilder stringBuilder = this;
			while (stringBuilder.m_ChunkOffset > index)
			{
				stringBuilder = stringBuilder.m_ChunkPrevious;
			}
			return stringBuilder;
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x00089BBE File Offset: 0x00087DBE
		[Nullable(0)]
		private Span<char> RemainingCurrentChunk
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return new Span<char>(this.m_ChunkChars, this.m_ChunkLength, this.m_ChunkChars.Length - this.m_ChunkLength);
			}
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x00089BE0 File Offset: 0x00087DE0
		private StringBuilder Next(StringBuilder chunk)
		{
			if (chunk != this)
			{
				return this.FindChunkForIndex(chunk.m_ChunkOffset + chunk.m_ChunkLength);
			}
			return null;
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00089BFC File Offset: 0x00087DFC
		private void ExpandByABlock(int minBlockCharCount)
		{
			if (minBlockCharCount + this.Length > this.m_MaxCapacity || minBlockCharCount + this.Length < minBlockCharCount)
			{
				throw new ArgumentOutOfRangeException("requiredLength", SR.ArgumentOutOfRange_SmallCapacity);
			}
			int num = Math.Max(minBlockCharCount, Math.Min(this.Length, 8000));
			if (this.m_ChunkOffset + this.m_ChunkLength + num < num)
			{
				throw new OutOfMemoryException();
			}
			char[] chunkChars = GC.AllocateUninitializedArray<char>(num, false);
			this.m_ChunkPrevious = new StringBuilder(this);
			this.m_ChunkOffset += this.m_ChunkLength;
			this.m_ChunkLength = 0;
			this.m_ChunkChars = chunkChars;
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00089C98 File Offset: 0x00087E98
		private StringBuilder(StringBuilder from)
		{
			this.m_ChunkLength = from.m_ChunkLength;
			this.m_ChunkOffset = from.m_ChunkOffset;
			this.m_ChunkChars = from.m_ChunkChars;
			this.m_ChunkPrevious = from.m_ChunkPrevious;
			this.m_MaxCapacity = from.m_MaxCapacity;
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00089CE8 File Offset: 0x00087EE8
		private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars)
		{
			if (count + this.Length > this.m_MaxCapacity || count + this.Length < count)
			{
				throw new ArgumentOutOfRangeException("requiredLength", SR.ArgumentOutOfRange_SmallCapacity);
			}
			chunk = this;
			while (chunk.m_ChunkOffset > index)
			{
				chunk.m_ChunkOffset += count;
				chunk = chunk.m_ChunkPrevious;
			}
			indexInChunk = index - chunk.m_ChunkOffset;
			if (!doNotMoveFollowingChars && chunk.m_ChunkLength <= 32 && chunk.m_ChunkChars.Length - chunk.m_ChunkLength >= count)
			{
				int i = chunk.m_ChunkLength;
				while (i > indexInChunk)
				{
					i--;
					chunk.m_ChunkChars[i + count] = chunk.m_ChunkChars[i];
				}
				chunk.m_ChunkLength += count;
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(Math.Max(count, 16), chunk.m_MaxCapacity, chunk.m_ChunkPrevious);
			stringBuilder.m_ChunkLength = count;
			int num = Math.Min(count, indexInChunk);
			if (num > 0)
			{
				new ReadOnlySpan<char>(chunk.m_ChunkChars, 0, num).CopyTo(stringBuilder.m_ChunkChars);
				int num2 = indexInChunk - num;
				if (num2 >= 0)
				{
					new ReadOnlySpan<char>(chunk.m_ChunkChars, num, num2).CopyTo(chunk.m_ChunkChars);
					indexInChunk = num2;
				}
			}
			chunk.m_ChunkPrevious = stringBuilder;
			chunk.m_ChunkOffset += count;
			if (num < count)
			{
				chunk = stringBuilder;
				indexInChunk = num;
			}
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00089E54 File Offset: 0x00088054
		private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
		{
			this.m_ChunkChars = GC.AllocateUninitializedArray<char>(size, false);
			this.m_MaxCapacity = maxCapacity;
			this.m_ChunkPrevious = previousBlock;
			if (previousBlock != null)
			{
				this.m_ChunkOffset = previousBlock.m_ChunkOffset + previousBlock.m_ChunkLength;
			}
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00089E90 File Offset: 0x00088090
		private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk)
		{
			int num = startIndex + count;
			chunk = this;
			StringBuilder stringBuilder = null;
			int num2 = 0;
			for (;;)
			{
				if (num - chunk.m_ChunkOffset >= 0)
				{
					if (stringBuilder == null)
					{
						stringBuilder = chunk;
						num2 = num - stringBuilder.m_ChunkOffset;
					}
					if (startIndex - chunk.m_ChunkOffset >= 0)
					{
						break;
					}
				}
				else
				{
					chunk.m_ChunkOffset -= count;
				}
				chunk = chunk.m_ChunkPrevious;
			}
			indexInChunk = startIndex - chunk.m_ChunkOffset;
			int num3 = indexInChunk;
			int length = stringBuilder.m_ChunkLength - num2;
			if (stringBuilder != chunk)
			{
				num3 = 0;
				chunk.m_ChunkLength = indexInChunk;
				stringBuilder.m_ChunkPrevious = chunk;
				stringBuilder.m_ChunkOffset = chunk.m_ChunkOffset + chunk.m_ChunkLength;
				if (indexInChunk == 0)
				{
					stringBuilder.m_ChunkPrevious = chunk.m_ChunkPrevious;
					chunk = stringBuilder;
				}
			}
			stringBuilder.m_ChunkLength -= num2 - num3;
			if (num3 != num2)
			{
				new ReadOnlySpan<char>(stringBuilder.m_ChunkChars, num2, length).CopyTo(stringBuilder.m_ChunkChars.AsSpan(num3));
			}
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x00089F7F File Offset: 0x0008817F
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char <AppendFormat>g__MoveNext|116_0(string format, ref int pos)
		{
			pos++;
			if (pos >= format.Length)
			{
				ThrowHelper.ThrowFormatInvalidString(pos, ExceptionResource.Format_UnclosedFormatItem);
			}
			return format[pos];
		}

		// Token: 0x04000797 RID: 1943
		internal char[] m_ChunkChars;

		// Token: 0x04000798 RID: 1944
		internal StringBuilder m_ChunkPrevious;

		// Token: 0x04000799 RID: 1945
		internal int m_ChunkLength;

		// Token: 0x0400079A RID: 1946
		internal int m_ChunkOffset;

		// Token: 0x0400079B RID: 1947
		internal int m_MaxCapacity;

		// Token: 0x02000238 RID: 568
		[NullableContext(0)]
		public struct ChunkEnumerator
		{
			// Token: 0x06002BD5 RID: 11221 RVA: 0x00089FA2 File Offset: 0x000881A2
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StringBuilder.ChunkEnumerator GetEnumerator()
			{
				return this;
			}

			// Token: 0x06002BD6 RID: 11222 RVA: 0x00089FAC File Offset: 0x000881AC
			public bool MoveNext()
			{
				if (this._currentChunk == this._firstChunk)
				{
					return false;
				}
				if (this._manyChunks != null)
				{
					return this._manyChunks.MoveNext(ref this._currentChunk);
				}
				StringBuilder stringBuilder = this._firstChunk;
				while (stringBuilder.m_ChunkPrevious != this._currentChunk)
				{
					stringBuilder = stringBuilder.m_ChunkPrevious;
				}
				this._currentChunk = stringBuilder;
				return true;
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x0008A009 File Offset: 0x00088209
			public ReadOnlyMemory<char> Current
			{
				get
				{
					if (this._currentChunk == null)
					{
						ThrowHelper.ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen();
					}
					return new ReadOnlyMemory<char>(this._currentChunk.m_ChunkChars, 0, this._currentChunk.m_ChunkLength);
				}
			}

			// Token: 0x06002BD8 RID: 11224 RVA: 0x0008A034 File Offset: 0x00088234
			internal ChunkEnumerator(StringBuilder stringBuilder)
			{
				this._firstChunk = stringBuilder;
				this._currentChunk = null;
				this._manyChunks = null;
				int num = StringBuilder.ChunkEnumerator.ChunkCount(stringBuilder);
				if (8 < num)
				{
					this._manyChunks = new StringBuilder.ChunkEnumerator.ManyChunkInfo(stringBuilder, num);
				}
			}

			// Token: 0x06002BD9 RID: 11225 RVA: 0x0008A070 File Offset: 0x00088270
			private static int ChunkCount(StringBuilder stringBuilder)
			{
				int num = 0;
				while (stringBuilder != null)
				{
					num++;
					stringBuilder = stringBuilder.m_ChunkPrevious;
				}
				return num;
			}

			// Token: 0x0400079C RID: 1948
			private readonly StringBuilder _firstChunk;

			// Token: 0x0400079D RID: 1949
			private StringBuilder _currentChunk;

			// Token: 0x0400079E RID: 1950
			private readonly StringBuilder.ChunkEnumerator.ManyChunkInfo _manyChunks;

			// Token: 0x02000239 RID: 569
			private sealed class ManyChunkInfo
			{
				// Token: 0x06002BDA RID: 11226 RVA: 0x0008A094 File Offset: 0x00088294
				public bool MoveNext(ref StringBuilder current)
				{
					int num = this._chunkPos + 1;
					this._chunkPos = num;
					int num2 = num;
					if (this._chunks.Length <= num2)
					{
						return false;
					}
					current = this._chunks[num2];
					return true;
				}

				// Token: 0x06002BDB RID: 11227 RVA: 0x0008A0CB File Offset: 0x000882CB
				public ManyChunkInfo(StringBuilder stringBuilder, int chunkCount)
				{
					this._chunks = new StringBuilder[chunkCount];
					while (0 <= --chunkCount)
					{
						this._chunks[chunkCount] = stringBuilder;
						stringBuilder = stringBuilder.m_ChunkPrevious;
					}
					this._chunkPos = -1;
				}

				// Token: 0x0400079F RID: 1951
				private readonly StringBuilder[] _chunks;

				// Token: 0x040007A0 RID: 1952
				private int _chunkPos;
			}
		}

		// Token: 0x0200023A RID: 570
		[Nullable(0)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[InterpolatedStringHandler]
		public struct AppendInterpolatedStringHandler
		{
			// Token: 0x06002BDC RID: 11228 RVA: 0x0008A102 File Offset: 0x00088302
			public AppendInterpolatedStringHandler(int literalLength, int formattedCount, StringBuilder stringBuilder)
			{
				this._stringBuilder = stringBuilder;
				this._provider = null;
				this._hasCustomFormatter = false;
			}

			// Token: 0x06002BDD RID: 11229 RVA: 0x0008A119 File Offset: 0x00088319
			public AppendInterpolatedStringHandler(int literalLength, int formattedCount, StringBuilder stringBuilder, [Nullable(2)] IFormatProvider provider)
			{
				this._stringBuilder = stringBuilder;
				this._provider = provider;
				this._hasCustomFormatter = (provider != null && DefaultInterpolatedStringHandler.HasCustomFormatter(provider));
			}

			// Token: 0x06002BDE RID: 11230 RVA: 0x0008A13E File Offset: 0x0008833E
			public void AppendLiteral(string value)
			{
				this._stringBuilder.Append(value);
			}

			// Token: 0x06002BDF RID: 11231 RVA: 0x0008A150 File Offset: 0x00088350
			public void AppendFormatted<[Nullable(2)] T>(T value)
			{
				if (this._hasCustomFormatter)
				{
					this.AppendCustomFormatter<T>(value, null);
					return;
				}
				if (!(value is IFormattable))
				{
					if (value != null)
					{
						this._stringBuilder.Append(value.ToString());
					}
					return;
				}
				if (typeof(T).IsEnum)
				{
					int num;
					if (Enum.TryFormatUnconstrained<T>(value, this._stringBuilder.RemainingCurrentChunk, out num, default(ReadOnlySpan<char>)))
					{
						this._stringBuilder.m_ChunkLength += num;
						return;
					}
					this.AppendFormattedWithTempSpace<T>(value, 0, null);
					return;
				}
				else
				{
					if (!(value is ISpanFormattable))
					{
						this._stringBuilder.Append(((IFormattable)((object)value)).ToString(null, this._provider));
						return;
					}
					Span<char> remainingCurrentChunk = this._stringBuilder.RemainingCurrentChunk;
					int num2;
					if (((ISpanFormattable)((object)value)).TryFormat(remainingCurrentChunk, out num2, default(ReadOnlySpan<char>), this._provider))
					{
						if (num2 > remainingCurrentChunk.Length)
						{
							ThrowHelper.ThrowFormatInvalidString();
						}
						this._stringBuilder.m_ChunkLength += num2;
						return;
					}
					this.AppendFormattedWithTempSpace<T>(value, 0, null);
					return;
				}
			}

			// Token: 0x06002BE0 RID: 11232 RVA: 0x0008A27C File Offset: 0x0008847C
			[NullableContext(2)]
			public void AppendFormatted<T>([Nullable(1)] T value, string format)
			{
				if (this._hasCustomFormatter)
				{
					this.AppendCustomFormatter<T>(value, format);
					return;
				}
				if (!(value is IFormattable))
				{
					if (value != null)
					{
						this._stringBuilder.Append(value.ToString());
					}
					return;
				}
				if (typeof(T).IsEnum)
				{
					int num;
					if (Enum.TryFormatUnconstrained<T>(value, this._stringBuilder.RemainingCurrentChunk, out num, format))
					{
						this._stringBuilder.m_ChunkLength += num;
						return;
					}
					this.AppendFormattedWithTempSpace<T>(value, 0, format);
					return;
				}
				else
				{
					if (!(value is ISpanFormattable))
					{
						this._stringBuilder.Append(((IFormattable)((object)value)).ToString(format, this._provider));
						return;
					}
					Span<char> remainingCurrentChunk = this._stringBuilder.RemainingCurrentChunk;
					int num2;
					if (((ISpanFormattable)((object)value)).TryFormat(remainingCurrentChunk, out num2, format, this._provider))
					{
						if (num2 > remainingCurrentChunk.Length)
						{
							ThrowHelper.ThrowFormatInvalidString();
						}
						this._stringBuilder.m_ChunkLength += num2;
						return;
					}
					this.AppendFormattedWithTempSpace<T>(value, 0, format);
					return;
				}
			}

			// Token: 0x06002BE1 RID: 11233 RVA: 0x0008A3A0 File Offset: 0x000885A0
			public void AppendFormatted<[Nullable(2)] T>(T value, int alignment)
			{
				this.AppendFormatted<T>(value, alignment, null);
			}

			// Token: 0x06002BE2 RID: 11234 RVA: 0x0008A3AC File Offset: 0x000885AC
			[NullableContext(2)]
			public void AppendFormatted<T>([Nullable(1)] T value, int alignment, string format)
			{
				if (alignment == 0)
				{
					this.AppendFormatted<T>(value, format);
					return;
				}
				if (alignment < 0)
				{
					int length = this._stringBuilder.Length;
					this.AppendFormatted<T>(value, format);
					int num = -alignment - (this._stringBuilder.Length - length);
					if (num > 0)
					{
						this._stringBuilder.Append(' ', num);
						return;
					}
				}
				else
				{
					this.AppendFormattedWithTempSpace<T>(value, alignment, format);
				}
			}

			// Token: 0x06002BE3 RID: 11235 RVA: 0x0008A40C File Offset: 0x0008860C
			private unsafe void AppendFormattedWithTempSpace<T>(T value, int alignment, string format)
			{
				IFormatProvider provider = this._provider;
				Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)512], 256);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 0, provider, initialBuffer);
				defaultInterpolatedStringHandler.AppendFormatted<T>(value, format);
				this.AppendFormatted(defaultInterpolatedStringHandler.Text, alignment, null);
				defaultInterpolatedStringHandler.Clear();
			}

			// Token: 0x06002BE4 RID: 11236 RVA: 0x0008A45D File Offset: 0x0008865D
			[NullableContext(0)]
			public void AppendFormatted(ReadOnlySpan<char> value)
			{
				this._stringBuilder.Append(value);
			}

			// Token: 0x06002BE5 RID: 11237 RVA: 0x0008A46C File Offset: 0x0008866C
			[NullableContext(0)]
			public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, [Nullable(2)] string format = null)
			{
				if (alignment == 0)
				{
					this._stringBuilder.Append(value);
					return;
				}
				bool flag = false;
				if (alignment < 0)
				{
					flag = true;
					alignment = -alignment;
				}
				int num = alignment - value.Length;
				if (num <= 0)
				{
					this._stringBuilder.Append(value);
					return;
				}
				if (flag)
				{
					this._stringBuilder.Append(value);
					this._stringBuilder.Append(' ', num);
					return;
				}
				this._stringBuilder.Append(' ', num);
				this._stringBuilder.Append(value);
			}

			// Token: 0x06002BE6 RID: 11238 RVA: 0x0008A4EE File Offset: 0x000886EE
			[NullableContext(2)]
			public void AppendFormatted(string value)
			{
				if (!this._hasCustomFormatter)
				{
					this._stringBuilder.Append(value);
					return;
				}
				this.AppendFormatted<string>(value);
			}

			// Token: 0x06002BE7 RID: 11239 RVA: 0x0008A50D File Offset: 0x0008870D
			[NullableContext(2)]
			public void AppendFormatted(string value, int alignment = 0, string format = null)
			{
				this.AppendFormatted<string>(value, alignment, format);
			}

			// Token: 0x06002BE8 RID: 11240 RVA: 0x0008A518 File Offset: 0x00088718
			[NullableContext(2)]
			public void AppendFormatted(object value, int alignment = 0, string format = null)
			{
				this.AppendFormatted<object>(value, alignment, format);
			}

			// Token: 0x06002BE9 RID: 11241 RVA: 0x0008A524 File Offset: 0x00088724
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void AppendCustomFormatter<T>(T value, string format)
			{
				ICustomFormatter customFormatter = (ICustomFormatter)this._provider.GetFormat(typeof(ICustomFormatter));
				if (customFormatter != null)
				{
					this._stringBuilder.Append(customFormatter.Format(format, value, this._provider));
				}
			}

			// Token: 0x040007A1 RID: 1953
			internal readonly StringBuilder _stringBuilder;

			// Token: 0x040007A2 RID: 1954
			private readonly IFormatProvider _provider;

			// Token: 0x040007A3 RID: 1955
			private readonly bool _hasCustomFormatter;
		}
	}
}
