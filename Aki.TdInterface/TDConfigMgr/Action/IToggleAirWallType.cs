using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200220D RID: 8717
	public class IToggleAirWallType
	{
		// Token: 0x0600BE04 RID: 48644 RVA: 0x001B7244 File Offset: 0x001B5444
		private IToggleAirWallType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IToggleAirWallType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IToggleAirWallType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IToggleAirWallType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE05 RID: 48645 RVA: 0x001B727C File Offset: 0x001B547C
		public static IToggleAirWallType Create([Nullable(2)] IToggleAirWallType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IToggleAirWallType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE06 RID: 48646 RVA: 0x001B728F File Offset: 0x001B548F
		public static IToggleAirWallType CreateFromSetValue([Nullable(2)] IToggleAirWallType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IToggleAirWallType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE07 RID: 48647 RVA: 0x001B72A2 File Offset: 0x001B54A2
		public IToggleAirWallType_SetValue ToSetValue()
		{
			return new IToggleAirWallType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0600BE08 RID: 48648 RVA: 0x001B72B5 File Offset: 0x001B54B5
		// (set) Token: 0x0600BE09 RID: 48649 RVA: 0x001B72E0 File Offset: 0x001B54E0
		public virtual EToggleAirWall Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EToggleAirWall.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007205 RID: 29189
		[Nullable(2)]
		protected IToggleAirWallType FbInstance;

		// Token: 0x04007206 RID: 29190
		[Nullable(2)]
		protected IToggleAirWallType_SetValue PocoInterface;
	}
}
