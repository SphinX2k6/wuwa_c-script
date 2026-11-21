using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200212E RID: 8494
	public class ISuperCatapult : ILeisureInteractType
	{
		// Token: 0x0600B44E RID: 46158 RVA: 0x001941B0 File Offset: 0x001923B0
		private ISuperCatapult_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISuperCatapult 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISuperCatapult_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISuperCatapult_SetValue());
			}
			return result;
		}

		// Token: 0x0600B44F RID: 46159 RVA: 0x001941E8 File Offset: 0x001923E8
		public static ISuperCatapult Create([Nullable(2)] ISuperCatapult instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISuperCatapult
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B450 RID: 46160 RVA: 0x001941FB File Offset: 0x001923FB
		public static ISuperCatapult CreateFromSetValue([Nullable(2)] ISuperCatapult_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISuperCatapult
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B451 RID: 46161 RVA: 0x0019420E File Offset: 0x0019240E
		public new ISuperCatapult_SetValue ToSetValue()
		{
			return new ISuperCatapult_SetValue
			{
				Type = this.Type,
				Param = this.Param
			};
		}

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0600B452 RID: 46162 RVA: 0x0019422D File Offset: 0x0019242D
		// (set) Token: 0x0600B453 RID: 46163 RVA: 0x00194258 File Offset: 0x00192458
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0600B454 RID: 46164 RVA: 0x00194268 File Offset: 0x00192468
		// (set) Token: 0x0600B455 RID: 46165 RVA: 0x001942C9 File Offset: 0x001924C9
		public virtual ICatapultParam Param
		{
			get
			{
				if (this._ParamInited)
				{
					return this._ParamCache;
				}
				this._ParamInited = true;
				if (this.FbInstance != null)
				{
					this._ParamCache = ICatapultParam.Create(this.FbInstance.Param);
				}
				else
				{
					ISuperCatapult_SetValue pocoInterface = this.PocoInterface;
					this._ParamCache = ((pocoInterface != null) ? pocoInterface.Param : null);
				}
				return this._ParamCache;
			}
			set
			{
				this.GetOrCreatePoco().Param = value;
				this._ParamInited = false;
			}
		}

		// Token: 0x04006AC0 RID: 27328
		[Nullable(2)]
		protected new ISuperCatapult FbInstance;

		// Token: 0x04006AC1 RID: 27329
		[Nullable(2)]
		protected new ISuperCatapult_SetValue PocoInterface;

		// Token: 0x04006AC2 RID: 27330
		private ICatapultParam _ParamCache;

		// Token: 0x04006AC3 RID: 27331
		private bool _ParamInited;
	}
}
