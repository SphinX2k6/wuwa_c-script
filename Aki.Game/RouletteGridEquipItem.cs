using System;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001EA7 RID: 7847
public class RouletteGridEquipItem : RouletteGridBase
{
	// Token: 0x0601360F RID: 79375 RVA: 0x005A7A04 File Offset: 0x005A5C04
	protected override UniTask Init()
	{
		RouletteGridEquipItem.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<RouletteGridEquipItem.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06013610 RID: 79376 RVA: 0x005A7A48 File Offset: 0x005A5C48
	protected override void OnSelect(bool bSelect)
	{
		if (!bSelect)
		{
			return;
		}
		if (this.Data == null || this.Data.State != EGridBehavior.Normal)
		{
			return;
		}
		if (this.Data.Id == 0)
		{
			RouletteController.Instance.OpenEmptyTips();
			return;
		}
		if (base.IsDataValid())
		{
			CharacterExploreModel.Instance.SetExploreSkillId(3001, EExploreSkillLayer.Roulette, "RouletteGridEquipItem.OnSelect");
			RouletteController.Instance.EquipItemSetRequest(this.Data.Id, delegate(bool success)
			{
				if (success)
				{
					AudioSystem.Instance.PostEvent("play_ui_fx_spl_roulette_new_equip");
				}
			}, EExploreSkillLayer.Roulette);
		}
	}
}
