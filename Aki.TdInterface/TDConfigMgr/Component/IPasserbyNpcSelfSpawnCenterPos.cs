using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000655 RID: 1621
	public class IPasserbyNpcSelfSpawnCenterPos : IPasserbyNpcSpawnCenterPosBase
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x0005E5B0 File Offset: 0x0005C7B0
		private IPasserbyNpcSelfSpawnCenterPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSelfSpawnCenterPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSelfSpawnCenterPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSelfSpawnCenterPos_SetValue());
			}
			return result;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0005E5E8 File Offset: 0x0005C7E8
		public static IPasserbyNpcSelfSpawnCenterPos Create([Nullable(2)] IPasserbyNpcSelfSpawnCenterPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSelfSpawnCenterPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0005E5FB File Offset: 0x0005C7FB
		public static IPasserbyNpcSelfSpawnCenterPos CreateFromSetValue([Nullable(2)] IPasserbyNpcSelfSpawnCenterPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSelfSpawnCenterPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0005E60E File Offset: 0x0005C80E
		public new IPasserbyNpcSelfSpawnCenterPos_SetValue ToSetValue()
		{
			return new IPasserbyNpcSelfSpawnCenterPos_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x0005E621 File Offset: 0x0005C821
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x0005E64C File Offset: 0x0005C84C
		public override EPasserbyNpcSpawnCenterPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPasserbyNpcSpawnCenterPosType.Self;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040017FD RID: 6141
		[Nullable(2)]
		protected new IPasserbyNpcSelfSpawnCenterPos FbInstance;

		// Token: 0x040017FE RID: 6142
		[Nullable(2)]
		protected new IPasserbyNpcSelfSpawnCenterPos_SetValue PocoInterface;
	}
}
