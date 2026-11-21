using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022E4 RID: 8932
	public class IVisualNovelPerformanceTransition : IVisualNovelPerformanceBase
	{
		// Token: 0x0600C2B4 RID: 49844 RVA: 0x001BFC00 File Offset: 0x001BDE00
		private IVisualNovelPerformanceTransition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceTransition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceTransition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceTransition_SetValue());
			}
			return result;
		}

		// Token: 0x0600C2B5 RID: 49845 RVA: 0x001BFC38 File Offset: 0x001BDE38
		public static IVisualNovelPerformanceTransition Create([Nullable(2)] IVisualNovelPerformanceTransition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceTransition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C2B6 RID: 49846 RVA: 0x001BFC4B File Offset: 0x001BDE4B
		public static IVisualNovelPerformanceTransition CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceTransition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceTransition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C2B7 RID: 49847 RVA: 0x001BFC5E File Offset: 0x001BDE5E
		public new IVisualNovelPerformanceTransition_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceTransition_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				TransitionPerformanceConfig = this.TransitionPerformanceConfig
			};
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0600C2B8 RID: 49848 RVA: 0x001BFC89 File Offset: 0x001BDE89
		// (set) Token: 0x0600C2B9 RID: 49849 RVA: 0x001BFCB4 File Offset: 0x001BDEB4
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

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0600C2BA RID: 49850 RVA: 0x001BFCC4 File Offset: 0x001BDEC4
		// (set) Token: 0x0600C2BB RID: 49851 RVA: 0x001BFCFE File Offset: 0x001BDEFE
		public override float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceTransition_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0600C2BC RID: 49852 RVA: 0x001BFD0C File Offset: 0x001BDF0C
		// (set) Token: 0x0600C2BD RID: 49853 RVA: 0x001BFD6D File Offset: 0x001BDF6D
		public virtual IVisualNovelTransitionPerformanceSolarSchool TransitionPerformanceConfig
		{
			get
			{
				if (this._TransitionPerformanceConfigInited)
				{
					return this._TransitionPerformanceConfigCache;
				}
				this._TransitionPerformanceConfigInited = true;
				if (this.FbInstance != null)
				{
					this._TransitionPerformanceConfigCache = IVisualNovelTransitionPerformanceSolarSchool.Create(this.FbInstance.TransitionPerformanceConfig);
				}
				else
				{
					IVisualNovelPerformanceTransition_SetValue pocoInterface = this.PocoInterface;
					this._TransitionPerformanceConfigCache = ((pocoInterface != null) ? pocoInterface.TransitionPerformanceConfig : null);
				}
				return this._TransitionPerformanceConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().TransitionPerformanceConfig = value;
				this._TransitionPerformanceConfigInited = false;
			}
		}

		// Token: 0x04007437 RID: 29751
		[Nullable(2)]
		protected new IVisualNovelPerformanceTransition FbInstance;

		// Token: 0x04007438 RID: 29752
		[Nullable(2)]
		protected new IVisualNovelPerformanceTransition_SetValue PocoInterface;

		// Token: 0x04007439 RID: 29753
		private IVisualNovelTransitionPerformanceSolarSchool _TransitionPerformanceConfigCache;

		// Token: 0x0400743A RID: 29754
		private bool _TransitionPerformanceConfigInited;
	}
}
