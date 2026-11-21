using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime.Serialization
{
	// Token: 0x02000527 RID: 1319
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SerializationInfo
	{
		// Token: 0x0600489D RID: 18589 RVA: 0x000F13C8 File Offset: 0x000EF5C8
		[CLSCompliant(false)]
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public SerializationInfo(Type type, IFormatterConverter converter)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			ArgumentNullException.ThrowIfNull(converter, "converter");
			this._rootType = type;
			this._rootTypeName = type.FullName;
			this._rootTypeAssemblyName = type.Module.Assembly.FullName;
			this._names = new string[4];
			this._values = new object[4];
			this._types = new Type[4];
			this._nameToIndex = new Dictionary<string, int>();
			this._converter = converter;
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x000F1450 File Offset: 0x000EF650
		[CLSCompliant(false)]
		[Obsolete("Formatter-based serialization is obsolete and should not be used.", DiagnosticId = "SYSLIB0050", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) : this(type, converter)
		{
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x000F145A File Offset: 0x000EF65A
		// (set) Token: 0x060048A0 RID: 18592 RVA: 0x000F1462 File Offset: 0x000EF662
		public string FullTypeName
		{
			get
			{
				return this._rootTypeName;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this._rootTypeName = value;
				this.IsFullTypeNameSetExplicit = true;
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x000F147D File Offset: 0x000EF67D
		// (set) Token: 0x060048A2 RID: 18594 RVA: 0x000F1485 File Offset: 0x000EF685
		public string AssemblyName
		{
			get
			{
				return this._rootTypeAssemblyName;
			}
			set
			{
				ArgumentNullException.ThrowIfNull(value, "value");
				this._rootTypeAssemblyName = value;
				this.IsAssemblyNameSetExplicit = true;
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x000F14A0 File Offset: 0x000EF6A0
		// (set) Token: 0x060048A4 RID: 18596 RVA: 0x000F14A8 File Offset: 0x000EF6A8
		public bool IsFullTypeNameSetExplicit { get; private set; }

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060048A5 RID: 18597 RVA: 0x000F14B1 File Offset: 0x000EF6B1
		// (set) Token: 0x060048A6 RID: 18598 RVA: 0x000F14B9 File Offset: 0x000EF6B9
		public bool IsAssemblyNameSetExplicit { get; private set; }

		// Token: 0x060048A7 RID: 18599 RVA: 0x000F14C4 File Offset: 0x000EF6C4
		public void SetType(Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			if (this._rootType != type)
			{
				this._rootType = type;
				this._rootTypeName = type.FullName;
				this._rootTypeAssemblyName = type.Module.Assembly.FullName;
				this.IsFullTypeNameSetExplicit = false;
				this.IsAssemblyNameSetExplicit = false;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x000F151C File Offset: 0x000EF71C
		public int MemberCount
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x000F1524 File Offset: 0x000EF724
		public Type ObjectType
		{
			get
			{
				return this._rootType;
			}
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x000F152C File Offset: 0x000EF72C
		public SerializationInfoEnumerator GetEnumerator()
		{
			return new SerializationInfoEnumerator(this._names, this._values, this._types, this._count);
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x000F154C File Offset: 0x000EF74C
		private void ExpandArrays()
		{
			int num = this._count * 2;
			if (num < this._count && 2147483647 > this._count)
			{
				num = int.MaxValue;
			}
			string[] array = new string[num];
			object[] array2 = new object[num];
			Type[] array3 = new Type[num];
			Array.Copy(this._names, array, this._count);
			Array.Copy(this._values, array2, this._count);
			Array.Copy(this._types, array3, this._count);
			this._names = array;
			this._values = array2;
			this._types = array3;
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x000F15DE File Offset: 0x000EF7DE
		public void AddValue(string name, [Nullable(2)] object value, Type type)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			ArgumentNullException.ThrowIfNull(type, "type");
			this.AddValueInternal(name, value, type);
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x000F15FF File Offset: 0x000EF7FF
		public void AddValue(string name, [Nullable(2)] object value)
		{
			if (value == null)
			{
				this.AddValue(name, value, typeof(object));
				return;
			}
			this.AddValue(name, value, value.GetType());
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x000F1625 File Offset: 0x000EF825
		public void AddValue(string name, bool value)
		{
			this.AddValue(name, value, typeof(bool));
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x000F163E File Offset: 0x000EF83E
		public void AddValue(string name, char value)
		{
			this.AddValue(name, value, typeof(char));
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x000F1657 File Offset: 0x000EF857
		[CLSCompliant(false)]
		public void AddValue(string name, sbyte value)
		{
			this.AddValue(name, value, typeof(sbyte));
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x000F1670 File Offset: 0x000EF870
		public void AddValue(string name, byte value)
		{
			this.AddValue(name, value, typeof(byte));
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x000F1689 File Offset: 0x000EF889
		public void AddValue(string name, short value)
		{
			this.AddValue(name, value, typeof(short));
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x000F16A2 File Offset: 0x000EF8A2
		[CLSCompliant(false)]
		public void AddValue(string name, ushort value)
		{
			this.AddValue(name, value, typeof(ushort));
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x000F16BB File Offset: 0x000EF8BB
		public void AddValue(string name, int value)
		{
			this.AddValue(name, value, typeof(int));
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x000F16D4 File Offset: 0x000EF8D4
		[CLSCompliant(false)]
		public void AddValue(string name, uint value)
		{
			this.AddValue(name, value, typeof(uint));
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x000F16ED File Offset: 0x000EF8ED
		public void AddValue(string name, long value)
		{
			this.AddValue(name, value, typeof(long));
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x000F1706 File Offset: 0x000EF906
		[CLSCompliant(false)]
		public void AddValue(string name, ulong value)
		{
			this.AddValue(name, value, typeof(ulong));
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x000F171F File Offset: 0x000EF91F
		public void AddValue(string name, float value)
		{
			this.AddValue(name, value, typeof(float));
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x000F1738 File Offset: 0x000EF938
		public void AddValue(string name, double value)
		{
			this.AddValue(name, value, typeof(double));
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x000F1751 File Offset: 0x000EF951
		public void AddValue(string name, decimal value)
		{
			this.AddValue(name, value, typeof(decimal));
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x000F176A File Offset: 0x000EF96A
		public void AddValue(string name, DateTime value)
		{
			this.AddValue(name, value, typeof(DateTime));
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x000F1784 File Offset: 0x000EF984
		internal void AddValueInternal(string name, object value, Type type)
		{
			if (!this._nameToIndex.TryAdd(name, this._count))
			{
				throw new SerializationException(SR.Serialization_SameNameTwice);
			}
			if (this._count >= this._names.Length)
			{
				this.ExpandArrays();
			}
			this._names[this._count] = name;
			this._values[this._count] = value;
			this._types[this._count] = type;
			this._count++;
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x000F1800 File Offset: 0x000EFA00
		internal void UpdateValue(string name, object value, Type type)
		{
			int num = this.FindElement(name);
			if (num < 0)
			{
				this.AddValueInternal(name, value, type);
				return;
			}
			this._values[num] = value;
			this._types[num] = type;
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x000F1838 File Offset: 0x000EFA38
		private int FindElement(string name)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			int result;
			if (this._nameToIndex.TryGetValue(name, out result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x000F1864 File Offset: 0x000EFA64
		private object GetElement(string name, out Type foundType)
		{
			int num = this.FindElement(name);
			if (num == -1)
			{
				throw new SerializationException(SR.Format(SR.Serialization_NotFound, name));
			}
			foundType = this._types[num];
			return this._values[num];
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x000F18A0 File Offset: 0x000EFAA0
		private object GetElementNoThrow(string name, out Type foundType)
		{
			int num = this.FindElement(name);
			if (num == -1)
			{
				foundType = null;
				return null;
			}
			foundType = this._types[num];
			return this._values[num];
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x000F18D0 File Offset: 0x000EFAD0
		[return: Nullable(2)]
		public object GetValue(string name, Type type)
		{
			ArgumentNullException.ThrowIfNull(type, "type");
			if (!(type is RuntimeType))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeType);
			}
			Type type2;
			object element = this.GetElement(name, out type2);
			if (type2 == type || type.IsAssignableFrom(type2) || element == null)
			{
				return element;
			}
			return this._converter.Convert(element, type);
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x000F1924 File Offset: 0x000EFB24
		internal object GetValueNoThrow(string name, Type type)
		{
			Type type2;
			object elementNoThrow = this.GetElementNoThrow(name, out type2);
			if (elementNoThrow == null)
			{
				return null;
			}
			if (type2 == type || type.IsAssignableFrom(type2))
			{
				return elementNoThrow;
			}
			return this._converter.Convert(elementNoThrow, type);
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x000F195C File Offset: 0x000EFB5C
		public bool GetBoolean(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(bool))
			{
				return this._converter.ToBoolean(element);
			}
			return (bool)element;
		}

		// Token: 0x060048C4 RID: 18628 RVA: 0x000F1994 File Offset: 0x000EFB94
		public char GetChar(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(char))
			{
				return this._converter.ToChar(element);
			}
			return (char)element;
		}

		// Token: 0x060048C5 RID: 18629 RVA: 0x000F19CC File Offset: 0x000EFBCC
		[CLSCompliant(false)]
		public sbyte GetSByte(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(sbyte))
			{
				return this._converter.ToSByte(element);
			}
			return (sbyte)element;
		}

		// Token: 0x060048C6 RID: 18630 RVA: 0x000F1A04 File Offset: 0x000EFC04
		public byte GetByte(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(byte))
			{
				return this._converter.ToByte(element);
			}
			return (byte)element;
		}

		// Token: 0x060048C7 RID: 18631 RVA: 0x000F1A3C File Offset: 0x000EFC3C
		public short GetInt16(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(short))
			{
				return this._converter.ToInt16(element);
			}
			return (short)element;
		}

		// Token: 0x060048C8 RID: 18632 RVA: 0x000F1A74 File Offset: 0x000EFC74
		[CLSCompliant(false)]
		public ushort GetUInt16(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(ushort))
			{
				return this._converter.ToUInt16(element);
			}
			return (ushort)element;
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x000F1AAC File Offset: 0x000EFCAC
		public int GetInt32(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(int))
			{
				return this._converter.ToInt32(element);
			}
			return (int)element;
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x000F1AE4 File Offset: 0x000EFCE4
		[CLSCompliant(false)]
		public uint GetUInt32(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(uint))
			{
				return this._converter.ToUInt32(element);
			}
			return (uint)element;
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x000F1B1C File Offset: 0x000EFD1C
		public long GetInt64(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(long))
			{
				return this._converter.ToInt64(element);
			}
			return (long)element;
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x000F1B54 File Offset: 0x000EFD54
		[CLSCompliant(false)]
		public ulong GetUInt64(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(ulong))
			{
				return this._converter.ToUInt64(element);
			}
			return (ulong)element;
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x000F1B8C File Offset: 0x000EFD8C
		public float GetSingle(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(float))
			{
				return this._converter.ToSingle(element);
			}
			return (float)element;
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x000F1BC4 File Offset: 0x000EFDC4
		public double GetDouble(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(double))
			{
				return this._converter.ToDouble(element);
			}
			return (double)element;
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x000F1BFC File Offset: 0x000EFDFC
		public decimal GetDecimal(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(decimal))
			{
				return this._converter.ToDecimal(element);
			}
			return (decimal)element;
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x000F1C34 File Offset: 0x000EFE34
		public DateTime GetDateTime(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(DateTime))
			{
				return this._converter.ToDateTime(element);
			}
			return (DateTime)element;
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x000F1C6C File Offset: 0x000EFE6C
		[return: Nullable(2)]
		public string GetString(string name)
		{
			Type type;
			object element = this.GetElement(name, out type);
			if (type != typeof(string) && element != null)
			{
				return this._converter.ToString(element);
			}
			return (string)element;
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x000F1CA6 File Offset: 0x000EFEA6
		internal static AsyncLocal<bool> AsyncDeserializationInProgress { get; } = new AsyncLocal<bool>();

		// Token: 0x060048D3 RID: 18643 RVA: 0x000F1CAD File Offset: 0x000EFEAD
		private static DeserializationTracker GetThreadDeserializationTracker()
		{
			DeserializationTracker result;
			if ((result = SerializationInfo.t_deserializationTracker) == null)
			{
				result = (SerializationInfo.t_deserializationTracker = new DeserializationTracker());
			}
			return result;
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x000F1CC3 File Offset: 0x000EFEC3
		internal static bool DeserializationInProgress
		{
			get
			{
				return SerializationInfo.AsyncDeserializationInProgress.Value || SerializationInfo.GetThreadDeserializationTracker().DeserializationInProgress;
			}
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x000F1CE0 File Offset: 0x000EFEE0
		internal static void ThrowIfDeserializationInProgress(string switchSuffix, ref int cachedValue)
		{
			if (cachedValue == 0)
			{
				bool flag;
				if (AppContext.TryGetSwitch("Switch.System.Runtime.Serialization.SerializationGuard." + switchSuffix, out flag) && flag)
				{
					cachedValue = 1;
				}
				else
				{
					cachedValue = -1;
				}
			}
			if (cachedValue == 1)
			{
				return;
			}
			if (cachedValue != -1)
			{
				throw new ArgumentOutOfRangeException("cachedValue");
			}
			if (SerializationInfo.DeserializationInProgress)
			{
				throw new SerializationException(SR.Format(SR.Serialization_DangerousDeserialization_Switch, "Switch.System.Runtime.Serialization.SerializationGuard." + switchSuffix));
			}
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x000F1D48 File Offset: 0x000EFF48
		public static DeserializationToken StartDeserialization()
		{
			if (LocalAppContextSwitches.SerializationGuard)
			{
				DeserializationTracker threadDeserializationTracker = SerializationInfo.GetThreadDeserializationTracker();
				if (!threadDeserializationTracker.DeserializationInProgress)
				{
					DeserializationTracker obj = threadDeserializationTracker;
					lock (obj)
					{
						if (!threadDeserializationTracker.DeserializationInProgress)
						{
							SerializationInfo.AsyncDeserializationInProgress.Value = true;
							threadDeserializationTracker.DeserializationInProgress = true;
							return new DeserializationToken(threadDeserializationTracker);
						}
					}
				}
			}
			return new DeserializationToken(null);
		}

		// Token: 0x0400115C RID: 4444
		private string[] _names;

		// Token: 0x0400115D RID: 4445
		private object[] _values;

		// Token: 0x0400115E RID: 4446
		private Type[] _types;

		// Token: 0x0400115F RID: 4447
		private int _count;

		// Token: 0x04001160 RID: 4448
		private readonly Dictionary<string, int> _nameToIndex;

		// Token: 0x04001161 RID: 4449
		private readonly IFormatterConverter _converter;

		// Token: 0x04001162 RID: 4450
		private string _rootTypeName;

		// Token: 0x04001163 RID: 4451
		private string _rootTypeAssemblyName;

		// Token: 0x04001164 RID: 4452
		private Type _rootType;

		// Token: 0x04001168 RID: 4456
		[ThreadStatic]
		private static DeserializationTracker t_deserializationTracker;
	}
}
