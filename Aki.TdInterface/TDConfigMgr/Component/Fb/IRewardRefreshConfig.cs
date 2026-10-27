using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AAC RID: 2732
	[NullableContext(1)]
	[Nullable(0)]
	public class IRewardRefreshConfig
	{
		// Token: 0x06003F01 RID: 16129 RVA: 0x000A12AA File Offset: 0x0009F4AA
		public static IRewardRefreshConfig Create(IRewardRefreshConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRewardRefreshConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x000A12C9 File Offset: 0x0009F4C9
		public virtual IRefreshConditionBase RefreshCondition
		{
			get
			{
				if (this._RefreshConditionInited)
				{
					return this._RefreshConditionCache;
				}
				this._RefreshConditionInited = true;
				this._RefreshConditionCache = ComponentReadHelper.ReadIRewardRefreshConfig_RefreshCondition(this.Instance);
				return this._RefreshConditionCache;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06003F03 RID: 16131 RVA: 0x000A12F8 File Offset: 0x0009F4F8
		public virtual IRefreshRule RefreshType
		{
			get
			{
				if (this._RefreshTypeInited)
				{
					return this._RefreshTypeCache;
				}
				this._RefreshTypeInited = true;
				this._RefreshTypeCache = ComponentReadHelper.ReadIRewardRefreshConfig_RefreshType(this.Instance);
				return this._RefreshTypeCache;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x000A1328 File Offset: 0x0009F528
		public virtual int? MaxCount
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MaxCount);
			}
		}

		// Token: 0x040022FD RID: 8957
		private IRewardRefreshConfig Instance;

		// Token: 0x040022FE RID: 8958
		private IRefreshConditionBase _RefreshConditionCache;

		// Token: 0x040022FF RID: 8959
		private bool _RefreshConditionInited;

		// Token: 0x04002300 RID: 8960
		private IRefreshRule _RefreshTypeCache;

		// Token: 0x04002301 RID: 8961
		private bool _RefreshTypeInited;
	}
}
