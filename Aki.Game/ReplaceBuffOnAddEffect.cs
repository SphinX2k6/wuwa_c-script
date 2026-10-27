using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F59 RID: 12121
[NullableContext(1)]
[Nullable(0)]
public class ReplaceBuffOnAddEffect : BuffEffect
{
	// Token: 0x06019CBB RID: 105659 RVA: 0x006BA460 File Offset: 0x006B8660
	public ReplaceBuffOnAddEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019CBC RID: 105660 RVA: 0x006BA47C File Offset: 0x006B867C
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

	// Token: 0x06019CBD RID: 105661 RVA: 0x006BA4F8 File Offset: 0x006B86F8
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

	// Token: 0x06019CBE RID: 105662 RVA: 0x006BA590 File Offset: 0x006B8790
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

	// Token: 0x06019CBF RID: 105663 RVA: 0x006BA5F8 File Offset: 0x006B87F8
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x06019CC0 RID: 105664 RVA: 0x006BA5FC File Offset: 0x006B87FC
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

	// Token: 0x0400C270 RID: 49776
	protected Dictionary<long, long> ReplaceBuffMap = new Dictionary<long, long>();
}
