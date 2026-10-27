using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A6 RID: 6054
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorVisibilityEffectType
	{
		// Token: 0x06008021 RID: 32801 RVA: 0x00131E54 File Offset: 0x00130054
		private IActorVisibilityEffectType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorVisibilityEffectType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorVisibilityEffectType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorVisibilityEffectType_SetValue());
			}
			return result;
		}

		// Token: 0x06008022 RID: 32802 RVA: 0x00131E8C File Offset: 0x0013008C
		public static IActorVisibilityEffectType Create([Nullable(2)] IActorVisibilityEffectType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorVisibilityEffectType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008023 RID: 32803 RVA: 0x00131E9F File Offset: 0x0013009F
		public static IActorVisibilityEffectType CreateFromSetValue([Nullable(2)] IActorVisibilityEffectType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorVisibilityEffectType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008024 RID: 32804 RVA: 0x00131EB2 File Offset: 0x001300B2
		public IActorVisibilityEffectType_SetValue ToSetValue()
		{
			return new IActorVisibilityEffectType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x06008025 RID: 32805 RVA: 0x00131EC5 File Offset: 0x001300C5
		// (set) Token: 0x06008026 RID: 32806 RVA: 0x00131EF0 File Offset: 0x001300F0
		public virtual EActorVisibilityEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorVisibilityEffectType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005155 RID: 20821
		[Nullable(2)]
		protected IActorVisibilityEffectType FbInstance;

		// Token: 0x04005156 RID: 20822
		[Nullable(2)]
		protected IActorVisibilityEffectType_SetValue PocoInterface;
	}
}
