using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A14 RID: 23060
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolChooseEndingView : SolarSchoolHideHudViewBase
	{
		// Token: 0x06038C96 RID: 232598 RVA: 0x00FE53AE File Offset: 0x00FE35AE
		public SolarSchoolChooseEndingView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038C97 RID: 232599 RVA: 0x00FE53C4 File Offset: 0x00FE35C4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnConfirmClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038C98 RID: 232600 RVA: 0x00FE5530 File Offset: 0x00FE3730
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolChooseEndingView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolChooseEndingView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C99 RID: 232601 RVA: 0x00FE5574 File Offset: 0x00FE3774
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			UUIItem item = base.GetItem(0);
			object obj;
			if (item == null)
			{
				obj = null;
			}
			else
			{
				AActor owner = item.GetOwner();
				obj = ((owner != null) ? owner.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null);
			}
			UUIInturnAnimController uuiinturnAnimController = obj as UUIInturnAnimController;
			if (uuiinturnAnimController != null)
			{
				uuiinturnAnimController.Play("", -1, false);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06038C9A RID: 232602 RVA: 0x00FE55C8 File Offset: 0x00FE37C8
		protected override void OnBeforeDestroy()
		{
			Action cancelCallback = this.CancelCallback;
			this.ConfirmCallback = null;
			this.CancelCallback = null;
			NoCircleAttachView<SolarSchoolEnding, SolarSchoolEndingCardItem> endingAttachView = this.EndingAttachView;
			if (endingAttachView != null)
			{
				endingAttachView.Clear();
			}
			this.EndingAttachView = null;
			this.MoveCurve = null;
			GenericLayout<SolarSchoolEndingPageItem, int> pageLayout = this.PageLayout;
			if (pageLayout != null)
			{
				pageLayout.ClearChildren();
			}
			this.PageLayout = null;
			this.EndingRows = new List<SolarSchoolEnding>();
			this.SelectedEndingId = 0;
			this.SelectedEndingIndex = 0;
			this.ActivityId = 0;
			if (cancelCallback == null)
			{
				return;
			}
			cancelCallback();
		}

		// Token: 0x06038C9B RID: 232603 RVA: 0x00FE564C File Offset: 0x00FE384C
		private unsafe static List<SolarSchoolEnding> BuildEndingRows(SolarSchoolChooseEndingViewParam param)
		{
			List<SolarSchoolEnding> list = new List<SolarSchoolEnding>();
			foreach (SolarSchoolEnding item in SolarSchoolConfig.Instance.GetEndingList(param.ActivityId))
			{
				if (param.CandidateIds == null)
				{
					list.Add(item);
				}
				else
				{
					bool flag = false;
					using (IEnumerator<int> enumerator2 = param.CandidateIds.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current == item.Id)
							{
								flag = true;
								break;
							}
						}
					}
					if (flag)
					{
						list.Add(item);
					}
				}
			}
			List<SolarSchoolEnding> list2 = SolarSchoolUtils.FilterAvailableEndings(list, param.EndingType);
			if (list2.Count == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 当前没有可选的结局";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", param.ActivityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("endingType", param.EndingType);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return list2;
		}

		// Token: 0x06038C9C RID: 232604 RVA: 0x00FE5788 File Offset: 0x00FE3988
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<UCurveFloat> LoadMoveCurveAsync()
		{
			SolarSchoolChooseEndingView.<LoadMoveCurveAsync>d__19 <LoadMoveCurveAsync>d__;
			<LoadMoveCurveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat>.Create();
			<LoadMoveCurveAsync>d__.<>1__state = -1;
			<LoadMoveCurveAsync>d__.<>t__builder.Start<SolarSchoolChooseEndingView.<LoadMoveCurveAsync>d__19>(ref <LoadMoveCurveAsync>d__);
			return <LoadMoveCurveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C9D RID: 232605 RVA: 0x00FE57C4 File Offset: 0x00FE39C4
		private void OnSelectEnding(int endingId)
		{
			int num = this.EndingRows.FindIndex((SolarSchoolEnding config) => config.Id == endingId);
			if (num < 0)
			{
				return;
			}
			this.SelectedEndingId = endingId;
			this.SelectedEndingIndex = num;
			this.RefreshSelectedPage(num);
			this.RefreshPageNumber(num);
			this.RefreshTips();
		}

		// Token: 0x06038C9E RID: 232606 RVA: 0x00FE5824 File Offset: 0x00FE3A24
		private void RefreshTips()
		{
			SolarSchoolActivityData activityData = SolarSchoolModel.Instance.GetActivityData(this.ActivityId);
			bool uiactive = activityData != null && activityData.IsEndingUnlocked(this.SelectedEndingId);
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06038C9F RID: 232607 RVA: 0x00FE5868 File Offset: 0x00FE3A68
		private SolarSchoolEndingCardItem CreateEndingCardItem(AActor actor, int index, int showNum)
		{
			return new SolarSchoolEndingCardItem(actor)
			{
				SelectCallback = new Action<int>(this.OnSelectEnding),
				AttachCallback = new Action<int>(this.OnAttachEnding),
				CanClickCallback = new Func<bool>(this.CanClickEnding),
				MoveCurve = this.MoveCurve,
				ItemSpacing = 492f,
				SelectedItemSpacing = 800f,
				MaxHierarchyIndex = this.EndingRows.Count + 1
			};
		}

		// Token: 0x06038CA0 RID: 232608 RVA: 0x00FE58E6 File Offset: 0x00FE3AE6
		private void OnAttachEnding(int index)
		{
			if (index < 0 || index >= this.EndingRows.Count)
			{
				return;
			}
			NoCircleAttachView<SolarSchoolEnding, SolarSchoolEndingCardItem> endingAttachView = this.EndingAttachView;
			if (endingAttachView == null)
			{
				return;
			}
			endingAttachView.AttachToIndex(index, false);
		}

		// Token: 0x06038CA1 RID: 232609 RVA: 0x00FE590D File Offset: 0x00FE3B0D
		private SolarSchoolEndingPageItem CreateEndingPageItem()
		{
			return new SolarSchoolEndingPageItem
			{
				ClickCallback = new Action<int>(this.OnPageClick)
			};
		}

		// Token: 0x06038CA2 RID: 232610 RVA: 0x00FE5926 File Offset: 0x00FE3B26
		private void OnPageClick(int index)
		{
			if (!this.CanClickEnding())
			{
				this.RefreshSelectedPage(this.SelectedEndingIndex);
				return;
			}
			this.OnAttachEnding(index);
		}

		// Token: 0x06038CA3 RID: 232611 RVA: 0x00FE5944 File Offset: 0x00FE3B44
		private void RefreshSelectedPage(int index)
		{
			if (this.PageLayout == null || index < 0 || index >= this.PageLayout.GetDisplayGridNum())
			{
				return;
			}
			this.PageLayout.SelectGridProxy(index, false);
		}

		// Token: 0x06038CA4 RID: 232612 RVA: 0x00FE596E File Offset: 0x00FE3B6E
		private void RefreshPageNumber(int index)
		{
			this.SetPageNumberTexture(base.GetTexture(5), index + 1);
			this.SetPageNumberTexture(base.GetTexture(6), this.EndingRows.Count);
		}

		// Token: 0x06038CA5 RID: 232613 RVA: 0x00FE5998 File Offset: 0x00FE3B98
		[NullableContext(2)]
		private void SetPageNumberTexture(UUITexture texture, int number)
		{
			string pageNumberTexturePath = SolarSchoolChooseEndingView.GetPageNumberTexturePath(number);
			if (texture == null || string.IsNullOrEmpty(pageNumberTexturePath))
			{
				return;
			}
			base.SetTextureByPath(pageNumberTexturePath, texture, null, null);
		}

		// Token: 0x06038CA6 RID: 232614 RVA: 0x00FE59CA File Offset: 0x00FE3BCA
		[NullableContext(2)]
		private static string GetPageNumberTexturePath(int number)
		{
			return null;
		}

		// Token: 0x06038CA7 RID: 232615 RVA: 0x00FE59CD File Offset: 0x00FE3BCD
		private bool CanClickEnding()
		{
			return this.EndingAttachView != null && !this.EndingAttachView.MovingState() && !this.EndingAttachView.IsVelocityMoveState();
		}

		// Token: 0x06038CA8 RID: 232616 RVA: 0x00FE59F4 File Offset: 0x00FE3BF4
		private void OnConfirmClick()
		{
			if (this.SelectedEndingId == 0)
			{
				return;
			}
			int selectedEndingId = this.SelectedEndingId;
			Action<int> confirmCallback = this.ConfirmCallback;
			this.ConfirmCallback = null;
			this.CancelCallback = null;
			this.CloseSelf();
			if (confirmCallback == null)
			{
				return;
			}
			confirmCallback(selectedEndingId);
		}

		// Token: 0x06038CA9 RID: 232617 RVA: 0x00FE5A36 File Offset: 0x00FE3C36
		private void CancelAndClose()
		{
			Action cancelCallback = this.CancelCallback;
			this.ConfirmCallback = null;
			this.CancelCallback = null;
			this.CloseSelf();
			if (cancelCallback == null)
			{
				return;
			}
			cancelCallback();
		}

		// Token: 0x0401DE45 RID: 122437
		private const float SMALL_CARD_SPACING = 492f;

		// Token: 0x0401DE46 RID: 122438
		private const float SELECTED_CARD_SPACING = 800f;

		// Token: 0x0401DE47 RID: 122439
		private const string MOVE_CURVE_RESOURCE_ID = "SolarSchoolCurve_Card";

		// Token: 0x0401DE48 RID: 122440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private NoCircleAttachView<SolarSchoolEnding, SolarSchoolEndingCardItem> EndingAttachView;

		// Token: 0x0401DE49 RID: 122441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolEndingPageItem, int> PageLayout;

		// Token: 0x0401DE4A RID: 122442
		private List<SolarSchoolEnding> EndingRows = new List<SolarSchoolEnding>();

		// Token: 0x0401DE4B RID: 122443
		[Nullable(2)]
		private UCurveFloat MoveCurve;

		// Token: 0x0401DE4C RID: 122444
		[Nullable(2)]
		private Action<int> ConfirmCallback;

		// Token: 0x0401DE4D RID: 122445
		[Nullable(2)]
		private Action CancelCallback;

		// Token: 0x0401DE4E RID: 122446
		private int SelectedEndingId;

		// Token: 0x0401DE4F RID: 122447
		private int SelectedEndingIndex;

		// Token: 0x0401DE50 RID: 122448
		private int ActivityId;

		// Token: 0x0200B5D0 RID: 46544
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040383A7 RID: 230311
			public const int PnlItem = 0;

			// Token: 0x040383A8 RID: 230312
			public const int CardItem = 1;

			// Token: 0x040383A9 RID: 230313
			public const int BtnConfirm = 2;

			// Token: 0x040383AA RID: 230314
			public const int PnlPage = 3;

			// Token: 0x040383AB RID: 230315
			public const int PageItem = 4;

			// Token: 0x040383AC RID: 230316
			public const int TexNum1 = 5;

			// Token: 0x040383AD RID: 230317
			public const int TexNum2 = 6;

			// Token: 0x040383AE RID: 230318
			public const int PnlTips = 7;
		}
	}
}
