using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070F5 RID: 28917
	[NullableContext(2)]
	public interface IRailData
	{
		// Token: 0x17009CE3 RID: 40163
		// (get) Token: 0x06046981 RID: 289153
		// (set) Token: 0x06046982 RID: 289154
		int RailSplineEntityId { get; set; }

		// Token: 0x17009CE4 RID: 40164
		// (get) Token: 0x06046983 RID: 289155
		// (set) Token: 0x06046984 RID: 289156
		float? SlideSpeed { get; set; }

		// Token: 0x17009CE5 RID: 40165
		// (get) Token: 0x06046985 RID: 289157
		// (set) Token: 0x06046986 RID: 289158
		float? UpSpeed { get; set; }

		// Token: 0x17009CE6 RID: 40166
		// (get) Token: 0x06046987 RID: 289159
		// (set) Token: 0x06046988 RID: 289160
		float? DownSpeed { get; set; }

		// Token: 0x17009CE7 RID: 40167
		// (get) Token: 0x06046989 RID: 289161
		// (set) Token: 0x0604698A RID: 289162
		[Nullable(new byte[]
		{
			2,
			1
		})]
		IExchangeSlideRailConfig[] ExchangeRailConfigs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17009CE8 RID: 40168
		// (get) Token: 0x0604698B RID: 289163
		// (set) Token: 0x0604698C RID: 289164
		ISlopeSlidePerform SlidePerformConfig { get; set; }
	}
}
