using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027ED RID: 10221
	public class ITalkItemStyleInnerVoice : ITalkItemStyle
	{
		// Token: 0x0600E221 RID: 57889 RVA: 0x00213B86 File Offset: 0x00211D86
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

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x0600E222 RID: 57890 RVA: 0x00213BA5 File Offset: 0x00211DA5
		public override ETalkItemStyle Type
		{
			get
			{
				return (ETalkItemStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007AF3 RID: 31475
		private ITalkItemStyleInnerVoice Instance;
	}
}
