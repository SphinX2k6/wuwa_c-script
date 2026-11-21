using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232E RID: 9006
	public class ManualOccupations : ActionParams
	{
		// Token: 0x0600C414 RID: 50196 RVA: 0x001C1FDC File Offset: 0x001C01DC
		private ManualOccupations_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ManualOccupations 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ManualOccupations_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ManualOccupations_SetValue());
			}
			return result;
		}

		// Token: 0x0600C415 RID: 50197 RVA: 0x001C2014 File Offset: 0x001C0214
		public static ManualOccupations Create([Nullable(2)] ManualOccupations instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ManualOccupations
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C416 RID: 50198 RVA: 0x001C2027 File Offset: 0x001C0227
		public static ManualOccupations CreateFromSetValue([Nullable(2)] ManualOccupations_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ManualOccupations
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C417 RID: 50199 RVA: 0x001C203A File Offset: 0x001C023A
		public ManualOccupations_SetValue ToSetValue()
		{
			return new ManualOccupations_SetValue
			{
				OccupationType = this.OccupationType,
				Occupations = this.Occupations
			};
		}

		// Token: 0x17003B55 RID: 15189
		// (get) Token: 0x0600C418 RID: 50200 RVA: 0x001C2059 File Offset: 0x001C0259
		// (set) Token: 0x0600C419 RID: 50201 RVA: 0x001C2084 File Offset: 0x001C0284
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

		// Token: 0x17003B56 RID: 15190
		// (get) Token: 0x0600C41A RID: 50202 RVA: 0x001C2092 File Offset: 0x001C0292
		// (set) Token: 0x0600C41B RID: 50203 RVA: 0x001C20B9 File Offset: 0x001C02B9
		public virtual List<string> Occupations
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Occupations;
				}
				ManualOccupations_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040074C6 RID: 29894
		[Nullable(2)]
		protected new ManualOccupations FbInstance;

		// Token: 0x040074C7 RID: 29895
		[Nullable(2)]
		protected ManualOccupations_SetValue PocoInterface;
	}
}
