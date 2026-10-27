using System;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070EB RID: 28907
	public interface ISplineRailData : IRailParam
	{
		// Token: 0x17009CBE RID: 40126
		// (get) Token: 0x06046932 RID: 289074
		// (set) Token: 0x06046933 RID: 289075
		int DefaultNextRailId { get; set; }

		// Token: 0x17009CBF RID: 40127
		// (get) Token: 0x06046934 RID: 289076
		// (set) Token: 0x06046935 RID: 289077
		ETriggerKey DefaultTriggerKey { get; set; }

		// Token: 0x17009CC0 RID: 40128
		// (get) Token: 0x06046936 RID: 289078
		// (set) Token: 0x06046937 RID: 289079
		int RailId { get; set; }
	}
}
