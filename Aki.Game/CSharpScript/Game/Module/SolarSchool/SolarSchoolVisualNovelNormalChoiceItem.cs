using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VisualNovel;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A75 RID: 23157
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class SolarSchoolVisualNovelNormalChoiceItem : GridProxyAbstract<VisualNovelChoiceOption>
	{
		// Token: 0x060390E6 RID: 233702 RVA: 0x00FFAB18 File Offset: 0x00FF8D18
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnChoiceToggleChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060390E7 RID: 233703 RVA: 0x00FFABBE File Offset: 0x00FF8DBE
		protected override void OnStart()
		{
			base.GetExtendToggle(0).AllowEventBubbleUp = false;
		}

		// Token: 0x060390E8 RID: 233704 RVA: 0x00FFABD0 File Offset: 0x00FF8DD0
		[NullableContext(1)]
		public override void Refresh(VisualNovelChoiceOption option, bool isSelected, int gridIndex)
		{
			base.GridIndex = gridIndex;
			this.IsLocked = (option.State == EVisualNovelChoiceState.Locked);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle.SetSelfInteractive(!this.IsLocked);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), option.TextKey, Array.Empty<object>());
		}

		// Token: 0x060390E9 RID: 233705 RVA: 0x00FFAC2F File Offset: 0x00FF8E2F
		protected override void OnBeforeDestroy()
		{
			this.ChoiceSelected = null;
			this.CanSelect = null;
		}

		// Token: 0x060390EA RID: 233706 RVA: 0x00FFAC40 File Offset: 0x00FF8E40
		private void OnChoiceToggleChanged(EToggleState toggleState)
		{
			if (toggleState != EToggleState.ETT_Checked)
			{
				return;
			}
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			if (!this.IsLocked)
			{
				Func<bool> canSelect = this.CanSelect;
				if (canSelect == null || canSelect())
				{
					Action<int> choiceSelected = this.ChoiceSelected;
					if (choiceSelected == null)
					{
						return;
					}
					choiceSelected(base.GridIndex);
					return;
				}
			}
		}

		// Token: 0x0401E055 RID: 122965
		public Action<int> ChoiceSelected;

		// Token: 0x0401E056 RID: 122966
		public Func<bool> CanSelect;

		// Token: 0x0401E057 RID: 122967
		private bool IsLocked;

		// Token: 0x0200B676 RID: 46710
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403872F RID: 231215
			public const int ChoiceToggle = 0;

			// Token: 0x04038730 RID: 231216
			public const int ContentText = 1;
		}
	}
}
