using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD2 RID: 3026
	[NullableContext(2)]
	[Nullable(0)]
	public class IFollowerShoot : IHookInteractType
	{
		// Token: 0x06004564 RID: 17764 RVA: 0x000B0D9F File Offset: 0x000AEF9F
		[NullableContext(0)]
		public static IFollowerShoot Create(IFollowerShoot? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowerShoot
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06004565 RID: 17765 RVA: 0x000B0DBE File Offset: 0x000AEFBE
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x000B0DCC File Offset: 0x000AEFCC
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

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06004567 RID: 17767 RVA: 0x000B0E48 File Offset: 0x000AF048
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

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x000B0EC4 File Offset: 0x000AF0C4
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

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x000B0F3E File Offset: 0x000AF13E
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

		// Token: 0x040026DB RID: 9947
		private IFollowerShoot Instance;

		// Token: 0x040026DC RID: 9948
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040026DD RID: 9949
		private bool _HookActionsInited;

		// Token: 0x040026DE RID: 9950
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x040026DF RID: 9951
		private bool _ExitHookActionsInited;

		// Token: 0x040026E0 RID: 9952
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x040026E1 RID: 9953
		private bool _FinishActionsInited;

		// Token: 0x040026E2 RID: 9954
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x040026E3 RID: 9955
		private bool _ClientHookActionConfigInited;
	}
}
