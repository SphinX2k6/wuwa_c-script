using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058FD RID: 22781
	public class SolarSchoolAffairsOptionItem : GridProxyAbstract<int>
	{
		// Token: 0x06038297 RID: 230039 RVA: 0x00FB2E20 File Offset: 0x00FB1020
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogOptionStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038298 RID: 230040 RVA: 0x00FB2EC6 File Offset: 0x00FB10C6
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanChoiceChange));
		}

		// Token: 0x06038299 RID: 230041 RVA: 0x00FB2EE5 File Offset: 0x00FB10E5
		private bool OnCanChoiceChange()
		{
			Func<bool> canSelectFunc = this.CanSelectFunc;
			return canSelectFunc == null || canSelectFunc();
		}

		// Token: 0x0603829A RID: 230042 RVA: 0x00FB2EF8 File Offset: 0x00FB10F8
		public override void Refresh(int optionId, bool isSelected, int gridIndex)
		{
			this.OptionId = optionId;
			SolarSchoolAffairsOption? affairsOption = SolarSchoolConfig.Instance.GetAffairsOption(this.OptionId);
			if (affairsOption == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), affairsOption.Value.DescKey, Array.Empty<object>());
			this.SetToggleState(isSelected);
		}

		// Token: 0x0603829B RID: 230043 RVA: 0x00FB2F53 File Offset: 0x00FB1153
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x0603829C RID: 230044 RVA: 0x00FB2F5B File Offset: 0x00FB115B
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x0603829D RID: 230045 RVA: 0x00FB2F64 File Offset: 0x00FB1164
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x0603829E RID: 230046 RVA: 0x00FB2F70 File Offset: 0x00FB1170
		private void SetToggleState(bool state)
		{
			EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(state2, false, false, false);
		}

		// Token: 0x0603829F RID: 230047 RVA: 0x00FB2F9B File Offset: 0x00FB119B
		private void OnTogOptionStateChanged(EToggleState state)
		{
			Action<int, int> onClickChoiceBack = this.OnClickChoiceBack;
			if (onClickChoiceBack == null)
			{
				return;
			}
			onClickChoiceBack(base.GridIndex, this.OptionId);
		}

		// Token: 0x0401D91F RID: 121119
		[Nullable(2)]
		public Action<int, int> OnClickChoiceBack;

		// Token: 0x0401D920 RID: 121120
		[Nullable(2)]
		public Func<bool> CanSelectFunc;

		// Token: 0x0401D921 RID: 121121
		private int OptionId;

		// Token: 0x0200B4BB RID: 46267
		private class EComponents
		{
			// Token: 0x04037E22 RID: 228898
			public const int TogOption = 0;

			// Token: 0x04037E23 RID: 228899
			public const int TxtContent = 1;
		}
	}
}
