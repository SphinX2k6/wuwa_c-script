using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D4 RID: 1492
	[NullableContext(1)]
	[Nullable(0)]
	public class IPasserbyNpcTemplateSource : IPasserbyNpcSource
	{
		// Token: 0x06001F98 RID: 8088 RVA: 0x000588B4 File Offset: 0x00056AB4
		private IPasserbyNpcTemplateSource_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcTemplateSource 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcTemplateSource_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcTemplateSource_SetValue());
			}
			return result;
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000588EC File Offset: 0x00056AEC
		public static IPasserbyNpcTemplateSource Create([Nullable(2)] IPasserbyNpcTemplateSource instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcTemplateSource
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000588FF File Offset: 0x00056AFF
		public static IPasserbyNpcTemplateSource CreateFromSetValue([Nullable(2)] IPasserbyNpcTemplateSource_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcTemplateSource
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00058912 File Offset: 0x00056B12
		public new IPasserbyNpcTemplateSource_SetValue ToSetValue()
		{
			return new IPasserbyNpcTemplateSource_SetValue
			{
				Type = this.Type,
				TemplateIds = this.TemplateIds
			};
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00058931 File Offset: 0x00056B31
		// (set) Token: 0x06001F9D RID: 8093 RVA: 0x0005895C File Offset: 0x00056B5C
		public override EPasserbyNpcSource Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcSource.Template;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001F9E RID: 8094 RVA: 0x0005896A File Offset: 0x00056B6A
		// (set) Token: 0x06001F9F RID: 8095 RVA: 0x00058991 File Offset: 0x00056B91
		public virtual List<string> TemplateIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TemplateIds;
				}
				IPasserbyNpcTemplateSource_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400164D RID: 5709
		[Nullable(2)]
		protected new IPasserbyNpcTemplateSource FbInstance;

		// Token: 0x0400164E RID: 5710
		[Nullable(2)]
		protected new IPasserbyNpcTemplateSource_SetValue PocoInterface;
	}
}
