using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02005270 RID: 21104
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsMonsterItem : GridProxyAbstract<long>
	{
		// Token: 0x06035F67 RID: 221031 RVA: 0x00CC43AC File Offset: 0x00CC25AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUINiagara)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(11, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
			};
		}

		// Token: 0x06035F68 RID: 221032 RVA: 0x00CC44F4 File Offset: 0x00CC26F4
		protected override void OnStart()
		{
			this.RefreshBarActive();
			this.DelegateX = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenCallX));
			this.DelegateZ = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.TweenerCallZ));
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIText text = base.GetText(10);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(8);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06035F69 RID: 221033 RVA: 0x00CC4584 File Offset: 0x00CC2784
		protected override void OnBeforeDestroy()
		{
			this.RemoveAttributeListener();
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenCallX));
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.TweenerCallZ));
		}

		// Token: 0x06035F6A RID: 221034 RVA: 0x00CC45D7 File Offset: 0x00CC27D7
		private void OnClick()
		{
			Action<long> onClickCb = this.OnClickCb;
			if (onClickCb == null)
			{
				return;
			}
			onClickCb(this.EntityId);
		}

		// Token: 0x06035F6B RID: 221035 RVA: 0x00CC45EF File Offset: 0x00CC27EF
		private void AttributeRefreshLifeBar(EAttributeType type, float cur, float max)
		{
			this.RefreshLifeBar();
		}

		// Token: 0x06035F6C RID: 221036 RVA: 0x00CC45F8 File Offset: 0x00CC27F8
		private void RefreshLifeBar()
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			int num = (int)((attributeComp != null) ? attributeComp.GetCurrentValue(EAttributeType.Life) : 0f);
			BaseAttributeComponent attributeComp2 = this.AttributeComp;
			int num2 = (int)((attributeComp2 != null) ? attributeComp2.GetCurrentValue(EAttributeType.LifeMax) : ((float)this.MaxLife));
			if (num2 != 0)
			{
				this.MaxLife = num2;
			}
			float num3 = (float)num / (float)num2;
			if (this.OldLife <= num)
			{
				base.GetSprite(11).SetFillAmount(num3);
				this.HpMachine.Reset();
			}
			else
			{
				this.HpMachine.GetHit(num3, (float)this.OldLife / (float)num2);
			}
			this.OldLife = num;
			base.GetSprite(4).SetFillAmount(num3);
			base.GetSprite(3).SetFillAmount(num3);
			if (this.OldLife == 0)
			{
				UUIItem item = base.GetItem(9);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlayLevelSequenceByName(EPhantomBattleHeadAnim.Kill.ToString(), false, null, false);
			}
		}

		// Token: 0x06035F6D RID: 221037 RVA: 0x00CC46EB File Offset: 0x00CC28EB
		private void RefreshCostNum(int settlePoint)
		{
			this.DamageCount = settlePoint;
			base.GetText(2).SetText(settlePoint.ToString(), true);
		}

		// Token: 0x06035F6E RID: 221038 RVA: 0x00CC4708 File Offset: 0x00CC2908
		private void RefreshIcon(long entityId)
		{
			PhantomCardData cardDataByEntityId = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(entityId);
			base.SetTextureByPath(PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardDataByEntityId.ConfigId).BvbIcon, base.GetTexture(1), null, null);
		}

		// Token: 0x06035F6F RID: 221039 RVA: 0x00CC4755 File Offset: 0x00CC2955
		private void RefreshBarActive()
		{
			base.GetSprite(3).SetUIActive(this.IsOwn);
			base.GetSprite(4).SetUIActive(!this.IsOwn);
		}

		// Token: 0x06035F70 RID: 221040 RVA: 0x00CC4780 File Offset: 0x00CC2980
		private void RefreshFactor(int cardId, List<int> extraFactors)
		{
			EPhantomBattleHeadAnim ephantomBattleHeadAnim = this.IsOwn ? EPhantomBattleHeadAnim.FactorMeShow : EPhantomBattleHeadAnim.FactorOtherShow;
			if (this.HasTickInit)
			{
				this.CurPlayingIndex = -1;
				this.BeforeBattleFactor.Clear();
				this.HadPlayFactor.Clear();
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer != null && sequencePlayer.IsPlayingSequence(ephantomBattleHeadAnim.ToString()))
				{
					LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
					if (sequencePlayer2 == null)
					{
						return;
					}
					sequencePlayer2.StopPlayingSequence(false, true);
				}
				return;
			}
			this.BeforeBattleFactor.Clear();
			foreach (int num in extraFactors)
			{
				if (PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(num).IsBeforeBattle)
				{
					this.BeforeBattleFactor.Add(num);
				}
			}
			this.BeforeBattleFactor.Sort(delegate(int a, int b)
			{
				PhantomBattleFactor phantomBattleFactorConfig = PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(a);
				return PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(b).Sort - phantomBattleFactorConfig.Sort;
			});
			if (this.BeforeBattleFactor.Count > 0)
			{
				this.CurPlayingIndex = 0;
			}
			this.HasTickInit = true;
		}

		// Token: 0x06035F71 RID: 221041 RVA: 0x00CC48A8 File Offset: 0x00CC2AA8
		private void RefreshFactorShow(int factorId)
		{
			PhantomBattleFactor phantomBattleFactorConfig = PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(factorId);
			bool isBeforeBattle = phantomBattleFactorConfig.IsBeforeBattle;
			string name = phantomBattleFactorConfig.Name;
			UUIText text = base.GetText(7);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(!isBeforeBattle);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(isBeforeBattle);
			}
			if (text != null)
			{
				text.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(text, name, Array.Empty<object>());
		}

		// Token: 0x06035F72 RID: 221042 RVA: 0x00CC4920 File Offset: 0x00CC2B20
		public void Tick(float deltaTime)
		{
			if (!this.HasTickInit)
			{
				return;
			}
			float num = this.HpMachine.UpdatePercent(deltaTime);
			if (num >= 0f)
			{
				UUISprite sprite = base.GetSprite(11);
				if (sprite != null)
				{
					sprite.SetFillAmount(num);
				}
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(this.EntityId);
			if ((entity == null || !entity.Valid) && this.OldLife != 0 && !this.AnimPlayed)
			{
				BaseAttributeComponent attributeComp = this.AttributeComp;
				if (attributeComp != null)
				{
					attributeComp.RemoveListeners(new EAttributeType[]
					{
						EAttributeType.Life,
						EAttributeType.LifeMax
					}, new Action<EAttributeType, float, float>(this.AttributeRefreshLifeBar));
				}
				BaseAttributeComponent attributeComp2 = this.AttributeComp;
				if (attributeComp2 != null)
				{
					attributeComp2.RemoveListener(EAttributeType.SpecialEnergy4, new Action<EAttributeType, float, float>(this.AttributeRefreshSettlePoint));
				}
				this.AttributeComp = null;
				this.RefreshLifeBar();
			}
			this.RefreshAnim();
		}

		// Token: 0x06035F73 RID: 221043 RVA: 0x00CC49F0 File Offset: 0x00CC2BF0
		private void RefreshAnim()
		{
			int? num = this.CheckTagCurrent();
			EPhantomBattleHeadAnim ephantomBattleHeadAnim = this.IsOwn ? EPhantomBattleHeadAnim.FactorMeShow : EPhantomBattleHeadAnim.FactorOtherShow;
			if (num == null)
			{
				if (this.CurPlayingIndex < 0 || this.CurPlayingIndex >= this.BeforeBattleFactor.Count)
				{
					return;
				}
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null || !sequencePlayer.IsPlayingSequence(ephantomBattleHeadAnim.ToString()))
				{
					this.RefreshFactorShow(this.BeforeBattleFactor[this.CurPlayingIndex]);
					LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
					if (sequencePlayer2 != null)
					{
						sequencePlayer2.PlayLevelSequenceByName(ephantomBattleHeadAnim.ToString(), false, null, false);
					}
					this.CurPlayingIndex++;
					return;
				}
			}
			else
			{
				if (this.BeforeBattleFactor.Count > 0)
				{
					this.BeforeBattleFactor.Clear();
					this.CurPlayingIndex = -1;
				}
				LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
				if (sequencePlayer3 == null || !sequencePlayer3.IsPlayingSequence(ephantomBattleHeadAnim.ToString()))
				{
					LevelSequencePlayer sequencePlayer4 = this.SequencePlayer;
					if (sequencePlayer4 != null)
					{
						sequencePlayer4.PlayLevelSequenceByName(ephantomBattleHeadAnim.ToString(), false, null, false);
					}
				}
				else
				{
					LevelSequencePlayer sequencePlayer5 = this.SequencePlayer;
					if (sequencePlayer5 != null)
					{
						sequencePlayer5.ReplaySequenceByKey(ephantomBattleHeadAnim.ToString());
					}
				}
				this.RefreshFactorShow(num.Value);
			}
		}

		// Token: 0x06035F74 RID: 221044 RVA: 0x00CC4B52 File Offset: 0x00CC2D52
		private void AttributeRefreshSettlePoint(EAttributeType type, float cur, float max)
		{
			this.RefreshSettlePoint();
		}

		// Token: 0x06035F75 RID: 221045 RVA: 0x00CC4B5C File Offset: 0x00CC2D5C
		private void RefreshSettlePoint()
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			int settlePoint = (int)((attributeComp != null) ? attributeComp.GetCurrentValue(EAttributeType.SpecialEnergy4) : 0f);
			if (this.IsOwn)
			{
				this.Proxy.SetOwnAllSettlePoint(this.EntityId, settlePoint);
				return;
			}
			this.Proxy.SetOpponentSettlePoint(this.EntityId, settlePoint);
		}

		// Token: 0x06035F76 RID: 221046 RVA: 0x00CC4BB0 File Offset: 0x00CC2DB0
		private void AddAttributeListener()
		{
			if (this.AttributeComp == null)
			{
				return;
			}
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp != null)
			{
				attributeComp.AddListeners(new EAttributeType[]
				{
					EAttributeType.Life,
					EAttributeType.LifeMax
				}, new Action<EAttributeType, float, float>(this.AttributeRefreshLifeBar), null);
			}
			BaseAttributeComponent attributeComp2 = this.AttributeComp;
			if (attributeComp2 == null)
			{
				return;
			}
			attributeComp2.AddListener(EAttributeType.SpecialEnergy4, new Action<EAttributeType, float, float>(this.AttributeRefreshSettlePoint), null);
		}

		// Token: 0x06035F77 RID: 221047 RVA: 0x00CC4C14 File Offset: 0x00CC2E14
		private void RemoveAttributeListener()
		{
			if (this.AttributeComp == null)
			{
				return;
			}
			BaseAttributeComponent attributeComp = this.AttributeComp;
			if (attributeComp != null)
			{
				attributeComp.RemoveListeners(new EAttributeType[]
				{
					EAttributeType.Life,
					EAttributeType.LifeMax
				}, new Action<EAttributeType, float, float>(this.AttributeRefreshLifeBar));
			}
			BaseAttributeComponent attributeComp2 = this.AttributeComp;
			if (attributeComp2 == null)
			{
				return;
			}
			attributeComp2.RemoveListener(EAttributeType.SpecialEnergy4, new Action<EAttributeType, float, float>(this.AttributeRefreshSettlePoint));
		}

		// Token: 0x06035F78 RID: 221048 RVA: 0x00CC4C74 File Offset: 0x00CC2E74
		public void RegisterProxy(PhantomArenaBattleDetailsViewProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x06035F79 RID: 221049 RVA: 0x00CC4C80 File Offset: 0x00CC2E80
		public override void Refresh(long entityId, bool isSelected, int gridIndex)
		{
			this.EntityId = entityId;
			this.RemoveAttributeListener();
			EntityHandle entity = CreatureModel.Instance.GetEntity(entityId);
			BaseAttributeComponent attributeComp;
			if (entity == null)
			{
				attributeComp = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				attributeComp = ((entity2 != null) ? entity2.GetComponent<BaseAttributeComponent>() : null);
			}
			this.AttributeComp = attributeComp;
			this.AddAttributeListener();
			PhantomCardData cardData = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(entityId);
			int fightValueByAttr = cardData.GetFightValueByAttr(PhantomBattleCardAttr.CostAbility);
			this.RefreshCostNum(fightValueByAttr);
			this.RefreshIcon(entityId);
			this.RefreshLifeBar();
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.RefreshFactor(cardData.ConfigId, cardData.ExtraFactors);
			}, 600f, null, null, true, 1f);
		}

		// Token: 0x06035F7A RID: 221050 RVA: 0x00CC4D34 File Offset: 0x00CC2F34
		private int? CheckTagCurrent()
		{
			if (this.CurShowTime + 600.0 > Time.Instance.Now)
			{
				return null;
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(this.EntityId);
			BaseTagComponent baseTagComponent;
			if (entity == null)
			{
				baseTagComponent = null;
			}
			else
			{
				WorldEntity entity2 = entity.Entity;
				baseTagComponent = ((entity2 != null) ? entity2.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null)
			{
				return null;
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, int> keyValuePair in PhantomArenaBattleModel.Instance.GetPhantomTagMap())
			{
				if (baseTagComponent2.HasTag(keyValuePair.Key) && !this.HadPlayFactor.Contains(keyValuePair.Value))
				{
					list.Add(keyValuePair.Value);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			list.Sort(delegate(int a, int b)
			{
				PhantomBattleFactor phantomBattleFactorConfig = PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(a);
				return PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(b).Sort - phantomBattleFactorConfig.Sort;
			});
			this.HadPlayFactor.Add(list[0]);
			this.CurShowTime = Time.Instance.Now;
			return new int?(list[0]);
		}

		// Token: 0x06035F7B RID: 221051 RVA: 0x00CC4E80 File Offset: 0x00CC3080
		public int GetDamage()
		{
			BaseAttributeComponent attributeComp = this.AttributeComp;
			this.LastLife = (int)((attributeComp != null) ? new float?(attributeComp.GetCurrentValue(EAttributeType.Life)) : null).Value;
			if (this.LastLife == 0)
			{
				return 0;
			}
			return this.DamageCount;
		}

		// Token: 0x06035F7C RID: 221052 RVA: 0x00CC4ECC File Offset: 0x00CC30CC
		public int ShowWinAnim()
		{
			EPhantomBattleHeadAnim ephantomBattleHeadAnim = this.IsOwn ? EPhantomBattleHeadAnim.FactorMeShow : EPhantomBattleHeadAnim.FactorOtherShow;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsPlayingSequence(ephantomBattleHeadAnim.ToString()))
			{
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 != null)
				{
					sequencePlayer2.StopCurrentSequence(false, true);
				}
			}
			BaseAttributeComponent attributeComp = this.AttributeComp;
			this.LastLife = (int)((attributeComp != null) ? new float?(attributeComp.GetCurrentValue(EAttributeType.Life)) : null).Value;
			if (this.LastLife == 0)
			{
				return 0;
			}
			LevelSequencePlayer sequencePlayer3 = this.SequencePlayer;
			if (sequencePlayer3 != null)
			{
				sequencePlayer3.PlayLevelSequenceByName(EPhantomBattleHeadAnim.DamageAccumulate.ToString(), false, null, false);
			}
			this.AnimPlayed = true;
			return this.DamageCount;
		}

		// Token: 0x06035F7D RID: 221053 RVA: 0x00CC4F94 File Offset: 0x00CC3194
		public void OnAccumulateEvent(float endX, float endZ, UCurveFloat curveX, UCurveFloat curveZ)
		{
			if (this.LastLife == 0)
			{
				return;
			}
			base.GetUiNiagara(8).SetUIActive(true);
			float duration = 0.3f;
			FVectorDouble fvectorDouble = base.GetButton(0).RootUIComp.Get().D_K2_GetComponentLocation();
			this.TweenerX = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DelegateX, (float)fvectorDouble.X, endX, duration, 0f, LTweenEase.OutCubic);
			this.TweenerZ = ULTweenBPLibrary.FloatTo(GlobalData.World, this.DelegateZ, (float)fvectorDouble.Z, endZ, duration, 0f, LTweenEase.OutCubic);
			if (this.TweenerX != null)
			{
				this.TweenerX.OnCompleteCallBack.Bind(new Action(this.OnTweenerXEnd));
				this.TweenerX.SetEase(LTweenEase.CurveFloat);
				this.TweenerX.SetCurveFloat(curveX);
			}
			if (this.TweenerZ != null)
			{
				this.TweenerZ.OnCompleteCallBack.Bind(new Action(this.OnTweenerZEnd));
				this.TweenerZ.SetEase(LTweenEase.CurveFloat);
				this.TweenerZ.SetCurveFloat(curveZ);
			}
		}

		// Token: 0x06035F7E RID: 221054 RVA: 0x00CC50A0 File Offset: 0x00CC32A0
		private void TweenCallX(float value)
		{
			FVectorDouble fvectorDouble = base.GetUiNiagara(8).D_K2_GetComponentLocation();
			FVectorDouble newLocation = global::Vector.Create((double)value, fvectorDouble.Y, fvectorDouble.Z).ToUeVector(false);
			base.GetUiNiagara(8).D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06035F7F RID: 221055 RVA: 0x00CC50E8 File Offset: 0x00CC32E8
		private void TweenerCallZ(float value)
		{
			FVectorDouble fvectorDouble = base.GetUiNiagara(8).D_K2_GetComponentLocation();
			FVectorDouble newLocation = global::Vector.Create(fvectorDouble.X, fvectorDouble.Y, (double)value).ToUeVector(false);
			base.GetUiNiagara(8).D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06035F80 RID: 221056 RVA: 0x00CC5130 File Offset: 0x00CC3330
		private void OnTweenerXEnd()
		{
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			base.GetUiNiagara(8).SetUIActive(false);
		}

		// Token: 0x06035F81 RID: 221057 RVA: 0x00CC514E File Offset: 0x00CC334E
		private void OnTweenerZEnd()
		{
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
		}

		// Token: 0x0401C929 RID: 117033
		private const int FACTOR_INTERVAL = 600;

		// Token: 0x0401C92A RID: 117034
		protected PhantomArenaBattleDetailsViewProxy Proxy;

		// Token: 0x0401C92B RID: 117035
		protected BaseAttributeComponent AttributeComp;

		// Token: 0x0401C92C RID: 117036
		protected long EntityId;

		// Token: 0x0401C92D RID: 117037
		protected bool HasTickInit;

		// Token: 0x0401C92E RID: 117038
		protected List<int> BeforeBattleFactor = new List<int>();

		// Token: 0x0401C92F RID: 117039
		protected HashSet<int> HadPlayFactor = new HashSet<int>();

		// Token: 0x0401C930 RID: 117040
		protected double CurShowTime;

		// Token: 0x0401C931 RID: 117041
		protected int CurPlayingIndex = -1;

		// Token: 0x0401C932 RID: 117042
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0401C933 RID: 117043
		public bool IsOwn;

		// Token: 0x0401C934 RID: 117044
		protected ULTweener TweenerX;

		// Token: 0x0401C935 RID: 117045
		protected ULTweener TweenerZ;

		// Token: 0x0401C936 RID: 117046
		protected FLTweenFloatSetterDynamic DelegateX;

		// Token: 0x0401C937 RID: 117047
		protected FLTweenFloatSetterDynamic DelegateZ;

		// Token: 0x0401C938 RID: 117048
		protected int DamageCount;

		// Token: 0x0401C939 RID: 117049
		protected HpBufferStateMachine HpMachine = new HpBufferStateMachine();

		// Token: 0x0401C93A RID: 117050
		protected int OldLife;

		// Token: 0x0401C93B RID: 117051
		protected int MaxLife;

		// Token: 0x0401C93C RID: 117052
		protected int LastLife;

		// Token: 0x0401C93D RID: 117053
		protected bool AnimPlayed;

		// Token: 0x0401C93E RID: 117054
		public Action<long> OnClickCb;

		// Token: 0x0200B460 RID: 46176
		[NullableContext(0)]
		private class EMonsterItem
		{
			// Token: 0x04036A66 RID: 223846
			public const int Button = 0;

			// Token: 0x04036A67 RID: 223847
			public const int Icon = 1;

			// Token: 0x04036A68 RID: 223848
			public const int CostNum = 2;

			// Token: 0x04036A69 RID: 223849
			public const int OwnBar = 3;

			// Token: 0x04036A6A RID: 223850
			public const int OpponentBar = 4;

			// Token: 0x04036A6B RID: 223851
			public const int AttackTexBg = 5;

			// Token: 0x04036A6C RID: 223852
			public const int NormalTexBg = 6;

			// Token: 0x04036A6D RID: 223853
			public const int TxtSkill = 7;

			// Token: 0x04036A6E RID: 223854
			public const int NiagaraPoint = 8;

			// Token: 0x04036A6F RID: 223855
			public const int PanelHit = 9;

			// Token: 0x04036A70 RID: 223856
			public const int TxtHitNum = 10;

			// Token: 0x04036A71 RID: 223857
			public const int DamageBar = 11;
		}
	}
}
