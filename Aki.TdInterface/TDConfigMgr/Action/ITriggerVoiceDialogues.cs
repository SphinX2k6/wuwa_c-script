using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002004 RID: 8196
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerVoiceDialogues : IInteractEffect
	{
		// Token: 0x0600B43A RID: 46138 RVA: 0x001A3254 File Offset: 0x001A1454
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

		// Token: 0x0600B43B RID: 46139 RVA: 0x001A328C File Offset: 0x001A148C
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

		// Token: 0x0600B43C RID: 46140 RVA: 0x001A329F File Offset: 0x001A149F
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

		// Token: 0x0600B43D RID: 46141 RVA: 0x001A32B2 File Offset: 0x001A14B2
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

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600B43E RID: 46142 RVA: 0x001A32E9 File Offset: 0x001A14E9
		// (set) Token: 0x0600B43F RID: 46143 RVA: 0x001A3314 File Offset: 0x001A1514
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

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0600B440 RID: 46144 RVA: 0x001A3324 File Offset: 0x001A1524
		// (set) Token: 0x0600B441 RID: 46145 RVA: 0x001A335E File Offset: 0x001A155E
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

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600B442 RID: 46146 RVA: 0x001A336C File Offset: 0x001A156C
		// (set) Token: 0x0600B443 RID: 46147 RVA: 0x001A33CD File Offset: 0x001A15CD
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

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600B444 RID: 46148 RVA: 0x001A33E4 File Offset: 0x001A15E4
		// (set) Token: 0x0600B445 RID: 46149 RVA: 0x001A341E File Offset: 0x001A161E
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

		// Token: 0x04006CA0 RID: 27808
		[Nullable(2)]
		protected new ITriggerVoiceDialogues FbInstance;

		// Token: 0x04006CA1 RID: 27809
		[Nullable(2)]
		protected new ITriggerVoiceDialogues_SetValue PocoInterface;

		// Token: 0x04006CA2 RID: 27810
		private PlayFlow _FlowCache;

		// Token: 0x04006CA3 RID: 27811
		private bool _FlowInited;
	}
}
