using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C42 RID: 11330
	public class IModifySelfSceneItemAttributeTag : ModifySceneItemAttributeTag
	{
		// Token: 0x0600F93B RID: 63803 RVA: 0x00243628 File Offset: 0x00241828
		public static IModifySelfSceneItemAttributeTag Create(IModifySelfSceneItemAttributeTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifySelfSceneItemAttributeTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D65 RID: 19813
		// (get) Token: 0x0600F93C RID: 63804 RVA: 0x00243647 File Offset: 0x00241847
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004D66 RID: 19814
		// (get) Token: 0x0600F93D RID: 63805 RVA: 0x00243654 File Offset: 0x00241854
		public override bool IsAddTag
		{
			get
			{
				return this.Instance.IsAddTag;
			}
		}

		// Token: 0x17004D67 RID: 19815
		// (get) Token: 0x0600F93E RID: 63806 RVA: 0x00243664 File Offset: 0x00241864
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

		// Token: 0x04008840 RID: 34880
		private IModifySelfSceneItemAttributeTag Instance;

		// Token: 0x04008841 RID: 34881
		private List<int> _PerformanceTagCache;

		// Token: 0x04008842 RID: 34882
		private bool _PerformanceTagInited;
	}
}
