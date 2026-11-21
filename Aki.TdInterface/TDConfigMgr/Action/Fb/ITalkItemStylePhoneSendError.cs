using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027EE RID: 10222
	public class ITalkItemStylePhoneSendError : ITalkItemStyle
	{
		// Token: 0x0600E224 RID: 57892 RVA: 0x00213BBA File Offset: 0x00211DBA
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

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x0600E225 RID: 57893 RVA: 0x00213BD9 File Offset: 0x00211DD9
		public override ETalkItemStyle Type
		{
			get
			{
				return (ETalkItemStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007AF4 RID: 31476
		private ITalkItemStylePhoneSendError Instance;
	}
}
