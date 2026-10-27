using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02005EFA RID: 24314
	[NullableContext(1)]
	[Nullable(0)]
	public class GuQinActivityMainViewSubToggleItem : UiPanelBase
	{
		// Token: 0x0603DC74 RID: 253044 RVA: 0x00EEF488 File Offset: 0x00EED688
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603DC75 RID: 253045 RVA: 0x00EEF5D3 File Offset: 0x00EED7D3
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteCallback));
			this.SetToggleState(EToggleState.ETT_UnChecked, true);
		}

		// Token: 0x0603DC76 RID: 253046 RVA: 0x00EEF607 File Offset: 0x00EED807
		private bool CanExecuteCallback()
		{
			if (this.Data.GetStatus() == EGuQinActivityTaskStatus.Lock)
			{
				ScrollingTipsController.Instance.ShowTipsByText(this.Data.GetLockTip());
				return false;
			}
			return true;
		}

		// Token: 0x0603DC77 RID: 253047 RVA: 0x00EEF62E File Offset: 0x00EED82E
		private void OnToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_UnChecked)
			{
				return;
			}
			this.SelectCallback(this, this.Data);
		}

		// Token: 0x0603DC78 RID: 253048 RVA: 0x00EEF646 File Offset: 0x00EED846
		public void SetToggleState(EToggleState state, bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x0603DC79 RID: 253049 RVA: 0x00EEF658 File Offset: 0x00EED858
		public void Refresh(GuQinActivityTaskData data)
		{
			this.Data = data;
			GuQinActivityTask config = data.GetConfig();
			string text = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? config.FemaleTabBgPath : config.TabBgPath;
			if (!StringUtils.IsBlank(text))
			{
				base.TrySetTextureByPath(text, base.GetTexture(1), null, null);
			}
			if (!StringUtils.IsBlank(config.TabNumTexturePath))
			{
				base.TrySetTextureByPath(config.TabNumTexturePath, base.GetTexture(2), null, null);
			}
			if (!StringUtils.IsBlank(config.TabNumTxt))
			{
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(3), config.TabNumTxt, Array.Empty<object>());
			}
			EGuQinActivityTaskStatus status = data.GetStatus();
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(status == EGuQinActivityTaskStatus.Lock);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(status == EGuQinActivityTaskStatus.Completed);
			}
			UUIItem item3 = base.GetItem(5);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(data.GetIsRedDot());
		}

		// Token: 0x0603DC7A RID: 253050 RVA: 0x00EEF754 File Offset: 0x00EED954
		public void RefreshRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.Data.GetIsRedDot());
		}

		// Token: 0x04020478 RID: 132216
		public GuQinActivityTaskData Data;

		// Token: 0x04020479 RID: 132217
		public Action<GuQinActivityMainViewSubToggleItem, GuQinActivityTaskData> SelectCallback;

		// Token: 0x0200C22C RID: 49708
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403AAAD RID: 240301
			public const int Toggle = 0;

			// Token: 0x0403AAAE RID: 240302
			public const int TexIcon = 1;

			// Token: 0x0403AAAF RID: 240303
			public const int TexNum = 2;

			// Token: 0x0403AAB0 RID: 240304
			public const int TextDay = 3;

			// Token: 0x0403AAB1 RID: 240305
			public const int PnlLock = 4;

			// Token: 0x0403AAB2 RID: 240306
			public const int RedDot = 5;

			// Token: 0x0403AAB3 RID: 240307
			public const int PnlDone = 6;
		}
	}
}
