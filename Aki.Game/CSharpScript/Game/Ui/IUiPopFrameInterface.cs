using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200355D RID: 13661
	[NullableContext(1)]
	public interface IUiPopFrameInterface
	{
		// Token: 0x170048A0 RID: 18592
		// (get) Token: 0x06022C73 RID: 142451
		// (set) Token: 0x06022C74 RID: 142452
		[Nullable(2)]
		CommonPopViewBase PopItem { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06022C75 RID: 142453
		void SetCloseBtnInteractive(bool state);

		// Token: 0x06022C76 RID: 142454
		void SetTitleByTextIdAndArg(string textId, params object[] args);

		// Token: 0x06022C77 RID: 142455
		void SetBackBtnShowState(bool state);

		// Token: 0x06022C78 RID: 142456
		AActor GetPopViewRootActor();

		// Token: 0x06022C79 RID: 142457
		UUIItem GetPopViewRootItem();

		// Token: 0x06022C7A RID: 142458
		AActor GetPopViewOriginalActor();

		// Token: 0x06022C7B RID: 142459
		void HidePopView();

		// Token: 0x06022C7C RID: 142460
		void ShowPopView();

		// Token: 0x06022C7D RID: 142461
		void SetViewPermanent();

		// Token: 0x06022C7E RID: 142462
		void PlayLevelSequenceByName(string sequenceName, bool blockClick);

		// Token: 0x06022C7F RID: 142463
		UniTask PlaySequenceAsync(string sequenceName, CustomPromise<bool> stopPromise, bool blockClick = false, bool playReverse = false);
	}
}
