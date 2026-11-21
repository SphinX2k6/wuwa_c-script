using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E2D RID: 3629
	public class IChessmanPickInteraction : IPickInteraction
	{
		// Token: 0x06005235 RID: 21045 RVA: 0x000CB4FA File Offset: 0x000C96FA
		public static IChessmanPickInteraction Create(IChessmanPickInteraction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChessmanPickInteraction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06005236 RID: 21046 RVA: 0x000CB519 File Offset: 0x000C9719
		public override EPickInteraction Type
		{
			get
			{
				return (EPickInteraction)this.Instance.Type;
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x06005237 RID: 21047 RVA: 0x000CB528 File Offset: 0x000C9728
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> CheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._CheckedActionsInited)
				{
					return this._CheckedActionsCache;
				}
				this._CheckedActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int checkedActionsLength = this.Instance.CheckedActionsLength;
				this._CheckedActionsCache = new List<ActionInfo>(checkedActionsLength);
				for (int i = 0; i < checkedActionsLength; i++)
				{
					this._CheckedActionsCache.Add(ActionInfo.Create(this.Instance.CheckedActions(i)));
				}
				return this._CheckedActionsCache;
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x06005238 RID: 21048 RVA: 0x000CB5A4 File Offset: 0x000C97A4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> UncheckedActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._UncheckedActionsInited)
				{
					return this._UncheckedActionsCache;
				}
				this._UncheckedActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int uncheckedActionsLength = this.Instance.UncheckedActionsLength;
				this._UncheckedActionsCache = new List<ActionInfo>(uncheckedActionsLength);
				for (int i = 0; i < uncheckedActionsLength; i++)
				{
					this._UncheckedActionsCache.Add(ActionInfo.Create(this.Instance.UncheckedActions(i)));
				}
				return this._UncheckedActionsCache;
			}
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x06005239 RID: 21049 RVA: 0x000CB61E File Offset: 0x000C981E
		public virtual int TargetChessboard
		{
			get
			{
				return this.Instance.TargetChessboard;
			}
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x0600523A RID: 21050 RVA: 0x000CB62B File Offset: 0x000C982B
		[Nullable(2)]
		public virtual string AvailablePosEffect
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.AvailablePosEffect;
			}
		}

		// Token: 0x04002EF0 RID: 12016
		private IChessmanPickInteraction Instance;

		// Token: 0x04002EF1 RID: 12017
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _CheckedActionsCache;

		// Token: 0x04002EF2 RID: 12018
		private bool _CheckedActionsInited;

		// Token: 0x04002EF3 RID: 12019
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _UncheckedActionsCache;

		// Token: 0x04002EF4 RID: 12020
		private bool _UncheckedActionsInited;
	}
}
