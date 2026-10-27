using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020AD RID: 8365
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelTransitionPerformanceSolarSchool : IVisualNovelTransitionPerformanceConfigBase
	{
		// Token: 0x0600B7F8 RID: 47096 RVA: 0x001AA080 File Offset: 0x001A8280
		private IVisualNovelTransitionPerformanceSolarSchool_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelTransitionPerformanceSolarSchool 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelTransitionPerformanceSolarSchool_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelTransitionPerformanceSolarSchool_SetValue());
			}
			return result;
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x001AA0B8 File Offset: 0x001A82B8
		public static IVisualNovelTransitionPerformanceSolarSchool Create([Nullable(2)] IVisualNovelTransitionPerformanceSolarSchool instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionPerformanceSolarSchool
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x001AA0CB File Offset: 0x001A82CB
		public static IVisualNovelTransitionPerformanceSolarSchool CreateFromSetValue([Nullable(2)] IVisualNovelTransitionPerformanceSolarSchool_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelTransitionPerformanceSolarSchool
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x001AA0DE File Offset: 0x001A82DE
		public new IVisualNovelTransitionPerformanceSolarSchool_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionPerformanceSolarSchool_SetValue
			{
				Type = this.Type,
				TransitionConfig = this.TransitionConfig
			};
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600B7FC RID: 47100 RVA: 0x001AA0FD File Offset: 0x001A82FD
		// (set) Token: 0x0600B7FD RID: 47101 RVA: 0x001AA128 File Offset: 0x001A8328
		public override EVisualNovelSubType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600B7FE RID: 47102 RVA: 0x001AA136 File Offset: 0x001A8336
		// (set) Token: 0x0600B7FF RID: 47103 RVA: 0x001AA15D File Offset: 0x001A835D
		public virtual IVisualNovelTransitionConfigBase TransitionConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionConfig;
				}
				IVisualNovelTransitionPerformanceSolarSchool_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionConfig;
			}
			set
			{
				this.GetOrCreatePoco().TransitionConfig = value;
			}
		}

		// Token: 0x04006E5A RID: 28250
		[Nullable(2)]
		protected new IVisualNovelTransitionPerformanceSolarSchool FbInstance;

		// Token: 0x04006E5B RID: 28251
		[Nullable(2)]
		protected new IVisualNovelTransitionPerformanceSolarSchool_SetValue PocoInterface;
	}
}
