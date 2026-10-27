using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002099 RID: 8345
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceTransition : IVisualNovelPerformanceBase
	{
		// Token: 0x0600B784 RID: 46980 RVA: 0x001A9350 File Offset: 0x001A7550
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

		// Token: 0x0600B785 RID: 46981 RVA: 0x001A9388 File Offset: 0x001A7588
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

		// Token: 0x0600B786 RID: 46982 RVA: 0x001A939B File Offset: 0x001A759B
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

		// Token: 0x0600B787 RID: 46983 RVA: 0x001A93AE File Offset: 0x001A75AE
		public new IVisualNovelPerformanceTransition_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceTransition_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime,
				TransitionPerformanceConfig = this.TransitionPerformanceConfig
			};
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600B788 RID: 46984 RVA: 0x001A93D9 File Offset: 0x001A75D9
		// (set) Token: 0x0600B789 RID: 46985 RVA: 0x001A9404 File Offset: 0x001A7604
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

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600B78A RID: 46986 RVA: 0x001A9414 File Offset: 0x001A7614
		// (set) Token: 0x0600B78B RID: 46987 RVA: 0x001A944E File Offset: 0x001A764E
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

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600B78C RID: 46988 RVA: 0x001A945C File Offset: 0x001A765C
		// (set) Token: 0x0600B78D RID: 46989 RVA: 0x001A94BD File Offset: 0x001A76BD
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

		// Token: 0x04006E28 RID: 28200
		[Nullable(2)]
		protected new IVisualNovelPerformanceTransition FbInstance;

		// Token: 0x04006E29 RID: 28201
		[Nullable(2)]
		protected new IVisualNovelPerformanceTransition_SetValue PocoInterface;

		// Token: 0x04006E2A RID: 28202
		private IVisualNovelTransitionPerformanceSolarSchool _TransitionPerformanceConfigCache;

		// Token: 0x04006E2B RID: 28203
		private bool _TransitionPerformanceConfigInited;
	}
}
