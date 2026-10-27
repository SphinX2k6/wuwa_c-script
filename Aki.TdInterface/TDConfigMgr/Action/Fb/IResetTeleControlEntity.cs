using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200297F RID: 10623
	[NullableContext(1)]
	[Nullable(0)]
	public class IResetTeleControlEntity : IResetEntityConfig
	{
		// Token: 0x0600EB59 RID: 60249 RVA: 0x00226D46 File Offset: 0x00224F46
		public static IResetTeleControlEntity Create(IResetTeleControlEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetTeleControlEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x0600EB5A RID: 60250 RVA: 0x00226D65 File Offset: 0x00224F65
		public override EResetEntityType Type
		{
			get
			{
				return (EResetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x0600EB5B RID: 60251 RVA: 0x00226D74 File Offset: 0x00224F74
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

		// Token: 0x0400819B RID: 33179
		private IResetTeleControlEntity Instance;

		// Token: 0x0400819C RID: 33180
		private List<int> _EntityIdsCache;

		// Token: 0x0400819D RID: 33181
		private bool _EntityIdsInited;
	}
}
