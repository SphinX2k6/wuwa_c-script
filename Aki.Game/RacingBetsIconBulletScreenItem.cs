using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C02 RID: 7170
public class RacingBetsIconBulletScreenItem : GridProxyAbstract<RacingBetsBulletScreen>
{
	// Token: 0x06011D0D RID: 72973 RVA: 0x0053CCFC File Offset: 0x0053AEFC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBulletScreenButton))
		};
	}

	// Token: 0x06011D0E RID: 72974 RVA: 0x0053CD63 File Offset: 0x0053AF63
	public override void Refresh(RacingBetsBulletScreen data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.SetTextureShowUntilLoaded(data.Icon, base.GetTexture(1), null);
	}

	// Token: 0x06011D0F RID: 72975 RVA: 0x0053CD81 File Offset: 0x0053AF81
	[NullableContext(1)]
	public void BindClickBulletScreenCallBack(Action<RacingBetsBulletScreen> callBack)
	{
		this.ClickBulletScreenCallBack = callBack;
	}

	// Token: 0x06011D10 RID: 72976 RVA: 0x0053CD8A File Offset: 0x0053AF8A
	private void OnClickBulletScreenButton()
	{
		Action<RacingBetsBulletScreen> clickBulletScreenCallBack = this.ClickBulletScreenCallBack;
		if (clickBulletScreenCallBack == null)
		{
			return;
		}
		clickBulletScreenCallBack(this.Data);
	}

	// Token: 0x04009BA5 RID: 39845
	private RacingBetsBulletScreen Data;

	// Token: 0x04009BA6 RID: 39846
	[Nullable(2)]
	private Action<RacingBetsBulletScreen> ClickBulletScreenCallBack;

	// Token: 0x02007EF5 RID: 32501
	private enum EComponent
	{
		// Token: 0x0402914C RID: 168268
		Button,
		// Token: 0x0402914D RID: 168269
		Icon
	}
}
