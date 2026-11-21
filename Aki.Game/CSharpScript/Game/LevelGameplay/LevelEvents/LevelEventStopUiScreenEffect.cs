using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D15 RID: 23829
	public class LevelEventStopUiScreenEffect : LevelEventBase
	{
		// Token: 0x0603A438 RID: 238648 RVA: 0x010778C9 File Offset: 0x01075AC9
		public LevelEventStopUiScreenEffect(int id) : base(id)
		{
		}

		// Token: 0x0603A439 RID: 238649 RVA: 0x010778D4 File Offset: 0x01075AD4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			StopUiScreenEffect stopUiScreenEffect = inParams as StopUiScreenEffect;
			if (!ResourceSystem.Instance.CheckAssetLoaded<EffectScreenPlayData_C>(stopUiScreenEffect.EffectDaPath))
			{
				base.FinishExecute(true, false, true);
				return;
			}
			ScreenEffectModel instance = ScreenEffectModel.Instance;
			if (instance != null)
			{
				instance.EndScreenEffectByPath(stopUiScreenEffect.EffectDaPath);
			}
			if (this.IsAsync)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			EffectScreenPlayData_C loadedAsset = ResourceSystem.Instance.GetLoadedAsset<EffectScreenPlayData_C>(stopUiScreenEffect.EffectDaPath);
			if (loadedAsset == null)
			{
				global::Log.Instance.Warn(ELogModule.LevelEvent, ELogAuthor.ZYL, "[LevelEventStopUiScreenEffect] 特效资源未加载, 无法获取End时间", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(true, false, true);
				return;
			}
			float num = loadedAsset.End * 1000f;
			if (num < 20f)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				base.FinishExecute(true, false, true);
			}, num, null, null, true, 1f);
		}
	}
}
