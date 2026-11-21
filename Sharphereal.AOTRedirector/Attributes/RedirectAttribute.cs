using System;
using System.Runtime.CompilerServices;

namespace Sharphereal.AOTRedirector.Attributes
{
	// Token: 0x0200000D RID: 13
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event)]
	public class RedirectAttribute : Attribute
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002882 File Offset: 0x00000A82
		public RedirectAttribute(int rrid, Type _delegateType, SourceFunctionType _functionType)
		{
			this.RRID = rrid;
			this.DelegateType = _delegateType;
			this.FunctionType = _functionType;
		}

		// Token: 0x04000018 RID: 24
		public int RRID;

		// Token: 0x04000019 RID: 25
		public Type DelegateType;

		// Token: 0x0400001A RID: 26
		public SourceFunctionType FunctionType;
	}
}
