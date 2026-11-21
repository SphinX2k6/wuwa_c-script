using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B0C RID: 31500
	public enum ITalkOptionParamType_Union : byte
	{
		// Token: 0x04013127 RID: 78119
		NONE,
		// Token: 0x04013128 RID: 78120
		ITalkOptionParamType,
		// Token: 0x04013129 RID: 78121
		ITalkOptionQteSucceed,
		// Token: 0x0401312A RID: 78122
		ITalkOptionQteFailed,
		// Token: 0x0401312B RID: 78123
		ITalkOptionQteSucceedDelayExec,
		// Token: 0x0401312C RID: 78124
		ITalkOptionQteFailedDelayExec,
		// Token: 0x0401312D RID: 78125
		ITalkOptionRogueRandomEvent,
		// Token: 0x0401312E RID: 78126
		ITalkOptionPhoneMessageEmoji,
		// Token: 0x0401312F RID: 78127
		ITalkOptionVisualNovel
	}
}
