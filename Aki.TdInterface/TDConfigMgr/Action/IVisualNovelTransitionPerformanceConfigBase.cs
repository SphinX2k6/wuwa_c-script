using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002300 RID: 8960
	public class IVisualNovelTransitionPerformanceConfigBase
	{
		// Token: 0x0600C348 RID: 49992 RVA: 0x001C0C0C File Offset: 0x001BEE0C
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

		// Token: 0x0600C349 RID: 49993 RVA: 0x001C0C44 File Offset: 0x001BEE44
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

		// Token: 0x0600C34A RID: 49994 RVA: 0x001C0C57 File Offset: 0x001BEE57
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

		// Token: 0x0600C34B RID: 49995 RVA: 0x001C0C6A File Offset: 0x001BEE6A
		public IVisualNovelTransitionPerformanceConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelTransitionPerformanceConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003B34 RID: 15156
		// (get) Token: 0x0600C34C RID: 49996 RVA: 0x001C0C7D File Offset: 0x001BEE7D
		// (set) Token: 0x0600C34D RID: 49997 RVA: 0x001C0CA8 File Offset: 0x001BEEA8
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

		// Token: 0x04007475 RID: 29813
		[Nullable(2)]
		protected IVisualNovelTransitionPerformanceConfigBase FbInstance;

		// Token: 0x04007476 RID: 29814
		[Nullable(2)]
		protected IVisualNovelTransitionPerformanceConfigBase_SetValue PocoInterface;
	}
}
