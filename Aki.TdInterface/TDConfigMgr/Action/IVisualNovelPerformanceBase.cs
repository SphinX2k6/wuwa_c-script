using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200207D RID: 8317
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelPerformanceBase
	{
		// Token: 0x0600B6B0 RID: 46768 RVA: 0x001A76E8 File Offset: 0x001A58E8
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

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x001A7720 File Offset: 0x001A5920
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

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x001A7733 File Offset: 0x001A5933
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

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x001A7746 File Offset: 0x001A5946
		public IVisualNovelPerformanceBase_SetValue ToSetValue()
		{
			return new IVisualNovelPerformanceBase_SetValue
			{
				Type = this.Type,
				StartTime = this.StartTime
			};
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0600B6B4 RID: 46772 RVA: 0x001A7765 File Offset: 0x001A5965
		// (set) Token: 0x0600B6B5 RID: 46773 RVA: 0x001A7790 File Offset: 0x001A5990
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

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600B6B6 RID: 46774 RVA: 0x001A77A0 File Offset: 0x001A59A0
		// (set) Token: 0x0600B6B7 RID: 46775 RVA: 0x001A77DA File Offset: 0x001A59DA
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

		// Token: 0x04006DB6 RID: 28086
		[Nullable(2)]
		protected IVisualNovelPerformanceBase FbInstance;

		// Token: 0x04006DB7 RID: 28087
		[Nullable(2)]
		protected IVisualNovelPerformanceBase_SetValue PocoInterface;
	}
}
