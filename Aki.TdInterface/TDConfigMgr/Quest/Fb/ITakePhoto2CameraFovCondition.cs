using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001500 RID: 5376
	public class ITakePhoto2CameraFovCondition
	{
		// Token: 0x060079C3 RID: 31171 RVA: 0x00122E39 File Offset: 0x00121039
		public static ITakePhoto2CameraFovCondition Create(ITakePhoto2CameraFovCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2CameraFovCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x060079C4 RID: 31172 RVA: 0x00122E58 File Offset: 0x00121058
		public virtual int MinFov
		{
			get
			{
				return this.Instance.MinFov;
			}
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x060079C5 RID: 31173 RVA: 0x00122E65 File Offset: 0x00121065
		public virtual int MaxFov
		{
			get
			{
				return this.Instance.MaxFov;
			}
		}

		// Token: 0x04004612 RID: 17938
		private ITakePhoto2CameraFovCondition Instance;
	}
}
