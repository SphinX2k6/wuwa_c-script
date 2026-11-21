using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F3C RID: 7996
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerRecordView : UiViewBase
{
	// Token: 0x06013C83 RID: 81027 RVA: 0x005C549F File Offset: 0x005C369F
	public ShipTowerRecordView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013C84 RID: 81028 RVA: 0x005C54A8 File Offset: 0x005C36A8
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

	// Token: 0x06013C85 RID: 81029 RVA: 0x005C565F File Offset: 0x005C385F
	private void InitDataParam()
	{
		this.AreaList = ShipTowerModel.Instance.RecordList;
		this.StageData = ShipTowerModel.Instance.GetEndlessStageData();
	}

	// Token: 0x06013C86 RID: 81030 RVA: 0x005C5684 File Offset: 0x005C3884
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRecordView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRecordView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C87 RID: 81031 RVA: 0x005C56C8 File Offset: 0x005C38C8
	protected override void OnStart()
	{
		ShipTowerStageData stageData = this.StageData;
		string key = ((stageData != null) ? stageData.TitleKey : null) ?? "";
		base.GetText(5).ShowTextNew(key);
	}

	// Token: 0x06013C88 RID: 81032 RVA: 0x005C56FE File Offset: 0x005C38FE
	private ShipTowerAreaItem CreateAreaItem()
	{
		return new ShipTowerAreaItem
		{
			ClickCallBack = new Action<ShipTowerAreaItemData>(this.OnAreaItemClick)
		};
	}

	// Token: 0x06013C89 RID: 81033 RVA: 0x005C5718 File Offset: 0x005C3918
	private void OnAreaItemClick(ShipTowerAreaItemData data)
	{
		this.SelectData = data;
		bool flag = false;
		if (data.RecordList != null)
		{
			for (int i = 0; i < data.RecordList.Count; i++)
			{
				if (data.RecordList[i].TeamList.Count > 0)
				{
					flag = true;
					break;
				}
			}
		}
		bool flag2 = false;
		if (data.RecordList != null)
		{
			for (int j = 0; j < data.RecordList.Count; j++)
			{
				if (data.RecordList[j].BuffId > 0)
				{
					flag2 = true;
					break;
				}
			}
		}
		bool flag3 = flag && flag2;
		this.SetEmptyState(!flag3);
		if (flag3 && data.RecordList != null)
		{
			GenericLayout<ShipTowerRecordItem, ShipTowerRecordItemData> layoutInfo = this.LayoutInfo;
			if (layoutInfo != null)
			{
				layoutInfo.RefreshByData(data.RecordList, null, true);
			}
		}
		int num = 0;
		if (data.RecordList != null)
		{
			for (int k = 0; k < data.RecordList.Count; k++)
			{
				num += data.RecordList[k].Score;
			}
		}
		int num2 = 0;
		if (data.RecordList != null)
		{
			for (int l = 0; l < data.RecordList.Count; l++)
			{
				num2 += data.RecordList[l].Wave;
			}
		}
		base.GetText(6).SetText(num.ToString(), true);
		base.GetText(7).SetText(num2.ToString(), true);
		UUITexture texture = base.GetTexture(8);
		ShipTowerStageData stageData = this.StageData;
		string text = (stageData != null) ? stageData.GetStageGradeResIdByScore(num) : null;
		bool flag4 = text != null;
		if (texture != null)
		{
			texture.SetUIActive(flag4);
		}
		if (flag4 && text != null)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}
		base.PlaySequence("Switch", null, false);
		this.RefreshShareBtn();
	}

	// Token: 0x06013C8A RID: 81034 RVA: 0x005C58EA File Offset: 0x005C3AEA
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

	// Token: 0x06013C8B RID: 81035 RVA: 0x005C5914 File Offset: 0x005C3B14
	private int GetSelectAreaIndex()
	{
		return 0;
	}

	// Token: 0x06013C8C RID: 81036 RVA: 0x005C5918 File Offset: 0x005C3B18
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

	// Token: 0x06013C8D RID: 81037 RVA: 0x005C5A50 File Offset: 0x005C3C50
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

	// Token: 0x06013C8E RID: 81038 RVA: 0x005C5AAA File Offset: 0x005C3CAA
	private ShipTowerRecordItem CreateRecordItem()
	{
		return new ShipTowerRecordItem();
	}

	// Token: 0x0400A8EF RID: 43247
	[Nullable(2)]
	private PopupCaptionItem PopupCaption;

	// Token: 0x0400A8F0 RID: 43248
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private LoopScrollView<ShipTowerAreaItem, ShipTowerAreaItemData> AreaLoopView;

	// Token: 0x0400A8F1 RID: 43249
	private List<ShipTowerAreaItemData> AreaList;

	// Token: 0x0400A8F2 RID: 43250
	[Nullable(2)]
	private ShipTowerAreaItemData SelectData;

	// Token: 0x0400A8F3 RID: 43251
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerRecordItem, ShipTowerRecordItemData> LayoutInfo;

	// Token: 0x0400A8F4 RID: 43252
	[Nullable(2)]
	private ShipTowerStageData StageData;

	// Token: 0x0400A8F5 RID: 43253
	[Nullable(2)]
	private ShareBtnItem ShareBtnItem;

	// Token: 0x02008224 RID: 33316
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A05F RID: 172127
		public const int ItemCaption = 0;

		// Token: 0x0402A060 RID: 172128
		public const int ButtonHelp = 1;

		// Token: 0x0402A061 RID: 172129
		public const int LoopViewPeriod = 2;

		// Token: 0x0402A062 RID: 172130
		public const int ItemEmpty = 3;

		// Token: 0x0402A063 RID: 172131
		public const int ItemDescRoot = 4;

		// Token: 0x0402A064 RID: 172132
		public const int TextDungeonName = 5;

		// Token: 0x0402A065 RID: 172133
		public const int TextMaxScore = 6;

		// Token: 0x0402A066 RID: 172134
		public const int TextMaxWave = 7;

		// Token: 0x0402A067 RID: 172135
		public const int TextureGrade = 8;

		// Token: 0x0402A068 RID: 172136
		public const int VLayoutTeamRecord = 9;

		// Token: 0x0402A069 RID: 172137
		public const int ItemPeriod = 10;

		// Token: 0x0402A06A RID: 172138
		public const int ShareItem = 11;
	}
}
