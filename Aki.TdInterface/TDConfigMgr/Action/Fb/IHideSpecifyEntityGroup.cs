using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002794 RID: 10132
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideSpecifyEntityGroup : IHideGroupType
	{
		// Token: 0x0600E189 RID: 57737 RVA: 0x002154AD File Offset: 0x002136AD
		public static IHideSpecifyEntityGroup Create(IHideSpecifyEntityGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideSpecifyEntityGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004423 RID: 17443
		// (get) Token: 0x0600E18A RID: 57738 RVA: 0x002154CC File Offset: 0x002136CC
		public override EHideType Type
		{
			get
			{
				return (EHideType)this.Instance.Type;
			}
		}

		// Token: 0x17004424 RID: 17444
		// (get) Token: 0x0600E18B RID: 57739 RVA: 0x002154DC File Offset: 0x002136DC
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

		// Token: 0x17004425 RID: 17445
		// (get) Token: 0x0600E18C RID: 57740 RVA: 0x00215540 File Offset: 0x00213740
		public virtual bool? ForceClean
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ForceClean);
			}
		}

		// Token: 0x04007D10 RID: 32016
		private IHideSpecifyEntityGroup Instance;

		// Token: 0x04007D11 RID: 32017
		private List<int> _EntityIdsCache;

		// Token: 0x04007D12 RID: 32018
		private bool _EntityIdsInited;
	}
}
