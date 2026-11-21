using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B2 RID: 8882
	public class IVisualNovelDate
	{
		// Token: 0x0600C174 RID: 49524 RVA: 0x001BD3AC File Offset: 0x001BB5AC
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

		// Token: 0x0600C175 RID: 49525 RVA: 0x001BD3E4 File Offset: 0x001BB5E4
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

		// Token: 0x0600C176 RID: 49526 RVA: 0x001BD3F7 File Offset: 0x001BB5F7
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

		// Token: 0x0600C177 RID: 49527 RVA: 0x001BD40A File Offset: 0x001BB60A
		public IVisualNovelDate_SetValue ToSetValue()
		{
			return new IVisualNovelDate_SetValue
			{
				Month = this.Month,
				Day = this.Day
			};
		}

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x0600C178 RID: 49528 RVA: 0x001BD429 File Offset: 0x001BB629
		// (set) Token: 0x0600C179 RID: 49529 RVA: 0x001BD454 File Offset: 0x001BB654
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

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x0600C17A RID: 49530 RVA: 0x001BD462 File Offset: 0x001BB662
		// (set) Token: 0x0600C17B RID: 49531 RVA: 0x001BD48D File Offset: 0x001BB68D
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

		// Token: 0x04007392 RID: 29586
		[Nullable(2)]
		protected IVisualNovelDate FbInstance;

		// Token: 0x04007393 RID: 29587
		[Nullable(2)]
		protected IVisualNovelDate_SetValue PocoInterface;
	}
}
