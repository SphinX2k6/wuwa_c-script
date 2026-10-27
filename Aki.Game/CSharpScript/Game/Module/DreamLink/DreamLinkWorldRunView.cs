using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB8 RID: 23224
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkWorldRunView : UiTickViewBase
	{
		// Token: 0x0603AD2A RID: 240938 RVA: 0x00E040AB File Offset: 0x00E022AB
		public DreamLinkWorldRunView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603AD2B RID: 240939 RVA: 0x00E040B4 File Offset: 0x00E022B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AD2C RID: 240940 RVA: 0x00E041A4 File Offset: 0x00E023A4
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkWorldRunView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkWorldRunView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AD2D RID: 240941 RVA: 0x00E041E8 File Offset: 0x00E023E8
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(1));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.TaskLayout = new GenericScrollViewNew<DreamLinkWorldRunTaskItem, DreamLinkRunTaskData>(base.GetScrollViewWithScrollbar(0), new Func<DreamLinkWorldRunTaskItem>(this.CreateTaskItem), null, false, null);
			this.RefreshSpine();
		}

		// Token: 0x0603AD2E RID: 240942 RVA: 0x00E04245 File Offset: 0x00E02445
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0603AD2F RID: 240943 RVA: 0x00E04247 File Offset: 0x00E02447
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DreamLinkRewardRefresh, new Action(this.RefreshTaskLayout));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603AD30 RID: 240944 RVA: 0x00E04281 File Offset: 0x00E02481
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DreamLinkRewardRefresh, new Action(this.RefreshTaskLayout));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0603AD31 RID: 240945 RVA: 0x00E042BC File Offset: 0x00E024BC
		protected override void OnTick(float delta)
		{
			if (this.TaskLayout == null)
			{
				return;
			}
			foreach (DreamLinkWorldRunTaskItem dreamLinkWorldRunTaskItem in this.TaskLayout.GetScrollItemList())
			{
				dreamLinkWorldRunTaskItem.RefreshLockText();
			}
		}

		// Token: 0x0603AD32 RID: 240946 RVA: 0x00E0431C File Offset: 0x00E0251C
		private DreamLinkWorldRunTaskItem CreateTaskItem()
		{
			return new DreamLinkWorldRunTaskItem();
		}

		// Token: 0x0603AD33 RID: 240947 RVA: 0x00E04324 File Offset: 0x00E02524
		private void RefreshSpine()
		{
			base.GetSpine(3).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
			base.GetSpine(4).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
			string animationName = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? EDreamLinkSpineDefine.MainFemale.ToString() : EDreamLinkSpineDefine.MainMale.ToString();
			base.GetSpine(5).SetAnimation(0, animationName, true);
		}

		// Token: 0x0603AD34 RID: 240948 RVA: 0x00E043AE File Offset: 0x00E025AE
		private void OnActivitySequenceEmitEvent(string param)
		{
			if ("InturnAnimation" == param)
			{
				this.RefreshTaskLayout();
			}
		}

		// Token: 0x0603AD35 RID: 240949 RVA: 0x00E043C3 File Offset: 0x00E025C3
		private void RefreshTaskLayout()
		{
			if (this.ActivityDataBase == null)
			{
				return;
			}
			this.TaskLayout.RefreshByData(this.ActivityDataBase.GetDreamLinkRunTaskDataList(), null, true);
		}

		// Token: 0x0603AD36 RID: 240950 RVA: 0x00E043E6 File Offset: 0x00E025E6
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401EB24 RID: 125732
		private const string LAYOUT_ANIMATION_START = "InturnAnimation";

		// Token: 0x0401EB25 RID: 125733
		[Nullable(2)]
		private DreamLinkData ActivityDataBase;

		// Token: 0x0401EB26 RID: 125734
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401EB27 RID: 125735
		[Nullable(2)]
		private DreamLinkScoreRewardItem RewardItem;

		// Token: 0x0401EB28 RID: 125736
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DreamLinkWorldRunTaskItem, DreamLinkRunTaskData> TaskLayout;

		// Token: 0x0200BD0A RID: 48394
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403902B RID: 233515
			public const int Layout = 0;

			// Token: 0x0403902C RID: 233516
			public const int CaptionItem = 1;

			// Token: 0x0403902D RID: 233517
			public const int ButtonScore = 2;

			// Token: 0x0403902E RID: 233518
			public const int SpineA = 3;

			// Token: 0x0403902F RID: 233519
			public const int SpineB = 4;

			// Token: 0x04039030 RID: 233520
			public const int SpineCharacter = 5;
		}
	}
}
