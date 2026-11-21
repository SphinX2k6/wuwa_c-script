using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001927 RID: 6439
	public class IActorVisibilityEffectType
	{
		// Token: 0x06008711 RID: 34577 RVA: 0x001410B4 File Offset: 0x0013F2B4
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

		// Token: 0x06008712 RID: 34578 RVA: 0x001410EC File Offset: 0x0013F2EC
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

		// Token: 0x06008713 RID: 34579 RVA: 0x001410FF File Offset: 0x0013F2FF
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

		// Token: 0x06008714 RID: 34580 RVA: 0x00141112 File Offset: 0x0013F312
		public IActorVisibilityEffectType_SetValue ToSetValue()
		{
			return new IActorVisibilityEffectType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x06008715 RID: 34581 RVA: 0x00141125 File Offset: 0x0013F325
		// (set) Token: 0x06008716 RID: 34582 RVA: 0x00141150 File Offset: 0x0013F350
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

		// Token: 0x0400558B RID: 21899
		[Nullable(2)]
		protected IActorVisibilityEffectType FbInstance;

		// Token: 0x0400558C RID: 21900
		[Nullable(2)]
		protected IActorVisibilityEffectType_SetValue PocoInterface;
	}
}
