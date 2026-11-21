using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x020054ED RID: 21741
	[NullableContext(1)]
	[Nullable(0)]
	internal class ActivityFunPlayPages : UiPanelBase
	{
		// Token: 0x06035DF7 RID: 220663 RVA: 0x00F0C2B8 File Offset: 0x00F0A4B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.MoveToLeft));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.MoveToRight));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06035DF8 RID: 220664 RVA: 0x00F0C557 File Offset: 0x00F0A757
		protected override void OnStart()
		{
			this.InitPageDot();
		}

		// Token: 0x06035DF9 RID: 220665 RVA: 0x00F0C55F File Offset: 0x00F0A75F
		private void InitPageDot()
		{
			this.PageDotLayout = new GenericLayout<ActivityFunPlayPage, FunPlaySharpComment>(base.GetHorizontalLayout(11), new Func<ActivityFunPlayPage>(this.CreatePageDot), null, false, true);
		}

		// Token: 0x06035DFA RID: 220666 RVA: 0x00F0C583 File Offset: 0x00F0A783
		private ActivityFunPlayPage CreatePageDot()
		{
			return new ActivityFunPlayPage();
		}

		// Token: 0x06035DFB RID: 220667 RVA: 0x00F0C58C File Offset: 0x00F0A78C
		private void MoveToLeft()
		{
			if (this.CurrentCommentIndex - 1 < 0)
			{
				return;
			}
			this.CurrentCommentIndex--;
			this.PlaySwitchAnimation();
			this.OnSelectedComment(this.CurrentCommentIndex);
			GenericLayout<ActivityFunPlayPage, FunPlaySharpComment> pageDotLayout = this.PageDotLayout;
			if (pageDotLayout == null)
			{
				return;
			}
			pageDotLayout.SelectGridProxy(this.CurrentCommentIndex, true);
		}

		// Token: 0x06035DFC RID: 220668 RVA: 0x00F0C5DC File Offset: 0x00F0A7DC
		private void MoveToRight()
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			if (currentChallengeData == null)
			{
				return;
			}
			List<FunPlaySharpComment> sharpComments = currentChallengeData.GetSharpComments();
			if (this.CurrentCommentIndex + 1 > sharpComments.Count - 1)
			{
				return;
			}
			this.CurrentCommentIndex++;
			this.PlaySwitchAnimation();
			this.OnSelectedComment(this.CurrentCommentIndex);
			GenericLayout<ActivityFunPlayPage, FunPlaySharpComment> pageDotLayout = this.PageDotLayout;
			if (pageDotLayout == null)
			{
				return;
			}
			pageDotLayout.SelectGridProxy(this.CurrentCommentIndex, true);
		}

		// Token: 0x06035DFD RID: 220669 RVA: 0x00F0C64C File Offset: 0x00F0A84C
		public void Refresh(bool reset)
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			if (currentChallengeData == null)
			{
				return;
			}
			bool flag = currentChallengeData.GetSharpComments().Count <= 0;
			base.GetItem(1).SetUIActive(!flag);
			base.GetItem(5).SetUIActive(flag);
			base.GetItem(6).SetUIActive(!flag);
			base.GetText(10).SetUIActive(!flag);
			base.GetItem(13).SetUIActive(flag);
			this.RefreshVarStatePanel(null);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), EFunPlayTextKey.NoComment.ToString(), Array.Empty<object>());
				return;
			}
			List<FunPlaySharpComment> sharpComments = currentChallengeData.GetSharpComments();
			this.CurrentCommentIndex = (reset ? 0 : sharpComments.FindIndex((FunPlaySharpComment item) => item.CommentId == this.CurrentCommentId));
			if (this.CurrentCommentIndex == -1)
			{
				this.CurrentCommentIndex = 0;
			}
			this.OnSelectedComment(this.CurrentCommentIndex);
			this.RefreshPageDotLayout(sharpComments);
		}

		// Token: 0x06035DFE RID: 220670 RVA: 0x00F0C748 File Offset: 0x00F0A948
		public void RefreshPageDotLayout(List<FunPlaySharpComment> list)
		{
			base.GetHorizontalLayout(11).RootUIComp.Get().SetUIActive(list.Count > 1);
			if (list.Count > 1)
			{
				GenericLayout<ActivityFunPlayPage, FunPlaySharpComment> pageDotLayout = this.PageDotLayout;
				if (pageDotLayout == null)
				{
					return;
				}
				pageDotLayout.RefreshByData(list, delegate
				{
					GenericLayout<ActivityFunPlayPage, FunPlaySharpComment> pageDotLayout2 = this.PageDotLayout;
					if (pageDotLayout2 == null)
					{
						return;
					}
					pageDotLayout2.SelectGridProxy(this.CurrentCommentIndex, true);
				}, false);
			}
		}

		// Token: 0x06035DFF RID: 220671 RVA: 0x00F0C7A0 File Offset: 0x00F0A9A0
		private void OnSelectedComment(int index)
		{
			ActivityFunPlayChallengeData currentChallengeData = ActivityFunPlayModel.Instance.GetCurrentChallengeData();
			if (currentChallengeData == null)
			{
				return;
			}
			List<FunPlaySharpComment> sharpComments = currentChallengeData.GetSharpComments();
			this.RefreshArrowBtn(index, sharpComments.Count);
			FunPlaySharpComment value = sharpComments[index];
			this.CurrentCommentId = value.CommentId;
			base.SetTextureByPath(value.RoleHeadPath, base.GetTexture(7), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), value.RoleName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), value.Comment, Array.Empty<object>());
			ValueTuple<int, int> finishMonthAndDay = currentChallengeData.GetFinishMonthAndDay();
			int item = finishMonthAndDay.Item1;
			int item2 = finishMonthAndDay.Item2;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), value.TimeTxt, new <>z__ReadOnlyArray<object>(new object[]
			{
				item,
				item2
			}));
			base.SetTextureByPath(value.PhotoPath, base.GetTexture(12), null, null);
			this.RefreshVarStatePanel(new FunPlaySharpComment?(value));
		}

		// Token: 0x06035E00 RID: 220672 RVA: 0x00F0C8B8 File Offset: 0x00F0AAB8
		private void RefreshVarStatePanel(FunPlaySharpComment? data)
		{
			int? num = (data != null) ? new int?(data.GetValueOrDefault().VarState) : null;
			bool uiactive = num.GetValueOrDefault() == 1;
			bool flag;
			if (num != null)
			{
				int? num2 = num;
				int num3 = 2;
				flag = (num2.GetValueOrDefault() >= num3 & num2 != null);
			}
			else
			{
				flag = false;
			}
			bool uiactive2 = flag;
			base.GetItem(14).SetUIActive(uiactive2);
			base.GetItem(15).SetUIActive(uiactive);
		}

		// Token: 0x06035E01 RID: 220673 RVA: 0x00F0C940 File Offset: 0x00F0AB40
		private void RefreshArrowBtn(int index, int length)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(index > 0);
			base.GetButton(4).RootUIComp.Get().SetUIActive(index < length - 1);
		}

		// Token: 0x06035E02 RID: 220674 RVA: 0x00F0C989 File Offset: 0x00F0AB89
		public void SetParentSequence(UiBehaviorLevelSequence sequence)
		{
			this.ParentUiViewSequence = sequence;
		}

		// Token: 0x06035E03 RID: 220675 RVA: 0x00F0C994 File Offset: 0x00F0AB94
		private void PlaySwitchAnimation()
		{
			if (this.ParentUiViewSequence != null && this.ParentUiViewSequence.HasSequenceNameInPlaying("Switch1"))
			{
				this.ParentUiViewSequence.StopSequenceByKey("Switch1", false, true);
			}
			UiBehaviorLevelSequence parentUiViewSequence = this.ParentUiViewSequence;
			if (parentUiViewSequence == null)
			{
				return;
			}
			parentUiViewSequence.PlaySequence("Switch1", false, null);
		}

		// Token: 0x0401C7CA RID: 116682
		private GenericLayout<ActivityFunPlayPage, FunPlaySharpComment> PageDotLayout;

		// Token: 0x0401C7CB RID: 116683
		private int CurrentCommentIndex;

		// Token: 0x0401C7CC RID: 116684
		private int CurrentCommentId;

		// Token: 0x0401C7CD RID: 116685
		private UiBehaviorLevelSequence ParentUiViewSequence;

		// Token: 0x0200B14A RID: 45386
		[NullableContext(0)]
		private class EPageComponent
		{
			// Token: 0x04036D28 RID: 224552
			public const int Draggable = 0;

			// Token: 0x04036D29 RID: 224553
			public const int TextureContent = 1;

			// Token: 0x04036D2A RID: 224554
			public const int TextureItem = 2;

			// Token: 0x04036D2B RID: 224555
			public const int BtnLeft = 3;

			// Token: 0x04036D2C RID: 224556
			public const int BtnRight = 4;

			// Token: 0x04036D2D RID: 224557
			public const int RoleNone = 5;

			// Token: 0x04036D2E RID: 224558
			public const int Role = 6;

			// Token: 0x04036D2F RID: 224559
			public const int RoleHeadIcon = 7;

			// Token: 0x04036D30 RID: 224560
			public const int RoleName = 8;

			// Token: 0x04036D31 RID: 224561
			public const int RoleComment = 9;

			// Token: 0x04036D32 RID: 224562
			public const int TimeTxt = 10;

			// Token: 0x04036D33 RID: 224563
			public const int PageDotRoot = 11;

			// Token: 0x04036D34 RID: 224564
			public const int PhotoTexture = 12;

			// Token: 0x04036D35 RID: 224565
			public const int QuestionMark = 13;

			// Token: 0x04036D36 RID: 224566
			public const int PnlRed = 14;

			// Token: 0x04036D37 RID: 224567
			public const int PnlGreen = 15;
		}
	}
}
