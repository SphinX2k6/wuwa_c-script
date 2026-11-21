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
	// Token: 0x02005376 RID: 21366
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorParkourActivitySubView : ActivitySubViewBase
	{
		// Token: 0x17006792 RID: 26514
		// (get) Token: 0x06035292 RID: 217746 RVA: 0x00ED891C File Offset: 0x00ED6B1C
		protected new MotorParkourActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as MotorParkourActivityData;
			}
		}

		// Token: 0x06035293 RID: 217747 RVA: 0x00ED892C File Offset: 0x00ED6B2C
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

		// Token: 0x06035294 RID: 217748 RVA: 0x00ED89B8 File Offset: 0x00ED6BB8
		protected override UniTask OnBeforeStartAsync()
		{
			MotorParkourActivitySubView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorParkourActivitySubView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035295 RID: 217749 RVA: 0x00ED89FB File Offset: 0x00ED6BFB
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

		// Token: 0x06035296 RID: 217750 RVA: 0x00ED8A23 File Offset: 0x00ED6C23
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

		// Token: 0x0401C0D4 RID: 114900
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0200AFFC RID: 45052
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036635 RID: 222773
			public const int CommonActionInfo = 0;

			// Token: 0x04036636 RID: 222774
			public const int TextureBg = 1;

			// Token: 0x04036637 RID: 222775
			public const int TextureCharacterBg = 2;
		}
	}
}
