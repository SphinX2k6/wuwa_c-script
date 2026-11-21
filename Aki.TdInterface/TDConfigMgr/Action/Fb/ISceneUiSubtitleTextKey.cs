using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002889 RID: 10377
	public class ISceneUiSubtitleTextKey : ISceneUiSubtitleTextBase
	{
		// Token: 0x0600E742 RID: 59202 RVA: 0x00223613 File Offset: 0x00221813
		public static ISceneUiSubtitleTextKey Create(ISceneUiSubtitleTextKey? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextKey
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042DE RID: 17118
		// (get) Token: 0x0600E743 RID: 59203 RVA: 0x00223632 File Offset: 0x00221832
		public override ESceneUiSubtitleTextType Type
		{
			get
			{
				return (ESceneUiSubtitleTextType)this.Instance.Type;
			}
		}

		// Token: 0x170042DF RID: 17119
		// (get) Token: 0x0600E744 RID: 59204 RVA: 0x0022363F File Offset: 0x0022183F
		public virtual string TextKey
		{
			get
			{
				return this.Instance.TextKey;
			}
		}

		// Token: 0x04007F59 RID: 32601
		private ISceneUiSubtitleTextKey Instance;
	}
}
