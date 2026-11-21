using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200141C RID: 5148
	public class IStalkingGamePlayConfig : ISpecialGamePlayConfig
	{
		// Token: 0x060074B8 RID: 29880 RVA: 0x00118B9A File Offset: 0x00116D9A
		public static IStalkingGamePlayConfig Create(IStalkingGamePlayConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStalkingGamePlayConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x060074B9 RID: 29881 RVA: 0x00118BB9 File Offset: 0x00116DB9
		public override ESpecialGamePlayConfigType Type
		{
			get
			{
				return (ESpecialGamePlayConfigType)this.Instance.Type;
			}
		}

		// Token: 0x0400429A RID: 17050
		private IStalkingGamePlayConfig Instance;
	}
}
