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
	// Token: 0x02004BB5 RID: 19381
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalStepChoiceList : UiPanelBase
	{
		// Token: 0x0603063A RID: 198202 RVA: 0x00D7C400 File Offset: 0x00D7A600
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

		// Token: 0x0603063B RID: 198203 RVA: 0x00D7C469 File Offset: 0x00D7A669
		protected override void OnStart()
		{
			this.LayoutList = new GenericLayout<GridProxyAbstract<CiacconaGalChoiceData>, CiacconaGalChoiceData>(base.GetVerticalLayout(0), new Func<GridProxyAbstract<CiacconaGalChoiceData>>(this.GetChoiceItem), null, false, true);
			EventSystem.Instance.Add(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0603063C RID: 198204 RVA: 0x00D7C4A8 File Offset: 0x00D7A6A8
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaChapterDataUpdate, new Action(this.OnDataUpdate));
		}

		// Token: 0x0603063D RID: 198205 RVA: 0x00D7C4C8 File Offset: 0x00D7A6C8
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

		// Token: 0x0603063E RID: 198206 RVA: 0x00D7C54E File Offset: 0x00D7A74E
		private CiacconaGalStepChoiceItem GetChoiceItem()
		{
			return new CiacconaGalStepChoiceItem();
		}

		// Token: 0x0603063F RID: 198207 RVA: 0x00D7C555 File Offset: 0x00D7A755
		private void OnDataUpdate()
		{
			if (this.StepData != null)
			{
				this.Refresh(this.StepData);
			}
		}

		// Token: 0x06030640 RID: 198208 RVA: 0x00D7C56C File Offset: 0x00D7A76C
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

		// Token: 0x04019A32 RID: 105010
		private List<CiacconaGalChoiceData> ChoicesDataList = new List<CiacconaGalChoiceData>();

		// Token: 0x04019A33 RID: 105011
		[Nullable(2)]
		private CiacconaGalStepData StepData;

		// Token: 0x04019A34 RID: 105012
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private GenericLayout<GridProxyAbstract<CiacconaGalChoiceData>, CiacconaGalChoiceData> LayoutList;

		// Token: 0x0200A7B8 RID: 42936
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04033D0F RID: 212239
			public const int LayoutList = 0;

			// Token: 0x04033D10 RID: 212240
			public const int ItemChoice = 1;
		}
	}
}
