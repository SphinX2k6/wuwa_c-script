using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE8 RID: 11240
	public class IFloatingSubtitleLanguageDiff : IPreprocessOperationConfig
	{
		// Token: 0x0600F791 RID: 63377 RVA: 0x002406CC File Offset: 0x0023E8CC
		public static IFloatingSubtitleLanguageDiff Create(IFloatingSubtitleLanguageDiff? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFloatingSubtitleLanguageDiff
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C6F RID: 19567
		// (get) Token: 0x0600F792 RID: 63378 RVA: 0x002406EB File Offset: 0x0023E8EB
		public override EPreprocessOperation Type
		{
			get
			{
				return (EPreprocessOperation)this.Instance.Type;
			}
		}

		// Token: 0x04008790 RID: 34704
		private IFloatingSubtitleLanguageDiff Instance;
	}
}
