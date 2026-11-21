using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020012C2 RID: 4802
public class HandBookEntranceItem : GridProxyAbstract<HandBookEntrance>
{
	// Token: 0x0600BDB9 RID: 48569 RVA: 0x00380158 File Offset: 0x0037E358
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

	// Token: 0x0600BDBA RID: 48570 RVA: 0x00380217 File Offset: 0x0037E417
	protected override void OnStart()
	{
	}

	// Token: 0x0600BDBB RID: 48571 RVA: 0x0038021C File Offset: 0x0037E41C
	public override void Refresh(HandBookEntrance handBookEntrance, bool isSelected, int gridIndex)
	{
		this.HandBookEntrance = new HandBookEntrance?(handBookEntrance);
		base.GetText(0).ShowTextNew(this.HandBookEntrance.Value.Name);
		base.SetTextureByPath(handBookEntrance.Texture, base.GetTexture(1), null, null);
		this.RefreshRedDot();
		this.RefreshCollectProgress();
	}

	// Token: 0x0600BDBC RID: 48572 RVA: 0x00380280 File Offset: 0x0037E480
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

	// Token: 0x0600BDBD RID: 48573 RVA: 0x003802CC File Offset: 0x0037E4CC
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

	// Token: 0x0600BDBE RID: 48574 RVA: 0x00380364 File Offset: 0x0037E564
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

	// Token: 0x04006D48 RID: 27976
	private HandBookEntrance? HandBookEntrance;

	// Token: 0x02007548 RID: 30024
	private class EHandBookEntranceItemDefine
	{
		// Token: 0x04026199 RID: 156057
		public const int NameText = 0;

		// Token: 0x0402619A RID: 156058
		public const int Texture = 1;

		// Token: 0x0402619B RID: 156059
		public const int CollectCountText = 2;

		// Token: 0x0402619C RID: 156060
		public const int Button = 3;

		// Token: 0x0402619D RID: 156061
		public const int RedDotItem = 4;

		// Token: 0x0402619E RID: 156062
		public const int NewCollectCountText = 5;
	}
}
