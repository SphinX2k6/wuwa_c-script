using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02005F73 RID: 24435
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemInspectEffectCenter
	{
		// Token: 0x0603AC22 RID: 240674 RVA: 0x0109D870 File Offset: 0x0109BA70
		public void Init()
		{
			this.RegisterEffect(EInteractEffectType.ModifyTipText, () => new ItemInspectEffectModifyTipText(), true);
			this.RegisterEffect(EInteractEffectType.ExecuteTag, () => new ItemInspectEffectPlayPerform(), false);
			this.RegisterEffect(EInteractEffectType.TriggerDialogues, () => new ItemInspectEffectTriggerDialogues(), true);
			this.RegisterEffect(EInteractEffectType.TriggerVoiceDialogues, () => new ItemInspectEffectTriggerVoiceDialogues(), true);
		}

		// Token: 0x0603AC23 RID: 240675 RVA: 0x0109D91C File Offset: 0x0109BB1C
		private void RegisterEffect(EInteractEffectType type, Func<ItemInspectEffectBase> effectClass, bool repeatable = false)
		{
			ItemInspectEffectDefine itemInspectEffectDefine = new ItemInspectEffectDefine();
			itemInspectEffectDefine.Init(effectClass, repeatable);
			this.EffectMap[type] = itemInspectEffectDefine;
		}

		// Token: 0x0603AC24 RID: 240676 RVA: 0x0109D944 File Offset: 0x0109BB44
		public void ExecuteEffects(List<IInteractEffect> effectConfigs, bool isChecked, float protectTime, [Nullable(2)] Action onFinish = null)
		{
			this.ClearEffects();
			foreach (IInteractEffect interactEffect in effectConfigs)
			{
				ItemInspectEffectDefine itemInspectEffectDefine;
				if (this.EffectMap.TryGetValue(interactEffect.Type, out itemInspectEffectDefine) && (!isChecked || itemInspectEffectDefine.IsRepeatable()))
				{
					ItemInspectEffectBase effect = itemInspectEffectDefine.GetEffect();
					this.ExecutingEffectSet.Add(effect);
					effect.ExecuteEffect(interactEffect, new Action<bool, ItemInspectEffectBase>(this.OnExecuteEffectFinish));
				}
			}
			if (protectTime > 0f)
			{
				this.ProtectHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.ProtectHandle = null;
					this.CheckFinish();
				}, protectTime * 1000f, null, null, true, 1f);
			}
			this.OnExecuteEffectsFinish = onFinish;
			this.CheckFinish();
		}

		// Token: 0x0603AC25 RID: 240677 RVA: 0x0109DA1C File Offset: 0x0109BC1C
		public void ClearEffects()
		{
			this.ExecutingEffectSet.Clear();
			TimerHandle protectHandle = this.ProtectHandle;
			if (protectHandle != null)
			{
				protectHandle.Remove();
			}
			this.ProtectHandle = null;
			this.OnExecuteEffectsFinish = null;
		}

		// Token: 0x0603AC26 RID: 240678 RVA: 0x0109DA49 File Offset: 0x0109BC49
		private void OnExecuteEffectFinish(bool result, ItemInspectEffectBase effect)
		{
			this.ExecutingEffectSet.Remove(effect);
			this.CheckFinish();
		}

		// Token: 0x0603AC27 RID: 240679 RVA: 0x0109DA5E File Offset: 0x0109BC5E
		private void CheckFinish()
		{
			if (this.ExecutingEffectSet.Count == 0 && this.ProtectHandle == null)
			{
				Action onExecuteEffectsFinish = this.OnExecuteEffectsFinish;
				if (onExecuteEffectsFinish != null)
				{
					onExecuteEffectsFinish();
				}
				this.OnExecuteEffectsFinish = null;
			}
		}

		// Token: 0x0401EE42 RID: 126530
		private readonly Dictionary<EInteractEffectType, ItemInspectEffectDefine> EffectMap = new Dictionary<EInteractEffectType, ItemInspectEffectDefine>();

		// Token: 0x0401EE43 RID: 126531
		private readonly HashSet<ItemInspectEffectBase> ExecutingEffectSet = new HashSet<ItemInspectEffectBase>();

		// Token: 0x0401EE44 RID: 126532
		[Nullable(2)]
		private Action OnExecuteEffectsFinish;

		// Token: 0x0401EE45 RID: 126533
		[Nullable(2)]
		private TimerHandle ProtectHandle;
	}
}
