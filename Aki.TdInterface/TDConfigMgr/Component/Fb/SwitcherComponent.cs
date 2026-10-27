using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A58 RID: 2648
	[NullableContext(1)]
	[Nullable(0)]
	public class SwitcherComponent : InteractiveComponent
	{
		// Token: 0x06003CFB RID: 15611 RVA: 0x0009CD20 File Offset: 0x0009AF20
		public static SwitcherComponent Create(ISwitcherComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SwitcherComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06003CFC RID: 15612 RVA: 0x0009CD40 File Offset: 0x0009AF40
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

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06003CFD RID: 15613 RVA: 0x0009CD76 File Offset: 0x0009AF76
		public override string Content
		{
			get
			{
				return this.Instance.Content;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06003CFE RID: 15614 RVA: 0x0009CD83 File Offset: 0x0009AF83
		public override string Icon
		{
			get
			{
				return this.Instance.Icon;
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06003CFF RID: 15615 RVA: 0x0009CD90 File Offset: 0x0009AF90
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06003D00 RID: 15616 RVA: 0x0009CDA8 File Offset: 0x0009AFA8
		public virtual List<ActionInfo> OnActions
		{
			get
			{
				if (this._OnActionsInited)
				{
					return this._OnActionsCache;
				}
				this._OnActionsInited = true;
				int onActionsLength = this.Instance.OnActionsLength;
				this._OnActionsCache = new List<ActionInfo>(onActionsLength);
				for (int i = 0; i < onActionsLength; i++)
				{
					this._OnActionsCache.Add(ActionInfo.Create(this.Instance.OnActions(i)));
				}
				return this._OnActionsCache;
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003D01 RID: 15617 RVA: 0x0009CE14 File Offset: 0x0009B014
		public virtual List<ActionInfo> OffActions
		{
			get
			{
				if (this._OffActionsInited)
				{
					return this._OffActionsCache;
				}
				this._OffActionsInited = true;
				int offActionsLength = this.Instance.OffActionsLength;
				this._OffActionsCache = new List<ActionInfo>(offActionsLength);
				for (int i = 0; i < offActionsLength; i++)
				{
					this._OffActionsCache.Add(ActionInfo.Create(this.Instance.OffActions(i)));
				}
				return this._OffActionsCache;
			}
		}

		// Token: 0x040021FB RID: 8699
		private ISwitcherComponent Instance;

		// Token: 0x040021FC RID: 8700
		private List<ActionInfo> _OnActionsCache;

		// Token: 0x040021FD RID: 8701
		private bool _OnActionsInited;

		// Token: 0x040021FE RID: 8702
		private List<ActionInfo> _OffActionsCache;

		// Token: 0x040021FF RID: 8703
		private bool _OffActionsInited;
	}
}
