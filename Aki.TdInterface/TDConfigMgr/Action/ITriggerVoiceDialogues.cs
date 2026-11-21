using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200224B RID: 8779
	public class ITriggerVoiceDialogues : IInteractEffect
	{
		// Token: 0x0600BF52 RID: 48978 RVA: 0x001B9818 File Offset: 0x001B7A18
		private ITriggerVoiceDialogues_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerVoiceDialogues 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerVoiceDialogues_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerVoiceDialogues_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF53 RID: 48979 RVA: 0x001B9850 File Offset: 0x001B7A50
		public static ITriggerVoiceDialogues Create([Nullable(2)] ITriggerVoiceDialogues instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerVoiceDialogues
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x001B9863 File Offset: 0x001B7A63
		public static ITriggerVoiceDialogues CreateFromSetValue([Nullable(2)] ITriggerVoiceDialogues_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerVoiceDialogues
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF55 RID: 48981 RVA: 0x001B9876 File Offset: 0x001B7A76
		public new ITriggerVoiceDialogues_SetValue ToSetValue()
		{
			return new ITriggerVoiceDialogues_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime,
				Flow = this.Flow,
				ShowTalker = this.ShowTalker
			};
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x0600BF56 RID: 48982 RVA: 0x001B98AD File Offset: 0x001B7AAD
		// (set) Token: 0x0600BF57 RID: 48983 RVA: 0x001B98D8 File Offset: 0x001B7AD8
		public override EInteractEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractEffectType.ModifyTipText;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003A49 RID: 14921
		// (get) Token: 0x0600BF58 RID: 48984 RVA: 0x001B98E8 File Offset: 0x001B7AE8
		// (set) Token: 0x0600BF59 RID: 48985 RVA: 0x001B9922 File Offset: 0x001B7B22
		public override float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ITriggerVoiceDialogues_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x17003A4A RID: 14922
		// (get) Token: 0x0600BF5A RID: 48986 RVA: 0x001B9930 File Offset: 0x001B7B30
		// (set) Token: 0x0600BF5B RID: 48987 RVA: 0x001B9991 File Offset: 0x001B7B91
		public virtual PlayFlow Flow
		{
			get
			{
				if (this._FlowInited)
				{
					return this._FlowCache;
				}
				this._FlowInited = true;
				if (this.FbInstance != null)
				{
					this._FlowCache = PlayFlow.Create(this.FbInstance.Flow);
				}
				else
				{
					ITriggerVoiceDialogues_SetValue pocoInterface = this.PocoInterface;
					this._FlowCache = ((pocoInterface != null) ? pocoInterface.Flow : null);
				}
				return this._FlowCache;
			}
			set
			{
				this.GetOrCreatePoco().Flow = value;
				this._FlowInited = false;
			}
		}

		// Token: 0x17003A4B RID: 14923
		// (get) Token: 0x0600BF5C RID: 48988 RVA: 0x001B99A8 File Offset: 0x001B7BA8
		// (set) Token: 0x0600BF5D RID: 48989 RVA: 0x001B99E2 File Offset: 0x001B7BE2
		public virtual bool? ShowTalker
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowTalker;
				}
				ITriggerVoiceDialogues_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ShowTalker;
			}
			set
			{
				this.GetOrCreatePoco().ShowTalker = value;
			}
		}

		// Token: 0x040072A3 RID: 29347
		[Nullable(2)]
		protected new ITriggerVoiceDialogues FbInstance;

		// Token: 0x040072A4 RID: 29348
		[Nullable(2)]
		protected new ITriggerVoiceDialogues_SetValue PocoInterface;

		// Token: 0x040072A5 RID: 29349
		private PlayFlow _FlowCache;

		// Token: 0x040072A6 RID: 29350
		private bool _FlowInited;
	}
}
