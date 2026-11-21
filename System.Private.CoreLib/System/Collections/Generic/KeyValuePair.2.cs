using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009D9 RID: 2521
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public readonly struct KeyValuePair<[Nullable(2)] TKey, [Nullable(2)] TValue>
	{
		// Token: 0x06009359 RID: 37721 RVA: 0x0016F5E4 File Offset: 0x0016D7E4
		public KeyValuePair(TKey key, TValue value)
		{
			this.key = key;
			this.value = value;
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600935A RID: 37722 RVA: 0x0016F5F4 File Offset: 0x0016D7F4
		public TKey Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x0600935B RID: 37723 RVA: 0x0016F5FC File Offset: 0x0016D7FC
		public TValue Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x0600935C RID: 37724 RVA: 0x0016F604 File Offset: 0x0016D804
		public override string ToString()
		{
			return KeyValuePair.PairToString(this.Key, this.Value);
		}

		// Token: 0x0600935D RID: 37725 RVA: 0x0016F621 File Offset: 0x0016D821
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Deconstruct(out TKey key, out TValue value)
		{
			key = this.Key;
			value = this.Value;
		}

		// Token: 0x0400229A RID: 8858
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly TKey key;

		// Token: 0x0400229B RID: 8859
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly TValue value;
	}
}
