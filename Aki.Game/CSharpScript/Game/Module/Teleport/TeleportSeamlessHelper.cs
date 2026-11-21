using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Teleport
{
	// Token: 0x02003B1B RID: 15131
	public class TeleportSeamlessHelper : TeleportContextHolder
	{
		// Token: 0x06026E13 RID: 159251 RVA: 0x00AE1021 File Offset: 0x00ADF221
		[NullableContext(1)]
		public TeleportSeamlessHelper(TeleportContext context) : base(context)
		{
		}

		// Token: 0x06026E14 RID: 159252 RVA: 0x00AE102C File Offset: 0x00ADF22C
		public UniTask SeamlessTeleportPreStart()
		{
			TeleportSeamlessHelper.<SeamlessTeleportPreStart>d__1 <SeamlessTeleportPreStart>d__;
			<SeamlessTeleportPreStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SeamlessTeleportPreStart>d__.<>4__this = this;
			<SeamlessTeleportPreStart>d__.<>1__state = -1;
			<SeamlessTeleportPreStart>d__.<>t__builder.Start<TeleportSeamlessHelper.<SeamlessTeleportPreStart>d__1>(ref <SeamlessTeleportPreStart>d__);
			return <SeamlessTeleportPreStart>d__.<>t__builder.Task;
		}

		// Token: 0x06026E15 RID: 159253 RVA: 0x00AE1070 File Offset: 0x00ADF270
		public UniTask SeamlessTeleportStart()
		{
			TeleportSeamlessHelper.<SeamlessTeleportStart>d__2 <SeamlessTeleportStart>d__;
			<SeamlessTeleportStart>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SeamlessTeleportStart>d__.<>4__this = this;
			<SeamlessTeleportStart>d__.<>1__state = -1;
			<SeamlessTeleportStart>d__.<>t__builder.Start<TeleportSeamlessHelper.<SeamlessTeleportStart>d__2>(ref <SeamlessTeleportStart>d__);
			return <SeamlessTeleportStart>d__.<>t__builder.Task;
		}

		// Token: 0x06026E16 RID: 159254 RVA: 0x00AE10B4 File Offset: 0x00ADF2B4
		public UniTask SeamlessTeleportPreEnd()
		{
			TeleportSeamlessHelper.<SeamlessTeleportPreEnd>d__3 <SeamlessTeleportPreEnd>d__;
			<SeamlessTeleportPreEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SeamlessTeleportPreEnd>d__.<>4__this = this;
			<SeamlessTeleportPreEnd>d__.<>1__state = -1;
			<SeamlessTeleportPreEnd>d__.<>t__builder.Start<TeleportSeamlessHelper.<SeamlessTeleportPreEnd>d__3>(ref <SeamlessTeleportPreEnd>d__);
			return <SeamlessTeleportPreEnd>d__.<>t__builder.Task;
		}

		// Token: 0x06026E17 RID: 159255 RVA: 0x00AE10F8 File Offset: 0x00ADF2F8
		public UniTask SeamlessTeleportEnd()
		{
			TeleportSeamlessHelper.<SeamlessTeleportEnd>d__4 <SeamlessTeleportEnd>d__;
			<SeamlessTeleportEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SeamlessTeleportEnd>d__.<>4__this = this;
			<SeamlessTeleportEnd>d__.<>1__state = -1;
			<SeamlessTeleportEnd>d__.<>t__builder.Start<TeleportSeamlessHelper.<SeamlessTeleportEnd>d__4>(ref <SeamlessTeleportEnd>d__);
			return <SeamlessTeleportEnd>d__.<>t__builder.Task;
		}

		// Token: 0x06026E18 RID: 159256 RVA: 0x00AE113C File Offset: 0x00ADF33C
		public void FinishSeamlessTeleport()
		{
			EventSystem.Instance.Emit(EEventName.SeamlessTravelFinishBeforeShowUI);
			BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.Seamless, 0);
			InputDistributeController.Instance.RefreshInputTag();
			if (!this.TeleportContext.IsInSeamlessTeleport)
			{
				return;
			}
			SeamlessTravelTreadmill treadmill = this.TeleportContext.Treadmill;
			if (treadmill != null)
			{
				treadmill.Destroy();
			}
			this.TeleportContext.Treadmill = null;
			SeamlessTravelPostProcess postProcess = this.TeleportContext.PostProcess;
			if (postProcess != null)
			{
				postProcess.Destroy();
			}
			this.TeleportContext.PostProcess = null;
			SeamlessTravelScreenEffect screenEffect = this.TeleportContext.ScreenEffect;
			if (screenEffect != null)
			{
				screenEffect.Destroy();
			}
			this.TeleportContext.ScreenEffect = null;
			SeamlessTravelSceneEffect sceneEffect = this.TeleportContext.SceneEffect;
			if (sceneEffect != null)
			{
				sceneEffect.Destroy();
			}
			this.TeleportContext.SceneEffect = null;
			SeamlessTravelKeepKite keepKite = this.TeleportContext.KeepKite;
			if (keepKite != null)
			{
				keepKite.Destroy();
			}
			this.TeleportContext.KeepKite = null;
			SeamlessTravelKeepMovementMode keepMovementMode = this.TeleportContext.KeepMovementMode;
			if (keepMovementMode != null)
			{
				keepMovementMode.Destroy();
			}
			this.TeleportContext.KeepMovementMode = null;
			this.TeleportContext.UseTreadmill = false;
			this.TeleportContext.UseKeepKite = false;
			this.TeleportContext.UseKeepMovementMode = false;
			this.TeleportContext.SeamlessEndHandle = null;
			this.TeleportContext.IsInSeamlessTeleport = false;
			this.TeleportContext.SeamlessConfig = null;
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x06026E19 RID: 159257 RVA: 0x00AE12A0 File Offset: 0x00ADF4A0
		[CompilerGenerated]
		private void <SeamlessTeleportStart>g__delayLeastTime|2_0()
		{
			float num = this.TeleportContext.SeamlessConfig.LeastTime * 1000f;
			if (num >= 20f)
			{
				TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
				{
					GameModePromise leastTimeFinished2 = this.TeleportContext.LeastTimeFinished;
					if (leastTimeFinished2 == null)
					{
						return;
					}
					leastTimeFinished2.SetResult(true);
				}, num, null, null, true, 1f);
				return;
			}
			GameModePromise leastTimeFinished = this.TeleportContext.LeastTimeFinished;
			if (leastTimeFinished == null)
			{
				return;
			}
			leastTimeFinished.SetResult(true);
		}
	}
}
