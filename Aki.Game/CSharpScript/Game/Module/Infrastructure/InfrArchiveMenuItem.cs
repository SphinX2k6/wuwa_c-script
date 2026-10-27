using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x02005907 RID: 22791
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class InfrArchiveMenuItem : GridProxyAbstract<IInfrArchiveMenuItemData>
	{
		// Token: 0x17008AD8 RID: 35544
		// (get) Token: 0x06039E08 RID: 237064 RVA: 0x00DBEFA2 File Offset: 0x00DBD1A2
		public InfrastructureDefine.EInfrArchiveTabType CardType
		{
			get
			{
				return this.Data.CardType;
			}
		}

		// Token: 0x06039E09 RID: 237065 RVA: 0x00DBEFB0 File Offset: 0x00DBD1B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039E0A RID: 237066 RVA: 0x00DBF056 File Offset: 0x00DBD256
		public override void Refresh(IInfrArchiveMenuItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetText(1).ShowTextNew(data.DesText);
		}

		// Token: 0x06039E0B RID: 237067 RVA: 0x00DBF071 File Offset: 0x00DBD271
		public void SetToggleClickCb(Action<int> callback)
		{
			this.SelectedCallBack = callback;
		}

		// Token: 0x06039E0C RID: 237068 RVA: 0x00DBF07A File Offset: 0x00DBD27A
		public void SetToggleSelected(EToggleState state)
		{
			base.GetExtendToggle(0).SetToggleState(state, false, false, false);
		}

		// Token: 0x06039E0D RID: 237069 RVA: 0x00DBF08D File Offset: 0x00DBD28D
		private void ToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectedCallBack((int)this.Data.CardType);
				return;
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06039E0E RID: 237070 RVA: 0x00DBF0C0 File Offset: 0x00DBD2C0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			UUIItem uuiitem = (extendToggle != null) ? extendToggle.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401E307 RID: 123655
		private IInfrArchiveMenuItemData Data;

		// Token: 0x0401E308 RID: 123656
		public Action<int> SelectedCallBack;

		// Token: 0x0200BB6E RID: 47982
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038933 RID: 231731
			public const int ToggleItem = 0;

			// Token: 0x04038934 RID: 231732
			public const int TextTitle = 1;
		}
	}
}
