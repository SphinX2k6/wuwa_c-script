using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C66 RID: 11366
	public class IJigsawItemEntity : IResetEntityConfig
	{
		// Token: 0x0600F9D8 RID: 63960 RVA: 0x00244538 File Offset: 0x00242738
		public static IJigsawItemEntity Create(IJigsawItemEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawItemEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DBA RID: 19898
		// (get) Token: 0x0600F9D9 RID: 63961 RVA: 0x00244557 File Offset: 0x00242757
		public override EResetEntityType Type
		{
			get
			{
				return (EResetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004DBB RID: 19899
		// (get) Token: 0x0600F9DA RID: 63962 RVA: 0x00244564 File Offset: 0x00242764
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

		// Token: 0x04008882 RID: 34946
		private IJigsawItemEntity Instance;

		// Token: 0x04008883 RID: 34947
		private List<int> _EntityIdsCache;

		// Token: 0x04008884 RID: 34948
		private bool _EntityIdsInited;
	}
}
