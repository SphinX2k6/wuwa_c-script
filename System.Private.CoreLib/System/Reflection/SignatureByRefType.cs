using System;

namespace System.Reflection
{
	// Token: 0x02000778 RID: 1912
	internal sealed class SignatureByRefType : SignatureHasElementType
	{
		// Token: 0x06007A3E RID: 31294 RVA: 0x00121A88 File Offset: 0x0011FC88
		internal SignatureByRefType(SignatureType elementType) : base(elementType)
		{
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x000070DD File Offset: 0x000052DD
		protected sealed override bool IsByRefImpl()
		{
			return true;
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x00007B65 File Offset: 0x00005D65
		protected sealed override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06007A42 RID: 31298 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06007A43 RID: 31299 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007A44 RID: 31300 RVA: 0x00121A91 File Offset: 0x0011FC91
		public sealed override int GetArrayRank()
		{
			throw new ArgumentException(SR.Argument_HasToBeArrayClass);
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06007A45 RID: 31301 RVA: 0x00121A9D File Offset: 0x0011FC9D
		protected sealed override string Suffix
		{
			get
			{
				return "&";
			}
		}
	}
}
