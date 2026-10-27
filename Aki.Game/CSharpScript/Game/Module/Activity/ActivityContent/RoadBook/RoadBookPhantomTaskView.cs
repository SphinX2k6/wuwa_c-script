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
	// Token: 0x020061DC RID: 25052
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookPhantomTaskView : UiViewBase
	{
		// Token: 0x0603F409 RID: 259081 RVA: 0x00F489C0 File Offset: 0x00F46BC0
		public RoadBookPhantomTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F40A RID: 259082 RVA: 0x00F489CC File Offset: 0x00F46BCC
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

		// Token: 0x0603F40B RID: 259083 RVA: 0x00F48A34 File Offset: 0x00F46C34
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookPhantomTaskView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookPhantomTaskView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F40C RID: 259084 RVA: 0x00F48A78 File Offset: 0x00F46C78
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

		// Token: 0x0603F40D RID: 259085 RVA: 0x00F48AF0 File Offset: 0x00F46CF0
		private PhantomCardItem OnCreateItem()
		{
			return new PhantomCardItem(this.ActivityBaseData);
		}

		// Token: 0x0603F40E RID: 259086 RVA: 0x00F48B00 File Offset: 0x00F46D00
		protected UniTask Refresh()
		{
			RoadBookPhantomTaskView.<Refresh>d__9 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RoadBookPhantomTaskView.<Refresh>d__9>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0603F40F RID: 259087 RVA: 0x00F48B44 File Offset: 0x00F46D44
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0603F410 RID: 259088 RVA: 0x00F48B74 File Offset: 0x00F46D74
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

		// Token: 0x04020FAE RID: 135086
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x04020FAF RID: 135087
		private ActivityRoadBookData ActivityBaseData;

		// Token: 0x04020FB0 RID: 135088
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04020FB1 RID: 135089
		private GenericScrollViewNew<PhantomCardItem, int> AreaLayoutList;
	}
}
