using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002547 RID: 9543
	public class ITalkItemStylePhoneSendError : ITalkItemStyle
	{
		// Token: 0x0600D4C4 RID: 54468 RVA: 0x001F815A File Offset: 0x001F635A
		[NullableContext(1)]
		public static ITalkItemStylePhoneSendError Create(ITalkItemStylePhoneSendError? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStylePhoneSendError
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x0600D4C5 RID: 54469 RVA: 0x001F8179 File Offset: 0x001F6379
		public override ETalkItemStyle Type
		{
			get
			{
				return (ETalkItemStyle)this.Instance.Type;
			}
		}

		// Token: 0x0400749F RID: 29855
		private ITalkItemStylePhoneSendError Instance;
	}
}
