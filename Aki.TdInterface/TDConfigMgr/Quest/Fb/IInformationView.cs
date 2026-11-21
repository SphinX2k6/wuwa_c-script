using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014ED RID: 5357
	public class IInformationView : IShowUi
	{
		// Token: 0x0600796B RID: 31083 RVA: 0x00122318 File Offset: 0x00120518
		public static IInformationView Create(IInformationView? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationView
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x0600796C RID: 31084 RVA: 0x00122337 File Offset: 0x00120537
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x0600796D RID: 31085 RVA: 0x00122344 File Offset: 0x00120544
		public virtual int InformationViewId
		{
			get
			{
				return this.Instance.InformationViewId;
			}
		}

		// Token: 0x040045DB RID: 17883
		private IInformationView Instance;
	}
}
