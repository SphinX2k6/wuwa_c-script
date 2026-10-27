using System;
using CSharpScript.Launcher.Ui;
using CSharpScript.Launcher.Ui.HotFix;
using UnrealEngine;

namespace CSharpScript.Game.Module.Launcher.Action
{
	// Token: 0x02000035 RID: 53
	public class HotFixSubPackageDownLoadVersionTipsView : LaunchComponentsAction
	{
		// Token: 0x060001F7 RID: 503 RVA: 0x0000B155 File Offset: 0x00009355
		protected override void OnStart()
		{
			base.GetButton(0).OnClickCallBack.Bind(delegate()
			{
				LauncherLog.Instance.Info("HotFixSubPackageDownLoadVersionTipsView MaskBtn", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetActive(false);
			});
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000B174 File Offset: 0x00009374
		public void RefreshItemByClearType(int clearType, FVector vector)
		{
			HotFixManager.SetLocalText(base.GetText(2), "HotFixSubPackageClearTipsTitle_TipsTitle_" + HotFixDownSubPackageDownLoadMobileClearPopViewDefine.ClearTypeToTipsNumber[clearType].ToString(), Array.Empty<string>());
			HotFixManager.SetLocalText(base.GetText(3), "HotFixSubPackageClearTipsTitle_TipsDes_" + HotFixDownSubPackageDownLoadMobileClearPopViewDefine.ClearTypeToTipsNumber[clearType].ToString(), Array.Empty<string>());
			this.TipsVector.X = vector.X + 45f;
			this.TipsVector.Z = vector.Z + 20f;
			FHitResult fhitResult = new FHitResult();
			base.GetItem(1).D_K2_SetWorldLocation(this.TipsVector, false, ref fhitResult, false);
		}

		// Token: 0x040000E8 RID: 232
		private const int BG_ITEM_OFFSETX = 45;

		// Token: 0x040000E9 RID: 233
		private const int BG_ITEM_OFFSETZ = 20;

		// Token: 0x040000EA RID: 234
		private FVector TipsVector = new FVector();

		// Token: 0x020002B0 RID: 688
		private static class EComponentDefine
		{
			// Token: 0x04000A92 RID: 2706
			public const int MaskBtn = 0;

			// Token: 0x04000A93 RID: 2707
			public const int BgItem = 1;

			// Token: 0x04000A94 RID: 2708
			public const int TitleText = 2;

			// Token: 0x04000A95 RID: 2709
			public const int ContentText = 3;
		}
	}
}
