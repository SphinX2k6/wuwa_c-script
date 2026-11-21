using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal;

// Token: 0x02002389 RID: 9097
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AnimalPerformStateBase : StateBase<Entity, EAnimalPerformState>
{
	// Token: 0x06016729 RID: 91945 RVA: 0x00690E6F File Offset: 0x0068F06F
	[NullableContext(1)]
	public AnimalPerformStateBase(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x170022F2 RID: 8946
	// (get) Token: 0x0601672A RID: 91946 RVA: 0x00690E7A File Offset: 0x0068F07A
	// (set) Token: 0x0601672B RID: 91947 RVA: 0x00690E82 File Offset: 0x0068F082
	public IBPI_AnimalEcological_C AnimalEcologicalInterface
	{
		get
		{
			return this.EcologicalInterface;
		}
		set
		{
			this.EcologicalInterface = value;
		}
	}

	// Token: 0x0601672C RID: 91948 RVA: 0x00690E8B File Offset: 0x0068F08B
	protected override void OnCreate(IEntityArgs args = null)
	{
		this.EcologicalInterface = args.GetP1<IBPI_AnimalEcological_C>();
	}

	// Token: 0x0601672D RID: 91949 RVA: 0x00690E99 File Offset: 0x0068F099
	protected override void OnDestroy()
	{
		this.AnimalEcologicalInterface = null;
		this.StateMachine = null;
	}

	// Token: 0x0601672E RID: 91950 RVA: 0x00690EA9 File Offset: 0x0068F0A9
	public float GetActionTime()
	{
		return this.ActionTime;
	}

	// Token: 0x0400BE6D RID: 48749
	protected IBPI_AnimalEcological_C EcologicalInterface;

	// Token: 0x0400BE6E RID: 48750
	protected float ActionTime;
}
