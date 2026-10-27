using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C3 RID: 707
	[NullableContext(1)]
	[Nullable(0)]
	public class IDollGrabInfiniteStageConfig
	{
		// Token: 0x06000D4F RID: 3407 RVA: 0x00031E3C File Offset: 0x0003003C
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

		// Token: 0x06000D50 RID: 3408 RVA: 0x00031E74 File Offset: 0x00030074
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

		// Token: 0x06000D51 RID: 3409 RVA: 0x00031E87 File Offset: 0x00030087
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

		// Token: 0x06000D52 RID: 3410 RVA: 0x00031E9A File Offset: 0x0003009A
		public IDollGrabInfiniteStageConfig_SetValue ToSetValue()
		{
			return new IDollGrabInfiniteStageConfig_SetValue
			{
				Duration = this.Duration,
				AudioState = this.AudioState
			};
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00031EB9 File Offset: 0x000300B9
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00031EE8 File Offset: 0x000300E8
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

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00031EF8 File Offset: 0x000300F8
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00031F59 File Offset: 0x00030159
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

		// Token: 0x04000C1D RID: 3101
		[Nullable(2)]
		protected IDollGrabInfiniteStageConfig FbInstance;

		// Token: 0x04000C1E RID: 3102
		[Nullable(2)]
		protected IDollGrabInfiniteStageConfig_SetValue PocoInterface;

		// Token: 0x04000C1F RID: 3103
		private IDollGrabStageAudioState _AudioStateCache;

		// Token: 0x04000C20 RID: 3104
		private bool _AudioStateInited;
	}
}
