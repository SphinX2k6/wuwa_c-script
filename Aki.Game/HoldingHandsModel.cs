using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E5F RID: 7775
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class HoldingHandsModel : ModelBase
{
	// Token: 0x0600EC85 RID: 60549 RVA: 0x00383C34 File Offset: 0x00381E34
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600EC86 RID: 60550 RVA: 0x00383C37 File Offset: 0x00381E37
	protected override bool OnClear()
	{
		this.Relations.Clear();
		return true;
	}

	// Token: 0x0600EC87 RID: 60551 RVA: 0x00383C45 File Offset: 0x00381E45
	public void SetRelation(string key, HoldingHandsRelation relation)
	{
		this.Relations[key] = relation;
	}

	// Token: 0x0600EC88 RID: 60552 RVA: 0x00383C54 File Offset: 0x00381E54
	public void DeleteRelation(string key)
	{
		this.Relations.Remove(key);
	}

	// Token: 0x0600EC89 RID: 60553 RVA: 0x00383C64 File Offset: 0x00381E64
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

	// Token: 0x1700128C RID: 4748
	// (get) Token: 0x0600EC8A RID: 60554 RVA: 0x00383C84 File Offset: 0x00381E84
	public static HoldingHandsModel Instance
	{
		get
		{
			return HoldingHandsModel._Instance;
		}
	}

	// Token: 0x0600EC8B RID: 60555 RVA: 0x00383C8B File Offset: 0x00381E8B
	public static HoldingHandsModel GetOrCreateInstance()
	{
		if (HoldingHandsModel._Instance == null)
		{
			HoldingHandsModel.CreateInstance();
		}
		return HoldingHandsModel._Instance;
	}

	// Token: 0x0600EC8C RID: 60556 RVA: 0x00383C9F File Offset: 0x00381E9F
	public static bool CreateInstance()
	{
		if (HoldingHandsModel._Instance != null)
		{
			return true;
		}
		HoldingHandsModel._Instance = new HoldingHandsModel();
		return true;
	}

	// Token: 0x0600EC8D RID: 60557 RVA: 0x00383CB5 File Offset: 0x00381EB5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EC8E RID: 60558 RVA: 0x00383CB7 File Offset: 0x00381EB7
	public static void ResetStaticDefaultValue()
	{
		HoldingHandsModel._Instance = null;
	}

	// Token: 0x0600EC8F RID: 60559 RVA: 0x00383CBF File Offset: 0x00381EBF
	static HoldingHandsModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HoldingHandsModel.CreateStaticDefaultValue), new Action(HoldingHandsModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006DA2 RID: 28066
	public readonly Dictionary<string, HoldingHandsRelation> Relations = new Dictionary<string, HoldingHandsRelation>();

	// Token: 0x04006DA3 RID: 28067
	[Nullable(2)]
	private static HoldingHandsModel _Instance;
}
