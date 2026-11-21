using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050E2 RID: 20706
	public class RoverlikeCommonButton : UiPanelBase
	{
		// Token: 0x06033D1F RID: 212255 RVA: 0x00E813BC File Offset: 0x00E7F5BC
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

		// Token: 0x06033D20 RID: 212256 RVA: 0x00E814A4 File Offset: 0x00E7F6A4
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06033D21 RID: 212257 RVA: 0x00E814B8 File Offset: 0x00E7F6B8
		[NullableContext(1)]
		public void SetClickCallback(Action callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06033D22 RID: 212258 RVA: 0x00E814C4 File Offset: 0x00E7F6C4
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

		// Token: 0x06033D23 RID: 212259 RVA: 0x00E81503 File Offset: 0x00E7F703
		private void OnClick()
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}

		// Token: 0x0401B736 RID: 112438
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly IReadOnlyList<FColor> CommonButtonColors = new List<FColor>
		{
			FColor.FromHex("#469ffb"),
			FColor.FromHex("#7960ff"),
			FColor.FromHex("#f22647")
		};

		// Token: 0x0401B737 RID: 112439
		[Nullable(2)]
		private Action ClickCallback;

		// Token: 0x0200ADAF RID: 44463
		private class ERoverlikeCommonButton
		{
			// Token: 0x04035AA1 RID: 219809
			public const int BtnCommon = 0;

			// Token: 0x04035AA2 RID: 219810
			public const int TxtName = 1;

			// Token: 0x04035AA3 RID: 219811
			public const int RedDot = 2;

			// Token: 0x04035AA4 RID: 219812
			public const int SprColor = 3;
		}
	}
}
