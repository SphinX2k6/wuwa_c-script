using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x0200701E RID: 28702
	[NullableContext(1)]
	[Nullable(0)]
	public class TouchUiEditViewModel : IStaticVariableResetter
	{
		// Token: 0x06045DB2 RID: 286130 RVA: 0x0115E739 File Offset: 0x0115C939
		static TouchUiEditViewModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TouchUiEditViewModel.CreateStaticDefaultValue), new Action(TouchUiEditViewModel.ResetStaticDefaultValue));
		}

		// Token: 0x06045DB3 RID: 286131 RVA: 0x0115E758 File Offset: 0x0115C958
		[NullableContext(2)]
		public static void SetCurrentSelectedItem(ITouchUiEditItem item)
		{
			TouchUiEditViewModel.CurrentSelectedItem = item;
			if (item != null)
			{
				TouchUiEditViewModel.NotifySelectedItemChange(item);
			}
		}

		// Token: 0x06045DB4 RID: 286132 RVA: 0x0115E769 File Offset: 0x0115C969
		[NullableContext(2)]
		public static ITouchUiEditItem GetCurrentSelectedItem()
		{
			return TouchUiEditViewModel.CurrentSelectedItem;
		}

		// Token: 0x06045DB5 RID: 286133 RVA: 0x0115E770 File Offset: 0x0115C970
		public static void AddTouchFingerData(TouchFingerData touchFingerData)
		{
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			TouchUiEditViewModel.TouchFingerDataMap[(int)fingerIndex] = touchFingerData;
		}

		// Token: 0x06045DB6 RID: 286134 RVA: 0x0115E790 File Offset: 0x0115C990
		public static void RemoveTouchFingerData(TouchFingerData touchFingerData)
		{
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			TouchUiEditViewModel.TouchFingerDataMap.Remove((int)fingerIndex);
		}

		// Token: 0x06045DB7 RID: 286135 RVA: 0x0115E7B0 File Offset: 0x0115C9B0
		[NullableContext(2)]
		public static TouchFingerData GetTouchFingerData(int fingerIndex)
		{
			return TouchUiEditViewModel.TouchFingerDataMap.GetValueOrDefault(fingerIndex);
		}

		// Token: 0x06045DB8 RID: 286136 RVA: 0x0115E7BD File Offset: 0x0115C9BD
		public static int GetTouchFingerDataCount()
		{
			return TouchUiEditViewModel.TouchFingerDataMap.Count;
		}

		// Token: 0x06045DB9 RID: 286137 RVA: 0x0115E7C9 File Offset: 0x0115C9C9
		public static void SetRootItem(UUIItem rootItem)
		{
			TouchUiEditViewModel.RootItem = rootItem;
		}

		// Token: 0x06045DBA RID: 286138 RVA: 0x0115E7D1 File Offset: 0x0115C9D1
		[NullableContext(2)]
		public static UUIItem GetRootItem()
		{
			return TouchUiEditViewModel.RootItem;
		}

		// Token: 0x06045DBB RID: 286139 RVA: 0x0115E7D8 File Offset: 0x0115C9D8
		public static void AddDelegateOnSelectedItemChange(Action<ITouchUiEditItem> delegate_)
		{
			TouchUiEditViewModel.DelegatesOnSelectedItemChange.Add(delegate_);
		}

		// Token: 0x06045DBC RID: 286140 RVA: 0x0115E7E8 File Offset: 0x0115C9E8
		public static void RemoveDelegateOnSelectedItemChange(Action<ITouchUiEditItem> delegate_)
		{
			int num = TouchUiEditViewModel.DelegatesOnSelectedItemChange.IndexOf(delegate_);
			if (num != -1)
			{
				TouchUiEditViewModel.DelegatesOnSelectedItemChange.RemoveAt(num);
			}
		}

		// Token: 0x06045DBD RID: 286141 RVA: 0x0115E810 File Offset: 0x0115CA10
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

		// Token: 0x06045DBE RID: 286142 RVA: 0x0115E86C File Offset: 0x0115CA6C
		public static void CreateStaticDefaultValue()
		{
			TouchUiEditViewModel.CurrentSelectedItem = null;
			TouchUiEditViewModel.RootItem = null;
			TouchUiEditViewModel.TouchFingerDataMap = new Dictionary<int, TouchFingerData>();
			TouchUiEditViewModel.DelegatesOnSelectedItemChange = new List<Action<ITouchUiEditItem>>();
		}

		// Token: 0x06045DBF RID: 286143 RVA: 0x0115E88E File Offset: 0x0115CA8E
		public static void ResetStaticDefaultValue()
		{
			TouchUiEditViewModel.CurrentSelectedItem = null;
			TouchUiEditViewModel.RootItem = null;
			TouchUiEditViewModel.TouchFingerDataMap = null;
			TouchUiEditViewModel.DelegatesOnSelectedItemChange = null;
		}

		// Token: 0x0402483C RID: 149564
		[Nullable(2)]
		private static ITouchUiEditItem CurrentSelectedItem;

		// Token: 0x0402483D RID: 149565
		[Nullable(2)]
		private static UUIItem RootItem;

		// Token: 0x0402483E RID: 149566
		private static Dictionary<int, TouchFingerData> TouchFingerDataMap;

		// Token: 0x0402483F RID: 149567
		private static List<Action<ITouchUiEditItem>> DelegatesOnSelectedItemChange;
	}
}
