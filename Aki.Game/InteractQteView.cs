using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002305 RID: 8965
[NullableContext(1)]
[Nullable(0)]
public class InteractQteView : PanelQteView
{
	// Token: 0x06011B1C RID: 72476 RVA: 0x00459872 File Offset: 0x00457A72
	public InteractQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011B1D RID: 72477 RVA: 0x00459888 File Offset: 0x00457A88
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

	// Token: 0x06011B1E RID: 72478 RVA: 0x00459980 File Offset: 0x00457B80
	protected override UniTask OnBeforeStartAsync()
	{
		InteractQteView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<InteractQteView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011B1F RID: 72479 RVA: 0x004599C4 File Offset: 0x00457BC4
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

	// Token: 0x06011B20 RID: 72480 RVA: 0x00459A7D File Offset: 0x00457C7D
	protected override void OnBeforeDestroyImplement()
	{
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x06011B21 RID: 72481 RVA: 0x00459A90 File Offset: 0x00457C90
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

	// Token: 0x06011B22 RID: 72482 RVA: 0x00459AD8 File Offset: 0x00457CD8
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

	// Token: 0x06011B23 RID: 72483 RVA: 0x00459BA4 File Offset: 0x00457DA4
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.InteractQteView, null);
		}
	}

	// Token: 0x06011B24 RID: 72484 RVA: 0x00459BF7 File Offset: 0x00457DF7
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		if (this.IsMobile)
		{
			base.GetButton(1).OnPointDownCallBack.Unbind();
		}
		this.StopDelayTimer();
	}

	// Token: 0x06011B25 RID: 72485 RVA: 0x00459C1E File Offset: 0x00457E1E
	protected override void RefreshVisible()
	{
	}

	// Token: 0x06011B26 RID: 72486 RVA: 0x00459C20 File Offset: 0x00457E20
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x06011B27 RID: 72487 RVA: 0x00459C44 File Offset: 0x00457E44
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

	// Token: 0x06011B28 RID: 72488 RVA: 0x00459D09 File Offset: 0x00457F09
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.BindAction("QTE交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x06011B29 RID: 72489 RVA: 0x00459D34 File Offset: 0x00457F34
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.UnBindAction("QTE交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x06011B2A RID: 72490 RVA: 0x00459D5F File Offset: 0x00457F5F
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

	// Token: 0x06011B2B RID: 72491 RVA: 0x00459D7B File Offset: 0x00457F7B
	private void OnPress()
	{
		if (this.IsQteEnd || !this.IsQteStart)
		{
			return;
		}
		this.OnInput();
	}

	// Token: 0x06011B2C RID: 72492 RVA: 0x00459D94 File Offset: 0x00457F94
	private void OnInput()
	{
		int handleId = (int)(this.OpenParam ?? 0);
		PanelQteModel.Instance.SetQteResult(handleId, true);
		PanelQteController.Instance.StopQte(handleId, false);
	}

	// Token: 0x06011B2D RID: 72493 RVA: 0x00459DD4 File Offset: 0x00457FD4
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

	// Token: 0x06011B2E RID: 72494 RVA: 0x00459E8B File Offset: 0x0045808B
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

	// Token: 0x0400863E RID: 34366
	[Nullable(2)]
	private CombineKeyItem KeyItem;

	// Token: 0x0400863F RID: 34367
	[Nullable(2)]
	private TimerHandle DelayTimer;

	// Token: 0x04008640 RID: 34368
	[Nullable(2)]
	private UUIItem AnimItem;

	// Token: 0x04008641 RID: 34369
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04008642 RID: 34370
	private Number LoopDuration = 0;

	// Token: 0x04008643 RID: 34371
	private const int STOP_ANIM_TIME = 500;

	// Token: 0x02008882 RID: 34946
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x0402C5EA RID: 181738
		AnimItem,
		// Token: 0x0402C5EB RID: 181739
		BtnClick
	}

	// Token: 0x02008883 RID: 34947
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x0402C5ED RID: 181741
		AnimItem,
		// Token: 0x0402C5EE RID: 181742
		KeyItemContainer,
		// Token: 0x0402C5EF RID: 181743
		KeyItem
	}
}
