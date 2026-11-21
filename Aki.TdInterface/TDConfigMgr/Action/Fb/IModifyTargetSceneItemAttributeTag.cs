using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C43 RID: 11331
	public class IModifyTargetSceneItemAttributeTag : ModifySceneItemAttributeTag
	{
		// Token: 0x0600F940 RID: 63808 RVA: 0x002436D0 File Offset: 0x002418D0
		public static IModifyTargetSceneItemAttributeTag Create(IModifyTargetSceneItemAttributeTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyTargetSceneItemAttributeTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D68 RID: 19816
		// (get) Token: 0x0600F941 RID: 63809 RVA: 0x002436EF File Offset: 0x002418EF
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004D69 RID: 19817
		// (get) Token: 0x0600F942 RID: 63810 RVA: 0x002436FC File Offset: 0x002418FC
		public override bool IsAddTag
		{
			get
			{
				return this.Instance.IsAddTag;
			}
		}

		// Token: 0x17004D6A RID: 19818
		// (get) Token: 0x0600F943 RID: 63811 RVA: 0x0024370C File Offset: 0x0024190C
		public override List<int> PerformanceTag
		{
			get
			{
				if (this._PerformanceTagInited)
				{
					return this._PerformanceTagCache;
				}
				this._PerformanceTagInited = true;
				int performanceTagLength = this.Instance.PerformanceTagLength;
				this._PerformanceTagCache = new List<int>(performanceTagLength);
				for (int i = 0; i < performanceTagLength; i++)
				{
					this._PerformanceTagCache.Add(this.Instance.PerformanceTag(i));
				}
				return this._PerformanceTagCache;
			}
		}

		// Token: 0x17004D6B RID: 19819
		// (get) Token: 0x0600F944 RID: 63812 RVA: 0x00243770 File Offset: 0x00241970
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

		// Token: 0x04008843 RID: 34883
		private IModifyTargetSceneItemAttributeTag Instance;

		// Token: 0x04008844 RID: 34884
		private List<int> _PerformanceTagCache;

		// Token: 0x04008845 RID: 34885
		private bool _PerformanceTagInited;

		// Token: 0x04008846 RID: 34886
		private List<int> _EntityIdsCache;

		// Token: 0x04008847 RID: 34887
		private bool _EntityIdsInited;
	}
}
