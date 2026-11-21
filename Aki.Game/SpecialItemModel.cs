using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020014F5 RID: 5365
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class SpecialItemModel : ModelBase
{
	// Token: 0x0600D65E RID: 54878 RVA: 0x003F94E4 File Offset: 0x003F76E4
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

	// Token: 0x0600D65F RID: 54879 RVA: 0x003F9554 File Offset: 0x003F7754
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

	// Token: 0x0600D660 RID: 54880 RVA: 0x003F95C4 File Offset: 0x003F77C4
	public int? GetEquipSpecialItemId()
	{
		if (RouletteModel.Instance.EquipItemType.GetValueOrDefault() == InventoryDefine.EItemType.SpecialItem)
		{
			return new int?(RouletteModel.Instance.CurrentEquipItemId);
		}
		return null;
	}

	// Token: 0x0600D661 RID: 54881 RVA: 0x003F9600 File Offset: 0x003F7800
	protected override bool OnClear()
	{
		foreach (KeyValuePair<SpecialItemDefine.ESpecialItemType, SpecialItemLogicBase> keyValuePair in this.SpecialItemLogicMap)
		{
			keyValuePair.Value.Destroy();
		}
		this.SpecialItemLogicMap.Clear();
		return true;
	}

	// Token: 0x170013DE RID: 5086
	// (get) Token: 0x0600D662 RID: 54882 RVA: 0x003F9664 File Offset: 0x003F7864
	public static SpecialItemModel Instance
	{
		get
		{
			return SpecialItemModel._Instance;
		}
	}

	// Token: 0x0600D663 RID: 54883 RVA: 0x003F966B File Offset: 0x003F786B
	public static SpecialItemModel GetOrCreateInstance()
	{
		if (SpecialItemModel._Instance == null)
		{
			SpecialItemModel.CreateInstance();
		}
		return SpecialItemModel._Instance;
	}

	// Token: 0x0600D664 RID: 54884 RVA: 0x003F967F File Offset: 0x003F787F
	public static bool CreateInstance()
	{
		if (SpecialItemModel._Instance != null)
		{
			return true;
		}
		SpecialItemModel._Instance = new SpecialItemModel();
		return true;
	}

	// Token: 0x0600D665 RID: 54885 RVA: 0x003F9695 File Offset: 0x003F7895
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D666 RID: 54886 RVA: 0x003F9697 File Offset: 0x003F7897
	public static void ResetStaticDefaultValue()
	{
		SpecialItemModel._Instance = null;
	}

	// Token: 0x0600D667 RID: 54887 RVA: 0x003F969F File Offset: 0x003F789F
	static SpecialItemModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialItemModel.CreateStaticDefaultValue), new Action(SpecialItemModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007834 RID: 30772
	private readonly Dictionary<SpecialItemDefine.ESpecialItemType, SpecialItemLogicBase> SpecialItemLogicMap = new Dictionary<SpecialItemDefine.ESpecialItemType, SpecialItemLogicBase>();

	// Token: 0x04007835 RID: 30773
	private readonly SpecialItemDefine.ESpecialItemType[] NeedLoadSpecialItemType = Array.Empty<SpecialItemDefine.ESpecialItemType>();

	// Token: 0x04007836 RID: 30774
	public int? TagWatchedItemId;

	// Token: 0x04007837 RID: 30775
	[Nullable(2)]
	public EntityHandle TagWatchedEntityHandle;

	// Token: 0x04007838 RID: 30776
	public HashSet<int> WatchedAllowTagIds = new HashSet<int>();

	// Token: 0x04007839 RID: 30777
	public HashSet<int> WatchedBanTagIds = new HashSet<int>();

	// Token: 0x0400783A RID: 30778
	[Nullable(2)]
	private static SpecialItemModel _Instance;
}
