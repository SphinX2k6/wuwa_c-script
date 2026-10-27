using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001BD8 RID: 7128
[NullableContext(1)]
[Nullable(0)]
public class TowerViewExtension : IViewExtension
{
	// Token: 0x0600D480 RID: 54400 RVA: 0x0030E9C5 File Offset: 0x0030CBC5
	public TowerViewExtension(Action refreshEnter)
	{
		this.RefreshEnter = refreshEnter;
	}

	// Token: 0x0600D481 RID: 54401 RVA: 0x0030E9D4 File Offset: 0x0030CBD4
	public bool ShouldActivate()
	{
		return TowerModel.Instance.IsOpenFloorFormation() || BattleTeamModel.Instance.Context.IsMowingInstance || TowerDefenseController.Instance.CheckInUiFlow();
	}

	// Token: 0x0600D482 RID: 54402 RVA: 0x0030E9FF File Offset: 0x0030CBFF
	public void OnViewStart()
	{
		this.Active = true;
		EventSystem.Instance.Add(EEventName.TowerDefensePhantomChanged, new Action(this.OnPhantomChanged));
	}

	// Token: 0x0600D483 RID: 54403 RVA: 0x0030EA24 File Offset: 0x0030CC24
	public void OnViewRefresh()
	{
	}

	// Token: 0x0600D484 RID: 54404 RVA: 0x0030EA26 File Offset: 0x0030CC26
	public void OnDetach()
	{
		if (!this.Active)
		{
			return;
		}
		EventSystem.Instance.Remove(EEventName.TowerDefensePhantomChanged, new Action(this.OnPhantomChanged));
		this.Active = false;
	}

	// Token: 0x0600D485 RID: 54405 RVA: 0x0030EA54 File Offset: 0x0030CC54
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

	// Token: 0x0600D486 RID: 54406 RVA: 0x0030EA88 File Offset: 0x0030CC88
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

	// Token: 0x0600D487 RID: 54407 RVA: 0x0030EADA File Offset: 0x0030CCDA
	public void OnClickTowerRecommend()
	{
		TowerController.Instance.TowerFormationRecommendRequest(TowerModel.Instance.CurrentSelectFloor).ContinueWith(delegate()
		{
			UiManager.Instance.OpenView(EUiViewName.TowerRecommendView, null, null);
		});
	}

	// Token: 0x0600D488 RID: 54408 RVA: 0x0030EB15 File Offset: 0x0030CD15
	private void OnPhantomChanged()
	{
		this.RefreshEnter();
	}

	// Token: 0x0400611E RID: 24862
	private bool Active;

	// Token: 0x0400611F RID: 24863
	private readonly Action RefreshEnter;
}
