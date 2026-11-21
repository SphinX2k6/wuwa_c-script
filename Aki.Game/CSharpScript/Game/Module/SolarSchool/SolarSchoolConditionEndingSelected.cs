using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005897 RID: 22679
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionEndingSelected : ActivityConditionBase
	{
		// Token: 0x06037E0B RID: 228875 RVA: 0x00FA044C File Offset: 0x00F9E64C
		protected override bool OnInitialize(ConditionParams p)
		{
			this.EndingIds = p.GetIntList("EndingIds").ToArray();
			return true;
		}

		// Token: 0x06037E0C RID: 228876 RVA: 0x00FA0468 File Offset: 0x00F9E668
		protected override bool OnCheck()
		{
			IReadOnlyList<int> selectedEndingIds = SolarSchoolGamePlayModel.Instance.SelectedEndingIds;
			if (selectedEndingIds.Count == 0)
			{
				return false;
			}
			foreach (int num in this.EndingIds)
			{
				for (int j = 0; j < selectedEndingIds.Count; j++)
				{
					if (selectedEndingIds[j] == num)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06037E0D RID: 228877 RVA: 0x00FA04C6 File Offset: 0x00F9E6C6
		protected override void OnClear()
		{
			this.EndingIds = Array.Empty<int>();
		}

		// Token: 0x0401D7D3 RID: 120787
		private int[] EndingIds = Array.Empty<int>();
	}
}
