using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E21 RID: 7713
	public class IMotorSoarInWindFieldExitWindField : IMotorSoarInWindFieldControlType
	{
		// Token: 0x0600A40D RID: 41997 RVA: 0x00176EC0 File Offset: 0x001750C0
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

		// Token: 0x0600A40E RID: 41998 RVA: 0x00176EF8 File Offset: 0x001750F8
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

		// Token: 0x0600A40F RID: 41999 RVA: 0x00176F0B File Offset: 0x0017510B
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

		// Token: 0x0600A410 RID: 42000 RVA: 0x00176F1E File Offset: 0x0017511E
		public new IMotorSoarInWindFieldExitWindField_SetValue ToSetValue()
		{
			return new IMotorSoarInWindFieldExitWindField_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032E3 RID: 13027
		// (get) Token: 0x0600A411 RID: 42001 RVA: 0x00176F31 File Offset: 0x00175131
		// (set) Token: 0x0600A412 RID: 42002 RVA: 0x00176F5C File Offset: 0x0017515C
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

		// Token: 0x04006348 RID: 25416
		[Nullable(2)]
		protected new IMotorSoarInWindFieldExitWindField FbInstance;

		// Token: 0x04006349 RID: 25417
		[Nullable(2)]
		protected new IMotorSoarInWindFieldExitWindField_SetValue PocoInterface;
	}
}
