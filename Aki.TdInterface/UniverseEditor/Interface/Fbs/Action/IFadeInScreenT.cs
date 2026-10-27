using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006793 RID: 26515
	public class IFadeInScreenT
	{
		// Token: 0x1700C4CF RID: 50383
		// (get) Token: 0x0602E22A RID: 188970 RVA: 0x0064D4B7 File Offset: 0x0064B6B7
		// (set) Token: 0x0602E22B RID: 188971 RVA: 0x0064D4BF File Offset: 0x0064B6BF
		public EFadeUiOverride TypeOverride { get; set; }

		// Token: 0x1700C4D0 RID: 50384
		// (get) Token: 0x0602E22C RID: 188972 RVA: 0x0064D4C8 File Offset: 0x0064B6C8
		// (set) Token: 0x0602E22D RID: 188973 RVA: 0x0064D4D0 File Offset: 0x0064B6D0
		public IEaseDataT Ease { get; set; }

		// Token: 0x1700C4D1 RID: 50385
		// (get) Token: 0x0602E22E RID: 188974 RVA: 0x0064D4D9 File Offset: 0x0064B6D9
		// (set) Token: 0x0602E22F RID: 188975 RVA: 0x0064D4E1 File Offset: 0x0064B6E1
		public EFadeInScreenShowType ScreenType { get; set; }

		// Token: 0x1700C4D2 RID: 50386
		// (get) Token: 0x0602E230 RID: 188976 RVA: 0x0064D4EA File Offset: 0x0064B6EA
		// (set) Token: 0x0602E231 RID: 188977 RVA: 0x0064D4F2 File Offset: 0x0064B6F2
		public bool KeepFadeAfterTreeEnd { get; set; }

		// Token: 0x1700C4D3 RID: 50387
		// (get) Token: 0x0602E232 RID: 188978 RVA: 0x0064D4FB File Offset: 0x0064B6FB
		// (set) Token: 0x0602E233 RID: 188979 RVA: 0x0064D503 File Offset: 0x0064B703
		public bool KeepFadeAfterTreeRollBack { get; set; }

		// Token: 0x1700C4D4 RID: 50388
		// (get) Token: 0x0602E234 RID: 188980 RVA: 0x0064D50C File Offset: 0x0064B70C
		// (set) Token: 0x0602E235 RID: 188981 RVA: 0x0064D514 File Offset: 0x0064B714
		public TFadeBackgroundUnion FadeBackground { get; set; }

		// Token: 0x1700C4D5 RID: 50389
		// (get) Token: 0x0602E236 RID: 188982 RVA: 0x0064D51D File Offset: 0x0064B71D
		// (set) Token: 0x0602E237 RID: 188983 RVA: 0x0064D525 File Offset: 0x0064B725
		public bool OnlyLowMemoryDeviceExecute { get; set; }

		// Token: 0x1700C4D6 RID: 50390
		// (get) Token: 0x0602E238 RID: 188984 RVA: 0x0064D52E File Offset: 0x0064B72E
		// (set) Token: 0x0602E239 RID: 188985 RVA: 0x0064D536 File Offset: 0x0064B736
		public byte NullMask { get; set; }

		// Token: 0x0602E23A RID: 188986 RVA: 0x0064D53F File Offset: 0x0064B73F
		public IFadeInScreenT()
		{
			this.TypeOverride = EFadeUiOverride.ShowTalkDialog;
			this.Ease = null;
			this.ScreenType = EFadeInScreenShowType.White;
			this.KeepFadeAfterTreeEnd = false;
			this.KeepFadeAfterTreeRollBack = false;
			this.FadeBackground = null;
			this.OnlyLowMemoryDeviceExecute = false;
			this.NullMask = 0;
		}
	}
}
