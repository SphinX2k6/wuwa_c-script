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
	// Token: 0x02004A94 RID: 19092
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkWorldRunView : UiTickViewBase
	{
		// Token: 0x0602FC76 RID: 195702 RVA: 0x00D54673 File Offset: 0x00D52873
		public DreamLinkWorldRunView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602FC77 RID: 195703 RVA: 0x00D5467C File Offset: 0x00D5287C
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

		// Token: 0x0602FC78 RID: 195704 RVA: 0x00D5476C File Offset: 0x00D5296C
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkWorldRunView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkWorldRunView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FC79 RID: 195705 RVA: 0x00D547B0 File Offset: 0x00D529B0
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(1));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseBtnClick));
			this.TaskLayout = new GenericScrollViewNew<DreamLinkWorldRunTaskItem, DreamLinkRunTaskData>(base.GetScrollViewWithScrollbar(0), new Func<DreamLinkWorldRunTaskItem>(this.CreateTaskItem), null, false, null);
			this.RefreshSpine();
		}

		// Token: 0x0602FC7A RID: 195706 RVA: 0x00D5480D File Offset: 0x00D52A0D
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x0602FC7B RID: 195707 RVA: 0x00D5480F File Offset: 0x00D52A0F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DreamLinkRewardRefresh, new Action(this.RefreshTaskLayout));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0602FC7C RID: 195708 RVA: 0x00D54849 File Offset: 0x00D52A49
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DreamLinkRewardRefresh, new Action(this.RefreshTaskLayout));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		}

		// Token: 0x0602FC7D RID: 195709 RVA: 0x00D54884 File Offset: 0x00D52A84
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

		// Token: 0x0602FC7E RID: 195710 RVA: 0x00D548E4 File Offset: 0x00D52AE4
		private DreamLinkWorldRunTaskItem CreateTaskItem()
		{
			return new DreamLinkWorldRunTaskItem();
		}

		// Token: 0x0602FC7F RID: 195711 RVA: 0x00D548EC File Offset: 0x00D52AEC
		private void RefreshSpine()
		{
			base.GetSpine(3).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
			base.GetSpine(4).SetAnimation(0, EDreamLinkSpineDefine.Idle.ToString(), true);
			string animationName = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? EDreamLinkSpineDefine.MainFemale.ToString() : EDreamLinkSpineDefine.MainMale.ToString();
			base.GetSpine(5).SetAnimation(0, animationName, true);
		}

		// Token: 0x0602FC80 RID: 195712 RVA: 0x00D54976 File Offset: 0x00D52B76
		private void OnActivitySequenceEmitEvent(string param)
		{
			if ("InturnAnimation" == param)
			{
				this.RefreshTaskLayout();
			}
		}

		// Token: 0x0602FC81 RID: 195713 RVA: 0x00D5498B File Offset: 0x00D52B8B
		private void RefreshTaskLayout()
		{
			if (this.ActivityDataBase == null)
			{
				return;
			}
			this.TaskLayout.RefreshByData(this.ActivityDataBase.GetDreamLinkRunTaskDataList(), null, true);
		}

		// Token: 0x0602FC82 RID: 195714 RVA: 0x00D549AE File Offset: 0x00D52BAE
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040195CB RID: 103883
		private const string LAYOUT_ANIMATION_START = "InturnAnimation";

		// Token: 0x040195CC RID: 103884
		[Nullable(2)]
		private DreamLinkData ActivityDataBase;

		// Token: 0x040195CD RID: 103885
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040195CE RID: 103886
		[Nullable(2)]
		private DreamLinkScoreRewardItem RewardItem;

		// Token: 0x040195CF RID: 103887
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DreamLinkWorldRunTaskItem, DreamLinkRunTaskData> TaskLayout;

		// Token: 0x0200A712 RID: 42770
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040339F5 RID: 211445
			public const int Layout = 0;

			// Token: 0x040339F6 RID: 211446
			public const int CaptionItem = 1;

			// Token: 0x040339F7 RID: 211447
			public const int ButtonScore = 2;

			// Token: 0x040339F8 RID: 211448
			public const int SpineA = 3;

			// Token: 0x040339F9 RID: 211449
			public const int SpineB = 4;

			// Token: 0x040339FA RID: 211450
			public const int SpineCharacter = 5;
		}
	}
}
