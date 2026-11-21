using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200030A RID: 778
	public class IDollGrabInfiniteStageConfig
	{
		// Token: 0x06000E7F RID: 3711 RVA: 0x00034D70 File Offset: 0x00032F70
		private IDollGrabInfiniteStageConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabInfiniteStageConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabInfiniteStageConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabInfiniteStageConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00034DA8 File Offset: 0x00032FA8
		public static IDollGrabInfiniteStageConfig Create([Nullable(2)] IDollGrabInfiniteStageConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabInfiniteStageConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00034DBB File Offset: 0x00032FBB
		public static IDollGrabInfiniteStageConfig CreateFromSetValue([Nullable(2)] IDollGrabInfiniteStageConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabInfiniteStageConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00034DCE File Offset: 0x00032FCE
		public IDollGrabInfiniteStageConfig_SetValue ToSetValue()
		{
			return new IDollGrabInfiniteStageConfig_SetValue
			{
				Duration = this.Duration,
				AudioState = this.AudioState
			};
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00034DED File Offset: 0x00032FED
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00034E1C File Offset: 0x0003301C
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x00034E2C File Offset: 0x0003302C
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x00034E8D File Offset: 0x0003308D
		[Nullable(2)]
		public virtual IDollGrabStageAudioState AudioState
		{
			[NullableContext(2)]
			get
			{
				if (this._AudioStateInited)
				{
					return this._AudioStateCache;
				}
				this._AudioStateInited = true;
				if (this.FbInstance != null)
				{
					this._AudioStateCache = IDollGrabStageAudioState.Create(this.FbInstance.AudioState);
				}
				else
				{
					IDollGrabInfiniteStageConfig_SetValue pocoInterface = this.PocoInterface;
					this._AudioStateCache = ((pocoInterface != null) ? pocoInterface.AudioState : null);
				}
				return this._AudioStateCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AudioState = value;
				this._AudioStateInited = false;
			}
		}

		// Token: 0x04000D07 RID: 3335
		[Nullable(2)]
		protected IDollGrabInfiniteStageConfig FbInstance;

		// Token: 0x04000D08 RID: 3336
		[Nullable(2)]
		protected IDollGrabInfiniteStageConfig_SetValue PocoInterface;

		// Token: 0x04000D09 RID: 3337
		private IDollGrabStageAudioState _AudioStateCache;

		// Token: 0x04000D0A RID: 3338
		private bool _AudioStateInited;
	}
}
