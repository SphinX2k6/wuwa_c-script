using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EF5 RID: 7925
	[NullableContext(1)]
	[Nullable(0)]
	public class ISuperCatapult : ILeisureInteractType
	{
		// Token: 0x0600A97C RID: 43388 RVA: 0x0017E1B8 File Offset: 0x0017C3B8
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

		// Token: 0x0600A97D RID: 43389 RVA: 0x0017E1F0 File Offset: 0x0017C3F0
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

		// Token: 0x0600A97E RID: 43390 RVA: 0x0017E203 File Offset: 0x0017C403
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

		// Token: 0x0600A97F RID: 43391 RVA: 0x0017E216 File Offset: 0x0017C416
		public new ISuperCatapult_SetValue ToSetValue()
		{
			return new ISuperCatapult_SetValue
			{
				Type = this.Type,
				Param = this.Param
			};
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600A980 RID: 43392 RVA: 0x0017E235 File Offset: 0x0017C435
		// (set) Token: 0x0600A981 RID: 43393 RVA: 0x0017E260 File Offset: 0x0017C460
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

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600A982 RID: 43394 RVA: 0x0017E270 File Offset: 0x0017C470
		// (set) Token: 0x0600A983 RID: 43395 RVA: 0x0017E2D1 File Offset: 0x0017C4D1
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

		// Token: 0x040064D1 RID: 25809
		[Nullable(2)]
		protected new ISuperCatapult FbInstance;

		// Token: 0x040064D2 RID: 25810
		[Nullable(2)]
		protected new ISuperCatapult_SetValue PocoInterface;

		// Token: 0x040064D3 RID: 25811
		private ICatapultParam _ParamCache;

		// Token: 0x040064D4 RID: 25812
		private bool _ParamInited;
	}
}
