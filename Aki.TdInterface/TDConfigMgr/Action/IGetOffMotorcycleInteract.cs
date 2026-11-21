using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C78 RID: 7288
	public class IGetOffMotorcycleInteract : ILeisureInteractType
	{
		// Token: 0x06009AEA RID: 39658 RVA: 0x00166398 File Offset: 0x00164598
		private IGetOffMotorcycleInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGetOffMotorcycleInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGetOffMotorcycleInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGetOffMotorcycleInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06009AEB RID: 39659 RVA: 0x001663D0 File Offset: 0x001645D0
		public static IGetOffMotorcycleInteract Create([Nullable(2)] IGetOffMotorcycleInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGetOffMotorcycleInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009AEC RID: 39660 RVA: 0x001663E3 File Offset: 0x001645E3
		public static IGetOffMotorcycleInteract CreateFromSetValue([Nullable(2)] IGetOffMotorcycleInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGetOffMotorcycleInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x001663F6 File Offset: 0x001645F6
		public new IGetOffMotorcycleInteract_SetValue ToSetValue()
		{
			return new IGetOffMotorcycleInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x06009AEE RID: 39662 RVA: 0x00166409 File Offset: 0x00164609
		// (set) Token: 0x06009AEF RID: 39663 RVA: 0x00166434 File Offset: 0x00164634
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

		// Token: 0x04005F09 RID: 24329
		[Nullable(2)]
		protected new IGetOffMotorcycleInteract FbInstance;

		// Token: 0x04005F0A RID: 24330
		[Nullable(2)]
		protected new IGetOffMotorcycleInteract_SetValue PocoInterface;
	}
}
