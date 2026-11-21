using System;
using CSharpScript.Game.World.StepSequence;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.DataLayerSwitch
{
	// Token: 0x02004AB1 RID: 19121
	public class DataLayerSwitchAbortSignal : ISequenceAbortSignal
	{
		// Token: 0x17005FFF RID: 24575
		// (get) Token: 0x0602FD7A RID: 195962 RVA: 0x00D5A5C5 File Offset: 0x00D587C5
		public bool Aborted
		{
			get
			{
				GameModeModel instance = GameModeModel.Instance;
				return instance != null && instance.SwitchDataLayerContext.DataLayerSwitchAborted;
			}
		}

		// Token: 0x17006000 RID: 24576
		// (get) Token: 0x0602FD7B RID: 195963 RVA: 0x00D5A5DC File Offset: 0x00D587DC
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

		// Token: 0x0602FD7C RID: 195964 RVA: 0x00D5A620 File Offset: 0x00D58820
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
