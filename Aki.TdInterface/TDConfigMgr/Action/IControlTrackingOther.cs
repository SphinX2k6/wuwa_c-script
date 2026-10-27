using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200193A RID: 6458
	[NullableContext(1)]
	[Nullable(0)]
	public class IControlTrackingOther : IControlTrackingType
	{
		// Token: 0x06008A75 RID: 35445 RVA: 0x001462A0 File Offset: 0x001444A0
		private IControlTrackingOther_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlTrackingOther 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlTrackingOther_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlTrackingOther_SetValue());
			}
			return result;
		}

		// Token: 0x06008A76 RID: 35446 RVA: 0x001462D8 File Offset: 0x001444D8
		public static IControlTrackingOther Create([Nullable(2)] IControlTrackingOther instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlTrackingOther
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x001462EB File Offset: 0x001444EB
		public static IControlTrackingOther CreateFromSetValue([Nullable(2)] IControlTrackingOther_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlTrackingOther
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x001462FE File Offset: 0x001444FE
		public new IControlTrackingOther_SetValue ToSetValue()
		{
			return new IControlTrackingOther_SetValue
			{
				Type = this.Type,
				Entities = this.Entities
			};
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x06008A79 RID: 35449 RVA: 0x0014631D File Offset: 0x0014451D
		// (set) Token: 0x06008A7A RID: 35450 RVA: 0x00146348 File Offset: 0x00144548
		public override EControlTrackingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControlTrackingType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x06008A7B RID: 35451 RVA: 0x00146356 File Offset: 0x00144556
		// (set) Token: 0x06008A7C RID: 35452 RVA: 0x0014637D File Offset: 0x0014457D
		public virtual List<int> Entities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Entities;
				}
				IControlTrackingOther_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Entities;
			}
			set
			{
				this.GetOrCreatePoco().Entities = value;
			}
		}

		// Token: 0x0400568D RID: 22157
		[Nullable(2)]
		protected new IControlTrackingOther FbInstance;

		// Token: 0x0400568E RID: 22158
		[Nullable(2)]
		protected new IControlTrackingOther_SetValue PocoInterface;
	}
}
