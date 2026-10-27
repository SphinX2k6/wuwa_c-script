using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A6B RID: 6763
	[NullableContext(1)]
	[Nullable(0)]
	public class IFishingRoulette : IUiGame
	{
		// Token: 0x060090CE RID: 37070 RVA: 0x001515EC File Offset: 0x0014F7EC
		private IFishingRoulette_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFishingRoulette 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFishingRoulette_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFishingRoulette_SetValue());
			}
			return result;
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x00151624 File Offset: 0x0014F824
		public static IFishingRoulette Create([Nullable(2)] IFishingRoulette instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFishingRoulette
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x00151637 File Offset: 0x0014F837
		public static IFishingRoulette CreateFromSetValue([Nullable(2)] IFishingRoulette_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFishingRoulette
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x0015164A File Offset: 0x0014F84A
		public new IFishingRoulette_SetValue ToSetValue()
		{
			return new IFishingRoulette_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x060090D2 RID: 37074 RVA: 0x0015165D File Offset: 0x0014F85D
		// (set) Token: 0x060090D3 RID: 37075 RVA: 0x00151688 File Offset: 0x0014F888
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005961 RID: 22881
		[Nullable(2)]
		protected new IFishingRoulette FbInstance;

		// Token: 0x04005962 RID: 22882
		[Nullable(2)]
		protected new IFishingRoulette_SetValue PocoInterface;
	}
}
