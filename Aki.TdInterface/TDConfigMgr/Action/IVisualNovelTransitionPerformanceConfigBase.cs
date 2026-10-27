using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020AB RID: 8363
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelTransitionPerformanceConfigBase
	{
		// Token: 0x0600B7F0 RID: 47088 RVA: 0x001A9FC4 File Offset: 0x001A81C4
		private IVisualNovelTransitionPerformanceConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelTransitionPerformanceConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelTransitionPerformanceConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelTransitionPerformanceConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x001A9FFC File Offset: 0x001A81FC
		public static IVisualNovelTransitionPerformanceConfigBase Create([Nullable(2)] IVisualNovelTransitionPerformanceConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionPerformanceConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B7F2 RID: 47090 RVA: 0x001AA00F File Offset: 0x001A820F
		public static IVisualNovelTransitionPerformanceConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelTransitionPerformanceConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelTransitionPerformanceConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x001AA022 File Offset: 0x001A8222
		public IVisualNovelTransitionPerformanceConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionPerformanceConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600B7F4 RID: 47092 RVA: 0x001AA035 File Offset: 0x001A8235
		// (set) Token: 0x0600B7F5 RID: 47093 RVA: 0x001AA060 File Offset: 0x001A8260
		public virtual EVisualNovelSubType Type
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

		// Token: 0x04006E57 RID: 28247
		[Nullable(2)]
		protected IVisualNovelTransitionPerformanceConfigBase FbInstance;

		// Token: 0x04006E58 RID: 28248
		[Nullable(2)]
		protected IVisualNovelTransitionPerformanceConfigBase_SetValue PocoInterface;
	}
}
