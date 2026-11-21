using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001416 RID: 5142
	public class IDangoAbyssInformationView : IInformationViewType
	{
		// Token: 0x060074A6 RID: 29862 RVA: 0x00118A19 File Offset: 0x00116C19
		public static IDangoAbyssInformationView Create(IDangoAbyssInformationView? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDangoAbyssInformationView
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x060074A7 RID: 29863 RVA: 0x00118A38 File Offset: 0x00116C38
		public override EInformationViewType Type
		{
			get
			{
				return (EInformationViewType)this.Instance.Type;
			}
		}

		// Token: 0x04004290 RID: 17040
		private IDangoAbyssInformationView Instance;
	}
}
