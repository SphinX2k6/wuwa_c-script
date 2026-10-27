using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C2A RID: 7210
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorSoarInWindFieldExitWindField : IMotorSoarInWindFieldControlType
	{
		// Token: 0x06009AB5 RID: 39605 RVA: 0x00163B80 File Offset: 0x00161D80
		private IMotorSoarInWindFieldExitWindField_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorSoarInWindFieldExitWindField 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorSoarInWindFieldExitWindField_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorSoarInWindFieldExitWindField_SetValue());
			}
			return result;
		}

		// Token: 0x06009AB6 RID: 39606 RVA: 0x00163BB8 File Offset: 0x00161DB8
		public static IMotorSoarInWindFieldExitWindField Create([Nullable(2)] IMotorSoarInWindFieldExitWindField instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSoarInWindFieldExitWindField
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AB7 RID: 39607 RVA: 0x00163BCB File Offset: 0x00161DCB
		public static IMotorSoarInWindFieldExitWindField CreateFromSetValue([Nullable(2)] IMotorSoarInWindFieldExitWindField_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorSoarInWindFieldExitWindField
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AB8 RID: 39608 RVA: 0x00163BDE File Offset: 0x00161DDE
		public new IMotorSoarInWindFieldExitWindField_SetValue ToSetValue()
		{
			return new IMotorSoarInWindFieldExitWindField_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003072 RID: 12402
		// (get) Token: 0x06009AB9 RID: 39609 RVA: 0x00163BF1 File Offset: 0x00161DF1
		// (set) Token: 0x06009ABA RID: 39610 RVA: 0x00163C1C File Offset: 0x00161E1C
		public override EMotorSoarInWindFieldControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorSoarInWindFieldControlType.EnterWindField;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005E11 RID: 24081
		[Nullable(2)]
		protected new IMotorSoarInWindFieldExitWindField FbInstance;

		// Token: 0x04005E12 RID: 24082
		[Nullable(2)]
		protected new IMotorSoarInWindFieldExitWindField_SetValue PocoInterface;
	}
}
