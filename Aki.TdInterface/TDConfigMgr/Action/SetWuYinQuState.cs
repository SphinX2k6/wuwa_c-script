using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245E RID: 9310
	public class SetWuYinQuState : ActionParams
	{
		// Token: 0x0600CA9D RID: 51869 RVA: 0x001CE920 File Offset: 0x001CCB20
		private SetWuYinQuState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetWuYinQuState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetWuYinQuState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetWuYinQuState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA9E RID: 51870 RVA: 0x001CE958 File Offset: 0x001CCB58
		public static SetWuYinQuState Create([Nullable(2)] SetWuYinQuState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWuYinQuState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA9F RID: 51871 RVA: 0x001CE96B File Offset: 0x001CCB6B
		public static SetWuYinQuState CreateFromSetValue([Nullable(2)] SetWuYinQuState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetWuYinQuState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CAA0 RID: 51872 RVA: 0x001CE97E File Offset: 0x001CCB7E
		public SetWuYinQuState_SetValue ToSetValue()
		{
			return new SetWuYinQuState_SetValue
			{
				WuYinQuName = this.WuYinQuName,
				State = this.State
			};
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x0600CAA1 RID: 51873 RVA: 0x001CE99D File Offset: 0x001CCB9D
		// (set) Token: 0x0600CAA2 RID: 51874 RVA: 0x001CE9C8 File Offset: 0x001CCBC8
		public virtual string WuYinQuName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WuYinQuName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.WuYinQuName;
			}
			set
			{
				this.GetOrCreatePoco().WuYinQuName = value;
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x0600CAA3 RID: 51875 RVA: 0x001CE9D6 File Offset: 0x001CCBD6
		// (set) Token: 0x0600CAA4 RID: 51876 RVA: 0x001CEA01 File Offset: 0x001CCC01
		public virtual EWuYinQuState State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return EWuYinQuState.End;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04007820 RID: 30752
		[Nullable(2)]
		protected new SetWuYinQuState FbInstance;

		// Token: 0x04007821 RID: 30753
		[Nullable(2)]
		protected SetWuYinQuState_SetValue PocoInterface;
	}
}
