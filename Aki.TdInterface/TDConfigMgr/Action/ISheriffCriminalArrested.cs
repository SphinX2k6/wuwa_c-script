using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E52 RID: 7762
	[NullableContext(1)]
	[Nullable(0)]
	public class ISheriffCriminalArrested : ICommonTipType
	{
		// Token: 0x0600A617 RID: 42519 RVA: 0x00177F78 File Offset: 0x00176178
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

		// Token: 0x0600A618 RID: 42520 RVA: 0x00177FB0 File Offset: 0x001761B0
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

		// Token: 0x0600A619 RID: 42521 RVA: 0x00177FC3 File Offset: 0x001761C3
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

		// Token: 0x0600A61A RID: 42522 RVA: 0x00177FD6 File Offset: 0x001761D6
		public new ISheriffCriminalArrested_SetValue ToSetValue()
		{
			return new ISheriffCriminalArrested_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x170032E7 RID: 13031
		// (get) Token: 0x0600A61B RID: 42523 RVA: 0x00177FF5 File Offset: 0x001761F5
		// (set) Token: 0x0600A61C RID: 42524 RVA: 0x00178020 File Offset: 0x00176220
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

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600A61D RID: 42525 RVA: 0x0017802E File Offset: 0x0017622E
		// (set) Token: 0x0600A61E RID: 42526 RVA: 0x00178059 File Offset: 0x00176259
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

		// Token: 0x0400633E RID: 25406
		[Nullable(2)]
		protected new ISheriffCriminalArrested FbInstance;

		// Token: 0x0400633F RID: 25407
		[Nullable(2)]
		protected new ISheriffCriminalArrested_SetValue PocoInterface;
	}
}
