using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AF2 RID: 2802
	[NullableContext(2)]
	[Nullable(0)]
	public class IFixedPointHook : IHookInteractType
	{
		// Token: 0x0600407E RID: 16510 RVA: 0x000A4BE6 File Offset: 0x000A2DE6
		[NullableContext(1)]
		public static IFixedPointHook Create(IFixedPointHook? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedPointHook
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x0600407F RID: 16511 RVA: 0x000A4C05 File Offset: 0x000A2E05
		public override EHookInteractType Type
		{
			get
			{
				return (EHookInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x000A4C14 File Offset: 0x000A2E14
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> HookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06004081 RID: 16513 RVA: 0x000A4C90 File Offset: 0x000A2E90
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> ExitHookActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06004082 RID: 16514 RVA: 0x000A4D0C File Offset: 0x000A2F0C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<ActionInfo> FinishActions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06004083 RID: 16515 RVA: 0x000A4D86 File Offset: 0x000A2F86
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

		// Token: 0x040023FD RID: 9213
		private IFixedPointHook Instance;

		// Token: 0x040023FE RID: 9214
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _HookActionsCache;

		// Token: 0x040023FF RID: 9215
		private bool _HookActionsInited;

		// Token: 0x04002400 RID: 9216
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _ExitHookActionsCache;

		// Token: 0x04002401 RID: 9217
		private bool _ExitHookActionsInited;

		// Token: 0x04002402 RID: 9218
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ActionInfo> _FinishActionsCache;

		// Token: 0x04002403 RID: 9219
		private bool _FinishActionsInited;

		// Token: 0x04002404 RID: 9220
		private IClientHookActionConfig _ClientHookActionConfigCache;

		// Token: 0x04002405 RID: 9221
		private bool _ClientHookActionConfigInited;
	}
}
