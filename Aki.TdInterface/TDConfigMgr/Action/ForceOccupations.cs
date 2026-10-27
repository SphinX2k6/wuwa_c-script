using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001733 RID: 5939
	[NullableContext(1)]
	[Nullable(0)]
	public class ForceOccupations : ActionParams
	{
		// Token: 0x06007DB5 RID: 32181 RVA: 0x0012D674 File Offset: 0x0012B874
		private ForceOccupations_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ForceOccupations 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ForceOccupations_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ForceOccupations_SetValue());
			}
			return result;
		}

		// Token: 0x06007DB6 RID: 32182 RVA: 0x0012D6AC File Offset: 0x0012B8AC
		public static ForceOccupations Create([Nullable(2)] ForceOccupations instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ForceOccupations
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007DB7 RID: 32183 RVA: 0x0012D6BF File Offset: 0x0012B8BF
		public static ForceOccupations CreateFromSetValue([Nullable(2)] ForceOccupations_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ForceOccupations
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007DB8 RID: 32184 RVA: 0x0012D6D2 File Offset: 0x0012B8D2
		public ForceOccupations_SetValue ToSetValue()
		{
			return new ForceOccupations_SetValue
			{
				OccupationType = this.OccupationType,
				Occupations = this.Occupations
			};
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x06007DB9 RID: 32185 RVA: 0x0012D6F1 File Offset: 0x0012B8F1
		// (set) Token: 0x06007DBA RID: 32186 RVA: 0x0012D71C File Offset: 0x0012B91C
		public virtual EOccupationActionType OccupationType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OccupationType;
				}
				if (this.PocoInterface == null)
				{
					return EOccupationActionType.Request;
				}
				return this.PocoInterface.OccupationType;
			}
			set
			{
				this.GetOrCreatePoco().OccupationType = value;
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x06007DBB RID: 32187 RVA: 0x0012D72A File Offset: 0x0012B92A
		// (set) Token: 0x06007DBC RID: 32188 RVA: 0x0012D751 File Offset: 0x0012B951
		public virtual List<string> Occupations
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Occupations;
				}
				ForceOccupations_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Occupations;
			}
			set
			{
				this.GetOrCreatePoco().Occupations = value;
			}
		}

		// Token: 0x0400502D RID: 20525
		[Nullable(2)]
		protected new ForceOccupations FbInstance;

		// Token: 0x0400502E RID: 20526
		[Nullable(2)]
		protected ForceOccupations_SetValue PocoInterface;
	}
}
