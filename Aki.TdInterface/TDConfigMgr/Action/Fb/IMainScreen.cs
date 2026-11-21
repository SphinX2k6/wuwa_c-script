using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A73 RID: 10867
	public class IMainScreen : IScreenType
	{
		// Token: 0x0600EFDE RID: 61406 RVA: 0x002327F5 File Offset: 0x002309F5
		public static IMainScreen Create(IMainScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMainScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170047A6 RID: 18342
		// (get) Token: 0x0600EFDF RID: 61407 RVA: 0x00232814 File Offset: 0x00230A14
		public override EScreenType Type
		{
			get
			{
				return (EScreenType)this.Instance.Type;
			}
		}

		// Token: 0x040083E3 RID: 33763
		private IMainScreen Instance;
	}
}
