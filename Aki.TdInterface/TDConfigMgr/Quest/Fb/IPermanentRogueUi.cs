using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F2 RID: 5362
	public class IPermanentRogueUi : IShowUi
	{
		// Token: 0x0600797C RID: 31100 RVA: 0x00122436 File Offset: 0x00120636
		public static IPermanentRogueUi Create(IPermanentRogueUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPermanentRogueUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700273A RID: 10042
		// (get) Token: 0x0600797D RID: 31101 RVA: 0x00122455 File Offset: 0x00120655
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x1700273B RID: 10043
		// (get) Token: 0x0600797E RID: 31102 RVA: 0x00122462 File Offset: 0x00120662
		public virtual ERogueUiType UiType
		{
			get
			{
				return (ERogueUiType)this.Instance.UiType;
			}
		}

		// Token: 0x1700273C RID: 10044
		// (get) Token: 0x0600797F RID: 31103 RVA: 0x0012246F File Offset: 0x0012066F
		public virtual int BindId
		{
			get
			{
				return this.Instance.BindId;
			}
		}

		// Token: 0x040045E0 RID: 17888
		private IPermanentRogueUi Instance;
	}
}
