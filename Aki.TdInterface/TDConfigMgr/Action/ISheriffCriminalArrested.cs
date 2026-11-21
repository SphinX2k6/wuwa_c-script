using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002087 RID: 8327
	public class ISheriffCriminalArrested : ICommonTipType
	{
		// Token: 0x0600B0CF RID: 45263 RVA: 0x0018DC78 File Offset: 0x0018BE78
		private ISheriffCriminalArrested_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISheriffCriminalArrested 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISheriffCriminalArrested_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISheriffCriminalArrested_SetValue());
			}
			return result;
		}

		// Token: 0x0600B0D0 RID: 45264 RVA: 0x0018DCB0 File Offset: 0x0018BEB0
		public static ISheriffCriminalArrested Create([Nullable(2)] ISheriffCriminalArrested instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISheriffCriminalArrested
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B0D1 RID: 45265 RVA: 0x0018DCC3 File Offset: 0x0018BEC3
		public static ISheriffCriminalArrested CreateFromSetValue([Nullable(2)] ISheriffCriminalArrested_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISheriffCriminalArrested
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B0D2 RID: 45266 RVA: 0x0018DCD6 File Offset: 0x0018BED6
		public new ISheriffCriminalArrested_SetValue ToSetValue()
		{
			return new ISheriffCriminalArrested_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x0018DCF5 File Offset: 0x0018BEF5
		// (set) Token: 0x0600B0D4 RID: 45268 RVA: 0x0018DD20 File Offset: 0x0018BF20
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

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600B0D5 RID: 45269 RVA: 0x0018DD2E File Offset: 0x0018BF2E
		// (set) Token: 0x0600B0D6 RID: 45270 RVA: 0x0018DD59 File Offset: 0x0018BF59
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x04006922 RID: 26914
		[Nullable(2)]
		protected new ISheriffCriminalArrested FbInstance;

		// Token: 0x04006923 RID: 26915
		[Nullable(2)]
		protected new ISheriffCriminalArrested_SetValue PocoInterface;
	}
}
