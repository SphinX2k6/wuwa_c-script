using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017ED RID: 6125
[NullableContext(1)]
[Nullable(0)]
public class YouHuQteView : PanelQteView
{
	// Token: 0x0600EFF0 RID: 61424 RVA: 0x0046738C File Offset: 0x0046558C
	public YouHuQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EFF1 RID: 61425 RVA: 0x004673D8 File Offset: 0x004655D8
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

	// Token: 0x0600EFF2 RID: 61426 RVA: 0x00467818 File Offset: 0x00465A18
	protected override UniTask OnBeforeStartAsync()
	{
		YouHuQteView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<YouHuQteView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFF3 RID: 61427 RVA: 0x0046785C File Offset: 0x00465A5C
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

	// Token: 0x0600EFF4 RID: 61428 RVA: 0x00467A44 File Offset: 0x00465C44
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			UiManager.Instance.CloseView(EUiViewName.YouHuQteView, null);
		}
	}

	// Token: 0x0600EFF5 RID: 61429 RVA: 0x00467A98 File Offset: 0x00465C98
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

	// Token: 0x0600EFF6 RID: 61430 RVA: 0x00467B68 File Offset: 0x00465D68
	protected override void RefreshVisible()
	{
	}

	// Token: 0x0600EFF7 RID: 61431 RVA: 0x00467B6A File Offset: 0x00465D6A
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x0600EFF8 RID: 61432 RVA: 0x00467B8C File Offset: 0x00465D8C
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

	// Token: 0x0600EFF9 RID: 61433 RVA: 0x00467C78 File Offset: 0x00465E78
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

	// Token: 0x0600EFFA RID: 61434 RVA: 0x00467CC4 File Offset: 0x00465EC4
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

	// Token: 0x0600EFFB RID: 61435 RVA: 0x00467D37 File Offset: 0x00465F37
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.BindActions(YouHuQteView.ActionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x0600EFFC RID: 61436 RVA: 0x00467D62 File Offset: 0x00465F62
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.UnBindActions(YouHuQteView.ActionNames, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
		}
	}

	// Token: 0x0600EFFD RID: 61437 RVA: 0x00467D90 File Offset: 0x00465F90
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

	// Token: 0x0600EFFE RID: 61438 RVA: 0x00467DCC File Offset: 0x00465FCC
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

	// Token: 0x0600EFFF RID: 61439 RVA: 0x00467E45 File Offset: 0x00466045
	protected override void InputControllerChangeInner()
	{
		this.RefreshEffectVisible();
	}

	// Token: 0x0600F000 RID: 61440 RVA: 0x00467E50 File Offset: 0x00466050
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

	// Token: 0x0600F001 RID: 61441 RVA: 0x00467EF8 File Offset: 0x004660F8
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

	// Token: 0x04008798 RID: 34712
	private readonly List<InputMultiKeyItem> KeyItemList = new List<InputMultiKeyItem>();

	// Token: 0x04008799 RID: 34713
	[Nullable(2)]
	private UUITexture ProgressTexture;

	// Token: 0x0400879A RID: 34714
	[Nullable(2)]
	private UUINiagara ProgressEffect;

	// Token: 0x0400879B RID: 34715
	[Nullable(2)]
	private UUIItem AnimItem;

	// Token: 0x0400879C RID: 34716
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400879D RID: 34717
	private readonly List<LevelSequencePlayer> LevelSequencePlayerList = new List<LevelSequencePlayer>();

	// Token: 0x0400879E RID: 34718
	private readonly List<UUIItem> KeyboardEffectList = new List<UUIItem>();

	// Token: 0x0400879F RID: 34719
	private readonly List<UUIItem> GamepadEffectList = new List<UUIItem>();

	// Token: 0x040087A0 RID: 34720
	[Nullable(2)]
	private TimerHandle DelayTimer;

	// Token: 0x040087A1 RID: 34721
	private Number DurationMs = 0;

	// Token: 0x040087A2 RID: 34722
	private const int STOP_ANIM_TIME = 333;

	// Token: 0x040087A3 RID: 34723
	[StaticVariableRuleIgnore]
	private static readonly string[] ActionNames = new string[]
	{
		"QTE数字1",
		"QTE数字2",
		"QTE数字3",
		"QTE数字4"
	};

	// Token: 0x02007A0C RID: 31244
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x04027905 RID: 162053
		AnimItem,
		// Token: 0x04027906 RID: 162054
		AnimItem1,
		// Token: 0x04027907 RID: 162055
		AnimItem2,
		// Token: 0x04027908 RID: 162056
		AnimItem3,
		// Token: 0x04027909 RID: 162057
		AnimItem4,
		// Token: 0x0402790A RID: 162058
		ProgressTexture,
		// Token: 0x0402790B RID: 162059
		ProgressEffect,
		// Token: 0x0402790C RID: 162060
		BtnItem1,
		// Token: 0x0402790D RID: 162061
		BtnItem2,
		// Token: 0x0402790E RID: 162062
		BtnItem3,
		// Token: 0x0402790F RID: 162063
		BtnItem4
	}

	// Token: 0x02007A0D RID: 31245
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x04027911 RID: 162065
		AnimItem,
		// Token: 0x04027912 RID: 162066
		AnimItem1,
		// Token: 0x04027913 RID: 162067
		AnimItem2,
		// Token: 0x04027914 RID: 162068
		AnimItem3,
		// Token: 0x04027915 RID: 162069
		AnimItem4,
		// Token: 0x04027916 RID: 162070
		ProgressTexture,
		// Token: 0x04027917 RID: 162071
		ProgressEffect,
		// Token: 0x04027918 RID: 162072
		KeyItem1,
		// Token: 0x04027919 RID: 162073
		KeyItem2,
		// Token: 0x0402791A RID: 162074
		KeyItem3,
		// Token: 0x0402791B RID: 162075
		KeyItem4,
		// Token: 0x0402791C RID: 162076
		KeyboardEffectItem1,
		// Token: 0x0402791D RID: 162077
		KeyboardEffectItem2,
		// Token: 0x0402791E RID: 162078
		KeyboardEffectItem3,
		// Token: 0x0402791F RID: 162079
		KeyboardEffectItem4,
		// Token: 0x04027920 RID: 162080
		GamepadEffectItem1,
		// Token: 0x04027921 RID: 162081
		GamepadEffectItem2,
		// Token: 0x04027922 RID: 162082
		GamepadEffectItem3,
		// Token: 0x04027923 RID: 162083
		GamepadEffectItem4
	}
}
