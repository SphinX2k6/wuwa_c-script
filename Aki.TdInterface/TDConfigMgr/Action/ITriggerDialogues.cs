using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FFA RID: 8186
	[NullableContext(1)]
	[Nullable(0)]
	public class ITriggerDialogues : IInteractEffect
	{
		// Token: 0x0600B406 RID: 46086 RVA: 0x001A2CB0 File Offset: 0x001A0EB0
		private ITriggerDialogues_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggerDialogues 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggerDialogues_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggerDialogues_SetValue());
			}
			return result;
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x001A2CE8 File Offset: 0x001A0EE8
		public static ITriggerDialogues Create([Nullable(2)] ITriggerDialogues instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggerDialogues
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x001A2CFB File Offset: 0x001A0EFB
		public static ITriggerDialogues CreateFromSetValue([Nullable(2)] ITriggerDialogues_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggerDialogues
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x001A2D0E File Offset: 0x001A0F0E
		public new ITriggerDialogues_SetValue ToSetValue()
		{
			return new ITriggerDialogues_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime,
				Talks = this.Talks,
				FocusObject = this.FocusObject
			};
		}

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600B40A RID: 46090 RVA: 0x001A2D45 File Offset: 0x001A0F45
		// (set) Token: 0x0600B40B RID: 46091 RVA: 0x001A2D70 File Offset: 0x001A0F70
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

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600B40C RID: 46092 RVA: 0x001A2D80 File Offset: 0x001A0F80
		// (set) Token: 0x0600B40D RID: 46093 RVA: 0x001A2DBA File Offset: 0x001A0FBA
		public override float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ITriggerDialogues_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600B40E RID: 46094 RVA: 0x001A2DC8 File Offset: 0x001A0FC8
		// (set) Token: 0x0600B40F RID: 46095 RVA: 0x001A2DEF File Offset: 0x001A0FEF
		public virtual List<string> Talks
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Talks;
				}
				ITriggerDialogues_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Talks;
			}
			set
			{
				this.GetOrCreatePoco().Talks = value;
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600B410 RID: 46096 RVA: 0x001A2E00 File Offset: 0x001A1000
		// (set) Token: 0x0600B411 RID: 46097 RVA: 0x001A2E61 File Offset: 0x001A1061
		[Nullable(2)]
		public virtual IFocusObject FocusObject
		{
			[NullableContext(2)]
			get
			{
				if (this._FocusObjectInited)
				{
					return this._FocusObjectCache;
				}
				this._FocusObjectInited = true;
				if (this.FbInstance != null)
				{
					this._FocusObjectCache = IFocusObject.Create(this.FbInstance.FocusObject);
				}
				else
				{
					ITriggerDialogues_SetValue pocoInterface = this.PocoInterface;
					this._FocusObjectCache = ((pocoInterface != null) ? pocoInterface.FocusObject : null);
				}
				return this._FocusObjectCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().FocusObject = value;
				this._FocusObjectInited = false;
			}
		}

		// Token: 0x04006C89 RID: 27785
		[Nullable(2)]
		protected new ITriggerDialogues FbInstance;

		// Token: 0x04006C8A RID: 27786
		[Nullable(2)]
		protected new ITriggerDialogues_SetValue PocoInterface;

		// Token: 0x04006C8B RID: 27787
		private IFocusObject _FocusObjectCache;

		// Token: 0x04006C8C RID: 27788
		private bool _FocusObjectInited;
	}
}
