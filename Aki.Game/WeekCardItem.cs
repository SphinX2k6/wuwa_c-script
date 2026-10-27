using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020023AA RID: 9130
[NullableContext(1)]
[Nullable(0)]
public class WeekCardItem : UiPanelBase
{
	// Token: 0x0601240E RID: 74766 RVA: 0x0047E7F8 File Offset: 0x0047C9F8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickConfirm));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601240F RID: 74767 RVA: 0x0047E9A8 File Offset: 0x0047CBA8
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<WeekCardRewardGrid, IWeekRewardData>(base.GetHorizontalLayout(1), () => new WeekCardRewardGrid(), null, false, true);
	}

	// Token: 0x06012410 RID: 74768 RVA: 0x0047E9E0 File Offset: 0x0047CBE0
	public void Refresh(WeekCardViewModel vm, WeekCardContentInfo info)
	{
		this.Vm = vm;
		this.ContentId = info.WeekCardContentId;
		this.Status = (EContentStatus)info.Status;
		this.UnlockDay = info.UnlockDay;
		this.UnlockTimeStamp = info.UnlockTimeStamp;
		this.RewardContent = new List<Tuple<int, int>>();
		foreach (KeyValuePair<int, int> keyValuePair in info.RewardContent)
		{
			this.RewardContent.Add(new Tuple<int, int>(keyValuePair.Key, keyValuePair.Value));
		}
		this.IsBuy = vm.IsBuy();
		this.RefreshView();
	}

	// Token: 0x06012411 RID: 74769 RVA: 0x0047EA98 File Offset: 0x0047CC98
	public void RefreshView()
	{
		this.RefreshRewardTexture();
		List<IWeekRewardData> list = new List<IWeekRewardData>();
		foreach (Tuple<int, int> tuple in this.RewardContent)
		{
			list.Add(new WeekRewardData
			{
				ItemId = tuple.Item1,
				Count = tuple.Item2
			});
		}
		this.RewardLayout.RefreshByData(list, null, false);
		base.GetItem(5).SetUIActive(this.IsBuy && this.Status == EContentStatus.CanReceive);
		base.GetItem(6).SetUIActive(this.IsBuy && this.Status == EContentStatus.Received);
		base.GetItem(8).SetAlpha((this.Status == EContentStatus.Received) ? 0.5f : 1f);
		this.ConfirmButton.SetUiActive(this.IsBuy && this.Status == EContentStatus.CanReceive);
		base.GetItem(7).SetUIActive(this.Status == EContentStatus.CanReceive);
		this.RefreshTime();
	}

	// Token: 0x06012412 RID: 74770 RVA: 0x0047EBBC File Offset: 0x0047CDBC
	private void RefreshRewardTexture()
	{
		WeekCardViewModel vm = this.Vm;
		string text = (vm != null) ? vm.GetContentRewardTexturePath(this.ContentId) : null;
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		base.SetTextureByPath(text, base.GetTexture(9), null, null);
	}

	// Token: 0x06012413 RID: 74771 RVA: 0x0047EC04 File Offset: 0x0047CE04
	public void RefreshTime()
	{
		base.GetText(4).SetUIActive(this.Status == EContentStatus.CannotReceive);
		if (this.IsBuy)
		{
			CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(TimeUtil.Instance.SetTimeSecond((double)this.UnlockTimeStamp - TimeUtil.Instance.GetServerTimeStamp()));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "WeekCard_1002", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText ?? ""));
			return;
		}
		if (this.UnlockDay == 1)
		{
			base.GetText(4).ShowTextNew("WeekCard_1001");
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "WeekCard_1006", new <>z__ReadOnlySingleElementList<object>(this.UnlockDay));
	}

	// Token: 0x06012414 RID: 74772 RVA: 0x0047ECC1 File Offset: 0x0047CEC1
	private void OnClickConfirm()
	{
		if (this.Status != EContentStatus.CanReceive)
		{
			return;
		}
		WeekCardViewModel vm = this.Vm;
		if (vm == null)
		{
			return;
		}
		vm.OnReceiveReward(this.ContentId).Forget<bool>();
	}

	// Token: 0x040089DB RID: 35291
	private int ContentId;

	// Token: 0x040089DC RID: 35292
	private EContentStatus Status;

	// Token: 0x040089DD RID: 35293
	private int UnlockDay;

	// Token: 0x040089DE RID: 35294
	private long UnlockTimeStamp;

	// Token: 0x040089DF RID: 35295
	private List<Tuple<int, int>> RewardContent = new List<Tuple<int, int>>();

	// Token: 0x040089E0 RID: 35296
	private bool IsBuy;

	// Token: 0x040089E1 RID: 35297
	private readonly ButtonItem ConfirmButton = new ButtonItem(null);

	// Token: 0x040089E2 RID: 35298
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeekCardRewardGrid, IWeekRewardData> RewardLayout;

	// Token: 0x040089E3 RID: 35299
	[Nullable(2)]
	private WeekCardViewModel Vm;

	// Token: 0x02008946 RID: 35142
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402C9FC RID: 182780
		public const int ButtonWeekCardReward = 0;

		// Token: 0x0402C9FD RID: 182781
		public const int PanelRewardLayout = 1;

		// Token: 0x0402C9FE RID: 182782
		public const int PanelRewardItem = 2;

		// Token: 0x0402C9FF RID: 182783
		public const int PanelLock = 3;

		// Token: 0x0402CA00 RID: 182784
		public const int TextLock = 4;

		// Token: 0x0402CA01 RID: 182785
		public const int PanelReceive = 5;

		// Token: 0x0402CA02 RID: 182786
		public const int PanelFinish = 6;

		// Token: 0x0402CA03 RID: 182787
		public const int PanelRedDot = 7;

		// Token: 0x0402CA04 RID: 182788
		public const int PanelFinishAlpha = 8;

		// Token: 0x0402CA05 RID: 182789
		public const int RewardTexture = 9;
	}
}
