using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A65 RID: 23141
	public sealed class SolarSchoolCharacterIntroduceItem : UiPanelBase
	{
		// Token: 0x06039021 RID: 233505 RVA: 0x00FF806C File Offset: 0x00FF626C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039022 RID: 233506 RVA: 0x00FF8138 File Offset: 0x00FF6338
		[NullableContext(1)]
		public void Show(string characterNameTextKey, string influenceTextKey, string influenceColor, string introductionTextKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), characterNameTextKey, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), influenceTextKey, Array.Empty<object>());
			if (!string.IsNullOrEmpty(influenceColor))
			{
				base.GetSprite(2).SetColor(FColor.FromHex(influenceColor));
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), introductionTextKey, Array.Empty<object>());
			base.SetUiActive(true);
		}

		// Token: 0x06039023 RID: 233507 RVA: 0x00FF81AC File Offset: 0x00FF63AC
		public void Hide()
		{
			base.SetUiActive(false);
		}

		// Token: 0x0200B656 RID: 46678
		private static class EComponents
		{
			// Token: 0x04038680 RID: 231040
			public const int CharacterNameText = 0;

			// Token: 0x04038681 RID: 231041
			public const int TagItem = 1;

			// Token: 0x04038682 RID: 231042
			public const int TagBackgroundSprite = 2;

			// Token: 0x04038683 RID: 231043
			public const int TagText = 3;

			// Token: 0x04038684 RID: 231044
			public const int DescriptionText = 4;
		}
	}
}
