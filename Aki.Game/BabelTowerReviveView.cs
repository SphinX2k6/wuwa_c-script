using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000639 RID: 1593
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerReviveView : UiViewBase
{
	// Token: 0x06004A33 RID: 18995 RVA: 0x001938B5 File Offset: 0x00191AB5
	[NullableContext(1)]
	public BabelTowerReviveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06004A34 RID: 18996 RVA: 0x001938C0 File Offset: 0x00191AC0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06004A35 RID: 18997 RVA: 0x00193A34 File Offset: 0x00191C34
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerReviveView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerReviveView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06004A36 RID: 18998 RVA: 0x00193A77 File Offset: 0x00191C77
	private void OnCancelButtonClick()
	{
		BabelTowerController.Instance.BabelTowerSettlementRequest();
		base.CloseMe(null);
	}

	// Token: 0x06004A37 RID: 18999 RVA: 0x00193A8C File Offset: 0x00191C8C
	private void OnConfirmButtonClick()
	{
		DeadReviveController.Instance.ReviveRequest(false, null, null);
		base.CloseMe(null);
	}

	// Token: 0x06004A38 RID: 19000 RVA: 0x00193AB8 File Offset: 0x00191CB8
	public void Refresh()
	{
		IBabelTowerReviveViewData data = this.Data;
		BabelTowerLevel value = ConfigBabelTowerLevelById.GetConfig(data.LevelId, true).Value;
		int starNum = data.StarNum;
		int reviveStar = value.ReviveStar;
		int num = Math.Max(0, starNum - reviveStar);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "Text_BabelTowerReviveStarsNeed_Text", new <>z__ReadOnlySingleElementList<object>(reviveStar));
		int passStar = value.PassStar;
		bool flag = num < passStar;
		base.GetItem(9).SetUIActive(flag);
		base.GetArtText(2).SetText(starNum.ToString());
		UUIArtText artText = base.GetArtText(3);
		artText.SetText(num.ToString());
		UUIItem uuiitem = artText;
		bool bUseChangeColor = !flag;
		FColor? fcolor = new FColor?(artText.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		int reviveBuffId = value.ReviveBuffId;
		BabelTowerBuffItemData data2 = new BabelTowerBuffItemData
		{
			Id = reviveBuffId,
			IsDeTerm = false,
			CanClick = false,
			ShowStar = new bool?(false)
		};
		this.BuffItem.Refresh(data2, false, 0);
		BabelTowerBuff value2 = ConfigBabelTowerBuffById.GetConfig(reviveBuffId, true).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value2.NameText, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), value2.DesText, Array.Empty<object>());
	}

	// Token: 0x04003704 RID: 14084
	private IBabelTowerReviveViewData Data;

	// Token: 0x04003705 RID: 14085
	private ButtonItem CancelButtonItem;

	// Token: 0x04003706 RID: 14086
	private ButtonItem ConfirmButtonItem;

	// Token: 0x04003707 RID: 14087
	private BabelTowerBuffItem BuffItem;

	// Token: 0x020068ED RID: 26861
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022941 RID: 141633
		public const int TitleText = 0;

		// Token: 0x04022942 RID: 141634
		public const int TipText = 1;

		// Token: 0x04022943 RID: 141635
		public const int SrcArtText = 2;

		// Token: 0x04022944 RID: 141636
		public const int DestArtText = 3;

		// Token: 0x04022945 RID: 141637
		public const int BuffItem = 4;

		// Token: 0x04022946 RID: 141638
		public const int BuffNameText = 5;

		// Token: 0x04022947 RID: 141639
		public const int BuffDescText = 6;

		// Token: 0x04022948 RID: 141640
		public const int CancelButtonItem = 7;

		// Token: 0x04022949 RID: 141641
		public const int ConfirmButtonItem = 8;

		// Token: 0x0402294A RID: 141642
		public const int LowStarTipItem = 9;
	}
}
