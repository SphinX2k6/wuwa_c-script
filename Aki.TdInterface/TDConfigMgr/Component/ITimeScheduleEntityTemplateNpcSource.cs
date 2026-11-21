using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000824 RID: 2084
	public class ITimeScheduleEntityTemplateNpcSource : ITimeScheduleNpcSource
	{
		// Token: 0x06002CDC RID: 11484 RVA: 0x00075130 File Offset: 0x00073330
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

		// Token: 0x06002CDD RID: 11485 RVA: 0x00075168 File Offset: 0x00073368
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

		// Token: 0x06002CDE RID: 11486 RVA: 0x0007517B File Offset: 0x0007337B
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

		// Token: 0x06002CDF RID: 11487 RVA: 0x0007518E File Offset: 0x0007338E
		public new ITimeScheduleEntityTemplateNpcSource_SetValue ToSetValue()
		{
			return new ITimeScheduleEntityTemplateNpcSource_SetValue
			{
				Type = this.Type,
				TemplateIds = this.TemplateIds
			};
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000751AD File Offset: 0x000733AD
		// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x000751D8 File Offset: 0x000733D8
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

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000751E6 File Offset: 0x000733E6
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x0007520D File Offset: 0x0007340D
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

		// Token: 0x04001DFD RID: 7677
		[Nullable(2)]
		protected new ITimeScheduleEntityTemplateNpcSource FbInstance;

		// Token: 0x04001DFE RID: 7678
		[Nullable(2)]
		protected new ITimeScheduleEntityTemplateNpcSource_SetValue PocoInterface;
	}
}
