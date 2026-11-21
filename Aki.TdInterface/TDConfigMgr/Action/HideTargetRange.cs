using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C7 RID: 6343
	public class HideTargetRange : ActionParams
	{
		// Token: 0x06008507 RID: 34055 RVA: 0x0013D3D0 File Offset: 0x0013B5D0
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

		// Token: 0x06008508 RID: 34056 RVA: 0x0013D408 File Offset: 0x0013B608
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

		// Token: 0x06008509 RID: 34057 RVA: 0x0013D41B File Offset: 0x0013B61B
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

		// Token: 0x0600850A RID: 34058 RVA: 0x0013D42E File Offset: 0x0013B62E
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

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x0600850B RID: 34059 RVA: 0x0013D465 File Offset: 0x0013B665
		// (set) Token: 0x0600850C RID: 34060 RVA: 0x0013D490 File Offset: 0x0013B690
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

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x0013D49E File Offset: 0x0013B69E
		// (set) Token: 0x0600850E RID: 34062 RVA: 0x0013D4C5 File Offset: 0x0013B6C5
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

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x0600850F RID: 34063 RVA: 0x0013D4D4 File Offset: 0x0013B6D4
		// (set) Token: 0x06008510 RID: 34064 RVA: 0x0013D50E File Offset: 0x0013B70E
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

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x06008511 RID: 34065 RVA: 0x0013D51C File Offset: 0x0013B71C
		// (set) Token: 0x06008512 RID: 34066 RVA: 0x0013D556 File Offset: 0x0013B756
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

		// Token: 0x04005491 RID: 21649
		[Nullable(2)]
		protected new HideTargetRange FbInstance;

		// Token: 0x04005492 RID: 21650
		[Nullable(2)]
		protected HideTargetRange_SetValue PocoInterface;
	}
}
