using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035E3 RID: 13795
	public class InputViewRecord
	{
		// Token: 0x06023217 RID: 143895 RVA: 0x009FC08C File Offset: 0x009FA28C
		public int Add(EUiViewName viewName)
		{
			int num;
			if (this.ViewRecordMap.TryGetValue(viewName, out num))
			{
				int num2 = num + 1;
				this.ViewRecordMap[viewName] = num2;
				return num2;
			}
			this.ViewRecordMap[viewName] = 1;
			return 1;
		}

		// Token: 0x06023218 RID: 143896 RVA: 0x009FC0CC File Offset: 0x009FA2CC
		public int Remove(EUiViewName viewName)
		{
			int num;
			if (!this.ViewRecordMap.TryGetValue(viewName, out num))
			{
				return 0;
			}
			int num2 = num - 1;
			if (num2 > 0)
			{
				this.ViewRecordMap[viewName] = num2;
			}
			else
			{
				this.ViewRecordMap.Remove(viewName);
			}
			return num2;
		}

		// Token: 0x06023219 RID: 143897 RVA: 0x009FC110 File Offset: 0x009FA310
		public bool Has(EUiViewName viewName)
		{
			int num;
			return this.ViewRecordMap.TryGetValue(viewName, out num) && num > 0;
		}

		// Token: 0x0602321A RID: 143898 RVA: 0x009FC134 File Offset: 0x009FA334
		public bool HasAny()
		{
			using (Dictionary<EUiViewName, int>.ValueCollection.Enumerator enumerator = this.ViewRecordMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current > 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0602321B RID: 143899 RVA: 0x009FC190 File Offset: 0x009FA390
		public int Size()
		{
			return this.ViewRecordMap.Count;
		}

		// Token: 0x0602321C RID: 143900 RVA: 0x009FC19D File Offset: 0x009FA39D
		public void Clear()
		{
			this.ViewRecordMap.Clear();
		}

		// Token: 0x04013D4D RID: 81229
		[Nullable(1)]
		private readonly Dictionary<EUiViewName, int> ViewRecordMap = new Dictionary<EUiViewName, int>();
	}
}
