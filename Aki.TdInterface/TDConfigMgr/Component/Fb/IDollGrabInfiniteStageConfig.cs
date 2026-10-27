using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF6 RID: 3574
	[NullableContext(2)]
	[Nullable(0)]
	public class IDollGrabInfiniteStageConfig
	{
		// Token: 0x060050F4 RID: 20724 RVA: 0x000C7D11 File Offset: 0x000C5F11
		[NullableContext(1)]
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

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x060050F5 RID: 20725 RVA: 0x000C7D30 File Offset: 0x000C5F30
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x060050F6 RID: 20726 RVA: 0x000C7D3D File Offset: 0x000C5F3D
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

		// Token: 0x04002E87 RID: 11911
		private IDollGrabInfiniteStageConfig Instance;

		// Token: 0x04002E88 RID: 11912
		private IDollGrabStageAudioState _AudioStateCache;

		// Token: 0x04002E89 RID: 11913
		private bool _AudioStateInited;
	}
}
