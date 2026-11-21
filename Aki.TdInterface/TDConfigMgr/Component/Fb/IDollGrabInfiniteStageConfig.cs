using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000EF2 RID: 3826
	[NullableContext(2)]
	[Nullable(0)]
	public class IDollGrabInfiniteStageConfig
	{
		// Token: 0x0600561B RID: 22043 RVA: 0x000D35D9 File Offset: 0x000D17D9
		[NullableContext(0)]
		public static IDollGrabInfiniteStageConfig Create(IDollGrabInfiniteStageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabInfiniteStageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x0600561C RID: 22044 RVA: 0x000D35F8 File Offset: 0x000D17F8
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x0600561D RID: 22045 RVA: 0x000D3605 File Offset: 0x000D1805
		public virtual IDollGrabStageAudioState AudioState
		{
			get
			{
				if (this._AudioStateInited)
				{
					return this._AudioStateCache;
				}
				this._AudioStateInited = true;
				this._AudioStateCache = IDollGrabStageAudioState.Create(this.Instance.AudioState);
				return this._AudioStateCache;
			}
		}

		// Token: 0x0400314F RID: 12623
		private IDollGrabInfiniteStageConfig Instance;

		// Token: 0x04003150 RID: 12624
		private IDollGrabStageAudioState _AudioStateCache;

		// Token: 0x04003151 RID: 12625
		private bool _AudioStateInited;
	}
}
