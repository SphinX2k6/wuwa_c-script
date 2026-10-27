using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DCB RID: 24011
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarAoGuSiTa : SpecialEnergyBarBase
	{
		// Token: 0x0603D04C RID: 249932 RVA: 0x00EAC418 File Offset: 0x00EAA618
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D04D RID: 249933 RVA: 0x00EAC69C File Offset: 0x00EAA89C
		protected override void OnInitData()
		{
			this.ConfigList.Add(this.Config);
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130601));
			this.ConfigList.Add(BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130602));
			this.UltraConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(130603);
			this.AttributeId = (EAttributeType)this.UltraConfig.AttributeId;
			this.MaxAttributeId = (EAttributeType)this.UltraConfig.MaxAttributeId;
			this.WarnTime = this.UltraConfig.ExtraFloatParams[0] * (float)TimeUtil.Instance.InverseMillisecond;
		}

		// Token: 0x0603D04E RID: 249934 RVA: 0x00EAC758 File Offset: 0x00EAA958
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarAoGuSiTa.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarAoGuSiTa.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D04F RID: 249935 RVA: 0x00EAC79C File Offset: 0x00EAA99C
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarAoGuSiTa.<InitBarItem>d__23 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarAoGuSiTa.<InitBarItem>d__23>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D050 RID: 249936 RVA: 0x00EAC7E0 File Offset: 0x00EAA9E0
		[NullableContext(1)]
		protected override UniTask InitKeyItem(UUIItem keyItemContainer)
		{
			SpecialEnergyBarAoGuSiTa.<InitKeyItem>d__24 <InitKeyItem>d__;
			<InitKeyItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitKeyItem>d__.<>4__this = this;
			<InitKeyItem>d__.keyItemContainer = keyItemContainer;
			<InitKeyItem>d__.<>1__state = -1;
			<InitKeyItem>d__.<>t__builder.Start<SpecialEnergyBarAoGuSiTa.<InitKeyItem>d__24>(ref <InitKeyItem>d__);
			return <InitKeyItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D051 RID: 249937 RVA: 0x00EAC82C File Offset: 0x00EAAA2C
		private UniTask LoadCurve()
		{
			SpecialEnergyBarAoGuSiTa.<LoadCurve>d__25 <LoadCurve>d__;
			<LoadCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCurve>d__.<>4__this = this;
			<LoadCurve>d__.<>1__state = -1;
			<LoadCurve>d__.<>t__builder.Start<SpecialEnergyBarAoGuSiTa.<LoadCurve>d__25>(ref <LoadCurve>d__);
			return <LoadCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0603D052 RID: 249938 RVA: 0x00EAC870 File Offset: 0x00EAAA70
		protected override void OnStart()
		{
			base.InitTweenAnim(14);
			base.InitTweenAnim(15);
			base.InitTweenAnim(16);
			this.UltraRiseEffect = new BattleUiNiagaraItem(base.GetUiNiagara(17));
			this.UltraRiseEffect.Duration = 500f;
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			BaseTagComponent tagComponent = this.TagComponent;
			bool isUltra = tagComponent != null && tagComponent.HasTag(SpecialEnergyBarAoGuSiTa.UltraTag);
			this.RefreshUltraState(isUltra, true);
			this.OnAttributeChangedB(true);
			BaseTagComponent tagComponent2 = this.TagComponent;
			int count = (tagComponent2 != null) ? tagComponent2.GetTagCount(SpecialEnergyBarAoGuSiTa.EnergyTag) : 0;
			this.OnEnergyTagChangedC(count, true);
			this.RefreshBarPercent(true);
			this.RefreshKeyItem();
			BattleUiRoleData roleData = this.RoleData;
			Entity entity;
			if (roleData == null)
			{
				entity = null;
			}
			else
			{
				EntityHandle entityHandle = roleData.EntityHandle;
				entity = ((entityHandle != null) ? entityHandle.Entity : null);
			}
			this.Entity = entity;
		}

		// Token: 0x0603D053 RID: 249939 RVA: 0x00EAC948 File Offset: 0x00EAAB48
		protected override void OnBeforeDestroy()
		{
			if (this.UltraRiseEffect != null)
			{
				this.UltraRiseEffect.Stop();
				this.UltraRiseEffect = null;
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603D054 RID: 249940 RVA: 0x00EAC96A File Offset: 0x00EAAB6A
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(16);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603D055 RID: 249941 RVA: 0x00EAC97C File Offset: 0x00EAAB7C
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarAoGuSiTa.UltraTag, new BaseTagComponent.TTagSwitchedCallback(this.OnUltraTagChange));
			base.ListenForTagCountChanged(SpecialEnergyBarAoGuSiTa.EnergyTag, new BaseTagComponent.TTagChangedCallback(this.OnEnergyTagChange));
			base.ListenForAttributeChanged((EAttributeType)this.ConfigList[1].AttributeId, new Action<EAttributeType, float, float>(this.AttributeChangedB));
			base.ListenForAttributeChanged((EAttributeType)this.ConfigList[1].MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChangedB));
			if (this.Entity != null)
			{
				EventSystem.Instance.AddWithTarget<bool, float>(this.Entity, EEventName.OnAbsoluteTimeStop, new Action<bool, float>(this.OnAbsoluteTimeStop));
			}
		}

		// Token: 0x0603D056 RID: 249942 RVA: 0x00EACA30 File Offset: 0x00EAAC30
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged((EAttributeType)this.ConfigList[1].AttributeId, new Action<EAttributeType, float, float>(this.AttributeChangedB));
			base.RemoveListenAttributeChanged((EAttributeType)this.ConfigList[1].MaxAttributeId, new Action<EAttributeType, float, float>(this.MaxAttributeChangedB));
			if (this.Entity != null)
			{
				EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.OnAbsoluteTimeStop, new Action<bool, float>(this.OnAbsoluteTimeStop));
			}
		}

		// Token: 0x0603D057 RID: 249943 RVA: 0x00EACAB3 File Offset: 0x00EAACB3
		private void OnUltraTagChange(int tagId, bool tagExist)
		{
			this.RefreshUltraState(tagExist, false);
		}

		// Token: 0x0603D058 RID: 249944 RVA: 0x00EACABD File Offset: 0x00EAACBD
		private void OnEnergyTagChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.OnEnergyTagChangedC(count, false);
		}

		// Token: 0x0603D059 RID: 249945 RVA: 0x00EACAC7 File Offset: 0x00EAACC7
		private void AttributeChangedB(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnAttributeChangedB(false);
		}

		// Token: 0x0603D05A RID: 249946 RVA: 0x00EACAD0 File Offset: 0x00EAACD0
		private void MaxAttributeChangedB(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnAttributeChangedB(false);
		}

		// Token: 0x0603D05B RID: 249947 RVA: 0x00EACADC File Offset: 0x00EAACDC
		protected void OnAttributeChangedB(bool isStart = false)
		{
			float currentValue = this.AttributeComponent.GetCurrentValue((EAttributeType)this.ConfigList[1].AttributeId);
			float currentValue2 = this.AttributeComponent.GetCurrentValue((EAttributeType)this.ConfigList[1].MaxAttributeId);
			float fillAmount = 0f;
			if (currentValue2 > 0f)
			{
				fillAmount = currentValue / currentValue2;
			}
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetFillAmount(fillAmount);
			}
			bool flag = currentValue >= currentValue2;
			if (this.IsEnergyFullB == flag && !isStart)
			{
				return;
			}
			this.IsEnergyFullB = flag;
			if (texture != null)
			{
				texture.SetUIActive(!flag);
			}
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				base.StopTweenAnim(15);
				base.PlayTweenAnim(14);
			}
			else
			{
				base.StopTweenAnim(14);
				base.PlayTweenAnim(15);
			}
			if (!isStart)
			{
				this.RefreshKeyItem();
			}
		}

		// Token: 0x0603D05C RID: 249948 RVA: 0x00EACBB8 File Offset: 0x00EAADB8
		protected void OnEnergyTagChangedC(int count, bool isStart = false)
		{
			this.RefreshCountEnergyC(Math.Min(count, 2), isStart);
		}

		// Token: 0x0603D05D RID: 249949 RVA: 0x00EACBC8 File Offset: 0x00EAADC8
		private void RefreshCountEnergyC(int count, bool isStart = false)
		{
			if (this.CountEnergyC == count && !isStart)
			{
				return;
			}
			this.CountEnergyC = count;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(count > 0);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(count > 1);
			}
			if (!isStart)
			{
				this.RefreshKeyItem();
			}
		}

		// Token: 0x0603D05E RID: 249950 RVA: 0x00EACC1E File Offset: 0x00EAAE1E
		protected override void OnAttributeChanged()
		{
			base.OnAttributeChanged();
			if (this.PercentMachine.GetTargetPercent() > 0f)
			{
				BattleUiNiagaraItem ultraRiseEffect = this.UltraRiseEffect;
				if (ultraRiseEffect == null)
				{
					return;
				}
				ultraRiseEffect.Play();
			}
		}

		// Token: 0x0603D05F RID: 249951 RVA: 0x00EACC48 File Offset: 0x00EAAE48
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D060 RID: 249952 RVA: 0x00EACC54 File Offset: 0x00EAAE54
		private void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			base.GetTexture(5).SetFillAmount(curPercent);
			base.GetSlider(8).SetValue(curPercent, true);
			float num = -207f + 428f * curPercent;
			UCurveFloat ultraCurve = this.UltraCurve;
			float anchorOffsetY = (ultraCurve != null) ? ultraCurve.GetFloatValue(num) : curPercent;
			UUINiagara uiNiagara = base.GetUiNiagara(12);
			uiNiagara.SetAnchorOffsetX(num);
			uiNiagara.SetAnchorOffsetY(anchorOffsetY);
			this.RefreshUltraEnergyFull(curPercent >= 1f, isStart);
			bool keyEnable = this.GetKeyEnable();
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0603D061 RID: 249953 RVA: 0x00EACCEC File Offset: 0x00EAAEEC
		private void RefreshUltraEnergyFull(bool isFull, bool isStart = false)
		{
			if (this.IsUltraEnergyFull == isFull && !isStart)
			{
				return;
			}
			this.IsUltraEnergyFull = isFull;
			base.GetTexture(5).SetUIActive(!isFull);
			base.GetItem(7).SetUIActive(!isFull);
			base.GetUiNiagara(12).SetUIActive(!isFull);
			base.GetItem(11).SetUIActive(isFull);
		}

		// Token: 0x0603D062 RID: 249954 RVA: 0x00EACD4C File Offset: 0x00EAAF4C
		private void RefreshKeyItem()
		{
			if (this.CountEnergyC > 1)
			{
				SpecialEnergyBarAoGuSiTaSlot barItem = this.BarItem;
				if (barItem == null)
				{
					return;
				}
				barItem.SetKeyItemType(2);
				return;
			}
			else if (this.IsEnergyFullB)
			{
				SpecialEnergyBarAoGuSiTaSlot barItem2 = this.BarItem;
				if (barItem2 == null)
				{
					return;
				}
				barItem2.SetKeyItemType(1);
				return;
			}
			else
			{
				SpecialEnergyBarAoGuSiTaSlot barItem3 = this.BarItem;
				if (barItem3 == null)
				{
					return;
				}
				barItem3.SetKeyItemType(0);
				return;
			}
		}

		// Token: 0x0603D063 RID: 249955 RVA: 0x00EACD9F File Offset: 0x00EAAF9F
		private void RefreshUltraState(bool isUltra, bool isStart = false)
		{
			if (this.IsUltra == isUltra && !isStart)
			{
				return;
			}
			this.IsUltra = isUltra;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(!isUltra);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(isUltra);
		}

		// Token: 0x0603D064 RID: 249956 RVA: 0x00EACDDE File Offset: 0x00EAAFDE
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(16);
				return;
			}
			base.StopTweenAnim(16);
			UUIItem item = base.GetItem(10);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(1f);
		}

		// Token: 0x0603D065 RID: 249957 RVA: 0x00EACE1C File Offset: 0x00EAB01C
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarAoGuSiTaSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			if (!this.IsUltra)
			{
				this.PlayWarnAnim(false);
				return;
			}
			if (!TimerSystem.Instance.Has(this.TimerHandle))
			{
				this.PlayWarnAnim(false);
				return;
			}
			float nextRemainTime = TimerSystem.Instance.GetNextRemainTime(this.TimerHandle);
			if (nextRemainTime <= 0f)
			{
				this.PlayWarnAnim(false);
				return;
			}
			this.PlayWarnAnim(nextRemainTime < this.WarnTime);
		}

		// Token: 0x0603D066 RID: 249958 RVA: 0x00EACE9C File Offset: 0x00EAB09C
		private void OnAbsoluteTimeStop(bool open, float duration)
		{
			if (open)
			{
				this.TimerHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.TimerHandle = null;
				}, duration * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
				return;
			}
			if (TimerSystem.Instance.Has(this.TimerHandle))
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0401FCA1 RID: 130209
		private const float EFFECT_BASE_PERCENT = 0.4390244f;

		// Token: 0x0401FCA2 RID: 130210
		[StaticVariableRuleIgnore]
		private static readonly int UltraTag = GameplayTagDefine.EGameplayTagId["角色.R2T1AogusitaMd10011.战斗逻辑.大循环充能X"];

		// Token: 0x0401FCA3 RID: 130211
		[StaticVariableRuleIgnore]
		private static readonly int EnergyTag = GameplayTagDefine.EGameplayTagId["角色.R2T1AogusitaMd10011.战斗逻辑.锁开可解放"];

		// Token: 0x0401FCA4 RID: 130212
		[Nullable(1)]
		private const string CURVE_PATH = "/Game/Aki/UI/UIResources/UiFight/Curve/Ani_UiItem_BarAogusita/Curve_UiItem_BarAogusita_Y.Curve_UiItem_BarAogusita_Y";

		// Token: 0x0401FCA5 RID: 130213
		private const float X_MIN = -207f;

		// Token: 0x0401FCA6 RID: 130214
		private const float X_MAX = 221f;

		// Token: 0x0401FCA7 RID: 130215
		[Nullable(1)]
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401FCA8 RID: 130216
		private SpecialEnergyBarAoGuSiTaSlot BarItem;

		// Token: 0x0401FCA9 RID: 130217
		private SpecialEnergyBarInfo UltraConfig;

		// Token: 0x0401FCAA RID: 130218
		private UCurveFloat UltraCurve;

		// Token: 0x0401FCAB RID: 130219
		private bool IsUltra;

		// Token: 0x0401FCAC RID: 130220
		private bool IsUltraEnergyFull;

		// Token: 0x0401FCAD RID: 130221
		private bool IsEnergyFullB;

		// Token: 0x0401FCAE RID: 130222
		private int CountEnergyC;

		// Token: 0x0401FCAF RID: 130223
		private TimerHandle TimerHandle;

		// Token: 0x0401FCB0 RID: 130224
		private bool IsPlayWarnAnim;

		// Token: 0x0401FCB1 RID: 130225
		private float WarnTime;

		// Token: 0x0401FCB2 RID: 130226
		private BattleUiNiagaraItem UltraRiseEffect;

		// Token: 0x0401FCB3 RID: 130227
		private Entity Entity;

		// Token: 0x0200C0D6 RID: 49366
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A2F6 RID: 238326
			NormalItem,
			// Token: 0x0403A2F7 RID: 238327
			BottomLightLeftItem,
			// Token: 0x0403A2F8 RID: 238328
			BottomLightRightItem,
			// Token: 0x0403A2F9 RID: 238329
			CircleBarTexture,
			// Token: 0x0403A2FA RID: 238330
			SlotBarItem,
			// Token: 0x0403A2FB RID: 238331
			UltraBarTexture,
			// Token: 0x0403A2FC RID: 238332
			UltraLightItem,
			// Token: 0x0403A2FD RID: 238333
			UltraSliderItem,
			// Token: 0x0403A2FE RID: 238334
			UltraSlider,
			// Token: 0x0403A2FF RID: 238335
			CirclePointItem,
			// Token: 0x0403A300 RID: 238336
			UltraItem,
			// Token: 0x0403A301 RID: 238337
			UltraMaxItem,
			// Token: 0x0403A302 RID: 238338
			UltraGlowNiagara,
			// Token: 0x0403A303 RID: 238339
			KeyItem,
			// Token: 0x0403A304 RID: 238340
			AniIn,
			// Token: 0x0403A305 RID: 238341
			AniOut,
			// Token: 0x0403A306 RID: 238342
			AniWarning,
			// Token: 0x0403A307 RID: 238343
			UltraRiseNiagara
		}
	}
}
