using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006117 RID: 24855
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeBlessingCardItem : RoverlikeMultiUseGridProxyAbstract<IRoverlikeBlessingItemData>
	{
		// Token: 0x0603ED83 RID: 257411 RVA: 0x00F2D801 File Offset: 0x00F2BA01
		[NullableContext(1)]
		public void BindOnItemSelect(Action<IRoverlikeBlessingItemData> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x0603ED84 RID: 257412 RVA: 0x00F2D80A File Offset: 0x00F2BA0A
		public UUIItem GetGuideUiItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.GetRootComponent();
		}

		// Token: 0x0603ED85 RID: 257413 RVA: 0x00F2D820 File Offset: 0x00F2BA20
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnTogItemStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ED86 RID: 257414 RVA: 0x00F2DB48 File Offset: 0x00F2BD48
		protected override void OnStart()
		{
			this.RepresentativeItem = new RoverlikeBlessingRepresentativeItem();
			this.RepresentativeItem.CreateThenShowByActor(base.GetItem(7).GetOwner(), null);
			this.RepresentativeChangeItem = new RoverlikeBlessingRepresentativeItem();
			this.RepresentativeChangeItem.CreateThenShowByActor(base.GetItem(9).GetOwner(), null);
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(18);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.OnScrollValueChange.Bind(delegate(FVector2D _)
				{
					this.RefreshScrollArrow();
				});
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(18);
			if (scrollViewWithScrollbar2 != null)
			{
				scrollViewWithScrollbar2.OnLateUpdate.Bind(new Action<float>(this.OnScrollLateUpdate));
			}
			ITermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = base.GetText(1),
				ViewType = ETermExplanationViewType.Center,
				ReportType = ETermExplanationReportType.Roverlike
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		}

		// Token: 0x0603ED87 RID: 257415 RVA: 0x00F2DC12 File Offset: 0x00F2BE12
		protected override void OnBeforeDestroy()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(18);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.OnScrollValueChange.Unbind();
		}

		// Token: 0x0603ED88 RID: 257416 RVA: 0x00F2DC2C File Offset: 0x00F2BE2C
		[NullableContext(1)]
		public override void Refresh(IRoverlikeBlessingItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			this.HasScrollFirstLateUpdate = false;
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(data.BlessId);
			if (blessConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), blessConfig.Value.Name, Array.Empty<object>());
			this.SetSpriteByPath(blessConfig.Value.Icon, base.GetSprite(3), false, null, null);
			this.RefreshDescMode();
			bool flag = !StringUtils.IsEmpty(blessConfig.Value.AdditionText);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), blessConfig.Value.AdditionText, blessConfig.Value.AdditionParams());
			}
			base.GetItem(16).SetUIActive(flag);
			this.RefreshQuality(blessConfig.Value.Quality);
			bool uiactive = data.ShowRecommend.GetValueOrDefault(true) && blessConfig.Value.IsRecommend;
			base.GetItem(17).SetUIActive(uiactive);
			base.GetItem(10).SetUIActive(data.IsUp.GetValueOrDefault());
			RoverlikeBlessingRepresentativeItem representativeItem = this.RepresentativeItem;
			if (representativeItem != null)
			{
				representativeItem.Refresh(blessConfig.Value.BlessRoleId);
			}
			this.RefreshChangeSlot(data);
			base.GetExtendToggle(6).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			bool valueOrDefault = data.AllowToggleInteract.GetValueOrDefault(true);
			base.GetExtendToggle(6).SetSelfInteractive(valueOrDefault);
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(18);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.RootUIComp.Get().SetBubbleUpToParent(valueOrDefault);
			}
			this.RefreshScrollArrow();
		}

		// Token: 0x0603ED89 RID: 257417 RVA: 0x00F2DE00 File Offset: 0x00F2C000
		public void RefreshDescMode()
		{
			if (this.CurrentData == null)
			{
				return;
			}
			RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(this.CurrentData.BlessId);
			if (blessConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), blessConfig.Value.Desc, blessConfig.Value.Params());
		}

		// Token: 0x0603ED8A RID: 257418 RVA: 0x00F2DE65 File Offset: 0x00F2C065
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0603ED8B RID: 257419 RVA: 0x00F2DE78 File Offset: 0x00F2C078
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0603ED8C RID: 257420 RVA: 0x00F2DE8C File Offset: 0x00F2C08C
		private void RefreshQuality(int quality)
		{
			RoverRogueQuality? qualityConfig = RoverlikeConfig.Instance.GetQualityConfig(quality);
			if (qualityConfig != null)
			{
				base.GetTexture(0).SetColor(FColor.FromHex(qualityConfig.Value.BlessCardTop));
				base.GetTexture(2).SetColor(FColor.FromHex(qualityConfig.Value.BlessCardTheme));
			}
			base.GetItem(11).SetUIActive(quality <= 3);
			base.GetItem(12).SetUIActive(quality == 4);
			base.GetItem(13).SetUIActive(quality == 5);
			base.GetItem(14).SetUIActive(quality == 6);
			base.GetItem(15).SetUIActive(quality == 6);
		}

		// Token: 0x0603ED8D RID: 257421 RVA: 0x00F2DF48 File Offset: 0x00F2C148
		[NullableContext(1)]
		private void RefreshChangeSlot(IRoverlikeBlessingItemData data)
		{
			bool uiactive = false;
			if (data.CheckSameSlot.GetValueOrDefault())
			{
				RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
				RoverlikeGainEntry roverlikeGainEntry = (instanceData != null) ? instanceData.GetSameSlotIdBless(data.BlessId) : null;
				if (roverlikeGainEntry != null)
				{
					RoverRogueBless? blessConfig = RoverlikeConfig.Instance.GetBlessConfig(roverlikeGainEntry.ConfigId);
					if (blessConfig != null)
					{
						RoverlikeBlessingRepresentativeItem representativeChangeItem = this.RepresentativeChangeItem;
						if (representativeChangeItem != null)
						{
							representativeChangeItem.Refresh(blessConfig.Value.BlessRoleId);
						}
						uiactive = true;
					}
				}
			}
			base.GetItem(8).SetUIActive(uiactive);
		}

		// Token: 0x0603ED8E RID: 257422 RVA: 0x00F2DFD1 File Offset: 0x00F2C1D1
		private void OnScrollLateUpdate(float _)
		{
			if (!this.HasScrollFirstLateUpdate)
			{
				this.RefreshScrollArrow();
				this.HasScrollFirstLateUpdate = true;
			}
		}

		// Token: 0x0603ED8F RID: 257423 RVA: 0x00F2DFE8 File Offset: 0x00F2C1E8
		private void RefreshScrollArrow()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(18);
			UUIText text = base.GetText(1);
			if (scrollViewWithScrollbar == null || text == null)
			{
				base.GetItem(19).SetUIActive(false);
				base.GetItem(20).SetUIActive(false);
				return;
			}
			EOutOfBoundsType eoutOfBoundsType = EOutOfBoundsType.EOutOfBoundsType_MAX;
			EOutOfBoundsType eoutOfBoundsType2 = EOutOfBoundsType.EOutOfBoundsType_MAX;
			scrollViewWithScrollbar.GetOutOfBottomBoundsType(text, ref eoutOfBoundsType, ref eoutOfBoundsType2, 0f);
			EOutOfBoundsType eoutOfBoundsType3 = eoutOfBoundsType;
			base.GetItem(19).SetUIActive(eoutOfBoundsType3 == EOutOfBoundsType.OutOfBegin);
			base.GetItem(20).SetUIActive(eoutOfBoundsType3 == EOutOfBoundsType.OutOfEnd);
		}

		// Token: 0x0603ED90 RID: 257424 RVA: 0x00F2E064 File Offset: 0x00F2C264
		private void OnTogItemStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.CurrentData != null)
			{
				Action<IRoverlikeBlessingItemData> onItemSelect = this.OnItemSelect;
				if (onItemSelect == null)
				{
					return;
				}
				onItemSelect(this.CurrentData);
			}
		}

		// Token: 0x04020D1D RID: 134429
		private IRoverlikeBlessingItemData CurrentData;

		// Token: 0x04020D1E RID: 134430
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeBlessingItemData> OnItemSelect;

		// Token: 0x04020D1F RID: 134431
		private RoverlikeBlessingRepresentativeItem RepresentativeItem;

		// Token: 0x04020D20 RID: 134432
		private RoverlikeBlessingRepresentativeItem RepresentativeChangeItem;

		// Token: 0x04020D21 RID: 134433
		private bool HasScrollFirstLateUpdate;

		// Token: 0x0200C373 RID: 50035
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AFAA RID: 241578
			public const int TexCardBg = 0;

			// Token: 0x0403AFAB RID: 241579
			public const int TxtInfo = 1;

			// Token: 0x0403AFAC RID: 241580
			public const int TexQualityBg = 2;

			// Token: 0x0403AFAD RID: 241581
			public const int SpriteIcon = 3;

			// Token: 0x0403AFAE RID: 241582
			public const int TxtName = 4;

			// Token: 0x0403AFAF RID: 241583
			public const int TxtTips = 5;

			// Token: 0x0403AFB0 RID: 241584
			public const int TogItem = 6;

			// Token: 0x0403AFB1 RID: 241585
			public const int ItemRepresentative = 7;

			// Token: 0x0403AFB2 RID: 241586
			public const int PanelExchange = 8;

			// Token: 0x0403AFB3 RID: 241587
			public const int ItemRepresentativeChange = 9;

			// Token: 0x0403AFB4 RID: 241588
			public const int ItemUp = 10;

			// Token: 0x0403AFB5 RID: 241589
			public const int PanelQualityBlue = 11;

			// Token: 0x0403AFB6 RID: 241590
			public const int PanelQualityPurple = 12;

			// Token: 0x0403AFB7 RID: 241591
			public const int PanelQualityGold = 13;

			// Token: 0x0403AFB8 RID: 241592
			public const int PanelQualityRed = 14;

			// Token: 0x0403AFB9 RID: 241593
			public const int ItemHighQualityEffect = 15;

			// Token: 0x0403AFBA RID: 241594
			public const int PanelAttribute = 16;

			// Token: 0x0403AFBB RID: 241595
			public const int PanelRecommend = 17;

			// Token: 0x0403AFBC RID: 241596
			public const int SvInfo = 18;

			// Token: 0x0403AFBD RID: 241597
			public const int ItemArrowUp = 19;

			// Token: 0x0403AFBE RID: 241598
			public const int ItemArrowDown = 20;
		}
	}
}
