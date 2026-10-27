using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001746 RID: 5958
	[NullableContext(1)]
	[Nullable(0)]
	public class HideTargetRange : ActionParams
	{
		// Token: 0x06007E17 RID: 32279 RVA: 0x0012E170 File Offset: 0x0012C370
		private HideTargetRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("HideTargetRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			HideTargetRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new HideTargetRange_SetValue());
			}
			return result;
		}

		// Token: 0x06007E18 RID: 32280 RVA: 0x0012E1A8 File Offset: 0x0012C3A8
		public static HideTargetRange Create([Nullable(2)] HideTargetRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new HideTargetRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007E19 RID: 32281 RVA: 0x0012E1BB File Offset: 0x0012C3BB
		public static HideTargetRange CreateFromSetValue([Nullable(2)] HideTargetRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new HideTargetRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007E1A RID: 32282 RVA: 0x0012E1CE File Offset: 0x0012C3CE
		public HideTargetRange_SetValue ToSetValue()
		{
			return new HideTargetRange_SetValue
			{
				RangeEntity = this.RangeEntity,
				HideConfig = this.HideConfig,
				IsHideSimpleNpc = this.IsHideSimpleNpc,
				IsHidePasserByNpc = this.IsHidePasserByNpc
			};
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x06007E1B RID: 32283 RVA: 0x0012E205 File Offset: 0x0012C405
		// (set) Token: 0x06007E1C RID: 32284 RVA: 0x0012E230 File Offset: 0x0012C430
		public virtual int RangeEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.RangeEntity;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntity = value;
			}
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x06007E1D RID: 32285 RVA: 0x0012E23E File Offset: 0x0012C43E
		// (set) Token: 0x06007E1E RID: 32286 RVA: 0x0012E265 File Offset: 0x0012C465
		public virtual IHideRangeType HideConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideConfig;
				}
				HideTargetRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideConfig;
			}
			set
			{
				this.GetOrCreatePoco().HideConfig = value;
			}
		}

		// Token: 0x17002978 RID: 10616
		// (get) Token: 0x06007E1F RID: 32287 RVA: 0x0012E274 File Offset: 0x0012C474
		// (set) Token: 0x06007E20 RID: 32288 RVA: 0x0012E2AE File Offset: 0x0012C4AE
		public virtual bool? IsHideSimpleNpc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsHideSimpleNpc;
				}
				HideTargetRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsHideSimpleNpc;
			}
			set
			{
				this.GetOrCreatePoco().IsHideSimpleNpc = value;
			}
		}

		// Token: 0x17002979 RID: 10617
		// (get) Token: 0x06007E21 RID: 32289 RVA: 0x0012E2BC File Offset: 0x0012C4BC
		// (set) Token: 0x06007E22 RID: 32290 RVA: 0x0012E2F6 File Offset: 0x0012C4F6
		public virtual bool? IsHidePasserByNpc
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsHidePasserByNpc;
				}
				HideTargetRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsHidePasserByNpc;
			}
			set
			{
				this.GetOrCreatePoco().IsHidePasserByNpc = value;
			}
		}

		// Token: 0x0400505B RID: 20571
		[Nullable(2)]
		protected new HideTargetRange FbInstance;

		// Token: 0x0400505C RID: 20572
		[Nullable(2)]
		protected HideTargetRange_SetValue PocoInterface;
	}
}
