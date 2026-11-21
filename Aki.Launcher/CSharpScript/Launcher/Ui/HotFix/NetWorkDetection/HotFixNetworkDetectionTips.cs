using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000FD RID: 253
	[NullableContext(1)]
	[Nullable(0)]
	public class HotFixNetworkDetectionTips : LaunchComponentsAction
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x0003F866 File Offset: 0x0003DA66
		public void InitTickManager(UObject worldContext, string tickName)
		{
			this.TickManager = new UKuroTickManager(worldContext, tickName, EObjectFlags.RF_NoFlags);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0003F876 File Offset: 0x0003DA76
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

		// Token: 0x0600085E RID: 2142 RVA: 0x0003F896 File Offset: 0x0003DA96
		protected override void OnBeforeDestroy()
		{
			if (this.TickManager != null)
			{
				this.RemoveTickDelegate();
				this.TickManager = null;
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0003F8AD File Offset: 0x0003DAAD
		public void SetTextureIconActive(bool active)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(active);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0003F8C1 File Offset: 0x0003DAC1
		public void SetTipsText(string text)
		{
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(text, true);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0003F8D6 File Offset: 0x0003DAD6
		public void SetTipsLocalText(string textKey)
		{
			HotFixManager.SetLocalText(base.GetText(0), textKey, Array.Empty<string>());
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0003F8EC File Offset: 0x0003DAEC
		public void ShowTip(string textKey)
		{
			this.SetTipsLocalText(textKey);
			base.SetActive(true);
			this.SetTextureIconActive(false);
			this.RemoveTickDelegate();
			this.TickDelegate = new Action<float>(this.TickCallback);
			this.TickManager.AddTick(ETickingGroup.TG_PrePhysics, DelegateUtils.ToManualReleaseDelegate<FTickHandler>(this.TickDelegate), 0);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0003F93F File Offset: 0x0003DB3F
		private void TickCallback(float delta)
		{
			this.TickTimeSinceStartup += (double)delta;
			if (this.TickTimeSinceStartup > 1.2)
			{
				base.SetActive(false);
				this.RemoveTickDelegate();
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0003F96E File Offset: 0x0003DB6E
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

		// Token: 0x040004E2 RID: 1250
		[Nullable(2)]
		private UKuroTickManager TickManager;

		// Token: 0x040004E3 RID: 1251
		[Nullable(2)]
		private Action<float> TickDelegate;

		// Token: 0x040004E4 RID: 1252
		private double TickTimeSinceStartup;

		// Token: 0x0200039D RID: 925
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040012CF RID: 4815
			public const int TxtTips = 0;

			// Token: 0x040012D0 RID: 4816
			public const int TexIcon = 1;
		}
	}
}
