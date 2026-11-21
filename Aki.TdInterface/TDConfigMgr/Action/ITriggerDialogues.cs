using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002241 RID: 8769
	public class ITriggerDialogues : IInteractEffect
	{
		// Token: 0x0600BF1C RID: 48924 RVA: 0x001B921C File Offset: 0x001B741C
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

		// Token: 0x0600BF1D RID: 48925 RVA: 0x001B9254 File Offset: 0x001B7454
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

		// Token: 0x0600BF1E RID: 48926 RVA: 0x001B9267 File Offset: 0x001B7467
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

		// Token: 0x0600BF1F RID: 48927 RVA: 0x001B927A File Offset: 0x001B747A
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

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0600BF20 RID: 48928 RVA: 0x001B92B1 File Offset: 0x001B74B1
		// (set) Token: 0x0600BF21 RID: 48929 RVA: 0x001B92DC File Offset: 0x001B74DC
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

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0600BF22 RID: 48930 RVA: 0x001B92EC File Offset: 0x001B74EC
		// (set) Token: 0x0600BF23 RID: 48931 RVA: 0x001B9326 File Offset: 0x001B7526
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

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0600BF24 RID: 48932 RVA: 0x001B9334 File Offset: 0x001B7534
		// (set) Token: 0x0600BF25 RID: 48933 RVA: 0x001B935B File Offset: 0x001B755B
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

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x0600BF26 RID: 48934 RVA: 0x001B936C File Offset: 0x001B756C
		// (set) Token: 0x0600BF27 RID: 48935 RVA: 0x001B93CD File Offset: 0x001B75CD
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

		// Token: 0x0400728B RID: 29323
		[Nullable(2)]
		protected new ITriggerDialogues FbInstance;

		// Token: 0x0400728C RID: 29324
		[Nullable(2)]
		protected new ITriggerDialogues_SetValue PocoInterface;

		// Token: 0x0400728D RID: 29325
		private IFocusObject _FocusObjectCache;

		// Token: 0x0400728E RID: 29326
		private bool _FocusObjectInited;
	}
}
