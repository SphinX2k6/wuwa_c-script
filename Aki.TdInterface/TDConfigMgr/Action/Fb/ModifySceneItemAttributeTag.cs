using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C3D RID: 11325
	public class ModifySceneItemAttributeTag : ActionParams
	{
		// Token: 0x0600F928 RID: 63784 RVA: 0x0024341C File Offset: 0x0024161C
		public static ModifySceneItemAttributeTag Create(IModifySceneItemAttributeTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ModifySceneItemAttributeTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D5C RID: 19804
		// (get) Token: 0x0600F929 RID: 63785 RVA: 0x0024343B File Offset: 0x0024163B
		public virtual EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x17004D5D RID: 19805
		// (get) Token: 0x0600F92A RID: 63786 RVA: 0x00243448 File Offset: 0x00241648
		public virtual bool IsAddTag
		{
			get
			{
				return this.Instance.IsAddTag;
			}
		}

		// Token: 0x17004D5E RID: 19806
		// (get) Token: 0x0600F92B RID: 63787 RVA: 0x00243458 File Offset: 0x00241658
		public virtual List<int> PerformanceTag
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

		// Token: 0x04008835 RID: 34869
		private IModifySceneItemAttributeTag Instance;

		// Token: 0x04008836 RID: 34870
		private List<int> _PerformanceTagCache;

		// Token: 0x04008837 RID: 34871
		private bool _PerformanceTagInited;
	}
}
