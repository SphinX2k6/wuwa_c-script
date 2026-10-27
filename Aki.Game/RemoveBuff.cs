using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F67 RID: 12135
[NullableContext(1)]
[Nullable(0)]
public class RemoveBuff : BuffEffect
{
	// Token: 0x06019CEA RID: 105706 RVA: 0x006BAEC8 File Offset: 0x006B90C8
	public RemoveBuff(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CEB RID: 105707 RVA: 0x006BAED8 File Offset: 0x006B90D8
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		string text = (extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? extraEffectParameters_[0] : "0";
		if (string.IsNullOrEmpty(text))
		{
			text = "0";
		}
		string[] array = text.Split('#', StringSplitOptions.None);
		this.TriggerTypes = new int[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.TriggerTypes[i] = int.Parse(array[i]);
		}
	}

	// Token: 0x06019CEC RID: 105708 RVA: 0x006BAF44 File Offset: 0x006B9144
	public override void OnCreated()
	{
		EntityHandle instigatorEntity = base.InstigatorEntity;
		if (instigatorEntity == null || !instigatorEntity.Valid)
		{
			return;
		}
		if (this.TriggerTypes == null)
		{
			return;
		}
		foreach (int num in this.TriggerTypes)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(base.InstigatorEntity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnInstigatorRemoved));
				}
			}
			else
			{
				EventSystem.Instance.AddWithTarget(base.InstigatorEntity.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnInstigatorDead));
			}
		}
	}

	// Token: 0x06019CED RID: 105709 RVA: 0x006BAFE0 File Offset: 0x006B91E0
	public override void OnRemoved(bool bPremature)
	{
		EntityHandle instigatorEntity = base.InstigatorEntity;
		if (instigatorEntity == null || !instigatorEntity.Valid)
		{
			return;
		}
		if (this.TriggerTypes == null)
		{
			return;
		}
		foreach (int num in this.TriggerTypes)
		{
			if (num != 0)
			{
				if (num == 1)
				{
					EventSystem.Instance.RemoveWithTarget(base.InstigatorEntity, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnInstigatorRemoved));
				}
			}
			else
			{
				EventSystem.Instance.RemoveWithTarget(base.InstigatorEntity.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnInstigatorDead));
			}
		}
	}

	// Token: 0x06019CEE RID: 105710 RVA: 0x006BB07B File Offset: 0x006B927B
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019CEF RID: 105711 RVA: 0x006BB080 File Offset: 0x006B9280
	private void OnInstigatorDead()
	{
		if (this.OwnerBuffComponent.HasBuffAuthority())
		{
			this.OwnerBuffComponent.RemoveBuffByHandle(this.ActiveHandleId, -1, "buff施加者死亡导致移除", null, null, null);
		}
	}

	// Token: 0x06019CF0 RID: 105712 RVA: 0x006BB0D0 File Offset: 0x006B92D0
	private void OnInstigatorRemoved(ERemoveEntityType removeType, EntityHandle handle)
	{
		if (handle == base.InstigatorEntity && this.OwnerBuffComponent.HasBuffAuthority())
		{
			this.OwnerBuffComponent.RemoveBuffByHandle(this.ActiveHandleId, -1, "buff施加者被移除导致移除", null, null, null);
		}
	}

	// Token: 0x0400C2AF RID: 49839
	[Nullable(2)]
	private int[] TriggerTypes;
}
