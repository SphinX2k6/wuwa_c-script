using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063F7 RID: 25591
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourTaskTabItem : GridProxyAbstract<MotorParkourLevelData>
	{
		// Token: 0x060405C8 RID: 263624 RVA: 0x00F91718 File Offset: 0x00F8F918
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggleSpriteTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060405C9 RID: 263625 RVA: 0x00F91821 File Offset: 0x00F8FA21
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
		}

		// Token: 0x060405CA RID: 263626 RVA: 0x00F91830 File Offset: 0x00F8FA30
		public override void Refresh(MotorParkourLevelData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.SetSpriteByPath(data.RomanNum, base.GetSprite(1), false, null, delegate(bool _)
			{
				base.GetUiExtendToggleSpriteTransition(3).SetAllStateSprite(base.GetSprite(1).GetSprite());
			});
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.LevelName, Array.Empty<object>());
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(data.HasRewardRedDot);
		}

		// Token: 0x060405CB RID: 263627 RVA: 0x00F918A0 File Offset: 0x00F8FAA0
		private void OnToggleClick(EToggleState _)
		{
			Action<MotorParkourLevelData> onToggleCallback = this.OnToggleCallback;
			if (onToggleCallback == null)
			{
				return;
			}
			onToggleCallback(this.Data);
		}

		// Token: 0x060405CC RID: 263628 RVA: 0x00F918B8 File Offset: 0x00F8FAB8
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x060405CD RID: 263629 RVA: 0x00F918D0 File Offset: 0x00F8FAD0
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x060405CE RID: 263630 RVA: 0x00F918E8 File Offset: 0x00F8FAE8
		public override object GetKey(MotorParkourLevelData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x040217A3 RID: 137123
		private MotorParkourLevelData Data;

		// Token: 0x040217A4 RID: 137124
		public Action<MotorParkourLevelData> OnToggleCallback = delegate(MotorParkourLevelData data)
		{
		};

		// Token: 0x0200C613 RID: 50707
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BCCF RID: 244943
			public const int ToggleRoot = 0;

			// Token: 0x0403BCD0 RID: 244944
			public const int SpriteNum = 1;

			// Token: 0x0403BCD1 RID: 244945
			public const int TextName = 2;

			// Token: 0x0403BCD2 RID: 244946
			public const int SpriteTransitionNum = 3;

			// Token: 0x0403BCD3 RID: 244947
			public const int ItemRedDot = 4;
		}
	}
}
