using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x0200580B RID: 22539
	public class RewardExploreToggle : UiPanelBase
	{
		// Token: 0x060394A8 RID: 234664 RVA: 0x00D96564 File Offset: 0x00D94764
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060394A9 RID: 234665 RVA: 0x00D965CD File Offset: 0x00D947CD
		protected override void OnStart()
		{
			this.StateToggle = base.GetExtendToggle(1);
		}

		// Token: 0x060394AA RID: 234666 RVA: 0x00D965DC File Offset: 0x00D947DC
		protected override void OnBeforeDestroy()
		{
			this.StateToggle = null;
		}

		// Token: 0x060394AB RID: 234667 RVA: 0x00D965E5 File Offset: 0x00D947E5
		[NullableContext(1)]
		public void Refresh(IRewardExploreToggle toggleData)
		{
			if (toggleData.OnToggleClick != null)
			{
				this.StateToggle.OnStateChange.Add(toggleData.OnToggleClick);
			}
			if (!StringUtils.IsEmpty(toggleData.DescriptionTextId))
			{
				this.SetTitleText(toggleData.DescriptionTextId);
			}
		}

		// Token: 0x060394AC RID: 234668 RVA: 0x00D96624 File Offset: 0x00D94824
		[NullableContext(1)]
		private void SetTitleText(string titleTextId)
		{
			if (StringUtils.IsEmpty(titleTextId))
			{
				return;
			}
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, titleTextId, Array.Empty<object>());
		}

		// Token: 0x060394AD RID: 234669 RVA: 0x00D96654 File Offset: 0x00D94854
		public EToggleState? GetToggleState()
		{
			UUIExtendToggle stateToggle = this.StateToggle;
			if (stateToggle == null)
			{
				return null;
			}
			return new EToggleState?(stateToggle.GetToggleState());
		}

		// Token: 0x0401DF5A RID: 122714
		[Nullable(2)]
		private UUIExtendToggle StateToggle;

		// Token: 0x0200BA0C RID: 47628
		private class EChildType
		{
			// Token: 0x040383C4 RID: 230340
			public const int TitleText = 0;

			// Token: 0x040383C5 RID: 230341
			public const int StateToggle = 1;
		}
	}
}
