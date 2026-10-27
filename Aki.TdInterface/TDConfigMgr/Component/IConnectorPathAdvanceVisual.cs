using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200027B RID: 635
	[NullableContext(1)]
	[Nullable(0)]
	public class IConnectorPathAdvanceVisual
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x0002E6A4 File Offset: 0x0002C8A4
		private IConnectorPathAdvanceVisual_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IConnectorPathAdvanceVisual 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IConnectorPathAdvanceVisual_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IConnectorPathAdvanceVisual_SetValue());
			}
			return result;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0002E6DC File Offset: 0x0002C8DC
		public static IConnectorPathAdvanceVisual Create([Nullable(2)] IConnectorPathAdvanceVisual instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVisual
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0002E6EF File Offset: 0x0002C8EF
		public static IConnectorPathAdvanceVisual CreateFromSetValue([Nullable(2)] IConnectorPathAdvanceVisual_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IConnectorPathAdvanceVisual
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0002E702 File Offset: 0x0002C902
		public IConnectorPathAdvanceVisual_SetValue ToSetValue()
		{
			return new IConnectorPathAdvanceVisual_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x0002E715 File Offset: 0x0002C915
		// (set) Token: 0x06000BB2 RID: 2994 RVA: 0x0002E740 File Offset: 0x0002C940
		public virtual EConnectorPathAdvanceVisualType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000B30 RID: 2864
		[Nullable(2)]
		protected IConnectorPathAdvanceVisual FbInstance;

		// Token: 0x04000B31 RID: 2865
		[Nullable(2)]
		protected IConnectorPathAdvanceVisual_SetValue PocoInterface;
	}
}
