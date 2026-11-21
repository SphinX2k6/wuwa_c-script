using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.AdventureGuide.Views;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02000B59 RID: 2905
public class NewSoundLordItem : UiPanelBase, INewSoundItem
{
	// Token: 0x0600793D RID: 31037 RVA: 0x00259344 File Offset: 0x00257544
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
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
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600793E RID: 31038 RVA: 0x002593EF File Offset: 0x002575EF
	protected override void OnStart()
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600793F RID: 31039 RVA: 0x00259404 File Offset: 0x00257604
	[NullableContext(1)]
	public void Update(NewSoundDetectItemData sourceData)
	{
		SoundAreaDetectionRecord detectRecordData = sourceData.DetectRecordData;
		ESoundAreaDataType? type = detectRecordData.Type;
		ESoundAreaDataType esoundAreaDataType = ESoundAreaDataType.Dungeon;
		if (type.GetValueOrDefault() == esoundAreaDataType & type != null)
		{
			return;
		}
		SilentAreaDetection silentAreaDetection = (T2)detectRecordData.Conf.Value;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, silentAreaDetection.Name, Array.Empty<object>());
		UUITexture texture = base.GetTexture(1);
		int gymEntranceId = silentAreaDetection.AdditionalId;
		if (detectRecordData.IsLock.GetValueOrDefault())
		{
			base.SetTextureShowUntilLoaded(silentAreaDetection.LockBigIcon, texture, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "LordGymDifficulty", new <>z__ReadOnlySingleElementList<object>("0/" + LordGymModel.Instance.GetGymCanFightMaxLevel(gymEntranceId).ToString()));
			return;
		}
		base.SetTextureShowUntilLoaded(silentAreaDetection.BigIcon, texture, null);
		LordGymController.Instance.LordGymInfoRequest(0).ContinueWith(delegate(bool _)
		{
			int? gymCanFightMaxLevelWithoutLockCondition = LordGymModel.Instance.GetGymCanFightMaxLevelWithoutLockCondition(gymEntranceId);
			int hasFinishLord = LordGymModel.Instance.GetHasFinishLord(gymEntranceId);
			LguiUtil.Instance.SetLocalTextNew(this.GetText(2), "NewSoundLordGymDifficulty", new <>z__ReadOnlyArray<object>(new object[]
			{
				hasFinishLord,
				gymCanFightMaxLevelWithoutLockCondition
			}));
		});
	}

	// Token: 0x02006DFC RID: 28156
	private enum EChildType
	{
		// Token: 0x04024093 RID: 147603
		NameText,
		// Token: 0x04024094 RID: 147604
		IconTexture,
		// Token: 0x04024095 RID: 147605
		ProgressText,
		// Token: 0x04024096 RID: 147606
		ProgressNumberText
	}
}
