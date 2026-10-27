using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000E1 RID: 225
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixPopupUiView : LaunchComponentsAction
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x0003B5E0 File Offset: 0x000397E0
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

		// Token: 0x0600075F RID: 1887 RVA: 0x0003B63C File Offset: 0x0003983C
		public void SetConfirmationTitle(string tableId)
		{
			HotFixManager.SetLocalText(base.GetText(4), tableId, Array.Empty<string>());
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0003B650 File Offset: 0x00039850
		public void SetConfirmationContent(string tableId, params string[] args)
		{
			HotFixManager.SetLocalText(base.GetText(8), tableId, args);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0003B660 File Offset: 0x00039860
		public void SetConfirmationLeftButtonCallBack(Action callback)
		{
			base.GetElement<HotFixBtnUiItem>(5).BindClickCallback(callback);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0003B66F File Offset: 0x0003986F
		public void SetConfirmationRightButtonCallBack(Action callback)
		{
			base.GetElement<HotFixBtnUiItem>(6).BindClickCallback(callback);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0003B67E File Offset: 0x0003987E
		public void SetConfirmationMiddleButtonCallBack(Action callback)
		{
			base.GetElement<HotFixBtnUiItem>(7).BindClickCallback(callback);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0003B68D File Offset: 0x0003988D
		public void SetConfirmationCloseButtonCallBack(Action callback)
		{
			base.GetButton(2).OnClickCallBack.Unbind();
			base.GetButton(2).OnClickCallBack.Bind(callback);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0003B6B2 File Offset: 0x000398B2
		[NullableContext(2)]
		public void SetConfirmationLeftButtonText(string tableId)
		{
			base.GetElement<HotFixBtnUiItem>(5).SetText(tableId, Array.Empty<string>());
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0003B6C6 File Offset: 0x000398C6
		[NullableContext(2)]
		public void SetConfirmationRightButtonText(string tableId)
		{
			base.GetElement<HotFixBtnUiItem>(6).SetText(tableId, Array.Empty<string>());
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0003B6DA File Offset: 0x000398DA
		[NullableContext(2)]
		public void SetConfirmationMiddleButtonText(string tableId)
		{
			base.GetElement<HotFixBtnUiItem>(7).SetText(tableId, Array.Empty<string>());
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0003B6EE File Offset: 0x000398EE
		public void SetConfirmationLeftButtonActive(bool value)
		{
			base.GetElement<HotFixBtnUiItem>(5).SetActive(value);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0003B6FD File Offset: 0x000398FD
		public void SetConfirmationRightButtonActive(bool value)
		{
			base.GetElement<HotFixBtnUiItem>(6).SetActive(value);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0003B70C File Offset: 0x0003990C
		public void SetConfirmationMiddleButtonActive(bool value)
		{
			base.GetElement<HotFixBtnUiItem>(7).SetActive(value);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0003B71C File Offset: 0x0003991C
		public void SetConfirmationCloseButtonActive(bool value)
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(value);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0003B744 File Offset: 0x00039944
		public void SetUploadLogToggleActive(bool active)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(9);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				extendToggle.RootUIComp.Get().SetUIActive(active);
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0003B77C File Offset: 0x0003997C
		public bool GetUploadLogToggleOn()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(9);
			return extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x0200037C RID: 892
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040011E3 RID: 4579
			public const int BtnMask = 0;

			// Token: 0x040011E4 RID: 4580
			public const int BtnRoot = 1;

			// Token: 0x040011E5 RID: 4581
			public const int BtnBack = 2;

			// Token: 0x040011E6 RID: 4582
			public const int CostItem = 3;

			// Token: 0x040011E7 RID: 4583
			public const int TxtTitle = 4;

			// Token: 0x040011E8 RID: 4584
			public const int LeftBtnItem = 5;

			// Token: 0x040011E9 RID: 4585
			public const int RightBtnItem = 6;

			// Token: 0x040011EA RID: 4586
			public const int MiddleBtnItem = 7;

			// Token: 0x040011EB RID: 4587
			public const int TxtContent = 8;

			// Token: 0x040011EC RID: 4588
			public const int ToggleUploadLog = 9;

			// Token: 0x040011ED RID: 4589
			public const int ToggleText = 10;
		}
	}
}
