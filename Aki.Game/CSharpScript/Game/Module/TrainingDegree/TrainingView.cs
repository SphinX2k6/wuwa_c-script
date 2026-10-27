using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrainingDegree
{
	// Token: 0x02004AFA RID: 19194
	[NullableContext(1)]
	[Nullable(0)]
	public class TrainingView
	{
		// Token: 0x06031B5C RID: 203612 RVA: 0x00B8B554 File Offset: 0x00B89754
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

		// Token: 0x06031B5D RID: 203613 RVA: 0x00B8B5CC File Offset: 0x00B897CC
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

		// Token: 0x06031B5E RID: 203614 RVA: 0x00B8B604 File Offset: 0x00B89804
		public void Clear()
		{
			if (this.GenericLayout != null)
			{
				this.GenericLayout.ClearChildren();
			}
			this.GenericLayout = null;
		}

		// Token: 0x0401A8B5 RID: 108725
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<TrainingItem> GenericLayout;
	}
}
