using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200639D RID: 25501
	public class MultiMotorParkourTaskTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0604022E RID: 262702 RVA: 0x00F86D28 File Offset: 0x00F84F28
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

		// Token: 0x0604022F RID: 262703 RVA: 0x00F86E31 File Offset: 0x00F85031
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
		}

		// Token: 0x06040230 RID: 262704 RVA: 0x00F86E40 File Offset: 0x00F85040
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (data == 0)
			{
				this.RefreshAsGlobalTab();
				return;
			}
			this.RefreshAsLevelTab(data);
		}

		// Token: 0x06040231 RID: 262705 RVA: 0x00F86E5C File Offset: 0x00F8505C
		private void RefreshAsGlobalTab()
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_ComRomeText_05");
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, delegate(bool _)
			{
				base.GetUiExtendToggleSpriteTransition(3).SetAllStateSprite(base.GetSprite(1).GetSprite());
			});
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "MultiMotorGlobalTask", Array.Empty<object>());
			MultiMotorData activityData = this.ActivityData;
			bool uiactive = activityData != null && activityData.HasGlobalRewardRedDot;
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06040232 RID: 262706 RVA: 0x00F86EF0 File Offset: 0x00F850F0
		private void RefreshAsLevelTab(int levelId)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(true);
			}
			MultiMotorLevelData multiMotorLevelData = null;
			MultiMotorData activityData = this.ActivityData;
			if (activityData != null)
			{
				activityData.LevelDataMap.TryGetValue(levelId, out multiMotorLevelData);
			}
			OnlineMotorLevel? onlineMotorLevel = (multiMotorLevelData != null) ? multiMotorLevelData.Config : null;
			if (onlineMotorLevel == null)
			{
				return;
			}
			this.SetSpriteByPath(onlineMotorLevel.Value.LevelRomanSprite, base.GetSprite(1), false, null, delegate(bool _)
			{
				base.GetUiExtendToggleSpriteTransition(3).SetAllStateSprite(base.GetSprite(1).GetSprite());
			});
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), onlineMotorLevel.Value.Name, Array.Empty<object>());
			UUIItem item = base.GetItem(4);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(multiMotorLevelData != null && multiMotorLevelData.HasRewardRedDot);
		}

		// Token: 0x06040233 RID: 262707 RVA: 0x00F86FC0 File Offset: 0x00F851C0
		private void OnToggleClick(EToggleState _)
		{
			Action<int> onToggleCallback = this.OnToggleCallback;
			if (onToggleCallback == null)
			{
				return;
			}
			onToggleCallback(this.Data);
		}

		// Token: 0x06040234 RID: 262708 RVA: 0x00F86FD8 File Offset: 0x00F851D8
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06040235 RID: 262709 RVA: 0x00F86FF0 File Offset: 0x00F851F0
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06040236 RID: 262710 RVA: 0x00F87008 File Offset: 0x00F85208
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x040216AC RID: 136876
		private int Data;

		// Token: 0x040216AD RID: 136877
		[Nullable(2)]
		public MultiMotorData ActivityData;

		// Token: 0x040216AE RID: 136878
		[Nullable(1)]
		public Action<int> OnToggleCallback = delegate(int data)
		{
		};

		// Token: 0x0200C5B6 RID: 50614
		private class EComponents
		{
			// Token: 0x0403BB19 RID: 244505
			public const int ToggleRoot = 0;

			// Token: 0x0403BB1A RID: 244506
			public const int SpriteNum = 1;

			// Token: 0x0403BB1B RID: 244507
			public const int TextName = 2;

			// Token: 0x0403BB1C RID: 244508
			public const int SpriteTransitionNum = 3;

			// Token: 0x0403BB1D RID: 244509
			public const int ItemRedDot = 4;
		}
	}
}
