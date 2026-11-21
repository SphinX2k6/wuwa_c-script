using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200065B RID: 1627
	public class IPasserbyNpcSpawnCenterPosBase
	{
		// Token: 0x0600222E RID: 8750 RVA: 0x0005E87C File Offset: 0x0005CA7C
		private IPasserbyNpcSpawnCenterPosBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPasserbyNpcSpawnCenterPosBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPasserbyNpcSpawnCenterPosBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPasserbyNpcSpawnCenterPosBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0005E8B4 File Offset: 0x0005CAB4
		public static IPasserbyNpcSpawnCenterPosBase Create([Nullable(2)] IPasserbyNpcSpawnCenterPosBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnCenterPosBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0005E8C7 File Offset: 0x0005CAC7
		public static IPasserbyNpcSpawnCenterPosBase CreateFromSetValue([Nullable(2)] IPasserbyNpcSpawnCenterPosBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPasserbyNpcSpawnCenterPosBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0005E8DA File Offset: 0x0005CADA
		public IPasserbyNpcSpawnCenterPosBase_SetValue ToSetValue()
		{
			return new IPasserbyNpcSpawnCenterPosBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0005E8ED File Offset: 0x0005CAED
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x0005E918 File Offset: 0x0005CB18
		public virtual EPasserbyNpcSpawnCenterPosType Type
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

		// Token: 0x04001808 RID: 6152
		[Nullable(2)]
		protected IPasserbyNpcSpawnCenterPosBase FbInstance;

		// Token: 0x04001809 RID: 6153
		[Nullable(2)]
		protected IPasserbyNpcSpawnCenterPosBase_SetValue PocoInterface;
	}
}
