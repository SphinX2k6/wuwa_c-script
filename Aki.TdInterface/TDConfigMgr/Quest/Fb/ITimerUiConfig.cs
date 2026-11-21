using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200157F RID: 5503
	[NullableContext(2)]
	[Nullable(0)]
	public class ITimerUiConfig
	{
		// Token: 0x06007C23 RID: 31779 RVA: 0x001270C2 File Offset: 0x001252C2
		[NullableContext(0)]
		public static ITimerUiConfig Create(ITimerUiConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimerUiConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x06007C24 RID: 31780 RVA: 0x001270E1 File Offset: 0x001252E1
		public virtual ETimerUiType UiType
		{
			get
			{
				return (ETimerUiType)this.Instance.UiType;
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x06007C25 RID: 31781 RVA: 0x001270EE File Offset: 0x001252EE
		public virtual string TidTitle
		{
			get
			{
				return this.Instance.TidTitle;
			}
		}

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x06007C26 RID: 31782 RVA: 0x001270FB File Offset: 0x001252FB
		public virtual string EdTidTitle
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04004791 RID: 18321
		private ITimerUiConfig Instance;
	}
}
