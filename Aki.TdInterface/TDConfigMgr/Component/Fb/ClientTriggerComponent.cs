using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E37 RID: 3639
	public class ClientTriggerComponent : IComponentBase
	{
		// Token: 0x06005264 RID: 21092 RVA: 0x000CBC5E File Offset: 0x000C9E5E
		public static ClientTriggerComponent Create(IClientTriggerComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ClientTriggerComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x000CBC80 File Offset: 0x000C9E80
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

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06005266 RID: 21094 RVA: 0x000CBCB8 File Offset: 0x000C9EB8
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x000CBCCE File Offset: 0x000C9ECE
		public virtual ITriggerMatchConfig TriggerMatch
		{
			get
			{
				if (this._TriggerMatchInited)
				{
					return this._TriggerMatchCache;
				}
				this._TriggerMatchInited = true;
				this._TriggerMatchCache = ITriggerMatchConfig.Create(this.Instance.TriggerMatch);
				return this._TriggerMatchCache;
			}
		}

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06005268 RID: 21096 RVA: 0x000CBD02 File Offset: 0x000C9F02
		public virtual ITriggeredConfig OnTriggerEnter
		{
			get
			{
				if (this._OnTriggerEnterInited)
				{
					return this._OnTriggerEnterCache;
				}
				this._OnTriggerEnterInited = true;
				this._OnTriggerEnterCache = ITriggeredConfig.Create(this.Instance.OnTriggerEnter);
				return this._OnTriggerEnterCache;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x000CBD36 File Offset: 0x000C9F36
		public virtual ITriggeredConfig OnTriggerExit
		{
			get
			{
				if (this._OnTriggerExitInited)
				{
					return this._OnTriggerExitCache;
				}
				this._OnTriggerExitInited = true;
				this._OnTriggerExitCache = ITriggeredConfig.Create(this.Instance.OnTriggerExit);
				return this._OnTriggerExitCache;
			}
		}

		// Token: 0x04002F10 RID: 12048
		private IClientTriggerComponent Instance;

		// Token: 0x04002F11 RID: 12049
		[Nullable(2)]
		private ITriggerMatchConfig _TriggerMatchCache;

		// Token: 0x04002F12 RID: 12050
		private bool _TriggerMatchInited;

		// Token: 0x04002F13 RID: 12051
		[Nullable(2)]
		private ITriggeredConfig _OnTriggerEnterCache;

		// Token: 0x04002F14 RID: 12052
		private bool _OnTriggerEnterInited;

		// Token: 0x04002F15 RID: 12053
		[Nullable(2)]
		private ITriggeredConfig _OnTriggerExitCache;

		// Token: 0x04002F16 RID: 12054
		private bool _OnTriggerExitInited;
	}
}
