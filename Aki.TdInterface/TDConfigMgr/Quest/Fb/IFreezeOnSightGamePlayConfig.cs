using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D7 RID: 4823
	public class IFreezeOnSightGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x06006E3D RID: 28221 RVA: 0x0010A93E File Offset: 0x00108B3E
		[NullableContext(1)]
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

		// Token: 0x17002262 RID: 8802
		// (get) Token: 0x06006E3E RID: 28222 RVA: 0x0010A95D File Offset: 0x00108B5D
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04003F2D RID: 16173
		private IFreezeOnSightGamePlayConfig Instance;
	}
}
