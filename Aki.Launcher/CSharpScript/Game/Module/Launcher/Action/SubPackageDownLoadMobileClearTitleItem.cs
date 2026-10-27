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
		// Token: 0x060001E5 RID: 485 RVA: 0x0000AA6C File Offset: 0x00008C6C
		protected override void OnStart()
		{
			base.GetButton(1).OnClickCallBack.Bind(new Action(this.OnClickHelpBtn));
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000AA98 File Offset: 0x00008C98
		public void RefreshItem(int type)
		{
			this.TitleType = type;
			HotFixManager.SetLocalText(base.GetText(0), "HotFixSubPackageClearTipsTitle_" + HotFixDownSubPackageDownLoadMobileClearPopViewDefine.ClearTypeToTipsNumber[this.TitleType].ToString(), Array.Empty<string>());
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		private void OnClickHelpBtn()
		{
			LauncherLog.Instance.Info("SubPackageDownLoadMobileClearTitleItem HelpBtn", default(ReadOnlySpan<ValueTuple<string, object>>));
			if (this.OnClickHelpBtnCallBack != null)
			{
				this.OnClickHelpBtnCallBack(this.TitleType, base.GetButton(1).RootUIComp);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000AB30 File Offset: 0x00008D30
		public void SelectItem()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "SubPackageDownLoadMobileClearTitleItem SelectItem";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TitleType", this.TitleType);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.GetItem(2).SetUIActive(true);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000AB78 File Offset: 0x00008D78
		public void UnSelectItem()
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "SubPackageDownLoadMobileClearTitleItem UnSelectItem";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TitleType", this.TitleType);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.GetItem(2).SetUIActive(false);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000ABC0 File Offset: 0x00008DC0
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

		// Token: 0x040000E1 RID: 225
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIItem> OnClickHelpBtnCallBack;

		// Token: 0x040000E2 RID: 226
		private int TitleType;

		// Token: 0x020002AE RID: 686
		private class ESubPackageDownLoadMobileClearTitleItem
		{
			// Token: 0x04000A89 RID: 2697
			public const int Text = 0;

			// Token: 0x04000A8A RID: 2698
			public const int HelpBtn = 1;

			// Token: 0x04000A8B RID: 2699
			public const int SelectItem = 2;
		}
	}
}
