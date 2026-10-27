using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D1 RID: 209
	public class HotFixDownLoadTabItem : LaunchComponentsAction, IHotFixLayoutItem
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x00039464 File Offset: 0x00037664
		[NullableContext(1)]
		public void SetRootActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0003946D File Offset: 0x0003766D
		protected override void OnStart()
		{
			this.ToggleRef = base.GetExtendToggle(0);
			this.ToggleRef.OnStateChange.Add(delegate(EToggleState state)
			{
				if (state == EToggleState.ETT_Checked && this.OnClickExtendToggleCallBack != null)
				{
					this.OnClickExtendToggleCallBack(this.TabIndex, this.ToggleRef);
				}
			});
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00039498 File Offset: 0x00037698
		[NullableContext(1)]
		public void Refresh(IHotFixLayoutData data)
		{
			IHotFixDownLoadTabItemData hotFixDownLoadTabItemData = (IHotFixDownLoadTabItemData)data;
			this.TabIndex = hotFixDownLoadTabItemData.TabId;
			LauncherDownLoadConfig downLoadTabConfig = LauncherConfigLib.Instance.GetDownLoadTabConfig(this.TabIndex.ToString());
			HotFixManager.SetLocalText(base.GetText(1), (downLoadTabConfig != null) ? downLoadTabConfig.Title : null, Array.Empty<string>());
			long resSize = ResourceDiffUpdaterManager.Instance.GetResSize((EResUpdateType)this.TabIndex, HotFixDownLoadTabItem.GetSelectTier());
			base.GetText(2).SetText(HotFixManager.ByteConverter(resSize), true);
			LauncherLog instance = LauncherLog.Instance;
			string message = "HotFixDownLoadTabItem";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("byte", resSize);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0003953C File Offset: 0x0003773C
		public void Select()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00039550 File Offset: 0x00037750
		public void RefreshSpace()
		{
			long resSize = ResourceDiffUpdaterManager.Instance.GetResSize((EResUpdateType)this.TabIndex, HotFixDownLoadTabItem.GetSelectTier());
			base.GetText(2).SetText(HotFixManager.ByteConverter(resSize), true);
			LauncherLog instance = LauncherLog.Instance;
			string message = "HotFixDownLoadTabItem-RefreshSpace";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("byte", resSize);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000395B0 File Offset: 0x000377B0
		private static ETier? GetSelectTier()
		{
			if (HotFixManager.SelectResourceQualityTier == ETier.None)
			{
				return null;
			}
			return new ETier?(HotFixManager.SelectResourceQualityTier);
		}

		// Token: 0x0400041C RID: 1052
		private int TabIndex;

		// Token: 0x0400041D RID: 1053
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickExtendToggleCallBack;

		// Token: 0x0400041E RID: 1054
		[Nullable(2)]
		private UUIExtendToggle ToggleRef;

		// Token: 0x02000367 RID: 871
		private static class EHotFixDownLoadTabData
		{
			// Token: 0x04001184 RID: 4484
			public const int Toggle = 0;

			// Token: 0x04001185 RID: 4485
			public const int NameText = 1;

			// Token: 0x04001186 RID: 4486
			public const int SpaceText = 2;
		}
	}
}
