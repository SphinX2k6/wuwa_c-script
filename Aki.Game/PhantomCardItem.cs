using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020012DD RID: 4829
[NullableContext(1)]
[Nullable(0)]
internal class PhantomCardItem : GridProxyAbstract<int>
{
	// Token: 0x06008531 RID: 34097 RVA: 0x001C5050 File Offset: 0x001C3250
	public PhantomCardItem(ActivityMapTravelData activityBaseData)
	{
		this.ActivityBaseData = activityBaseData;
	}

	// Token: 0x06008532 RID: 34098 RVA: 0x001C5060 File Offset: 0x001C3260
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

	// Token: 0x06008533 RID: 34099 RVA: 0x001C5254 File Offset: 0x001C3454
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x06008534 RID: 34100 RVA: 0x001C5274 File Offset: 0x001C3474
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

	// Token: 0x06008535 RID: 34101 RVA: 0x001C5344 File Offset: 0x001C3544
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

	// Token: 0x06008536 RID: 34102 RVA: 0x001C5414 File Offset: 0x001C3614
	private void TryUnlockItem()
	{
		if (!this.ActivityBaseData.SaveFirstCheckRedDotState(EMapTravelSaveFlag.PhantomCollectNewUnlock, this.PhantomId))
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Unlock", false, null, false);
		}
	}

	// Token: 0x06008537 RID: 34103 RVA: 0x001C5454 File Offset: 0x001C3654
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

	// Token: 0x04003BB7 RID: 15287
	protected int PhantomId;

	// Token: 0x04003BB8 RID: 15288
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04003BB9 RID: 15289
	protected ActivityMapTravelData ActivityBaseData;

	// Token: 0x020078F1 RID: 30961
	[NullableContext(0)]
	private class ECardComponent
	{
		// Token: 0x04027D73 RID: 163187
		public const int Button = 0;

		// Token: 0x04027D74 RID: 163188
		public const int ItemLock = 1;

		// Token: 0x04027D75 RID: 163189
		public const int PanelNormal = 2;

		// Token: 0x04027D76 RID: 163190
		public const int TexBg = 3;

		// Token: 0x04027D77 RID: 163191
		public const int TexQuality1 = 4;

		// Token: 0x04027D78 RID: 163192
		public const int TxtName = 5;

		// Token: 0x04027D79 RID: 163193
		public const int TexMonster = 6;

		// Token: 0x04027D7A RID: 163194
		public const int ItemDone = 7;

		// Token: 0x04027D7B RID: 163195
		public const int ItemNew = 8;

		// Token: 0x04027D7C RID: 163196
		public const int TexQuality3 = 9;

		// Token: 0x04027D7D RID: 163197
		public const int TexQuality2 = 10;

		// Token: 0x04027D7E RID: 163198
		public const int TexQuality4 = 11;
	}
}
