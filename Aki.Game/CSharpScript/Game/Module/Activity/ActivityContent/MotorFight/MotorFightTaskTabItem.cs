using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200539C RID: 21404
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTaskTabItem : GridProxyAbstract<MotorFightTaskTab>
	{
		// Token: 0x060353FD RID: 218109 RVA: 0x00EDF918 File Offset: 0x00EDDB18
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060353FE RID: 218110 RVA: 0x00EDF9E0 File Offset: 0x00EDDBE0
		public override void Refresh(MotorFightTaskTab data, bool isSelected, int gridIndex)
		{
			this.Data = new MotorFightTaskTab?(data);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TabTitle, Array.Empty<object>());
			bool uiactive = this.ActivityData.IsTaskHasRedDotByTab(data.Id);
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x060353FF RID: 218111 RVA: 0x00EDFA3C File Offset: 0x00EDDC3C
		private void OnToggleClick(EToggleState _)
		{
			this.OnToggleClickCallBack(this.Data.Value.Id);
		}

		// Token: 0x06035400 RID: 218112 RVA: 0x00EDFA67 File Offset: 0x00EDDC67
		public override object GetKey(MotorFightTaskTab data, int displayIndex)
		{
			return data.Id;
		}

		// Token: 0x06035401 RID: 218113 RVA: 0x00EDFA78 File Offset: 0x00EDDC78
		public void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
		}

		// Token: 0x06035402 RID: 218114 RVA: 0x00EDFA9E File Offset: 0x00EDDC9E
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06035403 RID: 218115 RVA: 0x00EDFAA7 File Offset: 0x00EDDCA7
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x0401C155 RID: 115029
		private MotorFightTaskTab? Data;

		// Token: 0x0401C156 RID: 115030
		public MotorFightActivityData ActivityData;

		// Token: 0x0401C157 RID: 115031
		public Action<int> OnToggleClickCallBack = delegate(int tabId)
		{
		};

		// Token: 0x0200B030 RID: 45104
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036734 RID: 223028
			public const int ToggleRoot = 0;

			// Token: 0x04036735 RID: 223029
			public const int TextTabName = 1;

			// Token: 0x04036736 RID: 223030
			public const int ItemRedDot = 2;
		}
	}
}
