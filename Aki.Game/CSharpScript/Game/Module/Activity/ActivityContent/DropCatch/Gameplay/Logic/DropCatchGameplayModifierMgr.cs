using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005687 RID: 22151
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayModifierMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06036A6F RID: 223855 RVA: 0x00F406DF File Offset: 0x00F3E8DF
		public DropCatchGameplayModifierMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06036A70 RID: 223856 RVA: 0x00F40714 File Offset: 0x00F3E914
		public override void Init()
		{
			this.Modifiers.Clear();
			this.ModifierIdCounter = 0;
			this.AttrToRefresh.Clear();
			this.ModifiersToDelete.Clear();
		}

		// Token: 0x06036A71 RID: 223857 RVA: 0x00F40740 File Offset: 0x00F3E940
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

		// Token: 0x06036A72 RID: 223858 RVA: 0x00F40980 File Offset: 0x00F3EB80
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

		// Token: 0x06036A73 RID: 223859 RVA: 0x00F40A14 File Offset: 0x00F3EC14
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

		// Token: 0x06036A74 RID: 223860 RVA: 0x00F40A58 File Offset: 0x00F3EC58
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

		// Token: 0x06036A75 RID: 223861 RVA: 0x00F40B4C File Offset: 0x00F3ED4C
		public void AddSkillModifier(IDropCatchGameplayAttribute attr, int modifierId)
		{
			if (this.SkillModifiers.ContainsKey(attr))
			{
				this.SkillModifiers[attr] = modifierId;
				return;
			}
			this.SkillModifiers.Add(attr, modifierId);
		}

		// Token: 0x06036A76 RID: 223862 RVA: 0x00F40B78 File Offset: 0x00F3ED78
		public void ClearAllSkillModifiers()
		{
			foreach (KeyValuePair<IDropCatchGameplayAttribute, int> keyValuePair in this.SkillModifiers)
			{
				this.RemoveModifierFromAttr(keyValuePair.Key, keyValuePair.Value);
			}
			this.SkillModifiers.Clear();
		}

		// Token: 0x06036A77 RID: 223863 RVA: 0x00F40BE4 File Offset: 0x00F3EDE4
		public override void Destroy()
		{
			this.Modifiers.Clear();
			this.AttrToRefresh.Clear();
			this.ModifiersToDelete.Clear();
		}

		// Token: 0x0401CE16 RID: 118294
		private readonly Dictionary<IDropCatchGameplayAttribute, Dictionary<int, IDropCatchGameplayModifier>> Modifiers = new Dictionary<IDropCatchGameplayAttribute, Dictionary<int, IDropCatchGameplayModifier>>();

		// Token: 0x0401CE17 RID: 118295
		private int ModifierIdCounter;

		// Token: 0x0401CE18 RID: 118296
		private readonly HashSet<IDropCatchGameplayAttribute> AttrToRefresh = new HashSet<IDropCatchGameplayAttribute>();

		// Token: 0x0401CE19 RID: 118297
		private readonly HashSet<int> ModifiersToDelete = new HashSet<int>();

		// Token: 0x0401CE1A RID: 118298
		private readonly Dictionary<IDropCatchGameplayAttribute, int> SkillModifiers = new Dictionary<IDropCatchGameplayAttribute, int>();
	}
}
