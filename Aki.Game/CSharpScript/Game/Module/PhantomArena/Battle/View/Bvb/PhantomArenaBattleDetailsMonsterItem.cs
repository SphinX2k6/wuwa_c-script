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
	// Token: 0x02004240 RID: 16960
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsMonsterItem : GridProxyAbstract<long>
	{
		// Token: 0x0602AE62 RID: 175714 RVA: 0x00C11AAC File Offset: 0x00C0FCAC
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

		// Token: 0x0602AE63 RID: 175715 RVA: 0x00C11BF4 File Offset: 0x00C0FDF4
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

		// Token: 0x0602AE64 RID: 175716 RVA: 0x00C11C84 File Offset: 0x00C0FE84
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

		// Token: 0x0602AE65 RID: 175717 RVA: 0x00C11CD7 File Offset: 0x00C0FED7
		private void OnClick()
		{
			Action<long> onClickCb = this.OnClickCb;
			if (onClickCb == null)
			{
				return;
			}
			onClickCb(this.EntityId);
		}

		// Token: 0x0602AE66 RID: 175718 RVA: 0x00C11CEF File Offset: 0x00C0FEEF
		private void AttributeRefreshLifeBar(EAttributeType type, float cur, float max)
		{
			this.RefreshLifeBar();
		}

		// Token: 0x0602AE67 RID: 175719 RVA: 0x00C11CF8 File Offset: 0x00C0FEF8
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

		// Token: 0x0602AE68 RID: 175720 RVA: 0x00C11DEB File Offset: 0x00C0FFEB
		private void RefreshCostNum(int settlePoint)
		{
			this.DamageCount = settlePoint;
			base.GetText(2).SetText(settlePoint.ToString(), true);
		}

		// Token: 0x0602AE69 RID: 175721 RVA: 0x00C11E08 File Offset: 0x00C10008
		private void RefreshIcon(long entityId)
		{
			PhantomCardData cardDataByEntityId = PhantomArenaBattleModel.Instance.BattleData.GetCardDataByEntityId(entityId);
			base.SetTextureByPath(PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(cardDataByEntityId.ConfigId).BvbIcon, base.GetTexture(1), null, null);
		}

		// Token: 0x0602AE6A RID: 175722 RVA: 0x00C11E55 File Offset: 0x00C10055
		private void RefreshBarActive()
		{
			base.GetSprite(3).SetUIActive(this.IsOwn);
			base.GetSprite(4).SetUIActive(!this.IsOwn);
		}

		// Token: 0x0602AE6B RID: 175723 RVA: 0x00C11E80 File Offset: 0x00C10080
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

		// Token: 0x0602AE6C RID: 175724 RVA: 0x00C11FA8 File Offset: 0x00C101A8
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

		// Token: 0x0602AE6D RID: 175725 RVA: 0x00C12020 File Offset: 0x00C10220
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

		// Token: 0x0602AE6E RID: 175726 RVA: 0x00C120F0 File Offset: 0x00C102F0
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

		// Token: 0x0602AE6F RID: 175727 RVA: 0x00C12252 File Offset: 0x00C10452
		private void AttributeRefreshSettlePoint(EAttributeType type, float cur, float max)
		{
			this.RefreshSettlePoint();
		}

		// Token: 0x0602AE70 RID: 175728 RVA: 0x00C1225C File Offset: 0x00C1045C
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

		// Token: 0x0602AE71 RID: 175729 RVA: 0x00C122B0 File Offset: 0x00C104B0
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

		// Token: 0x0602AE72 RID: 175730 RVA: 0x00C12314 File Offset: 0x00C10514
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

		// Token: 0x0602AE73 RID: 175731 RVA: 0x00C12374 File Offset: 0x00C10574
		public void RegisterProxy(PhantomArenaBattleDetailsViewProxy proxy)
		{
			this.Proxy = proxy;
		}

		// Token: 0x0602AE74 RID: 175732 RVA: 0x00C12380 File Offset: 0x00C10580
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

		// Token: 0x0602AE75 RID: 175733 RVA: 0x00C12434 File Offset: 0x00C10634
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

		// Token: 0x0602AE76 RID: 175734 RVA: 0x00C12580 File Offset: 0x00C10780
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

		// Token: 0x0602AE77 RID: 175735 RVA: 0x00C125CC File Offset: 0x00C107CC
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

		// Token: 0x0602AE78 RID: 175736 RVA: 0x00C12694 File Offset: 0x00C10894
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

		// Token: 0x0602AE79 RID: 175737 RVA: 0x00C127A0 File Offset: 0x00C109A0
		private void TweenCallX(float value)
		{
			FVectorDouble fvectorDouble = base.GetUiNiagara(8).D_K2_GetComponentLocation();
			FVectorDouble newLocation = global::Vector.Create((double)value, fvectorDouble.Y, fvectorDouble.Z).ToUeVector(false);
			base.GetUiNiagara(8).D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x0602AE7A RID: 175738 RVA: 0x00C127E8 File Offset: 0x00C109E8
		private void TweenerCallZ(float value)
		{
			FVectorDouble fvectorDouble = base.GetUiNiagara(8).D_K2_GetComponentLocation();
			FVectorDouble newLocation = global::Vector.Create(fvectorDouble.X, fvectorDouble.Y, (double)value).ToUeVector(false);
			base.GetUiNiagara(8).D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x0602AE7B RID: 175739 RVA: 0x00C12830 File Offset: 0x00C10A30
		private void OnTweenerXEnd()
		{
			if (this.TweenerX != null)
			{
				this.TweenerX = null;
			}
			base.GetUiNiagara(8).SetUIActive(false);
		}

		// Token: 0x0602AE7C RID: 175740 RVA: 0x00C1284E File Offset: 0x00C10A4E
		private void OnTweenerZEnd()
		{
			if (this.TweenerZ != null)
			{
				this.TweenerZ = null;
			}
		}

		// Token: 0x0401735E RID: 95070
		private const int FACTOR_INTERVAL = 600;

		// Token: 0x0401735F RID: 95071
		protected PhantomArenaBattleDetailsViewProxy Proxy;

		// Token: 0x04017360 RID: 95072
		protected BaseAttributeComponent AttributeComp;

		// Token: 0x04017361 RID: 95073
		protected long EntityId;

		// Token: 0x04017362 RID: 95074
		protected bool HasTickInit;

		// Token: 0x04017363 RID: 95075
		protected List<int> BeforeBattleFactor = new List<int>();

		// Token: 0x04017364 RID: 95076
		protected HashSet<int> HadPlayFactor = new HashSet<int>();

		// Token: 0x04017365 RID: 95077
		protected double CurShowTime;

		// Token: 0x04017366 RID: 95078
		protected int CurPlayingIndex = -1;

		// Token: 0x04017367 RID: 95079
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x04017368 RID: 95080
		public bool IsOwn;

		// Token: 0x04017369 RID: 95081
		protected ULTweener TweenerX;

		// Token: 0x0401736A RID: 95082
		protected ULTweener TweenerZ;

		// Token: 0x0401736B RID: 95083
		protected FLTweenFloatSetterDynamic DelegateX;

		// Token: 0x0401736C RID: 95084
		protected FLTweenFloatSetterDynamic DelegateZ;

		// Token: 0x0401736D RID: 95085
		protected int DamageCount;

		// Token: 0x0401736E RID: 95086
		protected HpBufferStateMachine HpMachine = new HpBufferStateMachine();

		// Token: 0x0401736F RID: 95087
		protected int OldLife;

		// Token: 0x04017370 RID: 95088
		protected int MaxLife;

		// Token: 0x04017371 RID: 95089
		protected int LastLife;

		// Token: 0x04017372 RID: 95090
		protected bool AnimPlayed;

		// Token: 0x04017373 RID: 95091
		public Action<long> OnClickCb;

		// Token: 0x02009E98 RID: 40600
		[NullableContext(0)]
		private class EMonsterItem
		{
			// Token: 0x040314B9 RID: 201913
			public const int Button = 0;

			// Token: 0x040314BA RID: 201914
			public const int Icon = 1;

			// Token: 0x040314BB RID: 201915
			public const int CostNum = 2;

			// Token: 0x040314BC RID: 201916
			public const int OwnBar = 3;

			// Token: 0x040314BD RID: 201917
			public const int OpponentBar = 4;

			// Token: 0x040314BE RID: 201918
			public const int AttackTexBg = 5;

			// Token: 0x040314BF RID: 201919
			public const int NormalTexBg = 6;

			// Token: 0x040314C0 RID: 201920
			public const int TxtSkill = 7;

			// Token: 0x040314C1 RID: 201921
			public const int NiagaraPoint = 8;

			// Token: 0x040314C2 RID: 201922
			public const int PanelHit = 9;

			// Token: 0x040314C3 RID: 201923
			public const int TxtHitNum = 10;

			// Token: 0x040314C4 RID: 201924
			public const int DamageBar = 11;
		}
	}
}
