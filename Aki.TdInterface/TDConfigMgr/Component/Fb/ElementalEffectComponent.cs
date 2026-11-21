using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F29 RID: 3881
	public class ElementalEffectComponent : IComponentBase
	{
		// Token: 0x0600572F RID: 22319 RVA: 0x000D5A4A File Offset: 0x000D3C4A
		public static ElementalEffectComponent Create(IElementalEffectComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ElementalEffectComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06005730 RID: 22320 RVA: 0x000D5A6C File Offset: 0x000D3C6C
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

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06005731 RID: 22321 RVA: 0x000D5AA4 File Offset: 0x000D3CA4
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06005732 RID: 22322 RVA: 0x000D5ABA File Offset: 0x000D3CBA
		public virtual IElementalMatchBase MatchConfig
		{
			get
			{
				if (this._MatchConfigInited)
				{
					return this._MatchConfigCache;
				}
				this._MatchConfigInited = true;
				this._MatchConfigCache = ComponentReadHelper.ReadElementalEffectComponent_MatchConfig(this.Instance);
				return this._MatchConfigCache;
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06005733 RID: 22323 RVA: 0x000D5AE9 File Offset: 0x000D3CE9
		public virtual IElementalRangeTypeBase Range
		{
			get
			{
				if (this._RangeInited)
				{
					return this._RangeCache;
				}
				this._RangeInited = true;
				this._RangeCache = ComponentReadHelper.ReadElementalEffectComponent_Range(this.Instance);
				return this._RangeCache;
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06005734 RID: 22324 RVA: 0x000D5B18 File Offset: 0x000D3D18
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IElementalMatchActions> OnActiveEffectActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._OnActiveEffectActionsInited)
				{
					return this._OnActiveEffectActionsCache;
				}
				this._OnActiveEffectActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int onActiveEffectActionsLength = this.Instance.OnActiveEffectActionsLength;
				this._OnActiveEffectActionsCache = new List<IElementalMatchActions>(onActiveEffectActionsLength);
				for (int i = 0; i < onActiveEffectActionsLength; i++)
				{
					this._OnActiveEffectActionsCache.Add(IElementalMatchActions.Create(this.Instance.OnActiveEffectActions(i)));
				}
				return this._OnActiveEffectActionsCache;
			}
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x000D5B94 File Offset: 0x000D3D94
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IElementalMatchActions> OnLoseEffectActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._OnLoseEffectActionsInited)
				{
					return this._OnLoseEffectActionsCache;
				}
				this._OnLoseEffectActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int onLoseEffectActionsLength = this.Instance.OnLoseEffectActionsLength;
				this._OnLoseEffectActionsCache = new List<IElementalMatchActions>(onLoseEffectActionsLength);
				for (int i = 0; i < onLoseEffectActionsLength; i++)
				{
					this._OnLoseEffectActionsCache.Add(IElementalMatchActions.Create(this.Instance.OnLoseEffectActions(i)));
				}
				return this._OnLoseEffectActionsCache;
			}
		}

		// Token: 0x04003206 RID: 12806
		private IElementalEffectComponent Instance;

		// Token: 0x04003207 RID: 12807
		private IElementalMatchBase _MatchConfigCache;

		// Token: 0x04003208 RID: 12808
		private bool _MatchConfigInited;

		// Token: 0x04003209 RID: 12809
		private IElementalRangeTypeBase _RangeCache;

		// Token: 0x0400320A RID: 12810
		private bool _RangeInited;

		// Token: 0x0400320B RID: 12811
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IElementalMatchActions> _OnActiveEffectActionsCache;

		// Token: 0x0400320C RID: 12812
		private bool _OnActiveEffectActionsInited;

		// Token: 0x0400320D RID: 12813
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IElementalMatchActions> _OnLoseEffectActionsCache;

		// Token: 0x0400320E RID: 12814
		private bool _OnLoseEffectActionsInited;
	}
}
