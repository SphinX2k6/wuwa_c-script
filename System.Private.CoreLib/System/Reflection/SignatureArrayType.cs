using System;

namespace System.Reflection
{
	// Token: 0x02000777 RID: 1911
	internal sealed class SignatureArrayType : SignatureHasElementType
	{
		// Token: 0x06007A36 RID: 31286 RVA: 0x00121A19 File Offset: 0x0011FC19
		internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim) : base(elementType)
		{
			this._rank = rank;
			this._isMultiDim = isMultiDim;
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x000070DD File Offset: 0x000052DD
		protected sealed override bool IsArrayImpl()
		{
			return true;
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06007A3A RID: 31290 RVA: 0x00121A30 File Offset: 0x0011FC30
		public sealed override bool IsSZArray
		{
			get
			{
				return !this._isMultiDim;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06007A3B RID: 31291 RVA: 0x00121A3B File Offset: 0x0011FC3B
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return this._isMultiDim;
			}
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x00121A43 File Offset: 0x0011FC43
		public sealed override int GetArrayRank()
		{
			return this._rank;
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06007A3D RID: 31293 RVA: 0x00121A4B File Offset: 0x0011FC4B
		protected sealed override string Suffix
		{
			get
			{
				if (!this._isMultiDim)
				{
					return "[]";
				}
				if (this._rank == 1)
				{
					return "[*]";
				}
				return "[" + new string(',', this._rank - 1) + "]";
			}
		}

		// Token: 0x0400171C RID: 5916
		private readonly int _rank;

		// Token: 0x0400171D RID: 5917
		private readonly bool _isMultiDim;
	}
}
