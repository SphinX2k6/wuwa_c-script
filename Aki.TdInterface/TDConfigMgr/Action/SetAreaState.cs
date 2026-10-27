using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002197 RID: 8599
	[NullableContext(1)]
	[Nullable(0)]
	public class SetAreaState : ActionParams
	{
		// Token: 0x0600BCE2 RID: 48354 RVA: 0x001B33A0 File Offset: 0x001B15A0
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

		// Token: 0x0600BCE3 RID: 48355 RVA: 0x001B33D8 File Offset: 0x001B15D8
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

		// Token: 0x0600BCE4 RID: 48356 RVA: 0x001B33EB File Offset: 0x001B15EB
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

		// Token: 0x0600BCE5 RID: 48357 RVA: 0x001B33FE File Offset: 0x001B15FE
		public SetAreaState_SetValue ToSetValue()
		{
			return new SetAreaState_SetValue
			{
				AreaId = this.AreaId,
				State = this.State
			};
		}

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600BCE6 RID: 48358 RVA: 0x001B341D File Offset: 0x001B161D
		// (set) Token: 0x0600BCE7 RID: 48359 RVA: 0x001B3448 File Offset: 0x001B1648
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

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600BCE8 RID: 48360 RVA: 0x001B3456 File Offset: 0x001B1656
		// (set) Token: 0x0600BCE9 RID: 48361 RVA: 0x001B3481 File Offset: 0x001B1681
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

		// Token: 0x040070C0 RID: 28864
		[Nullable(2)]
		protected new SetAreaState FbInstance;

		// Token: 0x040070C1 RID: 28865
		[Nullable(2)]
		protected SetAreaState_SetValue PocoInterface;
	}
}
