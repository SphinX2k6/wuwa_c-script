using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003EE RID: 1006
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiEcologyGameplayAbp
	{
		// Token: 0x06001445 RID: 5189 RVA: 0x00040FA8 File Offset: 0x0003F1A8
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

		// Token: 0x06001446 RID: 5190 RVA: 0x00040FE0 File Offset: 0x0003F1E0
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

		// Token: 0x06001447 RID: 5191 RVA: 0x00040FF3 File Offset: 0x0003F1F3
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

		// Token: 0x06001448 RID: 5192 RVA: 0x00041006 File Offset: 0x0003F206
		public IGroupAiEcologyGameplayAbp_SetValue ToSetValue()
		{
			return new IGroupAiEcologyGameplayAbp_SetValue
			{
				GameplayType = this.GameplayType
			};
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x00041019 File Offset: 0x0003F219
		// (set) Token: 0x0600144A RID: 5194 RVA: 0x00041044 File Offset: 0x0003F244
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

		// Token: 0x04000FFC RID: 4092
		[Nullable(2)]
		protected IGroupAiEcologyGameplayAbp FbInstance;

		// Token: 0x04000FFD RID: 4093
		[Nullable(2)]
		protected IGroupAiEcologyGameplayAbp_SetValue PocoInterface;
	}
}
