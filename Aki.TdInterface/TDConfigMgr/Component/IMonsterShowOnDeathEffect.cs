using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000518 RID: 1304
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterShowOnDeathEffect : IMonsterShowOnDeathConfig
	{
		// Token: 0x06001A6A RID: 6762 RVA: 0x0004CF7C File Offset: 0x0004B17C
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

		// Token: 0x06001A6B RID: 6763 RVA: 0x0004CFB4 File Offset: 0x0004B1B4
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

		// Token: 0x06001A6C RID: 6764 RVA: 0x0004CFC7 File Offset: 0x0004B1C7
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

		// Token: 0x06001A6D RID: 6765 RVA: 0x0004CFDA File Offset: 0x0004B1DA
		public new IMonsterShowOnDeathEffect_SetValue ToSetValue()
		{
			return new IMonsterShowOnDeathEffect_SetValue
			{
				Type = this.Type,
				EffectId = this.EffectId
			};
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0004CFF9 File Offset: 0x0004B1F9
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0004D024 File Offset: 0x0004B224
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

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0004D032 File Offset: 0x0004B232
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0004D05D File Offset: 0x0004B25D
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

		// Token: 0x04001322 RID: 4898
		[Nullable(2)]
		protected new IMonsterShowOnDeathEffect FbInstance;

		// Token: 0x04001323 RID: 4899
		[Nullable(2)]
		protected new IMonsterShowOnDeathEffect_SetValue PocoInterface;
	}
}
