using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD1 RID: 3025
	[NullableContext(2)]
	[Nullable(0)]
	public class ICableWay : IHookInteractType
	{
		// Token: 0x0600455C RID: 17756 RVA: 0x000B0BB6 File Offset: 0x000AEDB6
		[NullableContext(0)]
		public static ICableWay Create(ICableWay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICableWay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x000B0BD5 File Offset: 0x000AEDD5
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x000B0BE4 File Offset: 0x000AEDE4
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._HookActionsInited)
				{
					return this._HookActionsCache;
				}
				this._HookActionsInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int hookActionsLength = this.Instance.HookActionsLength;
				this._HookActionsCache = new List<ActionInfo>(hookActionsLength);
				for (int i = 0; i < hookActionsLength; i++)
				{
					this._HookActionsCache.Add(ActionInfo.Create(this.Instance.HookActions(i)));
				}
				return this._HookActionsCache;
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x000B0C60 File Offset: 0x000AEE60
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ExitHookActionsInited)
				{
					return this._ExitHookActionsCache;
				}
				this._ExitHookActionsInited = true;
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				int exitHookActionsLength = this.Instance.ExitHookActionsLength;
				this._ExitHookActionsCache = new List<ActionInfo>(exitHookActionsLength);
				for (int i = 0; i < exitHookActionsLength; i++)
				{
					this._ExitHookActionsCache.Add(ActionInfo.Create(this.Instance.ExitHookActions(i)));
				}
				return this._ExitHookActionsCache;
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x000B0CDC File Offset: 0x000AEEDC
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public override List<ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._FinishActionsInited)
				{
					return this._FinishActionsCache;
				}
				this._FinishActionsInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int finishActionsLength = this.Instance.FinishActionsLength;
				this._FinishActionsCache = new List<ActionInfo>(finishActionsLength);
				for (int i = 0; i < finishActionsLength; i++)
				{
					this._FinishActionsCache.Add(ActionInfo.Create(this.Instance.FinishActions(i)));
				}
				return this._FinishActionsCache;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x000B0D56 File Offset: 0x000AEF56
		public override IClientHookActionConfig ClientHookActionConfig
		{
			get
			{
				if (this._ClientHookActionConfigInited)
				{
					return this._ClientHookActionConfigCache;
				}
				this._ClientHookActionConfigInited = true;
				this._ClientHookActionConfigCache = IClientHookActionConfig.Create(this.Instance.ClientHookActionConfig);
				return this._ClientHookActionConfigCache;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x000B0D8A File Offset: 0x000AEF8A
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x040026D2 RID: 9938
		private ICableWay Instance;

		// Token: 0x040026D3 RID: 9939
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040026D4 RID: 9940
		private bool _HookActionsInited;

		// Token: 0x040026D5 RID: 9941
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040026D6 RID: 9942
		private bool _ExitHookActionsInited;

		// Token: 0x040026D7 RID: 9943
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040026D8 RID: 9944
		private bool _FinishActionsInited;

		// Token: 0x040026D9 RID: 9945
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040026DA RID: 9946
		private bool _ClientHookActionConfigInited;
	}
}
