using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B07 RID: 15111
	public class TowerDefensePopupView : UiViewBase, IExtraUiPopFrameType
	{
		// Token: 0x06026CE3 RID: 158947 RVA: 0x00ADC1BF File Offset: 0x00ADA3BF
		[NullableContext(1)]
		public TowerDefensePopupView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026CE4 RID: 158948 RVA: 0x00ADC1C8 File Offset: 0x00ADA3C8
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

		// Token: 0x06026CE5 RID: 158949 RVA: 0x00ADC315 File Offset: 0x00ADA515
		[NullableContext(2)]
		public EUiBehaviourPopType? GetExtraPopFrameType(object param = null)
		{
			return new EUiBehaviourPopType?(EUiBehaviourPopType.TowerDefense);
		}

		// Token: 0x06026CE6 RID: 158950 RVA: 0x00ADC320 File Offset: 0x00ADA520
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

		// Token: 0x06026CE7 RID: 158951 RVA: 0x00ADC3DC File Offset: 0x00ADA5DC
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

		// Token: 0x06026CE8 RID: 158952 RVA: 0x00ADC406 File Offset: 0x00ADA606
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

		// Token: 0x0200970F RID: 38671
		private class EComponent
		{
			// Token: 0x0402F266 RID: 193126
			public const int TextTips = 0;

			// Token: 0x0402F267 RID: 193127
			public const int TextContent = 1;

			// Token: 0x0402F268 RID: 193128
			public const int BtnCancel = 2;

			// Token: 0x0402F269 RID: 193129
			public const int BtnConfirm = 3;

			// Token: 0x0402F26A RID: 193130
			public const int WaitingItem = 4;

			// Token: 0x0402F26B RID: 193131
			public const int TextTitle = 5;
		}
	}
}
