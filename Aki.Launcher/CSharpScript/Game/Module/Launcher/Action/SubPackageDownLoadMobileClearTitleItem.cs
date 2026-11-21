using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x02000033 RID: 51
	public class SubPackageDownLoadMobileClearTitleItem : LaunchComponentsAction
	{
		// Token: 0x060001E5 RID: 485 RVA: 0x0000AAA4 File Offset: 0x00008CA4
		protected override void OnStart()
		{
			base.GetButton(1).OnClickCallBack.Bind(new Action(this.OnClickHelpBtn));
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		public void RefreshItem(int type)
		{
			this.TitleType = type;
			HotFixManager.SetLocalText(base.GetText(0), "HotFixSubPackageClearTipsTitle_" + HotFixDownSubPackageDownLoadMobileClearPopViewDefine.ClearTypeToTipsNumber[this.TitleType].ToString(), Array.Empty<string>());
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AB18 File Offset: 0x00008D18
		private void OnClickHelpBtn()
		{
			LauncherLog.Instance.Info("SubPackageDownLoadMobileClearTitleItem HelpBtn", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.OnClickHelpBtnCallBack != null)
			{
				this.OnClickHelpBtnCallBack(this.TitleType, base.GetButton(1).RootUIComp);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000AB68 File Offset: 0x00008D68
		public void SelectItem()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "SubPackageDownLoadMobileClearTitleItem SelectItem";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TitleType", this.TitleType);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		public void UnSelectItem()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "SubPackageDownLoadMobileClearTitleItem UnSelectItem";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TitleType", this.TitleType);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		public void ClickItemOnGamePad()
		{
			LauncherLog.Instance.Info("SubPackageDownLoadMobileClearTitleItem HelpBtn ClickItemOnGamePad", default(ReadOnlySpan<ValueTuple<string, object>>));
			Action<int, UUIItem> onClickHelpBtnCallBack = this.OnClickHelpBtnCallBack;
			if (onClickHelpBtnCallBack == null)
			{
				return;
			}
			onClickHelpBtnCallBack(this.TitleType, base.GetButton(1).RootUIComp);
		}

		// Token: 0x040000E2 RID: 226
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIItem> OnClickHelpBtnCallBack;

		// Token: 0x040000E3 RID: 227
		private int TitleType;

		// Token: 0x020002B7 RID: 695
		private class ESubPackageDownLoadMobileClearTitleItem
		{
			// Token: 0x04000AD9 RID: 2777
			public const int Text = 0;

			// Token: 0x04000ADA RID: 2778
			public const int HelpBtn = 1;

			// Token: 0x04000ADB RID: 2779
			public const int SelectItem = 2;
		}
	}
}
