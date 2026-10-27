using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000811 RID: 2065
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoPressureTrigger : IWuWaGoEntityBase
	{
		// Token: 0x06002CD5 RID: 11477 RVA: 0x000743D8 File Offset: 0x000725D8
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

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00074410 File Offset: 0x00072610
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

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00074423 File Offset: 0x00072623
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

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00074436 File Offset: 0x00072636
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

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x0007446D File Offset: 0x0007266D
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x00074498 File Offset: 0x00072698
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

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x000744A8 File Offset: 0x000726A8
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x00074509 File Offset: 0x00072709
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

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x00074520 File Offset: 0x00072720
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x000745B3 File Offset: 0x000727B3
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

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x000745C8 File Offset: 0x000727C8
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x0007465B File Offset: 0x0007285B
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

		// Token: 0x04001DAA RID: 7594
		[Nullable(2)]
		protected new IWuWaGoPressureTrigger FbInstance;

		// Token: 0x04001DAB RID: 7595
		[Nullable(2)]
		protected new IWuWaGoPressureTrigger_SetValue PocoInterface;

		// Token: 0x04001DAC RID: 7596
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04001DAD RID: 7597
		private bool _LinkDataInited;

		// Token: 0x04001DAE RID: 7598
		private List<Aki.TDConfigMgr.Action.ActionInfo> _EnterActionListCache;

		// Token: 0x04001DAF RID: 7599
		private bool _EnterActionListInited;

		// Token: 0x04001DB0 RID: 7600
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ExitActionListCache;

		// Token: 0x04001DB1 RID: 7601
		private bool _ExitActionListInited;
	}
}
