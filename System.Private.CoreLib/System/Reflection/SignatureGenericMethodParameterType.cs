using System;

namespace System.Reflection
{
	// Token: 0x0200077B RID: 1915
	internal sealed class SignatureGenericMethodParameterType : SignatureGenericParameterType
	{
		// Token: 0x06007A5E RID: 31326 RVA: 0x00121BF0 File Offset: 0x0011FDF0
		internal SignatureGenericMethodParameterType(int position) : base(position)
		{
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06007A5F RID: 31327 RVA: 0x00007B65 File Offset: 0x00005D65
		public sealed override bool IsGenericTypeParameter
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06007A60 RID: 31328 RVA: 0x000070DD File Offset: 0x000052DD
		public sealed override bool IsGenericMethodParameter
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06007A61 RID: 31329 RVA: 0x00121BFC File Offset: 0x0011FDFC
		public sealed override string Name
		{
			get
			{
				return "!!" + this.GenericParameterPosition.ToString();
			}
		}
	}
}
