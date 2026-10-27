using System;
using System.Runtime.CompilerServices;

// Token: 0x02002FDA RID: 12250
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class PassiveSkillPlayerQueueController : ControllerBase
{
	// Token: 0x06019F7B RID: 106363 RVA: 0x006CBD17 File Offset: 0x006C9F17
	protected override bool OnInit()
	{
		this.Queue.Clear();
		return true;
	}

	// Token: 0x06019F7C RID: 106364 RVA: 0x006CBD25 File Offset: 0x006C9F25
	protected override bool OnClear()
	{
		this.Queue.Clear();
		return true;
	}

	// Token: 0x06019F7D RID: 106365 RVA: 0x006CBD33 File Offset: 0x006C9F33
	public bool DoAction(TPassiveSkillQueueCallback func)
	{
		return this.Queue.DoActionCheckCd(func);
	}

	// Token: 0x170023B9 RID: 9145
	// (get) Token: 0x06019F7E RID: 106366 RVA: 0x006CBD41 File Offset: 0x006C9F41
	public static PassiveSkillPlayerQueueController Instance
	{
		get
		{
			return PassiveSkillPlayerQueueController._Instance;
		}
	}

	// Token: 0x06019F7F RID: 106367 RVA: 0x006CBD48 File Offset: 0x006C9F48
	public static PassiveSkillPlayerQueueController GetOrCreateInstance()
	{
		if (PassiveSkillPlayerQueueController._Instance == null)
		{
			PassiveSkillPlayerQueueController.CreateInstance();
		}
		return PassiveSkillPlayerQueueController._Instance;
	}

	// Token: 0x06019F80 RID: 106368 RVA: 0x006CBD5C File Offset: 0x006C9F5C
	public static bool CreateInstance()
	{
		if (PassiveSkillPlayerQueueController._Instance != null)
		{
			return true;
		}
		PassiveSkillPlayerQueueController._Instance = new PassiveSkillPlayerQueueController();
		return true;
	}

	// Token: 0x06019F81 RID: 106369 RVA: 0x006CBD72 File Offset: 0x006C9F72
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06019F82 RID: 106370 RVA: 0x006CBD74 File Offset: 0x006C9F74
	public static void ResetStaticDefaultValue()
	{
		PassiveSkillPlayerQueueController._Instance = null;
	}

	// Token: 0x06019F83 RID: 106371 RVA: 0x006CBD7C File Offset: 0x006C9F7C
	static PassiveSkillPlayerQueueController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PassiveSkillPlayerQueueController.CreateStaticDefaultValue), new Action(PassiveSkillPlayerQueueController.ResetStaticDefaultValue));
	}

	// Token: 0x0400C49C RID: 50332
	private readonly PassiveSkillPlayerQueue Queue = new PassiveSkillPlayerQueue();

	// Token: 0x0400C49D RID: 50333
	[Nullable(2)]
	private static PassiveSkillPlayerQueueController _Instance;
}
