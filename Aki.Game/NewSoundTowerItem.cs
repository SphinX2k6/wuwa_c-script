using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.AdventureGuide.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B62 RID: 2914
[NullableContext(1)]
[Nullable(0)]
public class NewSoundTowerItem : UiPanelBase, INewSoundItem
{
	// Token: 0x06007964 RID: 31076 RVA: 0x0025A420 File Offset: 0x00258620
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007965 RID: 31077 RVA: 0x0025A50D File Offset: 0x0025870D
	public void Update(NewSoundDetectItemData sourceData)
	{
		this.UpdateCommon(sourceData);
		if (sourceData.DetectRecordData.Secondary == 28)
		{
			this.UpdateShipTower(sourceData);
			return;
		}
		this.UpdateTower(sourceData);
	}

	// Token: 0x06007966 RID: 31078 RVA: 0x0025A534 File Offset: 0x00258734
	private void UpdateCommon(NewSoundDetectItemData sourceData)
	{
		SoundAreaDetectionRecord detectRecordData = sourceData.DetectRecordData;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, detectRecordData.Name, Array.Empty<object>());
		UUITexture texture = base.GetTexture(1);
		string path = detectRecordData.IsLock.GetValueOrDefault() ? detectRecordData.LockBigIcon : detectRecordData.BigIcon;
		base.SetTextureShowUntilLoaded(path, texture, null);
		UUIItem text2 = base.GetText(2);
		UUIText text3 = base.GetText(3);
		bool? isLock = detectRecordData.IsLock;
		bool flag = false;
		text2.SetUIActive(isLock.GetValueOrDefault() == flag & isLock != null);
		UUIItem uuiitem = text3;
		isLock = detectRecordData.IsLock;
		flag = false;
		uuiitem.SetUIActive(isLock.GetValueOrDefault() == flag & isLock != null);
	}

	// Token: 0x06007967 RID: 31079 RVA: 0x0025A5F0 File Offset: 0x002587F0
	private void UpdateTower(NewSoundDetectItemData sourceData)
	{
		if (sourceData.DetectRecordData.IsLock.GetValueOrDefault())
		{
			return;
		}
		int maxDifficulty = TowerModel.Instance.GetMaxDifficulty();
		string newTowerDifficultTitle = TowerClimbConfig.Instance.GetNewTowerDifficultTitle(maxDifficulty);
		this.UpdateSubTitle(newTowerDifficultTitle);
		int difficultyMaxStars = TowerModel.Instance.GetDifficultyMaxStars(maxDifficulty, false);
		int difficultyAllStars = TowerModel.Instance.GetDifficultyAllStars(maxDifficulty, false);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted<int>(difficultyMaxStars);
		defaultInterpolatedStringHandler.AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(difficultyAllStars);
		string progressStr = defaultInterpolatedStringHandler.ToStringAndClear();
		this.UpdateProgressNumber(progressStr);
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(true);
	}

	// Token: 0x06007968 RID: 31080 RVA: 0x0025A694 File Offset: 0x00258894
	private void UpdateShipTower(NewSoundDetectItemData sourceData)
	{
		if (sourceData.DetectRecordData.IsLock.GetValueOrDefault())
		{
			return;
		}
		this.UpdateSubTitle(ShipTowerModel.Instance.GetCurrentStageSeasonName());
		this.UpdateProgressNumber(ShipTowerModel.Instance.GetRewardProgressText(false));
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06007969 RID: 31081 RVA: 0x0025A6EA File Offset: 0x002588EA
	private void UpdateSubTitle(string subTitle)
	{
		base.GetText(2).SetText(subTitle, true);
	}

	// Token: 0x0600796A RID: 31082 RVA: 0x0025A6FA File Offset: 0x002588FA
	private void UpdateProgressNumber(string progressStr)
	{
		base.GetText(3).SetText(progressStr, true);
	}

	// Token: 0x02006E07 RID: 28167
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x040240C0 RID: 147648
		NameText,
		// Token: 0x040240C1 RID: 147649
		IconTexture,
		// Token: 0x040240C2 RID: 147650
		ProgressText,
		// Token: 0x040240C3 RID: 147651
		ProgressNumberText,
		// Token: 0x040240C4 RID: 147652
		SpriteIcon,
		// Token: 0x040240C5 RID: 147653
		ItemTowerStar
	}
}
