using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BCD RID: 7117
	public class IFaceExpressionConfigData_SetValue
	{
		// Token: 0x04005D3F RID: 23871
		public int Id;

		// Token: 0x04005D40 RID: 23872
		public IFaceExpressionConfig FaceExpression;

		// Token: 0x04005D41 RID: 23873
		[Nullable(2)]
		public IFaceExpressionConfig MaleVariant;

		// Token: 0x04005D42 RID: 23874
		public bool? CloseAutoBlink;
	}
}
