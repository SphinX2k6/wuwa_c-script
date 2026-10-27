using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CustomMarkPanel
{
	// Token: 0x0200482C RID: 18476
	public class MarkIconOption : UiPanelBase
	{
		// Token: 0x170078EC RID: 30956
		// (get) Token: 0x060305C3 RID: 198083 RVA: 0x00B3A339 File Offset: 0x00B38539
		// (set) Token: 0x060305C4 RID: 198084 RVA: 0x00B3A341 File Offset: 0x00B38541
		public CustomMark? Config { get; set; }

		// Token: 0x060305C5 RID: 198085 RVA: 0x00B3A34C File Offset: 0x00B3854C
		[NullableContext(1)]
		public void Initialize(UUIItem item, UUIItem parent, CustomMark config)
		{
			if (GlobalData.World == null)
			{
				return;
			}
			this.ParentMarkUi = parent;
			AActor owner = item.GetOwner();
			item.SetUIActive(true);
			base.CreateThenShowByActor(owner, null);
			this.Config = new CustomMark?(config);
			this.SetSpriteByPath(this.Config.Value.MarkPic, base.GetSprite(0), false, null, null);
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetRaycastTarget(true);
		}

		// Token: 0x060305C6 RID: 198086 RVA: 0x00B3A3CC File Offset: 0x00B385CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060305C7 RID: 198087 RVA: 0x00B3A435 File Offset: 0x00B38635
		protected override void OnStart()
		{
			base.GetExtendToggle(1).SetToggleGroup(this.ParentMarkUi.GetOwner());
			base.GetExtendToggle(1).bLockStateOnSelect = true;
		}

		// Token: 0x060305C8 RID: 198088 RVA: 0x00B3A45B File Offset: 0x00B3865B
		[NullableContext(1)]
		public void SetOnclick(Action<EToggleState> fn)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			extendToggle.OnStateChange.Clear();
			extendToggle.OnStateChange.Add(fn);
		}

		// Token: 0x060305C9 RID: 198089 RVA: 0x00B3A47A File Offset: 0x00B3867A
		public void SetToggleChecked()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x060305CA RID: 198090 RVA: 0x00B3A492 File Offset: 0x00B38692
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Clear();
		}

		// Token: 0x0401A02B RID: 106539
		[Nullable(2)]
		private UUIItem ParentMarkUi;

		// Token: 0x0200AB05 RID: 43781
		public static class EMarkOptionsComponents
		{
			// Token: 0x04033FB4 RID: 212916
			public const int Icon = 0;

			// Token: 0x04033FB5 RID: 212917
			public const int Toggle = 1;
		}
	}
}
