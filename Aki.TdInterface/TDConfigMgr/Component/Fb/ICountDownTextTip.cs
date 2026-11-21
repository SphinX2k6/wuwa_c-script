using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BB0 RID: 2992
	public class ICountDownTextTip : ITrampleTipType
	{
		// Token: 0x06004461 RID: 17505 RVA: 0x000AD4B5 File Offset: 0x000AB6B5
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

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06004462 RID: 17506 RVA: 0x000AD4D4 File Offset: 0x000AB6D4
		public override ETrampleTipType Type
		{
			get
			{
				return (ETrampleTipType)this.Instance.Type;
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06004463 RID: 17507 RVA: 0x000AD4E1 File Offset: 0x000AB6E1
		public virtual string TidCountDownTip
		{
			get
			{
				return this.Instance.TidCountDownTip;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06004464 RID: 17508 RVA: 0x000AD4EE File Offset: 0x000AB6EE
		[Nullable(2)]
		public virtual string EdTidCountDownTip
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040025D5 RID: 9685
		private ICountDownTextTip Instance;
	}
}
