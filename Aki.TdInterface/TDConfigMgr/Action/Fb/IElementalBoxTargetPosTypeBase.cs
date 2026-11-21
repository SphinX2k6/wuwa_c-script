using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DFB RID: 11771
	public class IElementalBoxTargetPosTypeBase
	{
		// Token: 0x0600FFEB RID: 65515 RVA: 0x0024D92B File Offset: 0x0024BB2B
		public static IElementalBoxTargetPosTypeBase Create(IElementalBoxTargetPosTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalBoxTargetPosTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170050A3 RID: 20643
		// (get) Token: 0x0600FFEC RID: 65516 RVA: 0x0024D94A File Offset: 0x0024BB4A
		public virtual EElementalBoxTargetPosType Type
		{
			get
			{
				return (EElementalBoxTargetPosType)this.Instance.Type;
			}
		}

		// Token: 0x04008BAB RID: 35755
		private IElementalBoxTargetPosTypeBase Instance;
	}
}
