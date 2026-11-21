using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000665 RID: 1637
	public class IPasserbyNpcTemplateSource : IPasserbyNpcSource
	{
		// Token: 0x06002264 RID: 8804 RVA: 0x0005EF40 File Offset: 0x0005D140
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

		// Token: 0x06002265 RID: 8805 RVA: 0x0005EF78 File Offset: 0x0005D178
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

		// Token: 0x06002266 RID: 8806 RVA: 0x0005EF8B File Offset: 0x0005D18B
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

		// Token: 0x06002267 RID: 8807 RVA: 0x0005EF9E File Offset: 0x0005D19E
		public new IPasserbyNpcTemplateSource_SetValue ToSetValue()
		{
			return new IPasserbyNpcTemplateSource_SetValue
			{
				Type = this.Type,
				TemplateIds = this.TemplateIds
			};
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x0005EFBD File Offset: 0x0005D1BD
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x0005EFE8 File Offset: 0x0005D1E8
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

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x0005EFF6 File Offset: 0x0005D1F6
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x0005F01D File Offset: 0x0005D21D
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

		// Token: 0x04001824 RID: 6180
		[Nullable(2)]
		protected new IPasserbyNpcTemplateSource FbInstance;

		// Token: 0x04001825 RID: 6181
		[Nullable(2)]
		protected new IPasserbyNpcTemplateSource_SetValue PocoInterface;
	}
}
