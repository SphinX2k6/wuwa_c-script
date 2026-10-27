using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001300 RID: 4864
	public class IFastReturnPosBase
	{
		// Token: 0x06006F0F RID: 28431 RVA: 0x0010C3FB File Offset: 0x0010A5FB
		[NullableContext(1)]
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

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x06006F10 RID: 28432 RVA: 0x0010C41A File Offset: 0x0010A61A
		public virtual EFastReturnPosType Type
		{
			get
			{
				return (EFastReturnPosType)this.Instance.Type;
			}
		}

		// Token: 0x04003FBE RID: 16318
		private IFastReturnPosBase Instance;
	}
}
