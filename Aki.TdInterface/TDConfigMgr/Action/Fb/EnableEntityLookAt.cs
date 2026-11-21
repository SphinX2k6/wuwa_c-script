using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D6A RID: 11626
	public class EnableEntityLookAt : ActionParams
	{
		// Token: 0x0600FDB1 RID: 64945 RVA: 0x0024A045 File Offset: 0x00248245
		public static EnableEntityLookAt Create(IEnableEntityLookAt? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableEntityLookAt
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F8B RID: 20363
		// (get) Token: 0x0600FDB2 RID: 64946 RVA: 0x0024A064 File Offset: 0x00248264
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17004F8C RID: 20364
		// (get) Token: 0x0600FDB3 RID: 64947 RVA: 0x0024A071 File Offset: 0x00248271
		public virtual IDefaultLookAtType DefaultLookAtType
		{
			get
			{
				if (this._DefaultLookAtTypeInited)
				{
					return this._DefaultLookAtTypeCache;
				}
				this._DefaultLookAtTypeInited = true;
				this._DefaultLookAtTypeCache = ActionReadHelper.ReadEnableEntityLookAt_DefaultLookAtType(this.Instance);
				return this._DefaultLookAtTypeCache;
			}
		}

		// Token: 0x17004F8D RID: 20365
		// (get) Token: 0x0600FDB4 RID: 64948 RVA: 0x0024A0A0 File Offset: 0x002482A0
		[Nullable(2)]
		public virtual ICheckFlowLookAt OverrideLookAtType
		{
			[NullableContext(2)]
			get
			{
				if (this._OverrideLookAtTypeInited)
				{
					return this._OverrideLookAtTypeCache;
				}
				this._OverrideLookAtTypeInited = true;
				this._OverrideLookAtTypeCache = ICheckFlowLookAt.Create(this.Instance.OverrideLookAtType);
				return this._OverrideLookAtTypeCache;
			}
		}

		// Token: 0x17004F8E RID: 20366
		// (get) Token: 0x0600FDB5 RID: 64949 RVA: 0x0024A0D4 File Offset: 0x002482D4
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x04008A7E RID: 35454
		private IEnableEntityLookAt Instance;

		// Token: 0x04008A7F RID: 35455
		private IDefaultLookAtType _DefaultLookAtTypeCache;

		// Token: 0x04008A80 RID: 35456
		private bool _DefaultLookAtTypeInited;

		// Token: 0x04008A81 RID: 35457
		[Nullable(2)]
		private ICheckFlowLookAt _OverrideLookAtTypeCache;

		// Token: 0x04008A82 RID: 35458
		private bool _OverrideLookAtTypeInited;

		// Token: 0x04008A83 RID: 35459
		private List<int> _EntityIdsCache;

		// Token: 0x04008A84 RID: 35460
		private bool _EntityIdsInited;
	}
}
