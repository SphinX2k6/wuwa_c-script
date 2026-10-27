using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200175A RID: 5978
public class VisionRecoveryDirectionalFusionItem : UiPanelBase
{
	// Token: 0x0600AD00 RID: 44288 RVA: 0x0026E3F0 File Offset: 0x0026C5F0
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

	// Token: 0x0600AD01 RID: 44289 RVA: 0x0026E484 File Offset: 0x0026C684
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

	// Token: 0x0600AD02 RID: 44290 RVA: 0x0026E52D File Offset: 0x0026C72D
	private void OnClickButton()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.VisionDirectionalFusionSelectTargetView))
		{
			return;
		}
		UiManager.Instance.OpenView(EUiViewName.VisionDirectionalFusionSelectTargetView, null, null);
	}

	// Token: 0x02007D40 RID: 32064
	private enum EComponent
	{
		// Token: 0x04029037 RID: 167991
		Button,
		// Token: 0x04029038 RID: 167992
		BgSprite,
		// Token: 0x04029039 RID: 167993
		IconTexture,
		// Token: 0x0402903A RID: 167994
		NameText
	}
}
