using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C0D RID: 7181
public class RacingBetsTextBulletScreenItem : GridProxyAbstract<RacingBetsBulletScreen>
{
	// Token: 0x06011D5D RID: 73053 RVA: 0x0053DD28 File Offset: 0x0053BF28
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

	// Token: 0x06011D5E RID: 73054 RVA: 0x0053DDBC File Offset: 0x0053BFBC
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

	// Token: 0x06011D5F RID: 73055 RVA: 0x0053DE71 File Offset: 0x0053C071
	[NullableContext(1)]
	public void BindClickBulletScreenCallBack(Action<RacingBetsBulletScreen> callBack)
	{
		this.ClickBulletScreenCallBack = callBack;
	}

	// Token: 0x06011D60 RID: 73056 RVA: 0x0053DE7A File Offset: 0x0053C07A
	private void OnClickBulletScreenButton()
	{
		Action<RacingBetsBulletScreen> clickBulletScreenCallBack = this.ClickBulletScreenCallBack;
		if (clickBulletScreenCallBack == null)
		{
			return;
		}
		clickBulletScreenCallBack(this.Data);
	}

	// Token: 0x04009BBB RID: 39867
	private RacingBetsBulletScreen Data;

	// Token: 0x04009BBC RID: 39868
	[Nullable(2)]
	private Action<RacingBetsBulletScreen> ClickBulletScreenCallBack;

	// Token: 0x02007F00 RID: 32512
	private enum EComponent
	{
		// Token: 0x0402917F RID: 168319
		Button,
		// Token: 0x04029180 RID: 168320
		Icon,
		// Token: 0x04029181 RID: 168321
		Text,
		// Token: 0x04029182 RID: 168322
		NormalIcon
	}
}
