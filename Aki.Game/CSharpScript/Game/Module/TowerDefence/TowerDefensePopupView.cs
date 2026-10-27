using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B5F RID: 19295
	public class TowerDefensePopupView : UiViewBase, IExtraUiPopFrameType
	{
		// Token: 0x06031F54 RID: 204628 RVA: 0x00B97F83 File Offset: 0x00B96183
		[NullableContext(1)]
		public TowerDefensePopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031F55 RID: 204629 RVA: 0x00B97F8C File Offset: 0x00B9618C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnCancel));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031F56 RID: 204630 RVA: 0x00B980D9 File Offset: 0x00B962D9
		[NullableContext(2)]
		public EUiBehaviourPopType? GetExtraPopFrameType(object param = null)
		{
			return new EUiBehaviourPopType?(EUiBehaviourPopType.TowerDefense);
		}

		// Token: 0x06031F57 RID: 204631 RVA: 0x00B980E4 File Offset: 0x00B962E4
		protected override void OnStart()
		{
			ITowerDefensePopupViewArgs towerDefensePopupViewArgs = this.OpenParam as ITowerDefensePopupViewArgs;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), ((towerDefensePopupViewArgs != null) ? towerDefensePopupViewArgs.TextTitle : null) ?? "", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), ((towerDefensePopupViewArgs != null) ? towerDefensePopupViewArgs.TextTips : null) ?? "", ((towerDefensePopupViewArgs != null) ? towerDefensePopupViewArgs.TextTipsArgs : null) ?? new List<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), ((towerDefensePopupViewArgs != null) ? towerDefensePopupViewArgs.TextContent : null) ?? "", Array.Empty<object>());
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06031F58 RID: 204632 RVA: 0x00B981A0 File Offset: 0x00B963A0
		private void OnClickBtnCancel()
		{
			ITowerDefensePopupViewArgs towerDefensePopupViewArgs = this.OpenParam as ITowerDefensePopupViewArgs;
			if (towerDefensePopupViewArgs != null)
			{
				Action cancelBack = towerDefensePopupViewArgs.CancelBack;
				if (cancelBack != null)
				{
					cancelBack();
				}
			}
			base.CloseMe(null);
		}

		// Token: 0x06031F59 RID: 204633 RVA: 0x00B981CA File Offset: 0x00B963CA
		private void OnClickBtnConfirm()
		{
			ITowerDefensePopupViewArgs towerDefensePopupViewArgs = this.OpenParam as ITowerDefensePopupViewArgs;
			if (towerDefensePopupViewArgs != null)
			{
				Action confirmBack = towerDefensePopupViewArgs.ConfirmBack;
				if (confirmBack != null)
				{
					confirmBack();
				}
			}
			base.CloseMe(null);
		}

		// Token: 0x0200ACF0 RID: 44272
		private class EComponent
		{
			// Token: 0x040348BD RID: 215229
			public const int TextTips = 0;

			// Token: 0x040348BE RID: 215230
			public const int TextContent = 1;

			// Token: 0x040348BF RID: 215231
			public const int BtnCancel = 2;

			// Token: 0x040348C0 RID: 215232
			public const int BtnConfirm = 3;

			// Token: 0x040348C1 RID: 215233
			public const int WaitingItem = 4;

			// Token: 0x040348C2 RID: 215234
			public const int TextTitle = 5;
		}
	}
}
