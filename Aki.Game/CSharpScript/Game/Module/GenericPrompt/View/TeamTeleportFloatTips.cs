using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x02004989 RID: 18825
	public class TeamTeleportFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F2C0 RID: 193216 RVA: 0x00D25E07 File Offset: 0x00D24007
		[NullableContext(1)]
		public TeamTeleportFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F2C1 RID: 193217 RVA: 0x00D25E10 File Offset: 0x00D24010
		protected override void OnStart()
		{
			this.TickDuration = (double)((this.OpenParam as IPromptParamHub).Duration.GetValueOrDefault() * 1000f);
			LguiUtil.Instance.SetLocalTextNew(base.MainText, "TeamTeleport_Tips", new <>z__ReadOnlySingleElementList<object>(TimeUtil.Instance.GetRemainTimeDataFormat3(this.TickDuration)));
		}

		// Token: 0x0602F2C2 RID: 193218 RVA: 0x00D25E6C File Offset: 0x00D2406C
		protected override void SetMainText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x0602F2C3 RID: 193219 RVA: 0x00D25E6E File Offset: 0x00D2406E
		protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
		{
			1,
			2
		})] IReadOnlyList<object> param)
		{
		}

		// Token: 0x0602F2C4 RID: 193220 RVA: 0x00D25E70 File Offset: 0x00D24070
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
