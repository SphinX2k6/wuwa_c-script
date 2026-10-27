using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF5 RID: 23797
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleSkillUltraItem : UiPanelBase
	{
		// Token: 0x0603C422 RID: 246818 RVA: 0x00E6CD18 File Offset: 0x00E6AF18
		public BattleSkillUltraItem(UUIItem rootUiItem)
		{
			base.CreateByResourceIdAsync("UiItem_BattleSkillUltraItem", rootUiItem, false).Forget();
		}

		// Token: 0x0603C423 RID: 246819 RVA: 0x00E6CD74 File Offset: 0x00E6AF74
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C424 RID: 246820 RVA: 0x00E6CE40 File Offset: 0x00E6B040
		protected override void OnStart()
		{
			this.FrameSprite = base.GetSprite(0);
			foreach (Action action in this.OperationMap.Values)
			{
				action();
			}
			if (BattleLinkModel.Instance.CheckInDreamLink())
			{
				this.RefreshLinkEffect();
				this.HasBattleLinkEvent = true;
				EventSystem.Instance.Add<ELinkStatus>(EEventName.OnBattleLinkStatusChanged, new Action<ELinkStatus>(this.OnBattleLinkStatusChanged));
			}
		}

		// Token: 0x0603C425 RID: 246821 RVA: 0x00E6CED8 File Offset: 0x00E6B0D8
		protected override void OnBeforeDestroy()
		{
			this.FrameSprite = null;
			this.OperationMap.Clear();
			this.CancelLoadUltraNiagara();
			this.CancelLoadUltraTipsNiagara();
			if (this.HasBattleLinkEvent)
			{
				this.HasBattleLinkEvent = false;
				EventSystem.Instance.Remove(EEventName.OnBattleLinkStatusChanged, new Action<ELinkStatus>(this.OnBattleLinkStatusChanged));
			}
		}

		// Token: 0x0603C426 RID: 246822 RVA: 0x00E6CF2E File Offset: 0x00E6B12E
		public void SetComponentActive(bool visibility)
		{
			this.Visible = visibility;
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetActive"] = new Action(this.<SetComponentActive>g__Callback|18_0);
				return;
			}
			this.<SetComponentActive>g__Callback|18_0();
		}

		// Token: 0x0603C427 RID: 246823 RVA: 0x00E6CF64 File Offset: 0x00E6B164
		public void SetBarPercent(float energyPercent, bool bPlayUpEffect)
		{
			BattleSkillUltraItem.<>c__DisplayClass19_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass19_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.energyPercent = energyPercent;
			if (this.CurrentEnergyPercent == CS$<>8__locals1.energyPercent)
			{
				return;
			}
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetBarPercent"] = new Action(CS$<>8__locals1.<SetBarPercent>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetBarPercent>g__Callback|0();
		}

		// Token: 0x0603C428 RID: 246824 RVA: 0x00E6CFC0 File Offset: 0x00E6B1C0
		public void SetBarVisible(bool flag)
		{
			BattleSkillUltraItem.<>c__DisplayClass20_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass20_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.flag = flag;
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetBarVisible"] = new Action(CS$<>8__locals1.<SetBarVisible>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetBarVisible>g__Callback|0();
		}

		// Token: 0x0603C429 RID: 246825 RVA: 0x00E6D00C File Offset: 0x00E6B20C
		public void SetFrameSprite(FColor frameSpriteColor)
		{
			BattleSkillUltraItem.<>c__DisplayClass21_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass21_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.frameSpriteColor = frameSpriteColor;
			if (this.FrameSpriteColor == CS$<>8__locals1.frameSpriteColor)
			{
				return;
			}
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetFrameSprite"] = new Action(CS$<>8__locals1.<SetFrameSprite>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetFrameSprite>g__Callback|0();
		}

		// Token: 0x0603C42A RID: 246826 RVA: 0x00E6D082 File Offset: 0x00E6B282
		[NullableContext(2)]
		private void SetEffectEnable(UUINiagara effect, bool bEnable)
		{
			if (effect == null)
			{
				return;
			}
			if (effect.bIsUIActive != bEnable)
			{
				effect.SetUIActive(bEnable);
				if (bEnable)
				{
					effect.ActivateSystem(true);
					return;
				}
				effect.DeactivateSystem();
			}
		}

		// Token: 0x0603C42B RID: 246827 RVA: 0x00E6D0AC File Offset: 0x00E6B2AC
		public void SetUltraEffectEnable(bool bEnable)
		{
			BattleSkillUltraItem.<>c__DisplayClass23_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass23_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.bEnable = bEnable;
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetUltraEffectEnable"] = new Action(CS$<>8__locals1.<SetUltraEffectEnable>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetUltraEffectEnable>g__Callback|0();
		}

		// Token: 0x0603C42C RID: 246828 RVA: 0x00E6D0F8 File Offset: 0x00E6B2F8
		public void SetUltraTipsEffectEnable(bool bEnable)
		{
			BattleSkillUltraItem.<>c__DisplayClass24_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass24_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.bEnable = bEnable;
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetUltraTipsEffectEnable"] = new Action(CS$<>8__locals1.<SetUltraTipsEffectEnable>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetUltraTipsEffectEnable>g__Callback|0();
		}

		// Token: 0x0603C42D RID: 246829 RVA: 0x00E6D144 File Offset: 0x00E6B344
		public void SetUltraUpEffectEnable(bool bEnable)
		{
			BattleSkillUltraItem.<>c__DisplayClass25_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass25_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.bEnable = bEnable;
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetUltraUpEffectEnable"] = new Action(CS$<>8__locals1.<SetUltraUpEffectEnable>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetUltraUpEffectEnable>g__Callback|0();
		}

		// Token: 0x0603C42E RID: 246830 RVA: 0x00E6D190 File Offset: 0x00E6B390
		public void RefreshUltraEffect(string effectPath, FLinearColor effectColor)
		{
			BattleSkillUltraItem.<>c__DisplayClass26_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass26_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.effectPath = effectPath;
			CS$<>8__locals1.effectColor = effectColor;
			if (!string.IsNullOrEmpty(this.UltNiagaraPath) && this.UltNiagaraPath == CS$<>8__locals1.effectPath)
			{
				if (this.UltNiagaraColor != CS$<>8__locals1.effectColor)
				{
					this.UltNiagaraColor = new FLinearColor?(CS$<>8__locals1.effectColor);
					if (!base.InAsyncLoading())
					{
						UUINiagara uiNiagara = base.GetUiNiagara(1);
						if (uiNiagara == null)
						{
							return;
						}
						uiNiagara.SetNiagaraVarLinearColor("Color", CS$<>8__locals1.effectColor);
					}
				}
				return;
			}
			this.UltNiagaraColor = new FLinearColor?(CS$<>8__locals1.effectColor);
			if (base.InAsyncLoading())
			{
				this.OperationMap["RefreshUltraEffect"] = new Action(CS$<>8__locals1.<RefreshUltraEffect>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<RefreshUltraEffect>g__Callback|0();
		}

		// Token: 0x0603C42F RID: 246831 RVA: 0x00E6D273 File Offset: 0x00E6B473
		private void CancelLoadUltraNiagara()
		{
			if (this.LoadUltraNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadUltraNiagaraHandleId.Value);
			this.LoadUltraNiagaraHandleId = null;
		}

		// Token: 0x0603C430 RID: 246832 RVA: 0x00E6D2A4 File Offset: 0x00E6B4A4
		public void RefreshUltraTipsEffect(string effectPath)
		{
			BattleSkillUltraItem.<>c__DisplayClass28_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass28_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.effectPath = effectPath;
			if (!string.IsNullOrEmpty(this.UltTipsNiagaraPath) && this.UltTipsNiagaraPath == CS$<>8__locals1.effectPath)
			{
				return;
			}
			if (base.InAsyncLoading())
			{
				this.OperationMap["RefreshUltraTipsEffect"] = new Action(CS$<>8__locals1.<RefreshUltraTipsEffect>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<RefreshUltraTipsEffect>g__Callback|0();
		}

		// Token: 0x0603C431 RID: 246833 RVA: 0x00E6D311 File Offset: 0x00E6B511
		private void CancelLoadUltraTipsNiagara()
		{
			if (this.LoadUltraTipsNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadUltraTipsNiagaraHandleId.Value);
			this.LoadUltraTipsNiagaraHandleId = null;
		}

		// Token: 0x0603C432 RID: 246834 RVA: 0x00E6D344 File Offset: 0x00E6B544
		public void RefreshUltraDynamicEffect(string effectPath, FLinearColor? effectColor = null)
		{
			BattleSkillUltraItem.<>c__DisplayClass30_0 CS$<>8__locals1 = new BattleSkillUltraItem.<>c__DisplayClass30_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.effectPath = effectPath;
			if (!string.IsNullOrEmpty(this.UltDynamicNiagaraPath) && this.UltDynamicNiagaraPath == CS$<>8__locals1.effectPath)
			{
				return;
			}
			if (base.InAsyncLoading())
			{
				this.OperationMap["RefreshUltraDynamicEffect"] = new Action(CS$<>8__locals1.<RefreshUltraDynamicEffect>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<RefreshUltraDynamicEffect>g__Callback|0();
		}

		// Token: 0x0603C433 RID: 246835 RVA: 0x00E6D3B1 File Offset: 0x00E6B5B1
		private void CancelLoadUltraDynamicNiagara()
		{
			if (this.LoadUltraDynamicNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadUltraDynamicNiagaraHandleId.Value);
			this.LoadUltraDynamicNiagaraHandleId = null;
		}

		// Token: 0x0603C434 RID: 246836 RVA: 0x00E6D3E2 File Offset: 0x00E6B5E2
		public void StopUltraDynamicEffect()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(4);
			if (uiNiagara != null)
			{
				uiNiagara.DeactivateSystem();
			}
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x0603C435 RID: 246837 RVA: 0x00E6D404 File Offset: 0x00E6B604
		public bool HasValidUltDynamicEffect()
		{
			return this.LoadUltraDynamicNiagaraHandleId != null && BattleLinkModel.Instance.CheckInDreamLink() && BattleLinkModel.Instance.CanUseLinkSkill(null);
		}

		// Token: 0x0603C436 RID: 246838 RVA: 0x00E6D43F File Offset: 0x00E6B63F
		private void OnBattleLinkStatusChanged(ELinkStatus state)
		{
			this.RefreshLinkEffect();
		}

		// Token: 0x0603C437 RID: 246839 RVA: 0x00E6D448 File Offset: 0x00E6B648
		private void RefreshLinkEffect()
		{
			bool ultraEffectEnable = BattleLinkModel.Instance.CanUseLinkSkill(null);
			this.SetUltraEffectEnable(ultraEffectEnable);
		}

		// Token: 0x0603C438 RID: 246840 RVA: 0x00E6D470 File Offset: 0x00E6B670
		[CompilerGenerated]
		private void <SetComponentActive>g__Callback|18_0()
		{
			this.SetActive(this.Visible);
		}

		// Token: 0x0401F667 RID: 128615
		public bool Visible;

		// Token: 0x0401F668 RID: 128616
		[Nullable(2)]
		private UUISprite FrameSprite;

		// Token: 0x0401F669 RID: 128617
		private FColor? FrameSpriteColor;

		// Token: 0x0401F66A RID: 128618
		private string UltNiagaraPath = string.Empty;

		// Token: 0x0401F66B RID: 128619
		private FLinearColor? UltNiagaraColor;

		// Token: 0x0401F66C RID: 128620
		private string UltTipsNiagaraPath = string.Empty;

		// Token: 0x0401F66D RID: 128621
		private string UltDynamicNiagaraPath = string.Empty;

		// Token: 0x0401F66E RID: 128622
		private int? LoadUltraNiagaraHandleId;

		// Token: 0x0401F66F RID: 128623
		private int? LoadUltraTipsNiagaraHandleId;

		// Token: 0x0401F670 RID: 128624
		private int? LoadUltraDynamicNiagaraHandleId;

		// Token: 0x0401F671 RID: 128625
		private float CurrentEnergyPercent = -1f;

		// Token: 0x0401F672 RID: 128626
		private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

		// Token: 0x0401F673 RID: 128627
		private bool HasBattleLinkEvent;

		// Token: 0x0200BF57 RID: 48983
		[NullableContext(0)]
		private enum ESkillUltraItem
		{
			// Token: 0x04039B4B RID: 236363
			BarSprite,
			// Token: 0x04039B4C RID: 236364
			UltNiagara,
			// Token: 0x04039B4D RID: 236365
			UltTipsNiagara,
			// Token: 0x04039B4E RID: 236366
			UltUpNiagara,
			// Token: 0x04039B4F RID: 236367
			UltDynamicNiagara
		}
	}
}
