using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021BF RID: 8639
	public class ITalkOptionSystemCondition : ITalkOptionPreConditionBase
	{
		// Token: 0x0600BC4E RID: 48206 RVA: 0x001B4080 File Offset: 0x001B2280
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

		// Token: 0x0600BC4F RID: 48207 RVA: 0x001B40B8 File Offset: 0x001B22B8
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

		// Token: 0x0600BC50 RID: 48208 RVA: 0x001B40CB File Offset: 0x001B22CB
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

		// Token: 0x0600BC51 RID: 48209 RVA: 0x001B40E0 File Offset: 0x001B22E0
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

		// Token: 0x17003998 RID: 14744
		// (get) Token: 0x0600BC52 RID: 48210 RVA: 0x001B412E File Offset: 0x001B232E
		// (set) Token: 0x0600BC53 RID: 48211 RVA: 0x001B4159 File Offset: 0x001B2359
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

		// Token: 0x17003999 RID: 14745
		// (get) Token: 0x0600BC54 RID: 48212 RVA: 0x001B4168 File Offset: 0x001B2368
		// (set) Token: 0x0600BC55 RID: 48213 RVA: 0x001B41C9 File Offset: 0x001B23C9
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

		// Token: 0x1700399A RID: 14746
		// (get) Token: 0x0600BC56 RID: 48214 RVA: 0x001B41E0 File Offset: 0x001B23E0
		// (set) Token: 0x0600BC57 RID: 48215 RVA: 0x001B421A File Offset: 0x001B241A
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

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x0600BC58 RID: 48216 RVA: 0x001B4228 File Offset: 0x001B2428
		// (set) Token: 0x0600BC59 RID: 48217 RVA: 0x001B4262 File Offset: 0x001B2462
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

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x0600BC5A RID: 48218 RVA: 0x001B4270 File Offset: 0x001B2470
		// (set) Token: 0x0600BC5B RID: 48219 RVA: 0x001B4297 File Offset: 0x001B2497
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

		// Token: 0x04007135 RID: 28981
		[Nullable(2)]
		protected new ITalkOptionSystemCondition FbInstance;

		// Token: 0x04007136 RID: 28982
		[Nullable(2)]
		protected new ITalkOptionSystemCondition_SetValue PocoInterface;

		// Token: 0x04007137 RID: 28983
		private ITalkOptionConditionSolarSchool _SystemCache;

		// Token: 0x04007138 RID: 28984
		private bool _SystemInited;
	}
}
