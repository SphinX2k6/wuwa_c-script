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

// Token: 0x020017E7 RID: 6119
[NullableContext(2)]
[Nullable(0)]
public class FreeRunningQteView : PanelQteView
{
	// Token: 0x0600EF85 RID: 61317 RVA: 0x00465562 File Offset: 0x00463762
	[NullableContext(1)]
	public FreeRunningQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EF86 RID: 61318 RVA: 0x00465584 File Offset: 0x00463784
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

	// Token: 0x0600EF87 RID: 61319 RVA: 0x004656DC File Offset: 0x004638DC
	protected override UniTask OnBeforeStartAsync()
	{
		FreeRunningQteView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FreeRunningQteView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EF88 RID: 61320 RVA: 0x00465720 File Offset: 0x00463920
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

	// Token: 0x0600EF89 RID: 61321 RVA: 0x004657CF File Offset: 0x004639CF
	protected override void OnAfterPlayStartSequence()
	{
		this.OnViewSequenceEndEvent();
	}

	// Token: 0x0600EF8A RID: 61322 RVA: 0x004657D7 File Offset: 0x004639D7
	protected override void OnBeforeDestroyImplement()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x0600EF8B RID: 61323 RVA: 0x004657EC File Offset: 0x004639EC
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

	// Token: 0x0600EF8C RID: 61324 RVA: 0x00465834 File Offset: 0x00463A34
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

	// Token: 0x0600EF8D RID: 61325 RVA: 0x0046591C File Offset: 0x00463B1C
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.WWJ, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.FreeRunningQteView, null);
		}
	}

	// Token: 0x0600EF8E RID: 61326 RVA: 0x0046596F File Offset: 0x00463B6F
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.ResumeQte();
	}

	// Token: 0x0600EF8F RID: 61327 RVA: 0x0046597D File Offset: 0x00463B7D
	protected override void OnBeforeHide()
	{
		this.PauseQte();
		base.OnBeforeHide();
	}

	// Token: 0x0600EF90 RID: 61328 RVA: 0x0046598B File Offset: 0x00463B8B
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

	// Token: 0x0600EF91 RID: 61329 RVA: 0x004659B7 File Offset: 0x00463BB7
	protected override void RefreshVisible()
	{
	}

	// Token: 0x0600EF92 RID: 61330 RVA: 0x004659B9 File Offset: 0x00463BB9
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x0600EF93 RID: 61331 RVA: 0x004659DC File Offset: 0x00463BDC
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

	// Token: 0x0600EF94 RID: 61332 RVA: 0x00465A28 File Offset: 0x00463C28
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

	// Token: 0x0600EF95 RID: 61333 RVA: 0x00465B14 File Offset: 0x00463D14
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		this.BindAction();
	}

	// Token: 0x0600EF96 RID: 61334 RVA: 0x00465B3B File Offset: 0x00463D3B
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		this.UnbindAction();
	}

	// Token: 0x0600EF97 RID: 61335 RVA: 0x00465B64 File Offset: 0x00463D64
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

	// Token: 0x0600EF98 RID: 61336 RVA: 0x00465BD8 File Offset: 0x00463DD8
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

	// Token: 0x0600EF99 RID: 61337 RVA: 0x00465C24 File Offset: 0x00463E24
	private void OnTriggerUiTimeDilation()
	{
		if (Time.Instance.TimeDilation == 0f)
		{
			this.PauseQte();
			return;
		}
		this.ResumeQte();
	}

	// Token: 0x0600EF9A RID: 61338 RVA: 0x00465C44 File Offset: 0x00463E44
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

	// Token: 0x0600EF9B RID: 61339 RVA: 0x00465CBD File Offset: 0x00463EBD
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

	// Token: 0x0600EF9C RID: 61340 RVA: 0x00465CD1 File Offset: 0x00463ED1
	private void OnPress()
	{
		if (!this.IsValidInput())
		{
			return;
		}
		this.OnInput();
	}

	// Token: 0x0600EF9D RID: 61341 RVA: 0x00465CE4 File Offset: 0x00463EE4
	private void OnInput()
	{
		int handleId = (int)(this.OpenParam ?? 0);
		PanelQteModel.Instance.SetQteResult(handleId, true);
		PanelQteController.Instance.StopQte(handleId, false);
	}

	// Token: 0x0600EF9E RID: 61342 RVA: 0x00465D24 File Offset: 0x00463F24
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

	// Token: 0x0600EF9F RID: 61343 RVA: 0x00465DDB File Offset: 0x00463FDB
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

	// Token: 0x0600EFA0 RID: 61344 RVA: 0x00465E0D File Offset: 0x0046400D
	private void PauseQte()
	{
		this.IsPause = true;
		if (this.DelayTimer != null)
		{
			this.DelayTimer.Pause();
		}
		this.SetPlayRate("Loop", 0f);
	}

	// Token: 0x0600EFA1 RID: 61345 RVA: 0x00465E3C File Offset: 0x0046403C
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

	// Token: 0x0400876A RID: 34666
	private CombineKeyItem KeyItem;

	// Token: 0x0400876B RID: 34667
	private TimerHandle DelayTimer;

	// Token: 0x0400876C RID: 34668
	private UUIItem AnimItem;

	// Token: 0x0400876D RID: 34669
	private UUIButtonComponent BtnClick;

	// Token: 0x0400876E RID: 34670
	private UUISprite IconItem;

	// Token: 0x0400876F RID: 34671
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008770 RID: 34672
	private Number LoopDuration = 0;

	// Token: 0x04008771 RID: 34673
	private bool HasBindAction;

	// Token: 0x04008772 RID: 34674
	[Nullable(1)]
	private string QteAction = string.Empty;

	// Token: 0x04008773 RID: 34675
	private bool IsQteInteractive;

	// Token: 0x020079FF RID: 31231
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x040278CC RID: 161996
		AnimItem,
		// Token: 0x040278CD RID: 161997
		BtnClick,
		// Token: 0x040278CE RID: 161998
		Icon
	}

	// Token: 0x02007A00 RID: 31232
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x040278D0 RID: 162000
		AnimItem,
		// Token: 0x040278D1 RID: 162001
		KeyItemContainer,
		// Token: 0x040278D2 RID: 162002
		KeyItem,
		// Token: 0x040278D3 RID: 162003
		Icon,
		// Token: 0x040278D4 RID: 162004
		BtnClick
	}
}
