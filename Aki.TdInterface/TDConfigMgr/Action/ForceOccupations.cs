using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018B2 RID: 6322
	public class ForceOccupations : ActionParams
	{
		// Token: 0x0600849D RID: 33949 RVA: 0x0013C81C File Offset: 0x0013AA1C
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

		// Token: 0x0600849E RID: 33950 RVA: 0x0013C854 File Offset: 0x0013AA54
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

		// Token: 0x0600849F RID: 33951 RVA: 0x0013C867 File Offset: 0x0013AA67
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

		// Token: 0x060084A0 RID: 33952 RVA: 0x0013C87A File Offset: 0x0013AA7A
		public ForceOccupations_SetValue ToSetValue()
		{
			return new ForceOccupations_SetValue
			{
				OccupationType = this.OccupationType,
				Occupations = this.Occupations
			};
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x060084A1 RID: 33953 RVA: 0x0013C899 File Offset: 0x0013AA99
		// (set) Token: 0x060084A2 RID: 33954 RVA: 0x0013C8C4 File Offset: 0x0013AAC4
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

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x060084A3 RID: 33955 RVA: 0x0013C8D2 File Offset: 0x0013AAD2
		// (set) Token: 0x060084A4 RID: 33956 RVA: 0x0013C8F9 File Offset: 0x0013AAF9
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

		// Token: 0x04005460 RID: 21600
		[Nullable(2)]
		protected new ForceOccupations FbInstance;

		// Token: 0x04005461 RID: 21601
		[Nullable(2)]
		protected ForceOccupations_SetValue PocoInterface;
	}
}
