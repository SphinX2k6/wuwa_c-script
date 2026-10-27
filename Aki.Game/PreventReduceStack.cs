using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F49 RID: 12105
[NullableContext(1)]
[Nullable(0)]
public class PreventReduceStack : BuffEffect
{
	// Token: 0x06019C51 RID: 105553 RVA: 0x006B7C9B File Offset: 0x006B5E9B
	public PreventReduceStack(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C52 RID: 105554 RVA: 0x006B7CB8 File Offset: 0x006B5EB8
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

	// Token: 0x06019C53 RID: 105555 RVA: 0x006B7D0C File Offset: 0x006B5F0C
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

	// Token: 0x06019C54 RID: 105556 RVA: 0x006B7D44 File Offset: 0x006B5F44
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C55 RID: 105557 RVA: 0x006B7D48 File Offset: 0x006B5F48
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

	// Token: 0x06019C56 RID: 105558 RVA: 0x006B7D80 File Offset: 0x006B5F80
	public override string GetDebugEffectString()
	{
		return "阻止buff" + string.Join<long>(",", this.InvolvedBuffIds) + "随时间自然衰减";
	}

	// Token: 0x0400C240 RID: 49728
	protected long[] InvolvedBuffIds = Array.Empty<long>();
}
