using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200295E RID: 10590
	[NullableContext(1)]
	[Nullable(0)]
	public class IModifyTargetSceneItemAttributeTag : ModifySceneItemAttributeTag
	{
		// Token: 0x0600EACA RID: 60106 RVA: 0x00226018 File Offset: 0x00224218
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

		// Token: 0x170049D0 RID: 18896
		// (get) Token: 0x0600EACB RID: 60107 RVA: 0x00226037 File Offset: 0x00224237
		public override EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				return (EChangeEntityPrefabPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x170049D1 RID: 18897
		// (get) Token: 0x0600EACC RID: 60108 RVA: 0x00226044 File Offset: 0x00224244
		public override bool IsAddTag
		{
			get
			{
				return this.Instance.IsAddTag;
			}
		}

		// Token: 0x170049D2 RID: 18898
		// (get) Token: 0x0600EACD RID: 60109 RVA: 0x00226054 File Offset: 0x00224254
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

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x0600EACE RID: 60110 RVA: 0x002260B8 File Offset: 0x002242B8
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

		// Token: 0x04008162 RID: 33122
		private IModifyTargetSceneItemAttributeTag Instance;

		// Token: 0x04008163 RID: 33123
		private List<int> _PerformanceTagCache;

		// Token: 0x04008164 RID: 33124
		private bool _PerformanceTagInited;

		// Token: 0x04008165 RID: 33125
		private List<int> _EntityIdsCache;

		// Token: 0x04008166 RID: 33126
		private bool _EntityIdsInited;
	}
}
