using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002722 RID: 10018
public class RacingBetsTextBulletScreenItem : GridProxyAbstract<RacingBetsBulletScreen>
{
	// Token: 0x0601487B RID: 84091 RVA: 0x0052F00C File Offset: 0x0052D20C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBulletScreenButton))
		};
	}

	// Token: 0x0601487C RID: 84092 RVA: 0x0052F0A0 File Offset: 0x0052D2A0
	public override void Refresh(RacingBetsBulletScreen data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(data.Name);
		}
		if (data.Type == 2)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			DangoData dangoData = DangoManager.Instance.GetDangoData(data.DangoId);
			base.SetTextureShowUntilLoaded(dangoData.DangoConfig.Value.IconSmall, base.GetTexture(1), null);
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
			return;
		}
		else
		{
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 != null)
			{
				texture2.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 == null)
			{
				return;
			}
			sprite2.SetUIActive(true);
			return;
		}
	}

	// Token: 0x0601487D RID: 84093 RVA: 0x0052F155 File Offset: 0x0052D355
	[NullableContext(1)]
	public void BindClickBulletScreenCallBack(Action<RacingBetsBulletScreen> callBack)
	{
		this.ClickBulletScreenCallBack = callBack;
	}

	// Token: 0x0601487E RID: 84094 RVA: 0x0052F15E File Offset: 0x0052D35E
	private void OnClickBulletScreenButton()
	{
		Action<RacingBetsBulletScreen> clickBulletScreenCallBack = this.ClickBulletScreenCallBack;
		if (clickBulletScreenCallBack == null)
		{
			return;
		}
		clickBulletScreenCallBack(this.Data);
	}

	// Token: 0x04009A63 RID: 39523
	private RacingBetsBulletScreen Data;

	// Token: 0x04009A64 RID: 39524
	[Nullable(2)]
	private Action<RacingBetsBulletScreen> ClickBulletScreenCallBack;

	// Token: 0x02008D77 RID: 36215
	private enum EComponent
	{
		// Token: 0x0402DE68 RID: 188008
		Button,
		// Token: 0x0402DE69 RID: 188009
		Icon,
		// Token: 0x0402DE6A RID: 188010
		Text,
		// Token: 0x0402DE6B RID: 188011
		NormalIcon
	}
}
