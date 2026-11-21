using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200287E RID: 10366
	public class ISceneUiSubtitlePositionBase
	{
		// Token: 0x0600E70D RID: 59149 RVA: 0x00222F5E File Offset: 0x0022115E
		public static ISceneUiSubtitlePositionBase Create(ISceneUiSubtitlePositionBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePositionBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x0600E70E RID: 59150 RVA: 0x00222F7D File Offset: 0x0022117D
		public virtual ESceneUiSubtitlePositionType Type
		{
			get
			{
				return (ESceneUiSubtitlePositionType)this.Instance.Type;
			}
		}

		// Token: 0x04007F36 RID: 32566
		private ISceneUiSubtitlePositionBase Instance;
	}
}
