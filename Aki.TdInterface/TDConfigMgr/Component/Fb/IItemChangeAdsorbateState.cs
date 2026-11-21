using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BF4 RID: 3060
	public class IItemChangeAdsorbateState
	{
		// Token: 0x0600463E RID: 17982 RVA: 0x000B315D File Offset: 0x000B135D
		public static IItemChangeAdsorbateState Create(IItemChangeAdsorbateState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemChangeAdsorbateState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x04002779 RID: 10105
		private IItemChangeAdsorbateState Instance;
	}
}
