using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D0A RID: 23818
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonBossStateMultiLayerView : CommonBossStateView
	{
		// Token: 0x0603C578 RID: 247160 RVA: 0x00E746A6 File Offset: 0x00E728A6
		protected override string GetResourceId()
		{
			return "UiItem_BossStateMultiLayer_Prefab";
		}

		// Token: 0x0603C579 RID: 247161 RVA: 0x00E746B0 File Offset: 0x00E728B0
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.AddRange(new <>z__ReadOnlyArray<ValueTuple<int, Type>>(new ValueTuple<int, Type>[]
			{
				new ValueTuple<int, Type>(40, typeof(UUISprite)),
				new ValueTuple<int, Type>(41, typeof(UUIItem)),
				new ValueTuple<int, Type>(42, typeof(UUIText)),
				new ValueTuple<int, Type>(43, typeof(UUIItem)),
				new ValueTuple<int, Type>(44, typeof(UUIItem))
			}));
		}

		// Token: 0x0603C57A RID: 247162 RVA: 0x00E74754 File Offset: 0x00E72954
		protected override void OnStart()
		{
			base.OnStart();
			this.BgBar = base.GetSprite(40);
			this.TextNum = base.GetText(42);
			this.SingleFadeDuration = ConfigCommonParamById.GetFloatConfig("BossHpBarMultiLayer_SingleFadeDuration").Value;
			this.MinDurationPerSegment = ConfigCommonParamById.GetFloatConfig("BossHpBarMultiLayer_MinDurationPerSegment").Value;
			this.MaxFadeDuration = ConfigCommonParamById.GetFloatConfig("BossHpBarMultiLayer_MaxFadeDuration").Value;
		}

		// Token: 0x0603C57B RID: 247163 RVA: 0x00E747CC File Offset: 0x00E729CC
		private IReadOnlyList<string> GetHpBarColorConfig()
		{
			Entity entity = base.GetEntity();
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			MonsterComponent monsterComponent = (creatureDataComponent != null) ? creatureDataComponent.GetMonsterComponent() : null;
			if (monsterComponent == null)
			{
				return ConfigCommonParamById.GetStringArrayConfig("BossHpBarMultiLayer_Colors");
			}
			if (monsterComponent.LifeMaxCustomizationId == null || monsterComponent.LifeMaxCustomizationId.Value == 0)
			{
				return ConfigCommonParamById.GetStringArrayConfig("BossHpBarMultiLayer_Colors");
			}
			LifeMaxCustomization? config = ConfigLifeMaxCustomizationById.GetConfig(monsterComponent.LifeMaxCustomizationId.Value, true);
			if (config == null || config.Value.CustomColorSetLength <= 0)
			{
				return ConfigCommonParamById.GetStringArrayConfig("BossHpBarMultiLayer_Colors");
			}
			string[] array = new string[config.Value.CustomColorSetLength];
			for (int i = 0; i < config.Value.CustomColorSetLength; i++)
			{
				array[i] = config.Value.CustomColorSet(i);
			}
			return array;
		}

		// Token: 0x0603C57C RID: 247164 RVA: 0x00E748BC File Offset: 0x00E72ABC
		private void InitBarColor()
		{
			IReadOnlyList<string> hpBarColorConfig = this.GetHpBarColorConfig();
			string stringConfig = ConfigCommonParamById.GetStringConfig("BossHpBarMultiLayer_WhiteBar");
			this.NumColor = hpBarColorConfig.Count;
			this.IsColorMode = (hpBarColorConfig.Count > 0 && !hpBarColorConfig[0].StartsWith("/Game/"));
			FColor fcolor = FColor.FromHex("ffffffff");
			for (int i = 0; i < hpBarColorConfig.Count; i++)
			{
				if (this.IsColorMode)
				{
					this.BarColors.Add(FColor.FromHex(hpBarColorConfig[i]));
				}
				else
				{
					this.BgBar.SetColor(fcolor);
					base.SetHpBarColor(fcolor);
					int localI = i;
					this.BarSprites.Add(null);
					this.LoadHandles.Add(-1);
					this.LoadHandles[localI] = ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(hpBarColorConfig[localI], delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
					{
						this.LoadHandles[localI] = -1;
						if (sprite == null || !sprite.IsValid())
						{
							return;
						}
						if (this.IsInvalid)
						{
							return;
						}
						this.BarSprites[localI] = sprite;
						if (this.LoadHandles.Count == 0 && this.CurrentSegmentNum != 0)
						{
							this.BarSprites.Reverse();
							this.ResetCurrentSegment();
						}
					}, 100, "js_undefined");
				}
			}
			if (this.IsColorMode)
			{
				this.BarColors.Reverse();
				this.LoadWhiteBarHd = ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(stringConfig, delegate([Nullable(2)] ULGUISpriteData_BaseObject sprite, string _)
				{
					this.LoadWhiteBarHd = 0;
					if (sprite == null || !sprite.IsValid())
					{
						return;
					}
					if (this.IsInvalid)
					{
						return;
					}
					this.BgBar.SetSprite(sprite, true);
					this.BgBar.SetHorizontalStretch(new FVector2D(0f, 0f));
					base.SetHpBarSprite(sprite);
					this.ResetCurrentSegment();
				}, 100, "js_undefined");
			}
		}

		// Token: 0x0603C57D RID: 247165 RVA: 0x00E74A06 File Offset: 0x00E72C06
		protected override void OnActivate()
		{
			base.OnActivate();
			this.InitBarColor();
			this.InitState();
		}

		// Token: 0x0603C57E RID: 247166 RVA: 0x00E74A1A File Offset: 0x00E72C1A
		protected override void OnDeactivate()
		{
			this.IsDeactivate = true;
			HeadStateWeaknessItem weaknessItem = this.WeaknessItem;
			if (weaknessItem != null)
			{
				weaknessItem.DisableRecycleItem();
			}
			base.OnDeactivate();
		}

		// Token: 0x0603C57F RID: 247167 RVA: 0x00E74A3A File Offset: 0x00E72C3A
		protected override void OnAfterHide()
		{
			if (this.IsDeactivate)
			{
				base.Destroy(null);
			}
		}

		// Token: 0x0603C580 RID: 247168 RVA: 0x00E74A4C File Offset: 0x00E72C4C
		protected override void OnBeforeDestroy()
		{
			this.IsInvalid = true;
			foreach (int num in this.LoadHandles)
			{
				if (num != -1)
				{
					ResourceSystem.Instance.CancelAsyncLoad(num);
				}
			}
			this.LoadHandles.Clear();
			if (this.LoadWhiteBarHd > 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadWhiteBarHd);
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x0603C581 RID: 247169 RVA: 0x00E74AD8 File Offset: 0x00E72CD8
		protected override bool DestroyOverride()
		{
			return false;
		}

		// Token: 0x0603C582 RID: 247170 RVA: 0x00E74ADB File Offset: 0x00E72CDB
		protected override void InitAllTweenAnim()
		{
			base.InitAllTweenAnim();
			base.InitTweenAnim(43);
			base.InitTweenAnim(44);
		}

		// Token: 0x0603C583 RID: 247171 RVA: 0x00E74AF4 File Offset: 0x00E72CF4
		private unsafe void InitState()
		{
			Entity entity = base.GetEntity();
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			MonsterComponent monsterComponent = (creatureDataComponent != null) ? creatureDataComponent.GetMonsterComponent() : null;
			if (monsterComponent == null)
			{
				return;
			}
			if (monsterComponent.LifeMaxCustomizationId == null || monsterComponent.LifeMaxCustomizationId.Value == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.HWR;
				string message = "Boss多管血条:缺少配表id";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("pbDataId", (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("serverId", (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			LifeMaxCustomization? config = ConfigLifeMaxCustomizationById.GetConfig(monsterComponent.LifeMaxCustomizationId.Value, true);
			if (config == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.HYJ;
				string message2 = "Boss多管血条:id没有对应配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("pbDataId", (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("serverId", (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("LifeMaxCustomizationId", monsterComponent.LifeMaxCustomizationId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			if (config.Value.LifeCustomType == 0)
			{
				this.HpPerSegment = (double)config.Value.SingleTubeLife;
				this.HpLimit = (double)(config.Value.SingleTubeLife * config.Value.LifeCount);
			}
			else
			{
				if (config.Value.LifeCustomType != 1)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Battle;
					ELogAuthor author3 = ELogAuthor.HWR;
					string message3 = "Boss多管血条:非法的血量定制类型";
					<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("pbDataId", (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("serverId", (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("LifeMaxCustomizationId", monsterComponent.LifeMaxCustomizationId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("LifeCustomType", config.Value.LifeCustomType);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
					return;
				}
				int num = WorldLevelModel.Instance.CurWorldLevel - 1;
				if (config.Value.LifeCountAttrLength <= num || config.Value.SingleTubeLifeArrLength <= num)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.Battle;
					ELogAuthor author4 = ELogAuthor.HYJ;
					string message4 = "Boss多管血条:血量定制类型 1, 血量信息数组长度不合法";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("pbDataId", (creatureDataComponent != null) ? new int?(creatureDataComponent.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("serverId", (creatureDataComponent != null) ? new long?(creatureDataComponent.GetCreatureDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("LifeMaxCustomizationId", monsterComponent.LifeMaxCustomizationId);
					instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
					return;
				}
				this.HpPerSegment = (double)config.Value.SingleTubeLifeArr(num);
				this.HpLimit = (double)(config.Value.SingleTubeLifeArr(num) * config.Value.LifeCountAttr(num));
			}
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.Battle;
			ELogAuthor author5 = ELogAuthor.HWR;
			string message5 = "Boss多管血条";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("LifeMaxCustomizationId", monsterComponent.LifeMaxCustomizationId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("每管hp", this.HpPerSegment);
			instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
			double hpAttributeValue = this.GetHpAttributeValue(EAttributeType.Life);
			double hpAttributeValue2 = this.GetHpAttributeValue(EAttributeType.LifeMax);
			if (hpAttributeValue2 < this.HpPerSegment)
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.Battle;
				ELogAuthor author6 = ELogAuthor.HWR;
				string message6 = "Boss多管血条:分段值大于了最大血值:";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray6 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 0) = new ValueTuple<string, object>("", this.HpPerSegment);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray6, 1) = new ValueTuple<string, object>("", hpAttributeValue2);
				instance6.Warn(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray6, 2));
				this.HpPerSegment = hpAttributeValue2;
			}
			this.CurrentSegmentNum = (int)Math.Ceiling(hpAttributeValue / this.HpPerSegment);
			this.TargetSegmentNum = this.CurrentSegmentNum;
			this.ResetCurrentSegment();
			base.RefreshHpAndShield(false);
		}

		// Token: 0x0603C584 RID: 247172 RVA: 0x00E75046 File Offset: 0x00E73246
		protected override void OnBossHeathChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.CheckSegment((int)Math.Ceiling((double)newValue / this.HpPerSegment));
			base.RefreshHpAndShield(true);
		}

		// Token: 0x0603C585 RID: 247173 RVA: 0x00E75064 File Offset: 0x00E73264
		private double GetHpAttributeValue(EAttributeType attributeId)
		{
			float currentAttributeValueById = base.GetCurrentAttributeValueById(attributeId);
			if (this.HpLimit > 0.0 && (double)currentAttributeValueById > this.HpLimit)
			{
				return this.HpLimit;
			}
			return (double)currentAttributeValueById;
		}

		// Token: 0x0603C586 RID: 247174 RVA: 0x00E7509D File Offset: 0x00E7329D
		private float GetHpPercent()
		{
			return (float)(this.GetHpAttributeValue(EAttributeType.Life) % (this.HpPerSegment + 0.0010000000474974513) / this.HpPerSegment);
		}

		// Token: 0x0603C587 RID: 247175 RVA: 0x00E750C0 File Offset: 0x00E732C0
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"hpPercent",
			"shieldPercent"
		})]
		protected override ValueTuple<float, float> GetHpAndShieldPercent()
		{
			if (!this.IsValid())
			{
				return new ValueTuple<float, float>(0f, 0f);
			}
			float hpPercent = this.GetHpPercent();
			float item = 1f;
			float bossShield = base.GetBossShield();
			double hpAttributeValue = this.GetHpAttributeValue(EAttributeType.LifeMax);
			if ((double)bossShield <= hpAttributeValue)
			{
				item = (float)((double)bossShield / hpAttributeValue);
			}
			return new ValueTuple<float, float>(hpPercent, item);
		}

		// Token: 0x0603C588 RID: 247176 RVA: 0x00E75114 File Offset: 0x00E73314
		protected override void PlayBarAnimation(float hpPercent)
		{
			if (this.SegmentState == CommonBossStateMultiLayerView.ESegmentState.Multi)
			{
				int num = (this.TargetSegmentNum < this.CurrentSegmentNum) ? -1 : 1;
				base.PlayBarAnimation(num != -1);
				return;
			}
			base.PlayBarAnimation(hpPercent);
		}

		// Token: 0x0603C589 RID: 247177 RVA: 0x00E75154 File Offset: 0x00E73354
		protected override void SetBarBufferPercent(float pctBuffer, float pctReal)
		{
			if (this.SegmentState == CommonBossStateMultiLayerView.ESegmentState.Multi)
			{
				float num = ((this.TargetSegmentNum < this.CurrentSegmentNum) ? -1 : 1) != -1;
				base.SetBarBufferPercent(Math.Max(pctBuffer, num), num);
				return;
			}
			base.SetBarBufferPercent(pctBuffer, pctReal);
		}

		// Token: 0x0603C58A RID: 247178 RVA: 0x00E7519B File Offset: 0x00E7339B
		protected override void SetHpBarPercent(float percent)
		{
			if (this.SegmentState == CommonBossStateMultiLayerView.ESegmentState.Multi)
			{
				return;
			}
			if (percent > this.CurrentBarPercent || this.TargetSegmentNum < this.CurrentSegmentNum)
			{
				this.NextSegment();
			}
			base.SetHpBarPercent(percent);
		}

		// Token: 0x0603C58B RID: 247179 RVA: 0x00E751CC File Offset: 0x00E733CC
		private void CheckSegment(int newTarget)
		{
			if (newTarget == this.TargetSegmentNum)
			{
				return;
			}
			this.TargetSegmentNum = newTarget;
			int num = Math.Abs(this.CurrentSegmentNum - this.TargetSegmentNum);
			if (this.SegmentState == CommonBossStateMultiLayerView.ESegmentState.Multi)
			{
				float num2 = Math.Max(this.MultiRemainingTime, 0f);
				int num3 = Math.Max((int)Math.Floor((double)((float)num / (num2 / this.MinDurationPerSegment))), 1);
				if (this.SegmentDelta < num3)
				{
					this.SegmentDelta = num3;
				}
			}
			else if (num > 1)
			{
				this.SegmentState = CommonBossStateMultiLayerView.ESegmentState.Multi;
				this.MultiRemainingTime = this.MaxFadeDuration;
				float num4;
				if ((float)num * this.SingleFadeDuration > this.MaxFadeDuration)
				{
					this.SegmentDelta = Math.Max((int)Math.Floor((double)((float)num / (this.MaxFadeDuration / this.MinDurationPerSegment))), 1);
					num4 = this.MinDurationPerSegment;
				}
				else
				{
					num4 = this.SingleFadeDuration;
					this.SegmentDelta = 1;
				}
				int num5 = (this.TargetSegmentNum < this.CurrentSegmentNum) ? -1 : 1;
				float currentBarPercent = this.CurrentBarPercent;
				this.PercentSegment.SetTargetPercent(num5 != -1);
				this.PercentSegment.SetCurrentPercent(currentBarPercent);
				this.PercentSegment.SetDuration(num4 * ((num5 == -1) ? currentBarPercent : (1f - currentBarPercent)));
				this.PercentSegment.UpdateSpeed(true);
			}
			CommonBossStateMultiLayerView.ESegmentState segmentState = this.SegmentState;
		}

		// Token: 0x0603C58C RID: 247180 RVA: 0x00E75323 File Offset: 0x00E73523
		private void ResetCurrentSegment()
		{
			this.UpdateBarColor(this.CurrentSegmentNum);
		}

		// Token: 0x0603C58D RID: 247181 RVA: 0x00E75334 File Offset: 0x00E73534
		private void UpdateBarColor(int num)
		{
			int num2 = (this.TargetSegmentNum < this.CurrentSegmentNum) ? -1 : 1;
			if (!this.ColorInit)
			{
				this.ColorInit = true;
				this.ColorIndex = this.NumColor - 2;
			}
			else if (this.LastDir == num2 && this.CurrentSegmentNum != num)
			{
				this.ColorIndex += num2;
				if (this.ColorIndex < 0)
				{
					this.ColorIndex = this.NumColor - 1;
				}
			}
			this.LastDir = num2;
			int num3 = this.ColorIndex % this.NumColor;
			int num4 = (num3 + num2 < 0) ? (this.NumColor - 1) : ((num3 + num2) % this.NumColor);
			if (this.IsColorMode)
			{
				this.BgBar.SetColor(this.BarColors[(num2 == -1) ? num4 : num3]);
				base.SetHpBarColor(this.BarColors[(num2 == -1) ? num3 : num4]);
			}
			else
			{
				ULGUISpriteData_BaseObject ulguispriteData_BaseObject = this.BarSprites[num4];
				if (ulguispriteData_BaseObject != null && ulguispriteData_BaseObject.IsValid())
				{
					this.BgBar.SetSprite(this.BarSprites[num4], true);
					this.BgBar.SetHorizontalStretch(new FVector2D(0f, 0f));
				}
				base.SetHpBarSprite(this.BarSprites[num3]);
			}
			this.BgBar.SetUIActive(num > 1);
			this.BgBar.SetFillAmount(1f);
			if (this.SegmentState == CommonBossStateMultiLayerView.ESegmentState.Multi)
			{
				base.SetHpBarPercent(num2 == -1);
			}
			else
			{
				base.SetHpBarPercent(this.CurrentBarPercent);
			}
			LguiUtil.Instance.SetLocalTextNew(this.TextNum, "BossPilingActivity_BossHpVesselNum", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x0603C58E RID: 247182 RVA: 0x00E754DC File Offset: 0x00E736DC
		private void UpdateNumFx(int num, int dir)
		{
			if (this.NextNumFx != num && Time.Instance.Now - this.NextNumTime > 300.0)
			{
				this.NextNumFx = num;
				this.NextNumTime = Time.Instance.Now;
				base.PlayTweenAnim((dir == -1) ? 43 : 44);
			}
		}

		// Token: 0x0603C58F RID: 247183 RVA: 0x00E75538 File Offset: 0x00E73738
		private void NextSegment()
		{
			int num = 1;
			if (this.SegmentState == CommonBossStateMultiLayerView.ESegmentState.Multi)
			{
				num = this.SegmentDelta;
			}
			int num2 = (this.TargetSegmentNum < this.CurrentSegmentNum) ? -1 : 1;
			int num3 = this.CurrentSegmentNum + num * num2;
			if (num2 == -1)
			{
				if (num3 < this.TargetSegmentNum)
				{
					num3 = this.TargetSegmentNum;
				}
			}
			else if (num3 > this.TargetSegmentNum)
			{
				num3 = this.TargetSegmentNum;
			}
			if (num3 != this.CurrentSegmentNum)
			{
				this.UpdateBarColor(num3);
				this.UpdateNumFx(num3, num2);
				this.CurrentSegmentNum = num3;
			}
		}

		// Token: 0x0603C590 RID: 247184 RVA: 0x00E755BC File Offset: 0x00E737BC
		private void TickSegmentBar(float delta)
		{
			if (this.PercentSegment.Update(delta))
			{
				this.MultiRemainingTime -= delta;
				float curPercent = this.PercentSegment.GetCurPercent();
				base.SetHpBarPercent(curPercent);
				int num = (this.TargetSegmentNum < this.CurrentSegmentNum) ? -1 : 1;
				if ((num == -1 && curPercent <= 0f) || (num == 1 && curPercent >= 1f))
				{
					this.NextSegment();
					if (this.CurrentSegmentNum != this.TargetSegmentNum)
					{
						this.PercentSegment.SetTargetPercent(num != -1);
						this.PercentSegment.SetCurrentPercent(num == -1);
						this.PercentSegment.SetDuration(this.MinDurationPerSegment);
						this.PercentSegment.UpdateSpeed(true);
						return;
					}
					float hpPercent = this.GetHpPercent();
					this.PercentSegment.SetTargetPercent(hpPercent);
					this.PercentSegment.SetCurrentPercent(num == -1);
					this.PercentSegment.SetDuration(this.MinDurationPerSegment * ((num == -1) ? (1f - hpPercent) : hpPercent));
					this.PercentSegment.UpdateSpeed(true);
					return;
				}
			}
			else if (this.SegmentState == CommonBossStateMultiLayerView.ESegmentState.Multi)
			{
				this.SegmentState = CommonBossStateMultiLayerView.ESegmentState.Single;
				base.RefreshHpAndShield(false);
			}
		}

		// Token: 0x0603C591 RID: 247185 RVA: 0x00E756E8 File Offset: 0x00E738E8
		public override void Tick(float delta)
		{
			base.Tick(delta);
			this.TickSegmentBar(delta);
		}

		// Token: 0x0401F6EE RID: 128750
		private CommonBossStateMultiLayerView.ESegmentState SegmentState;

		// Token: 0x0401F6EF RID: 128751
		private double HpPerSegment = 1.0;

		// Token: 0x0401F6F0 RID: 128752
		private float MaxFadeDuration = 500f;

		// Token: 0x0401F6F1 RID: 128753
		private float MinDurationPerSegment = 100f;

		// Token: 0x0401F6F2 RID: 128754
		private float SingleFadeDuration = 100f;

		// Token: 0x0401F6F3 RID: 128755
		private double HpLimit;

		// Token: 0x0401F6F4 RID: 128756
		private bool IsColorMode = true;

		// Token: 0x0401F6F5 RID: 128757
		private int NumColor;

		// Token: 0x0401F6F6 RID: 128758
		private readonly List<FColor> BarColors = new List<FColor>();

		// Token: 0x0401F6F7 RID: 128759
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<ULGUISpriteData_BaseObject> BarSprites = new List<ULGUISpriteData_BaseObject>();

		// Token: 0x0401F6F8 RID: 128760
		private readonly List<int> LoadHandles = new List<int>();

		// Token: 0x0401F6F9 RID: 128761
		private int LoadWhiteBarHd;

		// Token: 0x0401F6FA RID: 128762
		private int CurrentSegmentNum;

		// Token: 0x0401F6FB RID: 128763
		private int TargetSegmentNum;

		// Token: 0x0401F6FC RID: 128764
		private readonly ProgressPercentMachine PercentSegment = new ProgressPercentMachine();

		// Token: 0x0401F6FD RID: 128765
		private int SegmentDelta = 1;

		// Token: 0x0401F6FE RID: 128766
		private int ColorIndex = -1;

		// Token: 0x0401F6FF RID: 128767
		private bool ColorInit;

		// Token: 0x0401F700 RID: 128768
		[Nullable(2)]
		private UUISprite BgBar;

		// Token: 0x0401F701 RID: 128769
		[Nullable(2)]
		private UUIText TextNum;

		// Token: 0x0401F702 RID: 128770
		private bool IsDeactivate;

		// Token: 0x0401F703 RID: 128771
		private bool IsInvalid;

		// Token: 0x0401F704 RID: 128772
		private float MultiRemainingTime;

		// Token: 0x0401F705 RID: 128773
		private int LastDir;

		// Token: 0x0401F706 RID: 128774
		private int NextNumFx;

		// Token: 0x0401F707 RID: 128775
		private double NextNumTime;

		// Token: 0x0200BF81 RID: 49025
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039BFB RID: 236539
			BarHp = 40,
			// Token: 0x04039BFC RID: 236540
			PnlMultiNum,
			// Token: 0x04039BFD RID: 236541
			TextNum,
			// Token: 0x04039BFE RID: 236542
			AniNumDown,
			// Token: 0x04039BFF RID: 236543
			AniNumUp
		}

		// Token: 0x0200BF82 RID: 49026
		[NullableContext(0)]
		private enum ESegmentState
		{
			// Token: 0x04039C01 RID: 236545
			Single,
			// Token: 0x04039C02 RID: 236546
			Multi
		}
	}
}
