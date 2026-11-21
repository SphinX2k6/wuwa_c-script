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
	// Token: 0x020051FC RID: 20988
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenPhantomTaskView : UiViewBase
	{
		// Token: 0x06034441 RID: 214081 RVA: 0x00E9EF2C File Offset: 0x00E9D12C
		public RealmBetweenPhantomTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034442 RID: 214082 RVA: 0x00E9EF38 File Offset: 0x00E9D138
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

		// Token: 0x06034443 RID: 214083 RVA: 0x00E9EFA0 File Offset: 0x00E9D1A0
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenPhantomTaskView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenPhantomTaskView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034444 RID: 214084 RVA: 0x00E9EFE4 File Offset: 0x00E9D1E4
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

		// Token: 0x06034445 RID: 214085 RVA: 0x00E9F05C File Offset: 0x00E9D25C
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityData.LocalConfig.Value.HelpId);
		}

		// Token: 0x06034446 RID: 214086 RVA: 0x00E9F08B File Offset: 0x00E9D28B
		private RealmBetweenPhantomCardItem OnCreateItem()
		{
			return new RealmBetweenPhantomCardItem(this.ActivityData);
		}

		// Token: 0x06034447 RID: 214087 RVA: 0x00E9F098 File Offset: 0x00E9D298
		protected UniTask Refresh()
		{
			RealmBetweenPhantomTaskView.<Refresh>d__10 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<RealmBetweenPhantomTaskView.<Refresh>d__10>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x06034448 RID: 214088 RVA: 0x00E9F0DC File Offset: 0x00E9D2DC
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

		// Token: 0x0401BBE1 RID: 113633
		private ActivityRealmBetweenData ActivityData;

		// Token: 0x0401BBE2 RID: 113634
		private GenericScrollViewNew<RealmBetweenPhantomCardItem, int> AreaLayoutList;

		// Token: 0x0401BBE3 RID: 113635
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401BBE4 RID: 113636
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;
	}
}
