using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E1E RID: 24094
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarMorph : SpecialEnergyBarBase
	{
		// Token: 0x0603D471 RID: 250993 RVA: 0x00EC45C4 File Offset: 0x00EC27C4
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

		// Token: 0x0603D472 RID: 250994 RVA: 0x00EC4610 File Offset: 0x00EC2810
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

		// Token: 0x0603D473 RID: 250995 RVA: 0x00EC4720 File Offset: 0x00EC2920
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarMorph.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarMorph.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D474 RID: 250996 RVA: 0x00EC4764 File Offset: 0x00EC2964
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

		// Token: 0x0603D475 RID: 250997 RVA: 0x00EC47D8 File Offset: 0x00EC29D8
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

		// Token: 0x0603D476 RID: 250998 RVA: 0x00EC49D8 File Offset: 0x00EC2BD8
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

		// Token: 0x0603D477 RID: 250999 RVA: 0x00EC4A48 File Offset: 0x00EC2C48
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

		// Token: 0x0603D478 RID: 251000 RVA: 0x00EC4AAC File Offset: 0x00EC2CAC
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarMorph.<InitBarItem>d__22 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarMorph.<InitBarItem>d__22>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D479 RID: 251001 RVA: 0x00EC4AEF File Offset: 0x00EC2CEF
		[NullableContext(2)]
		protected virtual Type GetSpecialEnergyBarClass()
		{
			return SpecialEnergyBarMorph.SpecialEnergyBarClassList.GetValueOrDefault(this.Config.PrefabType);
		}

		// Token: 0x0603D47A RID: 251002 RVA: 0x00EC4B06 File Offset: 0x00EC2D06
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.IconHandle.OnBeforeDestroy();
			this.FrontIconHandle.OnBeforeDestroy();
		}

		// Token: 0x0603D47B RID: 251003 RVA: 0x00EC4B24 File Offset: 0x00EC2D24
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

		// Token: 0x0603D47C RID: 251004 RVA: 0x00EC4B58 File Offset: 0x00EC2D58
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

		// Token: 0x0603D47D RID: 251005 RVA: 0x00EC4BA7 File Offset: 0x00EC2DA7
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

		// Token: 0x0603D47E RID: 251006 RVA: 0x00EC4BCF File Offset: 0x00EC2DCF
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D47F RID: 251007 RVA: 0x00EC4BD8 File Offset: 0x00EC2DD8
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D480 RID: 251008 RVA: 0x00EC4BE4 File Offset: 0x00EC2DE4
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

		// Token: 0x0603D481 RID: 251009 RVA: 0x00EC4CA2 File Offset: 0x00EC2EA2
		public override void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			this.BarItem.ReplaceFullEffect(niagara);
		}

		// Token: 0x0401FF41 RID: 130881
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

		// Token: 0x0401FF42 RID: 130882
		private const double EFFECT_DURATION = 500.0;

		// Token: 0x0401FF43 RID: 130883
		private readonly SpecialEnergyBaIconHandle IconHandle = new SpecialEnergyBaIconHandle();

		// Token: 0x0401FF44 RID: 130884
		private readonly SpecialEnergyBaIconHandle FrontIconHandle = new SpecialEnergyBaIconHandle();

		// Token: 0x0401FF45 RID: 130885
		[Nullable(2)]
		protected SpecialEnergyBarBase BarItem;

		// Token: 0x0401FF46 RID: 130886
		private double StartEffectFinishTime;

		// Token: 0x0401FF47 RID: 130887
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401FF48 RID: 130888
		private int BuffHandle;

		// Token: 0x0401FF49 RID: 130889
		private bool NeedRefreshIconOnKeyEnable;

		// Token: 0x0401FF4A RID: 130890
		private bool ExtraEffectActive;

		// Token: 0x0401FF4B RID: 130891
		protected bool NeedExtraEffectOnKeyEnable;

		// Token: 0x0401FF4C RID: 130892
		protected int KeyEnableNiagaraIndex = -1;

		// Token: 0x0401FF4D RID: 130893
		protected int ReplaceFullEffectIndex = -1;

		// Token: 0x0401FF4E RID: 130894
		protected int ReplaceStartEffectIndex = -1;

		// Token: 0x0200C197 RID: 49559
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A7FB RID: 239611
			IconTexture,
			// Token: 0x0403A7FC RID: 239612
			KeyContainerItem,
			// Token: 0x0403A7FD RID: 239613
			StartEffect,
			// Token: 0x0403A7FE RID: 239614
			ExtraEffect,
			// Token: 0x0403A7FF RID: 239615
			SlotContainerItem,
			// Token: 0x0403A800 RID: 239616
			FrontIconTexture,
			// Token: 0x0403A801 RID: 239617
			AnimItem
		}
	}
}
