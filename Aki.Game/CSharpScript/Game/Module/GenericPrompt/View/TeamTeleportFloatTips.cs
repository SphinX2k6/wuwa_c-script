using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059B0 RID: 22960
	public class TeamTeleportFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A39A RID: 238490 RVA: 0x00DD6977 File Offset: 0x00DD4B77
		[NullableContext(1)]
		public TeamTeleportFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A39B RID: 238491 RVA: 0x00DD6980 File Offset: 0x00DD4B80
		protected override void OnStart()
		{
			this.TickDuration = (double)((this.OpenParam as IPromptParamHub).Duration.GetValueOrDefault() * 1000f);
			LguiUtil.Instance.SetLocalTextNew(base.MainText, "TeamTeleport_Tips", new <>z__ReadOnlySingleElementList<object>(TimeUtil.Instance.GetRemainTimeDataFormat3(this.TickDuration)));
		}

		// Token: 0x0603A39C RID: 238492 RVA: 0x00DD69DC File Offset: 0x00DD4BDC
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x0603A39D RID: 238493 RVA: 0x00DD69DE File Offset: 0x00DD4BDE
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x0603A39E RID: 238494 RVA: 0x00DD69E0 File Offset: 0x00DD4BE0
		protected override void OnTick(float delta)
		{
			if (this.TickTime >= this.TickDuration)
			{
				base.CloseMe(null);
				return;
			}
			this.TickTime += (double)delta;
			LguiUtil.Instance.SetLocalTextNew(base.MainText, "TeamTeleport_Tips", new <>z__ReadOnlySingleElementList<object>(TimeUtil.Instance.GetRemainTimeDataFormat3(this.TickDuration - this.TickTime)));
		}
	}
}
