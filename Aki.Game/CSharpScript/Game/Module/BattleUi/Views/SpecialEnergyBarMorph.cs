using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E03 RID: 19971
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarMorph : SpecialEnergyBarBase
	{
		// Token: 0x06032400 RID: 205824 RVA: 0x00E15B24 File Offset: 0x00E13D24
		public override UniTask InitByPathAsync(UUIItem parentItem, string prefabPath)
		{
			SpecialEnergyBarMorph.<InitByPathAsync>d__15 <InitByPathAsync>d__;
			<InitByPathAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitByPathAsync>d__.<>4__this = this;
			<InitByPathAsync>d__.parentItem = parentItem;
			<InitByPathAsync>d__.<>1__state = -1;
			<InitByPathAsync>d__.<>t__builder.Start<SpecialEnergyBarMorph.<InitByPathAsync>d__15>(ref <InitByPathAsync>d__);
			return <InitByPathAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032401 RID: 205825 RVA: 0x00E15B70 File Offset: 0x00E13D70
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032402 RID: 205826 RVA: 0x00E15C80 File Offset: 0x00E13E80
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarMorph.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarMorph.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032403 RID: 205827 RVA: 0x00E15CC4 File Offset: 0x00E13EC4
		protected override void OnInitData()
		{
			base.OnInitData();
			if (this.Config == null)
			{
				return;
			}
			this.KeyEnableNiagaraIndex = this.Config.KeyEnableNiagaraIndex;
			this.NeedExtraEffectOnKeyEnable = (this.KeyEnableNiagaraIndex >= 0);
			List<float> extraFloatParams = this.Config.ExtraFloatParams;
			int count = extraFloatParams.Count;
			if (count > 1)
			{
				this.ReplaceFullEffectIndex = (int)extraFloatParams[1];
			}
			if (count > 2)
			{
				this.ReplaceStartEffectIndex = (int)extraFloatParams[2];
			}
		}

		// Token: 0x06032404 RID: 205828 RVA: 0x00E15D38 File Offset: 0x00E13F38
		protected override void OnStart()
		{
			UUITexture[] iconTextureList = new UUITexture[]
			{
				base.GetTexture(0)
			};
			this.IconHandle.Init(iconTextureList, base.GetItem(6));
			SpecialEnergyBarInfo config = this.Config;
			if (!string.IsNullOrEmpty((config != null) ? config.EnableIconPath : null))
			{
				this.NeedRefreshIconOnKeyEnable = true;
			}
			else
			{
				this.NeedRefreshIconOnKeyEnable = false;
				SpecialEnergyBaIconHandle iconHandle = this.IconHandle;
				SpecialEnergyBarInfo config2 = this.Config;
				iconHandle.SetIcon((!string.IsNullOrEmpty((config2 != null) ? config2.IconPath : null)) ? this.Config.IconPath : null);
			}
			this.FrontIconHandle.Init(new UUITexture[]
			{
				base.GetTexture(5)
			}, null);
			SpecialEnergyBaIconHandle frontIconHandle = this.FrontIconHandle;
			SpecialEnergyBarInfo config3 = this.Config;
			frontIconHandle.SetIcon((!string.IsNullOrEmpty((config3 != null) ? config3.FrontIconPath : null)) ? this.Config.FrontIconPath : null);
			if (this.StartEffectFinishTime == 0.0)
			{
				base.GetUiNiagara(2).SetUIActive(false);
			}
			this.RefreshBuff();
			if (this.NeedExtraEffectOnKeyEnable)
			{
				UNiagaraSystem valueOrDefault = this.NiagaraList.GetValueOrDefault(this.KeyEnableNiagaraIndex);
				if (valueOrDefault != null)
				{
					base.GetUiNiagara(3).SetNiagaraSystem(valueOrDefault);
					SpecialEnergyBarInfo config4 = this.Config;
					string text = (config4 != null) ? config4.OtherEffectColorList.GetValueOrDefault(this.KeyEnableNiagaraIndex) : null;
					if (!string.IsNullOrEmpty(text))
					{
						FColor fcolor = FColor.FromHex(text);
						FLinearColor value = new FLinearColor(ref fcolor);
						base.GetUiNiagara(3).SetNiagaraVarLinearColor("Color", value);
					}
				}
				base.GetUiNiagara(3).SetUIActive(false);
			}
			if (this.ReplaceFullEffectIndex >= 0)
			{
				UNiagaraSystem valueOrDefault2 = this.NiagaraList.GetValueOrDefault(this.ReplaceFullEffectIndex);
				if (valueOrDefault2 != null && this.BarItem != null)
				{
					this.BarItem.ReplaceFullEffect(valueOrDefault2);
					SpecialEnergyBarSlot specialEnergyBarSlot = this.BarItem as SpecialEnergyBarSlot;
					if (specialEnergyBarSlot != null)
					{
						specialEnergyBarSlot.UpdateFullEffectOffsetBySlotWidth();
					}
				}
			}
			if (this.ReplaceStartEffectIndex >= 0)
			{
				UNiagaraSystem valueOrDefault3 = this.NiagaraList.GetValueOrDefault(this.ReplaceStartEffectIndex);
				if (valueOrDefault3 != null)
				{
					base.GetUiNiagara(2).SetNiagaraSystem(valueOrDefault3);
				}
			}
			this.RefreshBarPercent(true);
		}

		// Token: 0x06032405 RID: 205829 RVA: 0x00E15F38 File Offset: 0x00E14138
		protected void RefreshBuff()
		{
			SpecialEnergyBarInfo config = this.Config;
			bool flag;
			if (config == null)
			{
				flag = false;
			}
			else
			{
				long buffId = config.BuffId;
				flag = true;
			}
			if (flag)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.Config.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x06032406 RID: 205830 RVA: 0x00E15FA8 File Offset: 0x00E141A8
		public override void OnChangeVisibleByTagChange(bool visible)
		{
			if (!visible)
			{
				this.Buff = null;
				this.BuffHandle = 0;
				this.IconHandle.PlayEndAnim(false);
				return;
			}
			this.RefreshBuff();
			if (!base.IsShowOrShowing)
			{
				return;
			}
			base.GetUiNiagara(2).SetUIActive(true);
			this.StartEffectFinishTime = 500.0 + Time.Instance.Now;
		}

		// Token: 0x06032407 RID: 205831 RVA: 0x00E1600C File Offset: 0x00E1420C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarMorph.<InitBarItem>d__22 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarMorph.<InitBarItem>d__22>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032408 RID: 205832 RVA: 0x00E1604F File Offset: 0x00E1424F
		[NullableContext(2)]
		protected virtual Type GetSpecialEnergyBarClass()
		{
			return SpecialEnergyBarMorph.SpecialEnergyBarClassList.GetValueOrDefault(this.Config.PrefabType);
		}

		// Token: 0x06032409 RID: 205833 RVA: 0x00E16066 File Offset: 0x00E14266
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.IconHandle.OnBeforeDestroy();
			this.FrontIconHandle.OnBeforeDestroy();
		}

		// Token: 0x0603240A RID: 205834 RVA: 0x00E16084 File Offset: 0x00E14284
		protected void RefreshBarPercent(bool isStart = false)
		{
			bool keyEnable = this.GetKeyEnable();
			this.RefreshIcon(keyEnable);
			this.RefreshExtraEffectOnKeyEnable(keyEnable);
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0603240B RID: 205835 RVA: 0x00E160B8 File Offset: 0x00E142B8
		protected void RefreshIcon(bool bEnable)
		{
			if (!this.NeedRefreshIconOnKeyEnable)
			{
				return;
			}
			string icon = this.Config.IconPath;
			if (bEnable && !string.IsNullOrEmpty(this.Config.EnableIconPath))
			{
				icon = this.Config.EnableIconPath;
			}
			this.IconHandle.SetIcon(icon);
		}

		// Token: 0x0603240C RID: 205836 RVA: 0x00E16107 File Offset: 0x00E14307
		protected void RefreshExtraEffectOnKeyEnable(bool bEnable)
		{
			if (!this.NeedExtraEffectOnKeyEnable)
			{
				return;
			}
			if (this.ExtraEffectActive != bEnable)
			{
				this.ExtraEffectActive = bEnable;
				base.GetUiNiagara(3).SetUIActive(bEnable);
			}
		}

		// Token: 0x0603240D RID: 205837 RVA: 0x00E1612F File Offset: 0x00E1432F
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603240E RID: 205838 RVA: 0x00E16138 File Offset: 0x00E14338
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603240F RID: 205839 RVA: 0x00E16144 File Offset: 0x00E14344
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarBase barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			if (this.StartEffectFinishTime > 0.0 && this.StartEffectFinishTime <= Time.Instance.Now)
			{
				base.GetUiNiagara(2).SetUIActive(false);
				this.StartEffectFinishTime = 0.0;
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_80;
				}
			}
			this.RefreshBuff();
			IL_80:
			if (this.Buff != null)
			{
				this.IconHandle.PlayEndAnim(this.Buff.GetRemainDuration() < this.Config.ExtraFloatParams[0]);
			}
		}

		// Token: 0x06032410 RID: 205840 RVA: 0x00E16202 File Offset: 0x00E14402
		public override void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			this.BarItem.ReplaceFullEffect(niagara);
		}

		// Token: 0x0401AA08 RID: 109064
		[StaticVariableRuleIgnore]
		private static readonly Type[] SpecialEnergyBarClassList = new Type[]
		{
			null,
			null,
			null,
			typeof(SpecialEnergyBarPoint),
			typeof(SpecialEnergyBarSlot),
			null,
			null,
			null,
			null,
			typeof(SpecialEnergyBarPointGraduate)
		};

		// Token: 0x0401AA09 RID: 109065
		private const double EFFECT_DURATION = 500.0;

		// Token: 0x0401AA0A RID: 109066
		private readonly SpecialEnergyBaIconHandle IconHandle = new SpecialEnergyBaIconHandle();

		// Token: 0x0401AA0B RID: 109067
		private readonly SpecialEnergyBaIconHandle FrontIconHandle = new SpecialEnergyBaIconHandle();

		// Token: 0x0401AA0C RID: 109068
		[Nullable(2)]
		protected SpecialEnergyBarBase BarItem;

		// Token: 0x0401AA0D RID: 109069
		private double StartEffectFinishTime;

		// Token: 0x0401AA0E RID: 109070
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401AA0F RID: 109071
		private int BuffHandle;

		// Token: 0x0401AA10 RID: 109072
		private bool NeedRefreshIconOnKeyEnable;

		// Token: 0x0401AA11 RID: 109073
		private bool ExtraEffectActive;

		// Token: 0x0401AA12 RID: 109074
		protected bool NeedExtraEffectOnKeyEnable;

		// Token: 0x0401AA13 RID: 109075
		protected int KeyEnableNiagaraIndex = -1;

		// Token: 0x0401AA14 RID: 109076
		protected int ReplaceFullEffectIndex = -1;

		// Token: 0x0401AA15 RID: 109077
		protected int ReplaceStartEffectIndex = -1;

		// Token: 0x0200ABA6 RID: 43942
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040351ED RID: 217581
			IconTexture,
			// Token: 0x040351EE RID: 217582
			KeyContainerItem,
			// Token: 0x040351EF RID: 217583
			StartEffect,
			// Token: 0x040351F0 RID: 217584
			ExtraEffect,
			// Token: 0x040351F1 RID: 217585
			SlotContainerItem,
			// Token: 0x040351F2 RID: 217586
			FrontIconTexture,
			// Token: 0x040351F3 RID: 217587
			AnimItem
		}
	}
}
