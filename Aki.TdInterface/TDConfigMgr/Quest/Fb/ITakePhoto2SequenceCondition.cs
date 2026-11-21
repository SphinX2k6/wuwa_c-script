using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001504 RID: 5380
	public class ITakePhoto2SequenceCondition
	{
		// Token: 0x060079D0 RID: 31184 RVA: 0x00122F90 File Offset: 0x00121190
		public static ITakePhoto2SequenceCondition Create(ITakePhoto2SequenceCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2SequenceCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x060079D1 RID: 31185 RVA: 0x00122FAF File Offset: 0x001211AF
		public virtual string SequencePath
		{
			get
			{
				return this.Instance.SequencePath;
			}
		}

		// Token: 0x0400461A RID: 17946
		private ITakePhoto2SequenceCondition Instance;
	}
}
