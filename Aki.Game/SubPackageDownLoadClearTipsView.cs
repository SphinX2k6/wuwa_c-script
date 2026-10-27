using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002A9F RID: 10911
public class SubPackageDownLoadClearTipsView : UiViewBase
{
	// Token: 0x06016B95 RID: 93077 RVA: 0x005C31DC File Offset: 0x005C13DC
	[NullableContext(1)]
	public SubPackageDownLoadClearTipsView(UiViewInfo uiViewInfo) : base(uiViewInfo)
	{
	}

	// Token: 0x06016B96 RID: 93078 RVA: 0x005C31E8 File Offset: 0x005C13E8
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

	// Token: 0x06016B97 RID: 93079 RVA: 0x005C331C File Offset: 0x005C151C
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

	// Token: 0x06016B98 RID: 93080 RVA: 0x005C33BC File Offset: 0x005C15BC
	private void OnClickCancelBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06016B99 RID: 93081 RVA: 0x005C33C5 File Offset: 0x005C15C5
	private void OnClickConfirmBtn()
	{
		SubPackageController.Instance.DeleteUnneededResource(false);
		base.CloseMe(null);
	}

	// Token: 0x06016B9A RID: 93082 RVA: 0x005C33DC File Offset: 0x005C15DC
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

	// Token: 0x020090D2 RID: 37074
	private class EComponentDefine
	{
		// Token: 0x0402EEBD RID: 192189
		public const int TitleText = 0;

		// Token: 0x0402EEBE RID: 192190
		public const int DesText = 1;

		// Token: 0x0402EEBF RID: 192191
		public const int SubDesText = 2;

		// Token: 0x0402EEC0 RID: 192192
		public const int BtnItem = 3;

		// Token: 0x0402EEC1 RID: 192193
		public const int CancelBtn = 4;

		// Token: 0x0402EEC2 RID: 192194
		public const int ConfirmBtn = 5;

		// Token: 0x0402EEC3 RID: 192195
		public const int Toggle = 6;

		// Token: 0x0402EEC4 RID: 192196
		public const int ToggleText = 7;

		// Token: 0x0402EEC5 RID: 192197
		public const int TipsText = 8;
	}
}
