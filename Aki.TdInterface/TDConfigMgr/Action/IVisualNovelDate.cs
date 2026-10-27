using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002069 RID: 8297
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelDate
	{
		// Token: 0x0600B648 RID: 46664 RVA: 0x001A6B54 File Offset: 0x001A4D54
		private IVisualNovelDate_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelDate 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelDate_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelDate_SetValue());
			}
			return result;
		}

		// Token: 0x0600B649 RID: 46665 RVA: 0x001A6B8C File Offset: 0x001A4D8C
		public static IVisualNovelDate Create([Nullable(2)] IVisualNovelDate instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelDate
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B64A RID: 46666 RVA: 0x001A6B9F File Offset: 0x001A4D9F
		public static IVisualNovelDate CreateFromSetValue([Nullable(2)] IVisualNovelDate_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelDate
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B64B RID: 46667 RVA: 0x001A6BB2 File Offset: 0x001A4DB2
		public IVisualNovelDate_SetValue ToSetValue()
		{
			return new IVisualNovelDate_SetValue
			{
				Month = this.Month,
				Day = this.Day
			};
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600B64C RID: 46668 RVA: 0x001A6BD1 File Offset: 0x001A4DD1
		// (set) Token: 0x0600B64D RID: 46669 RVA: 0x001A6BFC File Offset: 0x001A4DFC
		public virtual int Month
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Month;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Month;
			}
			set
			{
				this.GetOrCreatePoco().Month = value;
			}
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0600B64E RID: 46670 RVA: 0x001A6C0A File Offset: 0x001A4E0A
		// (set) Token: 0x0600B64F RID: 46671 RVA: 0x001A6C35 File Offset: 0x001A4E35
		public virtual int Day
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Day;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Day;
			}
			set
			{
				this.GetOrCreatePoco().Day = value;
			}
		}

		// Token: 0x04006D86 RID: 28038
		[Nullable(2)]
		protected IVisualNovelDate FbInstance;

		// Token: 0x04006D87 RID: 28039
		[Nullable(2)]
		protected IVisualNovelDate_SetValue PocoInterface;
	}
}
