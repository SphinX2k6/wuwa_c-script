using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001097 RID: 4247
[NullableContext(1)]
[Nullable(0)]
public class TowerViewExtension : IViewExtension
{
	// Token: 0x0600A892 RID: 43154 RVA: 0x00319B39 File Offset: 0x00317D39
	public TowerViewExtension(Action refreshEnter)
	{
		this.RefreshEnter = refreshEnter;
	}

	// Token: 0x0600A893 RID: 43155 RVA: 0x00319B48 File Offset: 0x00317D48
	public bool ShouldActivate()
	{
		return TowerModel.Instance.IsOpenFloorFormation() || BattleTeamModel.Instance.Context.IsMowingInstance || TowerDefenseController.Instance.CheckInUiFlow();
	}

	// Token: 0x0600A894 RID: 43156 RVA: 0x00319B73 File Offset: 0x00317D73
	public void OnViewStart()
	{
		this.Active = true;
		EventSystem.Instance.Add(EEventName.TowerDefensePhantomChanged, new Action(this.OnPhantomChanged));
	}

	// Token: 0x0600A895 RID: 43157 RVA: 0x00319B98 File Offset: 0x00317D98
	public void OnViewRefresh()
	{
	}

	// Token: 0x0600A896 RID: 43158 RVA: 0x00319B9A File Offset: 0x00317D9A
	public void OnDetach()
	{
		if (!this.Active)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.TowerDefensePhantomChanged, new Action(this.OnPhantomChanged));
		this.Active = false;
	}

	// Token: 0x0600A897 RID: 43159 RVA: 0x00319BC8 File Offset: 0x00317DC8
	public IEnterGateResult ContributeEnterGate()
	{
		if (TowerDefenseController.Instance.CheckInUiFlow() && !TowerDefenseController.Instance.CheckAllPhantomsReady())
		{
			return new IEnterGateResult
			{
				Ok = false
			};
		}
		return new IEnterGateResult
		{
			Ok = true
		};
	}

	// Token: 0x0600A898 RID: 43160 RVA: 0x00319BFC File Offset: 0x00317DFC
	public void OnClickTowerDetails()
	{
		BattleTeamModel instance = BattleTeamModel.Instance;
		if (instance.Context.IsMowingInstance)
		{
			UiManager.Instance.OpenView(EUiViewName.InstanceDungeonMonsterPreView, instance.Context.InstanceDungeonId, null);
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.TowerFloorDetailView, null, null);
	}

	// Token: 0x0600A899 RID: 43161 RVA: 0x00319C4E File Offset: 0x00317E4E
	public void OnClickTowerRecommend()
	{
		TowerController.Instance.TowerFormationRecommendRequest(TowerModel.Instance.CurrentSelectFloor).ContinueWith(delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.TowerRecommendView, null, null);
		});
	}

	// Token: 0x0600A89A RID: 43162 RVA: 0x00319C89 File Offset: 0x00317E89
	private void OnPhantomChanged()
	{
		this.RefreshEnter();
	}

	// Token: 0x040061ED RID: 25069
	private bool Active;

	// Token: 0x040061EE RID: 25070
	private readonly Action RefreshEnter;
}
