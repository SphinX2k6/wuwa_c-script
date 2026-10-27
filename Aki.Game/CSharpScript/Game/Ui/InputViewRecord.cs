using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046B2 RID: 18098
	public class InputViewRecord
	{
		// Token: 0x0602EACB RID: 191179 RVA: 0x00ACD7B8 File Offset: 0x00ACB9B8
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

		// Token: 0x0602EACC RID: 191180 RVA: 0x00ACD7F8 File Offset: 0x00ACB9F8
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

		// Token: 0x0602EACD RID: 191181 RVA: 0x00ACD83C File Offset: 0x00ACBA3C
		public bool Has(EUiViewName viewName)
		{
			int num;
			return this.ViewRecordMap.TryGetValue(viewName, out num) && num > 0;
		}

		// Token: 0x0602EACE RID: 191182 RVA: 0x00ACD860 File Offset: 0x00ACBA60
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

		// Token: 0x0602EACF RID: 191183 RVA: 0x00ACD8BC File Offset: 0x00ACBABC
		public int Size()
		{
			return this.ViewRecordMap.Count;
		}

		// Token: 0x0602EAD0 RID: 191184 RVA: 0x00ACD8C9 File Offset: 0x00ACBAC9
		public void Clear()
		{
			this.ViewRecordMap.Clear();
		}

		// Token: 0x040196A8 RID: 104104
		[Nullable(1)]
		private readonly Dictionary<EUiViewName, int> ViewRecordMap = new Dictionary<EUiViewName, int>();
	}
}
