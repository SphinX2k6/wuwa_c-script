using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200119F RID: 4511
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleHeadStateManager
{
	// Token: 0x0600B3FA RID: 46074 RVA: 0x0035291C File Offset: 0x00350B1C
	public void Init()
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("MotorArrowDropHeadScaleCurvePath");
		this.DropHeadStateScaleCurve = ResourceSystem.Instance.Load<UCurveFloat>(stringConfig, "js_undefined");
	}

	// Token: 0x0600B3FB RID: 46075 RVA: 0x0035294C File Offset: 0x00350B4C
	public void UpdateHeadState(Func<UiPanelBase> headStateClass, FKSC_HeadHpContext headInfo, [Nullable(2)] IBuffGateDesc buffGateInfo = null)
	{
		UiPanelBase uiPanelBase2;
		if (headInfo.ActionType == EKSC_HeadHpContextType.Add || headInfo.ActionType == EKSC_HeadHpContextType.Update)
		{
			UiPanelBase uiPanelBase;
			if (!this.HeadStateMap.TryGetValue(headInfo.EntityId, out uiPanelBase))
			{
				uiPanelBase = headStateClass();
				MotorcycleBuffGateHeadState motorcycleBuffGateHeadState = uiPanelBase as MotorcycleBuffGateHeadState;
				if (motorcycleBuffGateHeadState != null)
				{
					motorcycleBuffGateHeadState.CreateHeadStateView(UiLayer.Instance.WorldSpaceUiRootItem, buffGateInfo);
				}
				else
				{
					MotorcycleDropBuffGateHeadState motorcycleDropBuffGateHeadState = uiPanelBase as MotorcycleDropBuffGateHeadState;
					if (motorcycleDropBuffGateHeadState != null)
					{
						motorcycleDropBuffGateHeadState.CreateHeadStateView(UiLayer.Instance.WorldSpaceUiRootItem, buffGateInfo, this.DropHeadStateScaleCurve);
					}
					else
					{
						((DigitalHpHeadStateHeadState)uiPanelBase).CreateHeadStateView(UiLayer.Instance.WorldSpaceUiRootItem, headInfo);
					}
				}
				this.HeadStateMap[headInfo.EntityId] = uiPanelBase;
			}
			DigitalHpHeadStateHeadState digitalHpHeadStateHeadState = uiPanelBase as DigitalHpHeadStateHeadState;
			if (digitalHpHeadStateHeadState != null)
			{
				digitalHpHeadStateHeadState.UpdateByHeadInfo(headInfo);
				return;
			}
			MotorcycleBuffGateHeadState motorcycleBuffGateHeadState2 = uiPanelBase as MotorcycleBuffGateHeadState;
			if (motorcycleBuffGateHeadState2 != null)
			{
				motorcycleBuffGateHeadState2.UpdateByHeadInfo(headInfo);
				return;
			}
			MotorcycleDropBuffGateHeadState motorcycleDropBuffGateHeadState2 = uiPanelBase as MotorcycleDropBuffGateHeadState;
			if (motorcycleDropBuffGateHeadState2 != null)
			{
				motorcycleDropBuffGateHeadState2.UpdateByHeadInfo(headInfo);
				return;
			}
		}
		else if (headInfo.ActionType == EKSC_HeadHpContextType.Remove && this.HeadStateMap.TryGetValue(headInfo.EntityId, out uiPanelBase2))
		{
			uiPanelBase2.DestroyAsync().Forget<bool>();
			this.HeadStateMap.Remove(headInfo.EntityId);
		}
	}

	// Token: 0x0600B3FC RID: 46076 RVA: 0x00352A6C File Offset: 0x00350C6C
	private void SwapBattleBuff()
	{
		MotorcycleBattleBuff motorcycleBattleBuff = this.MotorcycleBattleBuff;
		this.MotorcycleBattleBuff = this.MotorcycleBattleBuffUp;
		this.MotorcycleBattleBuffUp = motorcycleBattleBuff;
	}

	// Token: 0x0600B3FD RID: 46077 RVA: 0x00352A94 File Offset: 0x00350C94
	private bool TryPlayBattleBuff(IBuffGateDesc buffGateInfo)
	{
		if ((float)Time.Instance.WorldTimeSeconds < this.NextBuffTime)
		{
			return false;
		}
		MotorcycleBattleBuff motorcycleBattleBuff = this.MotorcycleBattleBuff;
		if (motorcycleBattleBuff != null && motorcycleBattleBuff.IsFree)
		{
			this.MotorcycleBattleBuff.UpdateBuffInfo(buffGateInfo);
			this.MotorcycleBattleBuff.SetActive(true);
			this.NextBuffTime = (float)Time.Instance.WorldTimeSeconds + 500f;
			return true;
		}
		MotorcycleBattleBuff motorcycleBattleBuffUp = this.MotorcycleBattleBuffUp;
		if (motorcycleBattleBuffUp != null && motorcycleBattleBuffUp.IsFree)
		{
			this.MotorcycleBattleBuffUp.UpdateBuffInfo(buffGateInfo);
			this.MotorcycleBattleBuffUp.SetActive(true);
			this.MotorcycleBattleBuff.SetUp();
			this.SwapBattleBuff();
			this.NextBuffTime = (float)Time.Instance.WorldTimeSeconds + 500f;
			return true;
		}
		return false;
	}

	// Token: 0x0600B3FE RID: 46078 RVA: 0x00352B54 File Offset: 0x00350D54
	public void CreateMotorcycleBuffItem(IBuffGateDesc buffGateInfo)
	{
		if (this.MotorcycleBattleBuff == null)
		{
			this.MotorcycleBattleBuff = new MotorcycleBattleBuff();
			this.MotorcycleBattleBuff.CreateHeadStateView(UiLayer.Instance.WorldSpaceUiRootItem, buffGateInfo);
			this.MotorcycleBattleBuffUp = new MotorcycleBattleBuff();
			this.MotorcycleBattleBuffUp.CreateHeadStateView(UiLayer.Instance.WorldSpaceUiRootItem, buffGateInfo);
		}
		if (!this.TryPlayBattleBuff(buffGateInfo))
		{
			this.WaitToShowBattleBuff.Add(buffGateInfo);
		}
	}

	// Token: 0x0600B3FF RID: 46079 RVA: 0x00352BC0 File Offset: 0x00350DC0
	public void Tick()
	{
		if (this.MotorcycleBattleBuff == null)
		{
			return;
		}
		if (this.WaitToShowBattleBuff.Count > 0 && this.TryPlayBattleBuff(this.WaitToShowBattleBuff[0]))
		{
			this.WaitToShowBattleBuff.RemoveAt(0);
		}
		this.MotorcycleBattleBuff.Tick();
		this.MotorcycleBattleBuffUp.Tick();
	}

	// Token: 0x0600B400 RID: 46080 RVA: 0x00352C1C File Offset: 0x00350E1C
	public void Clear()
	{
		foreach (UiPanelBase uiPanelBase in this.HeadStateMap.Values)
		{
			uiPanelBase.DestroyAsync().Forget<bool>();
		}
		this.HeadStateMap.Clear();
		MotorcycleBattleBuff motorcycleBattleBuff = this.MotorcycleBattleBuff;
		if (motorcycleBattleBuff != null)
		{
			motorcycleBattleBuff.DestroyAsync().Forget<bool>();
		}
		this.MotorcycleBattleBuff = null;
		MotorcycleBattleBuff motorcycleBattleBuffUp = this.MotorcycleBattleBuffUp;
		if (motorcycleBattleBuffUp != null)
		{
			motorcycleBattleBuffUp.DestroyAsync().Forget<bool>();
		}
		this.MotorcycleBattleBuffUp = null;
		this.WaitToShowBattleBuff.Clear();
		this.DropHeadStateScaleCurve = null;
	}

	// Token: 0x040067E6 RID: 26598
	private const int NEXT_BUFF_DURATION = 500;

	// Token: 0x040067E7 RID: 26599
	private readonly Dictionary<int, UiPanelBase> HeadStateMap = new Dictionary<int, UiPanelBase>();

	// Token: 0x040067E8 RID: 26600
	[Nullable(2)]
	private UCurveFloat DropHeadStateScaleCurve;

	// Token: 0x040067E9 RID: 26601
	private float NextBuffTime;

	// Token: 0x040067EA RID: 26602
	[Nullable(2)]
	public MotorcycleBattleBuff MotorcycleBattleBuff;

	// Token: 0x040067EB RID: 26603
	[Nullable(2)]
	public MotorcycleBattleBuff MotorcycleBattleBuffUp;

	// Token: 0x040067EC RID: 26604
	public List<IBuffGateDesc> WaitToShowBattleBuff = new List<IBuffGateDesc>();
}
