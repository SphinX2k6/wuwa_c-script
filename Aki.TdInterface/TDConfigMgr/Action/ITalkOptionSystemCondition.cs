using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F84 RID: 8068
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionSystemCondition : ITalkOptionPreConditionBase
	{
		// Token: 0x0600B174 RID: 45428 RVA: 0x0019E12C File Offset: 0x0019C32C
		private ITalkOptionSystemCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionSystemCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionSystemCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionSystemCondition_SetValue());
			}
			return result;
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x0019E164 File Offset: 0x0019C364
		public static ITalkOptionSystemCondition Create([Nullable(2)] ITalkOptionSystemCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionSystemCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B176 RID: 45430 RVA: 0x0019E177 File Offset: 0x0019C377
		public static ITalkOptionSystemCondition CreateFromSetValue([Nullable(2)] ITalkOptionSystemCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionSystemCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x0019E18C File Offset: 0x0019C38C
		public new ITalkOptionSystemCondition_SetValue ToSetValue()
		{
			return new ITalkOptionSystemCondition_SetValue
			{
				Type = this.Type,
				System = this.System,
				HideWhenUnmet = this.HideWhenUnmet,
				HideConditionTextWhenUnmet = this.HideConditionTextWhenUnmet,
				TidReplaceTextWhenUnmet = this.TidReplaceTextWhenUnmet
			};
		}

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0600B178 RID: 45432 RVA: 0x0019E1DA File Offset: 0x0019C3DA
		// (set) Token: 0x0600B179 RID: 45433 RVA: 0x0019E205 File Offset: 0x0019C405
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0600B17A RID: 45434 RVA: 0x0019E214 File Offset: 0x0019C414
		// (set) Token: 0x0600B17B RID: 45435 RVA: 0x0019E275 File Offset: 0x0019C475
		public virtual ITalkOptionConditionSolarSchool System
		{
			get
			{
				if (this._SystemInited)
				{
					return this._SystemCache;
				}
				this._SystemInited = true;
				if (this.FbInstance != null)
				{
					this._SystemCache = ITalkOptionConditionSolarSchool.Create(this.FbInstance.System);
				}
				else
				{
					ITalkOptionSystemCondition_SetValue pocoInterface = this.PocoInterface;
					this._SystemCache = ((pocoInterface != null) ? pocoInterface.System : null);
				}
				return this._SystemCache;
			}
			set
			{
				this.GetOrCreatePoco().System = value;
				this._SystemInited = false;
			}
		}

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x0600B17C RID: 45436 RVA: 0x0019E28C File Offset: 0x0019C48C
		// (set) Token: 0x0600B17D RID: 45437 RVA: 0x0019E2C6 File Offset: 0x0019C4C6
		public virtual bool? HideWhenUnmet
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideWhenUnmet;
				}
				ITalkOptionSystemCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideWhenUnmet;
			}
			set
			{
				this.GetOrCreatePoco().HideWhenUnmet = value;
			}
		}

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0600B17E RID: 45438 RVA: 0x0019E2D4 File Offset: 0x0019C4D4
		// (set) Token: 0x0600B17F RID: 45439 RVA: 0x0019E30E File Offset: 0x0019C50E
		public virtual bool? HideConditionTextWhenUnmet
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HideConditionTextWhenUnmet;
				}
				ITalkOptionSystemCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HideConditionTextWhenUnmet;
			}
			set
			{
				this.GetOrCreatePoco().HideConditionTextWhenUnmet = value;
			}
		}

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0600B180 RID: 45440 RVA: 0x0019E31C File Offset: 0x0019C51C
		// (set) Token: 0x0600B181 RID: 45441 RVA: 0x0019E343 File Offset: 0x0019C543
		[Nullable(2)]
		public virtual string TidReplaceTextWhenUnmet
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidReplaceTextWhenUnmet;
				}
				ITalkOptionSystemCondition_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidReplaceTextWhenUnmet;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TidReplaceTextWhenUnmet = value;
			}
		}

		// Token: 0x04006B4D RID: 27469
		[Nullable(2)]
		protected new ITalkOptionSystemCondition FbInstance;

		// Token: 0x04006B4E RID: 27470
		[Nullable(2)]
		protected new ITalkOptionSystemCondition_SetValue PocoInterface;

		// Token: 0x04006B4F RID: 27471
		private ITalkOptionConditionSolarSchool _SystemCache;

		// Token: 0x04006B50 RID: 27472
		private bool _SystemInited;
	}
}
