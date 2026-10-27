using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200203F RID: 8255
	[NullableContext(2)]
	[Nullable(0)]
	public class IVehicleExitPathMove : IVehicleControlType
	{
		// Token: 0x0600B56C RID: 46444 RVA: 0x001A5490 File Offset: 0x001A3690
		[NullableContext(1)]
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

		// Token: 0x0600B56D RID: 46445 RVA: 0x001A54C8 File Offset: 0x001A36C8
		[NullableContext(1)]
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

		// Token: 0x0600B56E RID: 46446 RVA: 0x001A54DB File Offset: 0x001A36DB
		[NullableContext(1)]
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

		// Token: 0x0600B56F RID: 46447 RVA: 0x001A54EE File Offset: 0x001A36EE
		[NullableContext(1)]
		public new IVehicleExitPathMove_SetValue ToSetValue()
		{
			return new IVehicleExitPathMove_SetValue
			{
				Type = this.Type,
				Pattern = this.Pattern
			};
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600B570 RID: 46448 RVA: 0x001A550D File Offset: 0x001A370D
		// (set) Token: 0x0600B571 RID: 46449 RVA: 0x001A5538 File Offset: 0x001A3738
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

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600B572 RID: 46450 RVA: 0x001A5546 File Offset: 0x001A3746
		// (set) Token: 0x0600B573 RID: 46451 RVA: 0x001A556D File Offset: 0x001A376D
		public virtual ICloseSplineMovePattern Pattern
		{
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
			set
			{
				this.GetOrCreatePoco().Pattern = value;
			}
		}

		// Token: 0x04006D2B RID: 27947
		protected new IVehicleExitPathMove FbInstance;

		// Token: 0x04006D2C RID: 27948
		protected new IVehicleExitPathMove_SetValue PocoInterface;
	}
}
