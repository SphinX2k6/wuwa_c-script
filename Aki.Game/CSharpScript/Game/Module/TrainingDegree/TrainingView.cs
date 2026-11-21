using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrainingDegree
{
	// Token: 0x02003AA2 RID: 15010
	[NullableContext(1)]
	[Nullable(0)]
	public class TrainingView
	{
		// Token: 0x060268EC RID: 157932 RVA: 0x00ACF5B0 File Offset: 0x00ACD7B0
		public void Show(UUILayoutBase layout, [Nullable(new byte[]
		{
			2,
			1
		})] IReadOnlyList<TrainingData> inDataList = null)
		{
			if (layout == null)
			{
				return;
			}
			UUIItem uuiitem = layout.RootUIComp.Get();
			IReadOnlyList<TrainingData> readOnlyList = inDataList ?? TrainingDegreeModel.Instance.GetTrainingDataList();
			if (readOnlyList == null && uuiitem != null)
			{
				uuiitem.SetUIActive(false);
			}
			this.GenericLayout = new GenericLayoutNew<TrainingItem>(layout, new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<TrainingItem>(this.InitTrainingItem), null);
			this.GenericLayout.RebuildLayoutByDataNew<TrainingData>(readOnlyList, null);
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(true);
			}
		}

		// Token: 0x060268ED RID: 157933 RVA: 0x00ACF628 File Offset: 0x00ACD828
		private ILayoutItem<TrainingItem> InitTrainingItem(object data, UUIItem uiItem, int index)
		{
			TrainingItem trainingItem = new TrainingItem(uiItem);
			trainingItem.SetData((TrainingData)data);
			return new LayoutItem<TrainingItem>
			{
				Key = index,
				Value = trainingItem
			};
		}

		// Token: 0x060268EE RID: 157934 RVA: 0x00ACF660 File Offset: 0x00ACD860
		public void Clear()
		{
			if (this.GenericLayout != null)
			{
				this.GenericLayout.ClearChildren();
			}
			this.GenericLayout = null;
		}

		// Token: 0x04015207 RID: 86535
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<TrainingItem> GenericLayout;
	}
}
