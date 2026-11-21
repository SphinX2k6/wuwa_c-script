using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B4 RID: 2228
	public class IWuWaGoPressureTrigger : IWuWaGoEntityBase
	{
		// Token: 0x06003005 RID: 12293 RVA: 0x0007B73C File Offset: 0x0007993C
		private IWuWaGoPressureTrigger_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoPressureTrigger 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoPressureTrigger_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoPressureTrigger_SetValue());
			}
			return result;
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x0007B774 File Offset: 0x00079974
		public static IWuWaGoPressureTrigger Create([Nullable(2)] IWuWaGoPressureTrigger instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoPressureTrigger
			{
				FbInstance = instance
			};
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x0007B787 File Offset: 0x00079987
		public static IWuWaGoPressureTrigger CreateFromSetValue([Nullable(2)] IWuWaGoPressureTrigger_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoPressureTrigger
			{
				PocoInterface = value
			};
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x0007B79A File Offset: 0x0007999A
		public new IWuWaGoPressureTrigger_SetValue ToSetValue()
		{
			return new IWuWaGoPressureTrigger_SetValue
			{
				Type = this.Type,
				LinkData = this.LinkData,
				EnterActionList = this.EnterActionList,
				ExitActionList = this.ExitActionList
			};
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x0007B7D1 File Offset: 0x000799D1
		// (set) Token: 0x0600300A RID: 12298 RVA: 0x0007B7FC File Offset: 0x000799FC
		public override EWuWaGoEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x0007B80C File Offset: 0x00079A0C
		// (set) Token: 0x0600300C RID: 12300 RVA: 0x0007B86D File Offset: 0x00079A6D
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				if (this.FbInstance != null)
				{
					this._LinkDataCache = IWuWaGoGridLinkData.Create(this.FbInstance.LinkData);
				}
				else
				{
					IWuWaGoPressureTrigger_SetValue pocoInterface = this.PocoInterface;
					this._LinkDataCache = ((pocoInterface != null) ? pocoInterface.LinkData : null);
				}
				return this._LinkDataCache;
			}
			set
			{
				this.GetOrCreatePoco().LinkData = value;
				this._LinkDataInited = false;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x0007B884 File Offset: 0x00079A84
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x0007B917 File Offset: 0x00079B17
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> EnterActionList
		{
			get
			{
				if (this._EnterActionListInited)
				{
					return this._EnterActionListCache;
				}
				this._EnterActionListInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> enterActionList = this.FbInstance.EnterActionList;
					if (enterActionList != null)
					{
						this._EnterActionListCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(enterActionList.Count);
						for (int i = 0; i < enterActionList.Count; i++)
						{
							this._EnterActionListCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(enterActionList[i]));
						}
					}
				}
				else
				{
					IWuWaGoPressureTrigger_SetValue pocoInterface = this.PocoInterface;
					this._EnterActionListCache = ((pocoInterface != null) ? pocoInterface.EnterActionList : null);
				}
				return this._EnterActionListCache;
			}
			set
			{
				this.GetOrCreatePoco().EnterActionList = value;
				this._EnterActionListInited = false;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x0007B92C File Offset: 0x00079B2C
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x0007B9BF File Offset: 0x00079BBF
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> ExitActionList
		{
			get
			{
				if (this._ExitActionListInited)
				{
					return this._ExitActionListCache;
				}
				this._ExitActionListInited = true;
				if (this.FbInstance != null)
				{
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> exitActionList = this.FbInstance.ExitActionList;
					if (exitActionList != null)
					{
						this._ExitActionListCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(exitActionList.Count);
						for (int i = 0; i < exitActionList.Count; i++)
						{
							this._ExitActionListCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(exitActionList[i]));
						}
					}
				}
				else
				{
					IWuWaGoPressureTrigger_SetValue pocoInterface = this.PocoInterface;
					this._ExitActionListCache = ((pocoInterface != null) ? pocoInterface.ExitActionList : null);
				}
				return this._ExitActionListCache;
			}
			set
			{
				this.GetOrCreatePoco().ExitActionList = value;
				this._ExitActionListInited = false;
			}
		}

		// Token: 0x04001FB6 RID: 8118
		[Nullable(2)]
		protected new IWuWaGoPressureTrigger FbInstance;

		// Token: 0x04001FB7 RID: 8119
		[Nullable(2)]
		protected new IWuWaGoPressureTrigger_SetValue PocoInterface;

		// Token: 0x04001FB8 RID: 8120
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001FB9 RID: 8121
		private bool _LinkDataInited;

		// Token: 0x04001FBA RID: 8122
		private List<Aki.TDConfigMgr.Action.ActionInfo> _EnterActionListCache;

		// Token: 0x04001FBB RID: 8123
		private bool _EnterActionListInited;

		// Token: 0x04001FBC RID: 8124
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitActionListCache;

		// Token: 0x04001FBD RID: 8125
		private bool _ExitActionListInited;
	}
}
