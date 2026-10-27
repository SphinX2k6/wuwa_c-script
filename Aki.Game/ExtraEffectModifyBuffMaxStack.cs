using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F4C RID: 12108
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectModifyBuffMaxStack : BuffEffect
{
	// Token: 0x06019C64 RID: 105572 RVA: 0x006B8523 File Offset: 0x006B6723
	public ExtraEffectModifyBuffMaxStack(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C65 RID: 105573 RVA: 0x006B8548 File Offset: 0x006B6748
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

	// Token: 0x06019C66 RID: 105574 RVA: 0x006B85C4 File Offset: 0x006B67C4
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

	// Token: 0x06019C67 RID: 105575 RVA: 0x006B860B File Offset: 0x006B680B
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C68 RID: 105576 RVA: 0x006B8610 File Offset: 0x006B6810
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

	// Token: 0x06019C69 RID: 105577 RVA: 0x006B8656 File Offset: 0x006B6856
	public override string GetDebugEffectString()
	{
		return "修改buff" + string.Join<long>(",", this.InvolvedBuffIds) + " 修改层数" + string.Join<int>(",", this.StackValues);
	}

	// Token: 0x0400C248 RID: 49736
	protected long[] InvolvedBuffIds = Array.Empty<long>();

	// Token: 0x0400C249 RID: 49737
	protected int[] StackValues = Array.Empty<int>();
}
