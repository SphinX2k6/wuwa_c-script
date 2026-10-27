using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014CA RID: 5322
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeElementalBoxState : ActionParams
	{
		// Token: 0x06007932 RID: 31026 RVA: 0x001223EC File Offset: 0x001205EC
		private ChangeElementalBoxState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeElementalBoxState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeElementalBoxState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeElementalBoxState_SetValue());
			}
			return result;
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x00122424 File Offset: 0x00120624
		public static ChangeElementalBoxState Create([Nullable(2)] ChangeElementalBoxState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeElementalBoxState
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x00122437 File Offset: 0x00120637
		public static ChangeElementalBoxState CreateFromSetValue([Nullable(2)] ChangeElementalBoxState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeElementalBoxState
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x0012244A File Offset: 0x0012064A
		public ChangeElementalBoxState_SetValue ToSetValue()
		{
			return new ChangeElementalBoxState_SetValue
			{
				Target = this.Target,
				State = this.State
			};
		}

		// Token: 0x170028A0 RID: 10400
		// (get) Token: 0x06007936 RID: 31030 RVA: 0x00122469 File Offset: 0x00120669
		// (set) Token: 0x06007937 RID: 31031 RVA: 0x00122490 File Offset: 0x00120690
		public virtual IChangeElementalBoxStateTarget Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ChangeElementalBoxState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x170028A1 RID: 10401
		// (get) Token: 0x06007938 RID: 31032 RVA: 0x0012249E File Offset: 0x0012069E
		// (set) Token: 0x06007939 RID: 31033 RVA: 0x001224C9 File Offset: 0x001206C9
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

		// Token: 0x0400465D RID: 18013
		[Nullable(2)]
		protected new ChangeElementalBoxState FbInstance;

		// Token: 0x0400465E RID: 18014
		[Nullable(2)]
		protected ChangeElementalBoxState_SetValue PocoInterface;
	}
}
