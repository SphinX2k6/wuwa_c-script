using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001F7C RID: 8060
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class InfluenceModel : ModelBase
{
	// Token: 0x0600FA0B RID: 64011 RVA: 0x003C9394 File Offset: 0x003C7594
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

	// Token: 0x0600FA0C RID: 64012 RVA: 0x003C93D0 File Offset: 0x003C75D0
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

	// Token: 0x17001343 RID: 4931
	// (get) Token: 0x0600FA0D RID: 64013 RVA: 0x003C940A File Offset: 0x003C760A
	public static InfluenceModel Instance
	{
		get
		{
			return InfluenceModel._Instance;
		}
	}

	// Token: 0x0600FA0E RID: 64014 RVA: 0x003C9411 File Offset: 0x003C7611
	public static InfluenceModel GetOrCreateInstance()
	{
		if (InfluenceModel._Instance == null)
		{
			InfluenceModel.CreateInstance();
		}
		return InfluenceModel._Instance;
	}

	// Token: 0x0600FA0F RID: 64015 RVA: 0x003C9425 File Offset: 0x003C7625
	public static bool CreateInstance()
	{
		if (InfluenceModel._Instance != null)
		{
			return true;
		}
		InfluenceModel._Instance = new InfluenceModel();
		return true;
	}

	// Token: 0x0600FA10 RID: 64016 RVA: 0x003C943B File Offset: 0x003C763B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FA11 RID: 64017 RVA: 0x003C943D File Offset: 0x003C763D
	public static void ResetStaticDefaultValue()
	{
		InfluenceModel._Instance = null;
	}

	// Token: 0x0600FA12 RID: 64018 RVA: 0x003C9445 File Offset: 0x003C7645
	static InfluenceModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfluenceModel.CreateStaticDefaultValue), new Action(InfluenceModel.ResetStaticDefaultValue));
	}

	// Token: 0x04007486 RID: 29830
	public HashSet<int> UnlockCountry = new HashSet<int>();

	// Token: 0x04007487 RID: 29831
	public HashSet<int> UnlockInfluence = new HashSet<int>();

	// Token: 0x04007488 RID: 29832
	public int CurrentSelectAreaId;

	// Token: 0x04007489 RID: 29833
	public int CurrentSelectInfluenceId;

	// Token: 0x0400748A RID: 29834
	[Nullable(2)]
	private static InfluenceModel _Instance;
}
