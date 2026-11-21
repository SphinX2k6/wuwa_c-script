using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200201B RID: 8219
public class SubPackageDownLoadClearTipsView : UiViewBase
{
	// Token: 0x060145C4 RID: 83396 RVA: 0x005EFC58 File Offset: 0x005EDE58
	[NullableContext(1)]
	public SubPackageDownLoadClearTipsView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x060145C5 RID: 83397 RVA: 0x005EFC64 File Offset: 0x005EDE64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickCancelBtn)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmBtn)),
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x060145C6 RID: 83398 RVA: 0x005EFD98 File Offset: 0x005EDF98
	protected override void OnStart()
	{
		bool player = LocalStorage.GetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, false);
		base.GetExtendToggle(6).SetToggleState(player ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		long subPackageCanClearSpace = SubPackageDownLoadModel.Instance.GetSubPackageCanClearSpace();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "SubPackageDownLoad_Clear_Des", new <>z__ReadOnlySingleElementList<object>(SubPackageDownLoadModel.Instance.ByteConverter(subPackageCanClearSpace).ToString()));
		if (subPackageCanClearSpace > 0L)
		{
			base.GetItem(3).SetUIActive(true);
			base.GetText(8).SetUIActive(false);
			return;
		}
		base.GetItem(3).SetUIActive(false);
		base.GetText(8).SetUIActive(true);
	}

	// Token: 0x060145C7 RID: 83399 RVA: 0x005EFE38 File Offset: 0x005EE038
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x060145C8 RID: 83400 RVA: 0x005EFE41 File Offset: 0x005EE041
	private void OnClickConfirmBtn()
	{
		SubPackageController.Instance.DeleteUnneededResource(false);
		base.CloseMe(null);
	}

	// Token: 0x060145C9 RID: 83401 RVA: 0x005EFE58 File Offset: 0x005EE058
	private void OnClickToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AutoClearUnusedResourcesConfirm);
			confirmBoxDataNew.FunctionMap[1] = delegate()
			{
				ConfirmBoxController.Instance.CloseConfirmBoxView();
				base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			};
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, true);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.SubDownLoadClearOnLogin, false);
	}

	// Token: 0x02008316 RID: 33558
	private class EComponentDefine
	{
		// Token: 0x0402A5C2 RID: 173506
		public const int TitleText = 0;

		// Token: 0x0402A5C3 RID: 173507
		public const int DesText = 1;

		// Token: 0x0402A5C4 RID: 173508
		public const int SubDesText = 2;

		// Token: 0x0402A5C5 RID: 173509
		public const int BtnItem = 3;

		// Token: 0x0402A5C6 RID: 173510
		public const int CancelBtn = 4;

		// Token: 0x0402A5C7 RID: 173511
		public const int ConfirmBtn = 5;

		// Token: 0x0402A5C8 RID: 173512
		public const int Toggle = 6;

		// Token: 0x0402A5C9 RID: 173513
		public const int ToggleText = 7;

		// Token: 0x0402A5CA RID: 173514
		public const int TipsText = 8;
	}
}
