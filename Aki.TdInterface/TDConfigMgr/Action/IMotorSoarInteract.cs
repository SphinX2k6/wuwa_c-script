using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C24 RID: 7204
	[NullableContext(1)]
	[Nullable(0)]
	public class IMotorSoarInteract : ILeisureInteractType
	{
		// Token: 0x06009A91 RID: 39569 RVA: 0x00163718 File Offset: 0x00161918
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

		// Token: 0x06009A92 RID: 39570 RVA: 0x00163750 File Offset: 0x00161950
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

		// Token: 0x06009A93 RID: 39571 RVA: 0x00163763 File Offset: 0x00161963
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

		// Token: 0x06009A94 RID: 39572 RVA: 0x00163776 File Offset: 0x00161976
		public new IMotorSoarInteract_SetValue ToSetValue()
		{
			return new IMotorSoarInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x06009A95 RID: 39573 RVA: 0x00163789 File Offset: 0x00161989
		// (set) Token: 0x06009A96 RID: 39574 RVA: 0x001637B4 File Offset: 0x001619B4
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

		// Token: 0x04005DFE RID: 24062
		[Nullable(2)]
		protected new IMotorSoarInteract FbInstance;

		// Token: 0x04005DFF RID: 24063
		[Nullable(2)]
		protected new IMotorSoarInteract_SetValue PocoInterface;
	}
}
