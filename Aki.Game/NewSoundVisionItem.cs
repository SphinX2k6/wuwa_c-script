using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.AdventureGuide.Views;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016B0 RID: 5808
public class NewSoundVisionItem : UiPanelBase, INewSoundItem
{
	// Token: 0x0600A5AC RID: 42412 RVA: 0x00250964 File Offset: 0x0024EB64
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A5AD RID: 42413 RVA: 0x00250A51 File Offset: 0x0024EC51
	protected override void OnStart()
	{
		this.PhantomLayout = new GenericLayout<NewSoundNormaPhantomItem, int>(base.GetVerticalLayout(3), new Func<NewSoundNormaPhantomItem>(this.OnPhantomInit), null, false, true);
	}

	// Token: 0x0600A5AE RID: 42414 RVA: 0x00250A74 File Offset: 0x0024EC74
	[NullableContext(1)]
	public void Update(NewSoundDetectItemData sourceData)
	{
		SoundAreaDetectionRecord detectRecordData = sourceData.DetectRecordData;
		UUIText text = base.GetText(0);
		LguiUtil.Instance.SetLocalTextNew(text, detectRecordData.Name, Array.Empty<object>());
		UUITexture texture = base.GetTexture(1);
		UUIText text2 = base.GetText(2);
		this.RefreshTraceItemState(sourceData);
		if (detectRecordData.Secondary == 63 || detectRecordData.Secondary == 64)
		{
			bool isDetectionPreOpenByRecord = AdventureGuideModel.Instance.GetIsDetectionPreOpenByRecord(detectRecordData.SilentAreaDetectionRecord);
			ValueTuple<long, int> valueTuple = new ValueTuple<long, int>(0L, 0);
			if (isDetectionPreOpenByRecord)
			{
				PreOpenDetection? preOpenDetectionConf = AdventureGuideModel.Instance.GetPreOpenDetectionConf(detectRecordData.Id, detectRecordData.Type.Value, detectRecordData.PreOpenId);
				valueTuple = AdventureGuideModel.Instance.GetNightMarePreOpenTarget(preOpenDetectionConf.Value.InstanceID);
			}
			else
			{
				ValueTuple<int, int> nightMareTarget = AdventureGuideModel.Instance.GetNightMareTarget(new int?(detectRecordData.SilentAreaDetectionRecord.Conf.MapId), new int?(detectRecordData.SilentAreaDetectionRecord.Conf.LevelPlayList()[0]));
				valueTuple = new ValueTuple<long, int>((long)nightMareTarget.Item1, nightMareTarget.Item2);
			}
			if (valueTuple.Item2 < 0)
			{
				if (text2 != null)
				{
					text2.SetText("", true);
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(text2, "NightMareLeftTimes", new <>z__ReadOnlyArray<object>(new object[]
				{
					valueTuple.Item1,
					valueTuple.Item2
				}));
			}
			base.SetTextureShowUntilLoaded(detectRecordData.BigIcon, texture, null);
		}
		else
		{
			bool isDetectionPreOpenByData = AdventureGuideModel.Instance.GetIsDetectionPreOpenByData(detectRecordData);
			if (detectRecordData.IsLock.GetValueOrDefault() && !isDetectionPreOpenByData)
			{
				base.SetTextureShowUntilLoaded(detectRecordData.LockBigIcon, texture, null);
				LguiUtil.Instance.SetLocalTextNew(text2, detectRecordData.AttributesDescriptionUnlock, Array.Empty<object>());
				GenericLayout<NewSoundNormaPhantomItem, int> phantomLayout = this.PhantomLayout;
				if (phantomLayout == null)
				{
					return;
				}
				phantomLayout.SetActive(false);
				return;
			}
			else
			{
				base.SetTextureShowUntilLoaded(detectRecordData.BigIcon, texture, null);
				LguiUtil.Instance.SetLocalTextNew(text2, detectRecordData.InstanceSubTypeDescription, Array.Empty<object>());
			}
		}
		if (detectRecordData.Secondary != 22 || detectRecordData.PhantomId == null || detectRecordData.PhantomId.Length == 0)
		{
			GenericLayout<NewSoundNormaPhantomItem, int> phantomLayout2 = this.PhantomLayout;
			if (phantomLayout2 == null)
			{
				return;
			}
			phantomLayout2.SetActive(false);
			return;
		}
		else
		{
			GenericLayout<NewSoundNormaPhantomItem, int> phantomLayout3 = this.PhantomLayout;
			if (phantomLayout3 != null)
			{
				phantomLayout3.SetActive(true);
			}
			GenericLayout<NewSoundNormaPhantomItem, int> phantomLayout4 = this.PhantomLayout;
			if (phantomLayout4 == null)
			{
				return;
			}
			phantomLayout4.RefreshByData(detectRecordData.PhantomId.ToList<int>(), null, false);
			return;
		}
	}

	// Token: 0x0600A5AF RID: 42415 RVA: 0x00250CC4 File Offset: 0x0024EEC4
	[NullableContext(1)]
	private void RefreshTraceItemState(NewSoundDetectItemData data)
	{
		List<int> tracingList = data.TracingList;
		bool uiactive = tracingList != null && tracingList.Contains(data.DetectRecordData.Id);
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600A5B0 RID: 42416 RVA: 0x00250D01 File Offset: 0x0024EF01
	[NullableContext(1)]
	private NewSoundNormaPhantomItem OnPhantomInit()
	{
		return new NewSoundNormaPhantomItem();
	}

	// Token: 0x04004AE3 RID: 19171
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<NewSoundNormaPhantomItem, int> PhantomLayout;

	// Token: 0x02007C86 RID: 31878
	private enum EChildType
	{
		// Token: 0x04028DAC RID: 167340
		NameText,
		// Token: 0x04028DAD RID: 167341
		IconTexture,
		// Token: 0x04028DAE RID: 167342
		DesText,
		// Token: 0x04028DAF RID: 167343
		PhantomLayout,
		// Token: 0x04028DB0 RID: 167344
		SpriteIcon,
		// Token: 0x04028DB1 RID: 167345
		TrackIcon
	}
}
