using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006164 RID: 24932
	public class RoverlikeCommonButton : UiPanelBase
	{
		// Token: 0x0603F05F RID: 258143 RVA: 0x00F3A4E8 File Offset: 0x00F386E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F060 RID: 258144 RVA: 0x00F3A5D0 File Offset: 0x00F387D0
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603F061 RID: 258145 RVA: 0x00F3A5E4 File Offset: 0x00F387E4
		[NullableContext(1)]
		public void SetClickCallback(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x0603F062 RID: 258146 RVA: 0x00F3A5F0 File Offset: 0x00F387F0
		public void RefreshByDifficulty(int difficulty)
		{
			int index = Math.Min(Math.Max(((difficulty == 0) ? 1 : difficulty) - 1, 0), 2);
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return;
			}
			sprite.SetColor(RoverlikeCommonButton.CommonButtonColors[index]);
		}

		// Token: 0x0603F063 RID: 258147 RVA: 0x00F3A62F File Offset: 0x00F3882F
		private void OnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x04020E09 RID: 134665
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<FColor> CommonButtonColors = new List<FColor>
		{
			FColor.FromHex("#469ffb"),
			FColor.FromHex("#7960ff"),
			FColor.FromHex("#f22647")
		};

		// Token: 0x04020E0A RID: 134666
		[Nullable(2)]
		private Action ClickCallback;

		// Token: 0x0200C3C8 RID: 50120
		private class ERoverlikeCommonButton
		{
			// Token: 0x0403B140 RID: 241984
			public const int BtnCommon = 0;

			// Token: 0x0403B141 RID: 241985
			public const int TxtName = 1;

			// Token: 0x0403B142 RID: 241986
			public const int RedDot = 2;

			// Token: 0x0403B143 RID: 241987
			public const int SprColor = 3;
		}
	}
}
