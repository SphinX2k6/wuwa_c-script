using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290C RID: 10508
	public class IFloatingSubtitleLanguageDiff : IPreprocessOperationConfig
	{
		// Token: 0x0600E940 RID: 59712 RVA: 0x002233AC File Offset: 0x002215AC
		[NullableContext(1)]
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

		// Token: 0x170048EA RID: 18666
		// (get) Token: 0x0600E941 RID: 59713 RVA: 0x002233CB File Offset: 0x002215CB
		public override EPreprocessOperation Type
		{
			get
			{
				return (EPreprocessOperation)this.Instance.Type;
			}
		}

		// Token: 0x040080C2 RID: 32962
		private IFloatingSubtitleLanguageDiff Instance;
	}
}
