using System;
using System.Runtime.CompilerServices;

// Token: 0x02002F51 RID: 12113
[NullableContext(1)]
[Nullable(0)]
public class ModifyBuffTimeScale : BuffEffect
{
	// Token: 0x06019C79 RID: 105593 RVA: 0x006B8CEF File Offset: 0x006B6EEF
	public ModifyBuffTimeScale(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019C7A RID: 105594 RVA: 0x006B8D14 File Offset: 0x006B6F14
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

	// Token: 0x06019C7B RID: 105595 RVA: 0x006B8DB8 File Offset: 0x006B6FB8
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

	// Token: 0x06019C7C RID: 105596 RVA: 0x006B8E88 File Offset: 0x006B7088
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

	// Token: 0x06019C7D RID: 105597 RVA: 0x006B8EB4 File Offset: 0x006B70B4
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

	// Token: 0x06019C7E RID: 105598 RVA: 0x006B8F78 File Offset: 0x006B7178
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019C7F RID: 105599 RVA: 0x006B8F7B File Offset: 0x006B717B
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C259 RID: 49753
	private bool ChangePreBuff;

	// Token: 0x0400C25A RID: 49754
	private bool ChangeBuffIfInDuration;

	// Token: 0x0400C25B RID: 49755
	private long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C25C RID: 49756
	private float TimeScale = 1f;
}
