using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E2D RID: 3629
	[NullableContext(1)]
	[Nullable(0)]
	public class ElementalEffectComponent : IComponentBase
	{
		// Token: 0x06005208 RID: 21000 RVA: 0x000CA182 File Offset: 0x000C8382
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

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x06005209 RID: 21001 RVA: 0x000CA1A4 File Offset: 0x000C83A4
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

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x000CA1DC File Offset: 0x000C83DC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x0600520B RID: 21003 RVA: 0x000CA1F2 File Offset: 0x000C83F2
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

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x000CA221 File Offset: 0x000C8421
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

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x0600520D RID: 21005 RVA: 0x000CA250 File Offset: 0x000C8450
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IElementalMatchActions> OnActiveEffectActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x000CA2CC File Offset: 0x000C84CC
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IElementalMatchActions> OnLoseEffectActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002F3E RID: 12094
		private IElementalEffectComponent Instance;

		// Token: 0x04002F3F RID: 12095
		private IElementalMatchBase _MatchConfigCache;

		// Token: 0x04002F40 RID: 12096
		private bool _MatchConfigInited;

		// Token: 0x04002F41 RID: 12097
		private IElementalRangeTypeBase _RangeCache;

		// Token: 0x04002F42 RID: 12098
		private bool _RangeInited;

		// Token: 0x04002F43 RID: 12099
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IElementalMatchActions> _OnActiveEffectActionsCache;

		// Token: 0x04002F44 RID: 12100
		private bool _OnActiveEffectActionsInited;

		// Token: 0x04002F45 RID: 12101
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IElementalMatchActions> _OnLoseEffectActionsCache;

		// Token: 0x04002F46 RID: 12102
		private bool _OnLoseEffectActionsInited;
	}
}
