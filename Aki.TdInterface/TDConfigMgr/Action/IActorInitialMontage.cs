using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F9 RID: 6393
	public class IActorInitialMontage
	{
		// Token: 0x06008621 RID: 34337 RVA: 0x0013F51C File Offset: 0x0013D71C
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

		// Token: 0x06008622 RID: 34338 RVA: 0x0013F554 File Offset: 0x0013D754
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

		// Token: 0x06008623 RID: 34339 RVA: 0x0013F567 File Offset: 0x0013D767
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

		// Token: 0x06008624 RID: 34340 RVA: 0x0013F57A File Offset: 0x0013D77A
		public IActorInitialMontage_SetValue ToSetValue()
		{
			return new IActorInitialMontage_SetValue
			{
				MontageId = this.MontageId
			};
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06008625 RID: 34341 RVA: 0x0013F590 File Offset: 0x0013D790
		// (set) Token: 0x06008626 RID: 34342 RVA: 0x0013F5F1 File Offset: 0x0013D7F1
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

		// Token: 0x04005518 RID: 21784
		[Nullable(2)]
		protected IActorInitialMontage FbInstance;

		// Token: 0x04005519 RID: 21785
		[Nullable(2)]
		protected IActorInitialMontage_SetValue PocoInterface;

		// Token: 0x0400551A RID: 21786
		private IMontageId _MontageIdCache;

		// Token: 0x0400551B RID: 21787
		private bool _MontageIdInited;
	}
}
