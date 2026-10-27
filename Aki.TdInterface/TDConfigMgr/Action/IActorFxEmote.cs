using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001766 RID: 5990
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmote
	{
		// Token: 0x06007ECF RID: 32463 RVA: 0x0012F774 File Offset: 0x0012D974
		private IActorFxEmote_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFxEmote 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFxEmote_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFxEmote_SetValue());
			}
			return result;
		}

		// Token: 0x06007ED0 RID: 32464 RVA: 0x0012F7AC File Offset: 0x0012D9AC
		public static IActorFxEmote Create([Nullable(2)] IActorFxEmote instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmote
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007ED1 RID: 32465 RVA: 0x0012F7BF File Offset: 0x0012D9BF
		public static IActorFxEmote CreateFromSetValue([Nullable(2)] IActorFxEmote_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFxEmote
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007ED2 RID: 32466 RVA: 0x0012F7D2 File Offset: 0x0012D9D2
		public IActorFxEmote_SetValue ToSetValue()
		{
			return new IActorFxEmote_SetValue
			{
				ActorIndex = this.ActorIndex,
				FxEmote = this.FxEmote
			};
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x06007ED3 RID: 32467 RVA: 0x0012F7F1 File Offset: 0x0012D9F1
		// (set) Token: 0x06007ED4 RID: 32468 RVA: 0x0012F81C File Offset: 0x0012DA1C
		public virtual int ActorIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ActorIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ActorIndex;
			}
			set
			{
				this.GetOrCreatePoco().ActorIndex = value;
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x06007ED5 RID: 32469 RVA: 0x0012F82A File Offset: 0x0012DA2A
		// (set) Token: 0x06007ED6 RID: 32470 RVA: 0x0012F851 File Offset: 0x0012DA51
		public virtual IActorFxEmoteType FxEmote
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FxEmote;
				}
				IActorFxEmote_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FxEmote;
			}
			set
			{
				this.GetOrCreatePoco().FxEmote = value;
			}
		}

		// Token: 0x040050B2 RID: 20658
		[Nullable(2)]
		protected IActorFxEmote FbInstance;

		// Token: 0x040050B3 RID: 20659
		[Nullable(2)]
		protected IActorFxEmote_SetValue PocoInterface;
	}
}
