using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006D9 RID: 1753
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyBuffActiveShowPanel : UiPanelBase
{
	// Token: 0x06005147 RID: 20807 RVA: 0x001B3344 File Offset: 0x001B1544
	public UniTask Init(UUIItem item, DangoMonopolyGridData gridData)
	{
		DangoMonopolyBuffActiveShowPanel.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.gridData = gridData;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<DangoMonopolyBuffActiveShowPanel.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06005148 RID: 20808 RVA: 0x001B3397 File Offset: 0x001B1597
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06005149 RID: 20809 RVA: 0x001B339C File Offset: 0x001B159C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x0600514A RID: 20810 RVA: 0x001B33F8 File Offset: 0x001B15F8
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyBuffActiveShowPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyBuffActiveShowPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600514B RID: 20811 RVA: 0x001B343B File Offset: 0x001B163B
	protected override void OnStart()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x0600514C RID: 20812 RVA: 0x001B344F File Offset: 0x001B164F
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x0600514D RID: 20813 RVA: 0x001B3458 File Offset: 0x001B1658
	public void UpdateData()
	{
		DangoData dangoData = this.GridData.GetDangoData();
		string text = ((dangoData != null) ? dangoData.NameKey : null) ?? "DangoName";
		string text2 = ConfigMultiTextLang.GetLocalTextNew(text, null) ?? text;
		string text3 = ConfigMultiTextLang.GetLocalTextNew("DangoMonopoly_title_15", null);
		if (text3 != null)
		{
			text3 = StringUtils.Format(text3, new string[]
			{
				text2
			});
		}
		UUIText text4 = base.GetText(0);
		if (text4 != null)
		{
			text4.SetText(text3 ?? "", true);
		}
		UUISprite sprite = base.GetSprite(2);
		this.SetSpriteByPath(this.GetSpriteTitlePath(true), sprite, true, null, null);
	}

	// Token: 0x0600514E RID: 20814 RVA: 0x001B34F4 File Offset: 0x001B16F4
	public string GetSpriteTitlePath(bool isGet = true)
	{
		string resourceId = isGet ? "SP_TuanziGetTxt" : "SP_TuanziUnlockTxt";
		UiResourceConfig instance = UiResourceConfig.Instance;
		return ((instance != null) ? instance.GetResourcePath(resourceId) : null) ?? "";
	}

	// Token: 0x040039C1 RID: 14785
	public DangoMonopolyGridData GridData;

	// Token: 0x020069A2 RID: 27042
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022C75 RID: 142453
		TxtTitle,
		// Token: 0x04022C76 RID: 142454
		TxtDesc,
		// Token: 0x04022C77 RID: 142455
		SpriteTitle
	}
}
