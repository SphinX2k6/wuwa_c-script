using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F56 RID: 12118
[NullableContext(1)]
[Nullable(0)]
public class DynamicModifyBuffStackEffect : BuffEffect
{
	// Token: 0x06019CA4 RID: 105636 RVA: 0x006B9BFC File Offset: 0x006B7DFC
	public DynamicModifyBuffStackEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CA5 RID: 105637 RVA: 0x006B9C18 File Offset: 0x006B7E18
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			this.BuffIds = Array.Empty<long>();
			return;
		}
		string[] array = extraEffectParameters_[0].Split('|', StringSplitOptions.None);
		this.BuffIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('#', StringSplitOptions.None);
			this.BuffIds[i] = ((array2.Length != 0) ? long.Parse(array2[0]) : 0L);
		}
	}

	// Token: 0x06019CA6 RID: 105638 RVA: 0x006B9C8B File Offset: 0x006B7E8B
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019CA7 RID: 105639 RVA: 0x006B9C8E File Offset: 0x006B7E8E
	public override void OnCreated()
	{
	}

	// Token: 0x06019CA8 RID: 105640 RVA: 0x006B9C90 File Offset: 0x006B7E90
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent != null)
		{
			foreach (long targetBuffId in this.BuffIds)
			{
				ownerBuffComponent.RemoveBuffStackModifier(targetBuffId, this.ActiveHandleId);
			}
		}
	}

	// Token: 0x0400C26D RID: 49773
	public long[] BuffIds = Array.Empty<long>();
}
