using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001419 RID: 5145
	public class IDangoAbyssInformationBoard : IInformationBoardType
	{
		// Token: 0x060074AF RID: 29871 RVA: 0x00118AD7 File Offset: 0x00116CD7
		public static IDangoAbyssInformationBoard Create(IDangoAbyssInformationBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDangoAbyssInformationBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x060074B0 RID: 29872 RVA: 0x00118AF6 File Offset: 0x00116CF6
		public override EInformationBoardType Type
		{
			get
			{
				return (EInformationBoardType)this.Instance.Type;
			}
		}

		// Token: 0x04004295 RID: 17045
		private IDangoAbyssInformationBoard Instance;
	}
}
