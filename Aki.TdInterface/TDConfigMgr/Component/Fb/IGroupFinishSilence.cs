using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C75 RID: 3189
	[NullableContext(2)]
	[Nullable(0)]
	public class IGroupFinishSilence : IGroupFinishConfig
	{
		// Token: 0x060048CE RID: 18638 RVA: 0x000B7E95 File Offset: 0x000B6095
		[NullableContext(0)]
		public static IGroupFinishSilence Create(IGroupFinishSilence? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishSilence
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x060048CF RID: 18639 RVA: 0x000B7EB4 File Offset: 0x000B60B4
		public override EGroupFinishConfig Type
		{
			get
			{
				return (EGroupFinishConfig)this.Instance.Type;
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x000B7EC1 File Offset: 0x000B60C1
		public virtual IEntityState SwitchSpecifiedStatus
		{
			get
			{
				if (this._SwitchSpecifiedStatusInited)
				{
					return this._SwitchSpecifiedStatusCache;
				}
				this._SwitchSpecifiedStatusInited = true;
				this._SwitchSpecifiedStatusCache = IEntityState.Create(this.Instance.SwitchSpecifiedStatus);
				return this._SwitchSpecifiedStatusCache;
			}
		}

		// Token: 0x040028EE RID: 10478
		private IGroupFinishSilence Instance;

		// Token: 0x040028EF RID: 10479
		private IEntityState _SwitchSpecifiedStatusCache;

		// Token: 0x040028F0 RID: 10480
		private bool _SwitchSpecifiedStatusInited;
	}
}
