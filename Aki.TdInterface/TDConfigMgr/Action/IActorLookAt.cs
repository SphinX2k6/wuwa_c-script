using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200177C RID: 6012
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorLookAt : ActionParams
	{
		// Token: 0x06007F47 RID: 32583 RVA: 0x001305CC File Offset: 0x0012E7CC
		private IActorLookAt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorLookAt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorLookAt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorLookAt_SetValue());
			}
			return result;
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x00130604 File Offset: 0x0012E804
		public static IActorLookAt Create([Nullable(2)] IActorLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x00130617 File Offset: 0x0012E817
		public static IActorLookAt CreateFromSetValue([Nullable(2)] IActorLookAt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorLookAt
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x0013062A File Offset: 0x0012E82A
		public IActorLookAt_SetValue ToSetValue()
		{
			return new IActorLookAt_SetValue
			{
				ActorIndex = this.ActorIndex,
				Target = this.Target,
				DelayTime = this.DelayTime,
				LookAtSpeedRate = this.LookAtSpeedRate
			};
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x06007F4B RID: 32587 RVA: 0x00130661 File Offset: 0x0012E861
		// (set) Token: 0x06007F4C RID: 32588 RVA: 0x0013068C File Offset: 0x0012E88C
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

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x06007F4D RID: 32589 RVA: 0x0013069A File Offset: 0x0012E89A
		// (set) Token: 0x06007F4E RID: 32590 RVA: 0x001306C1 File Offset: 0x0012E8C1
		public virtual IActorLookAtData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IActorLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x06007F4F RID: 32591 RVA: 0x001306D0 File Offset: 0x0012E8D0
		// (set) Token: 0x06007F50 RID: 32592 RVA: 0x0013070A File Offset: 0x0012E90A
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x06007F51 RID: 32593 RVA: 0x00130718 File Offset: 0x0012E918
		// (set) Token: 0x06007F52 RID: 32594 RVA: 0x00130752 File Offset: 0x0012E952
		public virtual float? LookAtSpeedRate
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LookAtSpeedRate;
				}
				IActorLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LookAtSpeedRate;
			}
			set
			{
				this.GetOrCreatePoco().LookAtSpeedRate = value;
			}
		}

		// Token: 0x040050F1 RID: 20721
		[Nullable(2)]
		protected new IActorLookAt FbInstance;

		// Token: 0x040050F2 RID: 20722
		[Nullable(2)]
		protected IActorLookAt_SetValue PocoInterface;
	}
}
