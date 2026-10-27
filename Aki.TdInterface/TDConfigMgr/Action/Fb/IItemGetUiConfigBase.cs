using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200263A RID: 9786
	public class IItemGetUiConfigBase
	{
		// Token: 0x0600DB9A RID: 56218 RVA: 0x0020B075 File Offset: 0x00209275
		[NullableContext(1)]
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

		// Token: 0x170040E8 RID: 16616
		// (get) Token: 0x0600DB9B RID: 56219 RVA: 0x0020B094 File Offset: 0x00209294
		public virtual EItemGetUiType Type
		{
			get
			{
				return (EItemGetUiType)this.Instance.Type;
			}
		}

		// Token: 0x04007A0A RID: 31242
		private IItemGetUiConfigBase Instance;
	}
}
