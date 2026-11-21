using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A30 RID: 10800
	public class ITeachAutoShowEnd : ICommonTipType
	{
		// Token: 0x0600EEA7 RID: 61095 RVA: 0x0022FEDC File Offset: 0x0022E0DC
		public static ITeachAutoShowEnd Create(ITeachAutoShowEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeachAutoShowEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046F5 RID: 18165
		// (get) Token: 0x0600EEA8 RID: 61096 RVA: 0x0022FEFB File Offset: 0x0022E0FB
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046F6 RID: 18166
		// (get) Token: 0x0600EEA9 RID: 61097 RVA: 0x0022FF08 File Offset: 0x0022E108
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170046F7 RID: 18167
		// (get) Token: 0x0600EEAA RID: 61098 RVA: 0x0022FF15 File Offset: 0x0022E115
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008312 RID: 33554
		private ITeachAutoShowEnd Instance;
	}
}
