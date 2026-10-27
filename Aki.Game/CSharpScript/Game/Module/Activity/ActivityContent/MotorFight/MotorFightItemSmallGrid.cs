using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02006413 RID: 25619
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightItemSmallGrid : LoopScrollSmallItemGrid<MotorFightItemData>
	{
		// Token: 0x17009475 RID: 38005
		// (get) Token: 0x060406F3 RID: 263923 RVA: 0x00F965D9 File Offset: 0x00F947D9
		public new MotorFightItemData Data
		{
			get
			{
				return this.Data as MotorFightItemData;
			}
		}

		// Token: 0x060406F4 RID: 263924 RVA: 0x00F965E8 File Offset: 0x00F947E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIExtendToggle));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060406F5 RID: 263925 RVA: 0x00F96754 File Offset: 0x00F94954
		[NullableContext(1)]
		protected override void OnRefresh(MotorFightItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.SetSpriteByPath(MotorFightConfig.Instance.GetMotorFightQuality(data.Quality).Value.SmallGridBg, base.GetSprite(0), false, null, null);
			base.SetTextureByPath(data.Icon, base.GetTexture(1), null, null);
			UUIText text = base.GetText(3);
			if (text != null)
			{
				text.SetText(data.Count.ToString(), true);
			}
			base.SetLeftTopIconVisible(MotorFightConfig.Instance.GetMotorFightItemType(data.Type).Value.Icon);
		}

		// Token: 0x060406F6 RID: 263926 RVA: 0x00F96808 File Offset: 0x00F94A08
		private void OnClickToggle(EToggleState _)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			UiManager.Instance.OpenView(EUiViewName.MotorFightItemTips, this.Data, null);
		}

		// Token: 0x0200C637 RID: 50743
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BD6E RID: 245102
			public const int SpriteQuality = 0;

			// Token: 0x0403BD6F RID: 245103
			public const int TextureIcon = 1;

			// Token: 0x0403BD70 RID: 245104
			public const int ItemTextPanel = 2;

			// Token: 0x0403BD71 RID: 245105
			public const int TextNum = 3;

			// Token: 0x0403BD72 RID: 245106
			public const int SpriteBg = 4;

			// Token: 0x0403BD73 RID: 245107
			public const int ItemBottomAddPanel = 5;

			// Token: 0x0403BD74 RID: 245108
			public const int ItemAddPanel = 6;

			// Token: 0x0403BD75 RID: 245109
			public const int ToggleRoot = 7;
		}
	}
}
