using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002827 RID: 10279
	public class IVisualNovelPlayScreenEffectOneShot : IVisualNovelPlayScreenEffectConfigBase
	{
		// Token: 0x0600E4DA RID: 58586 RVA: 0x0021D34A File Offset: 0x0021B54A
		public static IVisualNovelPlayScreenEffectOneShot Create(IVisualNovelPlayScreenEffectOneShot? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectOneShot
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x0600E4DB RID: 58587 RVA: 0x0021D369 File Offset: 0x0021B569
		public override EVisualNovelScreenEffectType Type
		{
			get
			{
				return (EVisualNovelScreenEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x0600E4DC RID: 58588 RVA: 0x0021D376 File Offset: 0x0021B576
		public virtual string OneShotEffectPath
		{
			get
			{
				return this.Instance.OneShotEffectPath;
			}
		}

		// Token: 0x04007D9D RID: 32157
		private IVisualNovelPlayScreenEffectOneShot Instance;
	}
}
