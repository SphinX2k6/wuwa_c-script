using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001415 RID: 5141
	public class IBossRushBuffInfoView : IInformationViewType
	{
		// Token: 0x060074A3 RID: 29859 RVA: 0x001189E5 File Offset: 0x00116BE5
		public static IBossRushBuffInfoView Create(IBossRushBuffInfoView? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBossRushBuffInfoView
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x060074A4 RID: 29860 RVA: 0x00118A04 File Offset: 0x00116C04
		public override EInformationViewType Type
		{
			get
			{
				return (EInformationViewType)this.Instance.Type;
			}
		}

		// Token: 0x0400428F RID: 17039
		private IBossRushBuffInfoView Instance;
	}
}
