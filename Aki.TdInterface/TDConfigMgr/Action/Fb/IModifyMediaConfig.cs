using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BE0 RID: 11232
	public class IModifyMediaConfig
	{
		// Token: 0x0600F770 RID: 63344 RVA: 0x00240365 File Offset: 0x0023E565
		public static IModifyMediaConfig Create(IModifyMediaConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyMediaConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C5E RID: 19550
		// (get) Token: 0x0600F771 RID: 63345 RVA: 0x00240384 File Offset: 0x0023E584
		public virtual EModifyActorMediaType Type
		{
			get
			{
				return (EModifyActorMediaType)this.Instance.Type;
			}
		}

		// Token: 0x04008780 RID: 34688
		private IModifyMediaConfig Instance;
	}
}
