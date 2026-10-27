using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AAD RID: 19117
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseLevelItem : GridProxyAbstract<TrapDefenseLevelData>
	{
		// Token: 0x0603188A RID: 202890 RVA: 0x00B7C6D4 File Offset: 0x00B7A8D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggleTextureTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggleSelf));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603188B RID: 202891 RVA: 0x00B7C884 File Offset: 0x00B7AA84
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603188C RID: 202892 RVA: 0x00B7C8C7 File Offset: 0x00B7AAC7
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x0603188D RID: 202893 RVA: 0x00B7C8CC File Offset: 0x00B7AACC
		public override UniTask RefreshAsync(TrapDefenseLevelData data, bool isSelected, int gridIndex)
		{
			TrapDefenseLevelItem.<RefreshAsync>d__7 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<TrapDefenseLevelItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603188E RID: 202894 RVA: 0x00B7C918 File Offset: 0x00B7AB18
		public void UpdateLevelBg()
		{
			bool isEndless = this.ItemData.IsEndless;
			UUIExtendToggleTextureTransition uiExtendToggleTextureTransition = base.GetUiExtendToggleTextureTransition(1);
			uiExtendToggleTextureTransition.RootUIComp.Get().SetUIActive(!isEndless);
			if (!isEndless)
			{
				base.SetExtendToggleTextureTransitionByPath(this.ItemData.Config.LevelNameImage, uiExtendToggleTextureTransition, EToggleTransitionState.ETT_MAX);
			}
			UUIItem item = base.GetItem(6);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isEndless);
		}

		// Token: 0x0603188F RID: 202895 RVA: 0x00B7C97F File Offset: 0x00B7AB7F
		public TrapDefenseLevelStarItem CreateItemStar()
		{
			return new TrapDefenseLevelStarItem();
		}

		// Token: 0x06031890 RID: 202896 RVA: 0x00B7C986 File Offset: 0x00B7AB86
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			Action<TrapDefenseLevelItem> onSelectLevelCallBack = this.OnSelectLevelCallBack;
			if (onSelectLevelCallBack == null)
			{
				return;
			}
			onSelectLevelCallBack(this);
		}

		// Token: 0x06031891 RID: 202897 RVA: 0x00B7C9AF File Offset: 0x00B7ABAF
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06031892 RID: 202898 RVA: 0x00B7C9C8 File Offset: 0x00B7ABC8
		public void OnClickToggleSelf(EToggleState state)
		{
			ScrollViewDelegate<TrapDefenseLevelItem, TrapDefenseLevelData> scrollViewDelegate = base.ScrollViewDelegate as ScrollViewDelegate<TrapDefenseLevelItem, TrapDefenseLevelData>;
			int? num = (scrollViewDelegate != null) ? new int?(scrollViewDelegate.GetSelectedGridIndex()) : null;
			int gridIndex = base.GridIndex;
			if (num.GetValueOrDefault() == gridIndex & num != null)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			else
			{
				GuideModel.Instance.FinishFocusGuideGroupOnView(EUiViewName.TrapDefenseMainLevelView);
				IScrollViewDelegate<IGridProxy<TrapDefenseLevelData>, TrapDefenseLevelData> scrollViewDelegate2 = base.ScrollViewDelegate;
				if (scrollViewDelegate2 == null)
				{
					return;
				}
				scrollViewDelegate2.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
				return;
			}
		}

		// Token: 0x0401A798 RID: 108440
		public TrapDefenseLevelData ItemData;

		// Token: 0x0401A799 RID: 108441
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<TrapDefenseLevelItem> OnSelectLevelCallBack;

		// Token: 0x0401A79A RID: 108442
		public GenericLayout<TrapDefenseLevelStarItem, bool> LayoutStar;

		// Token: 0x0200AC03 RID: 44035
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034452 RID: 214098
			public const int ToggleSelf = 0;

			// Token: 0x04034453 RID: 214099
			public const int TextureBg = 1;

			// Token: 0x04034454 RID: 214100
			public const int ArtTextPosition = 2;

			// Token: 0x04034455 RID: 214101
			public const int TextName = 3;

			// Token: 0x04034456 RID: 214102
			public const int LayoutStar = 4;

			// Token: 0x04034457 RID: 214103
			public const int ItemStar = 5;

			// Token: 0x04034458 RID: 214104
			public const int ItemEndlessTag = 6;

			// Token: 0x04034459 RID: 214105
			public const int ItemFinish = 7;

			// Token: 0x0403445A RID: 214106
			public const int ItemLock = 8;

			// Token: 0x0403445B RID: 214107
			public const int ItemRedDot = 9;
		}
	}
}
