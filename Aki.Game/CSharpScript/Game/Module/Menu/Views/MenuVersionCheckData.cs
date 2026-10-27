using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x02005412 RID: 21522
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuVersionCheckData : MenuData
	{
		// Token: 0x06037030 RID: 225328 RVA: 0x00D0903B File Offset: 0x00D0723B
		public MenuVersionCheckData(MenuConfig Config) : base(Config)
		{
		}

		// Token: 0x17008432 RID: 33842
		// (get) Token: 0x06037031 RID: 225329 RVA: 0x00D09044 File Offset: 0x00D07244
		public override string FunctionName
		{
			get
			{
				return "CurrentVersion";
			}
		}

		// Token: 0x17008433 RID: 33843
		// (get) Token: 0x06037032 RID: 225330 RVA: 0x00D0904B File Offset: 0x00D0724B
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

		// Token: 0x17008434 RID: 33844
		// (get) Token: 0x06037033 RID: 225331 RVA: 0x00D09064 File Offset: 0x00D07264
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

		// Token: 0x17008435 RID: 33845
		// (get) Token: 0x06037034 RID: 225332 RVA: 0x00D09074 File Offset: 0x00D07274
		public override bool EnableRedDot
		{
			get
			{
				return ParallelPackageController.Instance.CheckParallelPackage();
			}
		}

		// Token: 0x06037035 RID: 225333 RVA: 0x00D09080 File Offset: 0x00D07280
		public override void OnRefresh()
		{
			this.RefreshVersionCheckRedDotIsRead();
		}

		// Token: 0x06037036 RID: 225334 RVA: 0x00D09088 File Offset: 0x00D07288
		private void RefreshVersionCheckRedDotIsRead()
		{
			RedDotBase redDot = RedDotModel.Instance.GetRedDot(ERedDotName.RedDotVersionCheck);
			if (redDot != null && redDot.IsRedDotActive())
			{
				LocalStorage.SetPlayer<string>(ELocalStoragePlayerKey.VersionRedDotMap, UKuroLauncherLibrary.GetAppVersion());
				EventSystem.Instance.Emit(EEventName.VersionCheckRefresh);
			}
		}

		// Token: 0x06037037 RID: 225335 RVA: 0x00D090C4 File Offset: 0x00D072C4
		public override bool GetButtonEnable()
		{
			return ParallelPackageController.Instance.CheckParallelPackage();
		}
	}
}
