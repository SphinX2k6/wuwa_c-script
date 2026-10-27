using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B35 RID: 6965
	[NullableContext(1)]
	[Nullable(0)]
	public class IInputDrivenMoveDriveMode : ISplineMoveDriveMode
	{
		// Token: 0x0600950E RID: 38158 RVA: 0x00158BA4 File Offset: 0x00156DA4
		private IInputDrivenMoveDriveMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInputDrivenMoveDriveMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInputDrivenMoveDriveMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInputDrivenMoveDriveMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600950F RID: 38159 RVA: 0x00158BDC File Offset: 0x00156DDC
		public static IInputDrivenMoveDriveMode Create([Nullable(2)] IInputDrivenMoveDriveMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInputDrivenMoveDriveMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009510 RID: 38160 RVA: 0x00158BEF File Offset: 0x00156DEF
		public static IInputDrivenMoveDriveMode CreateFromSetValue([Nullable(2)] IInputDrivenMoveDriveMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInputDrivenMoveDriveMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009511 RID: 38161 RVA: 0x00158C02 File Offset: 0x00156E02
		public new IInputDrivenMoveDriveMode_SetValue ToSetValue()
		{
			return new IInputDrivenMoveDriveMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x06009512 RID: 38162 RVA: 0x00158C15 File Offset: 0x00156E15
		// (set) Token: 0x06009513 RID: 38163 RVA: 0x00158C40 File Offset: 0x00156E40
		public override ESplineMoveDriveMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveDriveMode.InputDriven;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B40 RID: 23360
		[Nullable(2)]
		protected new IInputDrivenMoveDriveMode FbInstance;

		// Token: 0x04005B41 RID: 23361
		[Nullable(2)]
		protected new IInputDrivenMoveDriveMode_SetValue PocoInterface;
	}
}
