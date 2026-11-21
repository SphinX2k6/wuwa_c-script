using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Define;
using CSharpScript.Launcher.Update.ResourceDiffUpdate;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D4 RID: 212
	public class HotFixDownLoadTabItem : LaunchComponentsAction, IHotFixLayoutItem
	{
		// Token: 0x060006F8 RID: 1784 RVA: 0x0003AF94 File Offset: 0x00039194
		[NullableContext(1)]
		public void SetRootActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0003AF9D File Offset: 0x0003919D
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

		// Token: 0x060006FA RID: 1786 RVA: 0x0003AFC8 File Offset: 0x000391C8
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

		// Token: 0x060006FB RID: 1787 RVA: 0x0003B06C File Offset: 0x0003926C
		public void Select()
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0003B080 File Offset: 0x00039280
		public void RefreshSpace()
		{
			long resSize = ResourceDiffUpdaterManager.Instance.GetResSize((EResUpdateType)this.TabIndex, HotFixDownLoadTabItem.GetSelectTier());
			base.GetText(2).SetText(HotFixManager.ByteConverter(resSize), true);
			LauncherLog instance = LauncherLog.Instance;
			string message = "HotFixDownLoadTabItem-RefreshSpace";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("byte", resSize);
			instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0003B0E0 File Offset: 0x000392E0
		private static ETier? GetSelectTier()
		{
			if (HotFixManager.SelectResourceQualityTier == ETier.None)
			{
				return null;
			}
			return new ETier?(HotFixManager.SelectResourceQualityTier);
		}

		// Token: 0x0400044B RID: 1099
		private int TabIndex;

		// Token: 0x0400044C RID: 1100
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, UUIExtendToggle> OnClickExtendToggleCallBack;

		// Token: 0x0400044D RID: 1101
		[Nullable(2)]
		private UUIExtendToggle ToggleRef;

		// Token: 0x02000372 RID: 882
		private static class EHotFixDownLoadTabData
		{
			// Token: 0x040011E6 RID: 4582
			public const int Toggle = 0;

			// Token: 0x040011E7 RID: 4583
			public const int NameText = 1;

			// Token: 0x040011E8 RID: 4584
			public const int SpaceText = 2;
		}
	}
}
