using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016B5 RID: 5813
	public class DarkTideSetMapMarkState : ActionParams
	{
		// Token: 0x06008253 RID: 33363 RVA: 0x00138898 File Offset: 0x00136A98
		private DarkTideSetMapMarkState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DarkTideSetMapMarkState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DarkTideSetMapMarkState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DarkTideSetMapMarkState_SetValue());
			}
			return result;
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x001388D0 File Offset: 0x00136AD0
		public static DarkTideSetMapMarkState Create([Nullable(2)] DarkTideSetMapMarkState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DarkTideSetMapMarkState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x001388E3 File Offset: 0x00136AE3
		public static DarkTideSetMapMarkState CreateFromSetValue([Nullable(2)] DarkTideSetMapMarkState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DarkTideSetMapMarkState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x001388F6 File Offset: 0x00136AF6
		public DarkTideSetMapMarkState_SetValue ToSetValue()
		{
			return new DarkTideSetMapMarkState_SetValue
			{
				MapMarkId = this.MapMarkId,
				StateType = this.StateType
			};
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x06008257 RID: 33367 RVA: 0x00138915 File Offset: 0x00136B15
		// (set) Token: 0x06008258 RID: 33368 RVA: 0x00138940 File Offset: 0x00136B40
		public virtual int MapMarkId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MapMarkId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MapMarkId;
			}
			set
			{
				this.GetOrCreatePoco().MapMarkId = value;
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x06008259 RID: 33369 RVA: 0x0013894E File Offset: 0x00136B4E
		// (set) Token: 0x0600825A RID: 33370 RVA: 0x00138979 File Offset: 0x00136B79
		public virtual EDarkTideMapMarkStateType StateType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateType;
				}
				if (this.PocoInterface == null)
				{
					return EDarkTideMapMarkStateType.Hide;
				}
				return this.PocoInterface.StateType;
			}
			set
			{
				this.GetOrCreatePoco().StateType = value;
			}
		}

		// Token: 0x04004ABD RID: 19133
		[Nullable(2)]
		protected new DarkTideSetMapMarkState FbInstance;

		// Token: 0x04004ABE RID: 19134
		[Nullable(2)]
		protected DarkTideSetMapMarkState_SetValue PocoInterface;
	}
}
