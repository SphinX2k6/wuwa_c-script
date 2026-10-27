using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006737 RID: 26423
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayModifierMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06041F23 RID: 270115 RVA: 0x00FFF32F File Offset: 0x00FFD52F
		public DropCatchGameplayModifierMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06041F24 RID: 270116 RVA: 0x00FFF364 File Offset: 0x00FFD564
		public override void Init()
		{
			this.Modifiers.Clear();
			this.ModifierIdCounter = 0;
			this.AttrToRefresh.Clear();
			this.ModifiersToDelete.Clear();
		}

		// Token: 0x06041F25 RID: 270117 RVA: 0x00FFF390 File Offset: 0x00FFD590
		public override void OnTick(float deltaTime)
		{
			this.AttrToRefresh.Clear();
			foreach (KeyValuePair<IDropCatchGameplayAttribute, Dictionary<int, IDropCatchGameplayModifier>> keyValuePair in this.Modifiers)
			{
				IDropCatchGameplayAttribute key = keyValuePair.Key;
				Dictionary<int, IDropCatchGameplayModifier> value = keyValuePair.Value;
				this.ModifiersToDelete.Clear();
				bool flag = false;
				foreach (KeyValuePair<int, IDropCatchGameplayModifier> keyValuePair2 in value)
				{
					int key2 = keyValuePair2.Key;
					IDropCatchGameplayModifier value2 = keyValuePair2.Value;
					if (value2.Duration != null)
					{
						float? duration = value2.Duration;
						float num = 0f;
						if (!(duration.GetValueOrDefault() <= num & duration != null))
						{
							value2.Duration -= deltaTime;
							duration = value2.Duration;
							num = 0f;
							if (duration.GetValueOrDefault() <= num & duration != null)
							{
								this.ModifiersToDelete.Add(key2);
								flag = true;
							}
						}
					}
				}
				foreach (int key3 in this.ModifiersToDelete)
				{
					value.Remove(key3);
				}
				if (flag)
				{
					this.AttrToRefresh.Add(key);
				}
			}
			foreach (IDropCatchGameplayAttribute attr in this.AttrToRefresh)
			{
				this.RefreshValueByAttr(attr);
			}
		}

		// Token: 0x06041F26 RID: 270118 RVA: 0x00FFF5D0 File Offset: 0x00FFD7D0
		public int AddModifierToAttr(IDropCatchGameplayAttribute attr, EDropCatchModifierType type, float value, float? duration)
		{
			Dictionary<int, IDropCatchGameplayModifier> dictionary;
			if (!this.Modifiers.TryGetValue(attr, out dictionary))
			{
				dictionary = new Dictionary<int, IDropCatchGameplayModifier>();
				this.Modifiers.Add(attr, dictionary);
			}
			float? duration2 = duration;
			if (duration2 != null)
			{
				duration2 = new float?(duration2.Value * (float)TimeUtil.Instance.InverseMillisecond);
			}
			int num = this.ModifierIdCounter + 1;
			this.ModifierIdCounter = num;
			int num2 = num;
			dictionary.Add(num2, new IDropCatchGameplayModifier
			{
				Type = type,
				Value = value,
				Duration = duration2
			});
			this.RefreshValueByAttr(attr);
			return num2;
		}

		// Token: 0x06041F27 RID: 270119 RVA: 0x00FFF664 File Offset: 0x00FFD864
		public void RemoveModifierFromAttr(IDropCatchGameplayAttribute attr, int modifierId)
		{
			Dictionary<int, IDropCatchGameplayModifier> dictionary;
			if (!this.Modifiers.TryGetValue(attr, out dictionary))
			{
				return;
			}
			dictionary.Remove(modifierId);
			if (dictionary.Count == 0)
			{
				this.Modifiers.Remove(attr);
			}
			this.RefreshValueByAttr(attr);
		}

		// Token: 0x06041F28 RID: 270120 RVA: 0x00FFF6A8 File Offset: 0x00FFD8A8
		private void RefreshValueByAttr(IDropCatchGameplayAttribute attr)
		{
			float baseValue = attr.GetBaseValue();
			Dictionary<int, IDropCatchGameplayModifier> dictionary;
			this.Modifiers.TryGetValue(attr, out dictionary);
			float num = baseValue;
			if (dictionary != null && dictionary.Count > 0)
			{
				float? num2 = null;
				float num3 = 1f;
				float num4 = 0f;
				foreach (IDropCatchGameplayModifier dropCatchGameplayModifier in dictionary.Values)
				{
					switch (dropCatchGameplayModifier.Type)
					{
					case EDropCatchModifierType.Override:
						num2 = new float?(dropCatchGameplayModifier.Value);
						break;
					case EDropCatchModifierType.Rate:
						num3 *= dropCatchGameplayModifier.Value;
						break;
					case EDropCatchModifierType.Offset:
						num4 += dropCatchGameplayModifier.Value;
						break;
					}
				}
				if (num2 != null)
				{
					num = num2.Value;
				}
				else
				{
					num = (num + num4) * num3;
				}
			}
			attr.SetFinalValue(num);
		}

		// Token: 0x06041F29 RID: 270121 RVA: 0x00FFF79C File Offset: 0x00FFD99C
		public void AddSkillModifier(IDropCatchGameplayAttribute attr, int modifierId)
		{
			if (this.SkillModifiers.ContainsKey(attr))
			{
				this.SkillModifiers[attr] = modifierId;
				return;
			}
			this.SkillModifiers.Add(attr, modifierId);
		}

		// Token: 0x06041F2A RID: 270122 RVA: 0x00FFF7C8 File Offset: 0x00FFD9C8
		public void ClearAllSkillModifiers()
		{
			foreach (KeyValuePair<IDropCatchGameplayAttribute, int> keyValuePair in this.SkillModifiers)
			{
				this.RemoveModifierFromAttr(keyValuePair.Key, keyValuePair.Value);
			}
			this.SkillModifiers.Clear();
		}

		// Token: 0x06041F2B RID: 270123 RVA: 0x00FFF834 File Offset: 0x00FFDA34
		public override void Destroy()
		{
			this.Modifiers.Clear();
			this.AttrToRefresh.Clear();
			this.ModifiersToDelete.Clear();
		}

		// Token: 0x040225BD RID: 140733
		private readonly Dictionary<IDropCatchGameplayAttribute, Dictionary<int, IDropCatchGameplayModifier>> Modifiers = new Dictionary<IDropCatchGameplayAttribute, Dictionary<int, IDropCatchGameplayModifier>>();

		// Token: 0x040225BE RID: 140734
		private int ModifierIdCounter;

		// Token: 0x040225BF RID: 140735
		private readonly HashSet<IDropCatchGameplayAttribute> AttrToRefresh = new HashSet<IDropCatchGameplayAttribute>();

		// Token: 0x040225C0 RID: 140736
		private readonly HashSet<int> ModifiersToDelete = new HashSet<int>();

		// Token: 0x040225C1 RID: 140737
		private readonly Dictionary<IDropCatchGameplayAttribute, int> SkillModifiers = new Dictionary<IDropCatchGameplayAttribute, int>();
	}
}
