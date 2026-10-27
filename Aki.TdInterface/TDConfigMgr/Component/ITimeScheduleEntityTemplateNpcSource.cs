using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000785 RID: 1925
	[NullableContext(1)]
	[Nullable(0)]
	public class ITimeScheduleEntityTemplateNpcSource : ITimeScheduleNpcSource
	{
		// Token: 0x060029C0 RID: 10688 RVA: 0x0006E044 File Offset: 0x0006C244
		private ITimeScheduleEntityTemplateNpcSource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimeScheduleEntityTemplateNpcSource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimeScheduleEntityTemplateNpcSource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimeScheduleEntityTemplateNpcSource_SetValue());
			}
			return result;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x0006E07C File Offset: 0x0006C27C
		public static ITimeScheduleEntityTemplateNpcSource Create([Nullable(2)] ITimeScheduleEntityTemplateNpcSource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeScheduleEntityTemplateNpcSource
			{
				FbInstance = instance
			};
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x0006E08F File Offset: 0x0006C28F
		public static ITimeScheduleEntityTemplateNpcSource CreateFromSetValue([Nullable(2)] ITimeScheduleEntityTemplateNpcSource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimeScheduleEntityTemplateNpcSource
			{
				PocoInterface = value
			};
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x0006E0A2 File Offset: 0x0006C2A2
		public new ITimeScheduleEntityTemplateNpcSource_SetValue ToSetValue()
		{
			return new ITimeScheduleEntityTemplateNpcSource_SetValue
			{
				Type = this.Type,
				TemplateIds = this.TemplateIds
			};
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x0006E0C1 File Offset: 0x0006C2C1
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x0006E0EC File Offset: 0x0006C2EC
		public override ETimeScheduleNpcSourceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScheduleNpcSourceType.EntityTemplate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x0006E0FA File Offset: 0x0006C2FA
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x0006E121 File Offset: 0x0006C321
		public virtual List<string> TemplateIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TemplateIds;
				}
				ITimeScheduleEntityTemplateNpcSource_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TemplateIds;
			}
			set
			{
				this.GetOrCreatePoco().TemplateIds = value;
			}
		}

		// Token: 0x04001BFB RID: 7163
		[Nullable(2)]
		protected new ITimeScheduleEntityTemplateNpcSource FbInstance;

		// Token: 0x04001BFC RID: 7164
		[Nullable(2)]
		protected new ITimeScheduleEntityTemplateNpcSource_SetValue PocoInterface;
	}
}
