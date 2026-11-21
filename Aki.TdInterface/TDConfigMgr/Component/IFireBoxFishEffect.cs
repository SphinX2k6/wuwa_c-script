using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003CF RID: 975
	public class IFireBoxFishEffect : IGraph3dEffectBase
	{
		// Token: 0x06001327 RID: 4903 RVA: 0x0003EE78 File Offset: 0x0003D078
		private IFireBoxFishEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFireBoxFishEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFireBoxFishEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFireBoxFishEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0003EEB0 File Offset: 0x0003D0B0
		public static IFireBoxFishEffect Create([Nullable(2)] IFireBoxFishEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFireBoxFishEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0003EEC3 File Offset: 0x0003D0C3
		public static IFireBoxFishEffect CreateFromSetValue([Nullable(2)] IFireBoxFishEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFireBoxFishEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0003EED6 File Offset: 0x0003D0D6
		public new IFireBoxFishEffect_SetValue ToSetValue()
		{
			return new IFireBoxFishEffect_SetValue
			{
				Type = this.Type,
				Effect = this.Effect
			};
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0003EEF5 File Offset: 0x0003D0F5
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x0003EF20 File Offset: 0x0003D120
		public override EGraph3dEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGraph3dEffectType.FireBoxFish;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0003EF2E File Offset: 0x0003D12E
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x0003EF59 File Offset: 0x0003D159
		public virtual string Effect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Effect;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Effect;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
			}
		}

		// Token: 0x04000F82 RID: 3970
		[Nullable(2)]
		protected new IFireBoxFishEffect FbInstance;

		// Token: 0x04000F83 RID: 3971
		[Nullable(2)]
		protected new IFireBoxFishEffect_SetValue PocoInterface;
	}
}
