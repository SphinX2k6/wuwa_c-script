using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F8 RID: 25592
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorParkourActivitySubView : ActivitySubViewBase
	{
		// Token: 0x17009430 RID: 37936
		// (get) Token: 0x060405D1 RID: 263633 RVA: 0x00F9193C File Offset: 0x00F8FB3C
		protected new MotorParkourActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as MotorParkourActivityData;
			}
		}

		// Token: 0x060405D2 RID: 263634 RVA: 0x00F9194C File Offset: 0x00F8FB4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060405D3 RID: 263635 RVA: 0x00F919D8 File Offset: 0x00F8FBD8
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourActivitySubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourActivitySubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060405D4 RID: 263636 RVA: 0x00F91A1B File Offset: 0x00F8FC1B
		protected override void OnRefreshView()
		{
			this.CommonInfoPanel.SetFunctionRedDotVisible(this.ActivityBaseData.RedPointShowState);
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel == null)
			{
				return;
			}
			commonInfoPanel.OnRefreshView();
		}

		// Token: 0x060405D5 RID: 263637 RVA: 0x00F91A43 File Offset: 0x00F8FC43
		private void OnConfirmBtnClick(ActivityBaseData data)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.MotorParkourMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x040217A5 RID: 137125
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0200C615 RID: 50709
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BCD6 RID: 244950
			public const int CommonActionInfo = 0;

			// Token: 0x0403BCD7 RID: 244951
			public const int TextureBg = 1;

			// Token: 0x0403BCD8 RID: 244952
			public const int TextureCharacterBg = 2;
		}
	}
}
