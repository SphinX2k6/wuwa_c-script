using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200531B RID: 21275
	public class MultiMotorParkourTaskTabItem : GridProxyAbstract<int>
	{
		// Token: 0x06034EEF RID: 216815 RVA: 0x00ECDC60 File Offset: 0x00ECBE60
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

		// Token: 0x06034EF0 RID: 216816 RVA: 0x00ECDD69 File Offset: 0x00ECBF69
		protected override void OnStart()
		{
			base.GetExtendToggle(0).bLockStateOnSelect = true;
		}

		// Token: 0x06034EF1 RID: 216817 RVA: 0x00ECDD78 File Offset: 0x00ECBF78
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

		// Token: 0x06034EF2 RID: 216818 RVA: 0x00ECDD94 File Offset: 0x00ECBF94
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

		// Token: 0x06034EF3 RID: 216819 RVA: 0x00ECDE28 File Offset: 0x00ECC028
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

		// Token: 0x06034EF4 RID: 216820 RVA: 0x00ECDEF8 File Offset: 0x00ECC0F8
		private void OnToggleClick(EToggleState _)
		{
			Action<int> onToggleCallback = this.OnToggleCallback;
			if (onToggleCallback == null)
			{
				return;
			}
			onToggleCallback(this.Data);
		}

		// Token: 0x06034EF5 RID: 216821 RVA: 0x00ECDF10 File Offset: 0x00ECC110
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06034EF6 RID: 216822 RVA: 0x00ECDF28 File Offset: 0x00ECC128
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06034EF7 RID: 216823 RVA: 0x00ECDF40 File Offset: 0x00ECC140
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0401BFDB RID: 114651
		private int Data;

		// Token: 0x0401BFDC RID: 114652
		[Nullable(2)]
		public MultiMotorData ActivityData;

		// Token: 0x0401BFDD RID: 114653
		[Nullable(1)]
		public Action<int> OnToggleCallback = delegate(int data)
		{
		};

		// Token: 0x0200AF9D RID: 44957
		private class EComponents
		{
			// Token: 0x04036478 RID: 222328
			public const int ToggleRoot = 0;

			// Token: 0x04036479 RID: 222329
			public const int SpriteNum = 1;

			// Token: 0x0403647A RID: 222330
			public const int TextName = 2;

			// Token: 0x0403647B RID: 222331
			public const int SpriteTransitionNum = 3;

			// Token: 0x0403647C RID: 222332
			public const int ItemRedDot = 4;
		}
	}
}
