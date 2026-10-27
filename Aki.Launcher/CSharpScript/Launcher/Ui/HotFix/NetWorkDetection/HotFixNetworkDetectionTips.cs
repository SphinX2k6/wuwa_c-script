using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F9 RID: 249
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectionTips : LaunchComponentsAction
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x0003D4C6 File Offset: 0x0003B6C6
		public void InitTickManager(UObject worldContext, string tickName)
		{
			this.TickManager = new UKuroTickManager(worldContext, tickName, EObjectFlags.RF_NoFlags);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0003D4D6 File Offset: 0x0003B6D6
		protected override void OnShow()
		{
			this.SetTextureIconActive(true);
			HotFixSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySequence("Loop", null);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0003D4F6 File Offset: 0x0003B6F6
		protected override void OnBeforeDestroy()
		{
			if (this.TickManager != null)
			{
				this.RemoveTickDelegate();
				this.TickManager = null;
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0003D50D File Offset: 0x0003B70D
		public void SetTextureIconActive(bool active)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0003D521 File Offset: 0x0003B721
		public void SetTipsText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0003D536 File Offset: 0x0003B736
		public void SetTipsLocalText(string textKey)
		{
			HotFixManager.SetLocalText(base.GetText(0), textKey, Array.Empty<string>());
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0003D54C File Offset: 0x0003B74C
		public void ShowTip(string textKey)
		{
			this.SetTipsLocalText(textKey);
			base.SetActive(true);
			this.SetTextureIconActive(false);
			this.RemoveTickDelegate();
			this.TickDelegate = new Action<float>(this.TickCallback);
			this.TickManager.AddTick(ETickingGroup.TG_PrePhysics, DelegateUtils.ToManualReleaseDelegate<FTickHandler>(this.TickDelegate), 0);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0003D59F File Offset: 0x0003B79F
		private void TickCallback(float delta)
		{
			this.TickTimeSinceStartup += (double)delta;
			if (this.TickTimeSinceStartup > 1.2)
			{
				base.SetActive(false);
				this.RemoveTickDelegate();
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0003D5CE File Offset: 0x0003B7CE
		private void RemoveTickDelegate()
		{
			if (this.TickDelegate != null)
			{
				this.TickManager.RemoveTick(ETickingGroup.TG_PrePhysics);
				DelegateUtils.ReleaseManualReleaseDelegate(this.TickDelegate);
				this.TickDelegate = null;
			}
			this.TickTimeSinceStartup = -1.0;
		}

		// Token: 0x040004A7 RID: 1191
		[Nullable(2)]
		private UKuroTickManager TickManager;

		// Token: 0x040004A8 RID: 1192
		[Nullable(2)]
		private Action<float> TickDelegate;

		// Token: 0x040004A9 RID: 1193
		private double TickTimeSinceStartup;

		// Token: 0x02000390 RID: 912
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04001259 RID: 4697
			public const int TxtTips = 0;

			// Token: 0x0400125A RID: 4698
			public const int TexIcon = 1;
		}
	}
}
