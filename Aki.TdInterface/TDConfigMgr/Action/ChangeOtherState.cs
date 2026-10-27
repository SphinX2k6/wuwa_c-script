using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014DE RID: 5342
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeOtherState : ActionParams
	{
		// Token: 0x0600799A RID: 31130 RVA: 0x00122EF0 File Offset: 0x001210F0
		private ChangeOtherState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeOtherState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeOtherState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeOtherState_SetValue());
			}
			return result;
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x00122F28 File Offset: 0x00121128
		public static ChangeOtherState Create([Nullable(2)] ChangeOtherState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeOtherState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x00122F3B File Offset: 0x0012113B
		public static ChangeOtherState CreateFromSetValue([Nullable(2)] ChangeOtherState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeOtherState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x00122F4E File Offset: 0x0012114E
		public ChangeOtherState_SetValue ToSetValue()
		{
			return new ChangeOtherState_SetValue
			{
				EntityId = this.EntityId,
				State = this.State
			};
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x0600799E RID: 31134 RVA: 0x00122F6D File Offset: 0x0012116D
		// (set) Token: 0x0600799F RID: 31135 RVA: 0x00122F98 File Offset: 0x00121198
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

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x060079A0 RID: 31136 RVA: 0x00122FA8 File Offset: 0x001211A8
		// (set) Token: 0x060079A1 RID: 31137 RVA: 0x00123009 File Offset: 0x00121209
		public virtual PlayFlow State
		{
			get
			{
				if (this._StateInited)
				{
					return this._StateCache;
				}
				this._StateInited = true;
				if (this.FbInstance != null)
				{
					this._StateCache = PlayFlow.Create(this.FbInstance.State);
				}
				else
				{
					ChangeOtherState_SetValue pocoInterface = this.PocoInterface;
					this._StateCache = ((pocoInterface != null) ? pocoInterface.State : null);
				}
				return this._StateCache;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
				this._StateInited = false;
			}
		}

		// Token: 0x0400468B RID: 18059
		[Nullable(2)]
		protected new ChangeOtherState FbInstance;

		// Token: 0x0400468C RID: 18060
		[Nullable(2)]
		protected ChangeOtherState_SetValue PocoInterface;

		// Token: 0x0400468D RID: 18061
		private PlayFlow _StateCache;

		// Token: 0x0400468E RID: 18062
		private bool _StateInited;
	}
}
