using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x0200096C RID: 2412
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public struct DictionaryEntry
	{
		// Token: 0x06009005 RID: 36869 RVA: 0x00163F1B File Offset: 0x0016211B
		public DictionaryEntry(object key, [Nullable(2)] object value)
		{
			this._key = key;
			this._value = value;
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06009006 RID: 36870 RVA: 0x00163F2B File Offset: 0x0016212B
		// (set) Token: 0x06009007 RID: 36871 RVA: 0x00163F33 File Offset: 0x00162133
		public object Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06009008 RID: 36872 RVA: 0x00163F3C File Offset: 0x0016213C
		// (set) Token: 0x06009009 RID: 36873 RVA: 0x00163F44 File Offset: 0x00162144
		[Nullable(2)]
		public object Value
		{
			[NullableContext(2)]
			get
			{
				return this._value;
			}
			[NullableContext(2)]
			set
			{
				this._value = value;
			}
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x00163F4D File Offset: 0x0016214D
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out object key, [Nullable(2)] out object value)
		{
			key = this.Key;
			value = this.Value;
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x00163F5F File Offset: 0x0016215F
		public override string ToString()
		{
			return KeyValuePair.PairToString(this._key, this._value);
		}

		// Token: 0x040021F5 RID: 8693
		private object _key;

		// Token: 0x040021F6 RID: 8694
		private object _value;
	}
}
