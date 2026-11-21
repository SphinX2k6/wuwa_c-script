using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x02003799 RID: 14233
	[NullableContext(2)]
	public interface IVisualNovelView
	{
		// Token: 0x17004BE7 RID: 19431
		// (get) Token: 0x0602502B RID: 151595
		bool IsTyping { get; }

		// Token: 0x17004BE8 RID: 19432
		// (get) Token: 0x0602502C RID: 151596
		VisualNovelTransform CgTransform { get; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0602502D RID: 151597
		// (remove) Token: 0x0602502E RID: 151598
		event Action ContinueRequested;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0602502F RID: 151599
		// (remove) Token: 0x06025030 RID: 151600
		event Action<int> ChoiceSelected;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06025031 RID: 151601
		// (remove) Token: 0x06025032 RID: 151602
		event Action AutoPlayRequested;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06025033 RID: 151603
		// (remove) Token: 0x06025034 RID: 151604
		event Action FastForwardStarted;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06025035 RID: 151605
		// (remove) Token: 0x06025036 RID: 151606
		event Action FastForwardEnded;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06025037 RID: 151607
		// (remove) Token: 0x06025038 RID: 151608
		event Action UltraFastForwardRequested;

		// Token: 0x06025039 RID: 151609
		[NullableContext(1)]
		void SetAvatarConfig(int speakerId, IVisualNovelRoleConfig roleConfig);

		// Token: 0x0602503A RID: 151610
		[NullableContext(1)]
		UniTask PrepareAsync(VisualNovelItem item);

		// Token: 0x0602503B RID: 151611
		[NullableContext(1)]
		UniTask ShowTextAsync(VisualNovelItem item, EVisualNovelPlaybackMode playbackMode);

		// Token: 0x0602503C RID: 151612
		[NullableContext(1)]
		UniTask ApplyCgAsync(IVisualNovelCgBase cgConfig);

		// Token: 0x0602503D RID: 151613
		UniTask PlayCgMoveAsync(VisualNovelCgMoveParameters parameters);

		// Token: 0x0602503E RID: 151614
		void SetCgTransform(VisualNovelTransform transform);

		// Token: 0x0602503F RID: 151615
		[NullableContext(1)]
		UniTask PlayScreenEffectAsync(string path, bool persistent);

		// Token: 0x06025040 RID: 151616
		[NullableContext(1)]
		UniTask StopScreenEffectAsync(string path);

		// Token: 0x06025041 RID: 151617
		[NullableContext(1)]
		void CompleteScreenEffect(string path);

		// Token: 0x06025042 RID: 151618
		UniTask PlayCustomScreenEffectAsync(EVisualNovelScreenEffectCustomType effectType);

		// Token: 0x06025043 RID: 151619
		void CompleteCustomScreenEffect(EVisualNovelScreenEffectCustomType effectType);

		// Token: 0x06025044 RID: 151620
		void ClearScreenEffects();

		// Token: 0x06025045 RID: 151621
		[NullableContext(1)]
		UniTask ShowChoicesAsync(VisualNovelChoiceData choiceData);

		// Token: 0x06025046 RID: 151622
		bool ShowCharacterIntroduction(int characterId);

		// Token: 0x06025047 RID: 151623
		void HideCharacterIntroduction();

		// Token: 0x06025048 RID: 151624
		void CompleteTyping();

		// Token: 0x06025049 RID: 151625
		void SetPlaybackRate(float playbackRate);

		// Token: 0x0602504A RID: 151626
		void SetPaused(bool paused);

		// Token: 0x0602504B RID: 151627
		void HideChoices();

		// Token: 0x0602504C RID: 151628
		void SetDialogueVisible(bool visible);

		// Token: 0x0602504D RID: 151629
		void SetAutoButtonVisible(bool visible);

		// Token: 0x0602504E RID: 151630
		void SetReviewButtonVisible(bool visible);

		// Token: 0x0602504F RID: 151631
		void SetMenuButtonVisible(bool visible);

		// Token: 0x06025050 RID: 151632
		void SetAccelerateButtonVisible(bool visible);

		// Token: 0x06025051 RID: 151633
		void SetHideUiButtonVisible(bool visible);

		// Token: 0x06025052 RID: 151634
		void SetUltraFastForwardButtonVisible(bool visible);

		// Token: 0x06025053 RID: 151635
		void SetPlaybackMode(EVisualNovelPlaybackMode playbackMode);

		// Token: 0x06025054 RID: 151636
		void SetInputLocked(bool locked);
	}
}
