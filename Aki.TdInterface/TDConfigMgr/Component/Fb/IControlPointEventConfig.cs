using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C2E RID: 3118
	public class IControlPointEventConfig
	{
		// Token: 0x0600476A RID: 18282 RVA: 0x000B3D45 File Offset: 0x000B1F45
		[NullableContext(1)]
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

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600476B RID: 18283 RVA: 0x000B3D64 File Offset: 0x000B1F64
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x000B3D74 File Offset: 0x000B1F74
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> LeftInEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x0600476D RID: 18285 RVA: 0x000B3DF0 File Offset: 0x000B1FF0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> LeftOutEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x000B3E6C File Offset: 0x000B206C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> RightInEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x0600476F RID: 18287 RVA: 0x000B3EE8 File Offset: 0x000B20E8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<ActionInfo> RightOutEventActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x0400288B RID: 10379
		private IControlPointEventConfig Instance;

		// Token: 0x0400288C RID: 10380
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _LeftInEventActionsCache;

		// Token: 0x0400288D RID: 10381
		private bool _LeftInEventActionsInited;

		// Token: 0x0400288E RID: 10382
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _LeftOutEventActionsCache;

		// Token: 0x0400288F RID: 10383
		private bool _LeftOutEventActionsInited;

		// Token: 0x04002890 RID: 10384
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _RightInEventActionsCache;

		// Token: 0x04002891 RID: 10385
		private bool _RightInEventActionsInited;

		// Token: 0x04002892 RID: 10386
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _RightOutEventActionsCache;

		// Token: 0x04002893 RID: 10387
		private bool _RightOutEventActionsInited;
	}
}
