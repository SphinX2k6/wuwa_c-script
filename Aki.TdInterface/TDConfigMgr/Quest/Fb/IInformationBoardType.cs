using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001418 RID: 5144
	public class IInformationBoardType
	{
		// Token: 0x060074AC RID: 29868 RVA: 0x00118AA3 File Offset: 0x00116CA3
		public static IInformationBoardType Create(IInformationBoardType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationBoardType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x060074AD RID: 29869 RVA: 0x00118AC2 File Offset: 0x00116CC2
		public virtual EInformationBoardType Type
		{
			get
			{
				return (EInformationBoardType)this.Instance.Type;
			}
		}

		// Token: 0x04004294 RID: 17044
		private IInformationBoardType Instance;
	}
}
