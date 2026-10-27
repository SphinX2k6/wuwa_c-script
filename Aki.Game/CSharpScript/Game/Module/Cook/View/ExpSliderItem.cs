using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02005B27 RID: 23335
	public class ExpSliderItem : UiPanelBase
	{
		// Token: 0x0603B14E RID: 241998 RVA: 0x00E16722 File Offset: 0x00E14922
		[NullableContext(1)]
		public ExpSliderItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603B14F RID: 241999 RVA: 0x00E16738 File Offset: 0x00E14938
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B150 RID: 242000 RVA: 0x00E167C4 File Offset: 0x00E149C4
		public void Update()
		{
			ICookerInfoData cookerInfo = CookModel.Instance.GetCookerInfo();
			int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(CookModel.Instance.GetCookerInfo().CookingLevel);
			double num = MathUtils.Instance.GetFloatPointFloor((double)cookerInfo.TotalProficiencys / (double)sumExpByLevel, 3);
			num = ((num > 1.0) ? 1.0 : num);
			base.GetSprite(0).SetFillAmount((float)num);
			base.GetText(1).SetText(cookerInfo.AddExp.ToString(), true);
			base.GetText(2).SetText(cookerInfo.AddExp.ToString(), true);
			LguiUtil.Instance.SetLocalText(base.GetText(2), "CookProgressText", new <>z__ReadOnlyArray<object>(new object[]
			{
				cookerInfo.TotalProficiencys,
				sumExpByLevel
			}));
		}
	}
}
