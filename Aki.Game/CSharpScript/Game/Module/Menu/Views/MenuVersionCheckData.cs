using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043F5 RID: 17397
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuVersionCheckData : MenuData
	{
		// Token: 0x0602BF79 RID: 180089 RVA: 0x00C58463 File Offset: 0x00C56663
		public MenuVersionCheckData(MenuConfig Config) : base(Config)
		{
		}

		// Token: 0x170057FE RID: 22526
		// (get) Token: 0x0602BF7A RID: 180090 RVA: 0x00C5846C File Offset: 0x00C5666C
		public override string FunctionName
		{
			get
			{
				return "CurrentVersion";
			}
		}

		// Token: 0x170057FF RID: 22527
		// (get) Token: 0x0602BF7B RID: 180091 RVA: 0x00C58473 File Offset: 0x00C56673
		public override string ButtonTextId
		{
			get
			{
				if (!ParallelPackageController.Instance.CheckParallelPackage())
				{
					return "NewVersionTip01";
				}
				return "NewVersionTip02";
			}
		}

		// Token: 0x17005800 RID: 22528
		// (get) Token: 0x0602BF7C RID: 180092 RVA: 0x00C5848C File Offset: 0x00C5668C
		public override string[] CustomTitleArgs
		{
			get
			{
				return new string[]
				{
					UKuroLauncherLibrary.GetAppVersion()
				};
			}
		}

		// Token: 0x17005801 RID: 22529
		// (get) Token: 0x0602BF7D RID: 180093 RVA: 0x00C5849C File Offset: 0x00C5669C
		public override bool EnableRedDot
		{
			get
			{
				return ParallelPackageController.Instance.CheckParallelPackage();
			}
		}

		// Token: 0x0602BF7E RID: 180094 RVA: 0x00C584A8 File Offset: 0x00C566A8
		public override void OnRefresh()
		{
			this.RefreshVersionCheckRedDotIsRead();
		}

		// Token: 0x0602BF7F RID: 180095 RVA: 0x00C584B0 File Offset: 0x00C566B0
		private void RefreshVersionCheckRedDotIsRead()
		{
			RedDotBase redDot = RedDotModel.Instance.GetRedDot(ERedDotName.RedDotVersionCheck);
			if (redDot != null && redDot.IsRedDotActive())
			{
				LocalStorage.SetPlayer<string>(ELocalStoragePlayerKey.VersionRedDotMap, UKuroLauncherLibrary.GetAppVersion());
				EventSystem.Instance.Emit(EEventName.VersionCheckRefresh);
			}
		}

		// Token: 0x0602BF80 RID: 180096 RVA: 0x00C584EC File Offset: 0x00C566EC
		public override bool GetButtonEnable()
		{
			return ParallelPackageController.Instance.CheckParallelPackage();
		}
	}
}
