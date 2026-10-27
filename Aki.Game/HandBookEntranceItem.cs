using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E00 RID: 7680
public class HandBookEntranceItem : GridProxyAbstract<HandBookEntrance>
{
	// Token: 0x0600E99A RID: 59802 RVA: 0x00374450 File Offset: 0x00372650
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnButtonClicked))
		};
	}

	// Token: 0x0600E99B RID: 59803 RVA: 0x0037450F File Offset: 0x0037270F
	protected override void OnStart()
	{
	}

	// Token: 0x0600E99C RID: 59804 RVA: 0x00374514 File Offset: 0x00372714
	public override void Refresh(HandBookEntrance handBookEntrance, bool isSelected, int gridIndex)
	{
		this.HandBookEntrance = new HandBookEntrance?(handBookEntrance);
		base.GetText(0).ShowTextNew(this.HandBookEntrance.Value.Name);
		base.SetTextureByPath(handBookEntrance.Texture, base.GetTexture(1), null, null);
		this.RefreshRedDot();
		this.RefreshCollectProgress();
	}

	// Token: 0x0600E99D RID: 59805 RVA: 0x00374578 File Offset: 0x00372778
	public void RefreshRedDot()
	{
		if (this.HandBookEntrance == null)
		{
			return;
		}
		bool uiactive = HandBookModel.Instance.IsShowRedDot((EHandBookTabType)this.HandBookEntrance.Value.Id);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
	}

	// Token: 0x0600E99E RID: 59806 RVA: 0x003745C4 File Offset: 0x003727C4
	public void RefreshCollectProgress()
	{
		int[] collectProgress = HandBookController.Instance.GetCollectProgress((EHandBookTabType)this.HandBookEntrance.Value.Id);
		if (this.HandBookEntrance.Value.Id != 3)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(5), "CollectProgress", new <>z__ReadOnlyArray<object>(new object[]
			{
				collectProgress[0],
				collectProgress[1]
			}));
			return;
		}
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		text.SetText(collectProgress[0].ToString(), true);
	}

	// Token: 0x0600E99F RID: 59807 RVA: 0x0037465C File Offset: 0x0037285C
	private void OnButtonClicked()
	{
		switch (this.HandBookEntrance.Value.Id)
		{
		case 0:
			UiManager.Instance.OpenView(EUiViewName.MonsterHandBookView, null, null);
			return;
		case 1:
			UiManager.Instance.OpenView(EUiViewName.PhantomHandBookView, null, null);
			return;
		case 2:
			UiManager.Instance.OpenView(EUiViewName.GeographyHandBookView, null, null);
			return;
		case 3:
			UiManager.Instance.OpenView(EUiViewName.WeaponHandBookView, null, null);
			return;
		case 4:
			UiManager.Instance.OpenView(EUiViewName.AnimalHandBookView, null, null);
			return;
		case 5:
			UiManager.Instance.OpenView(EUiViewName.ItemHandBookView, null, null);
			return;
		case 6:
			UiManager.Instance.OpenView(EUiViewName.ChipHandBookView, null, null);
			return;
		case 7:
			UiManager.Instance.OpenView(EUiViewName.QuestHandBookView, null, null);
			return;
		case 10:
			UiManager.Instance.OpenView(EUiViewName.HandBookRoleView, null, null);
			return;
		case 11:
			UiManager.Instance.OpenView(EUiViewName.NounHandBookView, null, null);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.HandBook;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "没有找到图鉴入口类型，请检查";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("this.HandBookEntrance.Id", this.HandBookEntrance.Value.Id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x04006C67 RID: 27751
	private HandBookEntrance? HandBookEntrance;

	// Token: 0x020083C3 RID: 33731
	private class EHandBookEntranceItemDefine
	{
		// Token: 0x0402AE76 RID: 175734
		public const int NameText = 0;

		// Token: 0x0402AE77 RID: 175735
		public const int Texture = 1;

		// Token: 0x0402AE78 RID: 175736
		public const int CollectCountText = 2;

		// Token: 0x0402AE79 RID: 175737
		public const int Button = 3;

		// Token: 0x0402AE7A RID: 175738
		public const int RedDotItem = 4;

		// Token: 0x0402AE7B RID: 175739
		public const int NewCollectCountText = 5;
	}
}
