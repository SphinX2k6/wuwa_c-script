using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.ActivityPOI
{
	// Token: 0x02005880 RID: 22656
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityPoiSubView : ActivitySubViewBase
	{
		// Token: 0x17006B2F RID: 27439
		// (get) Token: 0x06037D46 RID: 228678 RVA: 0x00F9D003 File Offset: 0x00F9B203
		protected new ActivityPoiData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityPoiData;
			}
		}

		// Token: 0x06037D47 RID: 228679 RVA: 0x00F9D010 File Offset: 0x00F9B210
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06037D48 RID: 228680 RVA: 0x00F9D058 File Offset: 0x00F9B258
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityPoiSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityPoiSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037D49 RID: 228681 RVA: 0x00F9D09B File Offset: 0x00F9B29B
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x06037D4A RID: 228682 RVA: 0x00F9D09D File Offset: 0x00F9B29D
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x06037D4B RID: 228683 RVA: 0x00F9D0A0 File Offset: 0x00F9B2A0
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				ActivityController.Instance.JumpToViewOrOpenPreGuideQuest(this.ActivityBaseData, EUiViewName.QuestView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.RoleQuestId, null);
		}

		// Token: 0x06037D4C RID: 228684 RVA: 0x00F9D0F4 File Offset: 0x00F9B2F4
		protected override void OnRefreshView()
		{
			this.CommonInfoPanel.SetBtnText("PrefabTextItem_2329755894_Text", Array.Empty<object>());
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.RefreshFunction();
			}
			if (this.ActivityBaseData.FinishShowState)
			{
				ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
				if (commonInfoPanel2 != null)
				{
					ActivityFunctionalTypeA functional = commonInfoPanel2.GetFunctional();
					if (functional != null)
					{
						ActivityButtonItem functionButton = functional.FunctionButton;
						if (functionButton != null)
						{
							functionButton.SetUiActive(false);
						}
					}
				}
				ActivitySubViewGeneralInfo commonInfoPanel3 = this.CommonInfoPanel;
				if (commonInfoPanel3 != null)
				{
					ActivityFunctionalTypeA functional2 = commonInfoPanel3.GetFunctional();
					if (functional2 != null)
					{
						functional2.SetPanelConditionVisible(false);
					}
				}
				ActivitySubViewGeneralInfo commonInfoPanel4 = this.CommonInfoPanel;
				if (commonInfoPanel4 == null)
				{
					return;
				}
				ActivityFunctionalTypeA functional3 = commonInfoPanel4.GetFunctional();
				if (functional3 == null)
				{
					return;
				}
				functional3.SetActivatePanelConditionVisible(true);
			}
		}

		// Token: 0x0401D764 RID: 120676
		protected ActivitySubViewGeneralInfo CommonInfoPanel;
	}
}
