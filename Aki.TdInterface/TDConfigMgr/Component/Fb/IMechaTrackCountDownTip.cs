using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB1 RID: 2993
	public class IMechaTrackCountDownTip : ITrampleTipType
	{
		// Token: 0x06004466 RID: 17510 RVA: 0x000AD4F9 File Offset: 0x000AB6F9
		public static IMechaTrackCountDownTip Create(IMechaTrackCountDownTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechaTrackCountDownTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06004467 RID: 17511 RVA: 0x000AD518 File Offset: 0x000AB718
		public override ETrampleTipType Type
		{
			get
			{
				return (ETrampleTipType)this.Instance.Type;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06004468 RID: 17512 RVA: 0x000AD525 File Offset: 0x000AB725
		public virtual string TidCountDownTip
		{
			get
			{
				return this.Instance.TidCountDownTip;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06004469 RID: 17513 RVA: 0x000AD532 File Offset: 0x000AB732
		[Nullable(2)]
		public virtual string EdTidCountDownTip
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040025D6 RID: 9686
		private IMechaTrackCountDownTip Instance;
	}
}
