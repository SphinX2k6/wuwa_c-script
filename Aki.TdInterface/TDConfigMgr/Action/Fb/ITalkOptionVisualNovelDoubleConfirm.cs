using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BF RID: 10175
	public class ITalkOptionVisualNovelDoubleConfirm
	{
		// Token: 0x0600E126 RID: 57638 RVA: 0x002119F6 File Offset: 0x0020FBF6
		public static ITalkOptionVisualNovelDoubleConfirm Create(ITalkOptionVisualNovelDoubleConfirm? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionVisualNovelDoubleConfirm
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0600E127 RID: 57639 RVA: 0x00211A15 File Offset: 0x0020FC15
		public virtual int ConfirmBoxId
		{
			get
			{
				return this.Instance.ConfirmBoxId;
			}
		}

		// Token: 0x04007A61 RID: 31329
		private ITalkOptionVisualNovelDoubleConfirm Instance;
	}
}
