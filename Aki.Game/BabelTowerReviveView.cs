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

// Token: 0x02001185 RID: 4485
[NullableContext(2)]
[Nullable(0)]
public class BabelTowerReviveView : UiViewBase
{
	// Token: 0x0600769C RID: 30364 RVA: 0x0018AD05 File Offset: 0x00188F05
	[NullableContext(1)]
	public BabelTowerReviveView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600769D RID: 30365 RVA: 0x0018AD10 File Offset: 0x00188F10
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

	// Token: 0x0600769E RID: 30366 RVA: 0x0018AE84 File Offset: 0x00189084
	protected override UniTask OnBeforeStartAsync()
	{
		BabelTowerReviveView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<BabelTowerReviveView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600769F RID: 30367 RVA: 0x0018AEC7 File Offset: 0x001890C7
	private void OnCancelButtonClick()
	{
		BabelTowerController.Instance.BabelTowerSettlementRequest();
		base.CloseMe(null);
	}

	// Token: 0x060076A0 RID: 30368 RVA: 0x0018AEDC File Offset: 0x001890DC
	private void OnConfirmButtonClick()
	{
		DeadReviveController.Instance.ReviveRequest(false, null, null);
		base.CloseMe(null);
	}

	// Token: 0x060076A1 RID: 30369 RVA: 0x0018AF08 File Offset: 0x00189108
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

	// Token: 0x0400366B RID: 13931
	private IBabelTowerReviveViewData Data;

	// Token: 0x0400366C RID: 13932
	private ButtonItem CancelButtonItem;

	// Token: 0x0400366D RID: 13933
	private ButtonItem ConfirmButtonItem;

	// Token: 0x0400366E RID: 13934
	private BabelTowerBuffItem BuffItem;

	// Token: 0x02007760 RID: 30560
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027608 RID: 161288
		public const int TitleText = 0;

		// Token: 0x04027609 RID: 161289
		public const int TipText = 1;

		// Token: 0x0402760A RID: 161290
		public const int SrcArtText = 2;

		// Token: 0x0402760B RID: 161291
		public const int DestArtText = 3;

		// Token: 0x0402760C RID: 161292
		public const int BuffItem = 4;

		// Token: 0x0402760D RID: 161293
		public const int BuffNameText = 5;

		// Token: 0x0402760E RID: 161294
		public const int BuffDescText = 6;

		// Token: 0x0402760F RID: 161295
		public const int CancelButtonItem = 7;

		// Token: 0x04027610 RID: 161296
		public const int ConfirmButtonItem = 8;

		// Token: 0x04027611 RID: 161297
		public const int LowStarTipItem = 9;
	}
}
