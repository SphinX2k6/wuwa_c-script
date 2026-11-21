using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200619F RID: 24991
	[NullableContext(1)]
	[Nullable(0)]
	public class TouchUiEditViewModel : IStaticVariableResetter
	{
		// Token: 0x0603BF68 RID: 245608 RVA: 0x01108B35 File Offset: 0x01106D35
		static TouchUiEditViewModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TouchUiEditViewModel.CreateStaticDefaultValue), new Action(TouchUiEditViewModel.ResetStaticDefaultValue));
		}

		// Token: 0x0603BF69 RID: 245609 RVA: 0x01108B54 File Offset: 0x01106D54
		[NullableContext(2)]
		public static void SetCurrentSelectedItem(ITouchUiEditItem item)
		{
			TouchUiEditViewModel.CurrentSelectedItem = item;
			if (item != null)
			{
				TouchUiEditViewModel.NotifySelectedItemChange(item);
			}
		}

		// Token: 0x0603BF6A RID: 245610 RVA: 0x01108B65 File Offset: 0x01106D65
		[NullableContext(2)]
		public static ITouchUiEditItem GetCurrentSelectedItem()
		{
			return TouchUiEditViewModel.CurrentSelectedItem;
		}

		// Token: 0x0603BF6B RID: 245611 RVA: 0x01108B6C File Offset: 0x01106D6C
		public static void AddTouchFingerData(TouchFingerData touchFingerData)
		{
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			TouchUiEditViewModel.TouchFingerDataMap[(int)fingerIndex] = touchFingerData;
		}

		// Token: 0x0603BF6C RID: 245612 RVA: 0x01108B8C File Offset: 0x01106D8C
		public static void RemoveTouchFingerData(TouchFingerData touchFingerData)
		{
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			TouchUiEditViewModel.TouchFingerDataMap.Remove((int)fingerIndex);
		}

		// Token: 0x0603BF6D RID: 245613 RVA: 0x01108BAC File Offset: 0x01106DAC
		[NullableContext(2)]
		public static TouchFingerData GetTouchFingerData(int fingerIndex)
		{
			return TouchUiEditViewModel.TouchFingerDataMap.GetValueOrDefault(fingerIndex);
		}

		// Token: 0x0603BF6E RID: 245614 RVA: 0x01108BB9 File Offset: 0x01106DB9
		public static int GetTouchFingerDataCount()
		{
			return TouchUiEditViewModel.TouchFingerDataMap.Count;
		}

		// Token: 0x0603BF6F RID: 245615 RVA: 0x01108BC5 File Offset: 0x01106DC5
		public static void SetRootItem(UUIItem rootItem)
		{
			TouchUiEditViewModel.RootItem = rootItem;
		}

		// Token: 0x0603BF70 RID: 245616 RVA: 0x01108BCD File Offset: 0x01106DCD
		[NullableContext(2)]
		public static UUIItem GetRootItem()
		{
			return TouchUiEditViewModel.RootItem;
		}

		// Token: 0x0603BF71 RID: 245617 RVA: 0x01108BD4 File Offset: 0x01106DD4
		public static void AddDelegateOnSelectedItemChange(Action<ITouchUiEditItem> delegate_)
		{
			TouchUiEditViewModel.DelegatesOnSelectedItemChange.Add(delegate_);
		}

		// Token: 0x0603BF72 RID: 245618 RVA: 0x01108BE4 File Offset: 0x01106DE4
		public static void RemoveDelegateOnSelectedItemChange(Action<ITouchUiEditItem> delegate_)
		{
			int num = TouchUiEditViewModel.DelegatesOnSelectedItemChange.IndexOf(delegate_);
			if (num != -1)
			{
				TouchUiEditViewModel.DelegatesOnSelectedItemChange.RemoveAt(num);
			}
		}

		// Token: 0x0603BF73 RID: 245619 RVA: 0x01108C0C File Offset: 0x01106E0C
		public static void NotifySelectedItemChange(ITouchUiEditItem item)
		{
			if (TouchUiEditViewModel.CurrentSelectedItem != item)
			{
				return;
			}
			foreach (Action<ITouchUiEditItem> action in TouchUiEditViewModel.DelegatesOnSelectedItemChange)
			{
				action(item);
			}
		}

		// Token: 0x0603BF74 RID: 245620 RVA: 0x01108C68 File Offset: 0x01106E68
		public static void CreateStaticDefaultValue()
		{
			TouchUiEditViewModel.CurrentSelectedItem = null;
			TouchUiEditViewModel.RootItem = null;
			TouchUiEditViewModel.TouchFingerDataMap = new Dictionary<int, TouchFingerData>();
			TouchUiEditViewModel.DelegatesOnSelectedItemChange = new List<Action<ITouchUiEditItem>>();
		}

		// Token: 0x0603BF75 RID: 245621 RVA: 0x01108C8A File Offset: 0x01106E8A
		public static void ResetStaticDefaultValue()
		{
			TouchUiEditViewModel.CurrentSelectedItem = null;
			TouchUiEditViewModel.RootItem = null;
			TouchUiEditViewModel.TouchFingerDataMap = null;
			TouchUiEditViewModel.DelegatesOnSelectedItemChange = null;
		}

		// Token: 0x0401FAF2 RID: 129778
		[Nullable(2)]
		private static ITouchUiEditItem CurrentSelectedItem;

		// Token: 0x0401FAF3 RID: 129779
		[Nullable(2)]
		private static UUIItem RootItem;

		// Token: 0x0401FAF4 RID: 129780
		private static Dictionary<int, TouchFingerData> TouchFingerDataMap;

		// Token: 0x0401FAF5 RID: 129781
		private static List<Action<ITouchUiEditItem>> DelegatesOnSelectedItemChange;
	}
}
