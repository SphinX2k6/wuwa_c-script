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
	// Token: 0x02004CD7 RID: 19671
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleSkillUltraItem : UiPanelBase
	{
		// Token: 0x06031378 RID: 201592 RVA: 0x00DBD2CC File Offset: 0x00DBB4CC
		public BattleSkillUltraItem(UUIItem rootUiItem)
		{
			base.CreateByResourceIdAsync("UiItem_BattleSkillUltraItem", rootUiItem, false).Forget();
		}

		// Token: 0x06031379 RID: 201593 RVA: 0x00DBD328 File Offset: 0x00DBB528
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

		// Token: 0x0603137A RID: 201594 RVA: 0x00DBD3F4 File Offset: 0x00DBB5F4
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

		// Token: 0x0603137B RID: 201595 RVA: 0x00DBD48C File Offset: 0x00DBB68C
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

		// Token: 0x0603137C RID: 201596 RVA: 0x00DBD4E2 File Offset: 0x00DBB6E2
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

		// Token: 0x0603137D RID: 201597 RVA: 0x00DBD518 File Offset: 0x00DBB718
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

		// Token: 0x0603137E RID: 201598 RVA: 0x00DBD574 File Offset: 0x00DBB774
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

		// Token: 0x0603137F RID: 201599 RVA: 0x00DBD5C0 File Offset: 0x00DBB7C0
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

		// Token: 0x06031380 RID: 201600 RVA: 0x00DBD636 File Offset: 0x00DBB836
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

		// Token: 0x06031381 RID: 201601 RVA: 0x00DBD660 File Offset: 0x00DBB860
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

		// Token: 0x06031382 RID: 201602 RVA: 0x00DBD6AC File Offset: 0x00DBB8AC
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

		// Token: 0x06031383 RID: 201603 RVA: 0x00DBD6F8 File Offset: 0x00DBB8F8
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

		// Token: 0x06031384 RID: 201604 RVA: 0x00DBD744 File Offset: 0x00DBB944
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

		// Token: 0x06031385 RID: 201605 RVA: 0x00DBD827 File Offset: 0x00DBBA27
		private void CancelLoadUltraNiagara()
		{
			if (this.LoadUltraNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadUltraNiagaraHandleId.Value);
			this.LoadUltraNiagaraHandleId = null;
		}

		// Token: 0x06031386 RID: 201606 RVA: 0x00DBD858 File Offset: 0x00DBBA58
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

		// Token: 0x06031387 RID: 201607 RVA: 0x00DBD8C5 File Offset: 0x00DBBAC5
		private void CancelLoadUltraTipsNiagara()
		{
			if (this.LoadUltraTipsNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadUltraTipsNiagaraHandleId.Value);
			this.LoadUltraTipsNiagaraHandleId = null;
		}

		// Token: 0x06031388 RID: 201608 RVA: 0x00DBD8F8 File Offset: 0x00DBBAF8
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

		// Token: 0x06031389 RID: 201609 RVA: 0x00DBD965 File Offset: 0x00DBBB65
		private void CancelLoadUltraDynamicNiagara()
		{
			if (this.LoadUltraDynamicNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadUltraDynamicNiagaraHandleId.Value);
			this.LoadUltraDynamicNiagaraHandleId = null;
		}

		// Token: 0x0603138A RID: 201610 RVA: 0x00DBD996 File Offset: 0x00DBBB96
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

		// Token: 0x0603138B RID: 201611 RVA: 0x00DBD9B8 File Offset: 0x00DBBBB8
		public bool HasValidUltDynamicEffect()
		{
			return this.LoadUltraDynamicNiagaraHandleId != null && BattleLinkModel.Instance.CheckInDreamLink() && BattleLinkModel.Instance.CanUseLinkSkill(null);
		}

		// Token: 0x0603138C RID: 201612 RVA: 0x00DBD9F3 File Offset: 0x00DBBBF3
		private void OnBattleLinkStatusChanged(ELinkStatus state)
		{
			this.RefreshLinkEffect();
		}

		// Token: 0x0603138D RID: 201613 RVA: 0x00DBD9FC File Offset: 0x00DBBBFC
		private void RefreshLinkEffect()
		{
			bool ultraEffectEnable = BattleLinkModel.Instance.CanUseLinkSkill(null);
			this.SetUltraEffectEnable(ultraEffectEnable);
		}

		// Token: 0x0603138E RID: 201614 RVA: 0x00DBDA24 File Offset: 0x00DBBC24
		[CompilerGenerated]
		private void <SetComponentActive>g__Callback|18_0()
		{
			this.SetActive(this.Visible);
		}

		// Token: 0x0401A120 RID: 106784
		public bool Visible;

		// Token: 0x0401A121 RID: 106785
		[Nullable(2)]
		private UUISprite FrameSprite;

		// Token: 0x0401A122 RID: 106786
		private FColor? FrameSpriteColor;

		// Token: 0x0401A123 RID: 106787
		private string UltNiagaraPath = string.Empty;

		// Token: 0x0401A124 RID: 106788
		private FLinearColor? UltNiagaraColor;

		// Token: 0x0401A125 RID: 106789
		private string UltTipsNiagaraPath = string.Empty;

		// Token: 0x0401A126 RID: 106790
		private string UltDynamicNiagaraPath = string.Empty;

		// Token: 0x0401A127 RID: 106791
		private int? LoadUltraNiagaraHandleId;

		// Token: 0x0401A128 RID: 106792
		private int? LoadUltraTipsNiagaraHandleId;

		// Token: 0x0401A129 RID: 106793
		private int? LoadUltraDynamicNiagaraHandleId;

		// Token: 0x0401A12A RID: 106794
		private float CurrentEnergyPercent = -1f;

		// Token: 0x0401A12B RID: 106795
		private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

		// Token: 0x0401A12C RID: 106796
		private bool HasBattleLinkEvent;

		// Token: 0x0200A95D RID: 43357
		[NullableContext(0)]
		private enum ESkillUltraItem
		{
			// Token: 0x0403450D RID: 214285
			BarSprite,
			// Token: 0x0403450E RID: 214286
			UltNiagara,
			// Token: 0x0403450F RID: 214287
			UltTipsNiagara,
			// Token: 0x04034510 RID: 214288
			UltUpNiagara,
			// Token: 0x04034511 RID: 214289
			UltDynamicNiagara
		}
	}
}
