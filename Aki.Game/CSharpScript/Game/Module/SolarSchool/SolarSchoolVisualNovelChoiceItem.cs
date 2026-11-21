using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VisualNovel;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A6B RID: 23147
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class SolarSchoolVisualNovelChoiceItem : GridProxyAbstract<VisualNovelChoiceOption>
	{
		// Token: 0x06039055 RID: 233557 RVA: 0x00FF8BF4 File Offset: 0x00FF6DF4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnChoiceToggleChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06039056 RID: 233558 RVA: 0x00FF8D60 File Offset: 0x00FF6F60
		public override void Refresh(VisualNovelChoiceOption option, bool isSelected, int gridIndex)
		{
			base.GridIndex = gridIndex;
			this.IsLocked = (option.State == EVisualNovelChoiceState.Locked);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle.SetSelfInteractive(!this.IsLocked);
			base.GetItem(1).SetUIActive(!this.IsLocked);
			base.GetItem(2).SetUIActive(this.IsLocked);
			base.GetItem(4).SetUIActive(!string.IsNullOrEmpty(option.ConditionText));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), option.TextKey, Array.Empty<object>());
			base.GetText(6).SetText(option.ConditionText, true);
			this.RefreshStateSprite(option);
		}

		// Token: 0x06039057 RID: 233559 RVA: 0x00FF8E1A File Offset: 0x00FF701A
		protected override void OnBeforeDestroy()
		{
			this.ChoiceSelected = null;
			this.CanSelect = null;
		}

		// Token: 0x06039058 RID: 233560 RVA: 0x00FF8E2C File Offset: 0x00FF702C
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

		// Token: 0x06039059 RID: 233561 RVA: 0x00FF8E88 File Offset: 0x00FF7088
		private void RefreshStateSprite(VisualNovelChoiceOption option)
		{
			UUISprite sprite = base.GetSprite(7);
			if (option.State == EVisualNovelChoiceState.Locked)
			{
				sprite.SetUIActive(false);
				return;
			}
			string resourceId = (option.State == EVisualNovelChoiceState.Selected) ? "SP_SolarSchoolExamCheck" : "SP_SolarSchoolExamGoto";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			if (string.IsNullOrEmpty(resourcePath))
			{
				sprite.SetUIActive(false);
				return;
			}
			base.TrySetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x0401E01D RID: 122909
		private const string SELECTED_STATE_SPRITE_RESOURCE_ID = "SP_SolarSchoolExamCheck";

		// Token: 0x0401E01E RID: 122910
		private const string UNSELECTED_STATE_SPRITE_RESOURCE_ID = "SP_SolarSchoolExamGoto";

		// Token: 0x0401E01F RID: 122911
		[Nullable(2)]
		public Action<int> ChoiceSelected;

		// Token: 0x0401E020 RID: 122912
		[Nullable(2)]
		public Func<bool> CanSelect;

		// Token: 0x0401E021 RID: 122913
		private bool IsLocked;

		// Token: 0x0200B660 RID: 46688
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040386B3 RID: 231091
			public const int ChoiceToggle = 0;

			// Token: 0x040386B4 RID: 231092
			public const int UnlockRootItem = 1;

			// Token: 0x040386B5 RID: 231093
			public const int LockRootItem = 2;

			// Token: 0x040386B6 RID: 231094
			public const int ContentText = 3;

			// Token: 0x040386B7 RID: 231095
			public const int LockTipRootItem = 4;

			// Token: 0x040386B8 RID: 231096
			public const int LockTipTexture = 5;

			// Token: 0x040386B9 RID: 231097
			public const int LockTipText = 6;

			// Token: 0x040386BA RID: 231098
			public const int StateSprite = 7;
		}
	}
}
