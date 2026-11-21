using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200188F RID: 6287
[NullableContext(1)]
[Nullable(0)]
public class WeekCardItem : UiPanelBase
{
	// Token: 0x0600F8C0 RID: 63680 RVA: 0x0048BCCC File Offset: 0x00489ECC
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

	// Token: 0x0600F8C1 RID: 63681 RVA: 0x0048BE7C File Offset: 0x0048A07C
	protected override void OnStart()
	{
		this.RewardLayout = new GenericLayout<WeekCardRewardGrid, IWeekRewardData>(base.GetHorizontalLayout(1), () => new WeekCardRewardGrid(), null, false, true);
	}

	// Token: 0x0600F8C2 RID: 63682 RVA: 0x0048BEB4 File Offset: 0x0048A0B4
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

	// Token: 0x0600F8C3 RID: 63683 RVA: 0x0048BF6C File Offset: 0x0048A16C
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

	// Token: 0x0600F8C4 RID: 63684 RVA: 0x0048C090 File Offset: 0x0048A290
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

	// Token: 0x0600F8C5 RID: 63685 RVA: 0x0048C0D8 File Offset: 0x0048A2D8
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

	// Token: 0x0600F8C6 RID: 63686 RVA: 0x0048C195 File Offset: 0x0048A395
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

	// Token: 0x04008B22 RID: 35618
	private int ContentId;

	// Token: 0x04008B23 RID: 35619
	private EContentStatus Status;

	// Token: 0x04008B24 RID: 35620
	private int UnlockDay;

	// Token: 0x04008B25 RID: 35621
	private long UnlockTimeStamp;

	// Token: 0x04008B26 RID: 35622
	private List<Tuple<int, int>> RewardContent = new List<Tuple<int, int>>();

	// Token: 0x04008B27 RID: 35623
	private bool IsBuy;

	// Token: 0x04008B28 RID: 35624
	private readonly ButtonItem ConfirmButton = new ButtonItem(null);

	// Token: 0x04008B29 RID: 35625
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<WeekCardRewardGrid, IWeekRewardData> RewardLayout;

	// Token: 0x04008B2A RID: 35626
	[Nullable(2)]
	private WeekCardViewModel Vm;

	// Token: 0x02007ACF RID: 31439
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x04027D17 RID: 163095
		public const int ButtonWeekCardReward = 0;

		// Token: 0x04027D18 RID: 163096
		public const int PanelRewardLayout = 1;

		// Token: 0x04027D19 RID: 163097
		public const int PanelRewardItem = 2;

		// Token: 0x04027D1A RID: 163098
		public const int PanelLock = 3;

		// Token: 0x04027D1B RID: 163099
		public const int TextLock = 4;

		// Token: 0x04027D1C RID: 163100
		public const int PanelReceive = 5;

		// Token: 0x04027D1D RID: 163101
		public const int PanelFinish = 6;

		// Token: 0x04027D1E RID: 163102
		public const int PanelRedDot = 7;

		// Token: 0x04027D1F RID: 163103
		public const int PanelFinishAlpha = 8;

		// Token: 0x04027D20 RID: 163104
		public const int RewardTexture = 9;
	}
}
