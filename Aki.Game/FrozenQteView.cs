using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017E8 RID: 6120
[NullableContext(1)]
[Nullable(0)]
public class FrozenQteView : PanelQteView
{
	// Token: 0x0600EFA3 RID: 61347 RVA: 0x00465EA2 File Offset: 0x004640A2
	public FrozenQteView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EFA4 RID: 61348 RVA: 0x00465EC4 File Offset: 0x004640C4
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
		*span[num] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num++;
		*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list2;
	}

	// Token: 0x0600EFA5 RID: 61349 RVA: 0x00466040 File Offset: 0x00464240
	protected override UniTask OnBeforeStartAsync()
	{
		FrozenQteView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FrozenQteView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFA6 RID: 61350 RVA: 0x00466084 File Offset: 0x00464284
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<InputMultiKeyItem> NewKeyItem(int childType)
	{
		FrozenQteView.<NewKeyItem>d__15 <NewKeyItem>d__;
		<NewKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<InputMultiKeyItem>.Create();
		<NewKeyItem>d__.<>4__this = this;
		<NewKeyItem>d__.childType = childType;
		<NewKeyItem>d__.<>1__state = -1;
		<NewKeyItem>d__.<>t__builder.Start<FrozenQteView.<NewKeyItem>d__15>(ref <NewKeyItem>d__);
		return <NewKeyItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFA7 RID: 61351 RVA: 0x004660D0 File Offset: 0x004642D0
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

	// Token: 0x0600EFA8 RID: 61352 RVA: 0x004661E4 File Offset: 0x004643E4
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		if (!PanelQteModel.Instance.IsInQte.GetValueOrDefault())
		{
			Log.Instance.Info(ELogModule.PanelQte, ELogAuthor.CFT, "界面打开时qte已经结束了", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.CloseMe(null);
		}
	}

	// Token: 0x0600EFA9 RID: 61353 RVA: 0x00466230 File Offset: 0x00464430
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

	// Token: 0x0600EFAA RID: 61354 RVA: 0x004662CC File Offset: 0x004644CC
	private void StopDelayTimer()
	{
		if (this.DelayTimer != null)
		{
			TimerSystem.Instance.Remove(this.DelayTimer);
			this.DelayTimer = null;
		}
	}

	// Token: 0x0600EFAB RID: 61355 RVA: 0x004662F0 File Offset: 0x004644F0
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

	// Token: 0x0600EFAC RID: 61356 RVA: 0x004663DC File Offset: 0x004645DC
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.BindAxis("MoveRight", new TInputHandle<float>(this.OnInputCallback));
		}
	}

	// Token: 0x0600EFAD RID: 61357 RVA: 0x00466407 File Offset: 0x00464607
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		if (!this.IsMobile)
		{
			InputDistributeController.Instance.UnBindAxis("MoveRight", new TInputHandle<float>(this.OnInputCallback));
		}
	}

	// Token: 0x0600EFAE RID: 61358 RVA: 0x00466434 File Offset: 0x00464634
	protected override void InputControllerChangeInner()
	{
		bool flag = Info.Instance.IsInGamepad();
		UUIItem item = base.GetItem(0);
		UUIItem item2 = base.GetItem(1);
		item.SetUIActive(!flag);
		item2.SetUIActive(flag);
		if (!flag)
		{
			this.RefreshKeyName(this.LeftKeyItem, "MoveRight", 0);
			this.RefreshKeyName(this.RightKeyItem, "MoveRight", 1);
		}
	}

	// Token: 0x0600EFAF RID: 61359 RVA: 0x00466494 File Offset: 0x00464694
	private void RefreshKeyName([Nullable(2)] InputMultiKeyItem keyItem, string actionName, int index)
	{
		if (keyItem == null)
		{
			return;
		}
		InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
		{
			ActionOrAxisName = actionName,
			Index = new int?(index)
		};
		keyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
	}

	// Token: 0x0600EFB0 RID: 61360 RVA: 0x004664C8 File Offset: 0x004646C8
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

	// Token: 0x0600EFB1 RID: 61361 RVA: 0x0046651F File Offset: 0x0046471F
	private void OnPress(int index)
	{
		if (this.IsQteEnd)
		{
			return;
		}
		this.AnimItemList[index].PressAnim();
		this.OnInput(index);
	}

	// Token: 0x0600EFB2 RID: 61362 RVA: 0x00466544 File Offset: 0x00464744
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

	// Token: 0x0600EFB3 RID: 61363 RVA: 0x004665D8 File Offset: 0x004647D8
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

	// Token: 0x04008774 RID: 34676
	private int InputCount;

	// Token: 0x04008775 RID: 34677
	private int MaxCount;

	// Token: 0x04008776 RID: 34678
	private readonly bool[] Input = new bool[2];

	// Token: 0x04008777 RID: 34679
	private readonly List<QteAnimItem> AnimItemList = new List<QteAnimItem>();

	// Token: 0x04008778 RID: 34680
	[Nullable(2)]
	private TimerHandle DelayTimer;

	// Token: 0x04008779 RID: 34681
	[Nullable(2)]
	private QteTipItem TipItem;

	// Token: 0x0400877A RID: 34682
	[Nullable(2)]
	private InputMultiKeyItem LeftKeyItem;

	// Token: 0x0400877B RID: 34683
	[Nullable(2)]
	private InputMultiKeyItem RightKeyItem;

	// Token: 0x0400877C RID: 34684
	private const int STOP_ANIM_TIME = 100;

	// Token: 0x0400877D RID: 34685
	private const int LOOP_ANIM_TIME = 230;

	// Token: 0x02007A04 RID: 31236
	[NullableContext(0)]
	private enum EPadChildType
	{
		// Token: 0x040278E3 RID: 162019
		BtnClickLeft,
		// Token: 0x040278E4 RID: 162020
		BtnClickRight,
		// Token: 0x040278E5 RID: 162021
		ItemLeft,
		// Token: 0x040278E6 RID: 162022
		ItemRight
	}

	// Token: 0x02007A05 RID: 31237
	[NullableContext(0)]
	private enum EDesktopChildType
	{
		// Token: 0x040278E8 RID: 162024
		KeyboardItem,
		// Token: 0x040278E9 RID: 162025
		GamepadItem,
		// Token: 0x040278EA RID: 162026
		AnimItem,
		// Token: 0x040278EB RID: 162027
		LeftKeyItem,
		// Token: 0x040278EC RID: 162028
		RightKeyItem
	}
}
