using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.CustomMarkPanel
{
	// Token: 0x0200375D RID: 14173
	public class MarkIconOption : UiPanelBase
	{
		// Token: 0x17004BA9 RID: 19369
		// (get) Token: 0x06024D93 RID: 150931 RVA: 0x00A6A405 File Offset: 0x00A68605
		// (set) Token: 0x06024D94 RID: 150932 RVA: 0x00A6A40D File Offset: 0x00A6860D
		public CustomMark? Config { get; set; }

		// Token: 0x06024D95 RID: 150933 RVA: 0x00A6A418 File Offset: 0x00A68618
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

		// Token: 0x06024D96 RID: 150934 RVA: 0x00A6A498 File Offset: 0x00A68698
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

		// Token: 0x06024D97 RID: 150935 RVA: 0x00A6A501 File Offset: 0x00A68701
		protected override void OnStart()
		{
			base.GetExtendToggle(1).SetToggleGroup(this.ParentMarkUi.GetOwner());
			base.GetExtendToggle(1).bLockStateOnSelect = true;
		}

		// Token: 0x06024D98 RID: 150936 RVA: 0x00A6A527 File Offset: 0x00A68727
		[NullableContext(1)]
		public void SetOnclick(Action<EToggleState> fn)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			extendToggle.OnStateChange.Clear();
			extendToggle.OnStateChange.Add(fn);
		}

		// Token: 0x06024D99 RID: 150937 RVA: 0x00A6A546 File Offset: 0x00A68746
		public void SetToggleChecked()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
		}

		// Token: 0x06024D9A RID: 150938 RVA: 0x00A6A55E File Offset: 0x00A6875E
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Clear();
		}

		// Token: 0x040146DF RID: 83679
		[Nullable(2)]
		private UUIItem ParentMarkUi;

		// Token: 0x020094B4 RID: 38068
		public static class EMarkOptionsComponents
		{
			// Token: 0x0402E734 RID: 190260
			public const int Icon = 0;

			// Token: 0x0402E735 RID: 190261
			public const int Toggle = 1;
		}
	}
}
