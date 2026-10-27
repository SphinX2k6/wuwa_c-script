using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD1 RID: 6865
	[NullableContext(1)]
	[Nullable(0)]
	public class IGetOffMotorcycleInteract : ILeisureInteractType
	{
		// Token: 0x0600932C RID: 37676 RVA: 0x00155B78 File Offset: 0x00153D78
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

		// Token: 0x0600932D RID: 37677 RVA: 0x00155BB0 File Offset: 0x00153DB0
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

		// Token: 0x0600932E RID: 37678 RVA: 0x00155BC3 File Offset: 0x00153DC3
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

		// Token: 0x0600932F RID: 37679 RVA: 0x00155BD6 File Offset: 0x00153DD6
		public new IGetOffMotorcycleInteract_SetValue ToSetValue()
		{
			return new IGetOffMotorcycleInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x06009330 RID: 37680 RVA: 0x00155BE9 File Offset: 0x00153DE9
		// (set) Token: 0x06009331 RID: 37681 RVA: 0x00155C14 File Offset: 0x00153E14
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

		// Token: 0x04005A7F RID: 23167
		[Nullable(2)]
		protected new IGetOffMotorcycleInteract FbInstance;

		// Token: 0x04005A80 RID: 23168
		[Nullable(2)]
		protected new IGetOffMotorcycleInteract_SetValue PocoInterface;
	}
}
