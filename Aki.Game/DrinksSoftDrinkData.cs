using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003FF RID: 1023
[NullableContext(1)]
[Nullable(0)]
public class DrinksSoftDrinkData
{
	// Token: 0x06003795 RID: 14229 RVA: 0x00143FC5 File Offset: 0x001421C5
	public DrinksSoftDrinkData(int id)
	{
		this._id = id;
	}

	// Token: 0x170007D2 RID: 2002
	// (get) Token: 0x06003796 RID: 14230 RVA: 0x00143FEA File Offset: 0x001421EA
	public int Id
	{
		get
		{
			return this._id;
		}
	}

	// Token: 0x06003797 RID: 14231 RVA: 0x00143FF2 File Offset: 0x001421F2
	public void UpdateConfig(int count, int configId)
	{
		this.CountMap[count] = configId;
	}

	// Token: 0x06003798 RID: 14232 RVA: 0x00144004 File Offset: 0x00142204
	public Dictionary<int, int[]> GetFlavorRange()
	{
		if (this.FlavorRange.Count > 0)
		{
			return this.FlavorRange;
		}
		foreach (KeyValuePair<int, int> keyValuePair in this.CountMap)
		{
			int value = keyValuePair.Value;
			foreach (KeyValuePair<int, int> keyValuePair2 in DrinksConfig.Instance.GetDrinkBase(value).Value.Flavor())
			{
				int key = keyValuePair2.Key;
				int value2 = keyValuePair2.Value;
				int[] array;
				if (!this.FlavorRange.TryGetValue(key, out array))
				{
					this.FlavorRange[key] = new int[]
					{
						value2,
						value2
					};
				}
				else
				{
					int num = array[0];
					int num2 = array[1];
					if (value2 < num)
					{
						this.FlavorRange[key] = new int[]
						{
							value2,
							num2
						};
					}
					else if (value2 > num2)
					{
						this.FlavorRange[key] = new int[]
						{
							num,
							value2
						};
					}
				}
			}
		}
		return this.FlavorRange;
	}

	// Token: 0x06003799 RID: 14233 RVA: 0x00144180 File Offset: 0x00142380
	public int GetMenuBaseId()
	{
		return this.CountMap[1];
	}

	// Token: 0x0600379A RID: 14234 RVA: 0x00144190 File Offset: 0x00142390
	public int[] GetAllBaseId()
	{
		int[] array = (this.CountMap.Count == 2) ? new int[2] : new int[3];
		foreach (KeyValuePair<int, int> keyValuePair in this.CountMap)
		{
			array[keyValuePair.Key - 1] = keyValuePair.Value;
		}
		return array;
	}

	// Token: 0x04002DEB RID: 11755
	protected Dictionary<int, int> CountMap = new Dictionary<int, int>();

	// Token: 0x04002DEC RID: 11756
	protected Dictionary<int, int[]> FlavorRange = new Dictionary<int, int[]>();

	// Token: 0x04002DED RID: 11757
	private readonly int _id;
}
