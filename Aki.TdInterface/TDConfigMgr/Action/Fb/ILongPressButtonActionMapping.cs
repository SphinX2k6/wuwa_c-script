using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D7 RID: 10455
	public class ILongPressButtonActionMapping
	{
		// Token: 0x0600E8AE RID: 59566 RVA: 0x00226035 File Offset: 0x00224235
		public static ILongPressButtonActionMapping Create(ILongPressButtonActionMapping? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressButtonActionMapping
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043AE RID: 17326
		// (get) Token: 0x0600E8AF RID: 59567 RVA: 0x00226054 File Offset: 0x00224254
		public virtual int Id
		{
			get
			{
				return this.Instance.Id;
			}
		}

		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x0600E8B0 RID: 59568 RVA: 0x00226061 File Offset: 0x00224261
		public virtual string ActionName
		{
			get
			{
				return this.Instance.ActionName;
			}
		}

		// Token: 0x04008027 RID: 32807
		private ILongPressButtonActionMapping Instance;
	}
}
