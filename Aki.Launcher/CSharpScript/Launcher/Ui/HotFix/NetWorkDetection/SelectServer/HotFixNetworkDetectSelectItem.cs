using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection.SelectServer
{
	// Token: 0x020000FB RID: 251
	public class HotFixNetworkDetectSelectItem : LaunchComponentsAction, IHotFixLayoutItem
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x0003DCE1 File Offset: 0x0003BEE1
		[NullableContext(1)]
		public void SetRootActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0003DCEA File Offset: 0x0003BEEA
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnSelectServerToggleEvent));
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0003DD23 File Offset: 0x0003BF23
		[NullableContext(1)]
		public UUIExtendToggle GetToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0003DD2C File Offset: 0x0003BF2C
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(0).OnStateChange.Clear();
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0003DD40 File Offset: 0x0003BF40
		public void RefreshToggleState()
		{
			bool flag = HotFixNetworkDetectionModel.Instance.CurrentUiSelectSeverData == this.Data.LoginServersData;
			base.GetExtendToggle(0).SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0003DD7C File Offset: 0x0003BF7C
		protected override void OnShow()
		{
			this.UpdateServerInfo();
			this.RefreshToggleState();
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0003DD8A File Offset: 0x0003BF8A
		[NullableContext(1)]
		public void Refresh(IHotFixLayoutData data)
		{
			this.Data = (IHotFixNetworkDetectSelectData)data;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0003DD98 File Offset: 0x0003BF98
		private void UpdateServerInfo()
		{
			base.GetText(1).SetText(this.Data.LoginServersData.name, true);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0003DDB7 File Offset: 0x0003BFB7
		private void OnSelectServerToggleEvent(EToggleState state)
		{
			if (this.Data != null)
			{
				HotFixNetworkDetectionModel.Instance.CurrentUiSelectSeverData = this.Data.LoginServersData;
			}
			Action onToggleStateChange = this.OnToggleStateChange;
			if (onToggleStateChange == null)
			{
				return;
			}
			onToggleStateChange();
		}

		// Token: 0x040004B3 RID: 1203
		[Nullable(2)]
		public IHotFixNetworkDetectSelectData Data;

		// Token: 0x040004B4 RID: 1204
		[Nullable(2)]
		public Action OnToggleStateChange;

		// Token: 0x02000394 RID: 916
		private static class EComponents
		{
			// Token: 0x04001276 RID: 4726
			public const int StripToggle = 0;

			// Token: 0x04001277 RID: 4727
			public const int TxtServerName = 1;

			// Token: 0x04001278 RID: 4728
			public const int ServerInfo = 2;

			// Token: 0x04001279 RID: 4729
			public const int RoleNode = 3;

			// Token: 0x0400127A RID: 4730
			public const int TxtLevel = 4;

			// Token: 0x0400127B RID: 4731
			public const int PnlState = 5;
		}
	}
}
