using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200783A RID: 30778
	public class ISetSkillBtnEffectT
	{
		// Token: 0x1700E1D2 RID: 57810
		// (get) Token: 0x0603620D RID: 221709 RVA: 0x00740581 File Offset: 0x0073E781
		// (set) Token: 0x0603620E RID: 221710 RVA: 0x00740589 File Offset: 0x0073E789
		public ESkillButtonType SkillBtnType { get; set; }

		// Token: 0x1700E1D3 RID: 57811
		// (get) Token: 0x0603620F RID: 221711 RVA: 0x00740592 File Offset: 0x0073E792
		// (set) Token: 0x06036210 RID: 221712 RVA: 0x0074059A File Offset: 0x0073E79A
		public IMusicBattleBtnEffectT SkillBtnEffectData { get; set; }

		// Token: 0x1700E1D4 RID: 57812
		// (get) Token: 0x06036211 RID: 221713 RVA: 0x007405A3 File Offset: 0x0073E7A3
		// (set) Token: 0x06036212 RID: 221714 RVA: 0x007405AB File Offset: 0x0073E7AB
		public float Time { get; set; }

		// Token: 0x06036213 RID: 221715 RVA: 0x007405B4 File Offset: 0x0073E7B4
		public ISetSkillBtnEffectT()
		{
			this.SkillBtnType = ESkillButtonType.None;
			this.SkillBtnEffectData = null;
			this.Time = 0f;
		}
	}
}
