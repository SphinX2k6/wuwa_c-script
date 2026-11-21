using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000447 RID: 1095
	public class IGroupAiEcologyGameplayAbp
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x00044CF0 File Offset: 0x00042EF0
		private IGroupAiEcologyGameplayAbp_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiEcologyGameplayAbp 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiEcologyGameplayAbp_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiEcologyGameplayAbp_SetValue());
			}
			return result;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00044D28 File Offset: 0x00042F28
		public static IGroupAiEcologyGameplayAbp Create([Nullable(2)] IGroupAiEcologyGameplayAbp instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiEcologyGameplayAbp
			{
				FbInstance = instance
			};
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00044D3B File Offset: 0x00042F3B
		public static IGroupAiEcologyGameplayAbp CreateFromSetValue([Nullable(2)] IGroupAiEcologyGameplayAbp_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiEcologyGameplayAbp
			{
				PocoInterface = value
			};
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00044D4E File Offset: 0x00042F4E
		public IGroupAiEcologyGameplayAbp_SetValue ToSetValue()
		{
			return new IGroupAiEcologyGameplayAbp_SetValue
			{
				GameplayType = this.GameplayType
			};
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00044D61 File Offset: 0x00042F61
		// (set) Token: 0x060015E4 RID: 5604 RVA: 0x00044D8C File Offset: 0x00042F8C
		public virtual EGroupAiEcologyGameplayType GameplayType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GameplayType;
				}
				if (this.PocoInterface == null)
				{
					return EGroupAiEcologyGameplayType.FloatParade;
				}
				return this.PocoInterface.GameplayType;
			}
			set
			{
				this.GetOrCreatePoco().GameplayType = value;
			}
		}

		// Token: 0x0400111E RID: 4382
		[Nullable(2)]
		protected IGroupAiEcologyGameplayAbp FbInstance;

		// Token: 0x0400111F RID: 4383
		[Nullable(2)]
		protected IGroupAiEcologyGameplayAbp_SetValue PocoInterface;
	}
}
