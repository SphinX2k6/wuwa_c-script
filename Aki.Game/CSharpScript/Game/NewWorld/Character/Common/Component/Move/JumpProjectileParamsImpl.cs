using System;
using CSharpScript.Game.NewWorld.Character.Common.Controller;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070F2 RID: 28914
	public class JumpProjectileParamsImpl : IJumpProjectileParams
	{
		// Token: 0x17009CD0 RID: 40144
		// (get) Token: 0x06046959 RID: 289113 RVA: 0x011C2963 File Offset: 0x011C0B63
		// (set) Token: 0x0604695A RID: 289114 RVA: 0x011C296B File Offset: 0x011C0B6B
		public float Length { get; set; }

		// Token: 0x17009CD1 RID: 40145
		// (get) Token: 0x0604695B RID: 289115 RVA: 0x011C2974 File Offset: 0x011C0B74
		// (set) Token: 0x0604695C RID: 289116 RVA: 0x011C297C File Offset: 0x011C0B7C
		public float AllTime { get; set; }

		// Token: 0x17009CD2 RID: 40146
		// (get) Token: 0x0604695D RID: 289117 RVA: 0x011C2985 File Offset: 0x011C0B85
		// (set) Token: 0x0604695E RID: 289118 RVA: 0x011C298D File Offset: 0x011C0B8D
		public float Height0 { get; set; }

		// Token: 0x17009CD3 RID: 40147
		// (get) Token: 0x0604695F RID: 289119 RVA: 0x011C2996 File Offset: 0x011C0B96
		// (set) Token: 0x06046960 RID: 289120 RVA: 0x011C299E File Offset: 0x011C0B9E
		public float ProjectileA { get; set; }

		// Token: 0x17009CD4 RID: 40148
		// (get) Token: 0x06046961 RID: 289121 RVA: 0x011C29A7 File Offset: 0x011C0BA7
		// (set) Token: 0x06046962 RID: 289122 RVA: 0x011C29AF File Offset: 0x011C0BAF
		public float ProjectileB { get; set; }
	}
}
