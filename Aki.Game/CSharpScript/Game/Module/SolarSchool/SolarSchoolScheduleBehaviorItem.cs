using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200599F RID: 22943
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolScheduleBehaviorItem : GridProxyAbstract<SolarSchoolScheduleBehaviorData>
	{
		// Token: 0x17006C2C RID: 27692
		// (get) Token: 0x06038912 RID: 231698 RVA: 0x00FD38D8 File Offset: 0x00FD1AD8
		// (set) Token: 0x06038913 RID: 231699 RVA: 0x00FD38E0 File Offset: 0x00FD1AE0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolScheduleBehaviorData> SelectCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17006C2D RID: 27693
		// (get) Token: 0x06038914 RID: 231700 RVA: 0x00FD38E9 File Offset: 0x00FD1AE9
		// (set) Token: 0x06038915 RID: 231701 RVA: 0x00FD38F1 File Offset: 0x00FD1AF1
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolScheduleBehaviorData> AddCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06038916 RID: 231702 RVA: 0x00FD38FC File Offset: 0x00FD1AFC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggleTextureTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickAdd));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038917 RID: 231703 RVA: 0x00FD3B13 File Offset: 0x00FD1D13
		protected override void OnStart()
		{
			this.CreateStarLayout();
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.SetCanClickWhenDisable(true);
		}

		// Token: 0x06038918 RID: 231704 RVA: 0x00FD3B30 File Offset: 0x00FD1D30
		public override void Refresh(SolarSchoolScheduleBehaviorData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(data.Name, true);
			}
			this.RefreshLevel(data);
			if (!string.IsNullOrEmpty(data.IconPath))
			{
				base.SetTextureByPath(data.IconPath, base.GetTexture(2), null, null);
			}
			this.RefreshStars(data.StarLevel);
			this.RefreshBg(data).Forget();
			this.SetAddEnabled(data.IsAddEnabled);
			this.SetSelectedState(isSelected);
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			SolarSchoolBehavior? solarSchoolBehavior;
			item.SetUIActive(SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(data.BehaviorId) != null && solarSchoolBehavior.GetValueOrDefault().IsRecommend);
		}

		// Token: 0x06038919 RID: 231705 RVA: 0x00FD3BFC File Offset: 0x00FD1DFC
		public void SetAddEnabled(bool enabled)
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(enabled);
		}

		// Token: 0x0603891A RID: 231706 RVA: 0x00FD3C10 File Offset: 0x00FD1E10
		public override void Clear()
		{
			this.Data = null;
		}

		// Token: 0x0603891B RID: 231707 RVA: 0x00FD3C19 File Offset: 0x00FD1E19
		[NullableContext(2)]
		public UUIItem GetGuideBehaviorItem()
		{
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return null;
			}
			return button.GetRootComponent();
		}

		// Token: 0x0603891C RID: 231708 RVA: 0x00FD3C2D File Offset: 0x00FD1E2D
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x0603891D RID: 231709 RVA: 0x00FD3C36 File Offset: 0x00FD1E36
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}

		// Token: 0x0603891E RID: 231710 RVA: 0x00FD3C40 File Offset: 0x00FD1E40
		private UniTask RefreshBg(SolarSchoolScheduleBehaviorData data)
		{
			SolarSchoolScheduleBehaviorItem.<RefreshBg>d__19 <RefreshBg>d__;
			<RefreshBg>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBg>d__.<>4__this = this;
			<RefreshBg>d__.data = data;
			<RefreshBg>d__.<>1__state = -1;
			<RefreshBg>d__.<>t__builder.Start<SolarSchoolScheduleBehaviorItem.<RefreshBg>d__19>(ref <RefreshBg>d__);
			return <RefreshBg>d__.<>t__builder.Task;
		}

		// Token: 0x0603891F RID: 231711 RVA: 0x00FD3C8C File Offset: 0x00FD1E8C
		private void CreateStarLayout()
		{
			UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(4);
			UUISprite sprite = base.GetSprite(5);
			AUIBaseActor auibaseActor = ((sprite != null) ? sprite.GetOwner() : null) as AUIBaseActor;
			if (horizontalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.StarLayout = new GenericLayout<SolarSchoolStarItem, bool>(horizontalLayout, () => new SolarSchoolStarItem(), auibaseActor, false, true);
		}

		// Token: 0x06038920 RID: 231712 RVA: 0x00FD3CF0 File Offset: 0x00FD1EF0
		private void RefreshStars(int starLevel)
		{
			bool flag = starLevel > 0;
			GenericLayout<SolarSchoolStarItem, bool> starLayout = this.StarLayout;
			if (starLayout != null)
			{
				starLayout.SetActive(flag);
			}
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			if (!flag)
			{
				return;
			}
			bool[] array = new bool[starLevel];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = true;
			}
			GenericLayout<SolarSchoolStarItem, bool> starLayout2 = this.StarLayout;
			if (starLayout2 == null)
			{
				return;
			}
			starLayout2.RefreshByData(array, null, false);
		}

		// Token: 0x06038921 RID: 231713 RVA: 0x00FD3D5C File Offset: 0x00FD1F5C
		private void RefreshLevel(SolarSchoolScheduleBehaviorData data)
		{
			bool flag = data.BehaviorType != ESolarSchoolBehaviorType.Special && data.Level > 0;
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "SolarSchool_Schedule_BehaviorLv", new <>z__ReadOnlySingleElementList<object>(data.Level));
		}

		// Token: 0x06038922 RID: 231714 RVA: 0x00FD3DBE File Offset: 0x00FD1FBE
		private void SetSelectedState(bool selected)
		{
			UUISprite sprite = base.GetSprite(7);
			if (sprite != null)
			{
				sprite.SetUIActive(selected);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038923 RID: 231715 RVA: 0x00FD3DF0 File Offset: 0x00FD1FF0
		private void OnClickToggle(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.Data == null)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<SolarSchoolScheduleBehaviorData>, SolarSchoolScheduleBehaviorData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<SolarSchoolScheduleBehaviorData> selectCallback = this.SelectCallback;
			if (selectCallback == null)
			{
				return;
			}
			selectCallback(this.Data);
		}

		// Token: 0x06038924 RID: 231716 RVA: 0x00FD3E40 File Offset: 0x00FD2040
		private void OnClickAdd()
		{
			if (this.Data == null)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<SolarSchoolScheduleBehaviorData>, SolarSchoolScheduleBehaviorData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<SolarSchoolScheduleBehaviorData> selectCallback = this.SelectCallback;
			if (selectCallback != null)
			{
				selectCallback(this.Data);
			}
			Action<SolarSchoolScheduleBehaviorData> addCallback = this.AddCallback;
			if (addCallback == null)
			{
				return;
			}
			addCallback(this.Data);
		}

		// Token: 0x0401DCB1 RID: 122033
		[Nullable(2)]
		private SolarSchoolScheduleBehaviorData Data;

		// Token: 0x0401DCB2 RID: 122034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolStarItem, bool> StarLayout;

		// Token: 0x0200B548 RID: 46408
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040380C3 RID: 229571
			public const int Root = 0;

			// Token: 0x040380C4 RID: 229572
			public const int TxtBg = 1;

			// Token: 0x040380C5 RID: 229573
			public const int TexIcon = 2;

			// Token: 0x040380C6 RID: 229574
			public const int TxtContent = 3;

			// Token: 0x040380C7 RID: 229575
			public const int PnlStarList = 4;

			// Token: 0x040380C8 RID: 229576
			public const int SprStar01 = 5;

			// Token: 0x040380C9 RID: 229577
			public const int BtnAdd = 6;

			// Token: 0x040380CA RID: 229578
			public const int SprFrameCur = 7;

			// Token: 0x040380CB RID: 229579
			public const int ItemNormalDes = 8;

			// Token: 0x040380CC RID: 229580
			public const int RecommendItem = 9;

			// Token: 0x040380CD RID: 229581
			public const int PnlLevel = 10;

			// Token: 0x040380CE RID: 229582
			public const int TxtLevel = 11;
		}
	}
}
