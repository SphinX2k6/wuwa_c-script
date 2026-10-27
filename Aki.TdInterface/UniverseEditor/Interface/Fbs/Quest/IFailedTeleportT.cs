using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E19 RID: 15897
	public class IFailedTeleportT
	{
		// Token: 0x17006DE2 RID: 28130
		// (get) Token: 0x06016419 RID: 91161 RVA: 0x00336885 File Offset: 0x00334A85
		// (set) Token: 0x0601641A RID: 91162 RVA: 0x0033688D File Offset: 0x00334A8D
		public IPosAT Position { get; set; }

		// Token: 0x17006DE3 RID: 28131
		// (get) Token: 0x0601641B RID: 91163 RVA: 0x00336896 File Offset: 0x00334A96
		// (set) Token: 0x0601641C RID: 91164 RVA: 0x0033689E File Offset: 0x00334A9E
		public int PositionEntityId { get; set; }

		// Token: 0x17006DE4 RID: 28132
		// (get) Token: 0x0601641D RID: 91165 RVA: 0x003368A7 File Offset: 0x00334AA7
		// (set) Token: 0x0601641E RID: 91166 RVA: 0x003368AF File Offset: 0x00334AAF
		public bool IsConfirm { get; set; }

		// Token: 0x17006DE5 RID: 28133
		// (get) Token: 0x0601641F RID: 91167 RVA: 0x003368B8 File Offset: 0x00334AB8
		// (set) Token: 0x06016420 RID: 91168 RVA: 0x003368C0 File Offset: 0x00334AC0
		public int ConfirmId { get; set; }

		// Token: 0x17006DE6 RID: 28134
		// (get) Token: 0x06016421 RID: 91169 RVA: 0x003368C9 File Offset: 0x00334AC9
		// (set) Token: 0x06016422 RID: 91170 RVA: 0x003368D1 File Offset: 0x00334AD1
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x17006DE7 RID: 28135
		// (get) Token: 0x06016423 RID: 91171 RVA: 0x003368DA File Offset: 0x00334ADA
		// (set) Token: 0x06016424 RID: 91172 RVA: 0x003368E2 File Offset: 0x00334AE2
		public bool GravityFlip { get; set; }

		// Token: 0x17006DE8 RID: 28136
		// (get) Token: 0x06016425 RID: 91173 RVA: 0x003368EB File Offset: 0x00334AEB
		// (set) Token: 0x06016426 RID: 91174 RVA: 0x003368F3 File Offset: 0x00334AF3
		public byte NullMask { get; set; }

		// Token: 0x06016427 RID: 91175 RVA: 0x003368FC File Offset: 0x00334AFC
		public IFailedTeleportT()
		{
			this.Position = null;
			this.PositionEntityId = 0;
			this.IsConfirm = false;
			this.ConfirmId = 0;
			this.TransitionOption = null;
			this.GravityFlip = false;
			this.NullMask = 0;
		}
	}
}
