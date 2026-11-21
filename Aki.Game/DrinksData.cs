using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityGamePlay.Drinks;

// Token: 0x020003F0 RID: 1008
[NullableContext(1)]
[Nullable(0)]
public class DrinksData
{
	// Token: 0x0600370D RID: 14093 RVA: 0x00141794 File Offset: 0x0013F994
	public unsafe void Init(int roleId, int? requireId = null)
	{
		this.CurStep = EDrinksPlayStep.Drink1;
		this.RoleId = roleId;
		DrinksResultInfo drinksResultInfo = new DrinksResultInfo();
		drinksResultInfo.RequireId = 0;
		int num = 2;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int num2 = 0;
		*span[num2] = 0;
		num2++;
		*span[num2] = 0;
		drinksResultInfo.DrinkBase = list;
		drinksResultInfo.Ornament = 0;
		this.Data = drinksResultInfo;
		List<EDrinksPlayStep> list2 = new List<EDrinksPlayStep>(this.SelectedEndMap.Keys);
		for (int i = 0; i < list2.Count; i++)
		{
			this.SelectedEndMap[list2[i]] = false;
		}
		this.FlavorValue = new int[3];
		if (requireId == null)
		{
			IReadOnlyList<DrinksRequireList> requireListByRole = DrinksConfig.Instance.GetRequireListByRole(roleId);
			this.RequireId = MathUtils.Instance.GetRandomItem<DrinksRequireList>(requireListByRole).Id;
		}
		else
		{
			this.RequireId = requireId.Value;
		}
		this.Data.RequireId = this.RequireId;
		this.GetRandomSort();
	}

	// Token: 0x0600370E RID: 14094 RVA: 0x0014189B File Offset: 0x0013FA9B
	public DrinksResultInfo GetCurData()
	{
		return this.Data;
	}

	// Token: 0x0600370F RID: 14095 RVA: 0x001418A4 File Offset: 0x0013FAA4
	public int[] UpdateFlavorValue()
	{
		int[] array = new int[3];
		EDrinksPlayStep curStep = DrinksModel.Instance.GetCurStep();
		if (curStep > EDrinksPlayStep.Drink1)
		{
			foreach (KeyValuePair<int, int> keyValuePair in DrinksConfig.Instance.GetDrinkBase(this.Data.DrinkBase[0]).Value.Flavor())
			{
				array[keyValuePair.Key] += keyValuePair.Value;
			}
		}
		if (curStep > EDrinksPlayStep.Drink2)
		{
			foreach (KeyValuePair<int, int> keyValuePair2 in DrinksConfig.Instance.GetDrinkBase(this.Data.DrinkBase[1]).Value.Flavor())
			{
				array[keyValuePair2.Key] += keyValuePair2.Value;
			}
		}
		if (this.Data.Batching != null && curStep > EDrinksPlayStep.Batching)
		{
			foreach (int id in this.Data.Batching)
			{
				foreach (KeyValuePair<int, int> keyValuePair3 in DrinksConfig.Instance.GetBatching(id).Value.Flavor())
				{
					array[keyValuePair3.Key] += keyValuePair3.Value;
				}
			}
		}
		for (int i = 0; i < 3; i++)
		{
			this.FlavorValue[i] = array[i];
		}
		return this.FlavorValue;
	}

	// Token: 0x06003710 RID: 14096 RVA: 0x00141AAC File Offset: 0x0013FCAC
	public int[] GetFlavorValue()
	{
		return this.FlavorValue;
	}

	// Token: 0x06003711 RID: 14097 RVA: 0x00141AB4 File Offset: 0x0013FCB4
	public int GetRequireId()
	{
		return this.RequireId;
	}

	// Token: 0x06003712 RID: 14098 RVA: 0x00141ABC File Offset: 0x0013FCBC
	public DrinksRequireList GetRequireConfig()
	{
		return DrinksConfig.Instance.GetRequireList(this.RequireId).Value;
	}

	// Token: 0x06003713 RID: 14099 RVA: 0x00141AE4 File Offset: 0x0013FCE4
	public int[] GetCurFlavor(bool force = false)
	{
		int[] array = new int[3];
		if ((this.SelectedEndMap[EDrinksPlayStep.Drink1] || force) && this.Data.DrinkBase[0] != 0)
		{
			foreach (KeyValuePair<int, int> keyValuePair in DrinksConfig.Instance.GetDrinkBase(this.Data.DrinkBase[0]).Value.Flavor())
			{
				array[keyValuePair.Key] = array[keyValuePair.Key] + keyValuePair.Value;
			}
		}
		if ((this.SelectedEndMap[EDrinksPlayStep.Drink2] || force) && this.Data.DrinkBase[1] != 0)
		{
			foreach (KeyValuePair<int, int> keyValuePair2 in DrinksConfig.Instance.GetDrinkBase(this.Data.DrinkBase[1]).Value.Flavor())
			{
				array[keyValuePair2.Key] = array[keyValuePair2.Key] + keyValuePair2.Value;
			}
		}
		if ((this.SelectedEndMap[EDrinksPlayStep.Batching] || force) && this.Data.Batching != null)
		{
			foreach (int id in this.Data.Batching)
			{
				foreach (KeyValuePair<int, int> keyValuePair3 in DrinksConfig.Instance.GetBatching(id).Value.Flavor())
				{
					array[keyValuePair3.Key] = array[keyValuePair3.Key] + keyValuePair3.Value;
				}
			}
		}
		return array;
	}

	// Token: 0x06003714 RID: 14100 RVA: 0x00141D14 File Offset: 0x0013FF14
	public void UpdateBase(int step, int id)
	{
		if (this.Data == null)
		{
			return;
		}
		this.Data.DrinkBase[step] = id;
		for (int i = step + 1; i < this.Data.DrinkBase.Count; i++)
		{
			this.Data.DrinkBase[i] = 0;
		}
	}

	// Token: 0x06003715 RID: 14101 RVA: 0x00141D6B File Offset: 0x0013FF6B
	public void UpdateBatching(HashSet<int> set)
	{
		if (this.Data == null || set.Count > 2)
		{
			return;
		}
		this.Data.Batching = new List<int>(set);
	}

	// Token: 0x06003716 RID: 14102 RVA: 0x00141D90 File Offset: 0x0013FF90
	public void UpdateOrnament(int id)
	{
		if (this.Data == null)
		{
			return;
		}
		this.Data.Ornament = id;
		DrinksSceneController sceneController = DrinksModel.Instance.GetSceneController();
		int roleId = DrinksModel.Instance.GetRoleId();
		sceneController.OnSetOrnament(id, roleId, null, true);
	}

	// Token: 0x06003717 RID: 14103 RVA: 0x00141DD0 File Offset: 0x0013FFD0
	public EDrinksPlayStep GetCurStep()
	{
		return this.CurStep;
	}

	// Token: 0x06003718 RID: 14104 RVA: 0x00141DD8 File Offset: 0x0013FFD8
	public void EnterNextStep()
	{
		this.CurStep = DrinksData.NextStep[(int)this.CurStep];
	}

	// Token: 0x06003719 RID: 14105 RVA: 0x00141DEC File Offset: 0x0013FFEC
	public void BackToPrevStep()
	{
		if (this.CurStep == EDrinksPlayStep.Drink2)
		{
			this.SelectedEndMap[EDrinksPlayStep.Drink1] = false;
			this.UpdateBase(0, this.GetDrinkBaseShowId(this.Data.DrinkBase[0]));
		}
		else if (this.CurStep == EDrinksPlayStep.Batching)
		{
			this.SelectedEndMap[EDrinksPlayStep.Drink2] = false;
			this.UpdateBatching(new HashSet<int>());
			this.UpdateBase(1, this.GetDrinkBaseShowId(this.Data.DrinkBase[1]));
		}
		else if (this.CurStep == EDrinksPlayStep.Ornament)
		{
			this.UpdateOrnament(0);
			this.SelectedEndMap[EDrinksPlayStep.Batching] = false;
		}
		DrinksModel.Instance.GetSceneController().OnBackToBeforeOrnament();
		this.CurStep = DrinksData.PrevStep[(int)this.CurStep];
		this.UpdateFlavorValue();
	}

	// Token: 0x0600371A RID: 14106 RVA: 0x00141EB8 File Offset: 0x001400B8
	public unsafe void RestartGame()
	{
		DrinksResultInfo data = this.Data;
		int num = 2;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int num2 = 0;
		*span[num2] = 0;
		num2++;
		*span[num2] = 0;
		data.DrinkBase = list;
		this.Data.Ornament = 0;
		this.Data.Batching = null;
		this.CurStep = EDrinksPlayStep.Drink1;
		DrinksModel.Instance.GetSceneController().OnBackToBeforeOrnament();
		List<EDrinksPlayStep> list2 = new List<EDrinksPlayStep>(this.SelectedEndMap.Keys);
		for (int i = 0; i < list2.Count; i++)
		{
			this.SelectedEndMap[list2[i]] = false;
		}
		this.UpdateFlavorValue();
	}

	// Token: 0x0600371B RID: 14107 RVA: 0x00141F6F File Offset: 0x0014016F
	public int GetDrinkBaseShowId(int id)
	{
		return DrinksModel.Instance.GetDrinksByBaseId(id).GetMenuBaseId();
	}

	// Token: 0x0600371C RID: 14108 RVA: 0x00141F84 File Offset: 0x00140184
	[NullableContext(2)]
	public DrinksDialogBubbleInfo GetDialogBubbleInfo(int inId)
	{
		if (this.CurStep == EDrinksPlayStep.Ornament && inId == 0)
		{
			return null;
		}
		DrinksRequireList requireConfig = this.GetRequireConfig();
		DrinksDialogBubbleInfo drinksDialogBubbleInfo = new DrinksDialogBubbleInfo
		{
			ConfigId = "",
			IsLike = false
		};
		foreach (int id in requireConfig.GetRoleLikeSettingArray() ?? Array.Empty<int>())
		{
			DrinksRoleLikeDrink value = DrinksConfig.Instance.GetRoleLikeDrink(id).Value;
			if (this.CurStep <= EDrinksPlayStep.Drink2)
			{
				int id2 = DrinksModel.Instance.GetDrinksByBaseId(inId).Id;
				foreach (int num in value.GetLinkDrinkBaseArray() ?? Array.Empty<int>())
				{
					if (id2 == num)
					{
						string format = value.LikeStatus ? "Dialog_{0}_Like0{1}" : "Dialog_{0}_Dislike0{1}";
						string randomId = this.GetRandomId();
						drinksDialogBubbleInfo.ConfigId = string.Format(format, this.RoleId.ToString(), randomId);
						drinksDialogBubbleInfo.IsLike = value.LikeStatus;
						return drinksDialogBubbleInfo;
					}
				}
			}
			else if (this.CurStep == EDrinksPlayStep.Batching)
			{
				int[] array2 = value.GetLinkBatchingArray() ?? Array.Empty<int>();
				for (int j = 0; j < array2.Length; j++)
				{
					if (array2[j] == inId)
					{
						string format2 = value.LikeStatus ? "Dialog_{0}_Like0{1}" : "Dialog_{0}_Dislike0{1}";
						string randomId2 = this.GetRandomId();
						drinksDialogBubbleInfo.ConfigId = string.Format(format2, this.RoleId.ToString(), randomId2);
						drinksDialogBubbleInfo.IsLike = value.LikeStatus;
						return drinksDialogBubbleInfo;
					}
				}
			}
			else
			{
				int[] array2 = value.GetLinkOrnamentArray() ?? Array.Empty<int>();
				for (int j = 0; j < array2.Length; j++)
				{
					if (array2[j] == inId)
					{
						string format3 = value.LikeStatus ? "Dialog_{0}_Like0{1}" : "Dialog_{0}_Dislike0{1}";
						string randomId3 = this.GetRandomId();
						drinksDialogBubbleInfo.ConfigId = string.Format(format3, this.RoleId.ToString(), randomId3);
						drinksDialogBubbleInfo.IsLike = value.LikeStatus;
						return drinksDialogBubbleInfo;
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0600371D RID: 14109 RVA: 0x00142192 File Offset: 0x00140392
	[NullableContext(2)]
	public DrinksDialogBubbleInfo GetDialogHintBubbleInfo()
	{
		if (this.CurStep != EDrinksPlayStep.Ornament)
		{
			return null;
		}
		return this.GetDialogBubbleInfoOrnament();
	}

	// Token: 0x0600371E RID: 14110 RVA: 0x001421A8 File Offset: 0x001403A8
	[NullableContext(2)]
	private DrinksDialogBubbleInfo GetDialogBubbleInfoOrnament()
	{
		DrinksRequireList value = DrinksConfig.Instance.GetRequireList(this.RequireId).Value;
		string text = "";
		foreach (int id in value.GetRoleLikeSettingArray() ?? Array.Empty<int>())
		{
			DrinksRoleLikeDrink value2 = DrinksConfig.Instance.GetRoleLikeDrink(id).Value;
			if (value2.OrnamentHintId != "")
			{
				text = value2.OrnamentHintId;
			}
		}
		if (text == "")
		{
			return null;
		}
		return new DrinksDialogBubbleInfo
		{
			ConfigId = text,
			IsLike = true
		};
	}

	// Token: 0x0600371F RID: 14111 RVA: 0x00142251 File Offset: 0x00140451
	public void UpdateStepEnd(EDrinksPlayStep step, bool value)
	{
		this.SelectedEndMap[step] = value;
	}

	// Token: 0x06003720 RID: 14112 RVA: 0x00142260 File Offset: 0x00140460
	private void GetRandomSort()
	{
		this.RandomSort.Clear();
		this.RandomSort = new List<int>(MathUtils.Instance.Shuffle<int>(new int[]
		{
			1,
			2,
			3
		}));
	}

	// Token: 0x06003721 RID: 14113 RVA: 0x00142294 File Offset: 0x00140494
	private string GetRandomId()
	{
		if (this.RandomSort.Count == 0)
		{
			this.GetRandomSort();
		}
		int num = this.RandomSort[0];
		this.RandomSort.RemoveAt(0);
		return num.ToString();
	}

	// Token: 0x04002DAE RID: 11694
	[StaticVariableRuleIgnore]
	private static EDrinksPlayStep[] PrevStep = new EDrinksPlayStep[]
	{
		EDrinksPlayStep.Drink1,
		EDrinksPlayStep.Drink1,
		EDrinksPlayStep.Drink2,
		EDrinksPlayStep.Drink2,
		EDrinksPlayStep.Batching
	};

	// Token: 0x04002DAF RID: 11695
	[StaticVariableRuleIgnore]
	private static EDrinksPlayStep[] NextStep = new EDrinksPlayStep[]
	{
		EDrinksPlayStep.Drink2,
		EDrinksPlayStep.Batching,
		EDrinksPlayStep.Ornament,
		EDrinksPlayStep.Ornament
	};

	// Token: 0x04002DB0 RID: 11696
	private const string BUBBLE_DRINK_LIKE = "Dialog_{0}_Like0{1}";

	// Token: 0x04002DB1 RID: 11697
	private const string BUBBLE_DRINK_DISLIKE = "Dialog_{0}_Dislike0{1}";

	// Token: 0x04002DB2 RID: 11698
	public EDrinksPlayStep CurStep;

	// Token: 0x04002DB3 RID: 11699
	[Nullable(2)]
	public DrinksResultInfo Data;

	// Token: 0x04002DB4 RID: 11700
	public int RoleId;

	// Token: 0x04002DB5 RID: 11701
	public int RequireId;

	// Token: 0x04002DB6 RID: 11702
	protected int[] FlavorValue = new int[3];

	// Token: 0x04002DB7 RID: 11703
	protected List<int> RandomSort = new List<int>();

	// Token: 0x04002DB8 RID: 11704
	public Dictionary<EDrinksPlayStep, bool> SelectedEndMap = new Dictionary<EDrinksPlayStep, bool>
	{
		{
			EDrinksPlayStep.Drink1,
			false
		},
		{
			EDrinksPlayStep.Drink2,
			false
		},
		{
			EDrinksPlayStep.Batching,
			false
		},
		{
			EDrinksPlayStep.Ornament,
			false
		}
	};
}
