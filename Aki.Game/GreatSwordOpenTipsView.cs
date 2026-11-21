using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001273 RID: 4723
public class GreatSwordOpenTipsView : UiViewBase
{
	// Token: 0x0600BAD8 RID: 47832 RVA: 0x00371949 File Offset: 0x0036FB49
	[NullableContext(1)]
	public GreatSwordOpenTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600BAD9 RID: 47833 RVA: 0x00371952 File Offset: 0x0036FB52
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600BADA RID: 47834 RVA: 0x0037198C File Offset: 0x0036FB8C
	protected override void OnStart()
	{
		IGreatSwordChallenge greatSwordChallenge = this.OpenParam as IGreatSwordChallenge;
		if (greatSwordChallenge == null)
		{
			return;
		}
		if (!string.IsNullOrEmpty(greatSwordChallenge.MainText))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), greatSwordChallenge.MainText, Array.Empty<object>());
		}
		if (!string.IsNullOrEmpty(greatSwordChallenge.SubText))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), greatSwordChallenge.SubText, Array.Empty<object>());
		}
	}

	// Token: 0x0600BADB RID: 47835 RVA: 0x003719FB File Offset: 0x0036FBFB
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
