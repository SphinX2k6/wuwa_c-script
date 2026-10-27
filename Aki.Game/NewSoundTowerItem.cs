using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.AdventureGuide.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016AA RID: 5802
[NullableContext(1)]
[Nullable(0)]
public class NewSoundTowerItem : UiPanelBase, INewSoundItem
{
	// Token: 0x0600A584 RID: 42372 RVA: 0x0025000C File Offset: 0x0024E20C
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

	// Token: 0x0600A585 RID: 42373 RVA: 0x002500F9 File Offset: 0x0024E2F9
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

	// Token: 0x0600A586 RID: 42374 RVA: 0x00250120 File Offset: 0x0024E320
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

	// Token: 0x0600A587 RID: 42375 RVA: 0x002501DC File Offset: 0x0024E3DC
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

	// Token: 0x0600A588 RID: 42376 RVA: 0x00250280 File Offset: 0x0024E480
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

	// Token: 0x0600A589 RID: 42377 RVA: 0x002502D6 File Offset: 0x0024E4D6
	private void UpdateSubTitle(string subTitle)
	{
		base.GetText(2).SetText(subTitle, true);
	}

	// Token: 0x0600A58A RID: 42378 RVA: 0x002502E6 File Offset: 0x0024E4E6
	private void UpdateProgressNumber(string progressStr)
	{
		base.GetText(3).SetText(progressStr, true);
	}

	// Token: 0x02007C82 RID: 31874
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028D97 RID: 167319
		NameText,
		// Token: 0x04028D98 RID: 167320
		IconTexture,
		// Token: 0x04028D99 RID: 167321
		ProgressText,
		// Token: 0x04028D9A RID: 167322
		ProgressNumberText,
		// Token: 0x04028D9B RID: 167323
		SpriteIcon,
		// Token: 0x04028D9C RID: 167324
		ItemTowerStar
	}
}
