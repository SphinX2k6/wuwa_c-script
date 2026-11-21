using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000894 RID: 2196
	public class IWorldLevelBonusType
	{
		// Token: 0x06002F5F RID: 12127 RVA: 0x0007A26C File Offset: 0x0007846C
		private IWorldLevelBonusType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWorldLevelBonusType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWorldLevelBonusType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWorldLevelBonusType_SetValue());
			}
			return result;
		}

		// Token: 0x06002F60 RID: 12128 RVA: 0x0007A2A4 File Offset: 0x000784A4
		public static IWorldLevelBonusType Create([Nullable(2)] IWorldLevelBonusType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWorldLevelBonusType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x0007A2B7 File Offset: 0x000784B7
		public static IWorldLevelBonusType CreateFromSetValue([Nullable(2)] IWorldLevelBonusType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWorldLevelBonusType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002F62 RID: 12130 RVA: 0x0007A2CA File Offset: 0x000784CA
		public IWorldLevelBonusType_SetValue ToSetValue()
		{
			return new IWorldLevelBonusType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x0007A2DD File Offset: 0x000784DD
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x0007A308 File Offset: 0x00078508
		public virtual EWorldLevelBonus Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWorldLevelBonus.WorldLevelTable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001F59 RID: 8025
		[Nullable(2)]
		protected IWorldLevelBonusType FbInstance;

		// Token: 0x04001F5A RID: 8026
		[Nullable(2)]
		protected IWorldLevelBonusType_SetValue PocoInterface;
	}
}
