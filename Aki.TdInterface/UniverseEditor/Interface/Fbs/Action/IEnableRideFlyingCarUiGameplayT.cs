using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF3 RID: 27891
	public class IEnableRideFlyingCarUiGameplayT
	{
		// Token: 0x1700CC8D RID: 52365
		// (get) Token: 0x06030154 RID: 196948 RVA: 0x0068A7A0 File Offset: 0x006889A0
		// (set) Token: 0x06030155 RID: 196949 RVA: 0x0068A7A8 File Offset: 0x006889A8
		public EToggleRideFlyingCarUiGameplayType Type { get; set; }

		// Token: 0x1700CC8E RID: 52366
		// (get) Token: 0x06030156 RID: 196950 RVA: 0x0068A7B1 File Offset: 0x006889B1
		// (set) Token: 0x06030157 RID: 196951 RVA: 0x0068A7B9 File Offset: 0x006889B9
		public int FirstPersonCameraTag { get; set; }

		// Token: 0x1700CC8F RID: 52367
		// (get) Token: 0x06030158 RID: 196952 RVA: 0x0068A7C2 File Offset: 0x006889C2
		// (set) Token: 0x06030159 RID: 196953 RVA: 0x0068A7CA File Offset: 0x006889CA
		public int ThirdPersonCameraTag { get; set; }

		// Token: 0x1700CC90 RID: 52368
		// (get) Token: 0x0603015A RID: 196954 RVA: 0x0068A7D3 File Offset: 0x006889D3
		// (set) Token: 0x0603015B RID: 196955 RVA: 0x0068A7DB File Offset: 0x006889DB
		public byte NullMask { get; set; }

		// Token: 0x0603015C RID: 196956 RVA: 0x0068A7E4 File Offset: 0x006889E4
		public IEnableRideFlyingCarUiGameplayT()
		{
			this.Type = EToggleRideFlyingCarUiGameplayType.Enable;
			this.FirstPersonCameraTag = 0;
			this.ThirdPersonCameraTag = 0;
			this.NullMask = 0;
		}
	}
}
