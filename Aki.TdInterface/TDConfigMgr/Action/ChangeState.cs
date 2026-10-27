using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014E8 RID: 5352
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeState : ActionParams
	{
		// Token: 0x060079CA RID: 31178 RVA: 0x00123408 File Offset: 0x00121608
		private ChangeState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeState_SetValue());
			}
			return result;
		}

		// Token: 0x060079CB RID: 31179 RVA: 0x00123440 File Offset: 0x00121640
		public static ChangeState Create([Nullable(2)] ChangeState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060079CC RID: 31180 RVA: 0x00123453 File Offset: 0x00121653
		public static ChangeState CreateFromSetValue([Nullable(2)] ChangeState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060079CD RID: 31181 RVA: 0x00123466 File Offset: 0x00121666
		public ChangeState_SetValue ToSetValue()
		{
			return new ChangeState_SetValue
			{
				StateId = this.StateId
			};
		}

		// Token: 0x170028BF RID: 10431
		// (get) Token: 0x060079CE RID: 31182 RVA: 0x00123479 File Offset: 0x00121679
		// (set) Token: 0x060079CF RID: 31183 RVA: 0x001234A4 File Offset: 0x001216A4
		public virtual int StateId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StateId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.StateId;
			}
			set
			{
				this.GetOrCreatePoco().StateId = value;
			}
		}

		// Token: 0x040046A0 RID: 18080
		[Nullable(2)]
		protected new ChangeState FbInstance;

		// Token: 0x040046A1 RID: 18081
		[Nullable(2)]
		protected ChangeState_SetValue PocoInterface;
	}
}
