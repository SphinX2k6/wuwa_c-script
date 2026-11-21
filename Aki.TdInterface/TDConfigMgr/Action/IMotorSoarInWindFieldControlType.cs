using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E1D RID: 7709
	public class IMotorSoarInWindFieldControlType
	{
		// Token: 0x0600A3F1 RID: 41969 RVA: 0x00176B14 File Offset: 0x00174D14
		private IMotorSoarInWindFieldControlType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorSoarInWindFieldControlType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorSoarInWindFieldControlType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorSoarInWindFieldControlType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3F2 RID: 41970 RVA: 0x00176B4C File Offset: 0x00174D4C
		public static IMotorSoarInWindFieldControlType Create([Nullable(2)] IMotorSoarInWindFieldControlType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSoarInWindFieldControlType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x00176B5F File Offset: 0x00174D5F
		public static IMotorSoarInWindFieldControlType CreateFromSetValue([Nullable(2)] IMotorSoarInWindFieldControlType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorSoarInWindFieldControlType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x00176B72 File Offset: 0x00174D72
		public IMotorSoarInWindFieldControlType_SetValue ToSetValue()
		{
			return new IMotorSoarInWindFieldControlType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032DB RID: 13019
		// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x00176B85 File Offset: 0x00174D85
		// (set) Token: 0x0600A3F6 RID: 41974 RVA: 0x00176BB0 File Offset: 0x00174DB0
		public virtual EMotorSoarInWindFieldControlType Type
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

		// Token: 0x04006338 RID: 25400
		[Nullable(2)]
		protected IMotorSoarInWindFieldControlType FbInstance;

		// Token: 0x04006339 RID: 25401
		[Nullable(2)]
		protected IMotorSoarInWindFieldControlType_SetValue PocoInterface;
	}
}
