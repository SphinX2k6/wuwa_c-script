using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021D3 RID: 8659
	public class ITeamType
	{
		// Token: 0x0600BCBA RID: 48314 RVA: 0x001B4C24 File Offset: 0x001B2E24
		private ITeamType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeamType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeamType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeamType_SetValue());
			}
			return result;
		}

		// Token: 0x0600BCBB RID: 48315 RVA: 0x001B4C5C File Offset: 0x001B2E5C
		public static ITeamType Create([Nullable(2)] ITeamType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeamType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BCBC RID: 48316 RVA: 0x001B4C6F File Offset: 0x001B2E6F
		public static ITeamType CreateFromSetValue([Nullable(2)] ITeamType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeamType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BCBD RID: 48317 RVA: 0x001B4C82 File Offset: 0x001B2E82
		public ITeamType_SetValue ToSetValue()
		{
			return new ITeamType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170039B0 RID: 14768
		// (get) Token: 0x0600BCBE RID: 48318 RVA: 0x001B4C95 File Offset: 0x001B2E95
		// (set) Token: 0x0600BCBF RID: 48319 RVA: 0x001B4CC0 File Offset: 0x001B2EC0
		public virtual ETeamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeamType.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007165 RID: 29029
		[Nullable(2)]
		protected ITeamType FbInstance;

		// Token: 0x04007166 RID: 29030
		[Nullable(2)]
		protected ITeamType_SetValue PocoInterface;
	}
}
