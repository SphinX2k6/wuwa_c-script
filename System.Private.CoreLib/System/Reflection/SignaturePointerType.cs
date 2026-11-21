using System;

namespace System.Reflection
{
	// Token: 0x0200077E RID: 1918
	internal sealed class SignaturePointerType : SignatureHasElementType
	{
		// Token: 0x06007A92 RID: 31378 RVA: 0x00121A88 File Offset: 0x0011FC88
		internal SignaturePointerType(SignatureType elementType) : base(elementType)
		{
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x000070DD File Offset: 0x000052DD
		protected sealed override bool IsPointerImpl()
		{
			return true;
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06007A96 RID: 31382 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06007A97 RID: 31383 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x00121A91 File Offset: 0x0011FC91
		public sealed override int GetArrayRank()
		{
			throw new ArgumentException(SR.Argument_HasToBeArrayClass);
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06007A99 RID: 31385 RVA: 0x00121CA1 File Offset: 0x0011FEA1
		protected sealed override string Suffix
		{
			get
			{
				return "*";
			}
		}
	}
}
