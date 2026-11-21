using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E4D RID: 7757
	public class INearestEntity : ITeleportConfig
	{
		// Token: 0x0600A4EF RID: 42223 RVA: 0x001787F8 File Offset: 0x001769F8
		private INearestEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INearestEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INearestEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INearestEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4F0 RID: 42224 RVA: 0x00178830 File Offset: 0x00176A30
		public static INearestEntity Create([Nullable(2)] INearestEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INearestEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4F1 RID: 42225 RVA: 0x00178843 File Offset: 0x00176A43
		public static INearestEntity CreateFromSetValue([Nullable(2)] INearestEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INearestEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x00178856 File Offset: 0x00176A56
		public new INearestEntity_SetValue ToSetValue()
		{
			return new INearestEntity_SetValue
			{
				Type = this.Type,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600A4F3 RID: 42227 RVA: 0x00178875 File Offset: 0x00176A75
		// (set) Token: 0x0600A4F4 RID: 42228 RVA: 0x001788A0 File Offset: 0x00176AA0
		public override ETeleportType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportType.FixedPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003313 RID: 13075
		// (get) Token: 0x0600A4F5 RID: 42229 RVA: 0x001788AE File Offset: 0x00176AAE
		// (set) Token: 0x0600A4F6 RID: 42230 RVA: 0x001788D5 File Offset: 0x00176AD5
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				INearestEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x040063B1 RID: 25521
		[Nullable(2)]
		protected new INearestEntity FbInstance;

		// Token: 0x040063B2 RID: 25522
		[Nullable(2)]
		protected new INearestEntity_SetValue PocoInterface;
	}
}
