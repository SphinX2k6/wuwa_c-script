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
	// Token: 0x02006930 RID: 26928
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityPoiSubView : ActivitySubViewBase
	{
		// Token: 0x170097EF RID: 38895
		// (get) Token: 0x060431EE RID: 274926 RVA: 0x0105B9D7 File Offset: 0x01059BD7
		protected new ActivityPoiData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityPoiData;
			}
		}

		// Token: 0x060431EF RID: 274927 RVA: 0x0105B9E4 File Offset: 0x01059BE4
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

		// Token: 0x060431F0 RID: 274928 RVA: 0x0105BA2C File Offset: 0x01059C2C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityPoiSubView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityPoiSubView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060431F1 RID: 274929 RVA: 0x0105BA6F File Offset: 0x01059C6F
		protected override void OnAddEventListener()
		{
		}

		// Token: 0x060431F2 RID: 274930 RVA: 0x0105BA71 File Offset: 0x01059C71
		protected override void OnRemoveEventListener()
		{
		}

		// Token: 0x060431F3 RID: 274931 RVA: 0x0105BA74 File Offset: 0x01059C74
		private void OnConfirmBtnClick(ActivityBaseData _)
		{
			if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
			{
				ActivityController.Instance.JumpToViewOrOpenPreGuideQuest(this.ActivityBaseData, EUiViewName.QuestView, null, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.RoleQuestId, null);
		}

		// Token: 0x060431F4 RID: 274932 RVA: 0x0105BAC8 File Offset: 0x01059CC8
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

		// Token: 0x04022F08 RID: 143112
		protected ActivitySubViewGeneralInfo CommonInfoPanel;
	}
}
