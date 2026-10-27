using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001225 RID: 4645
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyBuffActiveShowPanel : UiPanelBase
{
	// Token: 0x06007DB0 RID: 32176 RVA: 0x001AA684 File Offset: 0x001A8884
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

	// Token: 0x06007DB1 RID: 32177 RVA: 0x001AA6D7 File Offset: 0x001A88D7
	protected override void OnBeforeCreate()
	{
	}

	// Token: 0x06007DB2 RID: 32178 RVA: 0x001AA6DC File Offset: 0x001A88DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUISprite))
		};
	}

	// Token: 0x06007DB3 RID: 32179 RVA: 0x001AA738 File Offset: 0x001A8938
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyBuffActiveShowPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyBuffActiveShowPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007DB4 RID: 32180 RVA: 0x001AA77B File Offset: 0x001A897B
	protected override void OnStart()
	{
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x06007DB5 RID: 32181 RVA: 0x001AA78F File Offset: 0x001A898F
	protected override void OnBeforeShow()
	{
		this.UpdateData();
	}

	// Token: 0x06007DB6 RID: 32182 RVA: 0x001AA798 File Offset: 0x001A8998
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

	// Token: 0x06007DB7 RID: 32183 RVA: 0x001AA834 File Offset: 0x001A8A34
	public string GetSpriteTitlePath(bool isGet = true)
	{
		string resourceId = isGet ? "SP_TuanziGetTxt" : "SP_TuanziUnlockTxt";
		UiResourceConfig instance = UiResourceConfig.Instance;
		return ((instance != null) ? instance.GetResourcePath(resourceId) : null) ?? "";
	}

	// Token: 0x04003929 RID: 14633
	public DangoMonopolyGridData GridData;

	// Token: 0x02007817 RID: 30743
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027944 RID: 162116
		TxtTitle,
		// Token: 0x04027945 RID: 162117
		TxtDesc,
		// Token: 0x04027946 RID: 162118
		SpriteTitle
	}
}
