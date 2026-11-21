using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200241A RID: 9242
	public class SetEntityClientVisibleSave : ActionParams
	{
		// Token: 0x0600C912 RID: 51474 RVA: 0x001CB694 File Offset: 0x001C9894
		private SetEntityClientVisibleSave_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetEntityClientVisibleSave 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetEntityClientVisibleSave_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetEntityClientVisibleSave_SetValue());
			}
			return result;
		}

		// Token: 0x0600C913 RID: 51475 RVA: 0x001CB6CC File Offset: 0x001C98CC
		public static SetEntityClientVisibleSave Create([Nullable(2)] SetEntityClientVisibleSave instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityClientVisibleSave
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C914 RID: 51476 RVA: 0x001CB6DF File Offset: 0x001C98DF
		public static SetEntityClientVisibleSave CreateFromSetValue([Nullable(2)] SetEntityClientVisibleSave_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetEntityClientVisibleSave
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C915 RID: 51477 RVA: 0x001CB6F2 File Offset: 0x001C98F2
		public SetEntityClientVisibleSave_SetValue ToSetValue()
		{
			return new SetEntityClientVisibleSave_SetValue
			{
				EntityIds = this.EntityIds,
				Visible = this.Visible
			};
		}

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x0600C916 RID: 51478 RVA: 0x001CB711 File Offset: 0x001C9911
		// (set) Token: 0x0600C917 RID: 51479 RVA: 0x001CB738 File Offset: 0x001C9938
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				SetEntityClientVisibleSave_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x0600C918 RID: 51480 RVA: 0x001CB746 File Offset: 0x001C9946
		// (set) Token: 0x0600C919 RID: 51481 RVA: 0x001CB771 File Offset: 0x001C9971
		public virtual bool Visible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Visible;
				}
				return this.PocoInterface != null && this.PocoInterface.Visible;
			}
			set
			{
				this.GetOrCreatePoco().Visible = value;
			}
		}

		// Token: 0x0400773F RID: 30527
		[Nullable(2)]
		protected new SetEntityClientVisibleSave FbInstance;

		// Token: 0x04007740 RID: 30528
		[Nullable(2)]
		protected SetEntityClientVisibleSave_SetValue PocoInterface;
	}
}
