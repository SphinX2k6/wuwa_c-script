using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002304 RID: 8964
[NullableContext(1)]
[Nullable(0)]
public class FrozenQteView : PanelQteView
{
	// Token: 0x06011B0B RID: 72459 RVA: 0x004591C2 File Offset: 0x004573C2
	public FrozenQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011B0C RID: 72460 RVA: 0x004591E4 File Offset: 0x004573E4
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num;
		Span<ValueTuple<int, Type>> span;
		int num2;
		if (this.IsMobile)
		{
			num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
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

	// Token: 0x06011B0D RID: 72461 RVA: 0x00459320 File Offset: 0x00457520
	protected override void OnStart()
	{
		base.OnStart();
		if (this.IsMobile)
		{
			UUIButtonComponent button = base.GetButton(0);
			UUIButtonComponent button2 = base.GetButton(1);
			button.OnPointDownCallBack.Bind(delegate()
			{
				this.OnPress(0);
			});
			button2.OnPointDownCallBack.Bind(delegate()
			{
				this.OnPress(1);
			});
			QteAnimItem qteAnimItem = new QteAnimItem();
			qteAnimItem.Init(base.GetItem(2));
			qteAnimItem.StartAnim(0f);
			QteAnimItem qteAnimItem2 = new QteAnimItem();
			qteAnimItem2.Init(base.GetItem(3));
			qteAnimItem2.StartAnim(230f);
			this.AnimItemList.Add(qteAnimItem);
			this.AnimItemList.Add(qteAnimItem2);
		}
		else
		{
			QteAnimItem qteAnimItem3 = new QteAnimItem();
			qteAnimItem3.Init(base.GetItem(2));
			qteAnimItem3.StartAnim(0f);
			this.AnimItemList.Add(qteAnimItem3);
			this.InputControllerChangeInner();
		}
		this.TipItem = new QteTipItem();
		this.TipItem.Init(this.RootItem);
		this.TipItem.Refresh("Text_FrozenQteTip_Text");
		this.InitQteData();
	}

	// Token: 0x06011B0E RID: 72462 RVA: 0x00459434 File Offset: 0x00457634
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.CloseMe(null);
		}
	}

	// Token: 0x06011B0F RID: 72463 RVA: 0x00459480 File Offset: 0x00457680
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		if (this.IsMobile)
		{
			UUIButtonComponent button = base.GetButton(0);
			UUIButtonComponent button2 = base.GetButton(1);
			button.OnPointDownCallBack.Unbind();
			button2.OnPointDownCallBack.Unbind();
		}
		foreach (QteAnimItem qteAnimItem in this.AnimItemList)
		{
			qteAnimItem.Clear();
		}
		this.StopDelayTimer();
		this.TipItem.Destroy(null);
		this.TipItem = null;
	}

	// Token: 0x06011B10 RID: 72464 RVA: 0x0045951C File Offset: 0x0045771C
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x06011B11 RID: 72465 RVA: 0x00459540 File Offset: 0x00457740
	private void InitQteData()
	{
		this.InputCount = 0;
		int num = (int)(this.OpenParam ?? 0);
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.CloseMe(null);
			return;
		}
		PanelQteContext context = PanelQteModel.Instance.GetContext();
		if (num != context.QteHandleId)
		{
			Log.Instance.Error(ELogModule.PanelQte, ELogAuthor.CFT, "qte handleId 不匹配", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.CloseMe(null);
			return;
		}
		int maxSuccessCount = context.Config.MaxSuccessCount;
		int minSuccessCount = context.Config.MinSuccessCount;
		this.MaxCount = (int)Math.Floor((double)MathUtils.Instance.GetRandomFloatNumber((float)minSuccessCount, (float)(maxSuccessCount + 1)));
		base.InitCameraShake(context.Config);
		base.InitBuff(context.Config);
	}

	// Token: 0x06011B12 RID: 72466 RVA: 0x0045962C File Offset: 0x0045782C
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputCallback));
		}
	}

	// Token: 0x06011B13 RID: 72467 RVA: 0x00459657 File Offset: 0x00457857
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputCallback));
		}
	}

	// Token: 0x06011B14 RID: 72468 RVA: 0x00459684 File Offset: 0x00457884
	protected override void InputControllerChangeInner()
	{
		bool flag = Info.Instance.IsInGamepad();
		UUIItem item = base.GetItem(0);
		UUIItem item2 = base.GetItem(1);
		item.SetUIActive(!flag);
		item2.SetUIActive(flag);
	}

	// Token: 0x06011B15 RID: 72469 RVA: 0x004596BC File Offset: 0x004578BC
	private void OnInputCallback(string axisName, float value, InputIdentification identification)
	{
		if (this.IsQteEnd)
		{
			return;
		}
		if (value > 0f)
		{
			this.AnimItemList[0].PressAnim();
			this.OnInput(1);
			return;
		}
		if (value < 0f)
		{
			this.AnimItemList[0].PressAnim();
			this.OnInput(0);
		}
	}

	// Token: 0x06011B16 RID: 72470 RVA: 0x00459713 File Offset: 0x00457913
	private void OnPress(int index)
	{
		if (this.IsQteEnd)
		{
			return;
		}
		this.AnimItemList[index].PressAnim();
		this.OnInput(index);
	}

	// Token: 0x06011B17 RID: 72471 RVA: 0x00459738 File Offset: 0x00457938
	private void OnInput(int index)
	{
		this.Input[index] = true;
		if (this.Input[0] && this.Input[1])
		{
			this.Input[0] = false;
			this.Input[1] = false;
			this.InputCount++;
			if (this.InputCount == this.MaxCount)
			{
				int handleId = (int)(this.OpenParam ?? 0);
				PanelQteModel.Instance.SetQteResult(handleId, true);
				PanelQteController.Instance.StopQte(handleId, false);
			}
		}
		base.PlayCameraShake();
		base.AddBuff();
	}

	// Token: 0x06011B18 RID: 72472 RVA: 0x004597CC File Offset: 0x004579CC
	protected override void HandleQteEnd()
	{
		if (this.DelayTimer != null)
		{
			return;
		}
		foreach (QteAnimItem qteAnimItem in this.AnimItemList)
		{
			qteAnimItem.StopAnim();
		}
		this.DelayTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			this.DelayTimer = null;
			base.CloseMe(null);
		}, 100f, null, null, true, 1f);
	}

	// Token: 0x04008636 RID: 34358
	private int InputCount;

	// Token: 0x04008637 RID: 34359
	private int MaxCount;

	// Token: 0x04008638 RID: 34360
	private readonly bool[] Input = new bool[2];

	// Token: 0x04008639 RID: 34361
	private readonly List<QteAnimItem> AnimItemList = new List<QteAnimItem>();

	// Token: 0x0400863A RID: 34362
	[Nullable(2)]
	private TimerHandle DelayTimer;

	// Token: 0x0400863B RID: 34363
	[Nullable(2)]
	private QteTipItem TipItem;

	// Token: 0x0400863C RID: 34364
	private const int STOP_ANIM_TIME = 100;

	// Token: 0x0400863D RID: 34365
	private const int LOOP_ANIM_TIME = 230;

	// Token: 0x02008880 RID: 34944
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x0402C5E1 RID: 181729
		BtnClickLeft,
		// Token: 0x0402C5E2 RID: 181730
		BtnClickRight,
		// Token: 0x0402C5E3 RID: 181731
		ItemLeft,
		// Token: 0x0402C5E4 RID: 181732
		ItemRight
	}

	// Token: 0x02008881 RID: 34945
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x0402C5E6 RID: 181734
		KeyboardItem,
		// Token: 0x0402C5E7 RID: 181735
		GamepadItem,
		// Token: 0x0402C5E8 RID: 181736
		AnimItem
	}
}
