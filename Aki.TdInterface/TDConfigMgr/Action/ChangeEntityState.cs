using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001629 RID: 5673
	public class ChangeEntityState : ActionParams
	{
		// Token: 0x0600801B RID: 32795 RVA: 0x001312F0 File Offset: 0x0012F4F0
		private ChangeEntityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeEntityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeEntityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeEntityState_SetValue());
			}
			return result;
		}

		// Token: 0x0600801C RID: 32796 RVA: 0x00131328 File Offset: 0x0012F528
		public static ChangeEntityState Create([Nullable(2)] ChangeEntityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeEntityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600801D RID: 32797 RVA: 0x0013133B File Offset: 0x0012F53B
		public static ChangeEntityState CreateFromSetValue([Nullable(2)] ChangeEntityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeEntityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600801E RID: 32798 RVA: 0x0013134E File Offset: 0x0012F54E
		public ChangeEntityState_SetValue ToSetValue()
		{
			return new ChangeEntityState_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x0600801F RID: 32799 RVA: 0x0013136D File Offset: 0x0012F56D
		// (set) Token: 0x06008020 RID: 32800 RVA: 0x00131398 File Offset: 0x0012F598
		public virtual EChangeEntityState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityState.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x06008021 RID: 32801 RVA: 0x001313A6 File Offset: 0x0012F5A6
		// (set) Token: 0x06008022 RID: 32802 RVA: 0x001313D1 File Offset: 0x0012F5D1
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04004A03 RID: 18947
		[Nullable(2)]
		protected new ChangeEntityState FbInstance;

		// Token: 0x04004A04 RID: 18948
		[Nullable(2)]
		protected ChangeEntityState_SetValue PocoInterface;
	}
}
