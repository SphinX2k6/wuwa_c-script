using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002829 RID: 10281
	public class IVisualNovelPlayScreenEffectCustom : IVisualNovelPlayScreenEffectConfigBase
	{
		// Token: 0x0600E4E2 RID: 58594 RVA: 0x0021D3CC File Offset: 0x0021B5CC
		public static IVisualNovelPlayScreenEffectCustom Create(IVisualNovelPlayScreenEffectCustom? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelPlayScreenEffectCustom
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x0600E4E3 RID: 58595 RVA: 0x0021D3EB File Offset: 0x0021B5EB
		public override EVisualNovelScreenEffectType Type
		{
			get
			{
				return (EVisualNovelScreenEffectType)this.Instance.Type;
			}
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x0600E4E4 RID: 58596 RVA: 0x0021D3F8 File Offset: 0x0021B5F8
		public virtual EVisualNovelScreenEffectCustomType CustomType
		{
			get
			{
				return (EVisualNovelScreenEffectCustomType)this.Instance.CustomType;
			}
		}

		// Token: 0x04007D9F RID: 32159
		private IVisualNovelPlayScreenEffectCustom Instance;
	}
}
