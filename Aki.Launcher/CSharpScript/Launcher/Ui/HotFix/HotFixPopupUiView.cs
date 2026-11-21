using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E4 RID: 228
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixPopupUiView : LaunchComponentsAction
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x0003D1CC File Offset: 0x0003B3CC
		protected override void OnStart()
		{
			base.AttachElement<HotFixBtnUiItem>(5);
			base.AttachElement<HotFixBtnUiItem>(6);
			base.AttachElement<HotFixBtnUiItem>(7);
			UUIExtendToggle extendToggle = base.GetExtendToggle(9);
			if (extendToggle != null)
			{
				extendToggle.RootUIComp.Get().SetUIActive(false);
			}
			HotFixManager.SetLocalText(base.GetText(10), "PrefabTextItem_136241376_Text", Array.Empty<string>());
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0003D228 File Offset: 0x0003B428
		public void SetConfirmationTitle(string tableId)
		{
			HotFixManager.SetLocalText(base.GetText(4), tableId, Array.Empty<string>());
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0003D23C File Offset: 0x0003B43C
		public void SetConfirmationContent(string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(base.GetText(8), tableId, args);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0003D24C File Offset: 0x0003B44C
		public void SetConfirmationLeftButtonCallBack(Action callback)
		{
			base.GetElement<HotFixBtnUiItem>(5).BindClickCallback(callback);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0003D25B File Offset: 0x0003B45B
		public void SetConfirmationRightButtonCallBack(Action callback)
		{
			base.GetElement<HotFixBtnUiItem>(6).BindClickCallback(callback);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0003D26A File Offset: 0x0003B46A
		public void SetConfirmationMiddleButtonCallBack(Action callback)
		{
			base.GetElement<HotFixBtnUiItem>(7).BindClickCallback(callback);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0003D279 File Offset: 0x0003B479
		public void SetConfirmationCloseButtonCallBack(Action callback)
		{
			base.GetButton(2).OnClickCallBack.Unbind();
			base.GetButton(2).OnClickCallBack.Bind(callback);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0003D29E File Offset: 0x0003B49E
		[NullableContext(2)]
		public void SetConfirmationLeftButtonText(string tableId)
		{
			base.GetElement<HotFixBtnUiItem>(5).SetText(tableId, Array.Empty<string>());
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0003D2B2 File Offset: 0x0003B4B2
		[NullableContext(2)]
		public void SetConfirmationRightButtonText(string tableId)
		{
			base.GetElement<HotFixBtnUiItem>(6).SetText(tableId, Array.Empty<string>());
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0003D2C6 File Offset: 0x0003B4C6
		[NullableContext(2)]
		public void SetConfirmationMiddleButtonText(string tableId)
		{
			base.GetElement<HotFixBtnUiItem>(7).SetText(tableId, Array.Empty<string>());
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0003D2DA File Offset: 0x0003B4DA
		public void SetConfirmationLeftButtonActive(bool value)
		{
			base.GetElement<HotFixBtnUiItem>(5).SetActive(value);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0003D2E9 File Offset: 0x0003B4E9
		public void SetConfirmationRightButtonActive(bool value)
		{
			base.GetElement<HotFixBtnUiItem>(6).SetActive(value);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0003D2F8 File Offset: 0x0003B4F8
		public void SetConfirmationMiddleButtonActive(bool value)
		{
			base.GetElement<HotFixBtnUiItem>(7).SetActive(value);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0003D308 File Offset: 0x0003B508
		public void SetConfirmationCloseButtonActive(bool value)
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(value);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0003D330 File Offset: 0x0003B530
		public void SetUploadLogToggleActive(bool active)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(9);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				extendToggle.RootUIComp.Get().SetUIActive(active);
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0003D368 File Offset: 0x0003B568
		public bool GetUploadLogToggleOn()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(9);
			return extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x02000387 RID: 903
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04001248 RID: 4680
			public const int BtnMask = 0;

			// Token: 0x04001249 RID: 4681
			public const int BtnRoot = 1;

			// Token: 0x0400124A RID: 4682
			public const int BtnBack = 2;

			// Token: 0x0400124B RID: 4683
			public const int CostItem = 3;

			// Token: 0x0400124C RID: 4684
			public const int TxtTitle = 4;

			// Token: 0x0400124D RID: 4685
			public const int LeftBtnItem = 5;

			// Token: 0x0400124E RID: 4686
			public const int RightBtnItem = 6;

			// Token: 0x0400124F RID: 4687
			public const int MiddleBtnItem = 7;

			// Token: 0x04001250 RID: 4688
			public const int TxtContent = 8;

			// Token: 0x04001251 RID: 4689
			public const int ToggleUploadLog = 9;

			// Token: 0x04001252 RID: 4690
			public const int ToggleText = 10;
		}
	}
}
