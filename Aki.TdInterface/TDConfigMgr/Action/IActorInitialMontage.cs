using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001778 RID: 6008
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorInitialMontage
	{
		// Token: 0x06007F31 RID: 32561 RVA: 0x001302BC File Offset: 0x0012E4BC
		private IActorInitialMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorInitialMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorInitialMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorInitialMontage_SetValue());
			}
			return result;
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x001302F4 File Offset: 0x0012E4F4
		public static IActorInitialMontage Create([Nullable(2)] IActorInitialMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorInitialMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x00130307 File Offset: 0x0012E507
		public static IActorInitialMontage CreateFromSetValue([Nullable(2)] IActorInitialMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorInitialMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x0013031A File Offset: 0x0012E51A
		public IActorInitialMontage_SetValue ToSetValue()
		{
			return new IActorInitialMontage_SetValue
			{
				MontageId = this.MontageId
			};
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x06007F35 RID: 32565 RVA: 0x00130330 File Offset: 0x0012E530
		// (set) Token: 0x06007F36 RID: 32566 RVA: 0x00130391 File Offset: 0x0012E591
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._MontageIdCache = IMontageId.Create(this.FbInstance.MontageId);
				}
				else
				{
					IActorInitialMontage_SetValue pocoInterface = this.PocoInterface;
					this._MontageIdCache = ((pocoInterface != null) ? pocoInterface.MontageId : null);
				}
				return this._MontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
				this._MontageIdInited = false;
			}
		}

		// Token: 0x040050E2 RID: 20706
		[Nullable(2)]
		protected IActorInitialMontage FbInstance;

		// Token: 0x040050E3 RID: 20707
		[Nullable(2)]
		protected IActorInitialMontage_SetValue PocoInterface;

		// Token: 0x040050E4 RID: 20708
		private IMontageId _MontageIdCache;

		// Token: 0x040050E5 RID: 20709
		private bool _MontageIdInited;
	}
}
