using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002288 RID: 8840
	public class IVehicleExitPathMove : IVehicleControlType
	{
		// Token: 0x0600C092 RID: 49298 RVA: 0x001BBBFC File Offset: 0x001B9DFC
		private IVehicleExitPathMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVehicleExitPathMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVehicleExitPathMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVehicleExitPathMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600C093 RID: 49299 RVA: 0x001BBC34 File Offset: 0x001B9E34
		public static IVehicleExitPathMove Create([Nullable(2)] IVehicleExitPathMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVehicleExitPathMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C094 RID: 49300 RVA: 0x001BBC47 File Offset: 0x001B9E47
		public static IVehicleExitPathMove CreateFromSetValue([Nullable(2)] IVehicleExitPathMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVehicleExitPathMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C095 RID: 49301 RVA: 0x001BBC5A File Offset: 0x001B9E5A
		public new IVehicleExitPathMove_SetValue ToSetValue()
		{
			return new IVehicleExitPathMove_SetValue
			{
				Type = this.Type,
				Pattern = this.Pattern
			};
		}

		// Token: 0x17003A8D RID: 14989
		// (get) Token: 0x0600C096 RID: 49302 RVA: 0x001BBC79 File Offset: 0x001B9E79
		// (set) Token: 0x0600C097 RID: 49303 RVA: 0x001BBCA4 File Offset: 0x001B9EA4
		public override EVehicleControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVehicleControlType.EnterPathMoving;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A8E RID: 14990
		// (get) Token: 0x0600C098 RID: 49304 RVA: 0x001BBCB2 File Offset: 0x001B9EB2
		// (set) Token: 0x0600C099 RID: 49305 RVA: 0x001BBCD9 File Offset: 0x001B9ED9
		[Nullable(2)]
		public virtual ICloseSplineMovePattern Pattern
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pattern;
				}
				IVehicleExitPathMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pattern;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Pattern = value;
			}
		}

		// Token: 0x04007334 RID: 29492
		[Nullable(2)]
		protected new IVehicleExitPathMove FbInstance;

		// Token: 0x04007335 RID: 29493
		[Nullable(2)]
		protected new IVehicleExitPathMove_SetValue PocoInterface;
	}
}
