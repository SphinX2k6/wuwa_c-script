using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020019C6 RID: 6598
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendFetterDescItem : GridProxyAbstract<VisionNewRecommendFetterDescItemData>
{
	// Token: 0x06010474 RID: 66676 RVA: 0x004C11B4 File Offset: 0x004BF3B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06010475 RID: 66677 RVA: 0x004C1224 File Offset: 0x004BF424
	[NullableContext(1)]
	public override void Refresh(VisionNewRecommendFetterDescItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshIcon();
		this.RefreshName();
		this.RefreshDesc();
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data.IsNeedLine);
	}

	// Token: 0x06010476 RID: 66678 RVA: 0x004C1256 File Offset: 0x004BF456
	public void SetSimpleMode(bool isSimple)
	{
		if (this.IsSimple == isSimple)
		{
			return;
		}
		this.IsSimple = isSimple;
		this.RefreshDesc();
	}

	// Token: 0x06010477 RID: 66679 RVA: 0x004C1270 File Offset: 0x004BF470
	private void RefreshIcon()
	{
		base.TrySetTextureByPath(PhantomBattleConfig.Instance.GetFetterGroupById(this.Data.FetterData.GroupId).FetterElementPath, base.GetTexture(0), null, null);
	}

	// Token: 0x06010478 RID: 66680 RVA: 0x004C12B8 File Offset: 0x004BF4B8
	private void RefreshName()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetPhantomFetterById(this.Data.FetterData.FetterId).Name, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "VisionFetterDetailViewName", new <>z__ReadOnlyArray<object>(new object[]
		{
			localTextNew,
			this.Data.FetterData.Count.ToString()
		}));
	}

	// Token: 0x06010479 RID: 66681 RVA: 0x004C1330 File Offset: 0x004BF530
	private void RefreshDesc()
	{
		if (this.Data == null)
		{
			return;
		}
		PhantomFetter phantomFetterById = PhantomBattleConfig.Instance.GetPhantomFetterById(this.Data.FetterData.FetterId);
		if (!this.IsSimple)
		{
			int effectDescriptionParamLength = phantomFetterById.EffectDescriptionParamLength;
			object[] array = new object[effectDescriptionParamLength];
			for (int i = 0; i < effectDescriptionParamLength; i++)
			{
				array[i] = phantomFetterById.EffectDescriptionParam(i);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomFetterById.EffectDescription, array);
			return;
		}
		if (!StringUtils.IsEmpty(phantomFetterById.SimplyEffectDesc))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomFetterById.SimplyEffectDesc, Array.Empty<object>());
			return;
		}
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.SetText("", true);
	}

	// Token: 0x0400902D RID: 36909
	private bool IsSimple;

	// Token: 0x0400902E RID: 36910
	[Nullable(2)]
	private VisionNewRecommendFetterDescItemData Data;

	// Token: 0x02007BF8 RID: 31736
	private enum EComp
	{
		// Token: 0x0402825D RID: 164445
		Icon,
		// Token: 0x0402825E RID: 164446
		Name,
		// Token: 0x0402825F RID: 164447
		Desc,
		// Token: 0x04028260 RID: 164448
		Line
	}
}
