using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200627E RID: 25214
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenPhantomTaskView : UiViewBase
	{
		// Token: 0x0603F780 RID: 259968 RVA: 0x00F57FD0 File Offset: 0x00F561D0
		public RealmBetweenPhantomTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F781 RID: 259969 RVA: 0x00F57FDC File Offset: 0x00F561DC
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

		// Token: 0x0603F782 RID: 259970 RVA: 0x00F58044 File Offset: 0x00F56244
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenPhantomTaskView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenPhantomTaskView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F783 RID: 259971 RVA: 0x00F58088 File Offset: 0x00F56288
		protected override void OnBeforeShow()
		{
			foreach (KeyValuePair<int, bool> keyValuePair in this.ActivityData.PhantomDataMap)
			{
				int key = keyValuePair.Key;
				if (keyValuePair.Value)
				{
					int id = key - 6000000;
					this.ActivityData.SaveFirstCheckRedDotState(ERealmBetweenSaveFlag.PhantomCollectNewUnlock, id);
				}
			}
		}

		// Token: 0x0603F784 RID: 259972 RVA: 0x00F58100 File Offset: 0x00F56300
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0603F785 RID: 259973 RVA: 0x00F5812F File Offset: 0x00F5632F
		private RealmBetweenPhantomCardItem OnCreateItem()
		{
			return new RealmBetweenPhantomCardItem(this.ActivityData);
		}

		// Token: 0x0603F786 RID: 259974 RVA: 0x00F5813C File Offset: 0x00F5633C
		protected UniTask Refresh()
		{
			RealmBetweenPhantomTaskView.<Refresh>d__10 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RealmBetweenPhantomTaskView.<Refresh>d__10>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0603F787 RID: 259975 RVA: 0x00F58180 File Offset: 0x00F56380
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

		// Token: 0x040212B2 RID: 135858
		private ActivityRealmBetweenData ActivityData;

		// Token: 0x040212B3 RID: 135859
		private GenericScrollViewNew<RealmBetweenPhantomCardItem, int> AreaLayoutList;

		// Token: 0x040212B4 RID: 135860
		private PopupCaptionItem CaptionComponent;

		// Token: 0x040212B5 RID: 135861
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
