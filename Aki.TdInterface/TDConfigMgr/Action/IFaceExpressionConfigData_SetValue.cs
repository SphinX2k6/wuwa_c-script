using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A38 RID: 6712
	public class IFaceExpressionConfigData_SetValue
	{
		// Token: 0x040058DA RID: 22746
		public int Id;

		// Token: 0x040058DB RID: 22747
		[Nullable(1)]
		public IFaceExpressionConfig FaceExpression;

		// Token: 0x040058DC RID: 22748
		[Nullable(2)]
		public IFaceExpressionConfig MaleVariant;

		// Token: 0x040058DD RID: 22749
		public bool? CloseAutoBlink;
	}
}
