using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Runtime.Serialization
{
	// Token: 0x02000529 RID: 1321
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SerializationInfoEnumerator : IEnumerator
	{
		// Token: 0x060048DC RID: 18652 RVA: 0x000F1DFB File Offset: 0x000EFFFB
		internal SerializationInfoEnumerator(string[] members, object[] info, Type[] types, int numItems)
		{
			this._members = members;
			this._data = info;
			this._types = types;
			this._numItems = numItems - 1;
			this._currItem = -1;
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x000F1E29 File Offset: 0x000F0029
		public bool MoveNext()
		{
			if (this._currItem < this._numItems)
			{
				this._currItem++;
				this._current = true;
			}
			else
			{
				this._current = false;
			}
			return this._current;
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x000F1E5D File Offset: 0x000F005D
		[Nullable(2)]
		object IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x000F1E6C File Offset: 0x000F006C
		public SerializationEntry Current
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
				}
				return new SerializationEntry(this._members[this._currItem], this._data[this._currItem], this._types[this._currItem]);
			}
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x000F1EB8 File Offset: 0x000F00B8
		public void Reset()
		{
			this._currItem = -1;
			this._current = false;
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x000F1EC8 File Offset: 0x000F00C8
		public string Name
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
				}
				return this._members[this._currItem];
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x000F1EEA File Offset: 0x000F00EA
		[Nullable(2)]
		public object Value
		{
			[NullableContext(2)]
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
				}
				return this._data[this._currItem];
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x000F1F0C File Offset: 0x000F010C
		public Type ObjectType
		{
			get
			{
				if (!this._current)
				{
					throw new InvalidOperationException(SR.InvalidOperation_EnumOpCantHappen);
				}
				return this._types[this._currItem];
			}
		}

		// Token: 0x0400116C RID: 4460
		private readonly string[] _members;

		// Token: 0x0400116D RID: 4461
		private readonly object[] _data;

		// Token: 0x0400116E RID: 4462
		private readonly Type[] _types;

		// Token: 0x0400116F RID: 4463
		private readonly int _numItems;

		// Token: 0x04001170 RID: 4464
		private int _currItem;

		// Token: 0x04001171 RID: 4465
		private bool _current;
	}
}
