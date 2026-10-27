using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF4 RID: 24052
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarLuXi : SpecialEnergyBarBase
	{
		// Token: 0x0603D23C RID: 250428 RVA: 0x00EB8AA4 File Offset: 0x00EB6CA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D23D RID: 250429 RVA: 0x00EB8D05 File Offset: 0x00EB6F05
		protected override void OnInitData()
		{
			this.RedConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(151101);
		}

		// Token: 0x0603D23E RID: 250430 RVA: 0x00EB8D24 File Offset: 0x00EB6F24
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLuXi.NormalActivateTag, new BaseTagComponent.TTagSwitchedCallback(this.OnNormalActivateTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLuXi.NormalActivateTag2, new BaseTagComponent.TTagSwitchedCallback(this.OnNormalActivateTagChange2));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLuXi.RedOverclockTag, new BaseTagComponent.TTagSwitchedCallback(this.OnRedOverclockTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLuXi.RedWeakTag, new BaseTagComponent.TTagSwitchedCallback(this.OnRedWeakTagChange));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.WeakAttributeChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2Max, new Action<EAttributeType, float, float>(this.WeakAttributeChanged));
		}

		// Token: 0x0603D23F RID: 250431 RVA: 0x00EB8DBB File Offset: 0x00EB6FBB
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.WeakAttributeChanged));
			base.RemoveListenAttributeChanged(EAttributeType.SpecialEnergy2Max, new Action<EAttributeType, float, float>(this.WeakAttributeChanged));
		}

		// Token: 0x0603D240 RID: 250432 RVA: 0x00EB8DEB File Offset: 0x00EB6FEB
		private void OnNormalActivateTagChange(int tagId, bool tagExist)
		{
			this.IsNormalActivate = tagExist;
			this.StateDirty = true;
		}

		// Token: 0x0603D241 RID: 250433 RVA: 0x00EB8DFB File Offset: 0x00EB6FFB
		private void OnNormalActivateTagChange2(int tagId, bool tagExist)
		{
			this.IsNormalActivate2 = tagExist;
			this.StateDirty = true;
		}

		// Token: 0x0603D242 RID: 250434 RVA: 0x00EB8E0B File Offset: 0x00EB700B
		private void OnRedOverclockTagChange(int tagId, bool tagExist)
		{
			this.IsRedOverclock = tagExist;
			this.StateDirty = true;
		}

		// Token: 0x0603D243 RID: 250435 RVA: 0x00EB8E1B File Offset: 0x00EB701B
		private void OnRedWeakTagChange(int tagId, bool tagExist)
		{
			this.IsRedWeak = tagExist;
			this.StateDirty = true;
		}

		// Token: 0x0603D244 RID: 250436 RVA: 0x00EB8E2B File Offset: 0x00EB702B
		private void WeakAttributeChanged(EAttributeType attributeId, float curValue, float maxValue)
		{
			this.OnWeakAttributeChanged();
		}

		// Token: 0x0603D245 RID: 250437 RVA: 0x00EB8E34 File Offset: 0x00EB7034
		protected void OnWeakAttributeChanged()
		{
			if (this.AttributeComponent == null)
			{
				return;
			}
			float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2);
			float currentValue2 = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max);
			float targetPercent = 0f;
			if (currentValue2 > 0f)
			{
				targetPercent = currentValue / currentValue2;
			}
			this.WeakPercentMachine.SetTargetPercent(targetPercent);
			this.OnWeakPercentChanged();
		}

		// Token: 0x0603D246 RID: 250438 RVA: 0x00EB8E8C File Offset: 0x00EB708C
		protected void OnWeakPercentChanged()
		{
			float curPercent = this.WeakPercentMachine.GetCurPercent();
			UUISprite sprite = base.GetSprite(7);
			if (sprite == null)
			{
				return;
			}
			sprite.SetFillAmount(curPercent);
		}

		// Token: 0x0603D247 RID: 250439 RVA: 0x00EB8EB8 File Offset: 0x00EB70B8
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuXi.<OnBeforeStartAsync>d__40 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuXi.<OnBeforeStartAsync>d__40>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D248 RID: 250440 RVA: 0x00EB8EFC File Offset: 0x00EB70FC
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLuXi.<InitBarItem>d__41 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuXi.<InitBarItem>d__41>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D249 RID: 250441 RVA: 0x00EB8F40 File Offset: 0x00EB7140
		protected override void OnStart()
		{
			this.WeakPercentMachine.Duration = this.RedConfig.ExtraFloatParams[0] * 1000f;
			this.LineFlowDensityCurveAsset = ResourceSystem.Instance.Load<UCurveFloat>(UiResourceConfig.Instance.GetResourcePath("Curve_LIneFlow01_Luxi"), "js_undefined");
			this.LineFlowIntensityCurveAsset = ResourceSystem.Instance.Load<UCurveFloat>(UiResourceConfig.Instance.GetResourcePath("Curve_LIneFlow02_Luxi"), "js_undefined");
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			base.InitTweenAnim(15);
			base.InitTweenAnim(16);
			this.LastBarPercent = this.PercentMachine.GetCurPercent();
			this.RefreshLineFlowMaterial(0f);
			BaseTagComponent tagComponent = this.TagComponent;
			this.IsNormalActivate = (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarLuXi.NormalActivateTag));
			BaseTagComponent tagComponent2 = this.TagComponent;
			this.IsNormalActivate2 = (tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarLuXi.NormalActivateTag2));
			BaseTagComponent tagComponent3 = this.TagComponent;
			this.IsRedWeak = (tagComponent3 != null && tagComponent3.HasTag(SpecialEnergyBarLuXi.RedWeakTag));
			BaseTagComponent tagComponent4 = this.TagComponent;
			this.IsRedOverclock = (tagComponent4 != null && tagComponent4.HasTag(SpecialEnergyBarLuXi.RedOverclockTag));
			this.RefreshState(true);
			this.OnWeakAttributeChanged();
		}

		// Token: 0x0603D24A RID: 250442 RVA: 0x00EB9074 File Offset: 0x00EB7274
		protected override void OnBarPercentChanged()
		{
			base.OnBarPercentChanged();
			float curPercent = this.PercentMachine.GetCurPercent();
			bool flag = curPercent > this.LastBarPercent;
			bool flag2 = curPercent >= 1f;
			if (this.IsFullPercent != flag2)
			{
				this.IsFullPercent = flag2;
				this.RefreshLineFlowVisible();
				this.RefreshNormalLightItem();
				this.RefreshNiaMax();
				if (this.CurState == SpecialEnergyBarLuXi.EState.Normal)
				{
					base.PlayTweenAnim(14);
				}
			}
			if (this.CurState == SpecialEnergyBarLuXi.EState.NormalActivate && flag && !this.IsFullPercent)
			{
				this.TryPlayLineFlowGrowAnim();
			}
			this.LastBarPercent = curPercent;
		}

		// Token: 0x0603D24B RID: 250443 RVA: 0x00EB9100 File Offset: 0x00EB7300
		private void RefreshState(bool isStart = false)
		{
			if (this.IsRedWeak)
			{
				this.SetState(SpecialEnergyBarLuXi.EState.RedWeak, isStart);
				return;
			}
			if (this.IsRedOverclock)
			{
				this.SetState(SpecialEnergyBarLuXi.EState.RedOverclock, isStart);
				return;
			}
			if (this.IsNormalActivate || this.IsNormalActivate2)
			{
				this.SetState(SpecialEnergyBarLuXi.EState.NormalActivate, isStart);
				return;
			}
			this.SetState(SpecialEnergyBarLuXi.EState.Normal, isStart);
		}

		// Token: 0x0603D24C RID: 250444 RVA: 0x00EB9150 File Offset: 0x00EB7350
		private void SetState(SpecialEnergyBarLuXi.EState state, bool isStart = false)
		{
			if (state == this.CurState && !isStart)
			{
				return;
			}
			SpecialEnergyBarLuXi.EState curState = this.CurState;
			this.CurState = state;
			switch (this.CurState)
			{
			case SpecialEnergyBarLuXi.EState.Normal:
			{
				UUIItem item = base.GetItem(0);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUIItem item2 = base.GetItem(5);
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				UUIItem item3 = base.GetItem(3);
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				this.RefreshLineFlowVisible();
				this.RefreshNormalLightItem();
				if (!isStart && curState != SpecialEnergyBarLuXi.EState.Normal && curState != SpecialEnergyBarLuXi.EState.NormalActivate)
				{
					base.PlayTweenAnim(16);
					return;
				}
				break;
			}
			case SpecialEnergyBarLuXi.EState.NormalActivate:
			{
				UUIItem item4 = base.GetItem(0);
				if (item4 != null)
				{
					item4.SetUIActive(true);
				}
				UUIItem item5 = base.GetItem(5);
				if (item5 != null)
				{
					item5.SetUIActive(false);
				}
				UUIItem item6 = base.GetItem(3);
				if (item6 != null)
				{
					item6.SetUIActive(true);
				}
				this.RefreshLineFlowVisible();
				this.RefreshNormalLightItem();
				if (!isStart)
				{
					if (curState != SpecialEnergyBarLuXi.EState.Normal && curState != SpecialEnergyBarLuXi.EState.NormalActivate)
					{
						base.PlayTweenAnim(16);
					}
					base.PlayTweenAnim(14);
					this.TryPlayLineFlowGrowAnim();
					return;
				}
				break;
			}
			case SpecialEnergyBarLuXi.EState.RedOverclock:
			{
				UUIItem item7 = base.GetItem(0);
				if (item7 != null)
				{
					item7.SetUIActive(false);
				}
				UUIItem item8 = base.GetItem(5);
				if (item8 != null)
				{
					item8.SetUIActive(true);
				}
				UUIItem item9 = base.GetItem(11);
				if (item9 != null)
				{
					item9.SetUIActive(true);
				}
				UUINiagara uiNiagara = base.GetUiNiagara(12);
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(false);
				}
				this.RefreshNiaMax();
				if (!isStart && curState != SpecialEnergyBarLuXi.EState.RedOverclock && curState != SpecialEnergyBarLuXi.EState.RedWeak)
				{
					base.PlayTweenAnim(15);
					return;
				}
				break;
			}
			case SpecialEnergyBarLuXi.EState.RedWeak:
			{
				UUIItem item10 = base.GetItem(0);
				if (item10 != null)
				{
					item10.SetUIActive(false);
				}
				UUIItem item11 = base.GetItem(5);
				if (item11 != null)
				{
					item11.SetUIActive(true);
				}
				UUIItem item12 = base.GetItem(11);
				if (item12 != null)
				{
					item12.SetUIActive(false);
				}
				UUINiagara uiNiagara2 = base.GetUiNiagara(12);
				if (uiNiagara2 != null)
				{
					uiNiagara2.SetUIActive(true);
				}
				UUINiagara uiNiagara3 = base.GetUiNiagara(9);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetUIActive(false);
				}
				if (!isStart && curState != SpecialEnergyBarLuXi.EState.RedOverclock && curState != SpecialEnergyBarLuXi.EState.RedWeak)
				{
					base.PlayTweenAnim(15);
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x0603D24D RID: 250445 RVA: 0x00EB9344 File Offset: 0x00EB7544
		private void RefreshNormalLightItem()
		{
			bool flag = false;
			if (this.CurState == SpecialEnergyBarLuXi.EState.Normal)
			{
				flag = this.IsFullPercent;
			}
			else if (this.CurState == SpecialEnergyBarLuXi.EState.NormalActivate)
			{
				flag = true;
			}
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			SpecialEnergyBarLuXiSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal == null)
			{
				return;
			}
			barItemNormal.SetColorState((flag > false) ? 1 : 0);
		}

		// Token: 0x0603D24E RID: 250446 RVA: 0x00EB9398 File Offset: 0x00EB7598
		private void RefreshLineFlowVisible()
		{
			bool uiactive = this.CurState == SpecialEnergyBarLuXi.EState.NormalActivate && !this.IsFullPercent;
			UUITexture texture = base.GetTexture(8);
			if (texture == null)
			{
				return;
			}
			texture.SetUIActive(uiactive);
		}

		// Token: 0x0603D24F RID: 250447 RVA: 0x00EB93CD File Offset: 0x00EB75CD
		private void RefreshNiaMax()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(9);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(this.CurState == SpecialEnergyBarLuXi.EState.RedOverclock && this.IsFullPercent);
		}

		// Token: 0x0603D250 RID: 250448 RVA: 0x00EB93F3 File Offset: 0x00EB75F3
		private void TryPlayLineFlowGrowAnim()
		{
			if (this.LineFlowAnimTriggerCd < 2000f)
			{
				return;
			}
			this.LineFlowAnimTriggerCd = 0f;
			this.LineFlowAnimElapsed = 0f;
			this.RefreshLineFlowMaterial(0f);
			base.PlayTweenAnim(13);
		}

		// Token: 0x0603D251 RID: 250449 RVA: 0x00EB942C File Offset: 0x00EB762C
		private void RefreshLineFlowMaterial(float elapsedTime)
		{
			UUITexture texture = base.GetTexture(8);
			if (texture == null)
			{
				return;
			}
			float inTime = elapsedTime / 1000f;
			UCurveFloat lineFlowDensityCurveAsset = this.LineFlowDensityCurveAsset;
			float value = (lineFlowDensityCurveAsset != null) ? lineFlowDensityCurveAsset.GetFloatValue(inTime) : 0f;
			UCurveFloat lineFlowIntensityCurveAsset = this.LineFlowIntensityCurveAsset;
			float value2 = (lineFlowIntensityCurveAsset != null) ? lineFlowIntensityCurveAsset.GetFloatValue(inTime) : 0f;
			texture.SetCustomMaterialScalarParameter(this.NameDensityU, value);
			texture.SetCustomMaterialScalarParameter(this.NameIntensityU, value2);
		}

		// Token: 0x0603D252 RID: 250450 RVA: 0x00EB9498 File Offset: 0x00EB7698
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarLuXiSlot barItemRed = this.BarItemRed;
			if (barItemRed != null)
			{
				barItemRed.Tick(delta);
			}
			SpecialEnergyBarLuXiSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal != null)
			{
				barItemNormal.Tick(delta);
			}
			if (this.StateDirty)
			{
				this.RefreshState(false);
				this.StateDirty = false;
			}
			if (this.WeakPercentMachine.Update(delta))
			{
				this.OnWeakPercentChanged();
			}
			if (this.LineFlowAnimTriggerCd < 2000f)
			{
				this.LineFlowAnimTriggerCd = Math.Min(this.LineFlowAnimTriggerCd + delta, 2000f);
			}
			if (this.LineFlowAnimElapsed < 2000f)
			{
				this.LineFlowAnimElapsed = Math.Min(this.LineFlowAnimElapsed + delta, 2000f);
				this.RefreshLineFlowMaterial(this.LineFlowAnimElapsed);
			}
		}

		// Token: 0x0401FDEA RID: 130538
		private const int RedConfigId = 151101;

		// Token: 0x0401FDEB RID: 130539
		[Nullable(1)]
		private const string LineFlowDensityCurve = "Curve_LIneFlow01_Luxi";

		// Token: 0x0401FDEC RID: 130540
		[Nullable(1)]
		private const string LineFlowIntensityCurve = "Curve_LIneFlow02_Luxi";

		// Token: 0x0401FDED RID: 130541
		private const float LineFlowAnimDuration = 2000f;

		// Token: 0x0401FDEE RID: 130542
		private const float LineFlowAnimTriggerInterval = 2000f;

		// Token: 0x0401FDEF RID: 130543
		private static readonly int NormalActivateTag = GameplayTagDefine.EGameplayTagId["角色.R2T1LucyMd10011.黑客效果.跟踪同步"];

		// Token: 0x0401FDF0 RID: 130544
		private static readonly int NormalActivateTag2 = GameplayTagDefine.EGameplayTagId["角色.R2T1LucyMd10011.状态标识.黑客E可用"];

		// Token: 0x0401FDF1 RID: 130545
		private static readonly int RedOverclockTag = GameplayTagDefine.EGameplayTagId["角色.R2T1LucyMd10011.状态标识.强化重击印记"];

		// Token: 0x0401FDF2 RID: 130546
		private static readonly int RedWeakTag = GameplayTagDefine.EGameplayTagId["角色.R2T1LucyMd10011.状态标识.烧血警告"];

		// Token: 0x0401FDF3 RID: 130547
		private SpecialEnergyBarInfo RedConfig;

		// Token: 0x0401FDF4 RID: 130548
		private SpecialEnergyBarLuXiSlot BarItemRed;

		// Token: 0x0401FDF5 RID: 130549
		private SpecialEnergyBarLuXiSlot BarItemNormal;

		// Token: 0x0401FDF6 RID: 130550
		private bool IsNormalActivate;

		// Token: 0x0401FDF7 RID: 130551
		private bool IsNormalActivate2;

		// Token: 0x0401FDF8 RID: 130552
		private bool IsRedOverclock;

		// Token: 0x0401FDF9 RID: 130553
		private bool IsRedWeak;

		// Token: 0x0401FDFA RID: 130554
		private bool StateDirty;

		// Token: 0x0401FDFB RID: 130555
		private SpecialEnergyBarLuXi.EState CurState;

		// Token: 0x0401FDFC RID: 130556
		private bool IsFullPercent;

		// Token: 0x0401FDFD RID: 130557
		[Nullable(1)]
		private readonly SpecialEnergyBarPercentMachinePro WeakPercentMachine = new SpecialEnergyBarPercentMachinePro();

		// Token: 0x0401FDFE RID: 130558
		private readonly FName NameDensityU = FNameUtil.GetDynamicFName("密度U").Value;

		// Token: 0x0401FDFF RID: 130559
		private readonly FName NameIntensityU = FNameUtil.GetDynamicFName("强度U").Value;

		// Token: 0x0401FE00 RID: 130560
		private UCurveFloat LineFlowDensityCurveAsset;

		// Token: 0x0401FE01 RID: 130561
		private UCurveFloat LineFlowIntensityCurveAsset;

		// Token: 0x0401FE02 RID: 130562
		private float LineFlowAnimElapsed = 2000f;

		// Token: 0x0401FE03 RID: 130563
		private float LineFlowAnimTriggerCd = 2000f;

		// Token: 0x0401FE04 RID: 130564
		private float LastBarPercent;

		// Token: 0x0200C131 RID: 49457
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A57E RID: 238974
			NormalItem,
			// Token: 0x0403A57F RID: 238975
			NormalFullLightItem,
			// Token: 0x0403A580 RID: 238976
			NormalLightItem,
			// Token: 0x0403A581 RID: 238977
			NormalActivateItem,
			// Token: 0x0403A582 RID: 238978
			SlotBarItemNormal,
			// Token: 0x0403A583 RID: 238979
			RedItem,
			// Token: 0x0403A584 RID: 238980
			SlotBarItemRed,
			// Token: 0x0403A585 RID: 238981
			RedExtraBarSprite,
			// Token: 0x0403A586 RID: 238982
			TexLineFlow,
			// Token: 0x0403A587 RID: 238983
			NiaMax,
			// Token: 0x0403A588 RID: 238984
			NiaGlitchS,
			// Token: 0x0403A589 RID: 238985
			NiaLightItem,
			// Token: 0x0403A58A RID: 238986
			NiaGlitchBig,
			// Token: 0x0403A58B RID: 238987
			AnimActivate,
			// Token: 0x0403A58C RID: 238988
			AnimNormalFull,
			// Token: 0x0403A58D RID: 238989
			AnimRed,
			// Token: 0x0403A58E RID: 238990
			AnimBackNormal
		}

		// Token: 0x0200C132 RID: 49458
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x0403A590 RID: 238992
			Normal,
			// Token: 0x0403A591 RID: 238993
			NormalActivate,
			// Token: 0x0403A592 RID: 238994
			RedOverclock,
			// Token: 0x0403A593 RID: 238995
			RedWeak
		}
	}
}
