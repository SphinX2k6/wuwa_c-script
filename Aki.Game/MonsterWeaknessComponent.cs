using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;

// Token: 0x020031CE RID: 12750
[NullableContext(1)]
[Nullable(0)]
public class MonsterWeaknessComponent : EntityComponent
{
	// Token: 0x17002605 RID: 9733
	// (get) Token: 0x0601B7C0 RID: 112576 RVA: 0x00787ADF File Offset: 0x00785CDF
	public string TargetSocket
	{
		get
		{
			return this.TargetSocketInternal;
		}
	}

	// Token: 0x0601B7C1 RID: 112577 RVA: 0x00787AE7 File Offset: 0x00785CE7
	protected override bool OnStart()
	{
		PawnInteractNewComponent component = base.Entity.GetComponent<PawnInteractNewComponent>();
		this.InteractController = ((component != null) ? component.GetInteractController() : null);
		return true;
	}

	// Token: 0x0601B7C2 RID: 112578 RVA: 0x00787B07 File Offset: 0x00785D07
	protected override bool OnEnd()
	{
		return true;
	}

	// Token: 0x0601B7C3 RID: 112579 RVA: 0x00787B0C File Offset: 0x00785D0C
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

	// Token: 0x0601B7C4 RID: 112580 RVA: 0x00787B98 File Offset: 0x00785D98
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

	// Token: 0x0601B7C5 RID: 112581 RVA: 0x00787BEC File Offset: 0x00785DEC
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

	// Token: 0x0601B7C6 RID: 112582 RVA: 0x00787C4C File Offset: 0x00785E4C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MonsterWeaknessComponent monsterWeaknessComponent = (MonsterWeaknessComponent)componentTemplate;
		if (base.CanResetComponentProperty("InteractController"))
		{
			if (monsterWeaknessComponent.InteractController == null)
			{
				this.InteractController = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnInteractController>(this.InteractController), "InteractController"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InteractHandle"))
		{
			this.InteractHandle = monsterWeaknessComponent.InteractHandle;
		}
		if (base.CanResetComponentProperty("TargetSocketInternal"))
		{
			this.TargetSocketInternal = monsterWeaknessComponent.TargetSocketInternal;
		}
		return true;
	}

	// Token: 0x0400D7AF RID: 55215
	[Nullable(2)]
	private PawnInteractController InteractController;

	// Token: 0x0400D7B0 RID: 55216
	private int InteractHandle;

	// Token: 0x0400D7B1 RID: 55217
	private string TargetSocketInternal = "";
}
