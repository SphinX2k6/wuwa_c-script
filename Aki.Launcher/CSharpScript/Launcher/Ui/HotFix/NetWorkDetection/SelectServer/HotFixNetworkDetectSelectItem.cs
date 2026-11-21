using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection.SelectServer
{
	// Token: 0x020000FF RID: 255
	public class HotFixNetworkDetectSelectItem : LaunchComponentsAction, IHotFixLayoutItem
	{
		// Token: 0x0600087B RID: 2171 RVA: 0x00040081 File Offset: 0x0003E281
		[NullableContext(1)]
		public void SetRootActor(AActor actor)
		{
			base.SetRootActorLaunchComponentsAction(actor);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0004008A File Offset: 0x0003E28A
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
			base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnSelectServerToggleEvent));
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000400C3 File Offset: 0x0003E2C3
		[NullableContext(1)]
		public UUIExtendToggle GetToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000400CC File Offset: 0x0003E2CC
		protected override void OnBeforeDestroy()
		{
			base.GetExtendToggle(0).OnStateChange.Clear();
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x000400E0 File Offset: 0x0003E2E0
		public void RefreshToggleState()
		{
			bool flag = HotFixNetworkDetectionModel.Instance.CurrentUiSelectSeverData == this.Data.LoginServersData;
			base.GetExtendToggle(0).SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0004011C File Offset: 0x0003E31C
		protected override void OnShow()
		{
			this.UpdateServerInfo();
			this.RefreshToggleState();
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0004012A File Offset: 0x0003E32A
		[NullableContext(1)]
		public void Refresh(IHotFixLayoutData data)
		{
			this.Data = (IHotFixNetworkDetectSelectData)data;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00040138 File Offset: 0x0003E338
		private void UpdateServerInfo()
		{
			base.GetText(1).SetText(this.Data.LoginServersData.name, true);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00040157 File Offset: 0x0003E357
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

		// Token: 0x040004EE RID: 1262
		[Nullable(2)]
		public IHotFixNetworkDetectSelectData Data;

		// Token: 0x040004EF RID: 1263
		[Nullable(2)]
		public Action OnToggleStateChange;

		// Token: 0x020003A1 RID: 929
		private static class EComponents
		{
			// Token: 0x040012EC RID: 4844
			public const int StripToggle = 0;

			// Token: 0x040012ED RID: 4845
			public const int TxtServerName = 1;

			// Token: 0x040012EE RID: 4846
			public const int ServerInfo = 2;

			// Token: 0x040012EF RID: 4847
			public const int RoleNode = 3;

			// Token: 0x040012F0 RID: 4848
			public const int TxtLevel = 4;

			// Token: 0x040012F1 RID: 4849
			public const int PnlState = 5;
		}
	}
}
