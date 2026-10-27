using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001640 RID: 5696
	[NullableContext(1)]
	[Nullable(0)]
	public class EnableKey4Func : ActionParams
	{
		// Token: 0x06007C5F RID: 31839 RVA: 0x0012B170 File Offset: 0x00129370
		private EnableKey4Func_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("EnableKey4Func 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			EnableKey4Func_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new EnableKey4Func_SetValue());
			}
			return result;
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x0012B1A8 File Offset: 0x001293A8
		public static EnableKey4Func Create([Nullable(2)] EnableKey4Func instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableKey4Func
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x0012B1BB File Offset: 0x001293BB
		public static EnableKey4Func CreateFromSetValue([Nullable(2)] EnableKey4Func_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new EnableKey4Func
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x0012B1CE File Offset: 0x001293CE
		public EnableKey4Func_SetValue ToSetValue()
		{
			return new EnableKey4Func_SetValue
			{
				IsEnable = this.IsEnable,
				FuncKey = this.FuncKey
			};
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x06007C63 RID: 31843 RVA: 0x0012B1ED File Offset: 0x001293ED
		// (set) Token: 0x06007C64 RID: 31844 RVA: 0x0012B218 File Offset: 0x00129418
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x0012B226 File Offset: 0x00129426
		// (set) Token: 0x06007C66 RID: 31846 RVA: 0x0012B251 File Offset: 0x00129451
		public virtual EEnableKey4FuncKey FuncKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FuncKey;
				}
				if (this.PocoInterface == null)
				{
					return EEnableKey4FuncKey.TimeScaled;
				}
				return this.PocoInterface.FuncKey;
			}
			set
			{
				this.GetOrCreatePoco().FuncKey = value;
			}
		}

		// Token: 0x04004C66 RID: 19558
		[Nullable(2)]
		protected new EnableKey4Func FbInstance;

		// Token: 0x04004C67 RID: 19559
		[Nullable(2)]
		protected EnableKey4Func_SetValue PocoInterface;
	}
}
