using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014DC RID: 5340
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeNpcPerformState : ActionParams
	{
		// Token: 0x06007990 RID: 31120 RVA: 0x00122DF0 File Offset: 0x00120FF0
		private ChangeNpcPerformState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeNpcPerformState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeNpcPerformState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeNpcPerformState_SetValue());
			}
			return result;
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x00122E28 File Offset: 0x00121028
		public static ChangeNpcPerformState Create([Nullable(2)] ChangeNpcPerformState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeNpcPerformState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x00122E3B File Offset: 0x0012103B
		public static ChangeNpcPerformState CreateFromSetValue([Nullable(2)] ChangeNpcPerformState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeNpcPerformState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x00122E4E File Offset: 0x0012104E
		public ChangeNpcPerformState_SetValue ToSetValue()
		{
			return new ChangeNpcPerformState_SetValue
			{
				EntityId = this.EntityId,
				State = this.State
			};
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x06007994 RID: 31124 RVA: 0x00122E6D File Offset: 0x0012106D
		// (set) Token: 0x06007995 RID: 31125 RVA: 0x00122E98 File Offset: 0x00121098
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

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x06007996 RID: 31126 RVA: 0x00122EA6 File Offset: 0x001210A6
		// (set) Token: 0x06007997 RID: 31127 RVA: 0x00122ED1 File Offset: 0x001210D1
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

		// Token: 0x04004687 RID: 18055
		[Nullable(2)]
		protected new ChangeNpcPerformState FbInstance;

		// Token: 0x04004688 RID: 18056
		[Nullable(2)]
		protected ChangeNpcPerformState_SetValue PocoInterface;
	}
}
