using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AE6 RID: 2790
	[NullableContext(1)]
	[Nullable(0)]
	public class ICountDownTextTip : ITrampleTipType
	{
		// Token: 0x06004037 RID: 16439 RVA: 0x000A3EC1 File Offset: 0x000A20C1
		public static ICountDownTextTip Create(ICountDownTextTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICountDownTextTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x000A3EE0 File Offset: 0x000A20E0
		public override ETrampleTipType Type
		{
			get
			{
				return (ETrampleTipType)this.Instance.Type;
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x000A3EED File Offset: 0x000A20ED
		public virtual string TidCountDownTip
		{
			get
			{
				return this.Instance.TidCountDownTip;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x000A3EFA File Offset: 0x000A20FA
		[Nullable(2)]
		public virtual string EdTidCountDownTip
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040023B9 RID: 9145
		private ICountDownTextTip Instance;
	}
}
