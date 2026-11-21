using System;
using System.Runtime.CompilerServices;

// Token: 0x0200252F RID: 9519
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PassiveSkillPlayerQueueController : ControllerBase
{
	// Token: 0x060178AE RID: 96430 RVA: 0x006F3B57 File Offset: 0x006F1D57
	protected override bool OnInit()
	{
		this.Queue.Clear();
		return true;
	}

	// Token: 0x060178AF RID: 96431 RVA: 0x006F3B65 File Offset: 0x006F1D65
	protected override bool OnClear()
	{
		this.Queue.Clear();
		return true;
	}

	// Token: 0x060178B0 RID: 96432 RVA: 0x006F3B73 File Offset: 0x006F1D73
	public bool DoAction(TPassiveSkillQueueCallback func)
	{
		return this.Queue.DoActionCheckCd(func);
	}

	// Token: 0x1700247B RID: 9339
	// (get) Token: 0x060178B1 RID: 96433 RVA: 0x006F3B81 File Offset: 0x006F1D81
	public static PassiveSkillPlayerQueueController Instance
	{
		get
		{
			return PassiveSkillPlayerQueueController._Instance;
		}
	}

	// Token: 0x060178B2 RID: 96434 RVA: 0x006F3B88 File Offset: 0x006F1D88
	public static PassiveSkillPlayerQueueController GetOrCreateInstance()
	{
		if (PassiveSkillPlayerQueueController._Instance == null)
		{
			PassiveSkillPlayerQueueController.CreateInstance();
		}
		return PassiveSkillPlayerQueueController._Instance;
	}

	// Token: 0x060178B3 RID: 96435 RVA: 0x006F3B9C File Offset: 0x006F1D9C
	public static bool CreateInstance()
	{
		if (PassiveSkillPlayerQueueController._Instance != null)
		{
			return true;
		}
		PassiveSkillPlayerQueueController._Instance = new PassiveSkillPlayerQueueController();
		return true;
	}

	// Token: 0x060178B4 RID: 96436 RVA: 0x006F3BB2 File Offset: 0x006F1DB2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060178B5 RID: 96437 RVA: 0x006F3BB4 File Offset: 0x006F1DB4
	public static void ResetStaticDefaultValue()
	{
		PassiveSkillPlayerQueueController._Instance = null;
	}

	// Token: 0x060178B6 RID: 96438 RVA: 0x006F3BBC File Offset: 0x006F1DBC
	static PassiveSkillPlayerQueueController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PassiveSkillPlayerQueueController.CreateStaticDefaultValue), new Action(PassiveSkillPlayerQueueController.ResetStaticDefaultValue));
	}

	// Token: 0x0400C864 RID: 51300
	private readonly PassiveSkillPlayerQueue Queue = new PassiveSkillPlayerQueue();

	// Token: 0x0400C865 RID: 51301
	[Nullable(2)]
	private static PassiveSkillPlayerQueueController _Instance;
}
