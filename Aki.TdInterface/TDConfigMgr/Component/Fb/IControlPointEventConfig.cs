using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D01 RID: 3329
	public class IControlPointEventConfig
	{
		// Token: 0x06004BDA RID: 19418 RVA: 0x000BE0F5 File Offset: 0x000BC2F5
		public static IControlPointEventConfig Create(IControlPointEventConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlPointEventConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06004BDB RID: 19419 RVA: 0x000BE114 File Offset: 0x000BC314
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06004BDC RID: 19420 RVA: 0x000BE124 File Offset: 0x000BC324
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> LeftInEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LeftInEventActionsInited)
				{
					return this._LeftInEventActionsCache;
				}
				this._LeftInEventActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int leftInEventActionsLength = this.Instance.LeftInEventActionsLength;
				this._LeftInEventActionsCache = new List<ActionInfo>(leftInEventActionsLength);
				for (int i = 0; i < leftInEventActionsLength; i++)
				{
					this._LeftInEventActionsCache.Add(ActionInfo.Create(this.Instance.LeftInEventActions(i)));
				}
				return this._LeftInEventActionsCache;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06004BDD RID: 19421 RVA: 0x000BE1A0 File Offset: 0x000BC3A0
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> LeftOutEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._LeftOutEventActionsInited)
				{
					return this._LeftOutEventActionsCache;
				}
				this._LeftOutEventActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int leftOutEventActionsLength = this.Instance.LeftOutEventActionsLength;
				this._LeftOutEventActionsCache = new List<ActionInfo>(leftOutEventActionsLength);
				for (int i = 0; i < leftOutEventActionsLength; i++)
				{
					this._LeftOutEventActionsCache.Add(ActionInfo.Create(this.Instance.LeftOutEventActions(i)));
				}
				return this._LeftOutEventActionsCache;
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06004BDE RID: 19422 RVA: 0x000BE21C File Offset: 0x000BC41C
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> RightInEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._RightInEventActionsInited)
				{
					return this._RightInEventActionsCache;
				}
				this._RightInEventActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int rightInEventActionsLength = this.Instance.RightInEventActionsLength;
				this._RightInEventActionsCache = new List<ActionInfo>(rightInEventActionsLength);
				for (int i = 0; i < rightInEventActionsLength; i++)
				{
					this._RightInEventActionsCache.Add(ActionInfo.Create(this.Instance.RightInEventActions(i)));
				}
				return this._RightInEventActionsCache;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06004BDF RID: 19423 RVA: 0x000BE298 File Offset: 0x000BC498
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<ActionInfo> RightOutEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._RightOutEventActionsInited)
				{
					return this._RightOutEventActionsCache;
				}
				this._RightOutEventActionsInited = true;
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				int rightOutEventActionsLength = this.Instance.RightOutEventActionsLength;
				this._RightOutEventActionsCache = new List<ActionInfo>(rightOutEventActionsLength);
				for (int i = 0; i < rightOutEventActionsLength; i++)
				{
					this._RightOutEventActionsCache.Add(ActionInfo.Create(this.Instance.RightOutEventActions(i)));
				}
				return this._RightOutEventActionsCache;
			}
		}

		// Token: 0x04002AE0 RID: 10976
		private IControlPointEventConfig Instance;

		// Token: 0x04002AE1 RID: 10977
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _LeftInEventActionsCache;

		// Token: 0x04002AE2 RID: 10978
		private bool _LeftInEventActionsInited;

		// Token: 0x04002AE3 RID: 10979
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _LeftOutEventActionsCache;

		// Token: 0x04002AE4 RID: 10980
		private bool _LeftOutEventActionsInited;

		// Token: 0x04002AE5 RID: 10981
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _RightInEventActionsCache;

		// Token: 0x04002AE6 RID: 10982
		private bool _RightInEventActionsInited;

		// Token: 0x04002AE7 RID: 10983
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _RightOutEventActionsCache;

		// Token: 0x04002AE8 RID: 10984
		private bool _RightOutEventActionsInited;
	}
}
