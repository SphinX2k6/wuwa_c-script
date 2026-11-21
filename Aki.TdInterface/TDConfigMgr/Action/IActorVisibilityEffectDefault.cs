using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001925 RID: 6437
	public class IActorVisibilityEffectDefault : IActorVisibilityEffectType
	{
		// Token: 0x06008709 RID: 34569 RVA: 0x00140FF8 File Offset: 0x0013F1F8
		private IActorVisibilityEffectDefault_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorVisibilityEffectDefault 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorVisibilityEffectDefault_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorVisibilityEffectDefault_SetValue());
			}
			return result;
		}

		// Token: 0x0600870A RID: 34570 RVA: 0x00141030 File Offset: 0x0013F230
		public static IActorVisibilityEffectDefault Create([Nullable(2)] IActorVisibilityEffectDefault instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorVisibilityEffectDefault
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600870B RID: 34571 RVA: 0x00141043 File Offset: 0x0013F243
		public static IActorVisibilityEffectDefault CreateFromSetValue([Nullable(2)] IActorVisibilityEffectDefault_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorVisibilityEffectDefault
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600870C RID: 34572 RVA: 0x00141056 File Offset: 0x0013F256
		public new IActorVisibilityEffectDefault_SetValue ToSetValue()
		{
			return new IActorVisibilityEffectDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x0600870D RID: 34573 RVA: 0x00141069 File Offset: 0x0013F269
		// (set) Token: 0x0600870E RID: 34574 RVA: 0x00141094 File Offset: 0x0013F294
		public override EActorVisibilityEffectType Type
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

		// Token: 0x04005588 RID: 21896
		[Nullable(2)]
		protected new IActorVisibilityEffectDefault FbInstance;

		// Token: 0x04005589 RID: 21897
		[Nullable(2)]
		protected new IActorVisibilityEffectDefault_SetValue PocoInterface;
	}
}
