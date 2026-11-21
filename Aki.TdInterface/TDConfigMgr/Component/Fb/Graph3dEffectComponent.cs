using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F42 RID: 3906
	public class Graph3dEffectComponent : IComponentBase
	{
		// Token: 0x060057AF RID: 22447 RVA: 0x000D6B0F File Offset: 0x000D4D0F
		public static Graph3dEffectComponent Create(IGraph3dEffectComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Graph3dEffectComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x060057B0 RID: 22448 RVA: 0x000D6B30 File Offset: 0x000D4D30
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x060057B1 RID: 22449 RVA: 0x000D6B68 File Offset: 0x000D4D68
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x060057B2 RID: 22450 RVA: 0x000D6B7E File Offset: 0x000D4D7E
		public virtual int Graph3dEntityId
		{
			get
			{
				return this.Instance.Graph3dEntityId;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x060057B3 RID: 22451 RVA: 0x000D6B8B File Offset: 0x000D4D8B
		public virtual IFireBoxFishEffect EffectType
		{
			get
			{
				if (this._EffectTypeInited)
				{
					return this._EffectTypeCache;
				}
				this._EffectTypeInited = true;
				this._EffectTypeCache = IFireBoxFishEffect.Create(this.Instance.EffectType);
				return this._EffectTypeCache;
			}
		}

		// Token: 0x04003259 RID: 12889
		private IGraph3dEffectComponent Instance;

		// Token: 0x0400325A RID: 12890
		[Nullable(2)]
		private IFireBoxFishEffect _EffectTypeCache;

		// Token: 0x0400325B RID: 12891
		private bool _EffectTypeInited;
	}
}
