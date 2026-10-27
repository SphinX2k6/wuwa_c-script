using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B2 RID: 6578
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableMoveOperationConverter))]
	public class IDisableMoveOperation : IMoveOperationType
	{
		// Token: 0x06008CD9 RID: 36057 RVA: 0x0014A4C0 File Offset: 0x001486C0
		private IDisableMoveOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableMoveOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableMoveOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableMoveOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008CDA RID: 36058 RVA: 0x0014A4F8 File Offset: 0x001486F8
		public static IDisableMoveOperation Create([Nullable(2)] IDisableMoveOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableMoveOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008CDB RID: 36059 RVA: 0x0014A50B File Offset: 0x0014870B
		public static IDisableMoveOperation CreateFromSetValue([Nullable(2)] IDisableMoveOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableMoveOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008CDC RID: 36060 RVA: 0x0014A520 File Offset: 0x00148720
		public new IDisableMoveOperation_SetValue ToSetValue()
		{
			return new IDisableMoveOperation_SetValue
			{
				Type = this.Type,
				Forward = this.Forward,
				Back = this.Back,
				Left = this.Left,
				Right = this.Right,
				ForceWalk = this.ForceWalk,
				ForceJog = this.ForceJog,
				ForbidSprint = this.ForbidSprint,
				ForbidAndDisableSprint = this.ForbidAndDisableSprint,
				ForbidAndDisableMotorcycleSprint = this.ForbidAndDisableMotorcycleSprint,
				DisableClimbAndStep = this.DisableClimbAndStep
			};
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x0014A5B6 File Offset: 0x001487B6
		// (set) Token: 0x06008CDE RID: 36062 RVA: 0x0014A5E1 File Offset: 0x001487E1
		public override EMoveOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x06008CDF RID: 36063 RVA: 0x0014A5EF File Offset: 0x001487EF
		// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x0014A61A File Offset: 0x0014881A
		public virtual bool Forward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Forward;
				}
				return this.PocoInterface != null && this.PocoInterface.Forward;
			}
			set
			{
				this.GetOrCreatePoco().Forward = value;
			}
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x0014A628 File Offset: 0x00148828
		// (set) Token: 0x06008CE2 RID: 36066 RVA: 0x0014A653 File Offset: 0x00148853
		public virtual bool Back
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Back;
				}
				return this.PocoInterface != null && this.PocoInterface.Back;
			}
			set
			{
				this.GetOrCreatePoco().Back = value;
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x0014A661 File Offset: 0x00148861
		// (set) Token: 0x06008CE4 RID: 36068 RVA: 0x0014A68C File Offset: 0x0014888C
		public virtual bool Left
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Left;
				}
				return this.PocoInterface != null && this.PocoInterface.Left;
			}
			set
			{
				this.GetOrCreatePoco().Left = value;
			}
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x06008CE5 RID: 36069 RVA: 0x0014A69A File Offset: 0x0014889A
		// (set) Token: 0x06008CE6 RID: 36070 RVA: 0x0014A6C5 File Offset: 0x001488C5
		public virtual bool Right
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Right;
				}
				return this.PocoInterface != null && this.PocoInterface.Right;
			}
			set
			{
				this.GetOrCreatePoco().Right = value;
			}
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x06008CE7 RID: 36071 RVA: 0x0014A6D4 File Offset: 0x001488D4
		// (set) Token: 0x06008CE8 RID: 36072 RVA: 0x0014A70E File Offset: 0x0014890E
		public virtual bool? ForceWalk
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForceWalk;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForceWalk;
			}
			set
			{
				this.GetOrCreatePoco().ForceWalk = value;
			}
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x0014A71C File Offset: 0x0014891C
		// (set) Token: 0x06008CEA RID: 36074 RVA: 0x0014A756 File Offset: 0x00148956
		public virtual bool? ForceJog
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForceJog;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForceJog;
			}
			set
			{
				this.GetOrCreatePoco().ForceJog = value;
			}
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x06008CEB RID: 36075 RVA: 0x0014A764 File Offset: 0x00148964
		// (set) Token: 0x06008CEC RID: 36076 RVA: 0x0014A79E File Offset: 0x0014899E
		public virtual bool? ForbidSprint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForbidSprint;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForbidSprint;
			}
			set
			{
				this.GetOrCreatePoco().ForbidSprint = value;
			}
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x06008CED RID: 36077 RVA: 0x0014A7AC File Offset: 0x001489AC
		// (set) Token: 0x06008CEE RID: 36078 RVA: 0x0014A7E6 File Offset: 0x001489E6
		public virtual bool? ForbidAndDisableSprint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForbidAndDisableSprint;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForbidAndDisableSprint;
			}
			set
			{
				this.GetOrCreatePoco().ForbidAndDisableSprint = value;
			}
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x06008CEF RID: 36079 RVA: 0x0014A7F4 File Offset: 0x001489F4
		// (set) Token: 0x06008CF0 RID: 36080 RVA: 0x0014A82E File Offset: 0x00148A2E
		public virtual bool? ForbidAndDisableMotorcycleSprint
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ForbidAndDisableMotorcycleSprint;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ForbidAndDisableMotorcycleSprint;
			}
			set
			{
				this.GetOrCreatePoco().ForbidAndDisableMotorcycleSprint = value;
			}
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x06008CF1 RID: 36081 RVA: 0x0014A83C File Offset: 0x00148A3C
		// (set) Token: 0x06008CF2 RID: 36082 RVA: 0x0014A876 File Offset: 0x00148A76
		public virtual bool? DisableClimbAndStep
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisableClimbAndStep;
				}
				IDisableMoveOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisableClimbAndStep;
			}
			set
			{
				this.GetOrCreatePoco().DisableClimbAndStep = value;
			}
		}

		// Token: 0x04005799 RID: 22425
		[Nullable(2)]
		protected new IDisableMoveOperation FbInstance;

		// Token: 0x0400579A RID: 22426
		[Nullable(2)]
		protected new IDisableMoveOperation_SetValue PocoInterface;
	}
}
