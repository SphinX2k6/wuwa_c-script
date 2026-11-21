using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057F RID: 1407
	public class IMonsterShowOnDeathEffect : IMonsterShowOnDeathConfig
	{
		// Token: 0x06001C66 RID: 7270 RVA: 0x00051D38 File Offset: 0x0004FF38
		private IMonsterShowOnDeathEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterShowOnDeathEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterShowOnDeathEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterShowOnDeathEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00051D70 File Offset: 0x0004FF70
		public static IMonsterShowOnDeathEffect Create([Nullable(2)] IMonsterShowOnDeathEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterShowOnDeathEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00051D83 File Offset: 0x0004FF83
		public static IMonsterShowOnDeathEffect CreateFromSetValue([Nullable(2)] IMonsterShowOnDeathEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterShowOnDeathEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00051D96 File Offset: 0x0004FF96
		public new IMonsterShowOnDeathEffect_SetValue ToSetValue()
		{
			return new IMonsterShowOnDeathEffect_SetValue
			{
				Type = this.Type,
				EffectId = this.EffectId
			};
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00051DB5 File Offset: 0x0004FFB5
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x00051DE0 File Offset: 0x0004FFE0
		public override EMonsterShowOnDeathType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterShowOnDeathType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00051DEE File Offset: 0x0004FFEE
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x00051E19 File Offset: 0x00050019
		public virtual int EffectId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EffectId;
			}
			set
			{
				this.GetOrCreatePoco().EffectId = value;
			}
		}

		// Token: 0x0400148C RID: 5260
		[Nullable(2)]
		protected new IMonsterShowOnDeathEffect FbInstance;

		// Token: 0x0400148D RID: 5261
		[Nullable(2)]
		protected new IMonsterShowOnDeathEffect_SetValue PocoInterface;
	}
}
