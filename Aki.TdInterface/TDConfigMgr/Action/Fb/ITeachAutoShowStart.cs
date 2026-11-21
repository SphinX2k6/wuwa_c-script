using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2F RID: 10799
	public class ITeachAutoShowStart : ICommonTipType
	{
		// Token: 0x0600EEA2 RID: 61090 RVA: 0x0022FE98 File Offset: 0x0022E098
		public static ITeachAutoShowStart Create(ITeachAutoShowStart? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeachAutoShowStart
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046F2 RID: 18162
		// (get) Token: 0x0600EEA3 RID: 61091 RVA: 0x0022FEB7 File Offset: 0x0022E0B7
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046F3 RID: 18163
		// (get) Token: 0x0600EEA4 RID: 61092 RVA: 0x0022FEC4 File Offset: 0x0022E0C4
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170046F4 RID: 18164
		// (get) Token: 0x0600EEA5 RID: 61093 RVA: 0x0022FED1 File Offset: 0x0022E0D1
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008311 RID: 33553
		private ITeachAutoShowStart Instance;
	}
}
