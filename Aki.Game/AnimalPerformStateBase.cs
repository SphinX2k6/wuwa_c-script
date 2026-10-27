using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal;

// Token: 0x02002E2D RID: 11821
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AnimalPerformStateBase : StateBase<Entity, EAnimalPerformState>
{
	// Token: 0x06018E5C RID: 101980 RVA: 0x0066AF7F File Offset: 0x0066917F
	[NullableContext(1)]
	public AnimalPerformStateBase(Entity owner, EAnimalPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<Entity, EAnimalPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x1700227F RID: 8831
	// (get) Token: 0x06018E5D RID: 101981 RVA: 0x0066AF8A File Offset: 0x0066918A
	// (set) Token: 0x06018E5E RID: 101982 RVA: 0x0066AF92 File Offset: 0x00669192
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

	// Token: 0x06018E5F RID: 101983 RVA: 0x0066AF9B File Offset: 0x0066919B
	protected override void OnCreate(IEntityArgs args = null)
	{
		this.EcologicalInterface = args.GetP1<IBPI_AnimalEcological_C>();
	}

	// Token: 0x06018E60 RID: 101984 RVA: 0x0066AFA9 File Offset: 0x006691A9
	protected override void OnDestroy()
	{
		this.AnimalEcologicalInterface = null;
		this.StateMachine = null;
	}

	// Token: 0x06018E61 RID: 101985 RVA: 0x0066AFB9 File Offset: 0x006691B9
	public float GetActionTime()
	{
		return this.ActionTime;
	}

	// Token: 0x0400BADF RID: 47839
	protected IBPI_AnimalEcological_C EcologicalInterface;

	// Token: 0x0400BAE0 RID: 47840
	protected float ActionTime;
}
