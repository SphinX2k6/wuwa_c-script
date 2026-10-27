using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002306 RID: 8966
[NullableContext(1)]
[Nullable(0)]
public class PanelQteView : UiTickViewBase
{
	// Token: 0x06011B30 RID: 72496 RVA: 0x00459ED6 File Offset: 0x004580D6
	public PanelQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011B31 RID: 72497 RVA: 0x00459F05 File Offset: 0x00458105
	protected override void OnRegisterComponent()
	{
		this.IsMobile = Info.Instance.IsInTouch();
	}

	// Token: 0x06011B32 RID: 72498 RVA: 0x00459F17 File Offset: 0x00458117
	protected override void OnAfterShow()
	{
		this.RefreshVisible();
	}

	// Token: 0x06011B33 RID: 72499 RVA: 0x00459F20 File Offset: 0x00458120
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

	// Token: 0x06011B34 RID: 72500 RVA: 0x00459FC4 File Offset: 0x004581C4
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

	// Token: 0x06011B35 RID: 72501 RVA: 0x0045A066 File Offset: 0x00458266
	private void OnVisibleChanged()
	{
		this.RefreshVisible();
	}

	// Token: 0x06011B36 RID: 72502 RVA: 0x0045A070 File Offset: 0x00458270
	protected virtual void RefreshVisible()
	{
		bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQTE);
		this.SetActive(childVisible);
	}

	// Token: 0x06011B37 RID: 72503 RVA: 0x0045A096 File Offset: 0x00458296
	private void OnActiveBattleView()
	{
		this.IsPause = false;
	}

	// Token: 0x06011B38 RID: 72504 RVA: 0x0045A09F File Offset: 0x0045829F
	private void OnDisActiveBattleView()
	{
		this.IsPause = true;
	}

	// Token: 0x06011B39 RID: 72505 RVA: 0x0045A0A8 File Offset: 0x004582A8
	private void OnPanelQteEnd(int handleId, bool isQteSuccess)
	{
		if ((int)(this.OpenParam ?? 0) != handleId)
		{
			return;
		}
		this.IsQteEnd = true;
		this.HandleQteEnd();
	}

	// Token: 0x06011B3A RID: 72506 RVA: 0x0045A0D0 File Offset: 0x004582D0
	protected virtual void HandleQteEnd()
	{
	}

	// Token: 0x06011B3B RID: 72507 RVA: 0x0045A0D2 File Offset: 0x004582D2
	private void InputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		this.InputControllerChangeInner();
	}

	// Token: 0x06011B3C RID: 72508 RVA: 0x0045A0DA File Offset: 0x004582DA
	protected virtual void InputControllerChangeInner()
	{
	}

	// Token: 0x06011B3D RID: 72509 RVA: 0x0045A0DC File Offset: 0x004582DC
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

	// Token: 0x06011B3E RID: 72510 RVA: 0x0045A104 File Offset: 0x00458304
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

	// Token: 0x06011B3F RID: 72511 RVA: 0x0045A168 File Offset: 0x00458368
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

	// Token: 0x06011B40 RID: 72512 RVA: 0x0045A1B8 File Offset: 0x004583B8
	protected void PlayCameraShake()
	{
		if (this.CameraShakeType != null)
		{
			Vector cameraLocation = CameraModel.Instance.MainModel.CameraLocation;
			CameraController.Instance.PlayWorldCameraShake(this.CameraShakeType, new FVectorDouble?(cameraLocation.ToUeVector(false)), 0f, 500f, 1f, false, "MainCamera");
		}
	}

	// Token: 0x06011B41 RID: 72513 RVA: 0x0045A213 File Offset: 0x00458413
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

	// Token: 0x06011B42 RID: 72514 RVA: 0x0045A243 File Offset: 0x00458443
	protected void InitBuff(SPanelQte qteConfig)
	{
		this.BuffId = new long?(qteConfig.BuffOnInput);
		this.BuffCd = Math.Max(qteConfig.BuffCd * (float)TimeUtil.Instance.InverseMillisecond, 1000f);
	}

	// Token: 0x06011B43 RID: 72515 RVA: 0x0045A280 File Offset: 0x00458480
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

	// Token: 0x06011B44 RID: 72516 RVA: 0x0045A344 File Offset: 0x00458544
	protected void ClearBuff()
	{
		this.BuffId = null;
	}

	// Token: 0x04008644 RID: 34372
	protected bool IsMobile;

	// Token: 0x04008645 RID: 34373
	protected bool IsPause;

	// Token: 0x04008646 RID: 34374
	protected bool IsQteStart = true;

	// Token: 0x04008647 RID: 34375
	protected bool IsQteEnd;

	// Token: 0x04008648 RID: 34376
	protected bool CameraShakeOnInput;

	// Token: 0x04008649 RID: 34377
	protected int LoadCameraShakeHandleId = -1;

	// Token: 0x0400864A RID: 34378
	[Nullable(2)]
	protected UClass CameraShakeType;

	// Token: 0x0400864B RID: 34379
	protected long? BuffId;

	// Token: 0x0400864C RID: 34380
	protected Number BuffCd = 0;

	// Token: 0x0400864D RID: 34381
	protected Number BuffEnableTime = 0;
}
