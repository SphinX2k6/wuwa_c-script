using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001BF4 RID: 7156
public class RacingBetsBulletScreenItem : UiPanelBase
{
	// Token: 0x06011C9A RID: 72858 RVA: 0x0053AD10 File Offset: 0x00538F10
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUISizeControlByOther)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06011C9B RID: 72859 RVA: 0x0053AD98 File Offset: 0x00538F98
	public void RefreshUi(int bulletScreenId, bool isShowFrame)
	{
		this.BulletConfig = RacingBetsConfig.Instance.GetRacingBetsBulletScreen(bulletScreenId);
		if (this.BulletConfig == null)
		{
			return;
		}
		this.IsShowFrame = isShowFrame;
		UUITexture texture = base.GetTexture(0);
		UUITexture texture2 = base.GetTexture(2);
		UUIText text = base.GetText(1);
		if (this.BulletConfig.Value.Type == 1)
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			if (texture2 != null)
			{
				base.SetTextureShowUntilLoaded(this.BulletConfig.Value.Icon, texture2, null);
			}
		}
		else if (this.BulletConfig.Value.Type == 2)
		{
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			if (text != null)
			{
				text.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			DangoData dangoData = DangoManager.Instance.GetDangoData(this.BulletConfig.Value.DangoId);
			if (texture != null)
			{
				base.SetTextureShowUntilLoaded(dangoData.DangoConfig.Value.IconSmall, texture, null);
			}
			if (text != null)
			{
				text.ShowTextNew(this.BulletConfig.Value.Name);
			}
		}
		else
		{
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			if (text != null)
			{
				text.SetUIActive(true);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			if (text != null)
			{
				text.ShowTextNew(this.BulletConfig.Value.Name);
			}
		}
		UUISizeControlByOther uiSizeControlByOther = base.GetUiSizeControlByOther(3);
		if (uiSizeControlByOther == null)
		{
			return;
		}
		UUIItem uuiitem = uiSizeControlByOther.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(isShowFrame);
	}

	// Token: 0x06011C9C RID: 72860 RVA: 0x0053AF6C File Offset: 0x0053916C
	public float GetBulletScreenItemWidth()
	{
		float num;
		if (this.BulletConfig.Value.Type == 1)
		{
			UUITexture texture = base.GetTexture(2);
			num = ((texture != null) ? texture.GetWidth() : 0f) + 200f;
		}
		else if (this.BulletConfig.Value.Type == 2)
		{
			UUIText text = base.GetText(1);
			FVector2D? fvector2D = (text != null) ? new FVector2D?(text.GetTextRenderSize()) : null;
			UUITexture texture2 = base.GetTexture(0);
			float num2 = (texture2 != null) ? texture2.GetWidth() : 0f;
			num = ((fvector2D != null) ? fvector2D.GetValueOrDefault().X : 0f) + num2;
		}
		else
		{
			UUIText text2 = base.GetText(1);
			FVector2D? fvector2D2 = (text2 != null) ? new FVector2D?(text2.GetTextRenderSize()) : null;
			num = ((fvector2D2 != null) ? fvector2D2.GetValueOrDefault().X : 0f);
		}
		if (this.IsShowFrame)
		{
			UUISizeControlByOther uiSizeControlByOther = base.GetUiSizeControlByOther(3);
			if (uiSizeControlByOther != null)
			{
				return num + uiSizeControlByOther.AdditionalWidth / 2f;
			}
		}
		return num;
	}

	// Token: 0x06011C9D RID: 72861 RVA: 0x0053B090 File Offset: 0x00539290
	public float GetBulletScreenItemHeight()
	{
		UUITexture texture = base.GetTexture(0);
		float num = (texture != null) ? texture.GetHeight() : 0f;
		if (this.BulletConfig.Value.Type == 1)
		{
			UUITexture texture2 = base.GetTexture(2);
			num = ((texture2 != null) ? texture2.GetHeight() : 0f);
		}
		if (this.IsShowFrame)
		{
			UUISizeControlByOther uiSizeControlByOther = base.GetUiSizeControlByOther(3);
			if (uiSizeControlByOther != null)
			{
				return num + uiSizeControlByOther.AdditionalHeight;
			}
		}
		return num;
	}

	// Token: 0x06011C9E RID: 72862 RVA: 0x0053B100 File Offset: 0x00539300
	public void MoveLeft(float delta)
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem != null)
		{
			rootItem.SetAnchorOffsetX(rootItem.GetAnchorOffsetX() - delta);
		}
	}

	// Token: 0x04009B6D RID: 39789
	private RacingBetsBulletScreen? BulletConfig;

	// Token: 0x04009B6E RID: 39790
	private bool IsShowFrame;

	// Token: 0x04009B6F RID: 39791
	[Nullable(1)]
	public List<int> OccupiedTracks = new List<int>();

	// Token: 0x02007EDE RID: 32478
	private enum EComponent
	{
		// Token: 0x040290EA RID: 168170
		BulletIcon,
		// Token: 0x040290EB RID: 168171
		BulletText,
		// Token: 0x040290EC RID: 168172
		BulletBigIcon,
		// Token: 0x040290ED RID: 168173
		FrameItem,
		// Token: 0x040290EE RID: 168174
		TextBulletItem
	}
}
