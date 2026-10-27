using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Item;

// Token: 0x020018E6 RID: 6374
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class ItemTipsModel : ModelBase
{
	// Token: 0x17000F86 RID: 3974
	// (get) Token: 0x0600BABB RID: 47803 RVA: 0x002A4CC4 File Offset: 0x002A2EC4
	public int DebugCacheTipsItemId
	{
		get
		{
			return this.DebugCacheTipsItemIdInternal;
		}
	}

	// Token: 0x0600BABC RID: 47804 RVA: 0x002A4CCC File Offset: 0x002A2ECC
	public void SetCurrentItemTipsData(ItemTipsData itemTipsData)
	{
		this.CurrentItemTipsData = itemTipsData;
		if (!Info.Instance.IsBuildShipping && itemTipsData != null)
		{
			this.DebugCacheTipsItemIdInternal = itemTipsData.ConfigId;
		}
	}

	// Token: 0x0600BABD RID: 47805 RVA: 0x002A4CF0 File Offset: 0x002A2EF0
	public ItemTipsData GetCurrentItemTipsData()
	{
		return this.CurrentItemTipsData;
	}

	// Token: 0x17000F87 RID: 3975
	// (get) Token: 0x0600BABE RID: 47806 RVA: 0x002A4CF8 File Offset: 0x002A2EF8
	[Nullable(1)]
	public static ItemTipsModel Instance
	{
		[NullableContext(1)]
		get
		{
			return ItemTipsModel._Instance;
		}
	}

	// Token: 0x0600BABF RID: 47807 RVA: 0x002A4CFF File Offset: 0x002A2EFF
	[NullableContext(1)]
	public static ItemTipsModel GetOrCreateInstance()
	{
		if (ItemTipsModel._Instance == null)
		{
			ItemTipsModel.CreateInstance();
		}
		return ItemTipsModel._Instance;
	}

	// Token: 0x0600BAC0 RID: 47808 RVA: 0x002A4D13 File Offset: 0x002A2F13
	public static bool CreateInstance()
	{
		if (ItemTipsModel._Instance != null)
		{
			return true;
		}
		ItemTipsModel._Instance = new ItemTipsModel();
		return true;
	}

	// Token: 0x0600BAC1 RID: 47809 RVA: 0x002A4D29 File Offset: 0x002A2F29
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BAC2 RID: 47810 RVA: 0x002A4D2B File Offset: 0x002A2F2B
	public static void ResetStaticDefaultValue()
	{
		ItemTipsModel._Instance = null;
	}

	// Token: 0x0600BAC3 RID: 47811 RVA: 0x002A4D33 File Offset: 0x002A2F33
	static ItemTipsModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemTipsModel.CreateStaticDefaultValue), new Action(ItemTipsModel.ResetStaticDefaultValue));
	}

	// Token: 0x040054CE RID: 21710
	private ItemTipsData CurrentItemTipsData;

	// Token: 0x040054CF RID: 21711
	public ItemTipsParam SharpTempOpenParam;

	// Token: 0x040054D0 RID: 21712
	private int DebugCacheTipsItemIdInternal;

	// Token: 0x040054D1 RID: 21713
	private static ItemTipsModel _Instance;
}
