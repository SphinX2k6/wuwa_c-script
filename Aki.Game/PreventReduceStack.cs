using System;
using System.Runtime.CompilerServices;

// Token: 0x0200249C RID: 9372
[NullableContext(1)]
[Nullable(0)]
public class PreventReduceStack : BuffEffect
{
	// Token: 0x0601755C RID: 95580 RVA: 0x006DDFB7 File Offset: 0x006DC1B7
	public PreventReduceStack(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601755D RID: 95581 RVA: 0x006DDFD4 File Offset: 0x006DC1D4
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
			this.InvolvedBuffIds = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.InvolvedBuffIds[i] = long.Parse(array[i]);
			}
		}
	}

	// Token: 0x0601755E RID: 95582 RVA: 0x006DE028 File Offset: 0x006DC228
	public override void OnCreated()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			return;
		}
		foreach (long buffId in this.InvolvedBuffIds)
		{
			ownerBuffComponent.AddBuffRoutineExpirationLock(buffId);
		}
	}

	// Token: 0x0601755F RID: 95583 RVA: 0x006DE060 File Offset: 0x006DC260
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017560 RID: 95584 RVA: 0x006DE064 File Offset: 0x006DC264
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			return;
		}
		foreach (long buffId in this.InvolvedBuffIds)
		{
			ownerBuffComponent.RemoveBuffRoutineExpirationLock(buffId);
		}
	}

	// Token: 0x06017561 RID: 95585 RVA: 0x006DE09C File Offset: 0x006DC29C
	public override string GetDebugEffectString()
	{
		return "阻止buff" + string.Join<long>(",", this.InvolvedBuffIds) + "随时间自然衰减";
	}

	// Token: 0x0400C5E2 RID: 50658
	protected long[] InvolvedBuffIds = Array.Empty<long>();
}
