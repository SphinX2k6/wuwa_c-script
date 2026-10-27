using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002610 RID: 9744
	[NullableContext(2)]
	[Nullable(0)]
	public class IGamePadInteractVibration
	{
		// Token: 0x0600DAC4 RID: 56004 RVA: 0x0020965D File Offset: 0x0020785D
		[NullableContext(1)]
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

		// Token: 0x17004066 RID: 16486
		// (get) Token: 0x0600DAC5 RID: 56005 RVA: 0x0020967C File Offset: 0x0020787C
		public virtual string LongPressingEffect
		{
			get
			{
				return this.Instance.LongPressingEffect;
			}
		}

		// Token: 0x17004067 RID: 16487
		// (get) Token: 0x0600DAC6 RID: 56006 RVA: 0x00209689 File Offset: 0x00207889
		public virtual string LongPressFinishedEffect
		{
			get
			{
				return this.Instance.LongPressFinishedEffect;
			}
		}

		// Token: 0x04007982 RID: 31106
		private IGamePadInteractVibration Instance;
	}
}
