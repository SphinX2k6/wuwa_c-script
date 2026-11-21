using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000593 RID: 1427
	public class IMotorInteractConstraintType
	{
		// Token: 0x06001CE8 RID: 7400 RVA: 0x00052EE8 File Offset: 0x000510E8
		private IMotorInteractConstraintType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorInteractConstraintType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorInteractConstraintType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorInteractConstraintType_SetValue());
			}
			return result;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00052F20 File Offset: 0x00051120
		public static IMotorInteractConstraintType Create([Nullable(2)] IMotorInteractConstraintType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorInteractConstraintType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00052F33 File Offset: 0x00051133
		public static IMotorInteractConstraintType CreateFromSetValue([Nullable(2)] IMotorInteractConstraintType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorInteractConstraintType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00052F46 File Offset: 0x00051146
		public IMotorInteractConstraintType_SetValue ToSetValue()
		{
			return new IMotorInteractConstraintType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x00052F59 File Offset: 0x00051159
		// (set) Token: 0x06001CED RID: 7405 RVA: 0x00052F84 File Offset: 0x00051184
		public virtual EMotorInteractConstraintType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMotorInteractConstraintType.FaceToTarget;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040014D7 RID: 5335
		[Nullable(2)]
		protected IMotorInteractConstraintType FbInstance;

		// Token: 0x040014D8 RID: 5336
		[Nullable(2)]
		protected IMotorInteractConstraintType_SetValue PocoInterface;
	}
}
