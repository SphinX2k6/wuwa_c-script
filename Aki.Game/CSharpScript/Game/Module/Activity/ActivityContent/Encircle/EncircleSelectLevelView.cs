using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006679 RID: 26233
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleSelectLevelView : UiViewBase
	{
		// Token: 0x06041BCE RID: 269262 RVA: 0x00FF2045 File Offset: 0x00FF0245
		public EncircleSelectLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041BCF RID: 269263 RVA: 0x00FF205C File Offset: 0x00FF025C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
		}

		// Token: 0x06041BD0 RID: 269264 RVA: 0x00FF213C File Offset: 0x00FF033C
		protected override UniTask OnBeforeStartAsync()
		{
			EncircleSelectLevelView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EncircleSelectLevelView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041BD1 RID: 269265 RVA: 0x00FF217F File Offset: 0x00FF037F
		protected override void OnBeforeShow()
		{
			this.RefreshView();
		}

		// Token: 0x06041BD2 RID: 269266 RVA: 0x00FF2188 File Offset: 0x00FF0388
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

		// Token: 0x06041BD3 RID: 269267 RVA: 0x00FF2270 File Offset: 0x00FF0470
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
			Action<float> callback = delegate(float _)
			{
				int name = 2 + currentGroupId - 1;
				UUIItem item = this.GetItem(name);
				scrollItem.SetScrollProgress(1f - percentage + 0.15f);
				scrollItem.OnLateUpdate.Unbind();
				UiNavigationNewController.Instance.SetNavigationFocusForView(item, true, false, false);
			};
			scrollItem.OnLateUpdate.Bind(callback);
		}

		// Token: 0x06041BD4 RID: 269268 RVA: 0x00FF2319 File Offset: 0x00FF0519
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06041BD5 RID: 269269 RVA: 0x00FF2324 File Offset: 0x00FF0524
		private void OnClickHelpBtn()
		{
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			if (encircleData == null)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(encircleData.LocalConfig.Value.HelpId);
		}

		// Token: 0x04022361 RID: 140129
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022362 RID: 140130
		private readonly List<EncircleSelectLevelItemGrid> SelectItemList = new List<EncircleSelectLevelItemGrid>();
	}
}
