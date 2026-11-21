using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E7 RID: 6375
	public class IActorFxEmote
	{
		// Token: 0x060085BF RID: 34239 RVA: 0x0013E9D4 File Offset: 0x0013CBD4
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

		// Token: 0x060085C0 RID: 34240 RVA: 0x0013EA0C File Offset: 0x0013CC0C
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

		// Token: 0x060085C1 RID: 34241 RVA: 0x0013EA1F File Offset: 0x0013CC1F
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

		// Token: 0x060085C2 RID: 34242 RVA: 0x0013EA32 File Offset: 0x0013CC32
		public IActorFxEmote_SetValue ToSetValue()
		{
			return new IActorFxEmote_SetValue
			{
				ActorIndex = this.ActorIndex,
				FxEmote = this.FxEmote
			};
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x0013EA51 File Offset: 0x0013CC51
		// (set) Token: 0x060085C4 RID: 34244 RVA: 0x0013EA7C File Offset: 0x0013CC7C
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

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x060085C5 RID: 34245 RVA: 0x0013EA8A File Offset: 0x0013CC8A
		// (set) Token: 0x060085C6 RID: 34246 RVA: 0x0013EAB1 File Offset: 0x0013CCB1
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

		// Token: 0x040054E8 RID: 21736
		[Nullable(2)]
		protected IActorFxEmote FbInstance;

		// Token: 0x040054E9 RID: 21737
		[Nullable(2)]
		protected IActorFxEmote_SetValue PocoInterface;
	}
}
