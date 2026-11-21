using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;

// Token: 0x0200273D RID: 10045
[NullableContext(1)]
[Nullable(0)]
public class MonsterWeaknessComponent : EntityComponent
{
	// Token: 0x17002819 RID: 10265
	// (get) Token: 0x06019309 RID: 103177 RVA: 0x007AFB2D File Offset: 0x007ADD2D
	public string TargetSocket
	{
		get
		{
			return this.TargetSocketInternal;
		}
	}

	// Token: 0x0601930A RID: 103178 RVA: 0x007AFB35 File Offset: 0x007ADD35
	protected override bool OnStart()
	{
		PawnInteractNewComponent component = base.Entity.GetComponent<PawnInteractNewComponent>();
		this.InteractController = ((component != null) ? component.GetInteractController() : null);
		return true;
	}

	// Token: 0x0601930B RID: 103179 RVA: 0x007AFB55 File Offset: 0x007ADD55
	protected override bool OnEnd()
	{
		return true;
	}

	// Token: 0x0601930C RID: 103180 RVA: 0x007AFB58 File Offset: 0x007ADD58
	public void ShowWeaknessButton(string targetSocket)
	{
		if (this.InteractHandle != 0)
		{
			this.HideWeaknessButton();
		}
		CombatLog instance = CombatLog.Instance;
		CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
		Entity entity = base.Entity;
		string message = "激活破弱按钮";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("socket", targetSocket);
		instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.TargetSocketInternal = targetSocket;
		PawnInteractController interactController = this.InteractController;
		this.InteractHandle = ((interactController != null) ? interactController.AddClientInteractOption(new BreakWeakness(), null, new EDoInteract?(EDoInteract.Direct), new float?(float.MaxValue), null, new ECustomOptionType?(ECustomOptionType.BreakWeakness), null, null) : 0);
	}

	// Token: 0x0601930D RID: 103181 RVA: 0x007AFBE4 File Offset: 0x007ADDE4
	public void UpdateTargetSocket(string targetSocket)
	{
		if (this.InteractHandle != 0 && this.TargetSocketInternal != targetSocket)
		{
			this.TargetSocketInternal = targetSocket;
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
			Entity entity = base.Entity;
			string message = "更新破弱按钮Socket";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("socket", targetSocket);
			instance.Info(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x0601930E RID: 103182 RVA: 0x007AFC38 File Offset: 0x007ADE38
	public void HideWeaknessButton()
	{
		if (this.InteractHandle != 0)
		{
			CombatLog.Instance.Info(CombatLog.EDebugModule.Skill, base.Entity, "移除破弱按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
			PawnInteractController interactController = this.InteractController;
			if (interactController != null)
			{
				interactController.RemoveClientInteractOption(this.InteractHandle);
			}
			this.InteractHandle = 0;
			this.TargetSocketInternal = "";
		}
	}

	// Token: 0x0601930F RID: 103183 RVA: 0x007AFC98 File Offset: 0x007ADE98
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MonsterWeaknessComponent monsterWeaknessComponent = (MonsterWeaknessComponent)componentTemplate;
		if (monsterWeaknessComponent.InteractController == null)
		{
			this.InteractController = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InteractController), "InteractController"))
		{
			return false;
		}
		this.InteractHandle = monsterWeaknessComponent.InteractHandle;
		this.TargetSocketInternal = monsterWeaknessComponent.TargetSocketInternal;
		return true;
	}

	// Token: 0x1700281A RID: 10266
	// (get) Token: 0x06019310 RID: 103184 RVA: 0x007AFCFB File Offset: 0x007ADEFB
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700281B RID: 10267
	// (get) Token: 0x06019311 RID: 103185 RVA: 0x007AFCFE File Offset: 0x007ADEFE
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400DC36 RID: 56374
	[Nullable(2)]
	private PawnInteractController InteractController;

	// Token: 0x0400DC37 RID: 56375
	private int InteractHandle;

	// Token: 0x0400DC38 RID: 56376
	private string TargetSocketInternal = "";
}
