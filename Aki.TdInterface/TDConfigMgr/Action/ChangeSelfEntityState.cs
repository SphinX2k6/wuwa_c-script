using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200163F RID: 5695
	public class ChangeSelfEntityState : ActionParams
	{
		// Token: 0x0600808F RID: 32911 RVA: 0x00131F98 File Offset: 0x00130198
		private ChangeSelfEntityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeSelfEntityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeSelfEntityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeSelfEntityState_SetValue());
			}
			return result;
		}

		// Token: 0x06008090 RID: 32912 RVA: 0x00131FD0 File Offset: 0x001301D0
		public static ChangeSelfEntityState Create([Nullable(2)] ChangeSelfEntityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeSelfEntityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008091 RID: 32913 RVA: 0x00131FE3 File Offset: 0x001301E3
		public static ChangeSelfEntityState CreateFromSetValue([Nullable(2)] ChangeSelfEntityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeSelfEntityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x00131FF6 File Offset: 0x001301F6
		public ChangeSelfEntityState_SetValue ToSetValue()
		{
			return new ChangeSelfEntityState_SetValue
			{
				EntityState = this.EntityState
			};
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x06008093 RID: 32915 RVA: 0x00132009 File Offset: 0x00130209
		// (set) Token: 0x06008094 RID: 32916 RVA: 0x00132034 File Offset: 0x00130234
		public virtual string EntityState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityState;
			}
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x04004A38 RID: 19000
		[Nullable(2)]
		protected new ChangeSelfEntityState FbInstance;

		// Token: 0x04004A39 RID: 19001
		[Nullable(2)]
		protected ChangeSelfEntityState_SetValue PocoInterface;
	}
}
