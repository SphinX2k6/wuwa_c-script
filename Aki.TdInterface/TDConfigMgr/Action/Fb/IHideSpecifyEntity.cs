using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200278C RID: 10124
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideSpecifyEntity : IHideRangeType
	{
		// Token: 0x0600E165 RID: 57701 RVA: 0x00214E3D File Offset: 0x0021303D
		public static IHideSpecifyEntity Create(IHideSpecifyEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700440F RID: 17423
		// (get) Token: 0x0600E166 RID: 57702 RVA: 0x00214E5C File Offset: 0x0021305C
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x17004410 RID: 17424
		// (get) Token: 0x0600E167 RID: 57703 RVA: 0x00214E6C File Offset: 0x0021306C
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

		// Token: 0x04007CF2 RID: 31986
		private IHideSpecifyEntity Instance;

		// Token: 0x04007CF3 RID: 31987
		private List<int> _EntityIdsCache;

		// Token: 0x04007CF4 RID: 31988
		private bool _EntityIdsInited;
	}
}
