using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001DB1 RID: 7601
public class GreatSwordOpenTipsView : UiViewBase
{
	// Token: 0x0600E6BA RID: 59066 RVA: 0x00365CE9 File Offset: 0x00363EE9
	[NullableContext(1)]
	public GreatSwordOpenTipsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E6BB RID: 59067 RVA: 0x00365CF2 File Offset: 0x00363EF2
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
	}

	// Token: 0x0600E6BC RID: 59068 RVA: 0x00365D2C File Offset: 0x00363F2C
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

	// Token: 0x0600E6BD RID: 59069 RVA: 0x00365D9B File Offset: 0x00363F9B
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}
}
