using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000791 RID: 1937
[NullableContext(1)]
[Nullable(0)]
internal class PhantomCardItem : GridProxyAbstract<int>
{
	// Token: 0x060058CC RID: 22732 RVA: 0x001CDEAC File Offset: 0x001CC0AC
	public PhantomCardItem(ActivityMapTravelData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x060058CD RID: 22733 RVA: 0x001CDEBC File Offset: 0x001CC0BC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060058CE RID: 22734 RVA: 0x001CE0B0 File Offset: 0x001CC2B0
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x060058CF RID: 22735 RVA: 0x001CE0D0 File Offset: 0x001CC2D0
	public override void Refresh(int phantomId, bool isSelected, int gridIndex)
	{
		this.PhantomId = phantomId;
		PhantomGain value = ActivityMapTravelConfig.Instance.GetPhantomConfig(this.PhantomId).Value;
		Aki.Config.MonsterInfo value2 = MonsterInfoConfig.Instance.GetMonsterInfoConfig(value.MonsterInfoId).Value;
		bool valueOrDefault = this.ActivityBaseData.PhantomDataMap.GetValueOrDefault(phantomId, false);
		base.GetItem(1).SetUIActive(!valueOrDefault);
		base.GetItem(2).SetUIActive(valueOrDefault);
		base.GetItem(7).SetUIActive(valueOrDefault);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value.Name, Array.Empty<object>());
		base.SetTextureShowUntilLoaded(value.TexPhantom, base.GetTexture(6), null);
		this.RefreshTexture(value2.RarityId);
		if (valueOrDefault)
		{
			this.TryUnlockItem();
		}
	}

	// Token: 0x060058D0 RID: 22736 RVA: 0x001CE1A0 File Offset: 0x001CC3A0
	private void RefreshTexture(int rarity)
	{
		UiResourceConfig instance = UiResourceConfig.Instance;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(28, 1);
		defaultInterpolatedStringHandler.AppendLiteral("T_TravelMapAct_PhantomRarity");
		defaultInterpolatedStringHandler.AppendFormatted<int>(rarity);
		string resourcePath = instance.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
		base.SetTextureShowUntilLoaded(resourcePath, base.GetTexture(3), delegate(bool _)
		{
			base.GetTexture(3).SetSizeFromTexture();
		});
		foreach (ValueTuple<int, int> valueTuple in new ValueTuple<int, int>[]
		{
			new ValueTuple<int, int>(4, 1),
			new ValueTuple<int, int>(10, 2),
			new ValueTuple<int, int>(9, 3),
			new ValueTuple<int, int>(11, 4)
		})
		{
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			base.GetTexture(item).SetUIActive(rarity == item2);
		}
	}

	// Token: 0x060058D1 RID: 22737 RVA: 0x001CE270 File Offset: 0x001CC470
	private void TryUnlockItem()
	{
		if (!this.ActivityBaseData.SaveFirstCheckRedDotState(EMapTravelSaveFlag.PhantomCollectNewUnlock, this.PhantomId))
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Unlock", false, null, false);
		}
	}

	// Token: 0x060058D2 RID: 22738 RVA: 0x001CE2B0 File Offset: 0x001CC4B0
	private void OnClickedButton()
	{
		PhantomGain? phantomConfig = ActivityMapTravelConfig.Instance.GetPhantomConfig(this.PhantomId);
		if (GameModeController.Instance.IsInInstance())
		{
			GenericPromptController.Instance.ShowPromptByCode("DungeonDetection", Array.Empty<object>());
			return;
		}
		AdventureGuideModel.Instance.SetFromManualDetect(true);
		AdventureGuideController.Instance.RequestForDetection(DetectionType.NormalMonster, Array.Empty<int>(), phantomConfig.Value.MonsterInfoId);
	}

	// Token: 0x04003C4F RID: 15439
	protected int PhantomId;

	// Token: 0x04003C50 RID: 15440
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003C51 RID: 15441
	protected ActivityMapTravelData ActivityBaseData;

	// Token: 0x02006A7B RID: 27259
	[NullableContext(0)]
	private class ECardComponent
	{
		// Token: 0x040230A1 RID: 143521
		public const int Button = 0;

		// Token: 0x040230A2 RID: 143522
		public const int ItemLock = 1;

		// Token: 0x040230A3 RID: 143523
		public const int PanelNormal = 2;

		// Token: 0x040230A4 RID: 143524
		public const int TexBg = 3;

		// Token: 0x040230A5 RID: 143525
		public const int TexQuality1 = 4;

		// Token: 0x040230A6 RID: 143526
		public const int TxtName = 5;

		// Token: 0x040230A7 RID: 143527
		public const int TexMonster = 6;

		// Token: 0x040230A8 RID: 143528
		public const int ItemDone = 7;

		// Token: 0x040230A9 RID: 143529
		public const int ItemNew = 8;

		// Token: 0x040230AA RID: 143530
		public const int TexQuality3 = 9;

		// Token: 0x040230AB RID: 143531
		public const int TexQuality2 = 10;

		// Token: 0x040230AC RID: 143532
		public const int TexQuality4 = 11;
	}
}
