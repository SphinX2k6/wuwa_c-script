using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090C RID: 2316
	public class RefreshComponent : IComponentBase
	{
		// Token: 0x060032E7 RID: 13031 RVA: 0x00082470 File Offset: 0x00080670
		private RefreshComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RefreshComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RefreshComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RefreshComponent_SetValue());
			}
			return result;
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x000824A8 File Offset: 0x000806A8
		public static RefreshComponent Create([Nullable(2)] RefreshComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RefreshComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x000824BB File Offset: 0x000806BB
		public static RefreshComponent CreateFromSetValue([Nullable(2)] RefreshComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RefreshComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x000824D0 File Offset: 0x000806D0
		public new RefreshComponent_SetValue ToSetValue()
		{
			return new RefreshComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				RefreshRule = this.RefreshRule,
				IsDisableRefreshAfterDroppingReward = this.IsDisableRefreshAfterDroppingReward,
				IsResetOnDungeonRestart = this.IsResetOnDungeonRestart
			};
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x060032EB RID: 13035 RVA: 0x00082520 File Offset: 0x00080720
		// (set) Token: 0x060032EC RID: 13036 RVA: 0x0008255A File Offset: 0x0008075A
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				RefreshComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x060032ED RID: 13037 RVA: 0x00082568 File Offset: 0x00080768
		// (set) Token: 0x060032EE RID: 13038 RVA: 0x00082592 File Offset: 0x00080792
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x060032EF RID: 13039 RVA: 0x000825A0 File Offset: 0x000807A0
		// (set) Token: 0x060032F0 RID: 13040 RVA: 0x000825C7 File Offset: 0x000807C7
		public virtual IRefreshRule RefreshRule
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RefreshRule;
				}
				RefreshComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RefreshRule;
			}
			set
			{
				this.GetOrCreatePoco().RefreshRule = value;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x060032F1 RID: 13041 RVA: 0x000825D8 File Offset: 0x000807D8
		// (set) Token: 0x060032F2 RID: 13042 RVA: 0x00082612 File Offset: 0x00080812
		public virtual bool? IsDisableRefreshAfterDroppingReward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDisableRefreshAfterDroppingReward;
				}
				RefreshComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDisableRefreshAfterDroppingReward;
			}
			set
			{
				this.GetOrCreatePoco().IsDisableRefreshAfterDroppingReward = value;
			}
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x060032F3 RID: 13043 RVA: 0x00082620 File Offset: 0x00080820
		// (set) Token: 0x060032F4 RID: 13044 RVA: 0x0008265A File Offset: 0x0008085A
		public virtual bool? IsResetOnDungeonRestart
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsResetOnDungeonRestart;
				}
				RefreshComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsResetOnDungeonRestart;
			}
			set
			{
				this.GetOrCreatePoco().IsResetOnDungeonRestart = value;
			}
		}

		// Token: 0x04002183 RID: 8579
		[Nullable(2)]
		protected new RefreshComponent FbInstance;

		// Token: 0x04002184 RID: 8580
		[Nullable(2)]
		protected new RefreshComponent_SetValue PocoInterface;
	}
}
