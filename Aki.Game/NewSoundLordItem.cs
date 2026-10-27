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

// Token: 0x020016A1 RID: 5793
public class NewSoundLordItem : UiPanelBase, INewSoundItem
{
	// Token: 0x0600A55D RID: 42333 RVA: 0x0024EF28 File Offset: 0x0024D128
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

	// Token: 0x0600A55E RID: 42334 RVA: 0x0024EFD3 File Offset: 0x0024D1D3
	protected override void OnStart()
	{
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600A55F RID: 42335 RVA: 0x0024EFE8 File Offset: 0x0024D1E8
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

	// Token: 0x02007C77 RID: 31863
	private enum EChildType
	{
		// Token: 0x04028D6A RID: 167274
		NameText,
		// Token: 0x04028D6B RID: 167275
		IconTexture,
		// Token: 0x04028D6C RID: 167276
		ProgressText,
		// Token: 0x04028D6D RID: 167277
		ProgressNumberText
	}
}
