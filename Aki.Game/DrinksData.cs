using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.ActivityGamePlay.Drinks;

// Token: 0x02000F3B RID: 3899
[NullableContext(1)]
[Nullable(0)]
public class DrinksData
{
	// Token: 0x06006375 RID: 25461 RVA: 0x00138EC8 File Offset: 0x001370C8
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

	// Token: 0x06006376 RID: 25462 RVA: 0x00138FCF File Offset: 0x001371CF
	public DrinksResultInfo GetCurData()
	{
		return this.Data;
	}

	// Token: 0x06006377 RID: 25463 RVA: 0x00138FD8 File Offset: 0x001371D8
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

	// Token: 0x06006378 RID: 25464 RVA: 0x001391E0 File Offset: 0x001373E0
	public int[] GetFlavorValue()
	{
		return this.FlavorValue;
	}

	// Token: 0x06006379 RID: 25465 RVA: 0x001391E8 File Offset: 0x001373E8
	public int GetRequireId()
	{
		return this.RequireId;
	}

	// Token: 0x0600637A RID: 25466 RVA: 0x001391F0 File Offset: 0x001373F0
	public DrinksRequireList GetRequireConfig()
	{
		return DrinksConfig.Instance.GetRequireList(this.RequireId).Value;
	}

	// Token: 0x0600637B RID: 25467 RVA: 0x00139218 File Offset: 0x00137418
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

	// Token: 0x0600637C RID: 25468 RVA: 0x00139448 File Offset: 0x00137648
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

	// Token: 0x0600637D RID: 25469 RVA: 0x0013949F File Offset: 0x0013769F
	public void UpdateBatching(HashSet<int> set)
	{
		if (this.Data == null || set.Count > 2)
		{
			return;
		}
		this.Data.Batching = new List<int>(set);
	}

	// Token: 0x0600637E RID: 25470 RVA: 0x001394C4 File Offset: 0x001376C4
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

	// Token: 0x0600637F RID: 25471 RVA: 0x00139504 File Offset: 0x00137704
	public EDrinksPlayStep GetCurStep()
	{
		return this.CurStep;
	}

	// Token: 0x06006380 RID: 25472 RVA: 0x0013950C File Offset: 0x0013770C
	public void EnterNextStep()
	{
		this.CurStep = DrinksData.NextStep[(int)this.CurStep];
	}

	// Token: 0x06006381 RID: 25473 RVA: 0x00139520 File Offset: 0x00137720
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

	// Token: 0x06006382 RID: 25474 RVA: 0x001395EC File Offset: 0x001377EC
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

	// Token: 0x06006383 RID: 25475 RVA: 0x001396A3 File Offset: 0x001378A3
	public int GetDrinkBaseShowId(int id)
	{
		return DrinksModel.Instance.GetDrinksByBaseId(id).GetMenuBaseId();
	}

	// Token: 0x06006384 RID: 25476 RVA: 0x001396B8 File Offset: 0x001378B8
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

	// Token: 0x06006385 RID: 25477 RVA: 0x001398C6 File Offset: 0x00137AC6
	[NullableContext(2)]
	public DrinksDialogBubbleInfo GetDialogHintBubbleInfo()
	{
		if (this.CurStep != EDrinksPlayStep.Ornament)
		{
			return null;
		}
		return this.GetDialogBubbleInfoOrnament();
	}

	// Token: 0x06006386 RID: 25478 RVA: 0x001398DC File Offset: 0x00137ADC
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

	// Token: 0x06006387 RID: 25479 RVA: 0x00139985 File Offset: 0x00137B85
	public void UpdateStepEnd(EDrinksPlayStep step, bool value)
	{
		this.SelectedEndMap[step] = value;
	}

	// Token: 0x06006388 RID: 25480 RVA: 0x00139994 File Offset: 0x00137B94
	private void GetRandomSort()
	{
		this.RandomSort.Clear();
		this.RandomSort = MathUtils.Instance.Shuffle<int>(new int[]
		{
			1,
			2,
			3
		}).ToList<int>();
	}

	// Token: 0x06006389 RID: 25481 RVA: 0x001399C8 File Offset: 0x00137BC8
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

	// Token: 0x04002D15 RID: 11541
	[StaticVariableRuleIgnore]
	private static EDrinksPlayStep[] PrevStep = new EDrinksPlayStep[]
	{
		EDrinksPlayStep.Drink1,
		EDrinksPlayStep.Drink1,
		EDrinksPlayStep.Drink2,
		EDrinksPlayStep.Drink2,
		EDrinksPlayStep.Batching
	};

	// Token: 0x04002D16 RID: 11542
	[StaticVariableRuleIgnore]
	private static EDrinksPlayStep[] NextStep = new EDrinksPlayStep[]
	{
		EDrinksPlayStep.Drink2,
		EDrinksPlayStep.Batching,
		EDrinksPlayStep.Ornament,
		EDrinksPlayStep.Ornament
	};

	// Token: 0x04002D17 RID: 11543
	private const string BUBBLE_DRINK_LIKE = "Dialog_{0}_Like0{1}";

	// Token: 0x04002D18 RID: 11544
	private const string BUBBLE_DRINK_DISLIKE = "Dialog_{0}_Dislike0{1}";

	// Token: 0x04002D19 RID: 11545
	public EDrinksPlayStep CurStep;

	// Token: 0x04002D1A RID: 11546
	[Nullable(2)]
	public DrinksResultInfo Data;

	// Token: 0x04002D1B RID: 11547
	public int RoleId;

	// Token: 0x04002D1C RID: 11548
	public int RequireId;

	// Token: 0x04002D1D RID: 11549
	protected int[] FlavorValue = new int[3];

	// Token: 0x04002D1E RID: 11550
	protected List<int> RandomSort = new List<int>();

	// Token: 0x04002D1F RID: 11551
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
