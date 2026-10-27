using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002097 RID: 8343
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceSwitchAudioState : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B778 RID: 46968 RVA: 0x001A91BC File Offset: 0x001A73BC
		private IVisualNovelPerformanceSwitchAudioState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceSwitchAudioState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceSwitchAudioState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceSwitchAudioState_SetValue());
			}
			return result;
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x001A91F4 File Offset: 0x001A73F4
		public static IVisualNovelPerformanceSwitchAudioState Create([Nullable(2)] IVisualNovelPerformanceSwitchAudioState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceSwitchAudioState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x001A9207 File Offset: 0x001A7407
		public static IVisualNovelPerformanceSwitchAudioState CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceSwitchAudioState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceSwitchAudioState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x001A921A File Offset: 0x001A741A
		public new IVisualNovelPerformanceSwitchAudioState_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceSwitchAudioState_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				AudioState = this.AudioState
			};
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600B77C RID: 46972 RVA: 0x001A9245 File Offset: 0x001A7445
		// (set) Token: 0x0600B77D RID: 46973 RVA: 0x001A9270 File Offset: 0x001A7470
		public override EVisualNovelPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelPerformanceType.Enter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600B77E RID: 46974 RVA: 0x001A9280 File Offset: 0x001A7480
		// (set) Token: 0x0600B77F RID: 46975 RVA: 0x001A92BA File Offset: 0x001A74BA
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceSwitchAudioState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartTime;
			}
			set
			{
				this.GetOrCreatePoco().StartTime = value;
			}
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600B780 RID: 46976 RVA: 0x001A92C8 File Offset: 0x001A74C8
		// (set) Token: 0x0600B781 RID: 46977 RVA: 0x001A9329 File Offset: 0x001A7529
		public virtual IAudioState AudioState
		{
			get
			{
				if (this._AudioStateInited)
				{
					return this._AudioStateCache;
				}
				this._AudioStateInited = true;
				if (this.FbInstance != null)
				{
					this._AudioStateCache = IAudioState.Create(this.FbInstance.AudioState);
				}
				else
				{
					IVisualNovelPerformanceSwitchAudioState_SetValue pocoInterface = this.PocoInterface;
					this._AudioStateCache = ((pocoInterface != null) ? pocoInterface.AudioState : null);
				}
				return this._AudioStateCache;
			}
			set
			{
				this.GetOrCreatePoco().AudioState = value;
				this._AudioStateInited = false;
			}
		}

		// Token: 0x04006E21 RID: 28193
		[Nullable(2)]
		protected new IVisualNovelPerformanceSwitchAudioState FbInstance;

		// Token: 0x04006E22 RID: 28194
		[Nullable(2)]
		protected new IVisualNovelPerformanceSwitchAudioState_SetValue PocoInterface;

		// Token: 0x04006E23 RID: 28195
		private IAudioState _AudioStateCache;

		// Token: 0x04006E24 RID: 28196
		private bool _AudioStateInited;
	}
}
