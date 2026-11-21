using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017EA RID: 6122
[NullableContext(1)]
[Nullable(0)]
public class PanelQteView : UiTickViewBase
{
	// Token: 0x0600EFCB RID: 61387 RVA: 0x00466CE2 File Offset: 0x00464EE2
	public PanelQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EFCC RID: 61388 RVA: 0x00466D11 File Offset: 0x00464F11
	protected override void OnRegisterComponent()
	{
		this.IsMobile = Info.Instance.IsInTouch();
	}

	// Token: 0x0600EFCD RID: 61389 RVA: 0x00466D23 File Offset: 0x00464F23
	protected override void OnAfterShow()
	{
		this.RefreshVisible();
	}

	// Token: 0x0600EFCE RID: 61390 RVA: 0x00466D2C File Offset: 0x00464F2C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Add(EEventName.DisActiveBattleView, new Action(this.OnDisActiveBattleView));
		EventSystem.Instance.Add(EEventName.PanelQteEnd, new Action<int, bool>(this.OnPanelQteEnd));
		if (!this.IsMobile)
		{
			EventSystem.Instance.Add(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
		BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.PanelQTE, new Action(this.OnVisibleChanged));
	}

	// Token: 0x0600EFCF RID: 61391 RVA: 0x00466DD0 File Offset: 0x00464FD0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
		EventSystem.Instance.Remove(EEventName.DisActiveBattleView, new Action(this.OnDisActiveBattleView));
		EventSystem.Instance.Remove(EEventName.PanelQteEnd, new Action<int, bool>(this.OnPanelQteEnd));
		if (!this.IsMobile)
		{
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}
		BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.PanelQTE, new Action(this.OnVisibleChanged));
	}

	// Token: 0x0600EFD0 RID: 61392 RVA: 0x00466E72 File Offset: 0x00465072
	private void OnVisibleChanged()
	{
		this.RefreshVisible();
	}

	// Token: 0x0600EFD1 RID: 61393 RVA: 0x00466E7C File Offset: 0x0046507C
	protected virtual void RefreshVisible()
	{
		bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQTE);
		this.SetActive(childVisible);
	}

	// Token: 0x0600EFD2 RID: 61394 RVA: 0x00466EA2 File Offset: 0x004650A2
	private void OnActiveBattleView()
	{
		this.IsPause = false;
	}

	// Token: 0x0600EFD3 RID: 61395 RVA: 0x00466EAB File Offset: 0x004650AB
	private void OnDisActiveBattleView()
	{
		this.IsPause = true;
	}

	// Token: 0x0600EFD4 RID: 61396 RVA: 0x00466EB4 File Offset: 0x004650B4
	private void OnPanelQteEnd(int handleId, bool isQteSuccess)
	{
		if ((int)(this.OpenParam ?? 0) != handleId)
		{
			return;
		}
		this.IsQteEnd = true;
		this.HandleQteEnd();
	}

	// Token: 0x0600EFD5 RID: 61397 RVA: 0x00466EDC File Offset: 0x004650DC
	protected virtual void HandleQteEnd()
	{
	}

	// Token: 0x0600EFD6 RID: 61398 RVA: 0x00466EDE File Offset: 0x004650DE
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		this.InputControllerChangeInner();
	}

	// Token: 0x0600EFD7 RID: 61399 RVA: 0x00466EE6 File Offset: 0x004650E6
	protected virtual void InputControllerChangeInner()
	{
	}

	// Token: 0x0600EFD8 RID: 61400 RVA: 0x00466EE8 File Offset: 0x004650E8
	protected override void OnTick(float delta)
	{
		if (this.IsPause)
		{
			return;
		}
		if (this.IsQteStart && !this.IsQteEnd)
		{
			PanelQteModel.Instance.UpdateTime(delta);
		}
	}

	// Token: 0x0600EFD9 RID: 61401 RVA: 0x00466F10 File Offset: 0x00465110
	protected override void OnBeforeDestroy()
	{
		this.ClearCameraShake();
		this.ClearBuff();
		if (PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			int num = (int)(this.OpenParam ?? 0);
			PanelQteContext context = PanelQteModel.Instance.GetContext();
			if (num == context.QteHandleId)
			{
				PanelQteController.Instance.StopQte(num, true);
			}
		}
	}

	// Token: 0x0600EFDA RID: 61402 RVA: 0x00466F74 File Offset: 0x00465174
	protected void InitCameraShake(SPanelQte qteConfig)
	{
		this.CameraShakeOnInput = qteConfig.CameraShakeOnInput;
		if (this.CameraShakeOnInput)
		{
			this.LoadCameraShakeHandleId = ResourceSystem.Instance.LoadAsync<UClass>(qteConfig.CameraShakeType.ToAssetPathName(), delegate([Nullable(2)] UClass shakeType, string _)
			{
				this.CameraShakeType = shakeType;
				this.LoadCameraShakeHandleId = -1;
			}, 100, this.MemoryTag);
		}
	}

	// Token: 0x0600EFDB RID: 61403 RVA: 0x00466FC4 File Offset: 0x004651C4
	protected void PlayCameraShake()
	{
		if (this.CameraShakeType != null)
		{
			Vector cameraLocation = CameraModel.Instance.MainModel.CameraLocation;
			CameraController.Instance.PlayWorldCameraShake(new TSubclassOf<UCameraShakeBase>?(this.CameraShakeType), new FVectorDouble?(cameraLocation.ToUeVector(false)), 0f, 500f, 1f, false, "MainCamera");
		}
	}

	// Token: 0x0600EFDC RID: 61404 RVA: 0x00467024 File Offset: 0x00465224
	protected void ClearCameraShake()
	{
		this.CameraShakeOnInput = false;
		this.CameraShakeType = null;
		if (this.LoadCameraShakeHandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadCameraShakeHandleId);
			this.LoadCameraShakeHandleId = -1;
		}
	}

	// Token: 0x0600EFDD RID: 61405 RVA: 0x00467054 File Offset: 0x00465254
	protected void InitBuff(SPanelQte qteConfig)
	{
		this.BuffId = new long?(qteConfig.BuffOnInput);
		this.BuffCd = Math.Max(qteConfig.BuffCd * (float)TimeUtil.Instance.InverseMillisecond, 1000f);
	}

	// Token: 0x0600EFDE RID: 61406 RVA: 0x00467090 File Offset: 0x00465290
	protected void AddBuff()
	{
		if (this.BuffId == null || this.BuffId.Value == 0L)
		{
			return;
		}
		if (Time.Instance.WorldTime < this.BuffEnableTime)
		{
			return;
		}
		this.BuffEnableTime = Time.Instance.WorldTime + this.BuffCd;
		PanelQteContext context = PanelQteModel.Instance.GetContext();
		Entity sourceEntity = context.GetSourceEntity();
		if (sourceEntity != null)
		{
			long creatureDataId = sourceEntity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
			CharacterBuffComponent component = sourceEntity.GetComponent<CharacterBuffComponent>();
			if (component == null)
			{
				return;
			}
			component.AddBuff(this.BuffId.Value, new AddBuffParam
			{
				InstigatorId = creatureDataId,
				Reason = "界面QTE输入时添加",
				PreMessageId = context.PreMessageId
			});
		}
	}

	// Token: 0x0600EFDF RID: 61407 RVA: 0x00467154 File Offset: 0x00465354
	protected void ClearBuff()
	{
		this.BuffId = null;
	}

	// Token: 0x04008784 RID: 34692
	protected bool IsMobile;

	// Token: 0x04008785 RID: 34693
	protected bool IsPause;

	// Token: 0x04008786 RID: 34694
	protected bool IsQteStart = true;

	// Token: 0x04008787 RID: 34695
	protected bool IsQteEnd;

	// Token: 0x04008788 RID: 34696
	protected bool CameraShakeOnInput;

	// Token: 0x04008789 RID: 34697
	protected int LoadCameraShakeHandleId = -1;

	// Token: 0x0400878A RID: 34698
	[Nullable(2)]
	protected UClass CameraShakeType;

	// Token: 0x0400878B RID: 34699
	protected long? BuffId;

	// Token: 0x0400878C RID: 34700
	protected Number BuffCd = 0;

	// Token: 0x0400878D RID: 34701
	protected Number BuffEnableTime = 0;
}
