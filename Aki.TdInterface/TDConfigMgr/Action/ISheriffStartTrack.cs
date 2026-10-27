using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E56 RID: 7766
	[NullableContext(1)]
	[Nullable(0)]
	public class ISheriffStartTrack : ICommonTipType
	{
		// Token: 0x0600A62B RID: 42539 RVA: 0x00178178 File Offset: 0x00176378
		private ISheriffStartTrack_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISheriffStartTrack 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISheriffStartTrack_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISheriffStartTrack_SetValue());
			}
			return result;
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x001781B0 File Offset: 0x001763B0
		public static ISheriffStartTrack Create([Nullable(2)] ISheriffStartTrack instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffStartTrack
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x001781C3 File Offset: 0x001763C3
		public static ISheriffStartTrack CreateFromSetValue([Nullable(2)] ISheriffStartTrack_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISheriffStartTrack
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x001781D6 File Offset: 0x001763D6
		public new ISheriffStartTrack_SetValue ToSetValue()
		{
			return new ISheriffStartTrack_SetValue
			{
				Type = this.Type,
				AnomalyId = this.AnomalyId
			};
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600A62F RID: 42543 RVA: 0x001781F5 File Offset: 0x001763F5
		// (set) Token: 0x0600A630 RID: 42544 RVA: 0x00178220 File Offset: 0x00176420
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032EC RID: 13036
		// (get) Token: 0x0600A631 RID: 42545 RVA: 0x0017822E File Offset: 0x0017642E
		// (set) Token: 0x0600A632 RID: 42546 RVA: 0x00178259 File Offset: 0x00176459
		public virtual int AnomalyId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AnomalyId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AnomalyId;
			}
			set
			{
				this.GetOrCreatePoco().AnomalyId = value;
			}
		}

		// Token: 0x04006346 RID: 25414
		[Nullable(2)]
		protected new ISheriffStartTrack FbInstance;

		// Token: 0x04006347 RID: 25415
		[Nullable(2)]
		protected new ISheriffStartTrack_SetValue PocoInterface;
	}
}
