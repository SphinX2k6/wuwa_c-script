using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E3B RID: 3643
	public class BatchBulletCasterComponent : IComponentBase
	{
		// Token: 0x0600527E RID: 21118 RVA: 0x000CBF75 File Offset: 0x000CA175
		public static BatchBulletCasterComponent Create(IBatchBulletCasterComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new BatchBulletCasterComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x0600527F RID: 21119 RVA: 0x000CBF94 File Offset: 0x000CA194
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x000CBFCC File Offset: 0x000CA1CC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06005281 RID: 21121 RVA: 0x000CBFE2 File Offset: 0x000CA1E2
		public virtual string WarningEffect
		{
			get
			{
				return this.Instance.WarningEffect;
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06005282 RID: 21122 RVA: 0x000CBFF0 File Offset: 0x000CA1F0
		public virtual EBatchBulletMovementType? MovementType
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new EBatchBulletMovementType?((EBatchBulletMovementType)this.Instance.MovementType);
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06005283 RID: 21123 RVA: 0x000CC028 File Offset: 0x000CA228
		public virtual List<IPosRot> BulletList
		{
			get
			{
				if (this._BulletListInited)
				{
					return this._BulletListCache;
				}
				this._BulletListInited = true;
				int bulletListLength = this.Instance.BulletListLength;
				this._BulletListCache = new List<IPosRot>(bulletListLength);
				for (int i = 0; i < bulletListLength; i++)
				{
					this._BulletListCache.Add(IPosRot.Create(this.Instance.BulletList(i)));
				}
				return this._BulletListCache;
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06005284 RID: 21124 RVA: 0x000CC094 File Offset: 0x000CA294
		public virtual List<IBatchBulletItem> BatchList
		{
			get
			{
				if (this._BatchListInited)
				{
					return this._BatchListCache;
				}
				this._BatchListInited = true;
				int batchListLength = this.Instance.BatchListLength;
				this._BatchListCache = new List<IBatchBulletItem>(batchListLength);
				for (int i = 0; i < batchListLength; i++)
				{
					this._BatchListCache.Add(IBatchBulletItem.Create(this.Instance.BatchList(i)));
				}
				return this._BatchListCache;
			}
		}

		// Token: 0x04002F1E RID: 12062
		private IBatchBulletCasterComponent Instance;

		// Token: 0x04002F1F RID: 12063
		private List<IPosRot> _BulletListCache;

		// Token: 0x04002F20 RID: 12064
		private bool _BulletListInited;

		// Token: 0x04002F21 RID: 12065
		private List<IBatchBulletItem> _BatchListCache;

		// Token: 0x04002F22 RID: 12066
		private bool _BatchListInited;
	}
}
