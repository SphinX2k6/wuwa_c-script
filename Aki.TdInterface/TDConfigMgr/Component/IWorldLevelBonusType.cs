using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007F1 RID: 2033
	[NullableContext(1)]
	[Nullable(0)]
	public class IWorldLevelBonusType
	{
		// Token: 0x06002C2F RID: 11311 RVA: 0x00072F08 File Offset: 0x00071108
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

		// Token: 0x06002C30 RID: 11312 RVA: 0x00072F40 File Offset: 0x00071140
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

		// Token: 0x06002C31 RID: 11313 RVA: 0x00072F53 File Offset: 0x00071153
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

		// Token: 0x06002C32 RID: 11314 RVA: 0x00072F66 File Offset: 0x00071166
		public IWorldLevelBonusType_SetValue ToSetValue()
		{
			return new IWorldLevelBonusType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x00072F79 File Offset: 0x00071179
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x00072FA4 File Offset: 0x000711A4
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

		// Token: 0x04001D4D RID: 7501
		[Nullable(2)]
		protected IWorldLevelBonusType FbInstance;

		// Token: 0x04001D4E RID: 7502
		[Nullable(2)]
		protected IWorldLevelBonusType_SetValue PocoInterface;
	}
}
