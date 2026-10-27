using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200611B RID: 24859
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeReinforcementCardItem : RoverlikeMultiUseGridProxyAbstract<IRoverlikeReinforcementItemData>
	{
		// Token: 0x0603EDB0 RID: 257456 RVA: 0x00F2E609 File Offset: 0x00F2C809
		public void BindOnItemSelect(Action<IRoverlikeReinforcementItemData> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x0603EDB1 RID: 257457 RVA: 0x00F2E612 File Offset: 0x00F2C812
		[NullableContext(2)]
		public UUIItem GetGuideUiItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.GetRootComponent();
		}

		// Token: 0x0603EDB2 RID: 257458 RVA: 0x00F2E628 File Offset: 0x00F2C828
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogItemStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603EDB3 RID: 257459 RVA: 0x00F2E7B8 File Offset: 0x00F2C9B8
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(6);
			if (scrollViewWithScrollbar != null)
			{
				scrollViewWithScrollbar.OnScrollValueChange.Bind(delegate(FVector2D _)
				{
					this.RefreshScrollArrow();
				});
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar2 = base.GetScrollViewWithScrollbar(6);
			if (scrollViewWithScrollbar2 != null)
			{
				scrollViewWithScrollbar2.OnLateUpdate.Bind(new Action<float>(this.OnScrollLateUpdate));
			}
			ITermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = base.GetText(2),
				ViewType = ETermExplanationViewType.Center,
				ReportType = ETermExplanationReportType.Roverlike
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		}

		// Token: 0x0603EDB4 RID: 257460 RVA: 0x00F2E839 File Offset: 0x00F2CA39
		protected override void OnBeforeCreate()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(6);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.OnScrollValueChange.Unbind();
		}

		// Token: 0x0603EDB5 RID: 257461 RVA: 0x00F2E854 File Offset: 0x00F2CA54
		public override void Refresh(IRoverlikeReinforcementItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			this.HasScrollFirstLateUpdate = false;
			RoverRogueRoleEnhance? roleEnhanceConfig = RoverlikeConfig.Instance.GetRoleEnhanceConfig(data.ConfigId);
			if (roleEnhanceConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), roleEnhanceConfig.Value.Name, Array.Empty<object>());
			this.SetSpriteByPath(roleEnhanceConfig.Value.Icon, base.GetSprite(3), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), roleEnhanceConfig.Value.Desc, roleEnhanceConfig.Value.DescParams());
			bool flag = !StringUtils.IsEmpty(roleEnhanceConfig.Value.AdditionText);
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), roleEnhanceConfig.Value.AdditionText, roleEnhanceConfig.Value.AdditionParams());
			}
			base.GetText(4).SetUIActive(flag);
			base.GetItem(5).SetUIActive(roleEnhanceConfig.Value.IsRecommend);
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			base.GetExtendToggle(0).SetSelfInteractive(data.AllowToggleInteract.GetValueOrDefault(true));
			this.RefreshScrollArrow();
		}

		// Token: 0x0603EDB6 RID: 257462 RVA: 0x00F2E9B0 File Offset: 0x00F2CBB0
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603EDB7 RID: 257463 RVA: 0x00F2E9C3 File Offset: 0x00F2CBC3
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603EDB8 RID: 257464 RVA: 0x00F2E9D6 File Offset: 0x00F2CBD6
		private void OnScrollLateUpdate(float _)
		{
			if (!this.HasScrollFirstLateUpdate)
			{
				this.RefreshScrollArrow();
				this.HasScrollFirstLateUpdate = true;
			}
		}

		// Token: 0x0603EDB9 RID: 257465 RVA: 0x00F2E9F0 File Offset: 0x00F2CBF0
		private void RefreshScrollArrow()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(6);
			UUIText text = base.GetText(2);
			if (scrollViewWithScrollbar == null || text == null)
			{
				base.GetItem(7).SetUIActive(false);
				base.GetItem(8).SetUIActive(false);
				return;
			}
			EOutOfBoundsType eoutOfBoundsType = EOutOfBoundsType.EOutOfBoundsType_MAX;
			EOutOfBoundsType eoutOfBoundsType2 = EOutOfBoundsType.EOutOfBoundsType_MAX;
			scrollViewWithScrollbar.GetOutOfBottomBoundsType(text, ref eoutOfBoundsType, ref eoutOfBoundsType2, 0f);
			EOutOfBoundsType eoutOfBoundsType3 = eoutOfBoundsType;
			base.GetItem(7).SetUIActive(eoutOfBoundsType3 == EOutOfBoundsType.OutOfBegin);
			base.GetItem(8).SetUIActive(eoutOfBoundsType3 == EOutOfBoundsType.OutOfEnd);
		}

		// Token: 0x0603EDBA RID: 257466 RVA: 0x00F2EA67 File Offset: 0x00F2CC67
		private void OnTogItemStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.CurrentData != null)
			{
				Action<IRoverlikeReinforcementItemData> onItemSelect = this.OnItemSelect;
				if (onItemSelect == null)
				{
					return;
				}
				onItemSelect(this.CurrentData);
			}
		}

		// Token: 0x04020D27 RID: 134439
		[Nullable(2)]
		private IRoverlikeReinforcementItemData CurrentData;

		// Token: 0x04020D28 RID: 134440
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeReinforcementItemData> OnItemSelect;

		// Token: 0x04020D29 RID: 134441
		private bool HasScrollFirstLateUpdate;

		// Token: 0x0200C376 RID: 50038
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AFCA RID: 241610
			public const int TogItem = 0;

			// Token: 0x0403AFCB RID: 241611
			public const int TxtName = 1;

			// Token: 0x0403AFCC RID: 241612
			public const int TxtInfo = 2;

			// Token: 0x0403AFCD RID: 241613
			public const int SpriteIcon = 3;

			// Token: 0x0403AFCE RID: 241614
			public const int TxtTips = 4;

			// Token: 0x0403AFCF RID: 241615
			public const int PnlRecommend = 5;

			// Token: 0x0403AFD0 RID: 241616
			public const int SvInfo = 6;

			// Token: 0x0403AFD1 RID: 241617
			public const int SprArrowUp = 7;

			// Token: 0x0403AFD2 RID: 241618
			public const int SprArrowDown = 8;
		}
	}
}
