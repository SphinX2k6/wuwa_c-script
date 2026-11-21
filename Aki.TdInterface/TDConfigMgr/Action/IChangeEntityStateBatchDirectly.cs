using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F7 RID: 6647
	public class IChangeEntityStateBatchDirectly : ChangeEntityState
	{
		// Token: 0x06008D77 RID: 36215 RVA: 0x0014E9CC File Offset: 0x0014CBCC
		private IChangeEntityStateBatchDirectly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeEntityStateBatchDirectly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeEntityStateBatchDirectly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeEntityStateBatchDirectly_SetValue());
			}
			return result;
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x0014EA04 File Offset: 0x0014CC04
		public static IChangeEntityStateBatchDirectly Create([Nullable(2)] IChangeEntityStateBatchDirectly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateBatchDirectly
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x0014EA17 File Offset: 0x0014CC17
		public static IChangeEntityStateBatchDirectly CreateFromSetValue([Nullable(2)] IChangeEntityStateBatchDirectly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeEntityStateBatchDirectly
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x0014EA2C File Offset: 0x0014CC2C
		public new IChangeEntityStateBatchDirectly_SetValue ToSetValue()
		{
			return new IChangeEntityStateBatchDirectly_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				EntityIds = this.EntityIds,
				State = this.State,
				DelayChange = this.DelayChange
			};
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x06008D7B RID: 36219 RVA: 0x0014EA7A File Offset: 0x0014CC7A
		// (set) Token: 0x06008D7C RID: 36220 RVA: 0x0014EAA5 File Offset: 0x0014CCA5
		public override EChangeEntityState Type
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

		// Token: 0x17002DD6 RID: 11734
		// (get) Token: 0x06008D7D RID: 36221 RVA: 0x0014EAB3 File Offset: 0x0014CCB3
		// (set) Token: 0x06008D7E RID: 36222 RVA: 0x0014EADE File Offset: 0x0014CCDE
		public override int EntityId
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

		// Token: 0x17002DD7 RID: 11735
		// (get) Token: 0x06008D7F RID: 36223 RVA: 0x0014EAEC File Offset: 0x0014CCEC
		// (set) Token: 0x06008D80 RID: 36224 RVA: 0x0014EB13 File Offset: 0x0014CD13
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				IChangeEntityStateBatchDirectly_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17002DD8 RID: 11736
		// (get) Token: 0x06008D81 RID: 36225 RVA: 0x0014EB21 File Offset: 0x0014CD21
		// (set) Token: 0x06008D82 RID: 36226 RVA: 0x0014EB4C File Offset: 0x0014CD4C
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17002DD9 RID: 11737
		// (get) Token: 0x06008D83 RID: 36227 RVA: 0x0014EB5C File Offset: 0x0014CD5C
		// (set) Token: 0x06008D84 RID: 36228 RVA: 0x0014EB96 File Offset: 0x0014CD96
		public virtual bool? DelayChange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayChange;
				}
				IChangeEntityStateBatchDirectly_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayChange;
			}
			set
			{
				this.GetOrCreatePoco().DelayChange = value;
			}
		}

		// Token: 0x04005908 RID: 22792
		[Nullable(2)]
		protected new IChangeEntityStateBatchDirectly FbInstance;

		// Token: 0x04005909 RID: 22793
		[Nullable(2)]
		protected new IChangeEntityStateBatchDirectly_SetValue PocoInterface;
	}
}
