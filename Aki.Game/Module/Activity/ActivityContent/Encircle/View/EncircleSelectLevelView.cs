using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle.View
{
	// Token: 0x02003029 RID: 12329
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleSelectLevelView : UiViewBase
	{
		// Token: 0x0601D3F6 RID: 119798 RVA: 0x008EE209 File Offset: 0x008EC409
		public EncircleSelectLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D3F7 RID: 119799 RVA: 0x008EE220 File Offset: 0x008EC420
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0601D3F8 RID: 119800 RVA: 0x008EE374 File Offset: 0x008EC574
		protected override UniTask OnBeforeStartAsync()
		{
			EncircleSelectLevelView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EncircleSelectLevelView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601D3F9 RID: 119801 RVA: 0x008EE3B7 File Offset: 0x008EC5B7
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x0601D3FA RID: 119802 RVA: 0x008EE3C0 File Offset: 0x008EC5C0
		public void RefreshView()
		{
			List<IEncircleSelectLevelData> list = new List<IEncircleSelectLevelData>();
			int activityId = ActivityEncircleController.Instance.ActivityId;
			foreach (EncircleChallengeGroup encircleChallengeGroup in ActivityEncircleConfig.Instance.GetEncircleGroups(activityId))
			{
				EncircleSelectLevelData item = new EncircleSelectLevelData
				{
					GroupId = encircleChallengeGroup.Id
				};
				list.Add(item);
			}
			int count = list.Count;
			int count2 = this.SelectItemList.Count;
			for (int i = 0; i < count2; i++)
			{
				if (i < count)
				{
					this.SelectItemList[i].RefreshView(list[i]);
					this.SelectItemList[i].SetUiActive(true);
				}
				else
				{
					this.SelectItemList[i].SetUiActive(false);
				}
			}
		}

		// Token: 0x0601D3FB RID: 119803 RVA: 0x008EE4A8 File Offset: 0x008EC6A8
		private void RefreshScrollPercentage()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData == null)
			{
				return;
			}
			int activityId = ActivityEncircleController.Instance.ActivityId;
			IReadOnlyList<EncircleChallengeGroup> encircleGroups = ActivityEncircleConfig.Instance.GetEncircleGroups(activityId);
			int currentGroupId = encircleData.GetCurrentGroup();
			if (currentGroupId == 0)
			{
				return;
			}
			if (encircleGroups == null)
			{
				return;
			}
			UUIScrollViewWithScrollbarComponent scrollItem = base.GetScrollViewWithScrollbar(1);
			float percentage = (float)currentGroupId / (float)encircleGroups.Count;
			if (percentage < 0f)
			{
				return;
			}
			scrollItem.OnLateUpdate.Bind(delegate(float _)
			{
				int name = 2 + currentGroupId - 1;
				UUIItem item = this.GetItem(name);
				scrollItem.SetScrollProgress(1f - percentage + 0.15f);
				scrollItem.OnLateUpdate.Unbind();
				UiNavigationNewController.Instance.SetNavigationFocusForView(item, true, false, false);
			});
		}

		// Token: 0x0601D3FC RID: 119804 RVA: 0x008EE54D File Offset: 0x008EC74D
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0601D3FD RID: 119805 RVA: 0x008EE558 File Offset: 0x008EC758
		private void OnClickHelpBtn()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData == null)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(encircleData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0400F66B RID: 63083
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0400F66C RID: 63084
		private readonly List<EncircleSelectLevelItemGrid> SelectItemList = new List<EncircleSelectLevelItemGrid>();
	}
}
