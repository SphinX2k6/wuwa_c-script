using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FA RID: 10490
	public class IItemGetUiConfigBase
	{
		// Token: 0x0600E968 RID: 59752 RVA: 0x00227841 File Offset: 0x00225A41
		public static IItemGetUiConfigBase Create(IItemGetUiConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemGetUiConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004422 RID: 17442
		// (get) Token: 0x0600E969 RID: 59753 RVA: 0x00227860 File Offset: 0x00225A60
		public virtual EItemGetUiType Type
		{
			get
			{
				return (EItemGetUiType)this.Instance.Type;
			}
		}

		// Token: 0x040080A6 RID: 32934
		private IItemGetUiConfigBase Instance;
	}
}
