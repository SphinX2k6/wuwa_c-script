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
	// Token: 0x02004DD9 RID: 19929
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarLuXi : SpecialEnergyBarBase
	{
		// Token: 0x060321CB RID: 205259 RVA: 0x00E09FEC File Offset: 0x00E081EC
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

		// Token: 0x060321CC RID: 205260 RVA: 0x00E0A24D File Offset: 0x00E0844D
		protected override void OnInitData()
		{
			this.RedConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(151101);
		}

		// Token: 0x060321CD RID: 205261 RVA: 0x00E0A26C File Offset: 0x00E0846C
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

		// Token: 0x060321CE RID: 205262 RVA: 0x00E0A303 File Offset: 0x00E08503
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.WeakAttributeChanged));
			base.RemoveListenAttributeChanged(EAttributeType.SpecialEnergy2Max, new Action<EAttributeType, float, float>(this.WeakAttributeChanged));
		}

		// Token: 0x060321CF RID: 205263 RVA: 0x00E0A333 File Offset: 0x00E08533
		private void OnNormalActivateTagChange(int tagId, bool tagExist)
		{
			this.IsNormalActivate = tagExist;
			this.StateDirty = true;
		}

		// Token: 0x060321D0 RID: 205264 RVA: 0x00E0A343 File Offset: 0x00E08543
		private void OnNormalActivateTagChange2(int tagId, bool tagExist)
		{
			this.IsNormalActivate2 = tagExist;
			this.StateDirty = true;
		}

		// Token: 0x060321D1 RID: 205265 RVA: 0x00E0A353 File Offset: 0x00E08553
		private void OnRedOverclockTagChange(int tagId, bool tagExist)
		{
			this.IsRedOverclock = tagExist;
			this.StateDirty = true;
		}

		// Token: 0x060321D2 RID: 205266 RVA: 0x00E0A363 File Offset: 0x00E08563
		private void OnRedWeakTagChange(int tagId, bool tagExist)
		{
			this.IsRedWeak = tagExist;
			this.StateDirty = true;
		}

		// Token: 0x060321D3 RID: 205267 RVA: 0x00E0A373 File Offset: 0x00E08573
		private void WeakAttributeChanged(EAttributeType attributeId, float curValue, float maxValue)
		{
			this.OnWeakAttributeChanged();
		}

		// Token: 0x060321D4 RID: 205268 RVA: 0x00E0A37C File Offset: 0x00E0857C
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

		// Token: 0x060321D5 RID: 205269 RVA: 0x00E0A3D4 File Offset: 0x00E085D4
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

		// Token: 0x060321D6 RID: 205270 RVA: 0x00E0A400 File Offset: 0x00E08600
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLuXi.<OnBeforeStartAsync>d__40 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLuXi.<OnBeforeStartAsync>d__40>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060321D7 RID: 205271 RVA: 0x00E0A444 File Offset: 0x00E08644
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarLuXi.<InitBarItem>d__41 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarLuXi.<InitBarItem>d__41>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060321D8 RID: 205272 RVA: 0x00E0A488 File Offset: 0x00E08688
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

		// Token: 0x060321D9 RID: 205273 RVA: 0x00E0A5BC File Offset: 0x00E087BC
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

		// Token: 0x060321DA RID: 205274 RVA: 0x00E0A648 File Offset: 0x00E08848
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

		// Token: 0x060321DB RID: 205275 RVA: 0x00E0A698 File Offset: 0x00E08898
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

		// Token: 0x060321DC RID: 205276 RVA: 0x00E0A88C File Offset: 0x00E08A8C
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

		// Token: 0x060321DD RID: 205277 RVA: 0x00E0A8E0 File Offset: 0x00E08AE0
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

		// Token: 0x060321DE RID: 205278 RVA: 0x00E0A915 File Offset: 0x00E08B15
		private void RefreshNiaMax()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(9);
			if (uiNiagara == null)
			{
				return;
			}
			uiNiagara.SetUIActive(this.CurState == SpecialEnergyBarLuXi.EState.RedOverclock && this.IsFullPercent);
		}

		// Token: 0x060321DF RID: 205279 RVA: 0x00E0A93B File Offset: 0x00E08B3B
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

		// Token: 0x060321E0 RID: 205280 RVA: 0x00E0A974 File Offset: 0x00E08B74
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

		// Token: 0x060321E1 RID: 205281 RVA: 0x00E0A9E0 File Offset: 0x00E08BE0
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

		// Token: 0x0401A8B1 RID: 108721
		private const int RedConfigId = 151101;

		// Token: 0x0401A8B2 RID: 108722
		[Nullable(1)]
		private const string LineFlowDensityCurve = "Curve_LIneFlow01_Luxi";

		// Token: 0x0401A8B3 RID: 108723
		[Nullable(1)]
		private const string LineFlowIntensityCurve = "Curve_LIneFlow02_Luxi";

		// Token: 0x0401A8B4 RID: 108724
		private const float LineFlowAnimDuration = 2000f;

		// Token: 0x0401A8B5 RID: 108725
		private const float LineFlowAnimTriggerInterval = 2000f;

		// Token: 0x0401A8B6 RID: 108726
		private static readonly int NormalActivateTag = GameplayTagDefine.EGameplayTagId["角色.R2T1LucyMd10011.黑客效果.跟踪同步"];

		// Token: 0x0401A8B7 RID: 108727
		private static readonly int NormalActivateTag2 = GameplayTagDefine.EGameplayTagId["角色.R2T1LucyMd10011.状态标识.黑客E可用"];

		// Token: 0x0401A8B8 RID: 108728
		private static readonly int RedOverclockTag = GameplayTagDefine.EGameplayTagId["角色.R2T1LucyMd10011.状态标识.强化重击印记"];

		// Token: 0x0401A8B9 RID: 108729
		private static readonly int RedWeakTag = GameplayTagDefine.EGameplayTagId["角色.R2T1LucyMd10011.状态标识.烧血警告"];

		// Token: 0x0401A8BA RID: 108730
		private SpecialEnergyBarInfo RedConfig;

		// Token: 0x0401A8BB RID: 108731
		private SpecialEnergyBarLuXiSlot BarItemRed;

		// Token: 0x0401A8BC RID: 108732
		private SpecialEnergyBarLuXiSlot BarItemNormal;

		// Token: 0x0401A8BD RID: 108733
		private bool IsNormalActivate;

		// Token: 0x0401A8BE RID: 108734
		private bool IsNormalActivate2;

		// Token: 0x0401A8BF RID: 108735
		private bool IsRedOverclock;

		// Token: 0x0401A8C0 RID: 108736
		private bool IsRedWeak;

		// Token: 0x0401A8C1 RID: 108737
		private bool StateDirty;

		// Token: 0x0401A8C2 RID: 108738
		private SpecialEnergyBarLuXi.EState CurState;

		// Token: 0x0401A8C3 RID: 108739
		private bool IsFullPercent;

		// Token: 0x0401A8C4 RID: 108740
		[Nullable(1)]
		private readonly SpecialEnergyBarPercentMachinePro WeakPercentMachine = new SpecialEnergyBarPercentMachinePro();

		// Token: 0x0401A8C5 RID: 108741
		private readonly FName NameDensityU = FNameUtil.GetDynamicFName("密度U").Value;

		// Token: 0x0401A8C6 RID: 108742
		private readonly FName NameIntensityU = FNameUtil.GetDynamicFName("强度U").Value;

		// Token: 0x0401A8C7 RID: 108743
		private UCurveFloat LineFlowDensityCurveAsset;

		// Token: 0x0401A8C8 RID: 108744
		private UCurveFloat LineFlowIntensityCurveAsset;

		// Token: 0x0401A8C9 RID: 108745
		private float LineFlowAnimElapsed = 2000f;

		// Token: 0x0401A8CA RID: 108746
		private float LineFlowAnimTriggerCd = 2000f;

		// Token: 0x0401A8CB RID: 108747
		private float LastBarPercent;

		// Token: 0x0200AB40 RID: 43840
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034F70 RID: 216944
			NormalItem,
			// Token: 0x04034F71 RID: 216945
			NormalFullLightItem,
			// Token: 0x04034F72 RID: 216946
			NormalLightItem,
			// Token: 0x04034F73 RID: 216947
			NormalActivateItem,
			// Token: 0x04034F74 RID: 216948
			SlotBarItemNormal,
			// Token: 0x04034F75 RID: 216949
			RedItem,
			// Token: 0x04034F76 RID: 216950
			SlotBarItemRed,
			// Token: 0x04034F77 RID: 216951
			RedExtraBarSprite,
			// Token: 0x04034F78 RID: 216952
			TexLineFlow,
			// Token: 0x04034F79 RID: 216953
			NiaMax,
			// Token: 0x04034F7A RID: 216954
			NiaGlitchS,
			// Token: 0x04034F7B RID: 216955
			NiaLightItem,
			// Token: 0x04034F7C RID: 216956
			NiaGlitchBig,
			// Token: 0x04034F7D RID: 216957
			AnimActivate,
			// Token: 0x04034F7E RID: 216958
			AnimNormalFull,
			// Token: 0x04034F7F RID: 216959
			AnimRed,
			// Token: 0x04034F80 RID: 216960
			AnimBackNormal
		}

		// Token: 0x0200AB41 RID: 43841
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04034F82 RID: 216962
			Normal,
			// Token: 0x04034F83 RID: 216963
			NormalActivate,
			// Token: 0x04034F84 RID: 216964
			RedOverclock,
			// Token: 0x04034F85 RID: 216965
			RedWeak
		}
	}
}
