using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002717 RID: 10007
public class RacingBetsIconBulletScreenItem : GridProxyAbstract<RacingBetsBulletScreen>
{
	// Token: 0x0601482B RID: 84011 RVA: 0x0052DFE0 File Offset: 0x0052C1E0
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

	// Token: 0x0601482C RID: 84012 RVA: 0x0052E047 File Offset: 0x0052C247
	public override void Refresh(RacingBetsBulletScreen data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.SetTextureShowUntilLoaded(data.Icon, base.GetTexture(1), null);
	}

	// Token: 0x0601482D RID: 84013 RVA: 0x0052E065 File Offset: 0x0052C265
	[NullableContext(1)]
	public void BindClickBulletScreenCallBack(Action<RacingBetsBulletScreen> callBack)
	{
		this.ClickBulletScreenCallBack = callBack;
	}

	// Token: 0x0601482E RID: 84014 RVA: 0x0052E06E File Offset: 0x0052C26E
	private void OnClickBulletScreenButton()
	{
		Action<RacingBetsBulletScreen> clickBulletScreenCallBack = this.ClickBulletScreenCallBack;
		if (clickBulletScreenCallBack == null)
		{
			return;
		}
		clickBulletScreenCallBack(this.Data);
	}

	// Token: 0x04009A4D RID: 39501
	private RacingBetsBulletScreen Data;

	// Token: 0x04009A4E RID: 39502
	[Nullable(2)]
	private Action<RacingBetsBulletScreen> ClickBulletScreenCallBack;

	// Token: 0x02008D6C RID: 36204
	private enum EComponent
	{
		// Token: 0x0402DE35 RID: 187957
		Button,
		// Token: 0x0402DE36 RID: 187958
		Icon
	}
}
