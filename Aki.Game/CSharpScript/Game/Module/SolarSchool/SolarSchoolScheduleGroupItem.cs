using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059A4 RID: 22948
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolScheduleGroupItem : GridProxyAbstract<SolarSchoolScheduleGroupData>
	{
		// Token: 0x17006C2E RID: 27694
		// (get) Token: 0x06038941 RID: 231745 RVA: 0x00FD4AA3 File Offset: 0x00FD2CA3
		// (set) Token: 0x06038942 RID: 231746 RVA: 0x00FD4AAB File Offset: 0x00FD2CAB
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolScheduleGroupData> DeleteCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17006C2F RID: 27695
		// (get) Token: 0x06038943 RID: 231747 RVA: 0x00FD4AB4 File Offset: 0x00FD2CB4
		// (set) Token: 0x06038944 RID: 231748 RVA: 0x00FD4ABC File Offset: 0x00FD2CBC
		public Func<bool> CanPlayAnimations { get; set; }

		// Token: 0x06038945 RID: 231749 RVA: 0x00FD4AC8 File Offset: 0x00FD2CC8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickGroup));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038946 RID: 231750 RVA: 0x00FD4B90 File Offset: 0x00FD2D90
		protected override UniTask OnBeforeStartAsync()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(1);
			UUIItem item = base.GetItem(2);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (verticalLayout != null && auibaseActor != null)
			{
				this.CellLayout = new GenericLayout<SolarSchoolScheduleCellItem, SolarSchoolScheduleCellData>(verticalLayout, () => new SolarSchoolScheduleCellItem(), auibaseActor, false, true);
			}
			return UniTask.CompletedTask;
		}

		// Token: 0x06038947 RID: 231751 RVA: 0x00FD4BF8 File Offset: 0x00FD2DF8
		[NullableContext(1)]
		public override void Refresh(SolarSchoolScheduleGroupData data, bool isSelected, int gridIndex)
		{
			SolarSchoolScheduleGroupItem.<>c__DisplayClass14_0 CS$<>8__locals1 = new SolarSchoolScheduleGroupItem.<>c__DisplayClass14_0();
			CS$<>8__locals1.<>4__this = this;
			bool flag = this.HasSameCells(data);
			this.Data = data;
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive((data.BehaviorId != 0 && data.CanDelete) || data.IsEmptyClickable);
			}
			if (flag)
			{
				return;
			}
			SolarSchoolScheduleGroupItem.<>c__DisplayClass14_0 CS$<>8__locals2 = CS$<>8__locals1;
			int refreshVersion = this.RefreshVersion + 1;
			this.RefreshVersion = refreshVersion;
			CS$<>8__locals2.refreshVersion = refreshVersion;
			GenericLayout<SolarSchoolScheduleCellItem, SolarSchoolScheduleCellData> cellLayout = this.CellLayout;
			List<SolarSchoolScheduleCellItem> list = (cellLayout != null) ? cellLayout.GetLayoutItemList() : null;
			if (list != null)
			{
				for (int i = data.Cells.Count; i < list.Count; i++)
				{
					list[i].Clear();
				}
			}
			GenericLayout<SolarSchoolScheduleCellItem, SolarSchoolScheduleCellData> cellLayout2 = this.CellLayout;
			if (cellLayout2 == null)
			{
				return;
			}
			cellLayout2.RefreshByData(data.Cells, delegate
			{
				CS$<>8__locals1.<>4__this.PlayCellAnimationsAsync(CS$<>8__locals1.refreshVersion).Forget();
			}, false);
		}

		// Token: 0x06038948 RID: 231752 RVA: 0x00FD4CC8 File Offset: 0x00FD2EC8
		[NullableContext(1)]
		private bool HasSameCells(SolarSchoolScheduleGroupData data)
		{
			if (this.Data == null || this.Data.Slot != data.Slot || this.Data.FirstWeekday != data.FirstWeekday || this.Data.Cells.Count != data.Cells.Count)
			{
				return false;
			}
			for (int i = 0; i < data.Cells.Count; i++)
			{
				SolarSchoolScheduleCellData solarSchoolScheduleCellData = this.Data.Cells[i];
				SolarSchoolScheduleCellData solarSchoolScheduleCellData2 = data.Cells[i];
				if (solarSchoolScheduleCellData2.PlayRefreshAnimation || solarSchoolScheduleCellData2.PlayCancelAnimation || solarSchoolScheduleCellData.Weekday != solarSchoolScheduleCellData2.Weekday || solarSchoolScheduleCellData.BehaviorId != solarSchoolScheduleCellData2.BehaviorId || solarSchoolScheduleCellData.State != solarSchoolScheduleCellData2.State || solarSchoolScheduleCellData.IsSpecialDay != solarSchoolScheduleCellData2.IsSpecialDay || solarSchoolScheduleCellData.Text != solarSchoolScheduleCellData2.Text || solarSchoolScheduleCellData.BgPath != solarSchoolScheduleCellData2.BgPath || solarSchoolScheduleCellData.CanDelete != solarSchoolScheduleCellData2.CanDelete)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06038949 RID: 231753 RVA: 0x00FD4DDC File Offset: 0x00FD2FDC
		private UniTask PlayCellAnimationsAsync(int refreshVersion)
		{
			SolarSchoolScheduleGroupItem.<PlayCellAnimationsAsync>d__16 <PlayCellAnimationsAsync>d__;
			<PlayCellAnimationsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCellAnimationsAsync>d__.<>4__this = this;
			<PlayCellAnimationsAsync>d__.refreshVersion = refreshVersion;
			<PlayCellAnimationsAsync>d__.<>1__state = -1;
			<PlayCellAnimationsAsync>d__.<>t__builder.Start<SolarSchoolScheduleGroupItem.<PlayCellAnimationsAsync>d__16>(ref <PlayCellAnimationsAsync>d__);
			return <PlayCellAnimationsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603894A RID: 231754 RVA: 0x00FD4E28 File Offset: 0x00FD3028
		public void SetPreviewCoveredWeekdays(HashSet<int> coveredWeekdays)
		{
			if (this.Data != null)
			{
				foreach (SolarSchoolScheduleCellData solarSchoolScheduleCellData in this.Data.Cells)
				{
					solarSchoolScheduleCellData.IsPreviewCovered = (coveredWeekdays != null && coveredWeekdays.Contains(solarSchoolScheduleCellData.Weekday));
				}
			}
			GenericLayout<SolarSchoolScheduleCellItem, SolarSchoolScheduleCellData> cellLayout = this.CellLayout;
			List<SolarSchoolScheduleCellItem> list = (cellLayout != null) ? cellLayout.GetLayoutItemList() : null;
			if (list != null)
			{
				Func<bool> canPlayAnimations = this.CanPlayAnimations;
				if (canPlayAnimations == null || canPlayAnimations())
				{
					foreach (SolarSchoolScheduleCellItem solarSchoolScheduleCellItem in list)
					{
						solarSchoolScheduleCellItem.SetPreviewCovered(coveredWeekdays != null && coveredWeekdays.Contains(solarSchoolScheduleCellItem.GetWeekday()));
					}
					return;
				}
			}
		}

		// Token: 0x0603894B RID: 231755 RVA: 0x00FD4F18 File Offset: 0x00FD3118
		public void ResetAnimations()
		{
			this.RefreshVersion++;
			GenericLayout<SolarSchoolScheduleCellItem, SolarSchoolScheduleCellData> cellLayout = this.CellLayout;
			List<SolarSchoolScheduleCellItem> list = (cellLayout != null) ? cellLayout.GetLayoutItemList() : null;
			if (list == null)
			{
				return;
			}
			foreach (SolarSchoolScheduleCellItem solarSchoolScheduleCellItem in list)
			{
				solarSchoolScheduleCellItem.Clear();
			}
		}

		// Token: 0x0603894C RID: 231756 RVA: 0x00FD4F88 File Offset: 0x00FD3188
		public override void Clear()
		{
			this.Data = null;
			this.ResetAnimations();
		}

		// Token: 0x0603894D RID: 231757 RVA: 0x00FD4F97 File Offset: 0x00FD3197
		protected override void OnBeforeDestroy()
		{
			this.Clear();
		}

		// Token: 0x0603894E RID: 231758 RVA: 0x00FD4F9F File Offset: 0x00FD319F
		public UUIItem GetGuideGroupItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return null;
			}
			return button.GetRootComponent();
		}

		// Token: 0x0603894F RID: 231759 RVA: 0x00FD4FB4 File Offset: 0x00FD31B4
		private void OnClickGroup()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelectionState(EUISelectableSelectionState.Normal);
			}
			if (this.Data.BehaviorId == 0 || !this.Data.CanDelete)
			{
				return;
			}
			Action<SolarSchoolScheduleGroupData> deleteCallback = this.DeleteCallback;
			if (deleteCallback == null)
			{
				return;
			}
			deleteCallback(this.Data);
		}

		// Token: 0x0401DCD7 RID: 122071
		private SolarSchoolScheduleGroupData Data;

		// Token: 0x0401DCD8 RID: 122072
		private int RefreshVersion;

		// Token: 0x0401DCD9 RID: 122073
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolScheduleCellItem, SolarSchoolScheduleCellData> CellLayout;

		// Token: 0x0200B54D RID: 46413
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040380ED RID: 229613
			public const int BtnRoot = 0;

			// Token: 0x040380EE RID: 229614
			public const int PnlList = 1;

			// Token: 0x040380EF RID: 229615
			public const int CellTemplate = 2;
		}
	}
}
