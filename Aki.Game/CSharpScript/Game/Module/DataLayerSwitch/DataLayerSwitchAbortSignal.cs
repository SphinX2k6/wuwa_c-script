using System;
using CSharpScript.Game.World.StepSequence;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.DataLayerSwitch
{
	// Token: 0x02005AD0 RID: 23248
	public class DataLayerSwitchAbortSignal : ISequenceAbortSignal
	{
		// Token: 0x17008C25 RID: 35877
		// (get) Token: 0x0603AE08 RID: 241160 RVA: 0x00E098E5 File Offset: 0x00E07AE5
		public bool Aborted
		{
			get
			{
				GameModeModel instance = GameModeModel.Instance;
				return instance != null && instance.SwitchDataLayerContext.DataLayerSwitchAborted;
			}
		}

		// Token: 0x17008C26 RID: 35878
		// (get) Token: 0x0603AE09 RID: 241161 RVA: 0x00E098FC File Offset: 0x00E07AFC
		public UniTask<bool>? Promise
		{
			get
			{
				GameModeModel instance = GameModeModel.Instance;
				if (instance == null)
				{
					return null;
				}
				CustomPromise<bool> dataLayerSwitchAbortPromise = instance.SwitchDataLayerContext.DataLayerSwitchAbortPromise;
				if (dataLayerSwitchAbortPromise == null)
				{
					return null;
				}
				return new UniTask<bool>?(dataLayerSwitchAbortPromise.Promise);
			}
		}

		// Token: 0x0603AE0A RID: 241162 RVA: 0x00E09940 File Offset: 0x00E07B40
		public void Abort()
		{
			Log.Instance.Info(ELogModule.World, ELogAuthor.ZYL, "DataLayerSwitchAbortSignal:Abort", default(ReadOnlySpan<ValueTuple<string, object>>));
			GameModeModel instance = GameModeModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SwitchDataLayerContext.AbortDataLayerSwitch();
		}
	}
}
