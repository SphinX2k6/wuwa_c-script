using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CEC RID: 19692
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonBossStateMultiLayerView : CommonBossStateView
	{
		// Token: 0x060314D1 RID: 201937 RVA: 0x00DC4D0E File Offset: 0x00DC2F0E
		protected override string GetResourceId()
		{
			return "UiItem_BossStateMultiLayer_Prefab";
		}

		// Token: 0x060314D2 RID: 201938 RVA: 0x00DC4D18 File Offset: 0x00DC2F18
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

		// Token: 0x060314D3 RID: 201939 RVA: 0x00DC4DBC File Offset: 0x00DC2FBC
		protected override void OnStart()
		{
			base.OnStart();
			this.BgBar = base.GetSprite(40);
			this.TextNum = base.GetText(42);
			this.SingleFadeDuration = ConfigCommonParamById.GetFloatConfig("BossHpBarMultiLayer_SingleFadeDuration").Value;
			this.MinDurationPerSegment = ConfigCommonParamById.GetFloatConfig("BossHpBarMultiLayer_MinDurationPerSegment").Value;
			this.MaxFadeDuration = ConfigCommonParamById.GetFloatConfig("BossHpBarMultiLayer_MaxFadeDuration").Value;
		}

		// Token: 0x060314D4 RID: 201940 RVA: 0x00DC4E34 File Offset: 0x00DC3034
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

		// Token: 0x060314D5 RID: 201941 RVA: 0x00DC4F24 File Offset: 0x00DC3124
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

		// Token: 0x060314D6 RID: 201942 RVA: 0x00DC506E File Offset: 0x00DC326E
		protected override void OnActivate()
		{
			base.OnActivate();
			this.InitBarColor();
			this.InitState();
		}

		// Token: 0x060314D7 RID: 201943 RVA: 0x00DC5082 File Offset: 0x00DC3282
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

		// Token: 0x060314D8 RID: 201944 RVA: 0x00DC50A2 File Offset: 0x00DC32A2
		protected override void OnAfterHide()
		{
			if (this.IsDeactivate)
			{
				base.Destroy(null);
			}
		}

		// Token: 0x060314D9 RID: 201945 RVA: 0x00DC50B4 File Offset: 0x00DC32B4
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

		// Token: 0x060314DA RID: 201946 RVA: 0x00DC5140 File Offset: 0x00DC3340
		protected override bool DestroyOverride()
		{
			return false;
		}

		// Token: 0x060314DB RID: 201947 RVA: 0x00DC5143 File Offset: 0x00DC3343
		protected override void InitAllTweenAnim()
		{
			base.InitAllTweenAnim();
			base.InitTweenAnim(43);
			base.InitTweenAnim(44);
		}

		// Token: 0x060314DC RID: 201948 RVA: 0x00DC515C File Offset: 0x00DC335C
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

		// Token: 0x060314DD RID: 201949 RVA: 0x00DC56AE File Offset: 0x00DC38AE
		protected override void OnBossHeathChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.CheckSegment((int)Math.Ceiling((double)newValue / this.HpPerSegment));
			base.RefreshHpAndShield(true);
		}

		// Token: 0x060314DE RID: 201950 RVA: 0x00DC56CC File Offset: 0x00DC38CC
		private double GetHpAttributeValue(EAttributeType attributeId)
		{
			float currentAttributeValueById = base.GetCurrentAttributeValueById(attributeId);
			if (this.HpLimit > 0.0 && (double)currentAttributeValueById > this.HpLimit)
			{
				return this.HpLimit;
			}
			return (double)currentAttributeValueById;
		}

		// Token: 0x060314DF RID: 201951 RVA: 0x00DC5705 File Offset: 0x00DC3905
		private float GetHpPercent()
		{
			return (float)(this.GetHpAttributeValue(EAttributeType.Life) % (this.HpPerSegment + 0.0010000000474974513) / this.HpPerSegment);
		}

		// Token: 0x060314E0 RID: 201952 RVA: 0x00DC5728 File Offset: 0x00DC3928
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

		// Token: 0x060314E1 RID: 201953 RVA: 0x00DC577C File Offset: 0x00DC397C
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

		// Token: 0x060314E2 RID: 201954 RVA: 0x00DC57BC File Offset: 0x00DC39BC
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

		// Token: 0x060314E3 RID: 201955 RVA: 0x00DC5803 File Offset: 0x00DC3A03
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

		// Token: 0x060314E4 RID: 201956 RVA: 0x00DC5834 File Offset: 0x00DC3A34
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

		// Token: 0x060314E5 RID: 201957 RVA: 0x00DC598B File Offset: 0x00DC3B8B
		private void ResetCurrentSegment()
		{
			this.UpdateBarColor(this.CurrentSegmentNum);
		}

		// Token: 0x060314E6 RID: 201958 RVA: 0x00DC599C File Offset: 0x00DC3B9C
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

		// Token: 0x060314E7 RID: 201959 RVA: 0x00DC5B44 File Offset: 0x00DC3D44
		private void UpdateNumFx(int num, int dir)
		{
			if (this.NextNumFx != num && Time.Instance.Now - this.NextNumTime > 300.0)
			{
				this.NextNumFx = num;
				this.NextNumTime = Time.Instance.Now;
				base.PlayTweenAnim((dir == -1) ? 43 : 44);
			}
		}

		// Token: 0x060314E8 RID: 201960 RVA: 0x00DC5BA0 File Offset: 0x00DC3DA0
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

		// Token: 0x060314E9 RID: 201961 RVA: 0x00DC5C24 File Offset: 0x00DC3E24
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

		// Token: 0x060314EA RID: 201962 RVA: 0x00DC5D50 File Offset: 0x00DC3F50
		public override void Tick(float delta)
		{
			base.Tick(delta);
			this.TickSegmentBar(delta);
		}

		// Token: 0x0401A1A7 RID: 106919
		private CommonBossStateMultiLayerView.ESegmentState SegmentState;

		// Token: 0x0401A1A8 RID: 106920
		private double HpPerSegment = 1.0;

		// Token: 0x0401A1A9 RID: 106921
		private float MaxFadeDuration = 500f;

		// Token: 0x0401A1AA RID: 106922
		private float MinDurationPerSegment = 100f;

		// Token: 0x0401A1AB RID: 106923
		private float SingleFadeDuration = 100f;

		// Token: 0x0401A1AC RID: 106924
		private double HpLimit;

		// Token: 0x0401A1AD RID: 106925
		private bool IsColorMode = true;

		// Token: 0x0401A1AE RID: 106926
		private int NumColor;

		// Token: 0x0401A1AF RID: 106927
		private readonly List<FColor> BarColors = new List<FColor>();

		// Token: 0x0401A1B0 RID: 106928
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<ULGUISpriteData_BaseObject> BarSprites = new List<ULGUISpriteData_BaseObject>();

		// Token: 0x0401A1B1 RID: 106929
		private readonly List<int> LoadHandles = new List<int>();

		// Token: 0x0401A1B2 RID: 106930
		private int LoadWhiteBarHd;

		// Token: 0x0401A1B3 RID: 106931
		private int CurrentSegmentNum;

		// Token: 0x0401A1B4 RID: 106932
		private int TargetSegmentNum;

		// Token: 0x0401A1B5 RID: 106933
		private readonly ProgressPercentMachine PercentSegment = new ProgressPercentMachine();

		// Token: 0x0401A1B6 RID: 106934
		private int SegmentDelta = 1;

		// Token: 0x0401A1B7 RID: 106935
		private int ColorIndex = -1;

		// Token: 0x0401A1B8 RID: 106936
		private bool ColorInit;

		// Token: 0x0401A1B9 RID: 106937
		[Nullable(2)]
		private UUISprite BgBar;

		// Token: 0x0401A1BA RID: 106938
		[Nullable(2)]
		private UUIText TextNum;

		// Token: 0x0401A1BB RID: 106939
		private bool IsDeactivate;

		// Token: 0x0401A1BC RID: 106940
		private bool IsInvalid;

		// Token: 0x0401A1BD RID: 106941
		private float MultiRemainingTime;

		// Token: 0x0401A1BE RID: 106942
		private int LastDir;

		// Token: 0x0401A1BF RID: 106943
		private int NextNumFx;

		// Token: 0x0401A1C0 RID: 106944
		private double NextNumTime;

		// Token: 0x0200A987 RID: 43399
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040345BD RID: 214461
			BarHp = 40,
			// Token: 0x040345BE RID: 214462
			PnlMultiNum,
			// Token: 0x040345BF RID: 214463
			TextNum,
			// Token: 0x040345C0 RID: 214464
			AniNumDown,
			// Token: 0x040345C1 RID: 214465
			AniNumUp
		}

		// Token: 0x0200A988 RID: 43400
		[NullableContext(0)]
		private enum ESegmentState
		{
			// Token: 0x040345C3 RID: 214467
			Single,
			// Token: 0x040345C4 RID: 214468
			Multi
		}
	}
}
