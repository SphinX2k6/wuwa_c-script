using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C8 RID: 8904
	public class IVisualNovelPerformanceBase
	{
		// Token: 0x0600C1E0 RID: 49632 RVA: 0x001BDF60 File Offset: 0x001BC160
		private IVisualNovelPerformanceBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelPerformanceBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelPerformanceBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelPerformanceBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C1E1 RID: 49633 RVA: 0x001BDF98 File Offset: 0x001BC198
		public static IVisualNovelPerformanceBase Create([Nullable(2)] IVisualNovelPerformanceBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C1E2 RID: 49634 RVA: 0x001BDFAB File Offset: 0x001BC1AB
		public static IVisualNovelPerformanceBase CreateFromSetValue([Nullable(2)] IVisualNovelPerformanceBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelPerformanceBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x001BDFBE File Offset: 0x001BC1BE
		public IVisualNovelPerformanceBase_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceBase_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime
			};
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x0600C1E4 RID: 49636 RVA: 0x001BDFDD File Offset: 0x001BC1DD
		// (set) Token: 0x0600C1E5 RID: 49637 RVA: 0x001BE008 File Offset: 0x001BC208
		public virtual EVisualNovelPerformanceType Type
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

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x0600C1E6 RID: 49638 RVA: 0x001BE018 File Offset: 0x001BC218
		// (set) Token: 0x0600C1E7 RID: 49639 RVA: 0x001BE052 File Offset: 0x001BC252
		public virtual float? StartTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartTime;
				}
				IVisualNovelPerformanceBase_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040073C3 RID: 29635
		[Nullable(2)]
		protected IVisualNovelPerformanceBase FbInstance;

		// Token: 0x040073C4 RID: 29636
		[Nullable(2)]
		protected IVisualNovelPerformanceBase_SetValue PocoInterface;
	}
}
