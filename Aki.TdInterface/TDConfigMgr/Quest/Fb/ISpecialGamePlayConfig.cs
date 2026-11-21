using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141B RID: 5147
	public class ISpecialGamePlayConfig
	{
		// Token: 0x060074B5 RID: 29877 RVA: 0x00118B66 File Offset: 0x00116D66
		public static ISpecialGamePlayConfig Create(ISpecialGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x060074B6 RID: 29878 RVA: 0x00118B85 File Offset: 0x00116D85
		public virtual ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x04004299 RID: 17049
		private ISpecialGamePlayConfig Instance;
	}
}
