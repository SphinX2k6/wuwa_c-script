using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002880 RID: 10368
	public class ISceneUiSubtitlePositionEntity : ISceneUiSubtitlePositionBase
	{
		// Token: 0x0600E714 RID: 59156 RVA: 0x00222FFA File Offset: 0x002211FA
		public static ISceneUiSubtitlePositionEntity Create(ISceneUiSubtitlePositionEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePositionEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042C2 RID: 17090
		// (get) Token: 0x0600E715 RID: 59157 RVA: 0x00223019 File Offset: 0x00221219
		public override ESceneUiSubtitlePositionType Type
		{
			get
			{
				return (ESceneUiSubtitlePositionType)this.Instance.Type;
			}
		}

		// Token: 0x170042C3 RID: 17091
		// (get) Token: 0x0600E716 RID: 59158 RVA: 0x00223026 File Offset: 0x00221226
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007F3A RID: 32570
		private ISceneUiSubtitlePositionEntity Instance;
	}
}
