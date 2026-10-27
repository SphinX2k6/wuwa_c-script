using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000554 RID: 1364
	[NullableContext(1)]
	[Nullable(0)]
	public class INoRenderPortalMode
	{
		// Token: 0x06001BEA RID: 7146 RVA: 0x00050508 File Offset: 0x0004E708
		private INoRenderPortalMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INoRenderPortalMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INoRenderPortalMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INoRenderPortalMode_SetValue());
			}
			return result;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00050540 File Offset: 0x0004E740
		public static INoRenderPortalMode Create([Nullable(2)] INoRenderPortalMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoRenderPortalMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00050553 File Offset: 0x0004E753
		public static INoRenderPortalMode CreateFromSetValue([Nullable(2)] INoRenderPortalMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INoRenderPortalMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00050566 File Offset: 0x0004E766
		public INoRenderPortalMode_SetValue ToSetValue()
		{
			return new INoRenderPortalMode_SetValue
			{
				Type = this.Type,
				PortalModel = this.PortalModel
			};
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00050585 File Offset: 0x0004E785
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x000505B0 File Offset: 0x0004E7B0
		public virtual ENoRenderPortalType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENoRenderPortalType.Static;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000505BE File Offset: 0x0004E7BE
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x000505E9 File Offset: 0x0004E7E9
		public virtual EPortalModel PortalModel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PortalModel;
				}
				if (this.PocoInterface == null)
				{
					return EPortalModel.A;
				}
				return this.PocoInterface.PortalModel;
			}
			set
			{
				this.GetOrCreatePoco().PortalModel = value;
			}
		}

		// Token: 0x04001404 RID: 5124
		[Nullable(2)]
		protected INoRenderPortalMode FbInstance;

		// Token: 0x04001405 RID: 5125
		[Nullable(2)]
		protected INoRenderPortalMode_SetValue PocoInterface;
	}
}
