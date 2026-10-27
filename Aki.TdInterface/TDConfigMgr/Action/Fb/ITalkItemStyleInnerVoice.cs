using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002546 RID: 9542
	public class ITalkItemStyleInnerVoice : ITalkItemStyle
	{
		// Token: 0x0600D4C1 RID: 54465 RVA: 0x001F8126 File Offset: 0x001F6326
		[NullableContext(1)]
		public static ITalkItemStyleInnerVoice Create(ITalkItemStyleInnerVoice? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemStyleInnerVoice
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x0600D4C2 RID: 54466 RVA: 0x001F8145 File Offset: 0x001F6345
		public override ETalkItemStyle Type
		{
			get
			{
				return (ETalkItemStyle)this.Instance.Type;
			}
		}

		// Token: 0x0400749E RID: 29854
		private ITalkItemStyleInnerVoice Instance;
	}
}
