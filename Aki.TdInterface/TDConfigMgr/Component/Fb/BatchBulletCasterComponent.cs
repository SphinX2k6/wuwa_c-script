using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D41 RID: 3393
	[NullableContext(1)]
	[Nullable(0)]
	public class BatchBulletCasterComponent : IComponentBase
	{
		// Token: 0x06004D62 RID: 19810 RVA: 0x000C0831 File Offset: 0x000BEA31
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

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06004D63 RID: 19811 RVA: 0x000C0850 File Offset: 0x000BEA50
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

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x000C0888 File Offset: 0x000BEA88
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x000C089E File Offset: 0x000BEA9E
		public virtual string WarningEffect
		{
			get
			{
				return this.Instance.WarningEffect;
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x000C08AC File Offset: 0x000BEAAC
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

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06004D67 RID: 19815 RVA: 0x000C08E4 File Offset: 0x000BEAE4
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

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06004D68 RID: 19816 RVA: 0x000C0950 File Offset: 0x000BEB50
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

		// Token: 0x04002C5E RID: 11358
		private IBatchBulletCasterComponent Instance;

		// Token: 0x04002C5F RID: 11359
		private List<IPosRot> _BulletListCache;

		// Token: 0x04002C60 RID: 11360
		private bool _BulletListInited;

		// Token: 0x04002C61 RID: 11361
		private List<IBatchBulletItem> _BatchListCache;

		// Token: 0x04002C62 RID: 11362
		private bool _BatchListInited;
	}
}
