using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200185A RID: 6234
	[NullableContext(1)]
	[Nullable(0)]
	public class ICatapult : ILeisureInteractType
	{
		// Token: 0x060085EF RID: 34287 RVA: 0x0013E670 File Offset: 0x0013C870
		private ICatapult_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICatapult 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICatapult_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICatapult_SetValue());
			}
			return result;
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x0013E6A8 File Offset: 0x0013C8A8
		public static ICatapult Create([Nullable(2)] ICatapult instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICatapult
			{
				FbInstance = instance
			};
		}

		// Token: 0x060085F1 RID: 34289 RVA: 0x0013E6BB File Offset: 0x0013C8BB
		public static ICatapult CreateFromSetValue([Nullable(2)] ICatapult_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICatapult
			{
				PocoInterface = value
			};
		}

		// Token: 0x060085F2 RID: 34290 RVA: 0x0013E6CE File Offset: 0x0013C8CE
		public new ICatapult_SetValue ToSetValue()
		{
			return new ICatapult_SetValue
			{
				Type = this.Type,
				Param = this.Param
			};
		}

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x060085F3 RID: 34291 RVA: 0x0013E6ED File Offset: 0x0013C8ED
		// (set) Token: 0x060085F4 RID: 34292 RVA: 0x0013E718 File Offset: 0x0013C918
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

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x060085F5 RID: 34293 RVA: 0x0013E728 File Offset: 0x0013C928
		// (set) Token: 0x060085F6 RID: 34294 RVA: 0x0013E789 File Offset: 0x0013C989
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
					ICatapult_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400548C RID: 21644
		[Nullable(2)]
		protected new ICatapult FbInstance;

		// Token: 0x0400548D RID: 21645
		[Nullable(2)]
		protected new ICatapult_SetValue PocoInterface;

		// Token: 0x0400548E RID: 21646
		private ICatapultParam _ParamCache;

		// Token: 0x0400548F RID: 21647
		private bool _ParamInited;
	}
}
