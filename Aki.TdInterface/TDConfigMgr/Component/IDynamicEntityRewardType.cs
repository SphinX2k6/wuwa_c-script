using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002E3 RID: 739
	[NullableContext(1)]
	[Nullable(0)]
	public class IDynamicEntityRewardType
	{
		// Token: 0x06000E27 RID: 3623 RVA: 0x00033A80 File Offset: 0x00031C80
		private IDynamicEntityRewardType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDynamicEntityRewardType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDynamicEntityRewardType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDynamicEntityRewardType_SetValue());
			}
			return result;
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00033AB8 File Offset: 0x00031CB8
		public static IDynamicEntityRewardType Create([Nullable(2)] IDynamicEntityRewardType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicEntityRewardType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00033ACB File Offset: 0x00031CCB
		public static IDynamicEntityRewardType CreateFromSetValue([Nullable(2)] IDynamicEntityRewardType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDynamicEntityRewardType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00033ADE File Offset: 0x00031CDE
		public IDynamicEntityRewardType_SetValue ToSetValue()
		{
			return new IDynamicEntityRewardType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00033AF1 File Offset: 0x00031CF1
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00033B1C File Offset: 0x00031D1C
		public virtual EDynamicEntityRewardType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000C93 RID: 3219
		[Nullable(2)]
		protected IDynamicEntityRewardType FbInstance;

		// Token: 0x04000C94 RID: 3220
		[Nullable(2)]
		protected IDynamicEntityRewardType_SetValue PocoInterface;
	}
}
