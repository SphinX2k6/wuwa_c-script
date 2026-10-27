using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017A4 RID: 6052
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorVisibilityEffectDefault : IActorVisibilityEffectType
	{
		// Token: 0x06008019 RID: 32793 RVA: 0x00131D98 File Offset: 0x0012FF98
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

		// Token: 0x0600801A RID: 32794 RVA: 0x00131DD0 File Offset: 0x0012FFD0
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

		// Token: 0x0600801B RID: 32795 RVA: 0x00131DE3 File Offset: 0x0012FFE3
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

		// Token: 0x0600801C RID: 32796 RVA: 0x00131DF6 File Offset: 0x0012FFF6
		public new IActorVisibilityEffectDefault_SetValue ToSetValue()
		{
			return new IActorVisibilityEffectDefault_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x0600801D RID: 32797 RVA: 0x00131E09 File Offset: 0x00130009
		// (set) Token: 0x0600801E RID: 32798 RVA: 0x00131E34 File Offset: 0x00130034
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

		// Token: 0x04005152 RID: 20818
		[Nullable(2)]
		protected new IActorVisibilityEffectDefault FbInstance;

		// Token: 0x04005153 RID: 20819
		[Nullable(2)]
		protected new IActorVisibilityEffectDefault_SetValue PocoInterface;
	}
}
