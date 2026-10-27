using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02002022 RID: 8226
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SpecialItemModel : ModelBase
{
	// Token: 0x060101F6 RID: 66038 RVA: 0x003ECEEC File Offset: 0x003EB0EC
	protected override bool OnInit()
	{
		foreach (SpecialItemDefine.ESpecialItemType especialItemType in this.NeedLoadSpecialItemType)
		{
			Type type;
			if (SpecialItemDefine.specialItemLogic != null && SpecialItemDefine.specialItemLogic.TryGetValue(especialItemType, out type))
			{
				SpecialItemLogicBase specialItemLogicBase = (SpecialItemLogicBase)Activator.CreateInstance(type, new object[]
				{
					especialItemType
				});
				specialItemLogicBase.Init();
				this.SpecialItemLogicMap.Add(especialItemType, specialItemLogicBase);
			}
		}
		return true;
	}

	// Token: 0x060101F7 RID: 66039 RVA: 0x003ECF5C File Offset: 0x003EB15C
	[NullableContext(2)]
	public SpecialItemLogicBase GetSpecialItemLogic(SpecialItemDefine.ESpecialItemType itemType)
	{
		if (SpecialItemConfig.Instance.GetConfig((int)itemType) == null)
		{
			return null;
		}
		SpecialItemLogicBase specialItemLogicBase = null;
		SpecialItemLogicBase specialItemLogicBase2;
		if (this.SpecialItemLogicMap.TryGetValue(itemType, out specialItemLogicBase2))
		{
			specialItemLogicBase = specialItemLogicBase2;
		}
		Type type;
		if (specialItemLogicBase == null && SpecialItemDefine.specialItemLogic != null && SpecialItemDefine.specialItemLogic.TryGetValue(itemType, out type))
		{
			specialItemLogicBase = (SpecialItemLogicBase)Activator.CreateInstance(type, new object[]
			{
				itemType
			});
		}
		return specialItemLogicBase;
	}

	// Token: 0x060101F8 RID: 66040 RVA: 0x003ECFCC File Offset: 0x003EB1CC
	public int? GetEquipSpecialItemId()
	{
		if (RouletteModel.Instance.EquipItemType.GetValueOrDefault() == InventoryDefine.EItemType.SpecialItem)
		{
			return new int?(RouletteModel.Instance.CurrentEquipItemId);
		}
		return null;
	}

	// Token: 0x060101F9 RID: 66041 RVA: 0x003ED008 File Offset: 0x003EB208
	protected override bool OnClear()
	{
		foreach (KeyValuePair<SpecialItemDefine.ESpecialItemType, SpecialItemLogicBase> keyValuePair in this.SpecialItemLogicMap)
		{
			keyValuePair.Value.Destroy();
		}
		this.SpecialItemLogicMap.Clear();
		return true;
	}

	// Token: 0x170013B1 RID: 5041
	// (get) Token: 0x060101FA RID: 66042 RVA: 0x003ED06C File Offset: 0x003EB26C
	public static SpecialItemModel Instance
	{
		get
		{
			return SpecialItemModel._Instance;
		}
	}

	// Token: 0x060101FB RID: 66043 RVA: 0x003ED073 File Offset: 0x003EB273
	public static SpecialItemModel GetOrCreateInstance()
	{
		if (SpecialItemModel._Instance == null)
		{
			SpecialItemModel.CreateInstance();
		}
		return SpecialItemModel._Instance;
	}

	// Token: 0x060101FC RID: 66044 RVA: 0x003ED087 File Offset: 0x003EB287
	public static bool CreateInstance()
	{
		if (SpecialItemModel._Instance != null)
		{
			return true;
		}
		SpecialItemModel._Instance = new SpecialItemModel();
		return true;
	}

	// Token: 0x060101FD RID: 66045 RVA: 0x003ED09D File Offset: 0x003EB29D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060101FE RID: 66046 RVA: 0x003ED09F File Offset: 0x003EB29F
	public static void ResetStaticDefaultValue()
	{
		SpecialItemModel._Instance = null;
	}

	// Token: 0x060101FF RID: 66047 RVA: 0x003ED0A7 File Offset: 0x003EB2A7
	static SpecialItemModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialItemModel.CreateStaticDefaultValue), new Action(SpecialItemModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400774B RID: 30539
	private readonly Dictionary<SpecialItemDefine.ESpecialItemType, SpecialItemLogicBase> SpecialItemLogicMap = new Dictionary<SpecialItemDefine.ESpecialItemType, SpecialItemLogicBase>();

	// Token: 0x0400774C RID: 30540
	private readonly SpecialItemDefine.ESpecialItemType[] NeedLoadSpecialItemType = Array.Empty<SpecialItemDefine.ESpecialItemType>();

	// Token: 0x0400774D RID: 30541
	public int? TagWatchedItemId;

	// Token: 0x0400774E RID: 30542
	[Nullable(2)]
	public EntityHandle TagWatchedEntityHandle;

	// Token: 0x0400774F RID: 30543
	public HashSet<int> WatchedAllowTagIds = new HashSet<int>();

	// Token: 0x04007750 RID: 30544
	public HashSet<int> WatchedBanTagIds = new HashSet<int>();

	// Token: 0x04007751 RID: 30545
	[Nullable(2)]
	private static SpecialItemModel _Instance;
}
