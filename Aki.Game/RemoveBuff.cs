using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020024BB RID: 9403
[NullableContext(1)]
[Nullable(0)]
public class RemoveBuff : BuffEffect
{
	// Token: 0x060175FC RID: 95740 RVA: 0x006E17B4 File Offset: 0x006DF9B4
	public RemoveBuff(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175FD RID: 95741 RVA: 0x006E17C4 File Offset: 0x006DF9C4
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

	// Token: 0x060175FE RID: 95742 RVA: 0x006E1830 File Offset: 0x006DFA30
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

	// Token: 0x060175FF RID: 95743 RVA: 0x006E18CC File Offset: 0x006DFACC
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

	// Token: 0x06017600 RID: 95744 RVA: 0x006E1967 File Offset: 0x006DFB67
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06017601 RID: 95745 RVA: 0x006E196C File Offset: 0x006DFB6C
	private void OnInstigatorDead()
	{
		if (this.OwnerBuffComponent.HasBuffAuthority())
		{
			this.OwnerBuffComponent.RemoveBuffByHandle(this.ActiveHandleId, -1, "buff施加者死亡导致移除", null, null, null);
		}
	}

	// Token: 0x06017602 RID: 95746 RVA: 0x006E19BC File Offset: 0x006DFBBC
	private void OnInstigatorRemoved(ERemoveEntityType removeType, EntityHandle handle)
	{
		if (handle == base.InstigatorEntity && this.OwnerBuffComponent.HasBuffAuthority())
		{
			this.OwnerBuffComponent.RemoveBuffByHandle(this.ActiveHandleId, -1, "buff施加者被移除导致移除", null, null, null);
		}
	}

	// Token: 0x0400C658 RID: 50776
	[Nullable(2)]
	private int[] TriggerTypes;
}
