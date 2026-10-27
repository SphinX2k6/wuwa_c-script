using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F4A RID: 3914
[NullableContext(1)]
[Nullable(0)]
public class DrinksSoftDrinkData
{
	// Token: 0x060063FD RID: 25597 RVA: 0x0013B6F9 File Offset: 0x001398F9
	public DrinksSoftDrinkData(int id)
	{
		this._id = id;
	}

	// Token: 0x170007B0 RID: 1968
	// (get) Token: 0x060063FE RID: 25598 RVA: 0x0013B71E File Offset: 0x0013991E
	public int Id
	{
		get
		{
			return this._id;
		}
	}

	// Token: 0x060063FF RID: 25599 RVA: 0x0013B726 File Offset: 0x00139926
	public void UpdateConfig(int count, int configId)
	{
		this.CountMap[count] = configId;
	}

	// Token: 0x06006400 RID: 25600 RVA: 0x0013B738 File Offset: 0x00139938
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

	// Token: 0x06006401 RID: 25601 RVA: 0x0013B8B4 File Offset: 0x00139AB4
	public int GetMenuBaseId()
	{
		return this.CountMap[1];
	}

	// Token: 0x06006402 RID: 25602 RVA: 0x0013B8C4 File Offset: 0x00139AC4
	public int[] GetAllBaseId()
	{
		int[] array = (this.CountMap.Count == 2) ? new int[2] : new int[3];
		foreach (KeyValuePair<int, int> keyValuePair in this.CountMap)
		{
			array[keyValuePair.Key - 1] = keyValuePair.Value;
		}
		return array;
	}

	// Token: 0x04002D52 RID: 11602
	protected Dictionary<int, int> CountMap = new Dictionary<int, int>();

	// Token: 0x04002D53 RID: 11603
	protected Dictionary<int, int[]> FlavorRange = new Dictionary<int, int[]>();

	// Token: 0x04002D54 RID: 11604
	private readonly int _id;
}
