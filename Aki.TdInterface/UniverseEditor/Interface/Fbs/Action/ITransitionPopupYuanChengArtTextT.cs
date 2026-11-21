using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C48 RID: 31816
	public class ITransitionPopupYuanChengArtTextT
	{
		// Token: 0x1700EE34 RID: 60980
		// (get) Token: 0x0603959E RID: 234910 RVA: 0x007BE728 File Offset: 0x007BC928
		// (set) Token: 0x0603959F RID: 234911 RVA: 0x007BE730 File Offset: 0x007BC930
		public ETransitionPopupArtTextType Type { get; set; }

		// Token: 0x1700EE35 RID: 60981
		// (get) Token: 0x060395A0 RID: 234912 RVA: 0x007BE739 File Offset: 0x007BC939
		// (set) Token: 0x060395A1 RID: 234913 RVA: 0x007BE741 File Offset: 0x007BC941
		public IVector2T Position { get; set; }

		// Token: 0x1700EE36 RID: 60982
		// (get) Token: 0x060395A2 RID: 234914 RVA: 0x007BE74A File Offset: 0x007BC94A
		// (set) Token: 0x060395A3 RID: 234915 RVA: 0x007BE752 File Offset: 0x007BC952
		public string Texture { get; set; }

		// Token: 0x1700EE37 RID: 60983
		// (get) Token: 0x060395A4 RID: 234916 RVA: 0x007BE75B File Offset: 0x007BC95B
		// (set) Token: 0x060395A5 RID: 234917 RVA: 0x007BE763 File Offset: 0x007BC963
		public string SubtitleText { get; set; }

		// Token: 0x060395A6 RID: 234918 RVA: 0x007BE76C File Offset: 0x007BC96C
		public ITransitionPopupYuanChengArtTextT()
		{
			this.Type = ETransitionPopupArtTextType.YuanCheng;
			this.Position = null;
			this.Texture = null;
			this.SubtitleText = null;
		}
	}
}
