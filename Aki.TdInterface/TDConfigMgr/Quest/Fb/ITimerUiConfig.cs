using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001427 RID: 5159
	[NullableContext(2)]
	[Nullable(0)]
	public class ITimerUiConfig
	{
		// Token: 0x0600755E RID: 30046 RVA: 0x00118676 File Offset: 0x00116876
		[NullableContext(1)]
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

		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x0600755F RID: 30047 RVA: 0x00118695 File Offset: 0x00116895
		public virtual ETimerUiType UiType
		{
			get
			{
				return (ETimerUiType)this.Instance.UiType;
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x06007560 RID: 30048 RVA: 0x001186A2 File Offset: 0x001168A2
		public virtual string TidTitle
		{
			get
			{
				return this.Instance.TidTitle;
			}
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x06007561 RID: 30049 RVA: 0x001186AF File Offset: 0x001168AF
		public virtual string EdTidTitle
		{
			get
			{
				return null;
			}
		}

		// Token: 0x040043FD RID: 17405
		private ITimerUiConfig Instance;
	}
}
