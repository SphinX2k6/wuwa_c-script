using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001762 RID: 5986
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorcycleDiySkinListItem : GridProxyAbstract<MotorcycleDiySkinListItemData>
{
	// Token: 0x0600E87E RID: 59518 RVA: 0x0044230C File Offset: 0x0044050C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0600E87F RID: 59519 RVA: 0x00442368 File Offset: 0x00440568
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

	// Token: 0x0200794C RID: 31052
	private class EMotorDiySkinListItemComponent
	{
		// Token: 0x0402750B RID: 161035
		public const int TexIcon = 0;

		// Token: 0x0402750C RID: 161036
		public const int TxtName = 1;

		// Token: 0x0402750D RID: 161037
		public const int TxtNum = 2;
	}
}
