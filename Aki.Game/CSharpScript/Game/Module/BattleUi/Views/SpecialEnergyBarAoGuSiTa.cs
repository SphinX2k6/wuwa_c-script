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
	// Token: 0x02004DAF RID: 19887
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarAoGuSiTa : SpecialEnergyBarBase
	{
		// Token: 0x06031FC3 RID: 204739 RVA: 0x00DFD30C File Offset: 0x00DFB50C
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

		// Token: 0x06031FC4 RID: 204740 RVA: 0x00DFD590 File Offset: 0x00DFB790
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

		// Token: 0x06031FC5 RID: 204741 RVA: 0x00DFD64C File Offset: 0x00DFB84C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarAoGuSiTa.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarAoGuSiTa.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031FC6 RID: 204742 RVA: 0x00DFD690 File Offset: 0x00DFB890
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarAoGuSiTa.<InitBarItem>d__23 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarAoGuSiTa.<InitBarItem>d__23>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031FC7 RID: 204743 RVA: 0x00DFD6D4 File Offset: 0x00DFB8D4
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

		// Token: 0x06031FC8 RID: 204744 RVA: 0x00DFD720 File Offset: 0x00DFB920
		private UniTask LoadCurve()
		{
			SpecialEnergyBarAoGuSiTa.<LoadCurve>d__25 <LoadCurve>d__;
			<LoadCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCurve>d__.<>4__this = this;
			<LoadCurve>d__.<>1__state = -1;
			<LoadCurve>d__.<>t__builder.Start<SpecialEnergyBarAoGuSiTa.<LoadCurve>d__25>(ref <LoadCurve>d__);
			return <LoadCurve>d__.<>t__builder.Task;
		}

		// Token: 0x06031FC9 RID: 204745 RVA: 0x00DFD764 File Offset: 0x00DFB964
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

		// Token: 0x06031FCA RID: 204746 RVA: 0x00DFD83C File Offset: 0x00DFBA3C
		protected override void OnBeforeDestroy()
		{
			if (this.UltraRiseEffect != null)
			{
				this.UltraRiseEffect.Stop();
				this.UltraRiseEffect = null;
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x06031FCB RID: 204747 RVA: 0x00DFD85E File Offset: 0x00DFBA5E
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(16);
			base.ClearAllTweenAnim();
		}

		// Token: 0x06031FCC RID: 204748 RVA: 0x00DFD870 File Offset: 0x00DFBA70
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

		// Token: 0x06031FCD RID: 204749 RVA: 0x00DFD924 File Offset: 0x00DFBB24
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

		// Token: 0x06031FCE RID: 204750 RVA: 0x00DFD9A7 File Offset: 0x00DFBBA7
		private void OnUltraTagChange(int tagId, bool tagExist)
		{
			this.RefreshUltraState(tagExist, false);
		}

		// Token: 0x06031FCF RID: 204751 RVA: 0x00DFD9B1 File Offset: 0x00DFBBB1
		private void OnEnergyTagChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.OnEnergyTagChangedC(count, false);
		}

		// Token: 0x06031FD0 RID: 204752 RVA: 0x00DFD9BB File Offset: 0x00DFBBBB
		private void AttributeChangedB(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnAttributeChangedB(false);
		}

		// Token: 0x06031FD1 RID: 204753 RVA: 0x00DFD9C4 File Offset: 0x00DFBBC4
		private void MaxAttributeChangedB(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.OnAttributeChangedB(false);
		}

		// Token: 0x06031FD2 RID: 204754 RVA: 0x00DFD9D0 File Offset: 0x00DFBBD0
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

		// Token: 0x06031FD3 RID: 204755 RVA: 0x00DFDAAC File Offset: 0x00DFBCAC
		protected void OnEnergyTagChangedC(int count, bool isStart = false)
		{
			this.RefreshCountEnergyC(Math.Min(count, 2), isStart);
		}

		// Token: 0x06031FD4 RID: 204756 RVA: 0x00DFDABC File Offset: 0x00DFBCBC
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

		// Token: 0x06031FD5 RID: 204757 RVA: 0x00DFDB12 File Offset: 0x00DFBD12
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

		// Token: 0x06031FD6 RID: 204758 RVA: 0x00DFDB3C File Offset: 0x00DFBD3C
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06031FD7 RID: 204759 RVA: 0x00DFDB48 File Offset: 0x00DFBD48
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

		// Token: 0x06031FD8 RID: 204760 RVA: 0x00DFDBE0 File Offset: 0x00DFBDE0
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

		// Token: 0x06031FD9 RID: 204761 RVA: 0x00DFDC40 File Offset: 0x00DFBE40
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

		// Token: 0x06031FDA RID: 204762 RVA: 0x00DFDC93 File Offset: 0x00DFBE93
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

		// Token: 0x06031FDB RID: 204763 RVA: 0x00DFDCD2 File Offset: 0x00DFBED2
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

		// Token: 0x06031FDC RID: 204764 RVA: 0x00DFDD10 File Offset: 0x00DFBF10
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

		// Token: 0x06031FDD RID: 204765 RVA: 0x00DFDD90 File Offset: 0x00DFBF90
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

		// Token: 0x0401A75E RID: 108382
		private const float EFFECT_BASE_PERCENT = 0.4390244f;

		// Token: 0x0401A75F RID: 108383
		[StaticVariableRuleIgnore]
		private static readonly int UltraTag = GameplayTagDefine.EGameplayTagId["角色.R2T1AogusitaMd10011.战斗逻辑.大循环充能X"];

		// Token: 0x0401A760 RID: 108384
		[StaticVariableRuleIgnore]
		private static readonly int EnergyTag = GameplayTagDefine.EGameplayTagId["角色.R2T1AogusitaMd10011.战斗逻辑.锁开可解放"];

		// Token: 0x0401A761 RID: 108385
		[Nullable(1)]
		private const string CURVE_PATH = "/Game/Aki/UI/UIResources/UiFight/Curve/Ani_UiItem_BarAogusita/Curve_UiItem_BarAogusita_Y.Curve_UiItem_BarAogusita_Y";

		// Token: 0x0401A762 RID: 108386
		private const float X_MIN = -207f;

		// Token: 0x0401A763 RID: 108387
		private const float X_MAX = 221f;

		// Token: 0x0401A764 RID: 108388
		[Nullable(1)]
		private readonly List<SpecialEnergyBarInfo> ConfigList = new List<SpecialEnergyBarInfo>();

		// Token: 0x0401A765 RID: 108389
		private SpecialEnergyBarAoGuSiTaSlot BarItem;

		// Token: 0x0401A766 RID: 108390
		private SpecialEnergyBarInfo UltraConfig;

		// Token: 0x0401A767 RID: 108391
		private UCurveFloat UltraCurve;

		// Token: 0x0401A768 RID: 108392
		private bool IsUltra;

		// Token: 0x0401A769 RID: 108393
		private bool IsUltraEnergyFull;

		// Token: 0x0401A76A RID: 108394
		private bool IsEnergyFullB;

		// Token: 0x0401A76B RID: 108395
		private int CountEnergyC;

		// Token: 0x0401A76C RID: 108396
		private TimerHandle TimerHandle;

		// Token: 0x0401A76D RID: 108397
		private bool IsPlayWarnAnim;

		// Token: 0x0401A76E RID: 108398
		private float WarnTime;

		// Token: 0x0401A76F RID: 108399
		private BattleUiNiagaraItem UltraRiseEffect;

		// Token: 0x0401A770 RID: 108400
		private Entity Entity;

		// Token: 0x0200AADF RID: 43743
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034CC8 RID: 216264
			NormalItem,
			// Token: 0x04034CC9 RID: 216265
			BottomLightLeftItem,
			// Token: 0x04034CCA RID: 216266
			BottomLightRightItem,
			// Token: 0x04034CCB RID: 216267
			CircleBarTexture,
			// Token: 0x04034CCC RID: 216268
			SlotBarItem,
			// Token: 0x04034CCD RID: 216269
			UltraBarTexture,
			// Token: 0x04034CCE RID: 216270
			UltraLightItem,
			// Token: 0x04034CCF RID: 216271
			UltraSliderItem,
			// Token: 0x04034CD0 RID: 216272
			UltraSlider,
			// Token: 0x04034CD1 RID: 216273
			CirclePointItem,
			// Token: 0x04034CD2 RID: 216274
			UltraItem,
			// Token: 0x04034CD3 RID: 216275
			UltraMaxItem,
			// Token: 0x04034CD4 RID: 216276
			UltraGlowNiagara,
			// Token: 0x04034CD5 RID: 216277
			KeyItem,
			// Token: 0x04034CD6 RID: 216278
			AniIn,
			// Token: 0x04034CD7 RID: 216279
			AniOut,
			// Token: 0x04034CD8 RID: 216280
			AniWarning,
			// Token: 0x04034CD9 RID: 216281
			UltraRiseNiagara
		}
	}
}
