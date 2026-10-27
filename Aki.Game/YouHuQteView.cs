using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002309 RID: 8969
[NullableContext(1)]
[Nullable(0)]
public class YouHuQteView : PanelQteView
{
	// Token: 0x06011B55 RID: 72533 RVA: 0x0045A57C File Offset: 0x0045877C
	public YouHuQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011B56 RID: 72534 RVA: 0x0045A5C8 File Offset: 0x004587C8
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num;
		Span<ValueTuple<int, Type>> span;
		int num2;
		if (this.IsMobile)
		{
			num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			return;
		}
		num2 = 19;
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
		*span[num] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num++;
		*span[num] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
		num++;
		*span[num] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(12, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(16, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(18, typeof(UUIItem));
		this.ComponentRegisterInfos = list2;
	}

	// Token: 0x06011B57 RID: 72535 RVA: 0x0045AA08 File Offset: 0x00458C08
	protected override UniTask OnBeforeStartAsync()
	{
		YouHuQteView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<YouHuQteView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011B58 RID: 72536 RVA: 0x0045AA4C File Offset: 0x00458C4C
	protected override void OnStart()
	{
		base.OnStart();
		if (this.IsMobile)
		{
			this.ProgressTexture = base.GetTexture(5);
			this.ProgressEffect = base.GetUiNiagara(6);
			this.AnimItem = base.GetItem(0);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.AnimItem);
			this.LevelSequencePlayerList.Add(new LevelSequencePlayer(base.GetItem(1)));
			this.LevelSequencePlayerList.Add(new LevelSequencePlayer(base.GetItem(2)));
			this.LevelSequencePlayerList.Add(new LevelSequencePlayer(base.GetItem(3)));
			this.LevelSequencePlayerList.Add(new LevelSequencePlayer(base.GetItem(4)));
			base.GetButton(7).OnPointDownCallBack.Bind(delegate()
			{
				this.OnInput(0);
			});
			base.GetButton(8).OnPointDownCallBack.Bind(delegate()
			{
				this.OnInput(1);
			});
			base.GetButton(9).OnPointDownCallBack.Bind(delegate()
			{
				this.OnInput(2);
			});
			base.GetButton(10).OnPointDownCallBack.Bind(delegate()
			{
				this.OnInput(3);
			});
		}
		else
		{
			this.ProgressTexture = base.GetTexture(5);
			this.ProgressEffect = base.GetUiNiagara(6);
			this.AnimItem = base.GetItem(0);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.AnimItem);
			this.LevelSequencePlayerList.Add(new LevelSequencePlayer(base.GetItem(1)));
			this.LevelSequencePlayerList.Add(new LevelSequencePlayer(base.GetItem(2)));
			this.LevelSequencePlayerList.Add(new LevelSequencePlayer(base.GetItem(3)));
			this.LevelSequencePlayerList.Add(new LevelSequencePlayer(base.GetItem(4)));
			this.RefreshEffectVisible();
		}
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		this.InitQteData();
	}

	// Token: 0x06011B59 RID: 72537 RVA: 0x0045AC34 File Offset: 0x00458E34
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.YouHuQteView, null);
		}
	}

	// Token: 0x06011B5A RID: 72538 RVA: 0x0045AC88 File Offset: 0x00458E88
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		if (this.IsMobile)
		{
			base.GetButton(7).OnPointDownCallBack.Unbind();
			base.GetButton(8).OnPointDownCallBack.Unbind();
			base.GetButton(9).OnPointDownCallBack.Unbind();
			base.GetButton(10).OnPointDownCallBack.Unbind();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		foreach (LevelSequencePlayer levelSequencePlayer2 in this.LevelSequencePlayerList)
		{
			levelSequencePlayer2.Clear();
		}
		this.LevelSequencePlayerList.Clear();
		this.StopDelayTimer();
	}

	// Token: 0x06011B5B RID: 72539 RVA: 0x0045AD58 File Offset: 0x00458F58
	protected override void RefreshVisible()
	{
	}

	// Token: 0x06011B5C RID: 72540 RVA: 0x0045AD5A File Offset: 0x00458F5A
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x06011B5D RID: 72541 RVA: 0x0045AD7C File Offset: 0x00458F7C
	private void InitQteData()
	{
		int num = (int)(this.OpenParam ?? 0);
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.YouHuQteView, null);
			return;
		}
		PanelQteContext context = PanelQteModel.Instance.GetContext();
		if (num != context.QteHandleId)
		{
			Log.Instance.Error(ELogModule.PanelQte, ELogAuthor.CFT, "qte handleId 不匹配", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.YouHuQteView, null);
			return;
		}
		this.DurationMs = context.Config.Duration * (float)TimeUtil.Instance.InverseMillisecond;
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.PlayLevelSequenceByName("Start02", false, null, false);
	}

	// Token: 0x06011B5E RID: 72542 RVA: 0x0045AE68 File Offset: 0x00459068
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (sequenceName == "Start02")
		{
			if (this.IsQteEnd)
			{
				return;
			}
			int handleId = (int)(this.OpenParam ?? 0);
			PanelQteModel.Instance.ResetLeftTime(handleId);
			this.IsQteStart = true;
		}
	}

	// Token: 0x06011B5F RID: 72543 RVA: 0x0045AEB4 File Offset: 0x004590B4
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (this.IsPause || this.IsQteEnd)
		{
			return;
		}
		float num = Math.Max(PanelQteModel.Instance.GetLeftTimeNoScale() / this.DurationMs, 0f);
		UUITexture progressTexture = this.ProgressTexture;
		if (progressTexture != null)
		{
			progressTexture.SetFillAmount(num);
		}
		UUINiagara progressEffect = this.ProgressEffect;
		if (progressEffect == null)
		{
			return;
		}
		progressEffect.SetNiagaraVarFloat("Dissolve", num);
	}

	// Token: 0x06011B60 RID: 72544 RVA: 0x0045AF27 File Offset: 0x00459127
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.BindActions(YouHuQteView.ActionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x06011B61 RID: 72545 RVA: 0x0045AF52 File Offset: 0x00459152
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.UnBindActions(YouHuQteView.ActionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x06011B62 RID: 72546 RVA: 0x0045AF80 File Offset: 0x00459180
	private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
	{
		if (this.IsQteEnd || !this.IsQteStart)
		{
			return;
		}
		if (actionType == InputDistributeDefine.EActionType.Press)
		{
			int num = Array.IndexOf<string>(YouHuQteView.ActionNames, actionName);
			if (num == -1)
			{
				return;
			}
			this.OnInput(num);
		}
	}

	// Token: 0x06011B63 RID: 72547 RVA: 0x0045AFBC File Offset: 0x004591BC
	private void OnInput(int index)
	{
		this.LevelSequencePlayerList[index].PlayLevelSequenceByName("ButtonPre", false, null, false);
		int num = (int)(this.OpenParam ?? 0);
		PanelQteContext context = PanelQteModel.Instance.GetContext();
		if (num == context.QteHandleId)
		{
			context.BuffIndex = index;
		}
		PanelQteModel.Instance.SetQteResult(num, true);
		PanelQteController.Instance.StopQte(num, false);
	}

	// Token: 0x06011B64 RID: 72548 RVA: 0x0045B035 File Offset: 0x00459235
	protected override void InputControllerChangeInner()
	{
		this.RefreshEffectVisible();
	}

	// Token: 0x06011B65 RID: 72549 RVA: 0x0045B040 File Offset: 0x00459240
	private void RefreshEffectVisible()
	{
		bool uiactive = Info.Instance.IsInGamepad();
		foreach (UUIItem uuiitem in this.GamepadEffectList)
		{
			uuiitem.SetUIActive(uiactive);
		}
		bool uiactive2 = Info.Instance.IsInKeyBoard();
		foreach (UUIItem uuiitem2 in this.KeyboardEffectList)
		{
			uuiitem2.SetUIActive(uiactive2);
		}
	}

	// Token: 0x06011B66 RID: 72550 RVA: 0x0045B0E8 File Offset: 0x004592E8
	protected override void HandleQteEnd()
	{
		if (this.DelayTimer != null)
		{
			return;
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}
		this.DelayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.DelayTimer = null;
			UiManager.Instance.CloseView(EUiViewName.YouHuQteView, null);
		}, 333f, null, null, true, 1f);
	}

	// Token: 0x04008658 RID: 34392
	private readonly List<InputMultiKeyItem> KeyItemList = new List<InputMultiKeyItem>();

	// Token: 0x04008659 RID: 34393
	[Nullable(2)]
	private UUITexture ProgressTexture;

	// Token: 0x0400865A RID: 34394
	[Nullable(2)]
	private UUINiagara ProgressEffect;

	// Token: 0x0400865B RID: 34395
	[Nullable(2)]
	private UUIItem AnimItem;

	// Token: 0x0400865C RID: 34396
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400865D RID: 34397
	private readonly List<LevelSequencePlayer> LevelSequencePlayerList = new List<LevelSequencePlayer>();

	// Token: 0x0400865E RID: 34398
	private readonly List<UUIItem> KeyboardEffectList = new List<UUIItem>();

	// Token: 0x0400865F RID: 34399
	private readonly List<UUIItem> GamepadEffectList = new List<UUIItem>();

	// Token: 0x04008660 RID: 34400
	[Nullable(2)]
	private TimerHandle DelayTimer;

	// Token: 0x04008661 RID: 34401
	private Number DurationMs = 0;

	// Token: 0x04008662 RID: 34402
	private const int STOP_ANIM_TIME = 333;

	// Token: 0x04008663 RID: 34403
	[StaticVariableRuleIgnore]
	private static readonly string[] ActionNames = new string[]
	{
		"QTE数字1",
		"QTE数字2",
		"QTE数字3",
		"QTE数字4"
	};

	// Token: 0x02008886 RID: 34950
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x0402C5F7 RID: 181751
		AnimItem,
		// Token: 0x0402C5F8 RID: 181752
		AnimItem1,
		// Token: 0x0402C5F9 RID: 181753
		AnimItem2,
		// Token: 0x0402C5FA RID: 181754
		AnimItem3,
		// Token: 0x0402C5FB RID: 181755
		AnimItem4,
		// Token: 0x0402C5FC RID: 181756
		ProgressTexture,
		// Token: 0x0402C5FD RID: 181757
		ProgressEffect,
		// Token: 0x0402C5FE RID: 181758
		BtnItem1,
		// Token: 0x0402C5FF RID: 181759
		BtnItem2,
		// Token: 0x0402C600 RID: 181760
		BtnItem3,
		// Token: 0x0402C601 RID: 181761
		BtnItem4
	}

	// Token: 0x02008887 RID: 34951
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x0402C603 RID: 181763
		AnimItem,
		// Token: 0x0402C604 RID: 181764
		AnimItem1,
		// Token: 0x0402C605 RID: 181765
		AnimItem2,
		// Token: 0x0402C606 RID: 181766
		AnimItem3,
		// Token: 0x0402C607 RID: 181767
		AnimItem4,
		// Token: 0x0402C608 RID: 181768
		ProgressTexture,
		// Token: 0x0402C609 RID: 181769
		ProgressEffect,
		// Token: 0x0402C60A RID: 181770
		KeyItem1,
		// Token: 0x0402C60B RID: 181771
		KeyItem2,
		// Token: 0x0402C60C RID: 181772
		KeyItem3,
		// Token: 0x0402C60D RID: 181773
		KeyItem4,
		// Token: 0x0402C60E RID: 181774
		KeyboardEffectItem1,
		// Token: 0x0402C60F RID: 181775
		KeyboardEffectItem2,
		// Token: 0x0402C610 RID: 181776
		KeyboardEffectItem3,
		// Token: 0x0402C611 RID: 181777
		KeyboardEffectItem4,
		// Token: 0x0402C612 RID: 181778
		GamepadEffectItem1,
		// Token: 0x0402C613 RID: 181779
		GamepadEffectItem2,
		// Token: 0x0402C614 RID: 181780
		GamepadEffectItem3,
		// Token: 0x0402C615 RID: 181781
		GamepadEffectItem4
	}
}
