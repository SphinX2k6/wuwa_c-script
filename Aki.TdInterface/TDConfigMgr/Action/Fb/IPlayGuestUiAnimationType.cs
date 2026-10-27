using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0D RID: 10765
	public class IPlayGuestUiAnimationType
	{
		// Token: 0x0600ED6E RID: 60782 RVA: 0x00229D7A File Offset: 0x00227F7A
		[NullableContext(1)]
		public static IPlayGuestUiAnimationType Create(IPlayGuestUiAnimationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayGuestUiAnimationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B16 RID: 19222
		// (get) Token: 0x0600ED6F RID: 60783 RVA: 0x00229D99 File Offset: 0x00227F99
		public virtual EGuestUiAnimationType Type
		{
			get
			{
				return (EGuestUiAnimationType)this.Instance.Type;
			}
		}

		// Token: 0x040082B1 RID: 33457
		private IPlayGuestUiAnimationType Instance;
	}
}
