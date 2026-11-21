using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037A3 RID: 14243
	public sealed class VisualNovelCharacterState
	{
		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x060250D9 RID: 151769 RVA: 0x00A7650A File Offset: 0x00A7470A
		public int CharacterId { get; }

		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x060250DA RID: 151770 RVA: 0x00A76512 File Offset: 0x00A74712
		public int AvgTalkerId { get; }

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x060250DB RID: 151771 RVA: 0x00A7651A File Offset: 0x00A7471A
		// (set) Token: 0x060250DC RID: 151772 RVA: 0x00A76522 File Offset: 0x00A74722
		public VisualNovelTransform Transform { get; set; } = new VisualNovelTransform(0f, 0f, 1f);

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x060250DD RID: 151773 RVA: 0x00A7652B File Offset: 0x00A7472B
		// (set) Token: 0x060250DE RID: 151774 RVA: 0x00A76533 File Offset: 0x00A74733
		public EAvgVisualEffect VisualEffect { get; set; }

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x060250DF RID: 151775 RVA: 0x00A7653C File Offset: 0x00A7473C
		// (set) Token: 0x060250E0 RID: 151776 RVA: 0x00A76544 File Offset: 0x00A74744
		public int AnimationId { get; set; }

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x060250E1 RID: 151777 RVA: 0x00A7654D File Offset: 0x00A7474D
		// (set) Token: 0x060250E2 RID: 151778 RVA: 0x00A76555 File Offset: 0x00A74755
		public bool IsSpeaking { get; set; }

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x060250E3 RID: 151779 RVA: 0x00A7655E File Offset: 0x00A7475E
		// (set) Token: 0x060250E4 RID: 151780 RVA: 0x00A76566 File Offset: 0x00A74766
		public bool IsPortraitHidden { get; set; }

		// Token: 0x060250E5 RID: 151781 RVA: 0x00A7656F File Offset: 0x00A7476F
		public VisualNovelCharacterState(int characterId, int avgTalkerId)
		{
			this.CharacterId = characterId;
			this.AvgTalkerId = avgTalkerId;
		}

		// Token: 0x060250E6 RID: 151782 RVA: 0x00A765A0 File Offset: 0x00A747A0
		[NullableContext(1)]
		public VisualNovelCharacterState Clone()
		{
			return new VisualNovelCharacterState(this.CharacterId, this.AvgTalkerId)
			{
				Transform = this.Transform,
				VisualEffect = this.VisualEffect,
				AnimationId = this.AnimationId,
				IsSpeaking = this.IsSpeaking,
				IsPortraitHidden = this.IsPortraitHidden
			};
		}

		// Token: 0x060250E7 RID: 151783 RVA: 0x00A765FC File Offset: 0x00A747FC
		public void Apply(float? x, float? y, float? scale, int? animationId, EAvgVisualEffect? visualEffect, bool? hidePortrait)
		{
			this.Transform = VisualNovelTransform.Merge(this.Transform, x, y, scale);
			if (animationId != null)
			{
				this.AnimationId = animationId.Value;
			}
			if (visualEffect != null)
			{
				this.VisualEffect = visualEffect.Value;
			}
			if (hidePortrait != null)
			{
				this.IsPortraitHidden = hidePortrait.Value;
			}
		}
	}
}
