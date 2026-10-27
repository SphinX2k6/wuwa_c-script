using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BDE RID: 23518
	public class CiacconaGalReChooseChoiceList : UiPanelBase
	{
		// Token: 0x0603B73B RID: 243515 RVA: 0x00E2CFE8 File Offset: 0x00E2B1E8
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

		// Token: 0x0603B73C RID: 243516 RVA: 0x00E2D051 File Offset: 0x00E2B251
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<CiacconaGalReChooseChoiceItem, ICiacconaGalReChooseChoiceParam>(base.GetVerticalLayout(0), new Func<CiacconaGalReChooseChoiceItem>(this.GetChoiceItem), null, false, true);
		}

		// Token: 0x0603B73D RID: 243517 RVA: 0x00E2D074 File Offset: 0x00E2B274
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

		// Token: 0x0603B73E RID: 243518 RVA: 0x00E2D0F1 File Offset: 0x00E2B2F1
		[NullableContext(1)]
		private CiacconaGalReChooseChoiceItem GetChoiceItem()
		{
			return new CiacconaGalReChooseChoiceItem();
		}

		// Token: 0x0401EF99 RID: 126873
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CiacconaGalReChooseChoiceItem, ICiacconaGalReChooseChoiceParam> Layout;

		// Token: 0x0200BDBD RID: 48573
		public class EChoiceListComponentDefine
		{
			// Token: 0x04039378 RID: 234360
			public const int LayoutList = 0;

			// Token: 0x04039379 RID: 234361
			public const int ItemChoice = 1;
		}
	}
}
