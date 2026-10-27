using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200052C RID: 1324
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorInteractConstraintType
	{
		// Token: 0x06001AEC RID: 6892 RVA: 0x0004E12C File Offset: 0x0004C32C
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

		// Token: 0x06001AED RID: 6893 RVA: 0x0004E164 File Offset: 0x0004C364
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

		// Token: 0x06001AEE RID: 6894 RVA: 0x0004E177 File Offset: 0x0004C377
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

		// Token: 0x06001AEF RID: 6895 RVA: 0x0004E18A File Offset: 0x0004C38A
		public IMotorInteractConstraintType_SetValue ToSetValue()
		{
			return new IMotorInteractConstraintType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0004E19D File Offset: 0x0004C39D
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0004E1C8 File Offset: 0x0004C3C8
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

		// Token: 0x0400136D RID: 4973
		[Nullable(2)]
		protected IMotorInteractConstraintType FbInstance;

		// Token: 0x0400136E RID: 4974
		[Nullable(2)]
		protected IMotorInteractConstraintType_SetValue PocoInterface;
	}
}
