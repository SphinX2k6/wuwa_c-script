using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029C1 RID: 10689
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerRecordView : UiViewBase
{
	// Token: 0x0601627D RID: 90749 RVA: 0x0059A513 File Offset: 0x00598713
	public ShipTowerRecordView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601627E RID: 90750 RVA: 0x0059A51C File Offset: 0x0059871C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601627F RID: 90751 RVA: 0x0059A6D3 File Offset: 0x005988D3
	private void InitDataParam()
	{
		this.AreaList = ShipTowerModel.Instance.RecordList;
		this.StageData = ShipTowerModel.Instance.GetEndlessStageData();
	}

	// Token: 0x06016280 RID: 90752 RVA: 0x0059A6F8 File Offset: 0x005988F8
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRecordView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRecordView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016281 RID: 90753 RVA: 0x0059A73C File Offset: 0x0059893C
	protected override void OnStart()
	{
		ShipTowerStageData stageData = this.StageData;
		string key = ((stageData != null) ? stageData.TitleKey : null) ?? "";
		base.GetText(5).ShowTextNew(key);
	}

	// Token: 0x06016282 RID: 90754 RVA: 0x0059A772 File Offset: 0x00598972
	private ShipTowerAreaItem CreateAreaItem()
	{
		return new ShipTowerAreaItem
		{
			ClickCallBack = new Action<ShipTowerAreaItemData>(this.OnAreaItemClick)
		};
	}

	// Token: 0x06016283 RID: 90755 RVA: 0x0059A78C File Offset: 0x0059898C
	private void OnAreaItemClick(ShipTowerAreaItemData data)
	{
		this.SelectData = data;
		List<ShipTowerRecordItemData> recordList = data.RecordList;
		bool flag;
		if (recordList == null)
		{
			flag = false;
		}
		else
		{
			flag = recordList.Any((ShipTowerRecordItemData value) => value.TeamList.Count > 0);
		}
		List<ShipTowerRecordItemData> recordList2 = data.RecordList;
		bool flag2;
		if (recordList2 == null)
		{
			flag2 = false;
		}
		else
		{
			flag2 = recordList2.Any((ShipTowerRecordItemData value) => value.BuffId > 0);
		}
		bool flag3 = flag2;
		bool flag4 = flag && flag3;
		this.SetEmptyState(!flag4);
		if (flag4 && data.RecordList != null)
		{
			GenericLayout<ShipTowerRecordItem, ShipTowerRecordItemData> layoutInfo = this.LayoutInfo;
			if (layoutInfo != null)
			{
				layoutInfo.RefreshByData(data.RecordList, null, true);
			}
		}
		List<ShipTowerRecordItemData> recordList3 = data.RecordList;
		int num;
		if (recordList3 == null)
		{
			num = 0;
		}
		else
		{
			num = recordList3.Sum((ShipTowerRecordItemData value) => value.Score);
		}
		int score = num;
		List<ShipTowerRecordItemData> recordList4 = data.RecordList;
		int num2;
		if (recordList4 == null)
		{
			num2 = 0;
		}
		else
		{
			num2 = recordList4.Sum((ShipTowerRecordItemData value) => value.Wave);
		}
		int num3 = num2;
		base.GetText(6).SetText(score.ToString(), true);
		base.GetText(7).SetText(num3.ToString(), true);
		UUITexture texture = base.GetTexture(8);
		ShipTowerStageData stageData = this.StageData;
		string text = (stageData != null) ? stageData.GetStageGradeResIdByScore(score) : null;
		bool flag5 = text != null;
		if (texture != null)
		{
			texture.SetUIActive(flag5);
		}
		if (flag5 && text != null)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}
		base.PlaySequence("Switch", null, false);
		this.RefreshShareBtn();
	}

	// Token: 0x06016284 RID: 90756 RVA: 0x0059A930 File Offset: 0x00598B30
	private void SetEmptyState(bool isShow)
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(!isShow);
		}
		UUIItem item2 = base.GetItem(3);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(isShow);
	}

	// Token: 0x06016285 RID: 90757 RVA: 0x0059A95A File Offset: 0x00598B5A
	private int GetSelectAreaIndex()
	{
		return 0;
	}

	// Token: 0x06016286 RID: 90758 RVA: 0x0059A960 File Offset: 0x00598B60
	private void OnShareBtnClicked()
	{
		ShipTowerAreaItemData selectData = this.SelectData;
		if (selectData == null || selectData.RecordList == null || selectData.RecordList.Count <= 0)
		{
			return;
		}
		int num = 0;
		int num2 = 0;
		foreach (ShipTowerRecordItemData shipTowerRecordItemData in selectData.RecordList)
		{
			num += shipTowerRecordItemData.Score;
			num2 += shipTowerRecordItemData.Wave;
		}
		ShipTowerStageData stageData = this.StageData;
		string gradeResId = (stageData != null) ? stageData.GetShareStageGradeResIdByScore(num) : null;
		ShipTowerRecordShareData shipTowerRecordShareData = new ShipTowerRecordShareData
		{
			AreaTitle = selectData.Name,
			TotalScore = num,
			TotalWave = num2,
			GradeResId = gradeResId,
			RecordList = selectData.RecordList,
			DateText = selectData.TimeContent
		};
		PhotoSaveViewParam param = new PhotoSaveViewParam
		{
			ScreenShot = false,
			PrepareFullScreenShot = false,
			IsHiddenBattleView = false,
			HandBookPhotoData = null,
			GachaData = null,
			FragmentMemory = null,
			RoleSkinData = null,
			ShareId = 13,
			ShipTowerRecordShareData = shipTowerRecordShareData
		};
		UiManager.Instance.OpenView(EUiViewName.PhotoSaveView, param, null);
	}

	// Token: 0x06016287 RID: 90759 RVA: 0x0059AA98 File Offset: 0x00598C98
	private void RefreshShareBtn()
	{
		ShipTowerStageData stageData = this.StageData;
		bool flag = stageData != null && stageData.IsEndLess && this.AreaList.Count > 0;
		ShareBtnItem shareBtnItem = this.ShareBtnItem;
		if (shareBtnItem != null)
		{
			shareBtnItem.SetUiActive(flag);
		}
		if (flag)
		{
			ShareBtnItem shareBtnItem2 = this.ShareBtnItem;
			if (shareBtnItem2 == null)
			{
				return;
			}
			shareBtnItem2.SetShareActionId(EShareActionId.ChallengeRecord);
		}
	}

	// Token: 0x06016288 RID: 90760 RVA: 0x0059AAF2 File Offset: 0x00598CF2
	private ShipTowerRecordItem CreateRecordItem()
	{
		return new ShipTowerRecordItem();
	}

	// Token: 0x0400A505 RID: 42245
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A506 RID: 42246
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTowerAreaItem, ShipTowerAreaItemData> AreaLoopView;

	// Token: 0x0400A507 RID: 42247
	private List<ShipTowerAreaItemData> AreaList;

	// Token: 0x0400A508 RID: 42248
	[Nullable(2)]
	private ShipTowerAreaItemData SelectData;

	// Token: 0x0400A509 RID: 42249
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerRecordItem, ShipTowerRecordItemData> LayoutInfo;

	// Token: 0x0400A50A RID: 42250
	[Nullable(2)]
	private ShipTowerStageData StageData;

	// Token: 0x0400A50B RID: 42251
	[Nullable(2)]
	private ShareBtnItem ShareBtnItem;

	// Token: 0x02008FDC RID: 36828
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E962 RID: 190818
		public const int ItemCaption = 0;

		// Token: 0x0402E963 RID: 190819
		public const int ButtonHelp = 1;

		// Token: 0x0402E964 RID: 190820
		public const int LoopViewPeriod = 2;

		// Token: 0x0402E965 RID: 190821
		public const int ItemEmpty = 3;

		// Token: 0x0402E966 RID: 190822
		public const int ItemDescRoot = 4;

		// Token: 0x0402E967 RID: 190823
		public const int TextDungeonName = 5;

		// Token: 0x0402E968 RID: 190824
		public const int TextMaxScore = 6;

		// Token: 0x0402E969 RID: 190825
		public const int TextMaxWave = 7;

		// Token: 0x0402E96A RID: 190826
		public const int TextureGrade = 8;

		// Token: 0x0402E96B RID: 190827
		public const int VLayoutTeamRecord = 9;

		// Token: 0x0402E96C RID: 190828
		public const int ItemPeriod = 10;

		// Token: 0x0402E96D RID: 190829
		public const int ShareItem = 11;
	}
}
