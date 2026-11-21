using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001505 RID: 5381
	public class ITakePhoto2TargetPlayMontageCondition
	{
		// Token: 0x060079D3 RID: 31187 RVA: 0x00122FC4 File Offset: 0x001211C4
		public static ITakePhoto2TargetPlayMontageCondition Create(ITakePhoto2TargetPlayMontageCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetPlayMontageCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700276B RID: 10091
		// (get) Token: 0x060079D4 RID: 31188 RVA: 0x00122FE3 File Offset: 0x001211E3
		public virtual string MontagePath
		{
			get
			{
				return this.Instance.MontagePath;
			}
		}

		// Token: 0x0400461B RID: 17947
		private ITakePhoto2TargetPlayMontageCondition Instance;
	}
}
