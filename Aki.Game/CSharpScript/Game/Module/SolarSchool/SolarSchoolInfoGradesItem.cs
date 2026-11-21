using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059B4 RID: 22964
	public class SolarSchoolInfoGradesItem : UiPanelBase
	{
		// Token: 0x060389BA RID: 231866 RVA: 0x00FD6EF0 File Offset: 0x00FD50F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060389BB RID: 231867 RVA: 0x00FD6F9C File Offset: 0x00FD519C
		public void Refresh(SolarSchoolInfoGradesData data)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), data.HasResult ? data.RankTextId : null, new <>z__ReadOnlySingleElementList<object>(data.Rank));
			string path = data.HasResult ? data.RankIconPath : null;
			base.TrySetTextureByPath(path, base.GetTexture(0), null, null);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(!data.HasResult);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(data.HasResult);
		}

		// Token: 0x0200B55F RID: 46431
		private class EComponent
		{
			// Token: 0x04038140 RID: 229696
			public const int TexScore = 0;

			// Token: 0x04038141 RID: 229697
			public const int TxtRank = 1;

			// Token: 0x04038142 RID: 229698
			public const int ItemScoreEmpty = 2;

			// Token: 0x04038143 RID: 229699
			public const int ItemName = 3;
		}
	}
}
