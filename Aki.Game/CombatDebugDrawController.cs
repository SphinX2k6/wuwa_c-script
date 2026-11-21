using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002A1F RID: 10783
[NullableContext(1)]
[Nullable(0)]
public class CombatDebugDrawController : ControllerBase
{
	// Token: 0x0601B2FA RID: 111354 RVA: 0x00858F20 File Offset: 0x00857120
	protected override bool OnInit()
	{
		this.RedColor = new FLinearColor(1f, 0f, 0f, 1f);
		this.GreenColor = new FLinearColor(0f, 1f, 0f, 1f);
		this.BlueColor = new FLinearColor(0f, 0f, 1f, 1f);
		this.YellowColor = new FLinearColor(1f, 1f, 0f, 1f);
		this.EntityBoxColor = new FLinearColor(0.8f, 0.8f, 0f, 0.5f);
		this.EntityBoxColorInvincible = new FLinearColor(0.5f, 0.5f, 1f, 1f);
		this.EntityBoxColorCollisionDisabled = new FLinearColor(0.5f, 0.5f, 0.5f, 0.5f);
		this.EntityBoxInfoColor = new FLinearColor(0.8f, 0.8f, 1f, 0.5f);
		return true;
	}

	// Token: 0x0601B2FB RID: 111355 RVA: 0x00859026 File Offset: 0x00857226
	protected override void OnTick(float delta)
	{
		bool debugMonsterControl = this.DebugMonsterControl;
	}

	// Token: 0x0601B2FC RID: 111356 RVA: 0x0085902F File Offset: 0x0085722F
	[Conditional("DEBUG")]
	private void DrawMonsterControl()
	{
	}

	// Token: 0x0601B2FD RID: 111357 RVA: 0x00859031 File Offset: 0x00857231
	[Conditional("DEBUG")]
	private void DrawEntityBox(int entityId)
	{
	}

	// Token: 0x17002C53 RID: 11347
	// (get) Token: 0x0601B2FE RID: 111358 RVA: 0x00859033 File Offset: 0x00857233
	public static CombatDebugDrawController Instance
	{
		get
		{
			return CombatDebugDrawController._Instance;
		}
	}

	// Token: 0x0601B2FF RID: 111359 RVA: 0x0085903A File Offset: 0x0085723A
	public static CombatDebugDrawController GetOrCreateInstance()
	{
		if (CombatDebugDrawController._Instance == null)
		{
			CombatDebugDrawController.CreateInstance();
		}
		return CombatDebugDrawController._Instance;
	}

	// Token: 0x0601B300 RID: 111360 RVA: 0x0085904E File Offset: 0x0085724E
	public static bool CreateInstance()
	{
		if (CombatDebugDrawController._Instance != null)
		{
			return true;
		}
		CombatDebugDrawController._Instance = new CombatDebugDrawController();
		return true;
	}

	// Token: 0x0601B301 RID: 111361 RVA: 0x00859064 File Offset: 0x00857264
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B302 RID: 111362 RVA: 0x00859066 File Offset: 0x00857266
	public static void ResetStaticDefaultValue()
	{
		CombatDebugDrawController._Instance = null;
	}

	// Token: 0x0601B303 RID: 111363 RVA: 0x0085906E File Offset: 0x0085726E
	static CombatDebugDrawController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CombatDebugDrawController.CreateStaticDefaultValue), new Action(CombatDebugDrawController.ResetStaticDefaultValue));
	}

	// Token: 0x0400EC05 RID: 60421
	public bool DebugMonsterMovePath;

	// Token: 0x0400EC06 RID: 60422
	public bool DebugMonsterControl;

	// Token: 0x0400EC07 RID: 60423
	public bool IsDrawEntityBoxEnabled = true;

	// Token: 0x0400EC08 RID: 60424
	public bool IsDrawEntityBoxInfoEnabled;

	// Token: 0x0400EC09 RID: 60425
	protected FLinearColor RedColor;

	// Token: 0x0400EC0A RID: 60426
	protected FLinearColor GreenColor;

	// Token: 0x0400EC0B RID: 60427
	protected FLinearColor BlueColor;

	// Token: 0x0400EC0C RID: 60428
	protected FLinearColor YellowColor;

	// Token: 0x0400EC0D RID: 60429
	protected FLinearColor EntityBoxColor;

	// Token: 0x0400EC0E RID: 60430
	protected FLinearColor EntityBoxColorInvincible;

	// Token: 0x0400EC0F RID: 60431
	protected FLinearColor EntityBoxColorCollisionDisabled;

	// Token: 0x0400EC10 RID: 60432
	protected FLinearColor EntityBoxInfoColor;

	// Token: 0x0400EC11 RID: 60433
	private readonly Vector LocationCache1 = Vector.Create();

	// Token: 0x0400EC12 RID: 60434
	private readonly Vector LocationCache2 = Vector.Create();

	// Token: 0x0400EC13 RID: 60435
	private readonly Dictionary<int, Entity> PlayerIdToEntity = new Dictionary<int, Entity>();

	// Token: 0x0400EC14 RID: 60436
	[Nullable(2)]
	private static CombatDebugDrawController _Instance;
}
