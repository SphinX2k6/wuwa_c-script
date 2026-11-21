using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001450 RID: 5200
	public class IFastReturnPosBase
	{
		// Token: 0x060075AF RID: 30127 RVA: 0x0011A967 File Offset: 0x00118B67
		public static IFastReturnPosBase Create(IFastReturnPosBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFastReturnPosBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x060075B0 RID: 30128 RVA: 0x0011A986 File Offset: 0x00118B86
		public virtual EFastReturnPosType Type
		{
			get
			{
				return (EFastReturnPosType)this.Instance.Type;
			}
		}

		// Token: 0x0400433A RID: 17210
		private IFastReturnPosBase Instance;
	}
}
