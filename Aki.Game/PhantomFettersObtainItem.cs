using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001922 RID: 6434
[NullableContext(1)]
[Nullable(0)]
public class PhantomFettersObtainItem : UiPanelBase
{
	// Token: 0x0600FE54 RID: 65108 RVA: 0x004A414C File Offset: 0x004A234C
	public PhantomFettersObtainItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x0600FE55 RID: 65109 RVA: 0x004A415B File Offset: 0x004A235B
	public void Init()
	{
		base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
	}

	// Token: 0x0600FE56 RID: 65110 RVA: 0x004A4170 File Offset: 0x004A2370
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnTrack))
		};
	}

	// Token: 0x0600FE57 RID: 65111 RVA: 0x004A4204 File Offset: 0x004A2404
	public void Update(IFettersObtainData data)
	{
		this.MonsterId = data.Id;
		if (data.IsGet)
		{
			base.SetTextureByPath(data.Icon, base.GetTexture(0), null, null);
			base.GetText(1).ShowTextNew(data.Name);
		}
		else
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_IconMonsterHead00_UI");
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
			base.GetText(1).SetText("???", true);
		}
		base.GetText(2).SetUIActive(false);
	}

	// Token: 0x0600FE58 RID: 65112 RVA: 0x004A429D File Offset: 0x004A249D
	public void BindOnItemButtonClickedCallback(Action<int> onItemButtonClicked)
	{
		this.OnItemButtonClickedCallback = onItemButtonClicked;
	}

	// Token: 0x0600FE59 RID: 65113 RVA: 0x004A42A6 File Offset: 0x004A24A6
	private void OnTrack()
	{
		if (this.OnItemButtonClickedCallback != null)
		{
			UiManager.Instance.CloseView(EUiViewName.PhantomBattleFettersObtainView, null);
			this.OnItemButtonClickedCallback(this.MonsterId);
		}
	}

	// Token: 0x04008D88 RID: 36232
	private int MonsterId;

	// Token: 0x04008D89 RID: 36233
	[Nullable(2)]
	private Action<int> OnItemButtonClickedCallback;

	// Token: 0x04008D8A RID: 36234
	[Nullable(2)]
	private readonly UUIItem SourceItem;
}
