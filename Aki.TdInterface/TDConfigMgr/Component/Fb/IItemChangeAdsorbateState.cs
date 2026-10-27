using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B26 RID: 2854
	public class IItemChangeAdsorbateState
	{
		// Token: 0x060041E5 RID: 16869 RVA: 0x000A9099 File Offset: 0x000A7299
		[NullableContext(1)]
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

		// Token: 0x04002531 RID: 9521
		private IItemChangeAdsorbateState Instance;
	}
}
