using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02006DF4 RID: 28148
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemInspectEffectCenter
	{
		// Token: 0x06044ABE RID: 281278 RVA: 0x010F35A8 File Offset: 0x010F17A8
		public void Init()
		{
			this.RegisterEffect(EInteractEffectType.ModifyTipText, () => new ItemInspectEffectModifyTipText(), true);
			this.RegisterEffect(EInteractEffectType.ExecuteTag, () => new ItemInspectEffectPlayPerform(), false);
			this.RegisterEffect(EInteractEffectType.TriggerDialogues, () => new ItemInspectEffectTriggerDialogues(), true);
			this.RegisterEffect(EInteractEffectType.TriggerVoiceDialogues, () => new ItemInspectEffectTriggerVoiceDialogues(), true);
		}

		// Token: 0x06044ABF RID: 281279 RVA: 0x010F3654 File Offset: 0x010F1854
		private void RegisterEffect(EInteractEffectType type, Func<ItemInspectEffectBase> effectClass, bool repeatable = false)
		{
			ItemInspectEffectDefine itemInspectEffectDefine = new ItemInspectEffectDefine();
			itemInspectEffectDefine.Init(effectClass, repeatable);
			this.EffectMap[type] = itemInspectEffectDefine;
		}

		// Token: 0x06044AC0 RID: 281280 RVA: 0x010F367C File Offset: 0x010F187C
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

		// Token: 0x06044AC1 RID: 281281 RVA: 0x010F3754 File Offset: 0x010F1954
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

		// Token: 0x06044AC2 RID: 281282 RVA: 0x010F3781 File Offset: 0x010F1981
		private void OnExecuteEffectFinish(bool result, ItemInspectEffectBase effect)
		{
			this.ExecutingEffectSet.Remove(effect);
			this.CheckFinish();
		}

		// Token: 0x06044AC3 RID: 281283 RVA: 0x010F3796 File Offset: 0x010F1996
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

		// Token: 0x04023BA0 RID: 146336
		private readonly Dictionary<EInteractEffectType, ItemInspectEffectDefine> EffectMap = new Dictionary<EInteractEffectType, ItemInspectEffectDefine>();

		// Token: 0x04023BA1 RID: 146337
		private readonly HashSet<ItemInspectEffectBase> ExecutingEffectSet = new HashSet<ItemInspectEffectBase>();

		// Token: 0x04023BA2 RID: 146338
		[Nullable(2)]
		private Action OnExecuteEffectsFinish;

		// Token: 0x04023BA3 RID: 146339
		[Nullable(2)]
		private TimerHandle ProtectHandle;
	}
}
