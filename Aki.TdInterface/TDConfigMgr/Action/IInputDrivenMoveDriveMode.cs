using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CE4 RID: 7396
	public class IInputDrivenMoveDriveMode : ISplineMoveDriveMode
	{
		// Token: 0x06009CF8 RID: 40184 RVA: 0x00169880 File Offset: 0x00167A80
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

		// Token: 0x06009CF9 RID: 40185 RVA: 0x001698B8 File Offset: 0x00167AB8
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

		// Token: 0x06009CFA RID: 40186 RVA: 0x001698CB File Offset: 0x00167ACB
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

		// Token: 0x06009CFB RID: 40187 RVA: 0x001698DE File Offset: 0x00167ADE
		public new IInputDrivenMoveDriveMode_SetValue ToSetValue()
		{
			return new IInputDrivenMoveDriveMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003133 RID: 12595
		// (get) Token: 0x06009CFC RID: 40188 RVA: 0x001698F1 File Offset: 0x00167AF1
		// (set) Token: 0x06009CFD RID: 40189 RVA: 0x0016991C File Offset: 0x00167B1C
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

		// Token: 0x04005FDE RID: 24542
		[Nullable(2)]
		protected new IInputDrivenMoveDriveMode FbInstance;

		// Token: 0x04005FDF RID: 24543
		[Nullable(2)]
		protected new IInputDrivenMoveDriveMode_SetValue PocoInterface;
	}
}
