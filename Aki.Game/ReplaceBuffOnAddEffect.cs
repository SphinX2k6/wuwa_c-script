using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020024AC RID: 9388
[NullableContext(1)]
[Nullable(0)]
public class ReplaceBuffOnAddEffect : BuffEffect
{
	// Token: 0x060175C6 RID: 95686 RVA: 0x006E077C File Offset: 0x006DE97C
	public ReplaceBuffOnAddEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060175C7 RID: 95687 RVA: 0x006E0798 File Offset: 0x006DE998
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		this.ReplaceBuffMap.Clear();
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length < 2)
		{
			return;
		}
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		string[] array2 = extraEffectParameters_[1].Split('#', StringSplitOptions.None);
		int num = Math.Min(array.Length, array2.Length);
		for (int i = 0; i < num; i++)
		{
			this.ReplaceBuffMap[long.Parse(array[i])] = long.Parse(array2[i]);
		}
	}

	// Token: 0x060175C8 RID: 95688 RVA: 0x006E0814 File Offset: 0x006DEA14
	public override void OnCreated()
	{
		foreach (KeyValuePair<long, long> keyValuePair in this.ReplaceBuffMap)
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent != null)
			{
				long key = keyValuePair.Key;
				BuffReplace buffReplace = new BuffReplace();
				buffReplace.ReplaceBuffId = keyValuePair.Value;
				IActiveBuff buff = base.Buff;
				buffReplace.PreMessageId = ((buff != null) ? buff.MessageId : null);
				ownerBuffComponent.AddReplaceBuff(key, buffReplace);
			}
		}
	}

	// Token: 0x060175C9 RID: 95689 RVA: 0x006E08AC File Offset: 0x006DEAAC
	public override void OnRemoved(bool bPremature)
	{
		foreach (KeyValuePair<long, long> keyValuePair in this.ReplaceBuffMap)
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent != null)
			{
				ownerBuffComponent.RemoveReplaceBuff(keyValuePair.Key);
			}
		}
	}

	// Token: 0x060175CA RID: 95690 RVA: 0x006E0914 File Offset: 0x006DEB14
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x060175CB RID: 95691 RVA: 0x006E0918 File Offset: 0x006DEB18
	public override string GetDebugEffectString()
	{
		string text = "";
		foreach (KeyValuePair<long, long> keyValuePair in this.ReplaceBuffMap)
		{
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(19, 2);
			defaultInterpolatedStringHandler.AppendLiteral("当添加buff ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(keyValuePair.Key);
			defaultInterpolatedStringHandler.AppendLiteral(" 时替换为buff ");
			defaultInterpolatedStringHandler.AppendFormatted<long>(keyValuePair.Value);
			defaultInterpolatedStringHandler.AppendLiteral("\n");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text;
	}

	// Token: 0x0400C612 RID: 50706
	protected Dictionary<long, long> ReplaceBuffMap = new Dictionary<long, long>();
}
