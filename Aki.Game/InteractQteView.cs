using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017E9 RID: 6121
[NullableContext(1)]
[Nullable(0)]
public class InteractQteView : PanelQteView
{
	// Token: 0x0600EFB7 RID: 61367 RVA: 0x0046667E File Offset: 0x0046487E
	public InteractQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EFB8 RID: 61368 RVA: 0x00466694 File Offset: 0x00464894
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num;
		Span<ValueTuple<int, Type>> span;
		int num2;
		if (this.IsMobile)
		{
			num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			return;
		}
		num2 = 3;
		List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
		span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
		num = 0;
		*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list2;
	}

	// Token: 0x0600EFB9 RID: 61369 RVA: 0x0046678C File Offset: 0x0046498C
	protected override UniTask OnBeforeStartAsync()
	{
		InteractQteView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InteractQteView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFBA RID: 61370 RVA: 0x004667D0 File Offset: 0x004649D0
	protected override void OnStart()
	{
		if (this.IsMobile)
		{
			this.AnimItem = base.GetItem(0);
			base.GetButton(1).OnPointDownCallBack.Bind(new Action(this.OnPress));
		}
		else
		{
			this.AnimItem = base.GetItem(0);
			base.GetItem(1).SetUIActive(false);
		}
		this.LevelSequencePlayer = new LevelSequencePlayer(this.AnimItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		this.InitQteData();
		UUIItem animItem = this.AnimItem;
		if (animItem != null)
		{
			animItem.SetUIActive(false);
		}
		this.UiViewSequence.AddSequenceFinishEvent("Start", new Action<string>(this.OnViewSequenceEndEvent), false);
	}

	// Token: 0x0600EFBB RID: 61371 RVA: 0x00466889 File Offset: 0x00464A89
	protected override void OnBeforeDestroyImplement()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x0600EFBC RID: 61372 RVA: 0x0046689C File Offset: 0x00464A9C
	private void OnViewSequenceEndEvent(string name)
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

	// Token: 0x0600EFBD RID: 61373 RVA: 0x004668E4 File Offset: 0x00464AE4
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
				this.SetPlayRate("Loop", 1f / this.LoopDuration);
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

	// Token: 0x0600EFBE RID: 61374 RVA: 0x004669B0 File Offset: 0x00464BB0
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.InteractQteView, null);
		}
	}

	// Token: 0x0600EFBF RID: 61375 RVA: 0x00466A03 File Offset: 0x00464C03
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		if (this.IsMobile)
		{
			base.GetButton(1).OnPointDownCallBack.Unbind();
		}
		this.StopDelayTimer();
	}

	// Token: 0x0600EFC0 RID: 61376 RVA: 0x00466A2A File Offset: 0x00464C2A
	protected override void RefreshVisible()
	{
	}

	// Token: 0x0600EFC1 RID: 61377 RVA: 0x00466A2C File Offset: 0x00464C2C
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x0600EFC2 RID: 61378 RVA: 0x00466A50 File Offset: 0x00464C50
	private void InitQteData()
	{
		int num = (int)(this.OpenParam ?? 0);
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.InteractQteView, null);
			return;
		}
		PanelQteContext context = PanelQteModel.Instance.GetContext();
		if (num != context.QteHandleId)
		{
			Log.Instance.Error(ELogModule.PanelQte, ELogAuthor.CFT, "qte handleId 不匹配", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.InteractQteView, null);
			return;
		}
		this.LoopDuration = context.Config.Duration;
		this.IsQteStart = false;
	}

	// Token: 0x0600EFC3 RID: 61379 RVA: 0x00466B15 File Offset: 0x00464D15
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.BindAction("QTE交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x0600EFC4 RID: 61380 RVA: 0x00466B40 File Offset: 0x00464D40
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.UnBindAction("QTE交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x0600EFC5 RID: 61381 RVA: 0x00466B6B File Offset: 0x00464D6B
	private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
	{
		if (this.IsQteEnd || !this.IsQteStart)
		{
			return;
		}
		if (actionType == InputDistributeDefine.EActionType.Press)
		{
			this.OnInput();
		}
	}

	// Token: 0x0600EFC6 RID: 61382 RVA: 0x00466B87 File Offset: 0x00464D87
	private void OnPress()
	{
		if (this.IsQteEnd || !this.IsQteStart)
		{
			return;
		}
		this.OnInput();
	}

	// Token: 0x0600EFC7 RID: 61383 RVA: 0x00466BA0 File Offset: 0x00464DA0
	private void OnInput()
	{
		int handleId = (int)(this.OpenParam ?? 0);
		PanelQteModel.Instance.SetQteResult(handleId, true);
		PanelQteController.Instance.StopQte(handleId, false);
	}

	// Token: 0x0600EFC8 RID: 61384 RVA: 0x00466BE0 File Offset: 0x00464DE0
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
			UiManager.Instance.CloseView(EUiViewName.InteractQteView, null);
		}, 500f, null, null, true, 1f);
	}

	// Token: 0x0600EFC9 RID: 61385 RVA: 0x00466C97 File Offset: 0x00464E97
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

	// Token: 0x0400877E RID: 34686
	[Nullable(2)]
	private CombineKeyItem KeyItem;

	// Token: 0x0400877F RID: 34687
	[Nullable(2)]
	private TimerHandle DelayTimer;

	// Token: 0x04008780 RID: 34688
	[Nullable(2)]
	private UUIItem AnimItem;

	// Token: 0x04008781 RID: 34689
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008782 RID: 34690
	private Number LoopDuration = 0;

	// Token: 0x04008783 RID: 34691
	private const int STOP_ANIM_TIME = 500;

	// Token: 0x02007A08 RID: 31240
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x040278F8 RID: 162040
		AnimItem,
		// Token: 0x040278F9 RID: 162041
		BtnClick
	}

	// Token: 0x02007A09 RID: 31241
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x040278FB RID: 162043
		AnimItem,
		// Token: 0x040278FC RID: 162044
		KeyItemContainer,
		// Token: 0x040278FD RID: 162045
		KeyItem
	}
}
