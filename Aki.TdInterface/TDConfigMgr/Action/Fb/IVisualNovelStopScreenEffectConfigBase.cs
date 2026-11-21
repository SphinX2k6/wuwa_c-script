using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282B RID: 10283
	public class IVisualNovelStopScreenEffectConfigBase
	{
		// Token: 0x0600E4EB RID: 58603 RVA: 0x0021D4A9 File Offset: 0x0021B6A9
		public static IVisualNovelStopScreenEffectConfigBase Create(IVisualNovelStopScreenEffectConfigBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelStopScreenEffectConfigBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x0600E4EC RID: 58604 RVA: 0x0021D4C8 File Offset: 0x0021B6C8
		public virtual EVisualNovelStopScreenEffectType Type
		{
			get
			{
				return (EVisualNovelStopScreenEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007DA3 RID: 32163
		private IVisualNovelStopScreenEffectConfigBase Instance;
	}
}
