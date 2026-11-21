using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005391 RID: 21393
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightItemSmallGrid : LoopScrollSmallItemGrid<MotorFightItemData>
	{
		// Token: 0x170067D7 RID: 26583
		// (get) Token: 0x060353B4 RID: 218036 RVA: 0x00EDD579 File Offset: 0x00EDB779
		public new MotorFightItemData Data
		{
			get
			{
				return this.Data as MotorFightItemData;
			}
		}

		// Token: 0x060353B5 RID: 218037 RVA: 0x00EDD588 File Offset: 0x00EDB788
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

		// Token: 0x060353B6 RID: 218038 RVA: 0x00EDD6F4 File Offset: 0x00EDB8F4
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

		// Token: 0x060353B7 RID: 218039 RVA: 0x00EDD7A8 File Offset: 0x00EDB9A8
		private void OnClickToggle(EToggleState _)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(7);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			UiManager.Instance.OpenView(EUiViewName.MotorFightItemTips, this.Data, null);
		}

		// Token: 0x0200B01E RID: 45086
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040366CB RID: 222923
			public const int SpriteQuality = 0;

			// Token: 0x040366CC RID: 222924
			public const int TextureIcon = 1;

			// Token: 0x040366CD RID: 222925
			public const int ItemTextPanel = 2;

			// Token: 0x040366CE RID: 222926
			public const int TextNum = 3;

			// Token: 0x040366CF RID: 222927
			public const int SpriteBg = 4;

			// Token: 0x040366D0 RID: 222928
			public const int ItemBottomAddPanel = 5;

			// Token: 0x040366D1 RID: 222929
			public const int ItemAddPanel = 6;

			// Token: 0x040366D2 RID: 222930
			public const int ToggleRoot = 7;
		}
	}
}
