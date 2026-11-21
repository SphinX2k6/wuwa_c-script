using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000017 RID: 23
	public class AiAlertNotifyComponent : IComponentBase
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00014F74 File Offset: 0x00013174
		private AiAlertNotifyComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("AiAlertNotifyComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			AiAlertNotifyComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new AiAlertNotifyComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00014FAC File Offset: 0x000131AC
		public static AiAlertNotifyComponent Create([Nullable(2)] AiAlertNotifyComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new AiAlertNotifyComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00014FBF File Offset: 0x000131BF
		public static AiAlertNotifyComponent CreateFromSetValue([Nullable(2)] AiAlertNotifyComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new AiAlertNotifyComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00014FD4 File Offset: 0x000131D4
		public new AiAlertNotifyComponent_SetValue ToSetValue()
		{
			return new AiAlertNotifyComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				ExtraAiAlert = this.ExtraAiAlert,
				ExcludeEntities = this.ExcludeEntities,
				AlertSound = this.AlertSound
			};
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00015024 File Offset: 0x00013224
		// (set) Token: 0x06000063 RID: 99 RVA: 0x0001505E File Offset: 0x0001325E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				AiAlertNotifyComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0001506C File Offset: 0x0001326C
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00015096 File Offset: 0x00013296
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000150A4 File Offset: 0x000132A4
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00015105 File Offset: 0x00013305
		public virtual IExtraAiAlert ExtraAiAlert
		{
			get
			{
				if (this._ExtraAiAlertInited)
				{
					return this._ExtraAiAlertCache;
				}
				this._ExtraAiAlertInited = true;
				if (this.FbInstance != null)
				{
					this._ExtraAiAlertCache = IExtraAiAlert.Create(this.FbInstance.ExtraAiAlert);
				}
				else
				{
					AiAlertNotifyComponent_SetValue pocoInterface = this.PocoInterface;
					this._ExtraAiAlertCache = ((pocoInterface != null) ? pocoInterface.ExtraAiAlert : null);
				}
				return this._ExtraAiAlertCache;
			}
			set
			{
				this.GetOrCreatePoco().ExtraAiAlert = value;
				this._ExtraAiAlertInited = false;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0001511A File Offset: 0x0001331A
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00015141 File Offset: 0x00013341
		[Nullable(2)]
		public virtual List<int> ExcludeEntities
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExcludeEntities;
				}
				AiAlertNotifyComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExcludeEntities;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExcludeEntities = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0001514F File Offset: 0x0001334F
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00015176 File Offset: 0x00013376
		[Nullable(2)]
		public virtual string AlertSound
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AlertSound;
				}
				AiAlertNotifyComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AlertSound;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AlertSound = value;
			}
		}

		// Token: 0x04000043 RID: 67
		[Nullable(2)]
		protected new AiAlertNotifyComponent FbInstance;

		// Token: 0x04000044 RID: 68
		[Nullable(2)]
		protected new AiAlertNotifyComponent_SetValue PocoInterface;

		// Token: 0x04000045 RID: 69
		private IExtraAiAlert _ExtraAiAlertCache;

		// Token: 0x04000046 RID: 70
		private bool _ExtraAiAlertInited;
	}
}
