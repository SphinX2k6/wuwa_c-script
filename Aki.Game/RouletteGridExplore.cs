using System;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001EA8 RID: 7848
public class RouletteGridExplore : RouletteGridBase
{
	// Token: 0x06013612 RID: 79378 RVA: 0x005A7AE4 File Offset: 0x005A5CE4
	protected override UniTask Init()
	{
		RouletteGridExplore.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<RouletteGridExplore.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06013613 RID: 79379 RVA: 0x005A7B28 File Offset: 0x005A5D28
	protected override void OnSelect(bool bSelect)
	{
		if (!bSelect)
		{
			return;
		}
		if (!base.IsDataValid() || this.Data == null)
		{
			return;
		}
		if (this.Data.State == EGridBehavior.Forbidden)
		{
			RouletteGridForbiddenSettings.TipsForbiddenState(this.Data.GridType, this.Data.Id);
			return;
		}
		if (this.Data.State == EGridBehavior.Lock)
		{
			RouletteGridForbiddenSettings.TipsLockState(this.Data.GridType, this.Data.Id);
			return;
		}
		EGridUseType useType = this.Data.UseType;
		if (useType == EGridUseType.SwitchOnly)
		{
			int id = this.Data.Id;
			CharacterExploreModel.Instance.SetExploreSkillId(id, EExploreSkillLayer.Roulette, "RouletteGridExplore.OnSelect");
			RouletteController.Instance.ExploreSkillSetRequest(id, delegate(bool success)
			{
				if (success)
				{
					AudioSystem.Instance.PostEvent("play_ui_fx_spl_roulette_new_equip");
				}
			}, false);
			EventSystem.Instance.Emit<int>(EEventName.ChangeVisionSkillByTab, this.Data.Id);
			return;
		}
		if (useType != EGridUseType.FunctionOnly)
		{
			return;
		}
		RouletteExploreSkillController.Instance.UseRouletteExploreId((ERouletteExploreId)this.Data.Id);
	}
}
