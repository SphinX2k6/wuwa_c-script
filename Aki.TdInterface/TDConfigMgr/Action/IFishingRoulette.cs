using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C00 RID: 7168
	public class IFishingRoulette : IUiGame
	{
		// Token: 0x06009838 RID: 38968 RVA: 0x00161518 File Offset: 0x0015F718
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

		// Token: 0x06009839 RID: 38969 RVA: 0x00161550 File Offset: 0x0015F750
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

		// Token: 0x0600983A RID: 38970 RVA: 0x00161563 File Offset: 0x0015F763
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

		// Token: 0x0600983B RID: 38971 RVA: 0x00161576 File Offset: 0x0015F776
		public new IFishingRoulette_SetValue ToSetValue()
		{
			return new IFishingRoulette_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003029 RID: 12329
		// (get) Token: 0x0600983C RID: 38972 RVA: 0x00161589 File Offset: 0x0015F789
		// (set) Token: 0x0600983D RID: 38973 RVA: 0x001615B4 File Offset: 0x0015F7B4
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

		// Token: 0x04005DC6 RID: 24006
		[Nullable(2)]
		protected new IFishingRoulette FbInstance;

		// Token: 0x04005DC7 RID: 24007
		[Nullable(2)]
		protected new IFishingRoulette_SetValue PocoInterface;
	}
}
