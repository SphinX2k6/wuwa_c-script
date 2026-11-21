using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D0 RID: 10448
	[NullableContext(2)]
	[Nullable(0)]
	public class IGamePadInteractVibration
	{
		// Token: 0x0600E891 RID: 59537 RVA: 0x00225DB1 File Offset: 0x00223FB1
		[NullableContext(0)]
		public static IGamePadInteractVibration Create(IGamePadInteractVibration? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamePadInteractVibration
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700439F RID: 17311
		// (get) Token: 0x0600E892 RID: 59538 RVA: 0x00225DD0 File Offset: 0x00223FD0
		public virtual string LongPressingEffect
		{
			get
			{
				return this.Instance.LongPressingEffect;
			}
		}

		// Token: 0x170043A0 RID: 17312
		// (get) Token: 0x0600E893 RID: 59539 RVA: 0x00225DDD File Offset: 0x00223FDD
		public virtual string LongPressFinishedEffect
		{
			get
			{
				return this.Instance.LongPressFinishedEffect;
			}
		}

		// Token: 0x0400801C RID: 32796
		private IGamePadInteractVibration Instance;
	}
}
