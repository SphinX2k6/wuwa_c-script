using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001794 RID: 6036
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorTurnTo : ActionParams
	{
		// Token: 0x06007FC5 RID: 32709 RVA: 0x0013142C File Offset: 0x0012F62C
		private IActorTurnTo_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorTurnTo 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorTurnTo_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorTurnTo_SetValue());
			}
			return result;
		}

		// Token: 0x06007FC6 RID: 32710 RVA: 0x00131464 File Offset: 0x0012F664
		public static IActorTurnTo Create([Nullable(2)] IActorTurnTo instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorTurnTo
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007FC7 RID: 32711 RVA: 0x00131477 File Offset: 0x0012F677
		public static IActorTurnTo CreateFromSetValue([Nullable(2)] IActorTurnTo_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorTurnTo
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x0013148C File Offset: 0x0012F68C
		public IActorTurnTo_SetValue ToSetValue()
		{
			return new IActorTurnTo_SetValue
			{
				ActorIndex = this.ActorIndex,
				Target = this.Target,
				DelayTime = this.DelayTime,
				UseLookAtForSmallAngle = this.UseLookAtForSmallAngle,
				UpdatePosCache = this.UpdatePosCache
			};
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x06007FC9 RID: 32713 RVA: 0x001314DA File Offset: 0x0012F6DA
		// (set) Token: 0x06007FCA RID: 32714 RVA: 0x00131505 File Offset: 0x0012F705
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

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x06007FCB RID: 32715 RVA: 0x00131513 File Offset: 0x0012F713
		// (set) Token: 0x06007FCC RID: 32716 RVA: 0x0013153A File Offset: 0x0012F73A
		public virtual IActorTurnToData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IActorTurnTo_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x06007FCD RID: 32717 RVA: 0x00131548 File Offset: 0x0012F748
		// (set) Token: 0x06007FCE RID: 32718 RVA: 0x00131582 File Offset: 0x0012F782
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorTurnTo_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x06007FCF RID: 32719 RVA: 0x00131590 File Offset: 0x0012F790
		// (set) Token: 0x06007FD0 RID: 32720 RVA: 0x001315CA File Offset: 0x0012F7CA
		public virtual bool? UseLookAtForSmallAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UseLookAtForSmallAngle;
				}
				IActorTurnTo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UseLookAtForSmallAngle;
			}
			set
			{
				this.GetOrCreatePoco().UseLookAtForSmallAngle = value;
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x06007FD1 RID: 32721 RVA: 0x001315D8 File Offset: 0x0012F7D8
		// (set) Token: 0x06007FD2 RID: 32722 RVA: 0x00131612 File Offset: 0x0012F812
		public virtual bool? UpdatePosCache
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UpdatePosCache;
				}
				IActorTurnTo_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UpdatePosCache;
			}
			set
			{
				this.GetOrCreatePoco().UpdatePosCache = value;
			}
		}

		// Token: 0x0400512C RID: 20780
		[Nullable(2)]
		protected new IActorTurnTo FbInstance;

		// Token: 0x0400512D RID: 20781
		[Nullable(2)]
		protected IActorTurnTo_SetValue PocoInterface;
	}
}
