using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002400 RID: 9216
	public class SetAreaState : ActionParams
	{
		// Token: 0x0600C892 RID: 51346 RVA: 0x001CA898 File Offset: 0x001C8A98
		private SetAreaState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetAreaState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetAreaState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetAreaState_SetValue());
			}
			return result;
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x001CA8D0 File Offset: 0x001C8AD0
		public static SetAreaState Create([Nullable(2)] SetAreaState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetAreaState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C894 RID: 51348 RVA: 0x001CA8E3 File Offset: 0x001C8AE3
		public static SetAreaState CreateFromSetValue([Nullable(2)] SetAreaState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetAreaState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C895 RID: 51349 RVA: 0x001CA8F6 File Offset: 0x001C8AF6
		public SetAreaState_SetValue ToSetValue()
		{
			return new SetAreaState_SetValue
			{
				AreaId = this.AreaId,
				State = this.State
			};
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0600C896 RID: 51350 RVA: 0x001CA915 File Offset: 0x001C8B15
		// (set) Token: 0x0600C897 RID: 51351 RVA: 0x001CA940 File Offset: 0x001C8B40
		public virtual int AreaId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AreaId;
			}
			set
			{
				this.GetOrCreatePoco().AreaId = value;
			}
		}

		// Token: 0x17003C62 RID: 15458
		// (get) Token: 0x0600C898 RID: 51352 RVA: 0x001CA94E File Offset: 0x001C8B4E
		// (set) Token: 0x0600C899 RID: 51353 RVA: 0x001CA979 File Offset: 0x001C8B79
		public virtual int State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x04007702 RID: 30466
		[Nullable(2)]
		protected new SetAreaState FbInstance;

		// Token: 0x04007703 RID: 30467
		[Nullable(2)]
		protected SetAreaState_SetValue PocoInterface;
	}
}
