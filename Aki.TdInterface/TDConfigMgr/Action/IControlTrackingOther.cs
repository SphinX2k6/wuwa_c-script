using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC3 RID: 6851
	public class IControlTrackingOther : IControlTrackingType
	{
		// Token: 0x060091A1 RID: 37281 RVA: 0x00155BE0 File Offset: 0x00153DE0
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

		// Token: 0x060091A2 RID: 37282 RVA: 0x00155C18 File Offset: 0x00153E18
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

		// Token: 0x060091A3 RID: 37283 RVA: 0x00155C2B File Offset: 0x00153E2B
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

		// Token: 0x060091A4 RID: 37284 RVA: 0x00155C3E File Offset: 0x00153E3E
		public new IControlTrackingOther_SetValue ToSetValue()
		{
			return new IControlTrackingOther_SetValue
			{
				Type = this.Type,
				Entities = this.Entities
			};
		}

		// Token: 0x17002EB8 RID: 11960
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x00155C5D File Offset: 0x00153E5D
		// (set) Token: 0x060091A6 RID: 37286 RVA: 0x00155C88 File Offset: 0x00153E88
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

		// Token: 0x17002EB9 RID: 11961
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x00155C96 File Offset: 0x00153E96
		// (set) Token: 0x060091A8 RID: 37288 RVA: 0x00155CBD File Offset: 0x00153EBD
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

		// Token: 0x04005ADD RID: 23261
		[Nullable(2)]
		protected new IControlTrackingOther FbInstance;

		// Token: 0x04005ADE RID: 23262
		[Nullable(2)]
		protected new IControlTrackingOther_SetValue PocoInterface;
	}
}
