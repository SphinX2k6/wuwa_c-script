using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BD2 RID: 3026
	public class INpcSpecialMarkIgnoreCameraHideNpc : INpcSpecialMarkBase
	{
		// Token: 0x06004584 RID: 17796 RVA: 0x000AFFE9 File Offset: 0x000AE1E9
		[NullableContext(1)]
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

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x000B0008 File Offset: 0x000AE208
		public override ESpecialNpcMarkType Type
		{
			get
			{
				return (ESpecialNpcMarkType)this.Instance.Type;
			}
		}

		// Token: 0x0400278B RID: 10123
		private INpcSpecialMarkIgnoreCameraHideNpc Instance;
	}
}
