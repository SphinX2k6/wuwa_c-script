using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002887 RID: 10375
	public class ISceneUiSubtitleTextBase
	{
		// Token: 0x0600E73B RID: 59195 RVA: 0x00223577 File Offset: 0x00221777
		public static ISceneUiSubtitleTextBase Create(ISceneUiSubtitleTextBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042DB RID: 17115
		// (get) Token: 0x0600E73C RID: 59196 RVA: 0x00223596 File Offset: 0x00221796
		public virtual ESceneUiSubtitleTextType Type
		{
			get
			{
				return (ESceneUiSubtitleTextType)this.Instance.Type;
			}
		}

		// Token: 0x04007F55 RID: 32597
		private ISceneUiSubtitleTextBase Instance;
	}
}
