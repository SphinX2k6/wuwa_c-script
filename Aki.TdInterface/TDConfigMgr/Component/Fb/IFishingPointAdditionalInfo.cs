using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B41 RID: 2881
	public class IFishingPointAdditionalInfo : IInteractAdditionalInfo
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x000A7969 File Offset: 0x000A5B69
		public static IFishingPointAdditionalInfo Create(IFishingPointAdditionalInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFishingPointAdditionalInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x000A7988 File Offset: 0x000A5B88
		public override EInteractAdditionalInfoType Type
		{
			get
			{
				return (EInteractAdditionalInfoType)this.Instance.Type;
			}
		}

		// Token: 0x04002478 RID: 9336
		private IFishingPointAdditionalInfo Instance;
	}
}
