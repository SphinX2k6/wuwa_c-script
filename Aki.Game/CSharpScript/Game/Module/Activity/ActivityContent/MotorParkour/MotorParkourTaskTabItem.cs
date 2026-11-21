using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005375 RID: 21365
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorParkourTaskTabItem : GridProxyAbstract<MotorParkourLevelData>
	{
		// Token: 0x06035289 RID: 217737 RVA: 0x00ED86F8 File Offset: 0x00ED68F8
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

		// Token: 0x0603528A RID: 217738 RVA: 0x00ED8801 File Offset: 0x00ED6A01
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
		}

		// Token: 0x0603528B RID: 217739 RVA: 0x00ED8810 File Offset: 0x00ED6A10
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

		// Token: 0x0603528C RID: 217740 RVA: 0x00ED8880 File Offset: 0x00ED6A80
		private void OnToggleClick(EToggleState _)
		{
			Action<MotorParkourLevelData> onToggleCallback = this.OnToggleCallback;
			if (onToggleCallback == null)
			{
				return;
			}
			onToggleCallback(this.Data);
		}

		// Token: 0x0603528D RID: 217741 RVA: 0x00ED8898 File Offset: 0x00ED6A98
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603528E RID: 217742 RVA: 0x00ED88B0 File Offset: 0x00ED6AB0
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603528F RID: 217743 RVA: 0x00ED88C8 File Offset: 0x00ED6AC8
		public override object GetKey(MotorParkourLevelData data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x0401C0D2 RID: 114898
		private MotorParkourLevelData Data;

		// Token: 0x0401C0D3 RID: 114899
		public Action<MotorParkourLevelData> OnToggleCallback = delegate(MotorParkourLevelData data)
		{
		};

		// Token: 0x0200AFFA RID: 45050
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403662E RID: 222766
			public const int ToggleRoot = 0;

			// Token: 0x0403662F RID: 222767
			public const int SpriteNum = 1;

			// Token: 0x04036630 RID: 222768
			public const int TextName = 2;

			// Token: 0x04036631 RID: 222769
			public const int SpriteTransitionNum = 3;

			// Token: 0x04036632 RID: 222770
			public const int ItemRedDot = 4;
		}
	}
}
