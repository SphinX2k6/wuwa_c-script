using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BD5 RID: 23509
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalStepChoiceList : UiPanelBase
	{
		// Token: 0x0603B6EF RID: 243439 RVA: 0x00E2C0F8 File Offset: 0x00E2A2F8
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

		// Token: 0x0603B6F0 RID: 243440 RVA: 0x00E2C161 File Offset: 0x00E2A361
		protected override void OnStart()
		{
			this.LayoutList = new GenericLayout<GridProxyAbstract<CiacconaGalChoiceData>, CiacconaGalChoiceData>(base.GetVerticalLayout(0), new Func<GridProxyAbstract<CiacconaGalChoiceData>>(this.GetChoiceItem), null, false, true);
			EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0603B6F1 RID: 243441 RVA: 0x00E2C1A0 File Offset: 0x00E2A3A0
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0603B6F2 RID: 243442 RVA: 0x00E2C1C0 File Offset: 0x00E2A3C0
		public void Refresh(CiacconaGalStepData stepData)
		{
			this.StepData = stepData;
			this.ChoicesDataList.Clear();
			bool flag = false;
			foreach (int id in stepData.ChoiceIds)
			{
				CiacconaGalChoiceData choiceDataById = CiacconaGalModel.Instance.GetChoiceDataById(id);
				this.ChoicesDataList.Add(choiceDataById);
				if (choiceDataById.NeedInspiration)
				{
					flag = true;
				}
			}
			if (flag)
			{
				EventSystem.Instance.Emit<bool>(EEventName.OnCiacconaAvgInspirationChoiceShow, true);
			}
			this.LayoutList.RefreshByData(this.ChoicesDataList, null, false);
		}

		// Token: 0x0603B6F3 RID: 243443 RVA: 0x00E2C246 File Offset: 0x00E2A446
		private CiacconaGalStepChoiceItem GetChoiceItem()
		{
			return new CiacconaGalStepChoiceItem();
		}

		// Token: 0x0603B6F4 RID: 243444 RVA: 0x00E2C24D File Offset: 0x00E2A44D
		private void OnDataUpdate()
		{
			if (this.StepData != null)
			{
				this.Refresh(this.StepData);
			}
		}

		// Token: 0x0603B6F5 RID: 243445 RVA: 0x00E2C264 File Offset: 0x00E2A464
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams.Length == 0)
			{
				return null;
			}
			if (configParams[0] == "FirstChoice" && this.ChoicesDataList.Count > 1)
			{
				GenericLayout<GridProxyAbstract<CiacconaGalChoiceData>, CiacconaGalChoiceData> layoutList = this.LayoutList;
				UUIItem uuiitem = (layoutList != null) ? layoutList.GetGridByDisplayIndex(0) : null;
				if (uuiitem != null)
				{
					return new UUIItem[]
					{
						uuiitem,
						uuiitem
					};
				}
			}
			return null;
		}

		// Token: 0x0401EF81 RID: 126849
		private List<CiacconaGalChoiceData> ChoicesDataList = new List<CiacconaGalChoiceData>();

		// Token: 0x0401EF82 RID: 126850
		[Nullable(2)]
		private CiacconaGalStepData StepData;

		// Token: 0x0401EF83 RID: 126851
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private GenericLayout<GridProxyAbstract<CiacconaGalChoiceData>, CiacconaGalChoiceData> LayoutList;

		// Token: 0x0200BDAF RID: 48559
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403934A RID: 234314
			public const int LayoutList = 0;

			// Token: 0x0403934B RID: 234315
			public const int ItemChoice = 1;
		}
	}
}
