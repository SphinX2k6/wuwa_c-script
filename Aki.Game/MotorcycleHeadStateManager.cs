using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001CDD RID: 7389
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleHeadStateManager
{
	// Token: 0x0600DFDD RID: 57309 RVA: 0x00346EF4 File Offset: 0x003450F4
	public void Init()
	{
		string stringConfig = ConfigCommonParamById.GetStringConfig("MotorArrowDropHeadScaleCurvePath");
		this.DropHeadStateScaleCurve = ResourceSystem.Instance.Load<UCurveFloat>(stringConfig, "js_undefined");
	}

	// Token: 0x0600DFDE RID: 57310 RVA: 0x00346F24 File Offset: 0x00345124
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

	// Token: 0x0600DFDF RID: 57311 RVA: 0x00347044 File Offset: 0x00345244
	private void SwapBattleBuff()
	{
		MotorcycleBattleBuff motorcycleBattleBuff = this.MotorcycleBattleBuff;
		this.MotorcycleBattleBuff = this.MotorcycleBattleBuffUp;
		this.MotorcycleBattleBuffUp = motorcycleBattleBuff;
	}

	// Token: 0x0600DFE0 RID: 57312 RVA: 0x0034706C File Offset: 0x0034526C
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

	// Token: 0x0600DFE1 RID: 57313 RVA: 0x0034712C File Offset: 0x0034532C
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

	// Token: 0x0600DFE2 RID: 57314 RVA: 0x00347198 File Offset: 0x00345398
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

	// Token: 0x0600DFE3 RID: 57315 RVA: 0x003471F4 File Offset: 0x003453F4
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

	// Token: 0x04006707 RID: 26375
	private const int NEXT_BUFF_DURATION = 500;

	// Token: 0x04006708 RID: 26376
	private readonly Dictionary<int, UiPanelBase> HeadStateMap = new Dictionary<int, UiPanelBase>();

	// Token: 0x04006709 RID: 26377
	[Nullable(2)]
	private UCurveFloat DropHeadStateScaleCurve;

	// Token: 0x0400670A RID: 26378
	private float NextBuffTime;

	// Token: 0x0400670B RID: 26379
	[Nullable(2)]
	public MotorcycleBattleBuff MotorcycleBattleBuff;

	// Token: 0x0400670C RID: 26380
	[Nullable(2)]
	public MotorcycleBattleBuff MotorcycleBattleBuffUp;

	// Token: 0x0400670D RID: 26381
	public List<IBuffGateDesc> WaitToShowBattleBuff = new List<IBuffGateDesc>();
}
