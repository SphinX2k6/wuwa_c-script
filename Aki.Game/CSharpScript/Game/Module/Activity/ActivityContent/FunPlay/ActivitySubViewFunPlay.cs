using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x020054F2 RID: 21746
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewFunPlay : ActivitySubViewBase
	{
		// Token: 0x06035E4B RID: 220747 RVA: 0x00F0DE9C File Offset: 0x00F0C09C
		protected override void OnSetData()
		{
			this.ActivityData = (ActivityFunPlayData)this.ActivityBaseData;
		}

		// Token: 0x06035E4C RID: 220748 RVA: 0x00F0DEB0 File Offset: 0x00F0C0B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035E4D RID: 220749 RVA: 0x00F0DF1C File Offset: 0x00F0C11C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewFunPlay.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewFunPlay.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035E4E RID: 220750 RVA: 0x00F0DF5F File Offset: 0x00F0C15F
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				this.ActivityData.SetClickRedDotState();
				if (!this.ActivityData.GetPreGuideQuestFinishState())
				{
					UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityData.GetUnFinishPreGuideQuestId(), null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.ActivityFunPlayView, this.ActivityData, null);
			});
		}

		// Token: 0x06035E4F RID: 220751 RVA: 0x00F0DF7D File Offset: 0x00F0C17D
		protected override void OnRefreshView()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel == null)
			{
				return;
			}
			commonInfoPanel.SetFunctionRedDotVisible(this.ActivityData.CheckRedDot());
		}

		// Token: 0x0401C7DE RID: 116702
		protected ActivityFunPlayData ActivityData;

		// Token: 0x0401C7DF RID: 116703
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0200B154 RID: 45396
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04036D6D RID: 224621
			public const int ItemCommonPanel = 0;

			// Token: 0x04036D6E RID: 224622
			public const int TexBg = 1;
		}
	}
}
