using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200590D RID: 22797
	public class SolarSchoolExamOptionItem : GridProxyAbstract<int>
	{
		// Token: 0x06038341 RID: 230209 RVA: 0x00FB6B44 File Offset: 0x00FB4D44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogOptionStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038342 RID: 230210 RVA: 0x00FB6C4D File Offset: 0x00FB4E4D
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanChoiceChange));
		}

		// Token: 0x06038343 RID: 230211 RVA: 0x00FB6C6C File Offset: 0x00FB4E6C
		private bool OnCanChoiceChange()
		{
			Func<bool> canSelectFunc = this.CanSelectFunc;
			return canSelectFunc == null || canSelectFunc();
		}

		// Token: 0x06038344 RID: 230212 RVA: 0x00FB6C80 File Offset: 0x00FB4E80
		public override void Refresh(int choiceId, bool isSelected, int gridIndex)
		{
			this.ChoiceId = choiceId;
			SolarSchoolExamChoice? examChoice = SolarSchoolConfig.Instance.GetExamChoice(this.ChoiceId);
			if (examChoice == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), examChoice.Value.TextKey, Array.Empty<object>());
			this.SetToggleState(isSelected);
		}

		// Token: 0x06038345 RID: 230213 RVA: 0x00FB6CDC File Offset: 0x00FB4EDC
		public void ShowCorrectness()
		{
			SolarSchoolExamChoice? examChoice = SolarSchoolConfig.Instance.GetExamChoice(this.ChoiceId);
			if (examChoice == null)
			{
				return;
			}
			bool isCorrect = examChoice.Value.IsCorrect;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(isCorrect);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!isCorrect);
		}

		// Token: 0x06038346 RID: 230214 RVA: 0x00FB6D3C File Offset: 0x00FB4F3C
		[NullableContext(1)]
		public override object GetKey(int data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06038347 RID: 230215 RVA: 0x00FB6D44 File Offset: 0x00FB4F44
		public override void OnSelected(bool fireEvent)
		{
			this.SetToggleState(true);
		}

		// Token: 0x06038348 RID: 230216 RVA: 0x00FB6D4D File Offset: 0x00FB4F4D
		public override void OnDeselected(bool fireEvent)
		{
			this.SetToggleState(false);
		}

		// Token: 0x06038349 RID: 230217 RVA: 0x00FB6D58 File Offset: 0x00FB4F58
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

		// Token: 0x0603834A RID: 230218 RVA: 0x00FB6D83 File Offset: 0x00FB4F83
		private void OnTogOptionStateChanged(EToggleState state)
		{
			Action<int, int> onClickChoiceBack = this.OnClickChoiceBack;
			if (onClickChoiceBack == null)
			{
				return;
			}
			onClickChoiceBack(base.GridIndex, this.ChoiceId);
		}

		// Token: 0x0401D96E RID: 121198
		[Nullable(2)]
		public Action<int, int> OnClickChoiceBack;

		// Token: 0x0401D96F RID: 121199
		[Nullable(2)]
		public Func<bool> CanSelectFunc;

		// Token: 0x0401D970 RID: 121200
		private int ChoiceId;

		// Token: 0x0200B4CF RID: 46287
		private class EComponents
		{
			// Token: 0x04037E7A RID: 228986
			public const int TogOption = 0;

			// Token: 0x04037E7B RID: 228987
			public const int TxtContent = 1;

			// Token: 0x04037E7C RID: 228988
			public const int SpriteBg = 2;

			// Token: 0x04037E7D RID: 228989
			public const int PanelCorrect = 3;

			// Token: 0x04037E7E RID: 228990
			public const int PanelWrong = 4;
		}
	}
}
