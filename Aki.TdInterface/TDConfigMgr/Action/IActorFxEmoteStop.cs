using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018ED RID: 6381
	public class IActorFxEmoteStop : IActorFxEmoteType
	{
		// Token: 0x060085E9 RID: 34281 RVA: 0x0013EFA4 File Offset: 0x0013D1A4
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

		// Token: 0x060085EA RID: 34282 RVA: 0x0013EFDC File Offset: 0x0013D1DC
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

		// Token: 0x060085EB RID: 34283 RVA: 0x0013EFEF File Offset: 0x0013D1EF
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

		// Token: 0x060085EC RID: 34284 RVA: 0x0013F002 File Offset: 0x0013D202
		public new IActorFxEmoteStop_SetValue ToSetValue()
		{
			return new IActorFxEmoteStop_SetValue
			{
				Type = this.Type,
				StopType = this.StopType,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x060085ED RID: 34285 RVA: 0x0013F02D File Offset: 0x0013D22D
		// (set) Token: 0x060085EE RID: 34286 RVA: 0x0013F058 File Offset: 0x0013D258
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

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x060085EF RID: 34287 RVA: 0x0013F066 File Offset: 0x0013D266
		// (set) Token: 0x060085F0 RID: 34288 RVA: 0x0013F08D File Offset: 0x0013D28D
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

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x060085F1 RID: 34289 RVA: 0x0013F09C File Offset: 0x0013D29C
		// (set) Token: 0x060085F2 RID: 34290 RVA: 0x0013F0D6 File Offset: 0x0013D2D6
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

		// Token: 0x04005502 RID: 21762
		[Nullable(2)]
		protected new IActorFxEmoteStop FbInstance;

		// Token: 0x04005503 RID: 21763
		[Nullable(2)]
		protected new IActorFxEmoteStop_SetValue PocoInterface;
	}
}
