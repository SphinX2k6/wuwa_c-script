using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002533 RID: 9523
	[NullableContext(2)]
	[Nullable(0)]
	public class IActorFxEmotePlay : IActorFxEmoteType
	{
		// Token: 0x0600D441 RID: 54337 RVA: 0x001F6CE4 File Offset: 0x001F4EE4
		[NullableContext(1)]
		public static IActorFxEmotePlay Create(IActorFxEmotePlay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmotePlay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B9D RID: 15261
		// (get) Token: 0x0600D442 RID: 54338 RVA: 0x001F6D03 File Offset: 0x001F4F03
		public override EActorFxEmoteType Type
		{
			get
			{
				return (EActorFxEmoteType)this.Instance.Type;
			}
		}

		// Token: 0x17003B9E RID: 15262
		// (get) Token: 0x0600D443 RID: 54339 RVA: 0x001F6D10 File Offset: 0x001F4F10
		public virtual long FxEmoteId
		{
			get
			{
				return this.Instance.FxEmoteId;
			}
		}

		// Token: 0x17003B9F RID: 15263
		// (get) Token: 0x0600D444 RID: 54340 RVA: 0x001F6D1D File Offset: 0x001F4F1D
		public virtual IActorFxEmoteOverrideConfig OverrideConfig
		{
			get
			{
				if (this._OverrideConfigInited)
				{
					return this._OverrideConfigCache;
				}
				this._OverrideConfigInited = true;
				this._OverrideConfigCache = IActorFxEmoteOverrideConfig.Create(this.Instance.OverrideConfig);
				return this._OverrideConfigCache;
			}
		}

		// Token: 0x17003BA0 RID: 15264
		// (get) Token: 0x0600D445 RID: 54341 RVA: 0x001F6D54 File Offset: 0x001F4F54
		public virtual float? DelayTime
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.DelayTime);
			}
		}

		// Token: 0x17003BA1 RID: 15265
		// (get) Token: 0x0600D446 RID: 54342 RVA: 0x001F6D8C File Offset: 0x001F4F8C
		public virtual bool? LoopPlay
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.LoopPlay);
			}
		}

		// Token: 0x17003BA2 RID: 15266
		// (get) Token: 0x0600D447 RID: 54343 RVA: 0x001F6DC4 File Offset: 0x001F4FC4
		public virtual bool? KeepPlay
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.KeepPlay);
			}
		}

		// Token: 0x04007447 RID: 29767
		private IActorFxEmotePlay Instance;

		// Token: 0x04007448 RID: 29768
		private IActorFxEmoteOverrideConfig _OverrideConfigCache;

		// Token: 0x04007449 RID: 29769
		private bool _OverrideConfigInited;
	}
}
