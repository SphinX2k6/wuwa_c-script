using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200222C RID: 8748
	[NullableContext(1)]
	[Nullable(0)]
	public class SyncVarToActorState : ActionParams
	{
		// Token: 0x0600C002 RID: 49154 RVA: 0x001B93E0 File Offset: 0x001B75E0
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

		// Token: 0x0600C003 RID: 49155 RVA: 0x001B9418 File Offset: 0x001B7618
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

		// Token: 0x0600C004 RID: 49156 RVA: 0x001B942B File Offset: 0x001B762B
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

		// Token: 0x0600C005 RID: 49157 RVA: 0x001B943E File Offset: 0x001B763E
		public SyncVarToActorState_SetValue ToSetValue()
		{
			return new SyncVarToActorState_SetValue
			{
				VarName = this.VarName,
				StateKey = this.StateKey
			};
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0600C006 RID: 49158 RVA: 0x001B945D File Offset: 0x001B765D
		// (set) Token: 0x0600C007 RID: 49159 RVA: 0x001B9488 File Offset: 0x001B7688
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

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x0600C008 RID: 49160 RVA: 0x001B9496 File Offset: 0x001B7696
		// (set) Token: 0x0600C009 RID: 49161 RVA: 0x001B94C1 File Offset: 0x001B76C1
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

		// Token: 0x0400727A RID: 29306
		[Nullable(2)]
		protected new SyncVarToActorState FbInstance;

		// Token: 0x0400727B RID: 29307
		[Nullable(2)]
		protected SyncVarToActorState_SetValue PocoInterface;
	}
}
