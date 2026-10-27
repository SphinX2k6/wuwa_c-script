using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020034AB RID: 13483
[NullableContext(1)]
[Nullable(0)]
public class CombatDebugDrawController : ControllerBase
{
	// Token: 0x0601D5FB RID: 120315 RVA: 0x00831B00 File Offset: 0x0082FD00
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

	// Token: 0x0601D5FC RID: 120316 RVA: 0x00831C06 File Offset: 0x0082FE06
	protected override void OnTick(float delta)
	{
		bool debugMonsterControl = this.DebugMonsterControl;
	}

	// Token: 0x0601D5FD RID: 120317 RVA: 0x00831C0F File Offset: 0x0082FE0F
	[Conditional("DEBUG")]
	private void DrawMonsterControl()
	{
	}

	// Token: 0x0601D5FE RID: 120318 RVA: 0x00831C11 File Offset: 0x0082FE11
	[Conditional("DEBUG")]
	private void DrawEntityBox(int entityId)
	{
	}

	// Token: 0x170028BB RID: 10427
	// (get) Token: 0x0601D5FF RID: 120319 RVA: 0x00831C13 File Offset: 0x0082FE13
	public static CombatDebugDrawController Instance
	{
		get
		{
			return CombatDebugDrawController._Instance;
		}
	}

	// Token: 0x0601D600 RID: 120320 RVA: 0x00831C1A File Offset: 0x0082FE1A
	public static CombatDebugDrawController GetOrCreateInstance()
	{
		if (CombatDebugDrawController._Instance == null)
		{
			CombatDebugDrawController.CreateInstance();
		}
		return CombatDebugDrawController._Instance;
	}

	// Token: 0x0601D601 RID: 120321 RVA: 0x00831C2E File Offset: 0x0082FE2E
	public static bool CreateInstance()
	{
		if (CombatDebugDrawController._Instance != null)
		{
			return true;
		}
		CombatDebugDrawController._Instance = new CombatDebugDrawController();
		return true;
	}

	// Token: 0x0601D602 RID: 120322 RVA: 0x00831C44 File Offset: 0x0082FE44
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601D603 RID: 120323 RVA: 0x00831C46 File Offset: 0x0082FE46
	public static void ResetStaticDefaultValue()
	{
		CombatDebugDrawController._Instance = null;
	}

	// Token: 0x0601D604 RID: 120324 RVA: 0x00831C4E File Offset: 0x0082FE4E
	static CombatDebugDrawController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CombatDebugDrawController.CreateStaticDefaultValue), new Action(CombatDebugDrawController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E751 RID: 59217
	public bool DebugMonsterMovePath;

	// Token: 0x0400E752 RID: 59218
	public bool DebugMonsterControl;

	// Token: 0x0400E753 RID: 59219
	public bool IsDrawEntityBoxEnabled = true;

	// Token: 0x0400E754 RID: 59220
	public bool IsDrawEntityBoxInfoEnabled;

	// Token: 0x0400E755 RID: 59221
	protected FLinearColor RedColor;

	// Token: 0x0400E756 RID: 59222
	protected FLinearColor GreenColor;

	// Token: 0x0400E757 RID: 59223
	protected FLinearColor BlueColor;

	// Token: 0x0400E758 RID: 59224
	protected FLinearColor YellowColor;

	// Token: 0x0400E759 RID: 59225
	protected FLinearColor EntityBoxColor;

	// Token: 0x0400E75A RID: 59226
	protected FLinearColor EntityBoxColorInvincible;

	// Token: 0x0400E75B RID: 59227
	protected FLinearColor EntityBoxColorCollisionDisabled;

	// Token: 0x0400E75C RID: 59228
	protected FLinearColor EntityBoxInfoColor;

	// Token: 0x0400E75D RID: 59229
	private readonly Vector LocationCache1 = Vector.Create();

	// Token: 0x0400E75E RID: 59230
	private readonly Vector LocationCache2 = Vector.Create();

	// Token: 0x0400E75F RID: 59231
	private readonly Dictionary<int, Entity> PlayerIdToEntity = new Dictionary<int, Entity>();

	// Token: 0x0400E760 RID: 59232
	[Nullable(2)]
	private static CombatDebugDrawController _Instance;
}
