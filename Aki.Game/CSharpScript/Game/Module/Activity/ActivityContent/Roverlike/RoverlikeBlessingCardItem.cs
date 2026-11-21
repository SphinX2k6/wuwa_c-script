using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005095 RID: 20629
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeBlessingCardItem : RoverlikeMultiUseGridProxyAbstract<IRoverlikeBlessingItemData>
	{
		// Token: 0x06033A45 RID: 211525 RVA: 0x00E74615 File Offset: 0x00E72815
		[NullableContext(1)]
		public void BindOnItemSelect(Action<IRoverlikeBlessingItemData> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x06033A46 RID: 211526 RVA: 0x00E7461E File Offset: 0x00E7281E
		public UUIItem GetGuideUiItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.GetRootComponent();
		}

		// Token: 0x06033A47 RID: 211527 RVA: 0x00E74634 File Offset: 0x00E72834
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

		// Token: 0x06033A48 RID: 211528 RVA: 0x00E7495C File Offset: 0x00E72B5C
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

		// Token: 0x06033A49 RID: 211529 RVA: 0x00E74A26 File Offset: 0x00E72C26
		protected override void OnBeforeDestroy()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(18);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.OnScrollValueChange.Unbind();
		}

		// Token: 0x06033A4A RID: 211530 RVA: 0x00E74A40 File Offset: 0x00E72C40
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

		// Token: 0x06033A4B RID: 211531 RVA: 0x00E74C14 File Offset: 0x00E72E14
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

		// Token: 0x06033A4C RID: 211532 RVA: 0x00E74C79 File Offset: 0x00E72E79
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x06033A4D RID: 211533 RVA: 0x00E74C8C File Offset: 0x00E72E8C
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(6).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x06033A4E RID: 211534 RVA: 0x00E74CA0 File Offset: 0x00E72EA0
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

		// Token: 0x06033A4F RID: 211535 RVA: 0x00E74D5C File Offset: 0x00E72F5C
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

		// Token: 0x06033A50 RID: 211536 RVA: 0x00E74DE5 File Offset: 0x00E72FE5
		private void OnScrollLateUpdate(float _)
		{
			if (!this.HasScrollFirstLateUpdate)
			{
				this.RefreshScrollArrow();
				this.HasScrollFirstLateUpdate = true;
			}
		}

		// Token: 0x06033A51 RID: 211537 RVA: 0x00E74DFC File Offset: 0x00E72FFC
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

		// Token: 0x06033A52 RID: 211538 RVA: 0x00E74E78 File Offset: 0x00E73078
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

		// Token: 0x0401B64A RID: 112202
		private IRoverlikeBlessingItemData CurrentData;

		// Token: 0x0401B64B RID: 112203
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeBlessingItemData> OnItemSelect;

		// Token: 0x0401B64C RID: 112204
		private RoverlikeBlessingRepresentativeItem RepresentativeItem;

		// Token: 0x0401B64D RID: 112205
		private RoverlikeBlessingRepresentativeItem RepresentativeChangeItem;

		// Token: 0x0401B64E RID: 112206
		private bool HasScrollFirstLateUpdate;

		// Token: 0x0200AD5B RID: 44379
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403590F RID: 219407
			public const int TexCardBg = 0;

			// Token: 0x04035910 RID: 219408
			public const int TxtInfo = 1;

			// Token: 0x04035911 RID: 219409
			public const int TexQualityBg = 2;

			// Token: 0x04035912 RID: 219410
			public const int SpriteIcon = 3;

			// Token: 0x04035913 RID: 219411
			public const int TxtName = 4;

			// Token: 0x04035914 RID: 219412
			public const int TxtTips = 5;

			// Token: 0x04035915 RID: 219413
			public const int TogItem = 6;

			// Token: 0x04035916 RID: 219414
			public const int ItemRepresentative = 7;

			// Token: 0x04035917 RID: 219415
			public const int PanelExchange = 8;

			// Token: 0x04035918 RID: 219416
			public const int ItemRepresentativeChange = 9;

			// Token: 0x04035919 RID: 219417
			public const int ItemUp = 10;

			// Token: 0x0403591A RID: 219418
			public const int PanelQualityBlue = 11;

			// Token: 0x0403591B RID: 219419
			public const int PanelQualityPurple = 12;

			// Token: 0x0403591C RID: 219420
			public const int PanelQualityGold = 13;

			// Token: 0x0403591D RID: 219421
			public const int PanelQualityRed = 14;

			// Token: 0x0403591E RID: 219422
			public const int ItemHighQualityEffect = 15;

			// Token: 0x0403591F RID: 219423
			public const int PanelAttribute = 16;

			// Token: 0x04035920 RID: 219424
			public const int PanelRecommend = 17;

			// Token: 0x04035921 RID: 219425
			public const int SvInfo = 18;

			// Token: 0x04035922 RID: 219426
			public const int ItemArrowUp = 19;

			// Token: 0x04035923 RID: 219427
			public const int ItemArrowDown = 20;
		}
	}
}
