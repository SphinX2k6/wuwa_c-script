using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017AD RID: 6061
	public class EnableKey4Func : ActionParams
	{
		// Token: 0x0600833D RID: 33597 RVA: 0x0013A21C File Offset: 0x0013841C
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

		// Token: 0x0600833E RID: 33598 RVA: 0x0013A254 File Offset: 0x00138454
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

		// Token: 0x0600833F RID: 33599 RVA: 0x0013A267 File Offset: 0x00138467
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

		// Token: 0x06008340 RID: 33600 RVA: 0x0013A27A File Offset: 0x0013847A
		public EnableKey4Func_SetValue ToSetValue()
		{
			return new EnableKey4Func_SetValue
			{
				IsEnable = this.IsEnable,
				FuncKey = this.FuncKey
			};
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x06008341 RID: 33601 RVA: 0x0013A299 File Offset: 0x00138499
		// (set) Token: 0x06008342 RID: 33602 RVA: 0x0013A2C4 File Offset: 0x001384C4
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

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x06008343 RID: 33603 RVA: 0x0013A2D2 File Offset: 0x001384D2
		// (set) Token: 0x06008344 RID: 33604 RVA: 0x0013A2FD File Offset: 0x001384FD
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

		// Token: 0x0400505A RID: 20570
		[Nullable(2)]
		protected new EnableKey4Func FbInstance;

		// Token: 0x0400505B RID: 20571
		[Nullable(2)]
		protected EnableKey4Func_SetValue PocoInterface;
	}
}
