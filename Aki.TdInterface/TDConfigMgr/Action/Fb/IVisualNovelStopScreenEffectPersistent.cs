using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200282C RID: 10284
	public class IVisualNovelStopScreenEffectPersistent : IVisualNovelStopScreenEffectConfigBase
	{
		// Token: 0x0600E4EE RID: 58606 RVA: 0x0021D4DD File Offset: 0x0021B6DD
		public static IVisualNovelStopScreenEffectPersistent Create(IVisualNovelStopScreenEffectPersistent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelStopScreenEffectPersistent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x0600E4EF RID: 58607 RVA: 0x0021D4FC File Offset: 0x0021B6FC
		public override EVisualNovelStopScreenEffectType Type
		{
			get
			{
				return (EVisualNovelStopScreenEffectType)this.Instance.Type;
			}
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x0600E4F0 RID: 58608 RVA: 0x0021D509 File Offset: 0x0021B709
		public virtual string PersistentEffectPath
		{
			get
			{
				return this.Instance.PersistentEffectPath;
			}
		}

		// Token: 0x04007DA4 RID: 32164
		private IVisualNovelStopScreenEffectPersistent Instance;
	}
}
