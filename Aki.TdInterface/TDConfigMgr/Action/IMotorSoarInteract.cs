using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E1B RID: 7707
	public class IMotorSoarInteract : ILeisureInteractType
	{
		// Token: 0x0600A3E9 RID: 41961 RVA: 0x00176A58 File Offset: 0x00174C58
		private IMotorSoarInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorSoarInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorSoarInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorSoarInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3EA RID: 41962 RVA: 0x00176A90 File Offset: 0x00174C90
		public static IMotorSoarInteract Create([Nullable(2)] IMotorSoarInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorSoarInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x00176AA3 File Offset: 0x00174CA3
		public static IMotorSoarInteract CreateFromSetValue([Nullable(2)] IMotorSoarInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorSoarInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x00176AB6 File Offset: 0x00174CB6
		public new IMotorSoarInteract_SetValue ToSetValue()
		{
			return new IMotorSoarInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032DA RID: 13018
		// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x00176AC9 File Offset: 0x00174CC9
		// (set) Token: 0x0600A3EE RID: 41966 RVA: 0x00176AF4 File Offset: 0x00174CF4
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006335 RID: 25397
		[Nullable(2)]
		protected new IMotorSoarInteract FbInstance;

		// Token: 0x04006336 RID: 25398
		[Nullable(2)]
		protected new IMotorSoarInteract_SetValue PocoInterface;
	}
}
