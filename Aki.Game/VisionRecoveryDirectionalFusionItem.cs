using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C13 RID: 3091
public class VisionRecoveryDirectionalFusionItem : UiPanelBase
{
	// Token: 0x060080E7 RID: 32999 RVA: 0x0027886C File Offset: 0x00276A6C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
		};
	}

	// Token: 0x060080E8 RID: 33000 RVA: 0x00278900 File Offset: 0x00276B00
	public void RefreshItem()
	{
		UUITexture texture = base.GetTexture(2);
		UUIText text = base.GetText(3);
		int directionalFusionTargetFetterGroup = CalabashModel.Instance.DirectionalFusionTargetFetterGroup;
		if (directionalFusionTargetFetterGroup == 0)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_IconElementAttriNone");
			base.SetTextureByPath(resourcePath, texture, null, null);
			text.SetUIActive(false);
			return;
		}
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(directionalFusionTargetFetterGroup);
		string aimModelElementPath = fetterGroupById.AimModelElementPath;
		if (string.IsNullOrEmpty(aimModelElementPath))
		{
			return;
		}
		text.SetUIActive(true);
		LguiUtil.Instance.SetLocalTextNew(text, fetterGroupById.FetterGroupName, Array.Empty<object>());
		base.SetTextureByPath(aimModelElementPath, texture, null, null);
	}

	// Token: 0x060080E9 RID: 33001 RVA: 0x002789A9 File Offset: 0x00276BA9
	private void OnClickButton()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.VisionDirectionalFusionSelectTargetView))
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.VisionDirectionalFusionSelectTargetView, null, null);
	}

	// Token: 0x02006EC6 RID: 28358
	private enum EComponent
	{
		// Token: 0x04024362 RID: 148322
		Button,
		// Token: 0x04024363 RID: 148323
		BgSprite,
		// Token: 0x04024364 RID: 148324
		IconTexture,
		// Token: 0x04024365 RID: 148325
		NameText
	}
}
