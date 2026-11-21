using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BEA RID: 11242
	public class EnableTakePhotoClip : ActionParams
	{
		// Token: 0x0600F7A3 RID: 63395 RVA: 0x00240987 File Offset: 0x0023EB87
		public static EnableTakePhotoClip Create(IEnableTakePhotoClip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableTakePhotoClip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C7D RID: 19581
		// (get) Token: 0x0600F7A4 RID: 63396 RVA: 0x002409A6 File Offset: 0x0023EBA6
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x0400879C RID: 34716
		private IEnableTakePhotoClip Instance;
	}
}
