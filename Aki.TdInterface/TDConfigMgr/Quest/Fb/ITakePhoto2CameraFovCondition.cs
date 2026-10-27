using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013AF RID: 5039
	public class ITakePhoto2CameraFovCondition
	{
		// Token: 0x0600731C RID: 29468 RVA: 0x0011477D File Offset: 0x0011297D
		[NullableContext(1)]
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

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x0600731D RID: 29469 RVA: 0x0011479C File Offset: 0x0011299C
		public virtual int MinFov
		{
			get
			{
				return this.Instance.MinFov;
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x0600731E RID: 29470 RVA: 0x001147A9 File Offset: 0x001129A9
		public virtual int MaxFov
		{
			get
			{
				return this.Instance.MaxFov;
			}
		}

		// Token: 0x04004291 RID: 17041
		private ITakePhoto2CameraFovCondition Instance;
	}
}
