using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002826 RID: 10278
	public class IVisualNovelPlayScreenEffectConfigBase
	{
		// Token: 0x0600E4D7 RID: 58583 RVA: 0x0021D316 File Offset: 0x0021B516
		public static IVisualNovelPlayScreenEffectConfigBase Create(IVisualNovelPlayScreenEffectConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x0600E4D8 RID: 58584 RVA: 0x0021D335 File Offset: 0x0021B535
		public virtual EVisualNovelScreenEffectType Type
		{
			get
			{
				return (EVisualNovelScreenEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007D9C RID: 32156
		private IVisualNovelPlayScreenEffectConfigBase Instance;
	}
}
