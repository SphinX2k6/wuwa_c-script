using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002828 RID: 10280
	public class IVisualNovelPlayScreenEffectPersistent : IVisualNovelPlayScreenEffectConfigBase
	{
		// Token: 0x0600E4DE RID: 58590 RVA: 0x0021D38B File Offset: 0x0021B58B
		public static IVisualNovelPlayScreenEffectPersistent Create(IVisualNovelPlayScreenEffectPersistent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectPersistent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x0021D3AA File Offset: 0x0021B5AA
		public override EVisualNovelScreenEffectType Type
		{
			get
			{
				return (EVisualNovelScreenEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x0600E4E0 RID: 58592 RVA: 0x0021D3B7 File Offset: 0x0021B5B7
		public virtual string PersistentEffectPath
		{
			get
			{
				return this.Instance.PersistentEffectPath;
			}
		}

		// Token: 0x04007D9E RID: 32158
		private IVisualNovelPlayScreenEffectPersistent Instance;
	}
}
