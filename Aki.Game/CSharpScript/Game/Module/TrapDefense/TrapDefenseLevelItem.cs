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
	// Token: 0x02003A55 RID: 14933
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseLevelItem : GridProxyAbstract<TrapDefenseLevelData>
	{
		// Token: 0x0602661A RID: 157210 RVA: 0x00AC0688 File Offset: 0x00ABE888
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

		// Token: 0x0602661B RID: 157211 RVA: 0x00AC0838 File Offset: 0x00ABEA38
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602661C RID: 157212 RVA: 0x00AC087B File Offset: 0x00ABEA7B
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x0602661D RID: 157213 RVA: 0x00AC0880 File Offset: 0x00ABEA80
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

		// Token: 0x0602661E RID: 157214 RVA: 0x00AC08CC File Offset: 0x00ABEACC
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

		// Token: 0x0602661F RID: 157215 RVA: 0x00AC0933 File Offset: 0x00ABEB33
		public TrapDefenseLevelStarItem CreateItemStar()
		{
			return new TrapDefenseLevelStarItem();
		}

		// Token: 0x06026620 RID: 157216 RVA: 0x00AC093A File Offset: 0x00ABEB3A
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

		// Token: 0x06026621 RID: 157217 RVA: 0x00AC0963 File Offset: 0x00ABEB63
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06026622 RID: 157218 RVA: 0x00AC097C File Offset: 0x00ABEB7C
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

		// Token: 0x040150EA RID: 86250
		public TrapDefenseLevelData ItemData;

		// Token: 0x040150EB RID: 86251
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<TrapDefenseLevelItem> OnSelectLevelCallBack;

		// Token: 0x040150EC RID: 86252
		public GenericLayout<TrapDefenseLevelStarItem, bool> LayoutStar;

		// Token: 0x02009623 RID: 38435
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE03 RID: 192003
			public const int ToggleSelf = 0;

			// Token: 0x0402EE04 RID: 192004
			public const int TextureBg = 1;

			// Token: 0x0402EE05 RID: 192005
			public const int ArtTextPosition = 2;

			// Token: 0x0402EE06 RID: 192006
			public const int TextName = 3;

			// Token: 0x0402EE07 RID: 192007
			public const int LayoutStar = 4;

			// Token: 0x0402EE08 RID: 192008
			public const int ItemStar = 5;

			// Token: 0x0402EE09 RID: 192009
			public const int ItemEndlessTag = 6;

			// Token: 0x0402EE0A RID: 192010
			public const int ItemFinish = 7;

			// Token: 0x0402EE0B RID: 192011
			public const int ItemLock = 8;

			// Token: 0x0402EE0C RID: 192012
			public const int ItemRedDot = 9;
		}
	}
}
