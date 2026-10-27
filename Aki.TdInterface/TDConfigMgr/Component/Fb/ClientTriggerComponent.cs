using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D3D RID: 3389
	[NullableContext(1)]
	[Nullable(0)]
	public class ClientTriggerComponent : IComponentBase
	{
		// Token: 0x06004D48 RID: 19784 RVA: 0x000C051A File Offset: 0x000BE71A
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

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x000C053C File Offset: 0x000BE73C
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

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x000C0574 File Offset: 0x000BE774
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x000C058A File Offset: 0x000BE78A
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

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x000C05BE File Offset: 0x000BE7BE
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

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x000C05F2 File Offset: 0x000BE7F2
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

		// Token: 0x04002C50 RID: 11344
		private IClientTriggerComponent Instance;

		// Token: 0x04002C51 RID: 11345
		[Nullable(2)]
		private ITriggerMatchConfig _TriggerMatchCache;

		// Token: 0x04002C52 RID: 11346
		private bool _TriggerMatchInited;

		// Token: 0x04002C53 RID: 11347
		[Nullable(2)]
		private ITriggeredConfig _OnTriggerEnterCache;

		// Token: 0x04002C54 RID: 11348
		private bool _OnTriggerEnterInited;

		// Token: 0x04002C55 RID: 11349
		[Nullable(2)]
		private ITriggeredConfig _OnTriggerExitCache;

		// Token: 0x04002C56 RID: 11350
		private bool _OnTriggerExitInited;
	}
}
