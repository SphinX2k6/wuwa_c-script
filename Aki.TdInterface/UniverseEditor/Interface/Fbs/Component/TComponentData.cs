using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF4 RID: 23540
	public struct TComponentData : IFlatbufferObject
	{
		// Token: 0x1700B1CD RID: 45517
		// (get) Token: 0x0602855B RID: 165211 RVA: 0x0058A81C File Offset: 0x00588A1C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602855C RID: 165212 RVA: 0x0058A829 File Offset: 0x00588A29
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602855D RID: 165213 RVA: 0x0058A830 File Offset: 0x00588A30
		public static TComponentData GetRootAsTComponentData(ByteBuffer _bb)
		{
			return TComponentData.GetRootAsTComponentData(_bb, default(TComponentData));
		}

		// Token: 0x0602855E RID: 165214 RVA: 0x0058A84C File Offset: 0x00588A4C
		public static TComponentData GetRootAsTComponentData(ByteBuffer _bb, TComponentData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602855F RID: 165215 RVA: 0x0058A869 File Offset: 0x00588A69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028560 RID: 165216 RVA: 0x0058A878 File Offset: 0x00588A78
		public TComponentData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1CE RID: 45518
		// (get) Token: 0x06028561 RID: 165217 RVA: 0x0058A888 File Offset: 0x00588A88
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028562 RID: 165218 RVA: 0x0058A8BF File Offset: 0x00588ABF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06028563 RID: 165219 RVA: 0x0058A8CE File Offset: 0x00588ACE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700B1CF RID: 45519
		// (get) Token: 0x06028564 RID: 165220 RVA: 0x0058A8DC File Offset: 0x00588ADC
		public IComponentBase_Union ValueType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return IComponentBase_Union.NONE;
				}
				return (IComponentBase_Union)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028565 RID: 165221 RVA: 0x0058A918 File Offset: 0x00588B18
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028566 RID: 165222 RVA: 0x0058A95C File Offset: 0x00588B5C
		public IComponentBase ValueAsIComponentBase()
		{
			return this.Value<IComponentBase>().Value;
		}

		// Token: 0x06028567 RID: 165223 RVA: 0x0058A978 File Offset: 0x00588B78
		public IUnUseComponent ValueAsIUnUseComponent()
		{
			return this.Value<IUnUseComponent>().Value;
		}

		// Token: 0x06028568 RID: 165224 RVA: 0x0058A994 File Offset: 0x00588B94
		public IInteractiveComponent ValueAsIInteractiveComponent()
		{
			return this.Value<IInteractiveComponent>().Value;
		}

		// Token: 0x06028569 RID: 165225 RVA: 0x0058A9B0 File Offset: 0x00588BB0
		public ISwitcherComponent ValueAsISwitcherComponent()
		{
			return this.Value<ISwitcherComponent>().Value;
		}

		// Token: 0x0602856A RID: 165226 RVA: 0x0058A9CC File Offset: 0x00588BCC
		public IRotatorComponent ValueAsIRotatorComponent()
		{
			return this.Value<IRotatorComponent>().Value;
		}

		// Token: 0x0602856B RID: 165227 RVA: 0x0058A9E8 File Offset: 0x00588BE8
		public IBehaviorFlowComponent ValueAsIBehaviorFlowComponent()
		{
			return this.Value<IBehaviorFlowComponent>().Value;
		}

		// Token: 0x0602856C RID: 165228 RVA: 0x0058AA04 File Offset: 0x00588C04
		public IFlowComponent ValueAsIFlowComponent()
		{
			return this.Value<IFlowComponent>().Value;
		}

		// Token: 0x0602856D RID: 165229 RVA: 0x0058AA20 File Offset: 0x00588C20
		public ITriggerUe5Component ValueAsITriggerUe5Component()
		{
			return this.Value<ITriggerUe5Component>().Value;
		}

		// Token: 0x0602856E RID: 165230 RVA: 0x0058AA3C File Offset: 0x00588C3C
		public IMoveComponent ValueAsIMoveComponent()
		{
			return this.Value<IMoveComponent>().Value;
		}

		// Token: 0x0602856F RID: 165231 RVA: 0x0058AA58 File Offset: 0x00588C58
		public IActorStateComponent ValueAsIActorStateComponent()
		{
			return this.Value<IActorStateComponent>().Value;
		}

		// Token: 0x06028570 RID: 165232 RVA: 0x0058AA74 File Offset: 0x00588C74
		public ICalculateComponent ValueAsICalculateComponent()
		{
			return this.Value<ICalculateComponent>().Value;
		}

		// Token: 0x06028571 RID: 165233 RVA: 0x0058AA90 File Offset: 0x00588C90
		public IRefreshGroup ValueAsIRefreshGroup()
		{
			return this.Value<IRefreshGroup>().Value;
		}

		// Token: 0x06028572 RID: 165234 RVA: 0x0058AAAC File Offset: 0x00588CAC
		public IRefreshSingleComponent ValueAsIRefreshSingleComponent()
		{
			return this.Value<IRefreshSingleComponent>().Value;
		}

		// Token: 0x06028573 RID: 165235 RVA: 0x0058AAC8 File Offset: 0x00588CC8
		public IRotatorComponent2 ValueAsIRotatorComponent2()
		{
			return this.Value<IRotatorComponent2>().Value;
		}

		// Token: 0x06028574 RID: 165236 RVA: 0x0058AAE4 File Offset: 0x00588CE4
		public ISphereFactoryComponent ValueAsISphereFactoryComponent()
		{
			return this.Value<ISphereFactoryComponent>().Value;
		}

		// Token: 0x06028575 RID: 165237 RVA: 0x0058AB00 File Offset: 0x00588D00
		public ISpringComponent ValueAsISpringComponent()
		{
			return this.Value<ISpringComponent>().Value;
		}

		// Token: 0x06028576 RID: 165238 RVA: 0x0058AB1C File Offset: 0x00588D1C
		public ITrampleUe5Component ValueAsITrampleUe5Component()
		{
			return this.Value<ITrampleUe5Component>().Value;
		}

		// Token: 0x06028577 RID: 165239 RVA: 0x0058AB38 File Offset: 0x00588D38
		public IUndergroundComponent ValueAsIUndergroundComponent()
		{
			return this.Value<IUndergroundComponent>().Value;
		}

		// Token: 0x06028578 RID: 165240 RVA: 0x0058AB54 File Offset: 0x00588D54
		public IGrabComponent ValueAsIGrabComponent()
		{
			return this.Value<IGrabComponent>().Value;
		}

		// Token: 0x06028579 RID: 165241 RVA: 0x0058AB70 File Offset: 0x00588D70
		public IInteractComponent ValueAsIInteractComponent()
		{
			return this.Value<IInteractComponent>().Value;
		}

		// Token: 0x0602857A RID: 165242 RVA: 0x0058AB8C File Offset: 0x00588D8C
		public IVarComponent ValueAsIVarComponent()
		{
			return this.Value<IVarComponent>().Value;
		}

		// Token: 0x0602857B RID: 165243 RVA: 0x0058ABA8 File Offset: 0x00588DA8
		public IPatrol ValueAsIPatrol()
		{
			return this.Value<IPatrol>().Value;
		}

		// Token: 0x0602857C RID: 165244 RVA: 0x0058ABC4 File Offset: 0x00588DC4
		public IAiComponent ValueAsIAiComponent()
		{
			return this.Value<IAiComponent>().Value;
		}

		// Token: 0x0602857D RID: 165245 RVA: 0x0058ABE0 File Offset: 0x00588DE0
		public IAttributeComponent ValueAsIAttributeComponent()
		{
			return this.Value<IAttributeComponent>().Value;
		}

		// Token: 0x0602857E RID: 165246 RVA: 0x0058ABFC File Offset: 0x00588DFC
		public IEditCustomAoiComponent ValueAsIEditCustomAoiComponent()
		{
			return this.Value<IEditCustomAoiComponent>().Value;
		}

		// Token: 0x0602857F RID: 165247 RVA: 0x0058AC18 File Offset: 0x00588E18
		public IBaseInfoComponent ValueAsIBaseInfoComponent()
		{
			return this.Value<IBaseInfoComponent>().Value;
		}

		// Token: 0x06028580 RID: 165248 RVA: 0x0058AC34 File Offset: 0x00588E34
		public IRewardComponent ValueAsIRewardComponent()
		{
			return this.Value<IRewardComponent>().Value;
		}

		// Token: 0x06028581 RID: 165249 RVA: 0x0058AC50 File Offset: 0x00588E50
		public IDynamicEntityRewardComponent ValueAsIDynamicEntityRewardComponent()
		{
			return this.Value<IDynamicEntityRewardComponent>().Value;
		}

		// Token: 0x06028582 RID: 165250 RVA: 0x0058AC6C File Offset: 0x00588E6C
		public IIndependentSystemRewardComponent ValueAsIIndependentSystemRewardComponent()
		{
			return this.Value<IIndependentSystemRewardComponent>().Value;
		}

		// Token: 0x06028583 RID: 165251 RVA: 0x0058AC88 File Offset: 0x00588E88
		public IRefreshComponent ValueAsIRefreshComponent()
		{
			return this.Value<IRefreshComponent>().Value;
		}

		// Token: 0x06028584 RID: 165252 RVA: 0x0058ACA4 File Offset: 0x00588EA4
		public IRefreshGroupComponent ValueAsIRefreshGroupComponent()
		{
			return this.Value<IRefreshGroupComponent>().Value;
		}

		// Token: 0x06028585 RID: 165253 RVA: 0x0058ACC0 File Offset: 0x00588EC0
		public IEntityBatchRefreshComponent ValueAsIEntityBatchRefreshComponent()
		{
			return this.Value<IEntityBatchRefreshComponent>().Value;
		}

		// Token: 0x06028586 RID: 165254 RVA: 0x0058ACDC File Offset: 0x00588EDC
		public ITreasureBoxComponent ValueAsITreasureBoxComponent()
		{
			return this.Value<ITreasureBoxComponent>().Value;
		}

		// Token: 0x06028587 RID: 165255 RVA: 0x0058ACF8 File Offset: 0x00588EF8
		public ITriggerComponent ValueAsITriggerComponent()
		{
			return this.Value<ITriggerComponent>().Value;
		}

		// Token: 0x06028588 RID: 165256 RVA: 0x0058AD14 File Offset: 0x00588F14
		public IEntityStateComponent ValueAsIEntityStateComponent()
		{
			return this.Value<IEntityStateComponent>().Value;
		}

		// Token: 0x06028589 RID: 165257 RVA: 0x0058AD30 File Offset: 0x00588F30
		public ISceneItemAttributeComponent ValueAsISceneItemAttributeComponent()
		{
			return this.Value<ISceneItemAttributeComponent>().Value;
		}

		// Token: 0x0602858A RID: 165258 RVA: 0x0058AD4C File Offset: 0x00588F4C
		public IEntityAudioComponent ValueAsIEntityAudioComponent()
		{
			return this.Value<IEntityAudioComponent>().Value;
		}

		// Token: 0x0602858B RID: 165259 RVA: 0x0058AD68 File Offset: 0x00588F68
		public IEntityStateAudioComponent ValueAsIEntityStateAudioComponent()
		{
			return this.Value<IEntityStateAudioComponent>().Value;
		}

		// Token: 0x0602858C RID: 165260 RVA: 0x0058AD84 File Offset: 0x00588F84
		public IEntityCustomAudioComponent ValueAsIEntityCustomAudioComponent()
		{
			return this.Value<IEntityCustomAudioComponent>().Value;
		}

		// Token: 0x0602858D RID: 165261 RVA: 0x0058ADA0 File Offset: 0x00588FA0
		public ITrampleComponent ValueAsITrampleComponent()
		{
			return this.Value<ITrampleComponent>().Value;
		}

		// Token: 0x0602858E RID: 165262 RVA: 0x0058ADBC File Offset: 0x00588FBC
		public IEntityGroupComponent ValueAsIEntityGroupComponent()
		{
			return this.Value<IEntityGroupComponent>().Value;
		}

		// Token: 0x0602858F RID: 165263 RVA: 0x0058ADD8 File Offset: 0x00588FD8
		public IHookLockPoint ValueAsIHookLockPoint()
		{
			return this.Value<IHookLockPoint>().Value;
		}

		// Token: 0x06028590 RID: 165264 RVA: 0x0058ADF4 File Offset: 0x00588FF4
		public IRoleMotionInteractComponent ValueAsIRoleMotionInteractComponent()
		{
			return this.Value<IRoleMotionInteractComponent>().Value;
		}

		// Token: 0x06028591 RID: 165265 RVA: 0x0058AE10 File Offset: 0x00589010
		public IHookFetchComponent ValueAsIHookFetchComponent()
		{
			return this.Value<IHookFetchComponent>().Value;
		}

		// Token: 0x06028592 RID: 165266 RVA: 0x0058AE2C File Offset: 0x0058902C
		public IItemFoundation ValueAsIItemFoundation()
		{
			return this.Value<IItemFoundation>().Value;
		}

		// Token: 0x06028593 RID: 165267 RVA: 0x0058AE48 File Offset: 0x00589048
		public IResetEntitiesPosComponent ValueAsIResetEntitiesPosComponent()
		{
			return this.Value<IResetEntitiesPosComponent>().Value;
		}

		// Token: 0x06028594 RID: 165268 RVA: 0x0058AE64 File Offset: 0x00589064
		public IResetSelfPosComponent ValueAsIResetSelfPosComponent()
		{
			return this.Value<IResetSelfPosComponent>().Value;
		}

		// Token: 0x06028595 RID: 165269 RVA: 0x0058AE80 File Offset: 0x00589080
		public ICollectComponent ValueAsICollectComponent()
		{
			return this.Value<ICollectComponent>().Value;
		}

		// Token: 0x06028596 RID: 165270 RVA: 0x0058AE9C File Offset: 0x0058909C
		public ITeleControl2 ValueAsITeleControl2()
		{
			return this.Value<ITeleControl2>().Value;
		}

		// Token: 0x06028597 RID: 165271 RVA: 0x0058AEB8 File Offset: 0x005890B8
		public IItemFoundation2 ValueAsIItemFoundation2()
		{
			return this.Value<IItemFoundation2>().Value;
		}

		// Token: 0x06028598 RID: 165272 RVA: 0x0058AED4 File Offset: 0x005890D4
		public IPullingFoundation ValueAsIPullingFoundation()
		{
			return this.Value<IPullingFoundation>().Value;
		}

		// Token: 0x06028599 RID: 165273 RVA: 0x0058AEF0 File Offset: 0x005890F0
		public ILevelPlayComponent ValueAsILevelPlayComponent()
		{
			return this.Value<ILevelPlayComponent>().Value;
		}

		// Token: 0x0602859A RID: 165274 RVA: 0x0058AF0C File Offset: 0x0058910C
		public IDynamicLevelPlayComponent ValueAsIDynamicLevelPlayComponent()
		{
			return this.Value<IDynamicLevelPlayComponent>().Value;
		}

		// Token: 0x0602859B RID: 165275 RVA: 0x0058AF28 File Offset: 0x00589128
		public IVisionComponent ValueAsIVisionComponent()
		{
			return this.Value<IVisionComponent>().Value;
		}

		// Token: 0x0602859C RID: 165276 RVA: 0x0058AF44 File Offset: 0x00589144
		public IVisionCaptureComponent ValueAsIVisionCaptureComponent()
		{
			return this.Value<IVisionCaptureComponent>().Value;
		}

		// Token: 0x0602859D RID: 165277 RVA: 0x0058AF60 File Offset: 0x00589160
		public IAdsorbComponent ValueAsIAdsorbComponent()
		{
			return this.Value<IAdsorbComponent>().Value;
		}

		// Token: 0x0602859E RID: 165278 RVA: 0x0058AF7C File Offset: 0x0058917C
		public ITeleportComponent ValueAsITeleportComponent()
		{
			return this.Value<ITeleportComponent>().Value;
		}

		// Token: 0x0602859F RID: 165279 RVA: 0x0058AF98 File Offset: 0x00589198
		public ISpawnMonsterComponent ValueAsISpawnMonsterComponent()
		{
			return this.Value<ISpawnMonsterComponent>().Value;
		}

		// Token: 0x060285A0 RID: 165280 RVA: 0x0058AFB4 File Offset: 0x005891B4
		public IHitComponentBase ValueAsIHitComponentBase()
		{
			return this.Value<IHitComponentBase>().Value;
		}

		// Token: 0x060285A1 RID: 165281 RVA: 0x0058AFD0 File Offset: 0x005891D0
		public IDestructibleItem ValueAsIDestructibleItem()
		{
			return this.Value<IDestructibleItem>().Value;
		}

		// Token: 0x060285A2 RID: 165282 RVA: 0x0058AFEC File Offset: 0x005891EC
		public ITargetGearComponent ValueAsITargetGearComponent()
		{
			return this.Value<ITargetGearComponent>().Value;
		}

		// Token: 0x060285A3 RID: 165283 RVA: 0x0058B008 File Offset: 0x00589208
		public IProgressBarControlComponent ValueAsIProgressBarControlComponent()
		{
			return this.Value<IProgressBarControlComponent>().Value;
		}

		// Token: 0x060285A4 RID: 165284 RVA: 0x0058B024 File Offset: 0x00589224
		public IHitComponent ValueAsIHitComponent()
		{
			return this.Value<IHitComponent>().Value;
		}

		// Token: 0x060285A5 RID: 165285 RVA: 0x0058B040 File Offset: 0x00589240
		public ITargetGearGroupComponent ValueAsITargetGearGroupComponent()
		{
			return this.Value<ITargetGearGroupComponent>().Value;
		}

		// Token: 0x060285A6 RID: 165286 RVA: 0x0058B05C File Offset: 0x0058925C
		public INpcPerformComponent ValueAsINpcPerformComponent()
		{
			return this.Value<INpcPerformComponent>().Value;
		}

		// Token: 0x060285A7 RID: 165287 RVA: 0x0058B078 File Offset: 0x00589278
		public IInteractGearComponent ValueAsIInteractGearComponent()
		{
			return this.Value<IInteractGearComponent>().Value;
		}

		// Token: 0x060285A8 RID: 165288 RVA: 0x0058B094 File Offset: 0x00589294
		public ILiftComponent ValueAsILiftComponent()
		{
			return this.Value<ILiftComponent>().Value;
		}

		// Token: 0x060285A9 RID: 165289 RVA: 0x0058B0B0 File Offset: 0x005892B0
		public IConveyorBeltComponent ValueAsIConveyorBeltComponent()
		{
			return this.Value<IConveyorBeltComponent>().Value;
		}

		// Token: 0x060285AA RID: 165290 RVA: 0x0058B0CC File Offset: 0x005892CC
		public IFollowTrackComponent ValueAsIFollowTrackComponent()
		{
			return this.Value<IFollowTrackComponent>().Value;
		}

		// Token: 0x060285AB RID: 165291 RVA: 0x0058B0E8 File Offset: 0x005892E8
		public ISceneItemLifeCycleComponent ValueAsISceneItemLifeCycleComponent()
		{
			return this.Value<ISceneItemLifeCycleComponent>().Value;
		}

		// Token: 0x060285AC RID: 165292 RVA: 0x0058B104 File Offset: 0x00589304
		public IFightInteractComponent ValueAsIFightInteractComponent()
		{
			return this.Value<IFightInteractComponent>().Value;
		}

		// Token: 0x060285AD RID: 165293 RVA: 0x0058B120 File Offset: 0x00589320
		public IBubbleComponent ValueAsIBubbleComponent()
		{
			return this.Value<IBubbleComponent>().Value;
		}

		// Token: 0x060285AE RID: 165294 RVA: 0x0058B13C File Offset: 0x0058933C
		public INearbyTrackingComponent ValueAsINearbyTrackingComponent()
		{
			return this.Value<INearbyTrackingComponent>().Value;
		}

		// Token: 0x060285AF RID: 165295 RVA: 0x0058B158 File Offset: 0x00589358
		public IEntityPackageComponent ValueAsIEntityPackageComponent()
		{
			return this.Value<IEntityPackageComponent>().Value;
		}

		// Token: 0x060285B0 RID: 165296 RVA: 0x0058B174 File Offset: 0x00589374
		public ISkyboxComponent ValueAsISkyboxComponent()
		{
			return this.Value<ISkyboxComponent>().Value;
		}

		// Token: 0x060285B1 RID: 165297 RVA: 0x0058B190 File Offset: 0x00589390
		public IStateHintComponent ValueAsIStateHintComponent()
		{
			return this.Value<IStateHintComponent>().Value;
		}

		// Token: 0x060285B2 RID: 165298 RVA: 0x0058B1AC File Offset: 0x005893AC
		public IEntityVisibleComponent ValueAsIEntityVisibleComponent()
		{
			return this.Value<IEntityVisibleComponent>().Value;
		}

		// Token: 0x060285B3 RID: 165299 RVA: 0x0058B1C8 File Offset: 0x005893C8
		public ICombinedVisibleGroupComponent ValueAsICombinedVisibleGroupComponent()
		{
			return this.Value<ICombinedVisibleGroupComponent>().Value;
		}

		// Token: 0x060285B4 RID: 165300 RVA: 0x0058B1E4 File Offset: 0x005893E4
		public IWeaponComponent ValueAsIWeaponComponent()
		{
			return this.Value<IWeaponComponent>().Value;
		}

		// Token: 0x060285B5 RID: 165301 RVA: 0x0058B200 File Offset: 0x00589400
		public IDungeonEntryComponent ValueAsIDungeonEntryComponent()
		{
			return this.Value<IDungeonEntryComponent>().Value;
		}

		// Token: 0x060285B6 RID: 165302 RVA: 0x0058B21C File Offset: 0x0058941C
		public IResurrectionComponent ValueAsIResurrectionComponent()
		{
			return this.Value<IResurrectionComponent>().Value;
		}

		// Token: 0x060285B7 RID: 165303 RVA: 0x0058B238 File Offset: 0x00589438
		public IBuffProducerComponent ValueAsIBuffProducerComponent()
		{
			return this.Value<IBuffProducerComponent>().Value;
		}

		// Token: 0x060285B8 RID: 165304 RVA: 0x0058B254 File Offset: 0x00589454
		public IBuffConsumerComponent ValueAsIBuffConsumerComponent()
		{
			return this.Value<IBuffConsumerComponent>().Value;
		}

		// Token: 0x060285B9 RID: 165305 RVA: 0x0058B270 File Offset: 0x00589470
		public IGuideLineCreatorComponent ValueAsIGuideLineCreatorComponent()
		{
			return this.Value<IGuideLineCreatorComponent>().Value;
		}

		// Token: 0x060285BA RID: 165306 RVA: 0x0058B28C File Offset: 0x0058948C
		public IInteractAudioComponent ValueAsIInteractAudioComponent()
		{
			return this.Value<IInteractAudioComponent>().Value;
		}

		// Token: 0x060285BB RID: 165307 RVA: 0x0058B2A8 File Offset: 0x005894A8
		public IDropComponent ValueAsIDropComponent()
		{
			return this.Value<IDropComponent>().Value;
		}

		// Token: 0x060285BC RID: 165308 RVA: 0x0058B2C4 File Offset: 0x005894C4
		public IVisionItemComponent ValueAsIVisionItemComponent()
		{
			return this.Value<IVisionItemComponent>().Value;
		}

		// Token: 0x060285BD RID: 165309 RVA: 0x0058B2E0 File Offset: 0x005894E0
		public IAdviseItemComponent ValueAsIAdviseItemComponent()
		{
			return this.Value<IAdviseItemComponent>().Value;
		}

		// Token: 0x060285BE RID: 165310 RVA: 0x0058B2FC File Offset: 0x005894FC
		public IMonsterComponent ValueAsIMonsterComponent()
		{
			return this.Value<IMonsterComponent>().Value;
		}

		// Token: 0x060285BF RID: 165311 RVA: 0x0058B318 File Offset: 0x00589518
		public ICombatComponent ValueAsICombatComponent()
		{
			return this.Value<ICombatComponent>().Value;
		}

		// Token: 0x060285C0 RID: 165312 RVA: 0x0058B334 File Offset: 0x00589534
		public IEntityListComponent ValueAsIEntityListComponent()
		{
			return this.Value<IEntityListComponent>().Value;
		}

		// Token: 0x060285C1 RID: 165313 RVA: 0x0058B350 File Offset: 0x00589550
		public IAnimalComponent ValueAsIAnimalComponent()
		{
			return this.Value<IAnimalComponent>().Value;
		}

		// Token: 0x060285C2 RID: 165314 RVA: 0x0058B36C File Offset: 0x0058956C
		public ISceneItemMovementComponent ValueAsISceneItemMovementComponent()
		{
			return this.Value<ISceneItemMovementComponent>().Value;
		}

		// Token: 0x060285C3 RID: 165315 RVA: 0x0058B388 File Offset: 0x00589588
		public IRangeComponent ValueAsIRangeComponent()
		{
			return this.Value<IRangeComponent>().Value;
		}

		// Token: 0x060285C4 RID: 165316 RVA: 0x0058B3A4 File Offset: 0x005895A4
		public IExtraRangeComponent ValueAsIExtraRangeComponent()
		{
			return this.Value<IExtraRangeComponent>().Value;
		}

		// Token: 0x060285C5 RID: 165317 RVA: 0x0058B3C0 File Offset: 0x005895C0
		public ITimelineTrackControlComponent ValueAsITimelineTrackControlComponent()
		{
			return this.Value<ITimelineTrackControlComponent>().Value;
		}

		// Token: 0x060285C6 RID: 165318 RVA: 0x0058B3DC File Offset: 0x005895DC
		public ISplineComponent ValueAsISplineComponent()
		{
			return this.Value<ISplineComponent>().Value;
		}

		// Token: 0x060285C7 RID: 165319 RVA: 0x0058B3F8 File Offset: 0x005895F8
		public IAirWallSpawnerComponent ValueAsIAirWallSpawnerComponent()
		{
			return this.Value<IAirWallSpawnerComponent>().Value;
		}

		// Token: 0x060285C8 RID: 165320 RVA: 0x0058B414 File Offset: 0x00589614
		public ISceneActorRefComponent ValueAsISceneActorRefComponent()
		{
			return this.Value<ISceneActorRefComponent>().Value;
		}

		// Token: 0x060285C9 RID: 165321 RVA: 0x0058B430 File Offset: 0x00589630
		public ISceneBulletComponent ValueAsISceneBulletComponent()
		{
			return this.Value<ISceneBulletComponent>().Value;
		}

		// Token: 0x060285CA RID: 165322 RVA: 0x0058B44C File Offset: 0x0058964C
		public ITurntableControlComponent ValueAsITurntableControlComponent()
		{
			return this.Value<ITurntableControlComponent>().Value;
		}

		// Token: 0x060285CB RID: 165323 RVA: 0x0058B468 File Offset: 0x00589668
		public IConditionListenerComponent ValueAsIConditionListenerComponent()
		{
			return this.Value<IConditionListenerComponent>().Value;
		}

		// Token: 0x060285CC RID: 165324 RVA: 0x0058B484 File Offset: 0x00589684
		public IAttachTargetComponent ValueAsIAttachTargetComponent()
		{
			return this.Value<IAttachTargetComponent>().Value;
		}

		// Token: 0x060285CD RID: 165325 RVA: 0x0058B4A0 File Offset: 0x005896A0
		public IReboundComponent ValueAsIReboundComponent()
		{
			return this.Value<IReboundComponent>().Value;
		}

		// Token: 0x060285CE RID: 165326 RVA: 0x0058B4BC File Offset: 0x005896BC
		public IJigsawItem ValueAsIJigsawItem()
		{
			return this.Value<IJigsawItem>().Value;
		}

		// Token: 0x060285CF RID: 165327 RVA: 0x0058B4D8 File Offset: 0x005896D8
		public IJigsawFoundation ValueAsIJigsawFoundation()
		{
			return this.Value<IJigsawFoundation>().Value;
		}

		// Token: 0x060285D0 RID: 165328 RVA: 0x0058B4F4 File Offset: 0x005896F4
		public ILevelAIComponent ValueAsILevelAIComponent()
		{
			return this.Value<ILevelAIComponent>().Value;
		}

		// Token: 0x060285D1 RID: 165329 RVA: 0x0058B510 File Offset: 0x00589710
		public ILevitateMagnetComponent ValueAsILevitateMagnetComponent()
		{
			return this.Value<ILevitateMagnetComponent>().Value;
		}

		// Token: 0x060285D2 RID: 165330 RVA: 0x0058B52C File Offset: 0x0058972C
		public IPhotoTargetComponent ValueAsIPhotoTargetComponent()
		{
			return this.Value<IPhotoTargetComponent>().Value;
		}

		// Token: 0x060285D3 RID: 165331 RVA: 0x0058B548 File Offset: 0x00589748
		public IAiAlertNotifyComponent ValueAsIAiAlertNotifyComponent()
		{
			return this.Value<IAiAlertNotifyComponent>().Value;
		}

		// Token: 0x060285D4 RID: 165332 RVA: 0x0058B564 File Offset: 0x00589764
		public IMonsterGachaItemComponent ValueAsIMonsterGachaItemComponent()
		{
			return this.Value<IMonsterGachaItemComponent>().Value;
		}

		// Token: 0x060285D5 RID: 165333 RVA: 0x0058B580 File Offset: 0x00589780
		public IMonsterGachaBaseComponent ValueAsIMonsterGachaBaseComponent()
		{
			return this.Value<IMonsterGachaBaseComponent>().Value;
		}

		// Token: 0x060285D6 RID: 165334 RVA: 0x0058B59C File Offset: 0x0058979C
		public IDynamicTeleportComponent ValueAsIDynamicTeleportComponent()
		{
			return this.Value<IDynamicTeleportComponent>().Value;
		}

		// Token: 0x060285D7 RID: 165335 RVA: 0x0058B5B8 File Offset: 0x005897B8
		public IExploreSkillInteractComponent ValueAsIExploreSkillInteractComponent()
		{
			return this.Value<IExploreSkillInteractComponent>().Value;
		}

		// Token: 0x060285D8 RID: 165336 RVA: 0x0058B5D4 File Offset: 0x005897D4
		public IExploreSkillInteractGroupComponent ValueAsIExploreSkillInteractGroupComponent()
		{
			return this.Value<IExploreSkillInteractGroupComponent>().Value;
		}

		// Token: 0x060285D9 RID: 165337 RVA: 0x0058B5F0 File Offset: 0x005897F0
		public IFanComponent ValueAsIFanComponent()
		{
			return this.Value<IFanComponent>().Value;
		}

		// Token: 0x060285DA RID: 165338 RVA: 0x0058B60C File Offset: 0x0058980C
		public IPasserbyNpcSpawnComponent ValueAsIPasserbyNpcSpawnComponent()
		{
			return this.Value<IPasserbyNpcSpawnComponent>().Value;
		}

		// Token: 0x060285DB RID: 165339 RVA: 0x0058B628 File Offset: 0x00589828
		public IModelComponent ValueAsIModelComponent()
		{
			return this.Value<IModelComponent>().Value;
		}

		// Token: 0x060285DC RID: 165340 RVA: 0x0058B644 File Offset: 0x00589844
		public IEntityBundleComponent ValueAsIEntityBundleComponent()
		{
			return this.Value<IEntityBundleComponent>().Value;
		}

		// Token: 0x060285DD RID: 165341 RVA: 0x0058B660 File Offset: 0x00589860
		public IBeamCastComponent ValueAsIBeamCastComponent()
		{
			return this.Value<IBeamCastComponent>().Value;
		}

		// Token: 0x060285DE RID: 165342 RVA: 0x0058B67C File Offset: 0x0058987C
		public IBeamReceiveComponent ValueAsIBeamReceiveComponent()
		{
			return this.Value<IBeamReceiveComponent>().Value;
		}

		// Token: 0x060285DF RID: 165343 RVA: 0x0058B698 File Offset: 0x00589898
		public ITimeStopComponent ValueAsITimeStopComponent()
		{
			return this.Value<ITimeStopComponent>().Value;
		}

		// Token: 0x060285E0 RID: 165344 RVA: 0x0058B6B4 File Offset: 0x005898B4
		public IPortalComponent ValueAsIPortalComponent()
		{
			return this.Value<IPortalComponent>().Value;
		}

		// Token: 0x060285E1 RID: 165345 RVA: 0x0058B6D0 File Offset: 0x005898D0
		public IDynamicPortalCreatorComponent ValueAsIDynamicPortalCreatorComponent()
		{
			return this.Value<IDynamicPortalCreatorComponent>().Value;
		}

		// Token: 0x060285E2 RID: 165346 RVA: 0x0058B6EC File Offset: 0x005898EC
		public INoRenderPortalComponent ValueAsINoRenderPortalComponent()
		{
			return this.Value<INoRenderPortalComponent>().Value;
		}

		// Token: 0x060285E3 RID: 165347 RVA: 0x0058B708 File Offset: 0x00589908
		public IEffectAreaComponent ValueAsIEffectAreaComponent()
		{
			return this.Value<IEffectAreaComponent>().Value;
		}

		// Token: 0x060285E4 RID: 165348 RVA: 0x0058B724 File Offset: 0x00589924
		public IPhysicsConstraintComponent ValueAsIPhysicsConstraintComponent()
		{
			return this.Value<IPhysicsConstraintComponent>().Value;
		}

		// Token: 0x060285E5 RID: 165349 RVA: 0x0058B740 File Offset: 0x00589940
		public IFollowDecorationComponent ValueAsIFollowDecorationComponent()
		{
			return this.Value<IFollowDecorationComponent>().Value;
		}

		// Token: 0x060285E6 RID: 165350 RVA: 0x0058B75C File Offset: 0x0058995C
		public IFollowShooterComponent ValueAsIFollowShooterComponent()
		{
			return this.Value<IFollowShooterComponent>().Value;
		}

		// Token: 0x060285E7 RID: 165351 RVA: 0x0058B778 File Offset: 0x00589978
		public IConnectorComponent ValueAsIConnectorComponent()
		{
			return this.Value<IConnectorComponent>().Value;
		}

		// Token: 0x060285E8 RID: 165352 RVA: 0x0058B794 File Offset: 0x00589994
		public ISceneTextComponent ValueAsISceneTextComponent()
		{
			return this.Value<ISceneTextComponent>().Value;
		}

		// Token: 0x060285E9 RID: 165353 RVA: 0x0058B7B0 File Offset: 0x005899B0
		public INavMeshComponent ValueAsINavMeshComponent()
		{
			return this.Value<INavMeshComponent>().Value;
		}

		// Token: 0x060285EA RID: 165354 RVA: 0x0058B7CC File Offset: 0x005899CC
		public ICharacterConnectorComponent ValueAsICharacterConnectorComponent()
		{
			return this.Value<ICharacterConnectorComponent>().Value;
		}

		// Token: 0x060285EB RID: 165355 RVA: 0x0058B7E8 File Offset: 0x005899E8
		public IAiGearStrategyComponent ValueAsIAiGearStrategyComponent()
		{
			return this.Value<IAiGearStrategyComponent>().Value;
		}

		// Token: 0x060285EC RID: 165356 RVA: 0x0058B804 File Offset: 0x00589A04
		public IPickInteractComponent ValueAsIPickInteractComponent()
		{
			return this.Value<IPickInteractComponent>().Value;
		}

		// Token: 0x060285ED RID: 165357 RVA: 0x0058B820 File Offset: 0x00589A20
		public IChessmanComponent ValueAsIChessmanComponent()
		{
			return this.Value<IChessmanComponent>().Value;
		}

		// Token: 0x060285EE RID: 165358 RVA: 0x0058B83C File Offset: 0x00589A3C
		public IClientTriggerComponent ValueAsIClientTriggerComponent()
		{
			return this.Value<IClientTriggerComponent>().Value;
		}

		// Token: 0x060285EF RID: 165359 RVA: 0x0058B858 File Offset: 0x00589A58
		public ILocationSafetyComponent ValueAsILocationSafetyComponent()
		{
			return this.Value<ILocationSafetyComponent>().Value;
		}

		// Token: 0x060285F0 RID: 165360 RVA: 0x0058B874 File Offset: 0x00589A74
		public IBatchBulletCasterComponent ValueAsIBatchBulletCasterComponent()
		{
			return this.Value<IBatchBulletCasterComponent>().Value;
		}

		// Token: 0x060285F1 RID: 165361 RVA: 0x0058B890 File Offset: 0x00589A90
		public IVehicleComponent ValueAsIVehicleComponent()
		{
			return this.Value<IVehicleComponent>().Value;
		}

		// Token: 0x060285F2 RID: 165362 RVA: 0x0058B8AC File Offset: 0x00589AAC
		public IEnrichmentAreaComponent ValueAsIEnrichmentAreaComponent()
		{
			return this.Value<IEnrichmentAreaComponent>().Value;
		}

		// Token: 0x060285F3 RID: 165363 RVA: 0x0058B8C8 File Offset: 0x00589AC8
		public IMonitorComponent ValueAsIMonitorComponent()
		{
			return this.Value<IMonitorComponent>().Value;
		}

		// Token: 0x060285F4 RID: 165364 RVA: 0x0058B8E4 File Offset: 0x00589AE4
		public IGroupAiComponent ValueAsIGroupAiComponent()
		{
			return this.Value<IGroupAiComponent>().Value;
		}

		// Token: 0x060285F5 RID: 165365 RVA: 0x0058B900 File Offset: 0x00589B00
		public IInhalationAbilityComponent ValueAsIInhalationAbilityComponent()
		{
			return this.Value<IInhalationAbilityComponent>().Value;
		}

		// Token: 0x060285F6 RID: 165366 RVA: 0x0058B91C File Offset: 0x00589B1C
		public IInhaledItemComponent ValueAsIInhaledItemComponent()
		{
			return this.Value<IInhaledItemComponent>().Value;
		}

		// Token: 0x060285F7 RID: 165367 RVA: 0x0058B938 File Offset: 0x00589B38
		public IAirPassageComponent ValueAsIAirPassageComponent()
		{
			return this.Value<IAirPassageComponent>().Value;
		}

		// Token: 0x060285F8 RID: 165368 RVA: 0x0058B954 File Offset: 0x00589B54
		public IRenderSpecifiedRangeComponent ValueAsIRenderSpecifiedRangeComponent()
		{
			return this.Value<IRenderSpecifiedRangeComponent>().Value;
		}

		// Token: 0x060285F9 RID: 165369 RVA: 0x0058B970 File Offset: 0x00589B70
		public ILevelPrefabPerformComponent ValueAsILevelPrefabPerformComponent()
		{
			return this.Value<ILevelPrefabPerformComponent>().Value;
		}

		// Token: 0x060285FA RID: 165370 RVA: 0x0058B98C File Offset: 0x00589B8C
		public ISceneItemAiComponent ValueAsISceneItemAiComponent()
		{
			return this.Value<ISceneItemAiComponent>().Value;
		}

		// Token: 0x060285FB RID: 165371 RVA: 0x0058B9A8 File Offset: 0x00589BA8
		public IGravityFlipComponent ValueAsIGravityFlipComponent()
		{
			return this.Value<IGravityFlipComponent>().Value;
		}

		// Token: 0x060285FC RID: 165372 RVA: 0x0058B9C4 File Offset: 0x00589BC4
		public ILevelSequenceFrameEventComponent ValueAsILevelSequenceFrameEventComponent()
		{
			return this.Value<ILevelSequenceFrameEventComponent>().Value;
		}

		// Token: 0x060285FD RID: 165373 RVA: 0x0058B9E0 File Offset: 0x00589BE0
		public ILevelQteComponent ValueAsILevelQteComponent()
		{
			return this.Value<ILevelQteComponent>().Value;
		}

		// Token: 0x060285FE RID: 165374 RVA: 0x0058B9FC File Offset: 0x00589BFC
		public IWalkingPatternComponent ValueAsIWalkingPatternComponent()
		{
			return this.Value<IWalkingPatternComponent>().Value;
		}

		// Token: 0x060285FF RID: 165375 RVA: 0x0058BA18 File Offset: 0x00589C18
		public ILifePointCenterComponent ValueAsILifePointCenterComponent()
		{
			return this.Value<ILifePointCenterComponent>().Value;
		}

		// Token: 0x06028600 RID: 165376 RVA: 0x0058BA34 File Offset: 0x00589C34
		public IHackManagementComponent ValueAsIHackManagementComponent()
		{
			return this.Value<IHackManagementComponent>().Value;
		}

		// Token: 0x06028601 RID: 165377 RVA: 0x0058BA50 File Offset: 0x00589C50
		public IClientConditionListenerComponent ValueAsIClientConditionListenerComponent()
		{
			return this.Value<IClientConditionListenerComponent>().Value;
		}

		// Token: 0x06028602 RID: 165378 RVA: 0x0058BA6C File Offset: 0x00589C6C
		public ITemplateEntitySpawnerComponent ValueAsITemplateEntitySpawnerComponent()
		{
			return this.Value<ITemplateEntitySpawnerComponent>().Value;
		}

		// Token: 0x06028603 RID: 165379 RVA: 0x0058BA88 File Offset: 0x00589C88
		public IWindSourceComponent ValueAsIWindSourceComponent()
		{
			return this.Value<IWindSourceComponent>().Value;
		}

		// Token: 0x06028604 RID: 165380 RVA: 0x0058BAA4 File Offset: 0x00589CA4
		public ISlideRailComponent ValueAsISlideRailComponent()
		{
			return this.Value<ISlideRailComponent>().Value;
		}

		// Token: 0x06028605 RID: 165381 RVA: 0x0058BAC0 File Offset: 0x00589CC0
		public ISlidePerformComponent ValueAsISlidePerformComponent()
		{
			return this.Value<ISlidePerformComponent>().Value;
		}

		// Token: 0x06028606 RID: 165382 RVA: 0x0058BADC File Offset: 0x00589CDC
		public IRollBlockComponent ValueAsIRollBlockComponent()
		{
			return this.Value<IRollBlockComponent>().Value;
		}

		// Token: 0x06028607 RID: 165383 RVA: 0x0058BAF8 File Offset: 0x00589CF8
		public IRollBlockFloorComponent ValueAsIRollBlockFloorComponent()
		{
			return this.Value<IRollBlockFloorComponent>().Value;
		}

		// Token: 0x06028608 RID: 165384 RVA: 0x0058BB14 File Offset: 0x00589D14
		public IRollBlockItemComponent ValueAsIRollBlockItemComponent()
		{
			return this.Value<IRollBlockItemComponent>().Value;
		}

		// Token: 0x06028609 RID: 165385 RVA: 0x0058BB30 File Offset: 0x00589D30
		public ICurveControlComponent ValueAsICurveControlComponent()
		{
			return this.Value<ICurveControlComponent>().Value;
		}

		// Token: 0x0602860A RID: 165386 RVA: 0x0058BB4C File Offset: 0x00589D4C
		public ISimpleCombatComponent ValueAsISimpleCombatComponent()
		{
			return this.Value<ISimpleCombatComponent>().Value;
		}

		// Token: 0x0602860B RID: 165387 RVA: 0x0058BB68 File Offset: 0x00589D68
		public IGridObjectComponent ValueAsIGridObjectComponent()
		{
			return this.Value<IGridObjectComponent>().Value;
		}

		// Token: 0x0602860C RID: 165388 RVA: 0x0058BB84 File Offset: 0x00589D84
		public IGodKingFrequencyControllerComponent ValueAsIGodKingFrequencyControllerComponent()
		{
			return this.Value<IGodKingFrequencyControllerComponent>().Value;
		}

		// Token: 0x0602860D RID: 165389 RVA: 0x0058BBA0 File Offset: 0x00589DA0
		public IPerformanceOptimizationComponent ValueAsIPerformanceOptimizationComponent()
		{
			return this.Value<IPerformanceOptimizationComponent>().Value;
		}

		// Token: 0x0602860E RID: 165390 RVA: 0x0058BBBC File Offset: 0x00589DBC
		public ISceneItemEventListenerComponent ValueAsISceneItemEventListenerComponent()
		{
			return this.Value<ISceneItemEventListenerComponent>().Value;
		}

		// Token: 0x0602860F RID: 165391 RVA: 0x0058BBD8 File Offset: 0x00589DD8
		public IDynamicSpawnMonsterPointComponent ValueAsIDynamicSpawnMonsterPointComponent()
		{
			return this.Value<IDynamicSpawnMonsterPointComponent>().Value;
		}

		// Token: 0x06028610 RID: 165392 RVA: 0x0058BBF4 File Offset: 0x00589DF4
		public IDynamicSpawnMonsterComponent ValueAsIDynamicSpawnMonsterComponent()
		{
			return this.Value<IDynamicSpawnMonsterComponent>().Value;
		}

		// Token: 0x06028611 RID: 165393 RVA: 0x0058BC10 File Offset: 0x00589E10
		public ISunSpiritCollectComponent ValueAsISunSpiritCollectComponent()
		{
			return this.Value<ISunSpiritCollectComponent>().Value;
		}

		// Token: 0x06028612 RID: 165394 RVA: 0x0058BC2C File Offset: 0x00589E2C
		public ISunSpiritLauncherComponent ValueAsISunSpiritLauncherComponent()
		{
			return this.Value<ISunSpiritLauncherComponent>().Value;
		}

		// Token: 0x06028613 RID: 165395 RVA: 0x0058BC48 File Offset: 0x00589E48
		public ISunSpiritGearComponent ValueAsISunSpiritGearComponent()
		{
			return this.Value<ISunSpiritGearComponent>().Value;
		}

		// Token: 0x06028614 RID: 165396 RVA: 0x0058BC64 File Offset: 0x00589E64
		public IMotorSlideComponent ValueAsIMotorSlideComponent()
		{
			return this.Value<IMotorSlideComponent>().Value;
		}

		// Token: 0x06028615 RID: 165397 RVA: 0x0058BC80 File Offset: 0x00589E80
		public IProceduralVisualComponent ValueAsIProceduralVisualComponent()
		{
			return this.Value<IProceduralVisualComponent>().Value;
		}

		// Token: 0x06028616 RID: 165398 RVA: 0x0058BC9C File Offset: 0x00589E9C
		public IRoadNetworkNavigationComponent ValueAsIRoadNetworkNavigationComponent()
		{
			return this.Value<IRoadNetworkNavigationComponent>().Value;
		}

		// Token: 0x06028617 RID: 165399 RVA: 0x0058BCB8 File Offset: 0x00589EB8
		public IFurnitureSlotComponent ValueAsIFurnitureSlotComponent()
		{
			return this.Value<IFurnitureSlotComponent>().Value;
		}

		// Token: 0x06028618 RID: 165400 RVA: 0x0058BCD4 File Offset: 0x00589ED4
		public IVisionDisplayComponent ValueAsIVisionDisplayComponent()
		{
			return this.Value<IVisionDisplayComponent>().Value;
		}

		// Token: 0x06028619 RID: 165401 RVA: 0x0058BCF0 File Offset: 0x00589EF0
		public ISystemModuleDataSyncComponent ValueAsISystemModuleDataSyncComponent()
		{
			return this.Value<ISystemModuleDataSyncComponent>().Value;
		}

		// Token: 0x0602861A RID: 165402 RVA: 0x0058BD0C File Offset: 0x00589F0C
		public IExhibitComponent ValueAsIExhibitComponent()
		{
			return this.Value<IExhibitComponent>().Value;
		}

		// Token: 0x0602861B RID: 165403 RVA: 0x0058BD28 File Offset: 0x00589F28
		public ITimeScheduleComponent ValueAsITimeScheduleComponent()
		{
			return this.Value<ITimeScheduleComponent>().Value;
		}

		// Token: 0x0602861C RID: 165404 RVA: 0x0058BD44 File Offset: 0x00589F44
		public IProjectorComponent ValueAsIProjectorComponent()
		{
			return this.Value<IProjectorComponent>().Value;
		}

		// Token: 0x0602861D RID: 165405 RVA: 0x0058BD60 File Offset: 0x00589F60
		public IProceduralMaterialComponent ValueAsIProceduralMaterialComponent()
		{
			return this.Value<IProceduralMaterialComponent>().Value;
		}

		// Token: 0x0602861E RID: 165406 RVA: 0x0058BD7C File Offset: 0x00589F7C
		public IGameplayDataPersistenceComponent ValueAsIGameplayDataPersistenceComponent()
		{
			return this.Value<IGameplayDataPersistenceComponent>().Value;
		}

		// Token: 0x0602861F RID: 165407 RVA: 0x0058BD98 File Offset: 0x00589F98
		public IFlowerPollutionComponent ValueAsIFlowerPollutionComponent()
		{
			return this.Value<IFlowerPollutionComponent>().Value;
		}

		// Token: 0x06028620 RID: 165408 RVA: 0x0058BDB4 File Offset: 0x00589FB4
		public IQuickHackComponent ValueAsIQuickHackComponent()
		{
			return this.Value<IQuickHackComponent>().Value;
		}

		// Token: 0x06028621 RID: 165409 RVA: 0x0058BDD0 File Offset: 0x00589FD0
		public IDollGrabMachineComponent ValueAsIDollGrabMachineComponent()
		{
			return this.Value<IDollGrabMachineComponent>().Value;
		}

		// Token: 0x06028622 RID: 165410 RVA: 0x0058BDEC File Offset: 0x00589FEC
		public IDollGrabShowcaseComponent ValueAsIDollGrabShowcaseComponent()
		{
			return this.Value<IDollGrabShowcaseComponent>().Value;
		}

		// Token: 0x06028623 RID: 165411 RVA: 0x0058BE08 File Offset: 0x0058A008
		public IWuWaGoComponent ValueAsIWuWaGoComponent()
		{
			return this.Value<IWuWaGoComponent>().Value;
		}

		// Token: 0x06028624 RID: 165412 RVA: 0x0058BE24 File Offset: 0x0058A024
		public IDragActorPlayComponent ValueAsIDragActorPlayComponent()
		{
			return this.Value<IDragActorPlayComponent>().Value;
		}

		// Token: 0x06028625 RID: 165413 RVA: 0x0058BE40 File Offset: 0x0058A040
		public IPathDrivenActorSpawnerComponent ValueAsIPathDrivenActorSpawnerComponent()
		{
			return this.Value<IPathDrivenActorSpawnerComponent>().Value;
		}

		// Token: 0x06028626 RID: 165414 RVA: 0x0058BE5C File Offset: 0x0058A05C
		public IElementalHolderComponent ValueAsIElementalHolderComponent()
		{
			return this.Value<IElementalHolderComponent>().Value;
		}

		// Token: 0x06028627 RID: 165415 RVA: 0x0058BE78 File Offset: 0x0058A078
		public IElementalEffectComponent ValueAsIElementalEffectComponent()
		{
			return this.Value<IElementalEffectComponent>().Value;
		}

		// Token: 0x06028628 RID: 165416 RVA: 0x0058BE94 File Offset: 0x0058A094
		public IElementalBoxFoundationComponent ValueAsIElementalBoxFoundationComponent()
		{
			return this.Value<IElementalBoxFoundationComponent>().Value;
		}

		// Token: 0x06028629 RID: 165417 RVA: 0x0058BEB0 File Offset: 0x0058A0B0
		public IElementalWellComponent ValueAsIElementalWellComponent()
		{
			return this.Value<IElementalWellComponent>().Value;
		}

		// Token: 0x0602862A RID: 165418 RVA: 0x0058BECC File Offset: 0x0058A0CC
		public IStreamingSourceTriggerPointComponent ValueAsIStreamingSourceTriggerPointComponent()
		{
			return this.Value<IStreamingSourceTriggerPointComponent>().Value;
		}

		// Token: 0x0602862B RID: 165419 RVA: 0x0058BEE8 File Offset: 0x0058A0E8
		public IGraph3dComponent ValueAsIGraph3dComponent()
		{
			return this.Value<IGraph3dComponent>().Value;
		}

		// Token: 0x0602862C RID: 165420 RVA: 0x0058BF04 File Offset: 0x0058A104
		public IGraph3dEffectComponent ValueAsIGraph3dEffectComponent()
		{
			return this.Value<IGraph3dEffectComponent>().Value;
		}

		// Token: 0x0602862D RID: 165421 RVA: 0x0058BF20 File Offset: 0x0058A120
		public INoiseRemovalComponent ValueAsINoiseRemovalComponent()
		{
			return this.Value<INoiseRemovalComponent>().Value;
		}

		// Token: 0x0602862E RID: 165422 RVA: 0x0058BF3B File Offset: 0x0058A13B
		public static Offset<TComponentData> CreateTComponentData(FlatBufferBuilder builder, StringOffset keyOffset = default(StringOffset), IComponentBase_Union value_type = IComponentBase_Union.NONE, int valueOffset = 0)
		{
			builder.StartTable(3);
			TComponentData.AddValue(builder, valueOffset);
			TComponentData.AddKey(builder, keyOffset);
			TComponentData.AddValueType(builder, value_type);
			return TComponentData.EndTComponentData(builder);
		}

		// Token: 0x0602862F RID: 165423 RVA: 0x0058BF5F File Offset: 0x0058A15F
		public static void StartTComponentData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028630 RID: 165424 RVA: 0x0058BF68 File Offset: 0x0058A168
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x06028631 RID: 165425 RVA: 0x0058BF78 File Offset: 0x0058A178
		public static void AddValueType(FlatBufferBuilder builder, IComponentBase_Union valueType)
		{
			builder.AddByte(1, (byte)valueType, 0);
		}

		// Token: 0x06028632 RID: 165426 RVA: 0x0058BF83 File Offset: 0x0058A183
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(2, valueOffset, 0);
		}

		// Token: 0x06028633 RID: 165427 RVA: 0x0058BF8E File Offset: 0x0058A18E
		public static Offset<TComponentData> EndTComponentData(FlatBufferBuilder builder)
		{
			return new Offset<TComponentData>(builder.EndTable());
		}

		// Token: 0x06028634 RID: 165428 RVA: 0x0058BF9C File Offset: 0x0058A19C
		public TComponentDataT UnPack()
		{
			TComponentDataT tcomponentDataT = new TComponentDataT();
			this.UnPackTo(tcomponentDataT);
			return tcomponentDataT;
		}

		// Token: 0x06028635 RID: 165429 RVA: 0x0058BFB8 File Offset: 0x0058A1B8
		public void UnPackTo(TComponentDataT _o)
		{
			_o.Key = this.Key;
			_o.Value = new IComponentBase_UnionUnion();
			_o.Value.Type = this.ValueType;
			switch (this.ValueType)
			{
			case IComponentBase_Union.IComponentBase:
				_o.Value.Value = ((this.Value<IComponentBase>() != null) ? this.Value<IComponentBase>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IUnUseComponent:
				_o.Value.Value = ((this.Value<IUnUseComponent>() != null) ? this.Value<IUnUseComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IInteractiveComponent:
				_o.Value.Value = ((this.Value<IInteractiveComponent>() != null) ? this.Value<IInteractiveComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISwitcherComponent:
				_o.Value.Value = ((this.Value<ISwitcherComponent>() != null) ? this.Value<ISwitcherComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRotatorComponent:
				_o.Value.Value = ((this.Value<IRotatorComponent>() != null) ? this.Value<IRotatorComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IBehaviorFlowComponent:
				_o.Value.Value = ((this.Value<IBehaviorFlowComponent>() != null) ? this.Value<IBehaviorFlowComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IFlowComponent:
				_o.Value.Value = ((this.Value<IFlowComponent>() != null) ? this.Value<IFlowComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITriggerUe5Component:
				_o.Value.Value = ((this.Value<ITriggerUe5Component>() != null) ? this.Value<ITriggerUe5Component>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IMoveComponent:
				_o.Value.Value = ((this.Value<IMoveComponent>() != null) ? this.Value<IMoveComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IActorStateComponent:
				_o.Value.Value = ((this.Value<IActorStateComponent>() != null) ? this.Value<IActorStateComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ICalculateComponent:
				_o.Value.Value = ((this.Value<ICalculateComponent>() != null) ? this.Value<ICalculateComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRefreshGroup:
				_o.Value.Value = ((this.Value<IRefreshGroup>() != null) ? this.Value<IRefreshGroup>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRefreshSingleComponent:
				_o.Value.Value = ((this.Value<IRefreshSingleComponent>() != null) ? this.Value<IRefreshSingleComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRotatorComponent2:
				_o.Value.Value = ((this.Value<IRotatorComponent2>() != null) ? this.Value<IRotatorComponent2>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISphereFactoryComponent:
				_o.Value.Value = ((this.Value<ISphereFactoryComponent>() != null) ? this.Value<ISphereFactoryComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISpringComponent:
				_o.Value.Value = ((this.Value<ISpringComponent>() != null) ? this.Value<ISpringComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITrampleUe5Component:
				_o.Value.Value = ((this.Value<ITrampleUe5Component>() != null) ? this.Value<ITrampleUe5Component>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IUndergroundComponent:
				_o.Value.Value = ((this.Value<IUndergroundComponent>() != null) ? this.Value<IUndergroundComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGrabComponent:
				_o.Value.Value = ((this.Value<IGrabComponent>() != null) ? this.Value<IGrabComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IInteractComponent:
				_o.Value.Value = ((this.Value<IInteractComponent>() != null) ? this.Value<IInteractComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IVarComponent:
				_o.Value.Value = ((this.Value<IVarComponent>() != null) ? this.Value<IVarComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPatrol:
				_o.Value.Value = ((this.Value<IPatrol>() != null) ? this.Value<IPatrol>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAiComponent:
				_o.Value.Value = ((this.Value<IAiComponent>() != null) ? this.Value<IAiComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAttributeComponent:
				_o.Value.Value = ((this.Value<IAttributeComponent>() != null) ? this.Value<IAttributeComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEditCustomAoiComponent:
				_o.Value.Value = ((this.Value<IEditCustomAoiComponent>() != null) ? this.Value<IEditCustomAoiComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IBaseInfoComponent:
				_o.Value.Value = ((this.Value<IBaseInfoComponent>() != null) ? this.Value<IBaseInfoComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRewardComponent:
				_o.Value.Value = ((this.Value<IRewardComponent>() != null) ? this.Value<IRewardComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDynamicEntityRewardComponent:
				_o.Value.Value = ((this.Value<IDynamicEntityRewardComponent>() != null) ? this.Value<IDynamicEntityRewardComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IIndependentSystemRewardComponent:
				_o.Value.Value = ((this.Value<IIndependentSystemRewardComponent>() != null) ? this.Value<IIndependentSystemRewardComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRefreshComponent:
				_o.Value.Value = ((this.Value<IRefreshComponent>() != null) ? this.Value<IRefreshComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRefreshGroupComponent:
				_o.Value.Value = ((this.Value<IRefreshGroupComponent>() != null) ? this.Value<IRefreshGroupComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityBatchRefreshComponent:
				_o.Value.Value = ((this.Value<IEntityBatchRefreshComponent>() != null) ? this.Value<IEntityBatchRefreshComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITreasureBoxComponent:
				_o.Value.Value = ((this.Value<ITreasureBoxComponent>() != null) ? this.Value<ITreasureBoxComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITriggerComponent:
				_o.Value.Value = ((this.Value<ITriggerComponent>() != null) ? this.Value<ITriggerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityStateComponent:
				_o.Value.Value = ((this.Value<IEntityStateComponent>() != null) ? this.Value<IEntityStateComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISceneItemAttributeComponent:
				_o.Value.Value = ((this.Value<ISceneItemAttributeComponent>() != null) ? this.Value<ISceneItemAttributeComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityAudioComponent:
				_o.Value.Value = ((this.Value<IEntityAudioComponent>() != null) ? this.Value<IEntityAudioComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityStateAudioComponent:
				_o.Value.Value = ((this.Value<IEntityStateAudioComponent>() != null) ? this.Value<IEntityStateAudioComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityCustomAudioComponent:
				_o.Value.Value = ((this.Value<IEntityCustomAudioComponent>() != null) ? this.Value<IEntityCustomAudioComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITrampleComponent:
				_o.Value.Value = ((this.Value<ITrampleComponent>() != null) ? this.Value<ITrampleComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityGroupComponent:
				_o.Value.Value = ((this.Value<IEntityGroupComponent>() != null) ? this.Value<IEntityGroupComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IHookLockPoint:
				_o.Value.Value = ((this.Value<IHookLockPoint>() != null) ? this.Value<IHookLockPoint>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRoleMotionInteractComponent:
				_o.Value.Value = ((this.Value<IRoleMotionInteractComponent>() != null) ? this.Value<IRoleMotionInteractComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IHookFetchComponent:
				_o.Value.Value = ((this.Value<IHookFetchComponent>() != null) ? this.Value<IHookFetchComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IItemFoundation:
				_o.Value.Value = ((this.Value<IItemFoundation>() != null) ? this.Value<IItemFoundation>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IResetEntitiesPosComponent:
				_o.Value.Value = ((this.Value<IResetEntitiesPosComponent>() != null) ? this.Value<IResetEntitiesPosComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IResetSelfPosComponent:
				_o.Value.Value = ((this.Value<IResetSelfPosComponent>() != null) ? this.Value<IResetSelfPosComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ICollectComponent:
				_o.Value.Value = ((this.Value<ICollectComponent>() != null) ? this.Value<ICollectComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITeleControl2:
				_o.Value.Value = ((this.Value<ITeleControl2>() != null) ? this.Value<ITeleControl2>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IItemFoundation2:
				_o.Value.Value = ((this.Value<IItemFoundation2>() != null) ? this.Value<IItemFoundation2>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPullingFoundation:
				_o.Value.Value = ((this.Value<IPullingFoundation>() != null) ? this.Value<IPullingFoundation>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILevelPlayComponent:
				_o.Value.Value = ((this.Value<ILevelPlayComponent>() != null) ? this.Value<ILevelPlayComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDynamicLevelPlayComponent:
				_o.Value.Value = ((this.Value<IDynamicLevelPlayComponent>() != null) ? this.Value<IDynamicLevelPlayComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IVisionComponent:
				_o.Value.Value = ((this.Value<IVisionComponent>() != null) ? this.Value<IVisionComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IVisionCaptureComponent:
				_o.Value.Value = ((this.Value<IVisionCaptureComponent>() != null) ? this.Value<IVisionCaptureComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAdsorbComponent:
				_o.Value.Value = ((this.Value<IAdsorbComponent>() != null) ? this.Value<IAdsorbComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITeleportComponent:
				_o.Value.Value = ((this.Value<ITeleportComponent>() != null) ? this.Value<ITeleportComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISpawnMonsterComponent:
				_o.Value.Value = ((this.Value<ISpawnMonsterComponent>() != null) ? this.Value<ISpawnMonsterComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IHitComponentBase:
				_o.Value.Value = ((this.Value<IHitComponentBase>() != null) ? this.Value<IHitComponentBase>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDestructibleItem:
				_o.Value.Value = ((this.Value<IDestructibleItem>() != null) ? this.Value<IDestructibleItem>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITargetGearComponent:
				_o.Value.Value = ((this.Value<ITargetGearComponent>() != null) ? this.Value<ITargetGearComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IProgressBarControlComponent:
				_o.Value.Value = ((this.Value<IProgressBarControlComponent>() != null) ? this.Value<IProgressBarControlComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IHitComponent:
				_o.Value.Value = ((this.Value<IHitComponent>() != null) ? this.Value<IHitComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITargetGearGroupComponent:
				_o.Value.Value = ((this.Value<ITargetGearGroupComponent>() != null) ? this.Value<ITargetGearGroupComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.INpcPerformComponent:
				_o.Value.Value = ((this.Value<INpcPerformComponent>() != null) ? this.Value<INpcPerformComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IInteractGearComponent:
				_o.Value.Value = ((this.Value<IInteractGearComponent>() != null) ? this.Value<IInteractGearComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILiftComponent:
				_o.Value.Value = ((this.Value<ILiftComponent>() != null) ? this.Value<ILiftComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IConveyorBeltComponent:
				_o.Value.Value = ((this.Value<IConveyorBeltComponent>() != null) ? this.Value<IConveyorBeltComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IFollowTrackComponent:
				_o.Value.Value = ((this.Value<IFollowTrackComponent>() != null) ? this.Value<IFollowTrackComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISceneItemLifeCycleComponent:
				_o.Value.Value = ((this.Value<ISceneItemLifeCycleComponent>() != null) ? this.Value<ISceneItemLifeCycleComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IFightInteractComponent:
				_o.Value.Value = ((this.Value<IFightInteractComponent>() != null) ? this.Value<IFightInteractComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IBubbleComponent:
				_o.Value.Value = ((this.Value<IBubbleComponent>() != null) ? this.Value<IBubbleComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.INearbyTrackingComponent:
				_o.Value.Value = ((this.Value<INearbyTrackingComponent>() != null) ? this.Value<INearbyTrackingComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityPackageComponent:
				_o.Value.Value = ((this.Value<IEntityPackageComponent>() != null) ? this.Value<IEntityPackageComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISkyboxComponent:
				_o.Value.Value = ((this.Value<ISkyboxComponent>() != null) ? this.Value<ISkyboxComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IStateHintComponent:
				_o.Value.Value = ((this.Value<IStateHintComponent>() != null) ? this.Value<IStateHintComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityVisibleComponent:
				_o.Value.Value = ((this.Value<IEntityVisibleComponent>() != null) ? this.Value<IEntityVisibleComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ICombinedVisibleGroupComponent:
				_o.Value.Value = ((this.Value<ICombinedVisibleGroupComponent>() != null) ? this.Value<ICombinedVisibleGroupComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IWeaponComponent:
				_o.Value.Value = ((this.Value<IWeaponComponent>() != null) ? this.Value<IWeaponComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDungeonEntryComponent:
				_o.Value.Value = ((this.Value<IDungeonEntryComponent>() != null) ? this.Value<IDungeonEntryComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IResurrectionComponent:
				_o.Value.Value = ((this.Value<IResurrectionComponent>() != null) ? this.Value<IResurrectionComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IBuffProducerComponent:
				_o.Value.Value = ((this.Value<IBuffProducerComponent>() != null) ? this.Value<IBuffProducerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IBuffConsumerComponent:
				_o.Value.Value = ((this.Value<IBuffConsumerComponent>() != null) ? this.Value<IBuffConsumerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGuideLineCreatorComponent:
				_o.Value.Value = ((this.Value<IGuideLineCreatorComponent>() != null) ? this.Value<IGuideLineCreatorComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IInteractAudioComponent:
				_o.Value.Value = ((this.Value<IInteractAudioComponent>() != null) ? this.Value<IInteractAudioComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDropComponent:
				_o.Value.Value = ((this.Value<IDropComponent>() != null) ? this.Value<IDropComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IVisionItemComponent:
				_o.Value.Value = ((this.Value<IVisionItemComponent>() != null) ? this.Value<IVisionItemComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAdviseItemComponent:
				_o.Value.Value = ((this.Value<IAdviseItemComponent>() != null) ? this.Value<IAdviseItemComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IMonsterComponent:
				_o.Value.Value = ((this.Value<IMonsterComponent>() != null) ? this.Value<IMonsterComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ICombatComponent:
				_o.Value.Value = ((this.Value<ICombatComponent>() != null) ? this.Value<ICombatComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityListComponent:
				_o.Value.Value = ((this.Value<IEntityListComponent>() != null) ? this.Value<IEntityListComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAnimalComponent:
				_o.Value.Value = ((this.Value<IAnimalComponent>() != null) ? this.Value<IAnimalComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISceneItemMovementComponent:
				_o.Value.Value = ((this.Value<ISceneItemMovementComponent>() != null) ? this.Value<ISceneItemMovementComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRangeComponent:
				_o.Value.Value = ((this.Value<IRangeComponent>() != null) ? this.Value<IRangeComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IExtraRangeComponent:
				_o.Value.Value = ((this.Value<IExtraRangeComponent>() != null) ? this.Value<IExtraRangeComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITimelineTrackControlComponent:
				_o.Value.Value = ((this.Value<ITimelineTrackControlComponent>() != null) ? this.Value<ITimelineTrackControlComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISplineComponent:
				_o.Value.Value = ((this.Value<ISplineComponent>() != null) ? this.Value<ISplineComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAirWallSpawnerComponent:
				_o.Value.Value = ((this.Value<IAirWallSpawnerComponent>() != null) ? this.Value<IAirWallSpawnerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISceneActorRefComponent:
				_o.Value.Value = ((this.Value<ISceneActorRefComponent>() != null) ? this.Value<ISceneActorRefComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISceneBulletComponent:
				_o.Value.Value = ((this.Value<ISceneBulletComponent>() != null) ? this.Value<ISceneBulletComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITurntableControlComponent:
				_o.Value.Value = ((this.Value<ITurntableControlComponent>() != null) ? this.Value<ITurntableControlComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IConditionListenerComponent:
				_o.Value.Value = ((this.Value<IConditionListenerComponent>() != null) ? this.Value<IConditionListenerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAttachTargetComponent:
				_o.Value.Value = ((this.Value<IAttachTargetComponent>() != null) ? this.Value<IAttachTargetComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IReboundComponent:
				_o.Value.Value = ((this.Value<IReboundComponent>() != null) ? this.Value<IReboundComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IJigsawItem:
				_o.Value.Value = ((this.Value<IJigsawItem>() != null) ? this.Value<IJigsawItem>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IJigsawFoundation:
				_o.Value.Value = ((this.Value<IJigsawFoundation>() != null) ? this.Value<IJigsawFoundation>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILevelAIComponent:
				_o.Value.Value = ((this.Value<ILevelAIComponent>() != null) ? this.Value<ILevelAIComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILevitateMagnetComponent:
				_o.Value.Value = ((this.Value<ILevitateMagnetComponent>() != null) ? this.Value<ILevitateMagnetComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPhotoTargetComponent:
				_o.Value.Value = ((this.Value<IPhotoTargetComponent>() != null) ? this.Value<IPhotoTargetComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAiAlertNotifyComponent:
				_o.Value.Value = ((this.Value<IAiAlertNotifyComponent>() != null) ? this.Value<IAiAlertNotifyComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IMonsterGachaItemComponent:
				_o.Value.Value = ((this.Value<IMonsterGachaItemComponent>() != null) ? this.Value<IMonsterGachaItemComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IMonsterGachaBaseComponent:
				_o.Value.Value = ((this.Value<IMonsterGachaBaseComponent>() != null) ? this.Value<IMonsterGachaBaseComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDynamicTeleportComponent:
				_o.Value.Value = ((this.Value<IDynamicTeleportComponent>() != null) ? this.Value<IDynamicTeleportComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IExploreSkillInteractComponent:
				_o.Value.Value = ((this.Value<IExploreSkillInteractComponent>() != null) ? this.Value<IExploreSkillInteractComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IExploreSkillInteractGroupComponent:
				_o.Value.Value = ((this.Value<IExploreSkillInteractGroupComponent>() != null) ? this.Value<IExploreSkillInteractGroupComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IFanComponent:
				_o.Value.Value = ((this.Value<IFanComponent>() != null) ? this.Value<IFanComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPasserbyNpcSpawnComponent:
				_o.Value.Value = ((this.Value<IPasserbyNpcSpawnComponent>() != null) ? this.Value<IPasserbyNpcSpawnComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IModelComponent:
				_o.Value.Value = ((this.Value<IModelComponent>() != null) ? this.Value<IModelComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEntityBundleComponent:
				_o.Value.Value = ((this.Value<IEntityBundleComponent>() != null) ? this.Value<IEntityBundleComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IBeamCastComponent:
				_o.Value.Value = ((this.Value<IBeamCastComponent>() != null) ? this.Value<IBeamCastComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IBeamReceiveComponent:
				_o.Value.Value = ((this.Value<IBeamReceiveComponent>() != null) ? this.Value<IBeamReceiveComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITimeStopComponent:
				_o.Value.Value = ((this.Value<ITimeStopComponent>() != null) ? this.Value<ITimeStopComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPortalComponent:
				_o.Value.Value = ((this.Value<IPortalComponent>() != null) ? this.Value<IPortalComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDynamicPortalCreatorComponent:
				_o.Value.Value = ((this.Value<IDynamicPortalCreatorComponent>() != null) ? this.Value<IDynamicPortalCreatorComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.INoRenderPortalComponent:
				_o.Value.Value = ((this.Value<INoRenderPortalComponent>() != null) ? this.Value<INoRenderPortalComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEffectAreaComponent:
				_o.Value.Value = ((this.Value<IEffectAreaComponent>() != null) ? this.Value<IEffectAreaComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPhysicsConstraintComponent:
				_o.Value.Value = ((this.Value<IPhysicsConstraintComponent>() != null) ? this.Value<IPhysicsConstraintComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IFollowDecorationComponent:
				_o.Value.Value = ((this.Value<IFollowDecorationComponent>() != null) ? this.Value<IFollowDecorationComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IFollowShooterComponent:
				_o.Value.Value = ((this.Value<IFollowShooterComponent>() != null) ? this.Value<IFollowShooterComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IConnectorComponent:
				_o.Value.Value = ((this.Value<IConnectorComponent>() != null) ? this.Value<IConnectorComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISceneTextComponent:
				_o.Value.Value = ((this.Value<ISceneTextComponent>() != null) ? this.Value<ISceneTextComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.INavMeshComponent:
				_o.Value.Value = ((this.Value<INavMeshComponent>() != null) ? this.Value<INavMeshComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ICharacterConnectorComponent:
				_o.Value.Value = ((this.Value<ICharacterConnectorComponent>() != null) ? this.Value<ICharacterConnectorComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAiGearStrategyComponent:
				_o.Value.Value = ((this.Value<IAiGearStrategyComponent>() != null) ? this.Value<IAiGearStrategyComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPickInteractComponent:
				_o.Value.Value = ((this.Value<IPickInteractComponent>() != null) ? this.Value<IPickInteractComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IChessmanComponent:
				_o.Value.Value = ((this.Value<IChessmanComponent>() != null) ? this.Value<IChessmanComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IClientTriggerComponent:
				_o.Value.Value = ((this.Value<IClientTriggerComponent>() != null) ? this.Value<IClientTriggerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILocationSafetyComponent:
				_o.Value.Value = ((this.Value<ILocationSafetyComponent>() != null) ? this.Value<ILocationSafetyComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IBatchBulletCasterComponent:
				_o.Value.Value = ((this.Value<IBatchBulletCasterComponent>() != null) ? this.Value<IBatchBulletCasterComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IVehicleComponent:
				_o.Value.Value = ((this.Value<IVehicleComponent>() != null) ? this.Value<IVehicleComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IEnrichmentAreaComponent:
				_o.Value.Value = ((this.Value<IEnrichmentAreaComponent>() != null) ? this.Value<IEnrichmentAreaComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IMonitorComponent:
				_o.Value.Value = ((this.Value<IMonitorComponent>() != null) ? this.Value<IMonitorComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGroupAiComponent:
				_o.Value.Value = ((this.Value<IGroupAiComponent>() != null) ? this.Value<IGroupAiComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IInhalationAbilityComponent:
				_o.Value.Value = ((this.Value<IInhalationAbilityComponent>() != null) ? this.Value<IInhalationAbilityComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IInhaledItemComponent:
				_o.Value.Value = ((this.Value<IInhaledItemComponent>() != null) ? this.Value<IInhaledItemComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IAirPassageComponent:
				_o.Value.Value = ((this.Value<IAirPassageComponent>() != null) ? this.Value<IAirPassageComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRenderSpecifiedRangeComponent:
				_o.Value.Value = ((this.Value<IRenderSpecifiedRangeComponent>() != null) ? this.Value<IRenderSpecifiedRangeComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILevelPrefabPerformComponent:
				_o.Value.Value = ((this.Value<ILevelPrefabPerformComponent>() != null) ? this.Value<ILevelPrefabPerformComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISceneItemAiComponent:
				_o.Value.Value = ((this.Value<ISceneItemAiComponent>() != null) ? this.Value<ISceneItemAiComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGravityFlipComponent:
				_o.Value.Value = ((this.Value<IGravityFlipComponent>() != null) ? this.Value<IGravityFlipComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILevelSequenceFrameEventComponent:
				_o.Value.Value = ((this.Value<ILevelSequenceFrameEventComponent>() != null) ? this.Value<ILevelSequenceFrameEventComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILevelQteComponent:
				_o.Value.Value = ((this.Value<ILevelQteComponent>() != null) ? this.Value<ILevelQteComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IWalkingPatternComponent:
				_o.Value.Value = ((this.Value<IWalkingPatternComponent>() != null) ? this.Value<IWalkingPatternComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ILifePointCenterComponent:
				_o.Value.Value = ((this.Value<ILifePointCenterComponent>() != null) ? this.Value<ILifePointCenterComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IHackManagementComponent:
				_o.Value.Value = ((this.Value<IHackManagementComponent>() != null) ? this.Value<IHackManagementComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IClientConditionListenerComponent:
				_o.Value.Value = ((this.Value<IClientConditionListenerComponent>() != null) ? this.Value<IClientConditionListenerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITemplateEntitySpawnerComponent:
				_o.Value.Value = ((this.Value<ITemplateEntitySpawnerComponent>() != null) ? this.Value<ITemplateEntitySpawnerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IWindSourceComponent:
				_o.Value.Value = ((this.Value<IWindSourceComponent>() != null) ? this.Value<IWindSourceComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISlideRailComponent:
				_o.Value.Value = ((this.Value<ISlideRailComponent>() != null) ? this.Value<ISlideRailComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISlidePerformComponent:
				_o.Value.Value = ((this.Value<ISlidePerformComponent>() != null) ? this.Value<ISlidePerformComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRollBlockComponent:
				_o.Value.Value = ((this.Value<IRollBlockComponent>() != null) ? this.Value<IRollBlockComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRollBlockFloorComponent:
				_o.Value.Value = ((this.Value<IRollBlockFloorComponent>() != null) ? this.Value<IRollBlockFloorComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRollBlockItemComponent:
				_o.Value.Value = ((this.Value<IRollBlockItemComponent>() != null) ? this.Value<IRollBlockItemComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ICurveControlComponent:
				_o.Value.Value = ((this.Value<ICurveControlComponent>() != null) ? this.Value<ICurveControlComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISimpleCombatComponent:
				_o.Value.Value = ((this.Value<ISimpleCombatComponent>() != null) ? this.Value<ISimpleCombatComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGridObjectComponent:
				_o.Value.Value = ((this.Value<IGridObjectComponent>() != null) ? this.Value<IGridObjectComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGodKingFrequencyControllerComponent:
				_o.Value.Value = ((this.Value<IGodKingFrequencyControllerComponent>() != null) ? this.Value<IGodKingFrequencyControllerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPerformanceOptimizationComponent:
				_o.Value.Value = ((this.Value<IPerformanceOptimizationComponent>() != null) ? this.Value<IPerformanceOptimizationComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISceneItemEventListenerComponent:
				_o.Value.Value = ((this.Value<ISceneItemEventListenerComponent>() != null) ? this.Value<ISceneItemEventListenerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDynamicSpawnMonsterPointComponent:
				_o.Value.Value = ((this.Value<IDynamicSpawnMonsterPointComponent>() != null) ? this.Value<IDynamicSpawnMonsterPointComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDynamicSpawnMonsterComponent:
				_o.Value.Value = ((this.Value<IDynamicSpawnMonsterComponent>() != null) ? this.Value<IDynamicSpawnMonsterComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISunSpiritCollectComponent:
				_o.Value.Value = ((this.Value<ISunSpiritCollectComponent>() != null) ? this.Value<ISunSpiritCollectComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISunSpiritLauncherComponent:
				_o.Value.Value = ((this.Value<ISunSpiritLauncherComponent>() != null) ? this.Value<ISunSpiritLauncherComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISunSpiritGearComponent:
				_o.Value.Value = ((this.Value<ISunSpiritGearComponent>() != null) ? this.Value<ISunSpiritGearComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IMotorSlideComponent:
				_o.Value.Value = ((this.Value<IMotorSlideComponent>() != null) ? this.Value<IMotorSlideComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IProceduralVisualComponent:
				_o.Value.Value = ((this.Value<IProceduralVisualComponent>() != null) ? this.Value<IProceduralVisualComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IRoadNetworkNavigationComponent:
				_o.Value.Value = ((this.Value<IRoadNetworkNavigationComponent>() != null) ? this.Value<IRoadNetworkNavigationComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IFurnitureSlotComponent:
				_o.Value.Value = ((this.Value<IFurnitureSlotComponent>() != null) ? this.Value<IFurnitureSlotComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IVisionDisplayComponent:
				_o.Value.Value = ((this.Value<IVisionDisplayComponent>() != null) ? this.Value<IVisionDisplayComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ISystemModuleDataSyncComponent:
				_o.Value.Value = ((this.Value<ISystemModuleDataSyncComponent>() != null) ? this.Value<ISystemModuleDataSyncComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IExhibitComponent:
				_o.Value.Value = ((this.Value<IExhibitComponent>() != null) ? this.Value<IExhibitComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITimeScheduleComponent:
				_o.Value.Value = ((this.Value<ITimeScheduleComponent>() != null) ? this.Value<ITimeScheduleComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IProjectorComponent:
				_o.Value.Value = ((this.Value<IProjectorComponent>() != null) ? this.Value<IProjectorComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IProceduralMaterialComponent:
				_o.Value.Value = ((this.Value<IProceduralMaterialComponent>() != null) ? this.Value<IProceduralMaterialComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGameplayDataPersistenceComponent:
				_o.Value.Value = ((this.Value<IGameplayDataPersistenceComponent>() != null) ? this.Value<IGameplayDataPersistenceComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IFlowerPollutionComponent:
				_o.Value.Value = ((this.Value<IFlowerPollutionComponent>() != null) ? this.Value<IFlowerPollutionComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IQuickHackComponent:
				_o.Value.Value = ((this.Value<IQuickHackComponent>() != null) ? this.Value<IQuickHackComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDollGrabMachineComponent:
				_o.Value.Value = ((this.Value<IDollGrabMachineComponent>() != null) ? this.Value<IDollGrabMachineComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDollGrabShowcaseComponent:
				_o.Value.Value = ((this.Value<IDollGrabShowcaseComponent>() != null) ? this.Value<IDollGrabShowcaseComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IWuWaGoComponent:
				_o.Value.Value = ((this.Value<IWuWaGoComponent>() != null) ? this.Value<IWuWaGoComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IDragActorPlayComponent:
				_o.Value.Value = ((this.Value<IDragActorPlayComponent>() != null) ? this.Value<IDragActorPlayComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IPathDrivenActorSpawnerComponent:
				_o.Value.Value = ((this.Value<IPathDrivenActorSpawnerComponent>() != null) ? this.Value<IPathDrivenActorSpawnerComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IElementalHolderComponent:
				_o.Value.Value = ((this.Value<IElementalHolderComponent>() != null) ? this.Value<IElementalHolderComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IElementalEffectComponent:
				_o.Value.Value = ((this.Value<IElementalEffectComponent>() != null) ? this.Value<IElementalEffectComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IElementalBoxFoundationComponent:
				_o.Value.Value = ((this.Value<IElementalBoxFoundationComponent>() != null) ? this.Value<IElementalBoxFoundationComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IElementalWellComponent:
				_o.Value.Value = ((this.Value<IElementalWellComponent>() != null) ? this.Value<IElementalWellComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IStreamingSourceTriggerPointComponent:
				_o.Value.Value = ((this.Value<IStreamingSourceTriggerPointComponent>() != null) ? this.Value<IStreamingSourceTriggerPointComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGraph3dComponent:
				_o.Value.Value = ((this.Value<IGraph3dComponent>() != null) ? this.Value<IGraph3dComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.IGraph3dEffectComponent:
				_o.Value.Value = ((this.Value<IGraph3dEffectComponent>() != null) ? this.Value<IGraph3dEffectComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.INoiseRemovalComponent:
				_o.Value.Value = ((this.Value<INoiseRemovalComponent>() != null) ? this.Value<INoiseRemovalComponent>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06028636 RID: 165430 RVA: 0x0058F5B0 File Offset: 0x0058D7B0
		public static Offset<TComponentData> Pack(FlatBufferBuilder builder, TComponentDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<TComponentData>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			IComponentBase_Union value_type = (_o.Value == null) ? IComponentBase_Union.NONE : _o.Value.Type;
			int valueOffset = (_o.Value == null) ? 0 : IComponentBase_UnionUnion.Pack(builder, _o.Value);
			return TComponentData.CreateTComponentData(builder, keyOffset, value_type, valueOffset);
		}

		// Token: 0x0400F394 RID: 62356
		private Table __p;
	}
}
