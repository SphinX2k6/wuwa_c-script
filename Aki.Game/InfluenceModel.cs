using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200143E RID: 5182
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InfluenceModel : ModelBase
{
	// Token: 0x0600CE2A RID: 52778 RVA: 0x003D4EB0 File Offset: 0x003D30B0
	public void AddUnlockCountry(int[] unlockItems)
	{
		for (int i = 0; i < unlockItems.Length; i++)
		{
			if (!this.UnlockCountry.Contains(unlockItems[i]))
			{
				this.UnlockCountry.Add(unlockItems[i]);
			}
		}
	}

	// Token: 0x0600CE2B RID: 52779 RVA: 0x003D4EEC File Offset: 0x003D30EC
	public void AddUnlockInfluence(int[] unlockItems)
	{
		for (int i = 0; i < unlockItems.Length; i++)
		{
			if (!this.UnlockInfluence.Contains(unlockItems[i]))
			{
				this.UnlockInfluence.Add(unlockItems[i]);
			}
		}
	}

	// Token: 0x1700136D RID: 4973
	// (get) Token: 0x0600CE2C RID: 52780 RVA: 0x003D4F26 File Offset: 0x003D3126
	public static InfluenceModel Instance
	{
		get
		{
			return InfluenceModel._Instance;
		}
	}

	// Token: 0x0600CE2D RID: 52781 RVA: 0x003D4F2D File Offset: 0x003D312D
	public static InfluenceModel GetOrCreateInstance()
	{
		if (InfluenceModel._Instance == null)
		{
			InfluenceModel.CreateInstance();
		}
		return InfluenceModel._Instance;
	}

	// Token: 0x0600CE2E RID: 52782 RVA: 0x003D4F41 File Offset: 0x003D3141
	public static bool CreateInstance()
	{
		if (InfluenceModel._Instance != null)
		{
			return true;
		}
		InfluenceModel._Instance = new InfluenceModel();
		return true;
	}

	// Token: 0x0600CE2F RID: 52783 RVA: 0x003D4F57 File Offset: 0x003D3157
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CE30 RID: 52784 RVA: 0x003D4F59 File Offset: 0x003D3159
	public static void ResetStaticDefaultValue()
	{
		InfluenceModel._Instance = null;
	}

	// Token: 0x0600CE31 RID: 52785 RVA: 0x003D4F61 File Offset: 0x003D3161
	static InfluenceModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfluenceModel.CreateStaticDefaultValue), new Action(InfluenceModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007567 RID: 30055
	public HashSet<int> UnlockCountry = new HashSet<int>();

	// Token: 0x04007568 RID: 30056
	public HashSet<int> UnlockInfluence = new HashSet<int>();

	// Token: 0x04007569 RID: 30057
	public int CurrentSelectAreaId;

	// Token: 0x0400756A RID: 30058
	public int CurrentSelectInfluenceId;

	// Token: 0x0400756B RID: 30059
	[Nullable(2)]
	private static InfluenceModel _Instance;
}
