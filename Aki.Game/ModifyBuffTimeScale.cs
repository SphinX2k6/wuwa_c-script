using System;
using System.Runtime.CompilerServices;

// Token: 0x020024A4 RID: 9380
[NullableContext(1)]
[Nullable(0)]
public class ModifyBuffTimeScale : BuffEffect
{
	// Token: 0x06017584 RID: 95620 RVA: 0x006DF00B File Offset: 0x006DD20B
	public ModifyBuffTimeScale(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06017585 RID: 95621 RVA: 0x006DF030 File Offset: 0x006DD230
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length < 3)
		{
			return;
		}
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		if (array.Length != 0)
		{
			this.ChangePreBuff = (int.Parse(array[0]) == 1);
		}
		if (array.Length > 1)
		{
			this.ChangeBuffIfInDuration = (int.Parse(array[1]) == 1);
		}
		string[] array2 = extraEffectParameters_[1].Split('#', StringSplitOptions.None);
		this.BuffIds = new long[array2.Length];
		for (int i = 0; i < array2.Length; i++)
		{
			this.BuffIds[i] = long.Parse(array2[i]);
		}
		this.TimeScale = (float)int.Parse(extraEffectParameters_[2]) * 0.0001f;
	}

	// Token: 0x06017586 RID: 95622 RVA: 0x006DF0D4 File Offset: 0x006DD2D4
	public override void OnCreated()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			return;
		}
		if (this.ChangePreBuff)
		{
			foreach (long buffId in this.BuffIds)
			{
				foreach (ActiveBuffInternal activeBuffInternal in ownerBuffComponent.GetAllBuffById(buffId))
				{
					activeBuffInternal.SetBuffTimeScale(this.ActiveHandleId, this.TimeScale);
				}
			}
		}
		Entity ownerEntity = base.OwnerEntity;
		if (this.ChangeBuffIfInDuration && ownerEntity != null)
		{
			foreach (long key in this.BuffIds)
			{
				AbilityEvent.Instance.Add(ownerEntity, EAbilityEventName.OnBuffAdd, key, new Action<long, int>(this.OnBuffAdd));
			}
		}
	}

	// Token: 0x06017587 RID: 95623 RVA: 0x006DF1A4 File Offset: 0x006DD3A4
	private void OnBuffAdd(long buffId, int handle)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		IActiveBuff activeBuff = (ownerBuffComponent != null) ? ownerBuffComponent.GetBuffByHandle(handle) : null;
		if (activeBuff == null)
		{
			return;
		}
		activeBuff.SetBuffTimeScale(this.ActiveHandleId, this.TimeScale);
	}

	// Token: 0x06017588 RID: 95624 RVA: 0x006DF1D0 File Offset: 0x006DD3D0
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		if (ownerBuffComponent == null)
		{
			return;
		}
		foreach (long buffId in this.BuffIds)
		{
			foreach (ActiveBuffInternal activeBuffInternal in ownerBuffComponent.GetAllBuffById(buffId))
			{
				activeBuffInternal.RemoveBuffTimeScale(this.ActiveHandleId);
			}
		}
		Entity ownerEntity = base.OwnerEntity;
		if (this.ChangeBuffIfInDuration && ownerEntity != null)
		{
			foreach (long key in this.BuffIds)
			{
				AbilityEvent.Instance.Remove(ownerEntity, EAbilityEventName.OnBuffAdd, key, new Action<long, int>(this.OnBuffAdd));
			}
		}
	}

	// Token: 0x06017589 RID: 95625 RVA: 0x006DF294 File Offset: 0x006DD494
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x0601758A RID: 95626 RVA: 0x006DF297 File Offset: 0x006DD497
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C5FB RID: 50683
	private bool ChangePreBuff;

	// Token: 0x0400C5FC RID: 50684
	private bool ChangeBuffIfInDuration;

	// Token: 0x0400C5FD RID: 50685
	private long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C5FE RID: 50686
	private float TimeScale = 1f;
}
