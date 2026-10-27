using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.NewWorld.Character.Role.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002303 RID: 8963
[NullableContext(2)]
[Nullable(0)]
public class FreeRunningQteView : PanelQteView
{
	// Token: 0x06011AED RID: 72429 RVA: 0x00458882 File Offset: 0x00456A82
	[NullableContext(1)]
	public FreeRunningQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011AEE RID: 72430 RVA: 0x004588A4 File Offset: 0x00456AA4
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num;
		Span<ValueTuple<int, Type>> span;
		int num2;
		if (this.IsMobile)
		{
			num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			return;
		}
		num2 = 5;
		List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
		span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
		num = 0;
		*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num++;
		*span[num] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list2;
	}

	// Token: 0x06011AEF RID: 72431 RVA: 0x004589FC File Offset: 0x00456BFC
	protected override UniTask OnBeforeStartAsync()
	{
		FreeRunningQteView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FreeRunningQteView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011AF0 RID: 72432 RVA: 0x00458A40 File Offset: 0x00456C40
	protected override void OnStart()
	{
		if (this.IsMobile)
		{
			this.AnimItem = base.GetItem(0);
			this.BtnClick = base.GetButton(1);
			UUIButtonComponent btnClick = this.BtnClick;
			if (btnClick != null)
			{
				btnClick.OnPointDownCallBack.Bind(new Action(this.OnPress));
			}
		}
		else
		{
			this.AnimItem = base.GetItem(0);
			this.BtnClick = base.GetButton(4);
			UUIButtonComponent btnClick2 = this.BtnClick;
			if (btnClick2 != null)
			{
				btnClick2.SetActive(false, false);
			}
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(this.AnimItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		this.InitQteData();
	}

	// Token: 0x06011AF1 RID: 72433 RVA: 0x00458AEF File Offset: 0x00456CEF
	protected override void OnAfterPlayStartSequence()
	{
		this.OnViewSequenceEndEvent();
	}

	// Token: 0x06011AF2 RID: 72434 RVA: 0x00458AF7 File Offset: 0x00456CF7
	protected override void OnBeforeDestroyImplement()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x06011AF3 RID: 72435 RVA: 0x00458B0C File Offset: 0x00456D0C
	private void OnViewSequenceEndEvent()
	{
		if (this.IsQteEnd)
		{
			return;
		}
		UUIItem animItem = this.AnimItem;
		if (animItem != null)
		{
			animItem.SetUIActive(true);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x06011AF4 RID: 72436 RVA: 0x00458B54 File Offset: 0x00456D54
	[NullableContext(1)]
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			if (this.IsQteEnd)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
			if (this.LoopDuration > 0)
			{
				if (this.IsPause)
				{
					this.SetPlayRate("Loop", 0f);
				}
				else
				{
					this.SetPlayRate("Loop", 1f / this.LoopDuration);
				}
			}
			int handleId = (int)(this.OpenParam ?? 0);
			PanelQteModel.Instance.ResetLeftTime(handleId);
			if (!this.IsMobile)
			{
				UUIItem item = base.GetItem(1);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				CombineKeyItem keyItem = this.KeyItem;
				if (keyItem != null)
				{
					keyItem.Show(null);
				}
			}
			this.IsQteStart = true;
		}
	}

	// Token: 0x06011AF5 RID: 72437 RVA: 0x00458C3C File Offset: 0x00456E3C
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.WWJ, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.FreeRunningQteView, null);
		}
	}

	// Token: 0x06011AF6 RID: 72438 RVA: 0x00458C8F File Offset: 0x00456E8F
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.ResumeQte();
	}

	// Token: 0x06011AF7 RID: 72439 RVA: 0x00458C9D File Offset: 0x00456E9D
	protected override void OnBeforeHide()
	{
		this.PauseQte();
		base.OnBeforeHide();
	}

	// Token: 0x06011AF8 RID: 72440 RVA: 0x00458CAB File Offset: 0x00456EAB
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		if (this.IsMobile)
		{
			UUIButtonComponent btnClick = this.BtnClick;
			if (btnClick != null)
			{
				btnClick.OnPointDownCallBack.Unbind();
			}
		}
		this.StopDelayTimer();
	}

	// Token: 0x06011AF9 RID: 72441 RVA: 0x00458CD7 File Offset: 0x00456ED7
	protected override void RefreshVisible()
	{
	}

	// Token: 0x06011AFA RID: 72442 RVA: 0x00458CD9 File Offset: 0x00456ED9
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x06011AFB RID: 72443 RVA: 0x00458CFC File Offset: 0x00456EFC
	private UniTask LoadIcon([Nullable(new byte[]
	{
		2,
		1
	})] TSoftObjectPtr<ULGUITexturePackerSpriteData> iconRef)
	{
		FreeRunningQteView.<LoadIcon>d__26 <LoadIcon>d__;
		<LoadIcon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadIcon>d__.<>4__this = this;
		<LoadIcon>d__.iconRef = iconRef;
		<LoadIcon>d__.<>1__state = -1;
		<LoadIcon>d__.<>t__builder.Start<FreeRunningQteView.<LoadIcon>d__26>(ref <LoadIcon>d__);
		return <LoadIcon>d__.<>t__builder.Task;
	}

	// Token: 0x06011AFC RID: 72444 RVA: 0x00458D48 File Offset: 0x00456F48
	private void InitQteData()
	{
		int num = (int)(this.OpenParam ?? 0);
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.WWJ, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.FreeRunningQteView, null);
			return;
		}
		PanelQteContext context = PanelQteModel.Instance.GetContext();
		if (num != context.QteHandleId)
		{
			Log.Instance.Error(ELogModule.PanelQte, ELogAuthor.WWJ, "qte handleId 不匹配", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.FreeRunningQteView, null);
			return;
		}
		this.LoopDuration = context.Config.Duration;
		this.QteAction = context.Config.Action;
		this.IsQteInteractive = true;
		EventSystem.Instance.Emit<string>(EEventName.FreeRunningQteStart, this.QteAction);
	}

	// Token: 0x06011AFD RID: 72445 RVA: 0x00458E34 File Offset: 0x00457034
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		this.BindAction();
	}

	// Token: 0x06011AFE RID: 72446 RVA: 0x00458E5B File Offset: 0x0045705B
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		this.UnbindAction();
	}

	// Token: 0x06011AFF RID: 72447 RVA: 0x00458E84 File Offset: 0x00457084
	private void BindAction()
	{
		if (this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = true;
		if (!this.IsMobile)
		{
			PanelQteContext context = PanelQteModel.Instance.GetContext();
			this.QteAction = context.Config.Action;
			CombineKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshAction(this.QteAction);
			}
			InputDistributeController.Instance.BindAction(this.QteAction, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x06011B00 RID: 72448 RVA: 0x00458EF8 File Offset: 0x004570F8
	private void UnbindAction()
	{
		if (!this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = false;
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.UnBindAction(this.QteAction, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
			this.QteAction = string.Empty;
		}
	}

	// Token: 0x06011B01 RID: 72449 RVA: 0x00458F44 File Offset: 0x00457144
	private void OnTriggerUiTimeDilation()
	{
		if (Time.Instance.TimeDilation == 0f)
		{
			this.PauseQte();
			return;
		}
		this.ResumeQte();
	}

	// Token: 0x06011B02 RID: 72450 RVA: 0x00458F64 File Offset: 0x00457164
	private bool IsValidInput()
	{
		if (this.IsQteEnd || (!this.IsQteStart && !this.IsQteInteractive))
		{
			return false;
		}
		if (this.QteAction == "幻象1")
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null || !baseCharacter.IsValid())
			{
				return false;
			}
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			if (entity == null)
			{
				return false;
			}
			RoleSceneInteractComponent component = entity.GetComponent<RoleSceneInteractComponent>();
			if (component == null || !component.CanActivateFixHook())
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06011B03 RID: 72451 RVA: 0x00458FDD File Offset: 0x004571DD
	[NullableContext(1)]
	private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
	{
		if (!this.IsValidInput())
		{
			return;
		}
		if (actionType == InputDistributeDefine.EActionType.Press)
		{
			this.OnInput();
		}
	}

	// Token: 0x06011B04 RID: 72452 RVA: 0x00458FF1 File Offset: 0x004571F1
	private void OnPress()
	{
		if (!this.IsValidInput())
		{
			return;
		}
		this.OnInput();
	}

	// Token: 0x06011B05 RID: 72453 RVA: 0x00459004 File Offset: 0x00457204
	private void OnInput()
	{
		int handleId = (int)(this.OpenParam ?? 0);
		PanelQteModel.Instance.SetQteResult(handleId, true);
		PanelQteController.Instance.StopQte(handleId, false);
	}

	// Token: 0x06011B06 RID: 72454 RVA: 0x00459044 File Offset: 0x00457244
	protected override void HandleQteEnd()
	{
		if (this.DelayTimer != null)
		{
			return;
		}
		if (!this.IsMobile)
		{
			base.GetItem(1).SetUIActive(false);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		if (PanelQteModel.Instance.IsQteSuccess())
		{
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Success", false, null, false);
			}
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.PlayLevelSequenceByName("Fail", false, null, false);
			}
		}
		this.DelayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.DelayTimer = null;
			UiManager.Instance.CloseView(EUiViewName.FreeRunningQteView, null);
		}, 500f, null, null, true, 1f);
	}

	// Token: 0x06011B07 RID: 72455 RVA: 0x004590FB File Offset: 0x004572FB
	[NullableContext(1)]
	private void SetPlayRate(string sequenceName, float playRate)
	{
		AUIBaseActor auibaseActor = this.AnimItem.GetOwner() as AUIBaseActor;
		if (auibaseActor == null)
		{
			return;
		}
		ALevelSequenceActor sequencePlayerByKey = auibaseActor.GetSequencePlayerByKey(sequenceName);
		if (sequencePlayerByKey == null)
		{
			return;
		}
		ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.SetPlayRate(playRate);
	}

	// Token: 0x06011B08 RID: 72456 RVA: 0x0045912D File Offset: 0x0045732D
	private void PauseQte()
	{
		this.IsPause = true;
		if (this.DelayTimer != null)
		{
			this.DelayTimer.Pause();
		}
		this.SetPlayRate("Loop", 0f);
	}

	// Token: 0x06011B09 RID: 72457 RVA: 0x0045915C File Offset: 0x0045735C
	private void ResumeQte()
	{
		if (this.IsPause)
		{
			if (this.DelayTimer != null)
			{
				this.DelayTimer.Resume();
			}
			this.SetPlayRate("Loop", 1f / this.LoopDuration);
			this.IsPause = false;
		}
	}

	// Token: 0x0400862C RID: 34348
	private CombineKeyItem KeyItem;

	// Token: 0x0400862D RID: 34349
	private TimerHandle DelayTimer;

	// Token: 0x0400862E RID: 34350
	private UUIItem AnimItem;

	// Token: 0x0400862F RID: 34351
	private UUIButtonComponent BtnClick;

	// Token: 0x04008630 RID: 34352
	private UUISprite IconItem;

	// Token: 0x04008631 RID: 34353
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008632 RID: 34354
	private Number LoopDuration = 0;

	// Token: 0x04008633 RID: 34355
	private bool HasBindAction;

	// Token: 0x04008634 RID: 34356
	[Nullable(1)]
	private string QteAction = string.Empty;

	// Token: 0x04008635 RID: 34357
	private bool IsQteInteractive;

	// Token: 0x0200887B RID: 34939
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x0402C5CA RID: 181706
		AnimItem,
		// Token: 0x0402C5CB RID: 181707
		BtnClick,
		// Token: 0x0402C5CC RID: 181708
		Icon
	}

	// Token: 0x0200887C RID: 34940
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x0402C5CE RID: 181710
		AnimItem,
		// Token: 0x0402C5CF RID: 181711
		KeyItemContainer,
		// Token: 0x0402C5D0 RID: 181712
		KeyItem,
		// Token: 0x0402C5D1 RID: 181713
		Icon,
		// Token: 0x0402C5D2 RID: 181714
		BtnClick
	}
}
