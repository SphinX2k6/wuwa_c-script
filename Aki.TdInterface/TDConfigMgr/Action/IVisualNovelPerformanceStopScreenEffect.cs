using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E0 RID: 8928
	public class IVisualNovelPerformanceStopScreenEffect : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C29C RID: 49820 RVA: 0x001BF8D8 File Offset: 0x001BDAD8
		private IVisualNovelPerformanceStopScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceStopScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceStopScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceStopScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600C29D RID: 49821 RVA: 0x001BF910 File Offset: 0x001BDB10
		public static IVisualNovelPerformanceStopScreenEffect Create([Nullable(2)] IVisualNovelPerformanceStopScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceStopScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C29E RID: 49822 RVA: 0x001BF923 File Offset: 0x001BDB23
		public static IVisualNovelPerformanceStopScreenEffect CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceStopScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceStopScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C29F RID: 49823 RVA: 0x001BF936 File Offset: 0x001BDB36
		public new IVisualNovelPerformanceStopScreenEffect_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceStopScreenEffect_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				EffectConfig = this.EffectConfig
			};
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x0600C2A0 RID: 49824 RVA: 0x001BF961 File Offset: 0x001BDB61
		// (set) Token: 0x0600C2A1 RID: 49825 RVA: 0x001BF98C File Offset: 0x001BDB8C
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

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x0600C2A2 RID: 49826 RVA: 0x001BF99C File Offset: 0x001BDB9C
		// (set) Token: 0x0600C2A3 RID: 49827 RVA: 0x001BF9D6 File Offset: 0x001BDBD6
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceStopScreenEffect_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0600C2A4 RID: 49828 RVA: 0x001BF9E4 File Offset: 0x001BDBE4
		// (set) Token: 0x0600C2A5 RID: 49829 RVA: 0x001BFA45 File Offset: 0x001BDC45
		public virtual IVisualNovelStopScreenEffectPersistent EffectConfig
		{
			get
			{
				if (this._EffectConfigInited)
				{
					return this._EffectConfigCache;
				}
				this._EffectConfigInited = true;
				if (this.FbInstance != null)
				{
					this._EffectConfigCache = IVisualNovelStopScreenEffectPersistent.Create(this.FbInstance.EffectConfig);
				}
				else
				{
					IVisualNovelPerformanceStopScreenEffect_SetValue pocoInterface = this.PocoInterface;
					this._EffectConfigCache = ((pocoInterface != null) ? pocoInterface.EffectConfig : null);
				}
				return this._EffectConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().EffectConfig = value;
				this._EffectConfigInited = false;
			}
		}

		// Token: 0x04007429 RID: 29737
		[Nullable(2)]
		protected new IVisualNovelPerformanceStopScreenEffect FbInstance;

		// Token: 0x0400742A RID: 29738
		[Nullable(2)]
		protected new IVisualNovelPerformanceStopScreenEffect_SetValue PocoInterface;

		// Token: 0x0400742B RID: 29739
		private IVisualNovelStopScreenEffectPersistent _EffectConfigCache;

		// Token: 0x0400742C RID: 29740
		private bool _EffectConfigInited;
	}
}
