using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001623 RID: 5667
	public class ChangeElementalBoxState : ActionParams
	{
		// Token: 0x06007FFF RID: 32767 RVA: 0x00131038 File Offset: 0x0012F238
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

		// Token: 0x06008000 RID: 32768 RVA: 0x00131070 File Offset: 0x0012F270
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

		// Token: 0x06008001 RID: 32769 RVA: 0x00131083 File Offset: 0x0012F283
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

		// Token: 0x06008002 RID: 32770 RVA: 0x00131096 File Offset: 0x0012F296
		public ChangeElementalBoxState_SetValue ToSetValue()
		{
			return new ChangeElementalBoxState_SetValue
			{
				Target = this.Target,
				State = this.State
			};
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x06008003 RID: 32771 RVA: 0x001310B5 File Offset: 0x0012F2B5
		// (set) Token: 0x06008004 RID: 32772 RVA: 0x001310DC File Offset: 0x0012F2DC
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

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x06008005 RID: 32773 RVA: 0x001310EA File Offset: 0x0012F2EA
		// (set) Token: 0x06008006 RID: 32774 RVA: 0x00131115 File Offset: 0x0012F315
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

		// Token: 0x040049F8 RID: 18936
		[Nullable(2)]
		protected new ChangeElementalBoxState FbInstance;

		// Token: 0x040049F9 RID: 18937
		[Nullable(2)]
		protected ChangeElementalBoxState_SetValue PocoInterface;
	}
}
