using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A76 RID: 10870
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableEntityLookAt : ActionParams
	{
		// Token: 0x0600EEFB RID: 61179 RVA: 0x0022C339 File Offset: 0x0022A539
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

		// Token: 0x17004BD1 RID: 19409
		// (get) Token: 0x0600EEFC RID: 61180 RVA: 0x0022C358 File Offset: 0x0022A558
		public virtual string Key
		{
			get
			{
				return this.Instance.Key;
			}
		}

		// Token: 0x17004BD2 RID: 19410
		// (get) Token: 0x0600EEFD RID: 61181 RVA: 0x0022C365 File Offset: 0x0022A565
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

		// Token: 0x17004BD3 RID: 19411
		// (get) Token: 0x0600EEFE RID: 61182 RVA: 0x0022C394 File Offset: 0x0022A594
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

		// Token: 0x17004BD4 RID: 19412
		// (get) Token: 0x0600EEFF RID: 61183 RVA: 0x0022C3C8 File Offset: 0x0022A5C8
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

		// Token: 0x0400837A RID: 33658
		private IEnableEntityLookAt Instance;

		// Token: 0x0400837B RID: 33659
		private IDefaultLookAtType _DefaultLookAtTypeCache;

		// Token: 0x0400837C RID: 33660
		private bool _DefaultLookAtTypeInited;

		// Token: 0x0400837D RID: 33661
		[Nullable(2)]
		private ICheckFlowLookAt _OverrideLookAtTypeCache;

		// Token: 0x0400837E RID: 33662
		private bool _OverrideLookAtTypeInited;

		// Token: 0x0400837F RID: 33663
		private List<int> _EntityIdsCache;

		// Token: 0x04008380 RID: 33664
		private bool _EntityIdsInited;
	}
}
