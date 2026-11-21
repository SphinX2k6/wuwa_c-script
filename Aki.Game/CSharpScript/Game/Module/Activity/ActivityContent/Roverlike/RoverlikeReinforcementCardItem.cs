using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005099 RID: 20633
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeReinforcementCardItem : RoverlikeMultiUseGridProxyAbstract<IRoverlikeReinforcementItemData>
	{
		// Token: 0x06033A72 RID: 211570 RVA: 0x00E7541D File Offset: 0x00E7361D
		public void BindOnItemSelect(Action<IRoverlikeReinforcementItemData> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x06033A73 RID: 211571 RVA: 0x00E75426 File Offset: 0x00E73626
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

		// Token: 0x06033A74 RID: 211572 RVA: 0x00E7543C File Offset: 0x00E7363C
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

		// Token: 0x06033A75 RID: 211573 RVA: 0x00E755CC File Offset: 0x00E737CC
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

		// Token: 0x06033A76 RID: 211574 RVA: 0x00E7564D File Offset: 0x00E7384D
		protected override void OnBeforeCreate()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(6);
			if (scrollViewWithScrollbar == null)
			{
				return;
			}
			scrollViewWithScrollbar.OnScrollValueChange.Unbind();
		}

		// Token: 0x06033A77 RID: 211575 RVA: 0x00E75668 File Offset: 0x00E73868
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

		// Token: 0x06033A78 RID: 211576 RVA: 0x00E757C4 File Offset: 0x00E739C4
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06033A79 RID: 211577 RVA: 0x00E757D7 File Offset: 0x00E739D7
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033A7A RID: 211578 RVA: 0x00E757EA File Offset: 0x00E739EA
		private void OnScrollLateUpdate(float _)
		{
			if (!this.HasScrollFirstLateUpdate)
			{
				this.RefreshScrollArrow();
				this.HasScrollFirstLateUpdate = true;
			}
		}

		// Token: 0x06033A7B RID: 211579 RVA: 0x00E75804 File Offset: 0x00E73A04
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

		// Token: 0x06033A7C RID: 211580 RVA: 0x00E7587B File Offset: 0x00E73A7B
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

		// Token: 0x0401B654 RID: 112212
		[Nullable(2)]
		private IRoverlikeReinforcementItemData CurrentData;

		// Token: 0x0401B655 RID: 112213
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikeReinforcementItemData> OnItemSelect;

		// Token: 0x0401B656 RID: 112214
		private bool HasScrollFirstLateUpdate;

		// Token: 0x0200AD5E RID: 44382
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403592F RID: 219439
			public const int TogItem = 0;

			// Token: 0x04035930 RID: 219440
			public const int TxtName = 1;

			// Token: 0x04035931 RID: 219441
			public const int TxtInfo = 2;

			// Token: 0x04035932 RID: 219442
			public const int SpriteIcon = 3;

			// Token: 0x04035933 RID: 219443
			public const int TxtTips = 4;

			// Token: 0x04035934 RID: 219444
			public const int PnlRecommend = 5;

			// Token: 0x04035935 RID: 219445
			public const int SvInfo = 6;

			// Token: 0x04035936 RID: 219446
			public const int SprArrowUp = 7;

			// Token: 0x04035937 RID: 219447
			public const int SprArrowDown = 8;
		}
	}
}
