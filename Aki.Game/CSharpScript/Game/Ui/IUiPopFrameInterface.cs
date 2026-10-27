using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004633 RID: 17971
	[NullableContext(1)]
	public interface IUiPopFrameInterface
	{
		// Token: 0x170075E6 RID: 30182
		// (get) Token: 0x0602E54F RID: 189775
		// (set) Token: 0x0602E550 RID: 189776
		[Nullable(2)]
		CommonPopViewBase PopItem { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x0602E551 RID: 189777
		void SetCloseBtnInteractive(bool state);

		// Token: 0x0602E552 RID: 189778
		void SetTitleByTextIdAndArg(string textId, params object[] args);

		// Token: 0x0602E553 RID: 189779
		void SetBackBtnShowState(bool state);

		// Token: 0x0602E554 RID: 189780
		AActor GetPopViewRootActor();

		// Token: 0x0602E555 RID: 189781
		UUIItem GetPopViewRootItem();

		// Token: 0x0602E556 RID: 189782
		AActor GetPopViewOriginalActor();

		// Token: 0x0602E557 RID: 189783
		void HidePopView();

		// Token: 0x0602E558 RID: 189784
		void ShowPopView();

		// Token: 0x0602E559 RID: 189785
		void SetViewPermanent();

		// Token: 0x0602E55A RID: 189786
		void PlayLevelSequenceByName(string sequenceName, bool blockClick);

		// Token: 0x0602E55B RID: 189787
		UniTask PlaySequenceAsync(string sequenceName, CustomPromise<bool> stopPromise, bool blockClick = false, bool playReverse = false);
	}
}
