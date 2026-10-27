using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002958 RID: 10584
	[NullableContext(1)]
	[Nullable(0)]
	public class ModifySceneItemAttributeTag : ActionParams
	{
		// Token: 0x0600EAB2 RID: 60082 RVA: 0x00225D64 File Offset: 0x00223F64
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

		// Token: 0x170049C4 RID: 18884
		// (get) Token: 0x0600EAB3 RID: 60083 RVA: 0x00225D83 File Offset: 0x00223F83
		public virtual EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x170049C5 RID: 18885
		// (get) Token: 0x0600EAB4 RID: 60084 RVA: 0x00225D90 File Offset: 0x00223F90
		public virtual bool IsAddTag
		{
			get
			{
				return this.Instance.IsAddTag;
			}
		}

		// Token: 0x170049C6 RID: 18886
		// (get) Token: 0x0600EAB5 RID: 60085 RVA: 0x00225DA0 File Offset: 0x00223FA0
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

		// Token: 0x04008154 RID: 33108
		private IModifySceneItemAttributeTag Instance;

		// Token: 0x04008155 RID: 33109
		private List<int> _PerformanceTagCache;

		// Token: 0x04008156 RID: 33110
		private bool _PerformanceTagInited;
	}
}
