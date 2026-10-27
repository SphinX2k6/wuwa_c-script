using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AE0 RID: 19168
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopBranchSelectView : UiViewBase
	{
		// Token: 0x06031A5E RID: 203358 RVA: 0x00B84F7F File Offset: 0x00B8317F
		public TrapDefenseBuildingDevelopBranchSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06031A5F RID: 203359 RVA: 0x00B84F9C File Offset: 0x00B8319C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickedConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031A60 RID: 203360 RVA: 0x00B850E8 File Offset: 0x00B832E8
		protected override void OnStart()
		{
			ITrapDefenseSelectBranchData trapDefenseSelectBranchData = this.OpenParam as ITrapDefenseSelectBranchData;
			this.IsInDungeon = trapDefenseSelectBranchData.IsInDungeon;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(this.IsInDungeon);
			}
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!this.IsInDungeon);
			}
			this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedClose));
			this.Layout = new GenericLayout<TrapDefenseBuildingDevelopBranchSelectItem, ITrapDefenseDevelopBranchSelectInfo>(base.GetVerticalLayout(3), new Func<TrapDefenseBuildingDevelopBranchSelectItem>(this.CreateItem), null, false, true);
			this.Data = trapDefenseSelectBranchData.Data;
			this.CurSelectedId = this.Data.Id;
			this.UpdateData();
		}

		// Token: 0x06031A61 RID: 203361 RVA: 0x00B851BA File Offset: 0x00B833BA
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.Data = null;
		}

		// Token: 0x06031A62 RID: 203362 RVA: 0x00B851CC File Offset: 0x00B833CC
		protected void UpdateData()
		{
			if (!this.Data.GetHasBranch())
			{
				base.CloseMe(null);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.Data.GetName(), Array.Empty<object>());
			base.SetTextureByPath(this.Data.GetIconPath(), base.GetTexture(1), null, null);
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(this.CurSelectedId);
			int branchCount = this.Data.GetBranchCount();
			for (int i = 1; i <= branchCount; i++)
			{
				ITrapDefenseMachineIdInfo info = new ITrapDefenseMachineIdInfo
				{
					MachineType = trapDefenseMachineIdInfo.MachineType,
					DataType = trapDefenseMachineIdInfo.DataType,
					Level = trapDefenseMachineIdInfo.Level,
					Branch = i
				};
				int num = TrapDefenseModel.Instance.ComposeMachineId(info);
				TrapDefenseDevelopBranchSelectInfo item = new TrapDefenseDevelopBranchSelectInfo
				{
					Id = num,
					IsCurLevel = (this.Data.Id == num),
					IsSelected = (this.Data.Id == num)
				};
				this.DataList.Add(item);
			}
			this.Layout.RefreshByData(this.DataList, delegate
			{
				this.UpdateSelected();
				foreach (TrapDefenseBuildingDevelopBranchSelectItem trapDefenseBuildingDevelopBranchSelectItem in this.Layout.GetLayoutItemList())
				{
					trapDefenseBuildingDevelopBranchSelectItem.GetRootItem().SetRaycastTarget(!this.IsInDungeon);
				}
			}, true);
			this.CurSelectedId = ((trapDefenseMachineIdInfo.Branch > 0) ? this.Data.Id : -1);
			UUIButtonComponent button = base.GetButton(6);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(this.CurSelectedId != -1);
		}

		// Token: 0x06031A63 RID: 203363 RVA: 0x00B85340 File Offset: 0x00B83540
		protected void UpdateSelected()
		{
			foreach (ITrapDefenseDevelopBranchSelectInfo trapDefenseDevelopBranchSelectInfo in this.DataList)
			{
				trapDefenseDevelopBranchSelectInfo.IsSelected = (this.CurSelectedId == trapDefenseDevelopBranchSelectInfo.Id);
			}
			foreach (TrapDefenseBuildingDevelopBranchSelectItem trapDefenseBuildingDevelopBranchSelectItem in this.Layout.GetLayoutItemList())
			{
				trapDefenseBuildingDevelopBranchSelectItem.UpdateSelected();
			}
		}

		// Token: 0x06031A64 RID: 203364 RVA: 0x00B853E4 File Offset: 0x00B835E4
		private void OnClickedConfirm()
		{
			if (this.CurSelectedId == -1)
			{
				return;
			}
			TrapDefenseController.Instance.RequestTrapDefenseDevelopBranch(this.CurSelectedId).ContinueWith(delegate(bool task)
			{
				if (task)
				{
					base.CloseMe(null);
				}
			});
		}

		// Token: 0x06031A65 RID: 203365 RVA: 0x00B85412 File Offset: 0x00B83612
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031A66 RID: 203366 RVA: 0x00B8541B File Offset: 0x00B8361B
		private void OnSelectedItem(int id)
		{
			this.CurSelectedId = ((id == this.CurSelectedId) ? -1 : id);
			UUIButtonComponent button = base.GetButton(6);
			if (button != null)
			{
				button.SetSelfInteractive(this.CurSelectedId != -1);
			}
			this.UpdateSelected();
		}

		// Token: 0x06031A67 RID: 203367 RVA: 0x00B85454 File Offset: 0x00B83654
		private TrapDefenseBuildingDevelopBranchSelectItem CreateItem()
		{
			return new TrapDefenseBuildingDevelopBranchSelectItem
			{
				OnClickCb = new Action<int>(this.OnSelectedItem)
			};
		}

		// Token: 0x0401A83B RID: 108603
		protected TrapDefenseBuildingDevelopItemData Data;

		// Token: 0x0401A83C RID: 108604
		protected int CurSelectedId = -1;

		// Token: 0x0401A83D RID: 108605
		protected PopupCaptionItem CaptionItem;

		// Token: 0x0401A83E RID: 108606
		protected List<ITrapDefenseDevelopBranchSelectInfo> DataList = new List<ITrapDefenseDevelopBranchSelectInfo>();

		// Token: 0x0401A83F RID: 108607
		protected GenericLayout<TrapDefenseBuildingDevelopBranchSelectItem, ITrapDefenseDevelopBranchSelectInfo> Layout;

		// Token: 0x0401A840 RID: 108608
		protected bool IsInDungeon;

		// Token: 0x0200AC69 RID: 44137
		[NullableContext(0)]
		internal class EMainView
		{
			// Token: 0x0403465C RID: 214620
			public const int Caption = 0;

			// Token: 0x0403465D RID: 214621
			public const int Icon = 1;

			// Token: 0x0403465E RID: 214622
			public const int Title = 2;

			// Token: 0x0403465F RID: 214623
			public const int PanelSelectLayout = 3;

			// Token: 0x04034660 RID: 214624
			public const int SelectItem = 4;

			// Token: 0x04034661 RID: 214625
			public const int StartLayout = 5;

			// Token: 0x04034662 RID: 214626
			public const int BtnConfirm = 6;
		}
	}
}
