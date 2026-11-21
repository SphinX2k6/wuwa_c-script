using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000E30 RID: 3632
public class SmallItemGridDirectionalFusionComponent : SmallItemGridComponent
{
	// Token: 0x060092D1 RID: 37585 RVA: 0x002BDA2B File Offset: 0x002BBC2B
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture))
		};
	}

	// Token: 0x060092D2 RID: 37586 RVA: 0x002BDA4E File Offset: 0x002BBC4E
	[NullableContext(1)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemIconTag";
	}

	// Token: 0x060092D3 RID: 37587 RVA: 0x002BDA58 File Offset: 0x002BBC58
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
