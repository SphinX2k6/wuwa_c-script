using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B08 RID: 19208
	public class ExpSliderItem : UiPanelBase
	{
		// Token: 0x060300C0 RID: 196800 RVA: 0x00D6743A File Offset: 0x00D6563A
		[NullableContext(1)]
		public ExpSliderItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060300C1 RID: 196801 RVA: 0x00D67450 File Offset: 0x00D65650
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

		// Token: 0x060300C2 RID: 196802 RVA: 0x00D674DC File Offset: 0x00D656DC
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
