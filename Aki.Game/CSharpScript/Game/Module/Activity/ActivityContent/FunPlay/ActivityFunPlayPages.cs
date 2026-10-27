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
	// Token: 0x0200656F RID: 25967
	[NullableContext(1)]
	[Nullable(0)]
	internal class ActivityFunPlayPages : UiPanelBase
	{
		// Token: 0x06041132 RID: 266546 RVA: 0x00FC52D4 File Offset: 0x00FC34D4
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

		// Token: 0x06041133 RID: 266547 RVA: 0x00FC5573 File Offset: 0x00FC3773
		protected override void OnStart()
		{
			this.InitPageDot();
		}

		// Token: 0x06041134 RID: 266548 RVA: 0x00FC557B File Offset: 0x00FC377B
		private void InitPageDot()
		{
			this.PageDotLayout = new GenericLayout<ActivityFunPlayPage, FunPlaySharpComment>(base.GetHorizontalLayout(11), new Func<ActivityFunPlayPage>(this.CreatePageDot), null, false, true);
		}

		// Token: 0x06041135 RID: 266549 RVA: 0x00FC559F File Offset: 0x00FC379F
		private ActivityFunPlayPage CreatePageDot()
		{
			return new ActivityFunPlayPage();
		}

		// Token: 0x06041136 RID: 266550 RVA: 0x00FC55A8 File Offset: 0x00FC37A8
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

		// Token: 0x06041137 RID: 266551 RVA: 0x00FC55F8 File Offset: 0x00FC37F8
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

		// Token: 0x06041138 RID: 266552 RVA: 0x00FC5668 File Offset: 0x00FC3868
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

		// Token: 0x06041139 RID: 266553 RVA: 0x00FC5764 File Offset: 0x00FC3964
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

		// Token: 0x0604113A RID: 266554 RVA: 0x00FC57BC File Offset: 0x00FC39BC
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

		// Token: 0x0604113B RID: 266555 RVA: 0x00FC58D4 File Offset: 0x00FC3AD4
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

		// Token: 0x0604113C RID: 266556 RVA: 0x00FC595C File Offset: 0x00FC3B5C
		private void RefreshArrowBtn(int index, int length)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(index > 0);
			base.GetButton(4).RootUIComp.Get().SetUIActive(index < length - 1);
		}

		// Token: 0x0604113D RID: 266557 RVA: 0x00FC59A5 File Offset: 0x00FC3BA5
		public void SetParentSequence(UiBehaviorLevelSequence sequence)
		{
			this.ParentUiViewSequence = sequence;
		}

		// Token: 0x0604113E RID: 266558 RVA: 0x00FC59B0 File Offset: 0x00FC3BB0
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

		// Token: 0x04021E99 RID: 138905
		private GenericLayout<ActivityFunPlayPage, FunPlaySharpComment> PageDotLayout;

		// Token: 0x04021E9A RID: 138906
		private int CurrentCommentIndex;

		// Token: 0x04021E9B RID: 138907
		private int CurrentCommentId;

		// Token: 0x04021E9C RID: 138908
		private UiBehaviorLevelSequence ParentUiViewSequence;

		// Token: 0x0200C765 RID: 51045
		[NullableContext(0)]
		private class EPageComponent
		{
			// Token: 0x0403C3D6 RID: 246742
			public const int Draggable = 0;

			// Token: 0x0403C3D7 RID: 246743
			public const int TextureContent = 1;

			// Token: 0x0403C3D8 RID: 246744
			public const int TextureItem = 2;

			// Token: 0x0403C3D9 RID: 246745
			public const int BtnLeft = 3;

			// Token: 0x0403C3DA RID: 246746
			public const int BtnRight = 4;

			// Token: 0x0403C3DB RID: 246747
			public const int RoleNone = 5;

			// Token: 0x0403C3DC RID: 246748
			public const int Role = 6;

			// Token: 0x0403C3DD RID: 246749
			public const int RoleHeadIcon = 7;

			// Token: 0x0403C3DE RID: 246750
			public const int RoleName = 8;

			// Token: 0x0403C3DF RID: 246751
			public const int RoleComment = 9;

			// Token: 0x0403C3E0 RID: 246752
			public const int TimeTxt = 10;

			// Token: 0x0403C3E1 RID: 246753
			public const int PageDotRoot = 11;

			// Token: 0x0403C3E2 RID: 246754
			public const int PhotoTexture = 12;

			// Token: 0x0403C3E3 RID: 246755
			public const int QuestionMark = 13;

			// Token: 0x0403C3E4 RID: 246756
			public const int PnlRed = 14;

			// Token: 0x0403C3E5 RID: 246757
			public const int PnlGreen = 15;
		}
	}
}
