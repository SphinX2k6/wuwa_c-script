using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D10 RID: 7440
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerVisionItem : GridProxyAbstract<RoleTowerVisionItemData>
{
	// Token: 0x060126BB RID: 75451 RVA: 0x005718C1 File Offset: 0x0056FAC1
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x060126BC RID: 75452 RVA: 0x005718CC File Offset: 0x0056FACC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTog))
		};
	}

	// Token: 0x060126BD RID: 75453 RVA: 0x00571978 File Offset: 0x0056FB78
	public override void Refresh(RoleTowerVisionItemData data, bool isSelected, int gridIndex)
	{
		this.VisionId = data.VisionId;
		UUITexture texture = base.GetTexture(1);
		if (!string.IsNullOrEmpty(data.IconPath))
		{
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetTextureByPath(data.IconPath, texture, null, null);
		}
		else if (texture != null)
		{
			texture.SetUIActive(false);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Level);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		UUIText text2 = base.GetText(3);
		if (text2 != null)
		{
			text2.SetText(data.Cost.ToString(), true);
		}
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(data.IsSelected);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(data.IsSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060126BE RID: 75454 RVA: 0x00571A66 File Offset: 0x0056FC66
	private void OnClickTog(EToggleState check)
	{
		if (check == EToggleState.ETT_Checked)
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.VisionId);
		}
	}

	// Token: 0x060126BF RID: 75455 RVA: 0x00571A82 File Offset: 0x0056FC82
	public override object GetKey(RoleTowerVisionItemData data, int displayIndex)
	{
		return data.VisionId;
	}

	// Token: 0x0400A072 RID: 41074
	private int VisionId;

	// Token: 0x0400A073 RID: 41075
	[Nullable(2)]
	private Action<int> ClickCallback;

	// Token: 0x0200804B RID: 32843
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029837 RID: 170039
		public const int TogItem = 0;

		// Token: 0x04029838 RID: 170040
		public const int TexIcon = 1;

		// Token: 0x04029839 RID: 170041
		public const int TxtLevel = 2;

		// Token: 0x0402983A RID: 170042
		public const int TxtCost = 3;

		// Token: 0x0402983B RID: 170043
		public const int PnlSelected = 4;
	}
}
