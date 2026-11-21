using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002302 RID: 8962
	public class IVisualNovelTransitionPerformanceSolarSchool : IVisualNovelTransitionPerformanceConfigBase
	{
		// Token: 0x0600C350 RID: 50000 RVA: 0x001C0CC8 File Offset: 0x001BEEC8
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

		// Token: 0x0600C351 RID: 50001 RVA: 0x001C0D00 File Offset: 0x001BEF00
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

		// Token: 0x0600C352 RID: 50002 RVA: 0x001C0D13 File Offset: 0x001BEF13
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

		// Token: 0x0600C353 RID: 50003 RVA: 0x001C0D26 File Offset: 0x001BEF26
		public new IVisualNovelTransitionPerformanceSolarSchool_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionPerformanceSolarSchool_SetValue
			{
				Type = this.Type,
				TransitionConfig = this.TransitionConfig
			};
		}

		// Token: 0x17003B35 RID: 15157
		// (get) Token: 0x0600C354 RID: 50004 RVA: 0x001C0D45 File Offset: 0x001BEF45
		// (set) Token: 0x0600C355 RID: 50005 RVA: 0x001C0D70 File Offset: 0x001BEF70
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

		// Token: 0x17003B36 RID: 15158
		// (get) Token: 0x0600C356 RID: 50006 RVA: 0x001C0D7E File Offset: 0x001BEF7E
		// (set) Token: 0x0600C357 RID: 50007 RVA: 0x001C0DA5 File Offset: 0x001BEFA5
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

		// Token: 0x04007478 RID: 29816
		[Nullable(2)]
		protected new IVisualNovelTransitionPerformanceSolarSchool FbInstance;

		// Token: 0x04007479 RID: 29817
		[Nullable(2)]
		protected new IVisualNovelTransitionPerformanceSolarSchool_SetValue PocoInterface;
	}
}
