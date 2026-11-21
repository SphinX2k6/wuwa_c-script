using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200249F RID: 9375
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectModifyBuffMaxStack : BuffEffect
{
	// Token: 0x0601756F RID: 95599 RVA: 0x006DE83F File Offset: 0x006DCA3F
	public ExtraEffectModifyBuffMaxStack(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017570 RID: 95600 RVA: 0x006DE864 File Offset: 0x006DCA64
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null)
		{
			List<long> list = new List<long>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < extraEffectParameters_.Length; i++)
			{
				string[] array = extraEffectParameters_[i].Split('#', StringSplitOptions.None);
				if (array.Length >= 2)
				{
					list.Add(long.Parse(array[0]));
					list2.Add(int.Parse(array[1]));
				}
			}
			this.InvolvedBuffIds = list.ToArray();
			this.StackValues = list2.ToArray();
		}
	}

	// Token: 0x06017571 RID: 95601 RVA: 0x006DE8E0 File Offset: 0x006DCAE0
	public override void OnCreated()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent != null)
		{
			for (int i = 0; i < this.InvolvedBuffIds.Length; i++)
			{
				ownerBuffComponent.AddBuffStackModifier(this.InvolvedBuffIds[i], this.ActiveHandleId, this.StackValues[i], EBuffStackModifierType.Incremental);
			}
		}
	}

	// Token: 0x06017572 RID: 95602 RVA: 0x006DE927 File Offset: 0x006DCB27
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017573 RID: 95603 RVA: 0x006DE92C File Offset: 0x006DCB2C
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent != null && this.InvolvedBuffIds.Length != 0)
		{
			foreach (long targetBuffId in this.InvolvedBuffIds)
			{
				ownerBuffComponent.RemoveBuffStackModifier(targetBuffId, this.ActiveHandleId);
			}
		}
	}

	// Token: 0x06017574 RID: 95604 RVA: 0x006DE972 File Offset: 0x006DCB72
	public override string GetDebugEffectString()
	{
		return "修改buff" + string.Join<long>(",", this.InvolvedBuffIds) + " 修改层数" + string.Join<int>(",", this.StackValues);
	}

	// Token: 0x0400C5EA RID: 50666
	protected long[] InvolvedBuffIds = Array.Empty<long>();

	// Token: 0x0400C5EB RID: 50667
	protected int[] StackValues = Array.Empty<int>();
}
