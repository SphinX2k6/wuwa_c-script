using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000E4 RID: 228
	public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable
	{
		// Token: 0x06000C2A RID: 3114 RVA: 0x00022724 File Offset: 0x00020924
		internal CharEnumerator(string str)
		{
			this._str = str;
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00007BA1 File Offset: 0x00005DA1
		[NullableContext(1)]
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0002273C File Offset: 0x0002093C
		public bool MoveNext()
		{
			int num = this._index + 1;
			int length = this._str.Length;
			if (num < length)
			{
				this._index = num;
				return true;
			}
			this._index = length;
			return false;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00022773 File Offset: 0x00020973
		public void Dispose()
		{
			this._str = null;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0002277C File Offset: 0x0002097C
		[Nullable(2)]
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0002278C File Offset: 0x0002098C
		public char Current
		{
			get
			{
				int index = this._index;
				string str = this._str;
				if (index >= str.Length)
				{
					ThrowHelper.ThrowInvalidOperationException_EnumCurrent(this._index);
				}
				return str[index];
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000227C2 File Offset: 0x000209C2
		public void Reset()
		{
			this._index = -1;
		}

		// Token: 0x0400030A RID: 778
		private string _str;

		// Token: 0x0400030B RID: 779
		private int _index = -1;
	}
}
