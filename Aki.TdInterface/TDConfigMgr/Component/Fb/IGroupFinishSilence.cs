using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA7 RID: 2983
	[NullableContext(2)]
	[Nullable(0)]
	public class IGroupFinishSilence : IGroupFinishConfig
	{
		// Token: 0x06004475 RID: 17525 RVA: 0x000ADDD1 File Offset: 0x000ABFD1
		[NullableContext(1)]
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

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x000ADDF0 File Offset: 0x000ABFF0
		public override EGroupFinishConfig Type
		{
			get
			{
				return (EGroupFinishConfig)this.Instance.Type;
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x000ADDFD File Offset: 0x000ABFFD
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

		// Token: 0x040026A6 RID: 9894
		private IGroupFinishSilence Instance;

		// Token: 0x040026A7 RID: 9895
		private IEntityState _SwitchSpecifiedStatusCache;

		// Token: 0x040026A8 RID: 9896
		private bool _SwitchSpecifiedStatusInited;
	}
}
