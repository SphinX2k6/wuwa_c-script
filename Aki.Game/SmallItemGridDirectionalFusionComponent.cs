using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001973 RID: 6515
public class SmallItemGridDirectionalFusionComponent : SmallItemGridComponent
{
	// Token: 0x0600BEC9 RID: 48841 RVA: 0x002B2AA7 File Offset: 0x002B0CA7
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x0600BECA RID: 48842 RVA: 0x002B2ACA File Offset: 0x002B0CCA
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemIconTag";
	}

	// Token: 0x0600BECB RID: 48843 RVA: 0x002B2AD4 File Offset: 0x002B0CD4
	[NullableContext(2)]
	protected override void OnRefresh(object phantomFetterId)
	{
		if (phantomFetterId == null)
		{
			this.SetActive(false);
			return;
		}
		int num = (int)phantomFetterId;
		if (num < 0)
		{
			this.SetActive(false);
			return;
		}
		UUITexture texture = base.GetTexture(0);
		if (num == 0)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_IconElementAttriNone");
			base.SetTextureByPath(resourcePath, texture, null, null);
			this.SetActive(true);
			return;
		}
		string fetterElementPath = PhantomBattleConfig.Instance.GetFetterGroupById(num).FetterElementPath;
		if (string.IsNullOrEmpty(fetterElementPath))
		{
			this.SetActive(false);
			return;
		}
		base.SetTextureByPath(fetterElementPath, texture, null, null);
		this.SetActive(true);
	}
}
