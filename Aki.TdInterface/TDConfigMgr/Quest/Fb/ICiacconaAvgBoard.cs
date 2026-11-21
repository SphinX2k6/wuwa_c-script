using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014F3 RID: 5363
	public class ICiacconaAvgBoard : IShowUi
	{
		// Token: 0x06007981 RID: 31105 RVA: 0x00122484 File Offset: 0x00120684
		public static ICiacconaAvgBoard Create(ICiacconaAvgBoard? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICiacconaAvgBoard
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700273D RID: 10045
		// (get) Token: 0x06007982 RID: 31106 RVA: 0x001224A3 File Offset: 0x001206A3
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x06007983 RID: 31107 RVA: 0x001224B0 File Offset: 0x001206B0
		public virtual int? EndingId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EndingId);
			}
		}

		// Token: 0x040045E1 RID: 17889
		private ICiacconaAvgBoard Instance;
	}
}
