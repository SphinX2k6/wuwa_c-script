using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141D RID: 5149
	public class IFreezeOnSightGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x060074BB RID: 29883 RVA: 0x00118BCE File Offset: 0x00116DCE
		public static IFreezeOnSightGamePlayConfig Create(IFreezeOnSightGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFreezeOnSightGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x060074BC RID: 29884 RVA: 0x00118BED File Offset: 0x00116DED
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x0400429B RID: 17051
		private IFreezeOnSightGamePlayConfig Instance;
	}
}
