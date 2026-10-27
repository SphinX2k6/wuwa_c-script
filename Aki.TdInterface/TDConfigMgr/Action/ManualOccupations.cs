using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020D1 RID: 8401
	[NullableContext(1)]
	[Nullable(0)]
	public class ManualOccupations : ActionParams
	{
		// Token: 0x0600B89C RID: 47260 RVA: 0x001AB0B4 File Offset: 0x001A92B4
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

		// Token: 0x0600B89D RID: 47261 RVA: 0x001AB0EC File Offset: 0x001A92EC
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

		// Token: 0x0600B89E RID: 47262 RVA: 0x001AB0FF File Offset: 0x001A92FF
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

		// Token: 0x0600B89F RID: 47263 RVA: 0x001AB112 File Offset: 0x001A9312
		public ManualOccupations_SetValue ToSetValue()
		{
			return new ManualOccupations_SetValue
			{
				OccupationType = this.OccupationType,
				Occupations = this.Occupations
			};
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600B8A0 RID: 47264 RVA: 0x001AB131 File Offset: 0x001A9331
		// (set) Token: 0x0600B8A1 RID: 47265 RVA: 0x001AB15C File Offset: 0x001A935C
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

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600B8A2 RID: 47266 RVA: 0x001AB16A File Offset: 0x001A936A
		// (set) Token: 0x0600B8A3 RID: 47267 RVA: 0x001AB191 File Offset: 0x001A9391
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

		// Token: 0x04006E9C RID: 28316
		[Nullable(2)]
		protected new ManualOccupations FbInstance;

		// Token: 0x04006E9D RID: 28317
		[Nullable(2)]
		protected ManualOccupations_SetValue PocoInterface;
	}
}
