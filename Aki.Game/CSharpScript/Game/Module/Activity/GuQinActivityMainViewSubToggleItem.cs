using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity
{
	// Token: 0x02004EE1 RID: 20193
	[NullableContext(1)]
	[Nullable(0)]
	public class GuQinActivityMainViewSubToggleItem : UiPanelBase
	{
		// Token: 0x06032C0F RID: 207887 RVA: 0x00E4114C File Offset: 0x00E3F34C
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

		// Token: 0x06032C10 RID: 207888 RVA: 0x00E41297 File Offset: 0x00E3F497
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteCallback));
			this.SetToggleState(EToggleState.ETT_UnChecked, true);
		}

		// Token: 0x06032C11 RID: 207889 RVA: 0x00E412CB File Offset: 0x00E3F4CB
		private bool CanExecuteCallback()
		{
			if (this.Data.GetStatus() == EGuQinActivityTaskStatus.Lock)
			{
				ScrollingTipsController.Instance.ShowTipsByText(this.Data.GetLockTip());
				return false;
			}
			return true;
		}

		// Token: 0x06032C12 RID: 207890 RVA: 0x00E412F2 File Offset: 0x00E3F4F2
		private void OnToggleClick(EToggleState state)
		{
			if (state == EToggleState.ETT_UnChecked)
			{
				return;
			}
			this.SelectCallback(this, this.Data);
		}

		// Token: 0x06032C13 RID: 207891 RVA: 0x00E4130A File Offset: 0x00E3F50A
		public void SetToggleState(EToggleState state, bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, fireEvent, false, false);
		}

		// Token: 0x06032C14 RID: 207892 RVA: 0x00E4131C File Offset: 0x00E3F51C
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

		// Token: 0x06032C15 RID: 207893 RVA: 0x00E41418 File Offset: 0x00E3F618
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

		// Token: 0x0401AF4A RID: 110410
		public GuQinActivityTaskData Data;

		// Token: 0x0401AF4B RID: 110411
		public Action<GuQinActivityMainViewSubToggleItem, GuQinActivityTaskData> SelectCallback;

		// Token: 0x0200AC3A RID: 44090
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x040354A1 RID: 218273
			public const int Toggle = 0;

			// Token: 0x040354A2 RID: 218274
			public const int TexIcon = 1;

			// Token: 0x040354A3 RID: 218275
			public const int TexNum = 2;

			// Token: 0x040354A4 RID: 218276
			public const int TextDay = 3;

			// Token: 0x040354A5 RID: 218277
			public const int PnlLock = 4;

			// Token: 0x040354A6 RID: 218278
			public const int RedDot = 5;

			// Token: 0x040354A7 RID: 218279
			public const int PnlDone = 6;
		}
	}
}
