using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200176C RID: 5996
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFxEmoteStop : IActorFxEmoteType
	{
		// Token: 0x06007EF9 RID: 32505 RVA: 0x0012FD44 File Offset: 0x0012DF44
		private IActorFxEmoteStop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFxEmoteStop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFxEmoteStop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFxEmoteStop_SetValue());
			}
			return result;
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x0012FD7C File Offset: 0x0012DF7C
		public static IActorFxEmoteStop Create([Nullable(2)] IActorFxEmoteStop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteStop
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x0012FD8F File Offset: 0x0012DF8F
		public static IActorFxEmoteStop CreateFromSetValue([Nullable(2)] IActorFxEmoteStop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFxEmoteStop
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x0012FDA2 File Offset: 0x0012DFA2
		public new IActorFxEmoteStop_SetValue ToSetValue()
		{
			return new IActorFxEmoteStop_SetValue
			{
				Type = this.Type,
				StopType = this.StopType,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x06007EFD RID: 32509 RVA: 0x0012FDCD File Offset: 0x0012DFCD
		// (set) Token: 0x06007EFE RID: 32510 RVA: 0x0012FDF8 File Offset: 0x0012DFF8
		public override EActorFxEmoteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorFxEmoteType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x06007EFF RID: 32511 RVA: 0x0012FE06 File Offset: 0x0012E006
		// (set) Token: 0x06007F00 RID: 32512 RVA: 0x0012FE2D File Offset: 0x0012E02D
		public virtual IActorFxEmoteStopSubType StopType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StopType;
				}
				IActorFxEmoteStop_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StopType;
			}
			set
			{
				this.GetOrCreatePoco().StopType = value;
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x06007F01 RID: 32513 RVA: 0x0012FE3C File Offset: 0x0012E03C
		// (set) Token: 0x06007F02 RID: 32514 RVA: 0x0012FE76 File Offset: 0x0012E076
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorFxEmoteStop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040050CC RID: 20684
		[Nullable(2)]
		protected new IActorFxEmoteStop FbInstance;

		// Token: 0x040050CD RID: 20685
		[Nullable(2)]
		protected new IActorFxEmoteStop_SetValue PocoInterface;
	}
}
