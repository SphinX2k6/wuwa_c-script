using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200227E RID: 8830
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiySkinListItem : GridProxyAbstract<MotorcycleDiySkinListItemData>
{
	// Token: 0x060113E8 RID: 70632 RVA: 0x00435700 File Offset: 0x00433900
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060113E9 RID: 70633 RVA: 0x0043575C File Offset: 0x0043395C
	[NullableContext(1)]
	public override void Refresh(MotorcycleDiySkinListItemData data, bool isSelected, int gridIndex)
	{
		string textStringId;
		if (MotorcycleDiyDefine.OutlookToSkinCustomizeNameMap.TryGetValue(data.OutlookType, out textStringId))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, Array.Empty<object>());
		}
		string resourceId;
		if (MotorcycleDiyDefine.OutlookToSkinCustomizeIconMap.TryGetValue(data.OutlookType, out resourceId))
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
		}
		if (data.CanCustomizeNum > 0)
		{
			base.GetText(2).SetText(data.CanCustomizeNum.ToString(), true);
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "MotorSkin_Tips04", Array.Empty<object>());
		}
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetAlpha((data.CanCustomizeNum > 0) ? 1f : 0.5f);
	}

	// Token: 0x020087C3 RID: 34755
	private class EMotorDiySkinListItemComponent
	{
		// Token: 0x0402C1F3 RID: 180723
		public const int TexIcon = 0;

		// Token: 0x0402C1F4 RID: 180724
		public const int TxtName = 1;

		// Token: 0x0402C1F5 RID: 180725
		public const int TxtNum = 2;
	}
}
