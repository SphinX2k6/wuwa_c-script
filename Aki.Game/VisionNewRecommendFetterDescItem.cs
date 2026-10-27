using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020024DF RID: 9439
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionNewRecommendFetterDescItem : GridProxyAbstract<VisionNewRecommendFetterDescItemData>
{
	// Token: 0x06012FB5 RID: 77749 RVA: 0x004B35F4 File Offset: 0x004B17F4
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

	// Token: 0x06012FB6 RID: 77750 RVA: 0x004B3664 File Offset: 0x004B1864
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

	// Token: 0x06012FB7 RID: 77751 RVA: 0x004B3696 File Offset: 0x004B1896
	public void SetSimpleMode(bool isSimple)
	{
		if (this.IsSimple == isSimple)
		{
			return;
		}
		this.IsSimple = isSimple;
		this.RefreshDesc();
	}

	// Token: 0x06012FB8 RID: 77752 RVA: 0x004B36B0 File Offset: 0x004B18B0
	private void RefreshIcon()
	{
		base.TrySetTextureByPath(PhantomBattleConfig.Instance.GetFetterGroupById(this.Data.FetterData.GroupId).FetterElementPath, base.GetTexture(0), null, null);
	}

	// Token: 0x06012FB9 RID: 77753 RVA: 0x004B36F8 File Offset: 0x004B18F8
	private void RefreshName()
	{
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(PhantomBattleConfig.Instance.GetPhantomFetterById(this.Data.FetterData.FetterId).Name, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "VisionFetterDetailViewName", new <>z__ReadOnlyArray<object>(new object[]
		{
			localTextNew,
			this.Data.FetterData.Count.ToString()
		}));
	}

	// Token: 0x06012FBA RID: 77754 RVA: 0x004B3770 File Offset: 0x004B1970
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

	// Token: 0x04008EE3 RID: 36579
	private bool IsSimple;

	// Token: 0x04008EE4 RID: 36580
	[Nullable(2)]
	private VisionNewRecommendFetterDescItemData Data;

	// Token: 0x02008A70 RID: 35440
	private enum EComp
	{
		// Token: 0x0402CF44 RID: 184132
		Icon,
		// Token: 0x0402CF45 RID: 184133
		Name,
		// Token: 0x0402CF46 RID: 184134
		Desc,
		// Token: 0x0402CF47 RID: 184135
		Line
	}
}
