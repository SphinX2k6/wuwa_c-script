using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001506 RID: 5382
	public class ITakePhoto2TargetAnsTagCondition
	{
		// Token: 0x060079D6 RID: 31190 RVA: 0x00122FF8 File Offset: 0x001211F8
		public static ITakePhoto2TargetAnsTagCondition Create(ITakePhoto2TargetAnsTagCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetAnsTagCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x00123017 File Offset: 0x00121217
		public virtual string MontageTag
		{
			get
			{
				return this.Instance.MontageTag;
			}
		}

		// Token: 0x0400461C RID: 17948
		private ITakePhoto2TargetAnsTagCondition Instance;
	}
}
