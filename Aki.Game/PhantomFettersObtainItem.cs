using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200243D RID: 9277
[NullableContext(1)]
[Nullable(0)]
public class PhantomFettersObtainItem : UiPanelBase
{
	// Token: 0x0601299E RID: 76190 RVA: 0x00496B80 File Offset: 0x00494D80
	public PhantomFettersObtainItem(UUIItem uiItem)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x0601299F RID: 76191 RVA: 0x00496B8F File Offset: 0x00494D8F
	public void Init()
	{
		base.CreateThenShowByActor(this.SourceItem.GetOwner(), null);
	}

	// Token: 0x060129A0 RID: 76192 RVA: 0x00496BA4 File Offset: 0x00494DA4
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

	// Token: 0x060129A1 RID: 76193 RVA: 0x00496C38 File Offset: 0x00494E38
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

	// Token: 0x060129A2 RID: 76194 RVA: 0x00496CD1 File Offset: 0x00494ED1
	public void BindOnItemButtonClickedCallback(Action<int> onItemButtonClicked)
	{
		this.OnItemButtonClickedCallback = onItemButtonClicked;
	}

	// Token: 0x060129A3 RID: 76195 RVA: 0x00496CDA File Offset: 0x00494EDA
	private void OnTrack()
	{
		if (this.OnItemButtonClickedCallback != null)
		{
			UiManager.Instance.CloseView(EUiViewName.PhantomBattleFettersObtainView, null);
			this.OnItemButtonClickedCallback(this.MonsterId);
		}
	}

	// Token: 0x04008C41 RID: 35905
	private int MonsterId;

	// Token: 0x04008C42 RID: 35906
	[Nullable(2)]
	private Action<int> OnItemButtonClickedCallback;

	// Token: 0x04008C43 RID: 35907
	[Nullable(2)]
	private readonly UUIItem SourceItem;
}
