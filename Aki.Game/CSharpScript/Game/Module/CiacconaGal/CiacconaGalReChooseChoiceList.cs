using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BBE RID: 19390
	public class CiacconaGalReChooseChoiceList : UiPanelBase
	{
		// Token: 0x06030686 RID: 198278 RVA: 0x00D7D2F0 File Offset: 0x00D7B4F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030687 RID: 198279 RVA: 0x00D7D359 File Offset: 0x00D7B559
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<CiacconaGalReChooseChoiceItem, ICiacconaGalReChooseChoiceParam>(base.GetVerticalLayout(0), new Func<CiacconaGalReChooseChoiceItem>(this.GetChoiceItem), null, false, true);
		}

		// Token: 0x06030688 RID: 198280 RVA: 0x00D7D37C File Offset: 0x00D7B57C
		[NullableContext(1)]
		public void Refresh(Action onRestart, Action onReturn)
		{
			this.Layout.RefreshByData(new <>z__ReadOnlyArray<ICiacconaGalReChooseChoiceParam>(new ICiacconaGalReChooseChoiceParam[]
			{
				new CiacconaGalReChooseChoiceParam
				{
					Text = "Xkjsx_Option_Reselection",
					TogState = EToggleState.ETT_UnChecked,
					IconResId = "T_PlotReasoningIcon03",
					OnClick = onRestart
				},
				new CiacconaGalReChooseChoiceParam
				{
					Text = "Xkjsx_Option_Cancel",
					TogState = EToggleState.ETT_UnChecked,
					IconResId = "T_PlotReasoningIcon05",
					OnClick = onReturn
				}
			}), null, false);
		}

		// Token: 0x06030689 RID: 198281 RVA: 0x00D7D3F9 File Offset: 0x00D7B5F9
		[NullableContext(1)]
		private CiacconaGalReChooseChoiceItem GetChoiceItem()
		{
			return new CiacconaGalReChooseChoiceItem();
		}

		// Token: 0x04019A4A RID: 105034
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CiacconaGalReChooseChoiceItem, ICiacconaGalReChooseChoiceParam> Layout;

		// Token: 0x0200A7C6 RID: 42950
		public class EChoiceListComponentDefine
		{
			// Token: 0x04033D3D RID: 212285
			public const int LayoutList = 0;

			// Token: 0x04033D3E RID: 212286
			public const int ItemChoice = 1;
		}
	}
}
