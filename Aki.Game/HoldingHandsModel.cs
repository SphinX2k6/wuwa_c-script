using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001321 RID: 4897
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class HoldingHandsModel : ModelBase
{
	// Token: 0x0600C0A4 RID: 49316 RVA: 0x0038F8F0 File Offset: 0x0038DAF0
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600C0A5 RID: 49317 RVA: 0x0038F8F3 File Offset: 0x0038DAF3
	protected override bool OnClear()
	{
		this.Relations.Clear();
		return true;
	}

	// Token: 0x0600C0A6 RID: 49318 RVA: 0x0038F901 File Offset: 0x0038DB01
	public void SetRelation(string key, HoldingHandsRelation relation)
	{
		this.Relations[key] = relation;
	}

	// Token: 0x0600C0A7 RID: 49319 RVA: 0x0038F910 File Offset: 0x0038DB10
	public void DeleteRelation(string key)
	{
		this.Relations.Remove(key);
	}

	// Token: 0x0600C0A8 RID: 49320 RVA: 0x0038F920 File Offset: 0x0038DB20
	[return: Nullable(2)]
	public HoldingHandsRelation GetRelation(string key)
	{
		HoldingHandsRelation result;
		if (this.Relations.TryGetValue(key, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x170012B6 RID: 4790
	// (get) Token: 0x0600C0A9 RID: 49321 RVA: 0x0038F940 File Offset: 0x0038DB40
	public static HoldingHandsModel Instance
	{
		get
		{
			return HoldingHandsModel._Instance;
		}
	}

	// Token: 0x0600C0AA RID: 49322 RVA: 0x0038F947 File Offset: 0x0038DB47
	public static HoldingHandsModel GetOrCreateInstance()
	{
		if (HoldingHandsModel._Instance == null)
		{
			HoldingHandsModel.CreateInstance();
		}
		return HoldingHandsModel._Instance;
	}

	// Token: 0x0600C0AB RID: 49323 RVA: 0x0038F95B File Offset: 0x0038DB5B
	public static bool CreateInstance()
	{
		if (HoldingHandsModel._Instance != null)
		{
			return true;
		}
		HoldingHandsModel._Instance = new HoldingHandsModel();
		return true;
	}

	// Token: 0x0600C0AC RID: 49324 RVA: 0x0038F971 File Offset: 0x0038DB71
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C0AD RID: 49325 RVA: 0x0038F973 File Offset: 0x0038DB73
	public static void ResetStaticDefaultValue()
	{
		HoldingHandsModel._Instance = null;
	}

	// Token: 0x0600C0AE RID: 49326 RVA: 0x0038F97B File Offset: 0x0038DB7B
	static HoldingHandsModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HoldingHandsModel.CreateStaticDefaultValue), new Action(HoldingHandsModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006E83 RID: 28291
	public readonly Dictionary<string, HoldingHandsRelation> Relations = new Dictionary<string, HoldingHandsRelation>();

	// Token: 0x04006E84 RID: 28292
	[Nullable(2)]
	private static HoldingHandsModel _Instance;
}
