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
	// Token: 0x02006574 RID: 25972
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewFunPlay : ActivitySubViewBase
	{
		// Token: 0x06041186 RID: 266630 RVA: 0x00FC6EB8 File Offset: 0x00FC50B8
		protected override void OnSetData()
		{
			this.ActivityData = (ActivityFunPlayData)this.ActivityBaseData;
		}

		// Token: 0x06041187 RID: 266631 RVA: 0x00FC6ECC File Offset: 0x00FC50CC
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

		// Token: 0x06041188 RID: 266632 RVA: 0x00FC6F38 File Offset: 0x00FC5138
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewFunPlay.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewFunPlay.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041189 RID: 266633 RVA: 0x00FC6F7B File Offset: 0x00FC517B
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

		// Token: 0x0604118A RID: 266634 RVA: 0x00FC6F99 File Offset: 0x00FC5199
		protected override void OnRefreshView()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel == null)
			{
				return;
			}
			commonInfoPanel.SetFunctionRedDotVisible(this.ActivityData.CheckRedDot());
		}

		// Token: 0x04021EAD RID: 138925
		protected ActivityFunPlayData ActivityData;

		// Token: 0x04021EAE RID: 138926
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0200C76F RID: 51055
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403C41B RID: 246811
			public const int ItemCommonPanel = 0;

			// Token: 0x0403C41C RID: 246812
			public const int TexBg = 1;
		}
	}
}
