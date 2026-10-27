using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014E6 RID: 5350
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeSelfEntityState : ActionParams
	{
		// Token: 0x060079C2 RID: 31170 RVA: 0x0012334C File Offset: 0x0012154C
		private ChangeSelfEntityState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeSelfEntityState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeSelfEntityState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeSelfEntityState_SetValue());
			}
			return result;
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x00123384 File Offset: 0x00121584
		public static ChangeSelfEntityState Create([Nullable(2)] ChangeSelfEntityState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeSelfEntityState
			{
				FbInstance = instance
			};
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x00123397 File Offset: 0x00121597
		public static ChangeSelfEntityState CreateFromSetValue([Nullable(2)] ChangeSelfEntityState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeSelfEntityState
			{
				PocoInterface = value
			};
		}

		// Token: 0x060079C5 RID: 31173 RVA: 0x001233AA File Offset: 0x001215AA
		public ChangeSelfEntityState_SetValue ToSetValue()
		{
			return new ChangeSelfEntityState_SetValue
			{
				EntityState = this.EntityState
			};
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x060079C6 RID: 31174 RVA: 0x001233BD File Offset: 0x001215BD
		// (set) Token: 0x060079C7 RID: 31175 RVA: 0x001233E8 File Offset: 0x001215E8
		public virtual string EntityState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EntityState;
			}
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x0400469D RID: 18077
		[Nullable(2)]
		protected new ChangeSelfEntityState FbInstance;

		// Token: 0x0400469E RID: 18078
		[Nullable(2)]
		protected ChangeSelfEntityState_SetValue PocoInterface;
	}
}
