using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200599D RID: 22941
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolRoleTogItem : UiPanelBase
	{
		// Token: 0x17006C2B RID: 27691
		// (get) Token: 0x06038906 RID: 231686 RVA: 0x00FD35C6 File Offset: 0x00FD17C6
		// (set) Token: 0x06038907 RID: 231687 RVA: 0x00FD35CE File Offset: 0x00FD17CE
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolTogItemData> ClickCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06038908 RID: 231688 RVA: 0x00FD35D8 File Offset: 0x00FD17D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038909 RID: 231689 RVA: 0x00FD36C0 File Offset: 0x00FD18C0
		protected override void OnStart()
		{
			AActor rootActor = base.GetRootActor();
			this.Canvas = (((rootActor != null) ? rootActor.GetComponentByClass(ULGUICanvas.StaticClass()) : null) as ULGUICanvas);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(() => !this.IsAboveMask);
		}

		// Token: 0x0603890A RID: 231690 RVA: 0x00FD3718 File Offset: 0x00FD1918
		public void Refresh(SolarSchoolTogItemData data)
		{
			this.Data = data;
			this.SetAboveMask(false);
			this.SetSelected(false);
			base.SetUiActive(data != null);
			if (data == null)
			{
				return;
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(data.ShowRedDot);
			}
			string occupyTagText = SolarSchoolUtils.GetOccupyTagText(data.OccupySlot);
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(!string.IsNullOrEmpty(occupyTagText));
			}
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(occupyTagText, true);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetSelfInteractive(data.CanClick);
		}

		// Token: 0x0603890B RID: 231691 RVA: 0x00FD37B4 File Offset: 0x00FD19B4
		public void SetAboveMask(bool above)
		{
			this.IsAboveMask = above;
			if (this.Canvas == null)
			{
				if (above)
				{
					Log.Instance.Warn(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 角色槽位按钮没挂 LGUICanvas，无法抬到二次确认遮罩之上", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return;
			}
			this.Canvas.SetSortOrder((above > false) ? 1 : 0, true);
		}

		// Token: 0x0603890C RID: 231692 RVA: 0x00FD3803 File Offset: 0x00FD1A03
		public UUIItem GetGuideToggleItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.GetRootComponent();
		}

		// Token: 0x0603890D RID: 231693 RVA: 0x00FD3817 File Offset: 0x00FD1A17
		public void SetSelected(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603890E RID: 231694 RVA: 0x00FD3834 File Offset: 0x00FD1A34
		private void OnClickToggle(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.Data == null || !this.Data.CanClick)
			{
				return;
			}
			Action<SolarSchoolTogItemData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data);
		}

		// Token: 0x0401DCA0 RID: 122016
		private const int SortOrderNormal = 0;

		// Token: 0x0401DCA1 RID: 122017
		private const int SortOrderAboveMask = 1;

		// Token: 0x0401DCA2 RID: 122018
		private SolarSchoolTogItemData Data;

		// Token: 0x0401DCA3 RID: 122019
		private ULGUICanvas Canvas;

		// Token: 0x0401DCA4 RID: 122020
		private bool IsAboveMask;

		// Token: 0x0200B547 RID: 46407
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040380BF RID: 229567
			public const int Toggle = 0;

			// Token: 0x040380C0 RID: 229568
			public const int RedDot = 1;

			// Token: 0x040380C1 RID: 229569
			public const int PnlTag = 2;

			// Token: 0x040380C2 RID: 229570
			public const int TxtTag = 3;
		}
	}
}
