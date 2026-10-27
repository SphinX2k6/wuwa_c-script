using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002980 RID: 10624
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawItemEntity : IResetEntityConfig
	{
		// Token: 0x0600EB5D RID: 60253 RVA: 0x00226DE0 File Offset: 0x00224FE0
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

		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x0600EB5E RID: 60254 RVA: 0x00226DFF File Offset: 0x00224FFF
		public override EResetEntityType Type
		{
			get
			{
				return (EResetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x0600EB5F RID: 60255 RVA: 0x00226E0C File Offset: 0x0022500C
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

		// Token: 0x0400819E RID: 33182
		private IJigsawItemEntity Instance;

		// Token: 0x0400819F RID: 33183
		private List<int> _EntityIdsCache;

		// Token: 0x040081A0 RID: 33184
		private bool _EntityIdsInited;
	}
}
