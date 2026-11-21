using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001915 RID: 6421
	public class IActorTurnTo : ActionParams
	{
		// Token: 0x060086B5 RID: 34485 RVA: 0x0014068C File Offset: 0x0013E88C
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

		// Token: 0x060086B6 RID: 34486 RVA: 0x001406C4 File Offset: 0x0013E8C4
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

		// Token: 0x060086B7 RID: 34487 RVA: 0x001406D7 File Offset: 0x0013E8D7
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

		// Token: 0x060086B8 RID: 34488 RVA: 0x001406EC File Offset: 0x0013E8EC
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

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x060086B9 RID: 34489 RVA: 0x0014073A File Offset: 0x0013E93A
		// (set) Token: 0x060086BA RID: 34490 RVA: 0x00140765 File Offset: 0x0013E965
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

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x060086BB RID: 34491 RVA: 0x00140773 File Offset: 0x0013E973
		// (set) Token: 0x060086BC RID: 34492 RVA: 0x0014079A File Offset: 0x0013E99A
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

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x060086BD RID: 34493 RVA: 0x001407A8 File Offset: 0x0013E9A8
		// (set) Token: 0x060086BE RID: 34494 RVA: 0x001407E2 File Offset: 0x0013E9E2
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

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x060086BF RID: 34495 RVA: 0x001407F0 File Offset: 0x0013E9F0
		// (set) Token: 0x060086C0 RID: 34496 RVA: 0x0014082A File Offset: 0x0013EA2A
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

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x060086C1 RID: 34497 RVA: 0x00140838 File Offset: 0x0013EA38
		// (set) Token: 0x060086C2 RID: 34498 RVA: 0x00140872 File Offset: 0x0013EA72
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

		// Token: 0x04005562 RID: 21858
		[Nullable(2)]
		protected new IActorTurnTo FbInstance;

		// Token: 0x04005563 RID: 21859
		[Nullable(2)]
		protected IActorTurnTo_SetValue PocoInterface;
	}
}
