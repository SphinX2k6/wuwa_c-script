using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001444 RID: 5188
	public class ILogicProgramSpecialProcessOperation
	{
		// Token: 0x06007554 RID: 30036 RVA: 0x00119B93 File Offset: 0x00117D93
		public static ILogicProgramSpecialProcessOperation Create(ILogicProgramSpecialProcessOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILogicProgramSpecialProcessOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x06007555 RID: 30037 RVA: 0x00119BB2 File Offset: 0x00117DB2
		public virtual ELogicProgramSpecialProcess Type
		{
			get
			{
				return (ELogicProgramSpecialProcess)this.Instance.Type;
			}
		}

		// Token: 0x040042F0 RID: 17136
		private ILogicProgramSpecialProcessOperation Instance;
	}
}
