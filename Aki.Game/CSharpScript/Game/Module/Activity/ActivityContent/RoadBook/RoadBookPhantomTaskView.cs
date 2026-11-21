using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200515A RID: 20826
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookPhantomTaskView : UiViewBase
	{
		// Token: 0x060340CA RID: 213194 RVA: 0x00E8F918 File Offset: 0x00E8DB18
		public RoadBookPhantomTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060340CB RID: 213195 RVA: 0x00E8F924 File Offset: 0x00E8DB24
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x060340CC RID: 213196 RVA: 0x00E8F98C File Offset: 0x00E8DB8C
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookPhantomTaskView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookPhantomTaskView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060340CD RID: 213197 RVA: 0x00E8F9D0 File Offset: 0x00E8DBD0
		protected override void OnBeforeShow()
		{
			foreach (KeyValuePair<int, bool> keyValuePair in this.ActivityBaseData.PhantomDataMap)
			{
				int key = keyValuePair.Key;
				if (keyValuePair.Value)
				{
					int id = key - 6000000;
					this.ActivityBaseData.SaveFirstCheckRedDotState(ERoadBookSaveFlag.PhantomCollectNewUnlock, id);
				}
			}
		}

		// Token: 0x060340CE RID: 213198 RVA: 0x00E8FA48 File Offset: 0x00E8DC48
		private PhantomCardItem OnCreateItem()
		{
			return new PhantomCardItem(this.ActivityBaseData);
		}

		// Token: 0x060340CF RID: 213199 RVA: 0x00E8FA58 File Offset: 0x00E8DC58
		protected UniTask Refresh()
		{
			RoadBookPhantomTaskView.<Refresh>d__9 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RoadBookPhantomTaskView.<Refresh>d__9>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x060340D0 RID: 213200 RVA: 0x00E8FA9C File Offset: 0x00E8DC9C
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x060340D1 RID: 213201 RVA: 0x00E8FACC File Offset: 0x00E8DCCC
		private void ScrollToCenter(int index)
		{
			UUIItem item = this.AreaLayoutList.GetItemByIndex(Math.Max(index, 0));
			if (item != null)
			{
				TTimerAction <>9__1;
				this.AreaLayoutList.BindLateUpdate(delegate(float delta)
				{
					TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
					TTimerAction action;
					if ((action = <>9__1) == null)
					{
						action = (<>9__1 = delegate(float _)
						{
							UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = this.GetScrollViewWithScrollbar(2);
							int num = (int)Math.Floor((double)(this.AreaLayoutList.ScrollWidth / item.Width / 2f));
							UUIItem itemByIndex = this.AreaLayoutList.GetItemByIndex(Math.Max(index - num, 0));
							FVector relativeLocation = scrollViewWithScrollbar.ContentUIItem.Get().RelativeLocation;
							FVector2D fvector2D = new FVector2D(ref relativeLocation);
							scrollViewWithScrollbar.ScrollToLeft(ref fvector2D, itemByIndex, false);
						});
					}
					gameplayTimeInstance.Next(action, null, null);
					this.AreaLayoutList.UnBindLateUpdate();
				});
			}
		}

		// Token: 0x0401B8DD RID: 112861
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401B8DE RID: 112862
		private ActivityRoadBookData ActivityBaseData;

		// Token: 0x0401B8DF RID: 112863
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B8E0 RID: 112864
		private GenericScrollViewNew<PhantomCardItem, int> AreaLayoutList;
	}
}
