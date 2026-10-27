using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000869 RID: 2153
	[NullableContext(1)]
	[Nullable(0)]
	public class RefreshComponent : IComponentBase
	{
		// Token: 0x06002FAB RID: 12203 RVA: 0x0007AF88 File Offset: 0x00079188
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

		// Token: 0x06002FAC RID: 12204 RVA: 0x0007AFC0 File Offset: 0x000791C0
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

		// Token: 0x06002FAD RID: 12205 RVA: 0x0007AFD3 File Offset: 0x000791D3
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

		// Token: 0x06002FAE RID: 12206 RVA: 0x0007AFE8 File Offset: 0x000791E8
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x0007B038 File Offset: 0x00079238
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x0007B072 File Offset: 0x00079272
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

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002FB1 RID: 12209 RVA: 0x0007B080 File Offset: 0x00079280
		// (set) Token: 0x06002FB2 RID: 12210 RVA: 0x0007B0AA File Offset: 0x000792AA
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x0007B0B8 File Offset: 0x000792B8
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x0007B0DF File Offset: 0x000792DF
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

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002FB5 RID: 12213 RVA: 0x0007B0F0 File Offset: 0x000792F0
		// (set) Token: 0x06002FB6 RID: 12214 RVA: 0x0007B12A File Offset: 0x0007932A
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

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002FB7 RID: 12215 RVA: 0x0007B138 File Offset: 0x00079338
		// (set) Token: 0x06002FB8 RID: 12216 RVA: 0x0007B172 File Offset: 0x00079372
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

		// Token: 0x04001F71 RID: 8049
		[Nullable(2)]
		protected new RefreshComponent FbInstance;

		// Token: 0x04001F72 RID: 8050
		[Nullable(2)]
		protected new RefreshComponent_SetValue PocoInterface;
	}
}
