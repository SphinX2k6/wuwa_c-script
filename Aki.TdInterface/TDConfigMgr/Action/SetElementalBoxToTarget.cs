using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002416 RID: 9238
	public class SetElementalBoxToTarget : ActionParams
	{
		// Token: 0x0600C8FE RID: 51454 RVA: 0x001CB49C File Offset: 0x001C969C
		private SetElementalBoxToTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetElementalBoxToTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetElementalBoxToTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetElementalBoxToTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600C8FF RID: 51455 RVA: 0x001CB4D4 File Offset: 0x001C96D4
		public static SetElementalBoxToTarget Create([Nullable(2)] SetElementalBoxToTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetElementalBoxToTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C900 RID: 51456 RVA: 0x001CB4E7 File Offset: 0x001C96E7
		public static SetElementalBoxToTarget CreateFromSetValue([Nullable(2)] SetElementalBoxToTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetElementalBoxToTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C901 RID: 51457 RVA: 0x001CB4FA File Offset: 0x001C96FA
		public SetElementalBoxToTarget_SetValue ToSetValue()
		{
			return new SetElementalBoxToTarget_SetValue
			{
				ElementalBoxId = this.ElementalBoxId,
				Target = this.Target
			};
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x0600C902 RID: 51458 RVA: 0x001CB519 File Offset: 0x001C9719
		// (set) Token: 0x0600C903 RID: 51459 RVA: 0x001CB544 File Offset: 0x001C9744
		public virtual int ElementalBoxId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ElementalBoxId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ElementalBoxId;
			}
			set
			{
				this.GetOrCreatePoco().ElementalBoxId = value;
			}
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x0600C904 RID: 51460 RVA: 0x001CB552 File Offset: 0x001C9752
		// (set) Token: 0x0600C905 RID: 51461 RVA: 0x001CB579 File Offset: 0x001C9779
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				SetElementalBoxToTarget_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04007737 RID: 30519
		[Nullable(2)]
		protected new SetElementalBoxToTarget FbInstance;

		// Token: 0x04007738 RID: 30520
		[Nullable(2)]
		protected SetElementalBoxToTarget_SetValue PocoInterface;
	}
}
