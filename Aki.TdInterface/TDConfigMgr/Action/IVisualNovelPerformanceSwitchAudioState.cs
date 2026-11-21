using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E2 RID: 8930
	public class IVisualNovelPerformanceSwitchAudioState : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C2A8 RID: 49832 RVA: 0x001BFA6C File Offset: 0x001BDC6C
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

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x001BFAA4 File Offset: 0x001BDCA4
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

		// Token: 0x0600C2AA RID: 49834 RVA: 0x001BFAB7 File Offset: 0x001BDCB7
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

		// Token: 0x0600C2AB RID: 49835 RVA: 0x001BFACA File Offset: 0x001BDCCA
		public new IVisualNovelPerformanceSwitchAudioState_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceSwitchAudioState_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				AudioState = this.AudioState
			};
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0600C2AC RID: 49836 RVA: 0x001BFAF5 File Offset: 0x001BDCF5
		// (set) Token: 0x0600C2AD RID: 49837 RVA: 0x001BFB20 File Offset: 0x001BDD20
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

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x0600C2AE RID: 49838 RVA: 0x001BFB30 File Offset: 0x001BDD30
		// (set) Token: 0x0600C2AF RID: 49839 RVA: 0x001BFB6A File Offset: 0x001BDD6A
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

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x0600C2B0 RID: 49840 RVA: 0x001BFB78 File Offset: 0x001BDD78
		// (set) Token: 0x0600C2B1 RID: 49841 RVA: 0x001BFBD9 File Offset: 0x001BDDD9
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

		// Token: 0x04007430 RID: 29744
		[Nullable(2)]
		protected new IVisualNovelPerformanceSwitchAudioState FbInstance;

		// Token: 0x04007431 RID: 29745
		[Nullable(2)]
		protected new IVisualNovelPerformanceSwitchAudioState_SetValue PocoInterface;

		// Token: 0x04007432 RID: 29746
		private IAudioState _AudioStateCache;

		// Token: 0x04007433 RID: 29747
		private bool _AudioStateInited;
	}
}
