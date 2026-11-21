using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002497 RID: 9367
	public class SyncVarToActorState : ActionParams
	{
		// Token: 0x0600CBC0 RID: 52160 RVA: 0x001D0AAC File Offset: 0x001CECAC
		private SyncVarToActorState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SyncVarToActorState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SyncVarToActorState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SyncVarToActorState_SetValue());
			}
			return result;
		}

		// Token: 0x0600CBC1 RID: 52161 RVA: 0x001D0AE4 File Offset: 0x001CECE4
		public static SyncVarToActorState Create([Nullable(2)] SyncVarToActorState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SyncVarToActorState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CBC2 RID: 52162 RVA: 0x001D0AF7 File Offset: 0x001CECF7
		public static SyncVarToActorState CreateFromSetValue([Nullable(2)] SyncVarToActorState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SyncVarToActorState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CBC3 RID: 52163 RVA: 0x001D0B0A File Offset: 0x001CED0A
		public SyncVarToActorState_SetValue ToSetValue()
		{
			return new SyncVarToActorState_SetValue
			{
				VarName = this.VarName,
				StateKey = this.StateKey
			};
		}

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x0600CBC4 RID: 52164 RVA: 0x001D0B29 File Offset: 0x001CED29
		// (set) Token: 0x0600CBC5 RID: 52165 RVA: 0x001D0B54 File Offset: 0x001CED54
		public virtual string VarName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.VarName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.VarName;
			}
			set
			{
				this.GetOrCreatePoco().VarName = value;
			}
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x0600CBC6 RID: 52166 RVA: 0x001D0B62 File Offset: 0x001CED62
		// (set) Token: 0x0600CBC7 RID: 52167 RVA: 0x001D0B8D File Offset: 0x001CED8D
		public virtual string StateKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.StateKey;
			}
			set
			{
				this.GetOrCreatePoco().StateKey = value;
			}
		}

		// Token: 0x040078C4 RID: 30916
		[Nullable(2)]
		protected new SyncVarToActorState FbInstance;

		// Token: 0x040078C5 RID: 30917
		[Nullable(2)]
		protected SyncVarToActorState_SetValue PocoInterface;
	}
}
