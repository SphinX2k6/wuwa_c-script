using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02000D9F RID: 3487
[NullableContext(2)]
[Nullable(0)]
[Model(0)]
public class ItemTipsModel : ModelBase
{
	// Token: 0x17000FA9 RID: 4009
	// (get) Token: 0x06008EA4 RID: 36516 RVA: 0x002AF440 File Offset: 0x002AD640
	public int DebugCacheTipsItemId
	{
		get
		{
			return this.DebugCacheTipsItemIdInternal;
		}
	}

	// Token: 0x06008EA5 RID: 36517 RVA: 0x002AF448 File Offset: 0x002AD648
	public void SetCurrentItemTipsData(ItemTipsData itemTipsData)
	{
		this.CurrentItemTipsData = itemTipsData;
	}

	// Token: 0x06008EA6 RID: 36518 RVA: 0x002AF451 File Offset: 0x002AD651
	public ItemTipsData GetCurrentItemTipsData()
	{
		return this.CurrentItemTipsData;
	}

	// Token: 0x17000FAA RID: 4010
	// (get) Token: 0x06008EA7 RID: 36519 RVA: 0x002AF459 File Offset: 0x002AD659
	[Nullable(1)]
	public static ItemTipsModel Instance
	{
		[NullableContext(1)]
		get
		{
			return ItemTipsModel._Instance;
		}
	}

	// Token: 0x06008EA8 RID: 36520 RVA: 0x002AF460 File Offset: 0x002AD660
	[NullableContext(1)]
	public static ItemTipsModel GetOrCreateInstance()
	{
		if (ItemTipsModel._Instance == null)
		{
			ItemTipsModel.CreateInstance();
		}
		return ItemTipsModel._Instance;
	}

	// Token: 0x06008EA9 RID: 36521 RVA: 0x002AF474 File Offset: 0x002AD674
	public static bool CreateInstance()
	{
		if (ItemTipsModel._Instance != null)
		{
			return true;
		}
		ItemTipsModel._Instance = new ItemTipsModel();
		return true;
	}

	// Token: 0x06008EAA RID: 36522 RVA: 0x002AF48A File Offset: 0x002AD68A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008EAB RID: 36523 RVA: 0x002AF48C File Offset: 0x002AD68C
	public static void ResetStaticDefaultValue()
	{
		ItemTipsModel._Instance = null;
	}

	// Token: 0x06008EAC RID: 36524 RVA: 0x002AF494 File Offset: 0x002AD694
	static ItemTipsModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ItemTipsModel.CreateStaticDefaultValue), new Action(ItemTipsModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005579 RID: 21881
	private ItemTipsData CurrentItemTipsData;

	// Token: 0x0400557A RID: 21882
	public ItemTipsParam SharpTempOpenParam;

	// Token: 0x0400557B RID: 21883
	private int DebugCacheTipsItemIdInternal;

	// Token: 0x0400557C RID: 21884
	private static ItemTipsModel _Instance;
}
