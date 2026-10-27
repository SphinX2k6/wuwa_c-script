using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200186C RID: 6252
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeEntityStateBatchDirectly : ChangeEntityState
	{
		// Token: 0x0600864F RID: 34383 RVA: 0x0013F198 File Offset: 0x0013D398
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

		// Token: 0x06008650 RID: 34384 RVA: 0x0013F1D0 File Offset: 0x0013D3D0
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

		// Token: 0x06008651 RID: 34385 RVA: 0x0013F1E3 File Offset: 0x0013D3E3
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

		// Token: 0x06008652 RID: 34386 RVA: 0x0013F1F8 File Offset: 0x0013D3F8
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

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x06008653 RID: 34387 RVA: 0x0013F246 File Offset: 0x0013D446
		// (set) Token: 0x06008654 RID: 34388 RVA: 0x0013F271 File Offset: 0x0013D471
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

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x06008655 RID: 34389 RVA: 0x0013F27F File Offset: 0x0013D47F
		// (set) Token: 0x06008656 RID: 34390 RVA: 0x0013F2AA File Offset: 0x0013D4AA
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

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x06008657 RID: 34391 RVA: 0x0013F2B8 File Offset: 0x0013D4B8
		// (set) Token: 0x06008658 RID: 34392 RVA: 0x0013F2DF File Offset: 0x0013D4DF
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

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06008659 RID: 34393 RVA: 0x0013F2ED File Offset: 0x0013D4ED
		// (set) Token: 0x0600865A RID: 34394 RVA: 0x0013F318 File Offset: 0x0013D518
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

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x0600865B RID: 34395 RVA: 0x0013F328 File Offset: 0x0013D528
		// (set) Token: 0x0600865C RID: 34396 RVA: 0x0013F362 File Offset: 0x0013D562
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

		// Token: 0x040054BB RID: 21691
		[Nullable(2)]
		protected new IChangeEntityStateBatchDirectly FbInstance;

		// Token: 0x040054BC RID: 21692
		[Nullable(2)]
		protected new IChangeEntityStateBatchDirectly_SetValue PocoInterface;
	}
}
