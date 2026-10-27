using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014DA RID: 5338
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeNpcAbpState : ActionParams
	{
		// Token: 0x06007986 RID: 31110 RVA: 0x00122CF0 File Offset: 0x00120EF0
		private ChangeNpcAbpState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeNpcAbpState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeNpcAbpState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeNpcAbpState_SetValue());
			}
			return result;
		}

		// Token: 0x06007987 RID: 31111 RVA: 0x00122D28 File Offset: 0x00120F28
		public static ChangeNpcAbpState Create([Nullable(2)] ChangeNpcAbpState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeNpcAbpState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007988 RID: 31112 RVA: 0x00122D3B File Offset: 0x00120F3B
		public static ChangeNpcAbpState CreateFromSetValue([Nullable(2)] ChangeNpcAbpState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeNpcAbpState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007989 RID: 31113 RVA: 0x00122D4E File Offset: 0x00120F4E
		public ChangeNpcAbpState_SetValue ToSetValue()
		{
			return new ChangeNpcAbpState_SetValue
			{
				EntityId = this.EntityId,
				AbpState = this.AbpState
			};
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600798A RID: 31114 RVA: 0x00122D6D File Offset: 0x00120F6D
		// (set) Token: 0x0600798B RID: 31115 RVA: 0x00122D98 File Offset: 0x00120F98
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

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600798C RID: 31116 RVA: 0x00122DA6 File Offset: 0x00120FA6
		// (set) Token: 0x0600798D RID: 31117 RVA: 0x00122DD1 File Offset: 0x00120FD1
		public virtual string AbpState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AbpState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.AbpState;
			}
			set
			{
				this.GetOrCreatePoco().AbpState = value;
			}
		}

		// Token: 0x04004683 RID: 18051
		[Nullable(2)]
		protected new ChangeNpcAbpState FbInstance;

		// Token: 0x04004684 RID: 18052
		[Nullable(2)]
		protected ChangeNpcAbpState_SetValue PocoInterface;
	}
}
