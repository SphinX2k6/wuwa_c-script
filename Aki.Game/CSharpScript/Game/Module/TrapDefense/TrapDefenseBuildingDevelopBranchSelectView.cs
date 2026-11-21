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
	// Token: 0x02003A88 RID: 14984
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopBranchSelectView : UiViewBase
	{
		// Token: 0x060267EE RID: 157678 RVA: 0x00AC8F33 File Offset: 0x00AC7133
		public TrapDefenseBuildingDevelopBranchSelectView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060267EF RID: 157679 RVA: 0x00AC8F50 File Offset: 0x00AC7150
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

		// Token: 0x060267F0 RID: 157680 RVA: 0x00AC909C File Offset: 0x00AC729C
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

		// Token: 0x060267F1 RID: 157681 RVA: 0x00AC916E File Offset: 0x00AC736E
		protected override void OnBeforeDestroy()
		{
			this.CaptionItem = null;
			this.Data = null;
		}

		// Token: 0x060267F2 RID: 157682 RVA: 0x00AC9180 File Offset: 0x00AC7380
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

		// Token: 0x060267F3 RID: 157683 RVA: 0x00AC92F4 File Offset: 0x00AC74F4
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

		// Token: 0x060267F4 RID: 157684 RVA: 0x00AC9398 File Offset: 0x00AC7598
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

		// Token: 0x060267F5 RID: 157685 RVA: 0x00AC93C6 File Offset: 0x00AC75C6
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x060267F6 RID: 157686 RVA: 0x00AC93CF File Offset: 0x00AC75CF
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

		// Token: 0x060267F7 RID: 157687 RVA: 0x00AC9408 File Offset: 0x00AC7608
		private TrapDefenseBuildingDevelopBranchSelectItem CreateItem()
		{
			return new TrapDefenseBuildingDevelopBranchSelectItem
			{
				OnClickCb = new Action<int>(this.OnSelectedItem)
			};
		}

		// Token: 0x0401518D RID: 86413
		protected TrapDefenseBuildingDevelopItemData Data;

		// Token: 0x0401518E RID: 86414
		protected int CurSelectedId = -1;

		// Token: 0x0401518F RID: 86415
		protected PopupCaptionItem CaptionItem;

		// Token: 0x04015190 RID: 86416
		protected List<ITrapDefenseDevelopBranchSelectInfo> DataList = new List<ITrapDefenseDevelopBranchSelectInfo>();

		// Token: 0x04015191 RID: 86417
		protected GenericLayout<TrapDefenseBuildingDevelopBranchSelectItem, ITrapDefenseDevelopBranchSelectInfo> Layout;

		// Token: 0x04015192 RID: 86418
		protected bool IsInDungeon;

		// Token: 0x02009689 RID: 38537
		[NullableContext(0)]
		internal class EMainView
		{
			// Token: 0x0402F00D RID: 192525
			public const int Caption = 0;

			// Token: 0x0402F00E RID: 192526
			public const int Icon = 1;

			// Token: 0x0402F00F RID: 192527
			public const int Title = 2;

			// Token: 0x0402F010 RID: 192528
			public const int PanelSelectLayout = 3;

			// Token: 0x0402F011 RID: 192529
			public const int SelectItem = 4;

			// Token: 0x0402F012 RID: 192530
			public const int StartLayout = 5;

			// Token: 0x0402F013 RID: 192531
			public const int BtnConfirm = 6;
		}
	}
}
