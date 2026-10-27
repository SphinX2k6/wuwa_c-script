using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001944 RID: 6468
	[NullableContext(1)]
	[Nullable(0)]
	public class ICurrentVehicle : ITargetVehicle
	{
		// Token: 0x06008A9F RID: 35487 RVA: 0x0014668C File Offset: 0x0014488C
		private ICurrentVehicle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICurrentVehicle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICurrentVehicle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICurrentVehicle_SetValue());
			}
			return result;
		}

		// Token: 0x06008AA0 RID: 35488 RVA: 0x001466C4 File Offset: 0x001448C4
		public static ICurrentVehicle Create([Nullable(2)] ICurrentVehicle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICurrentVehicle
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AA1 RID: 35489 RVA: 0x001466D7 File Offset: 0x001448D7
		public static ICurrentVehicle CreateFromSetValue([Nullable(2)] ICurrentVehicle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICurrentVehicle
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AA2 RID: 35490 RVA: 0x001466EA File Offset: 0x001448EA
		public new ICurrentVehicle_SetValue ToSetValue()
		{
			return new ICurrentVehicle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x06008AA3 RID: 35491 RVA: 0x001466FD File Offset: 0x001448FD
		// (set) Token: 0x06008AA4 RID: 35492 RVA: 0x00146728 File Offset: 0x00144928
		public override ETargetVehicle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetVehicle.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400569D RID: 22173
		[Nullable(2)]
		protected new ICurrentVehicle FbInstance;

		// Token: 0x0400569E RID: 22174
		[Nullable(2)]
		protected new ICurrentVehicle_SetValue PocoInterface;
	}
}
