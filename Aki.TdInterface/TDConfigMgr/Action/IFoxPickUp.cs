using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AB9 RID: 6841
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoxPickUp : ILeisureInteractType
	{
		// Token: 0x060092B0 RID: 37552 RVA: 0x00154E18 File Offset: 0x00153018
		private IFoxPickUp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxPickUp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxPickUp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxPickUp_SetValue());
			}
			return result;
		}

		// Token: 0x060092B1 RID: 37553 RVA: 0x00154E50 File Offset: 0x00153050
		public static IFoxPickUp Create([Nullable(2)] IFoxPickUp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPickUp
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092B2 RID: 37554 RVA: 0x00154E63 File Offset: 0x00153063
		public static IFoxPickUp CreateFromSetValue([Nullable(2)] IFoxPickUp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxPickUp
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092B3 RID: 37555 RVA: 0x00154E76 File Offset: 0x00153076
		public new IFoxPickUp_SetValue ToSetValue()
		{
			return new IFoxPickUp_SetValue
			{
				Type = this.Type,
				DataTableIndex = this.DataTableIndex,
				MouthOpen = this.MouthOpen
			};
		}

		// Token: 0x17002E98 RID: 11928
		// (get) Token: 0x060092B4 RID: 37556 RVA: 0x00154EA1 File Offset: 0x001530A1
		// (set) Token: 0x060092B5 RID: 37557 RVA: 0x00154ECC File Offset: 0x001530CC
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E99 RID: 11929
		// (get) Token: 0x060092B6 RID: 37558 RVA: 0x00154EDA File Offset: 0x001530DA
		// (set) Token: 0x060092B7 RID: 37559 RVA: 0x00154F05 File Offset: 0x00153105
		public virtual int DataTableIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DataTableIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.DataTableIndex;
			}
			set
			{
				this.GetOrCreatePoco().DataTableIndex = value;
			}
		}

		// Token: 0x17002E9A RID: 11930
		// (get) Token: 0x060092B8 RID: 37560 RVA: 0x00154F14 File Offset: 0x00153114
		// (set) Token: 0x060092B9 RID: 37561 RVA: 0x00154F4E File Offset: 0x0015314E
		public virtual bool? MouthOpen
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MouthOpen;
				}
				IFoxPickUp_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MouthOpen;
			}
			set
			{
				this.GetOrCreatePoco().MouthOpen = value;
			}
		}

		// Token: 0x04005A49 RID: 23113
		[Nullable(2)]
		protected new IFoxPickUp FbInstance;

		// Token: 0x04005A4A RID: 23114
		[Nullable(2)]
		protected new IFoxPickUp_SetValue PocoInterface;
	}
}
