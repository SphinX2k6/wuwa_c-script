using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CA0 RID: 3232
	public class INpcSpecialMarkIgnoreCameraHideNpc : INpcSpecialMarkBase
	{
		// Token: 0x060049DD RID: 18909 RVA: 0x000BA0AD File Offset: 0x000B82AD
		public static INpcSpecialMarkIgnoreCameraHideNpc Create(INpcSpecialMarkIgnoreCameraHideNpc? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkIgnoreCameraHideNpc
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x060049DE RID: 18910 RVA: 0x000BA0CC File Offset: 0x000B82CC
		public override ESpecialNpcMarkType Type
		{
			get
			{
				return (ESpecialNpcMarkType)this.Instance.Type;
			}
		}

		// Token: 0x040029D3 RID: 10707
		private INpcSpecialMarkIgnoreCameraHideNpc Instance;
	}
}
