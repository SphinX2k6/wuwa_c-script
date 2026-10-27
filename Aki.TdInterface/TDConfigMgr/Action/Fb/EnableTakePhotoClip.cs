using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200290E RID: 10510
	public class EnableTakePhotoClip : ActionParams
	{
		// Token: 0x0600E952 RID: 59730 RVA: 0x00223667 File Offset: 0x00221867
		[NullableContext(1)]
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

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x0600E953 RID: 59731 RVA: 0x00223686 File Offset: 0x00221886
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x040080CE RID: 32974
		private IEnableTakePhotoClip Instance;
	}
}
