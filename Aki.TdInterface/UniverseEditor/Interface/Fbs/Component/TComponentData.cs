using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006213 RID: 25107
	public struct TComponentData : IFlatbufferObject
	{
		// Token: 0x1700BB1B RID: 47899
		// (get) Token: 0x0602AB49 RID: 174921 RVA: 0x005D2682 File Offset: 0x005D0882
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602AB4A RID: 174922 RVA: 0x005D268F File Offset: 0x005D088F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602AB4B RID: 174923 RVA: 0x005D2698 File Offset: 0x005D0898
		public static TComponentData GetRootAsTComponentData(ByteBuffer _bb)
		{
			return TComponentData.GetRootAsTComponentData(_bb, default(TComponentData));
		}

		// Token: 0x0602AB4C RID: 174924 RVA: 0x005D26B4 File Offset: 0x005D08B4
		public static TComponentData GetRootAsTComponentData(ByteBuffer _bb, TComponentData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602AB4D RID: 174925 RVA: 0x005D26D1 File Offset: 0x005D08D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602AB4E RID: 174926 RVA: 0x005D26E0 File Offset: 0x005D08E0
		public TComponentData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB1C RID: 47900
		// (get) Token: 0x0602AB4F RID: 174927 RVA: 0x005D26F0 File Offset: 0x005D08F0
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

		// Token: 0x0602AB50 RID: 174928 RVA: 0x005D2727 File Offset: 0x005D0927
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602AB51 RID: 174929 RVA: 0x005D2736 File Offset: 0x005D0936
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700BB1D RID: 47901
		// (get) Token: 0x0602AB52 RID: 174930 RVA: 0x005D2744 File Offset: 0x005D0944
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

		// Token: 0x0602AB53 RID: 174931 RVA: 0x005D2780 File Offset: 0x005D0980
		public TTable? Value<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602AB54 RID: 174932 RVA: 0x005D27C4 File Offset: 0x005D09C4
		public IComponentBase ValueAsIComponentBase()
		{
			return this.Value<IComponentBase>().Value;
		}

		// Token: 0x0602AB55 RID: 174933 RVA: 0x005D27E0 File Offset: 0x005D09E0
		public IUnUseComponent ValueAsIUnUseComponent()
		{
			return this.Value<IUnUseComponent>().Value;
		}

		// Token: 0x0602AB56 RID: 174934 RVA: 0x005D27FC File Offset: 0x005D09FC
		public IInteractiveComponent ValueAsIInteractiveComponent()
		{
			return this.Value<IInteractiveComponent>().Value;
		}

		// Token: 0x0602AB57 RID: 174935 RVA: 0x005D2818 File Offset: 0x005D0A18
		public ISwitcherComponent ValueAsISwitcherComponent()
		{
			return this.Value<ISwitcherComponent>().Value;
		}

		// Token: 0x0602AB58 RID: 174936 RVA: 0x005D2834 File Offset: 0x005D0A34
		public IRotatorComponent ValueAsIRotatorComponent()
		{
			return this.Value<IRotatorComponent>().Value;
		}

		// Token: 0x0602AB59 RID: 174937 RVA: 0x005D2850 File Offset: 0x005D0A50
		public IBehaviorFlowComponent ValueAsIBehaviorFlowComponent()
		{
			return this.Value<IBehaviorFlowComponent>().Value;
		}

		// Token: 0x0602AB5A RID: 174938 RVA: 0x005D286C File Offset: 0x005D0A6C
		public IFlowComponent ValueAsIFlowComponent()
		{
			return this.Value<IFlowComponent>().Value;
		}

		// Token: 0x0602AB5B RID: 174939 RVA: 0x005D2888 File Offset: 0x005D0A88
		public ITriggerUe5Component ValueAsITriggerUe5Component()
		{
			return this.Value<ITriggerUe5Component>().Value;
		}

		// Token: 0x0602AB5C RID: 174940 RVA: 0x005D28A4 File Offset: 0x005D0AA4
		public IMoveComponent ValueAsIMoveComponent()
		{
			return this.Value<IMoveComponent>().Value;
		}

		// Token: 0x0602AB5D RID: 174941 RVA: 0x005D28C0 File Offset: 0x005D0AC0
		public IActorStateComponent ValueAsIActorStateComponent()
		{
			return this.Value<IActorStateComponent>().Value;
		}

		// Token: 0x0602AB5E RID: 174942 RVA: 0x005D28DC File Offset: 0x005D0ADC
		public ICalculateComponent ValueAsICalculateComponent()
		{
			return this.Value<ICalculateComponent>().Value;
		}

		// Token: 0x0602AB5F RID: 174943 RVA: 0x005D28F8 File Offset: 0x005D0AF8
		public IRefreshGroup ValueAsIRefreshGroup()
		{
			return this.Value<IRefreshGroup>().Value;
		}

		// Token: 0x0602AB60 RID: 174944 RVA: 0x005D2914 File Offset: 0x005D0B14
		public IRefreshSingleComponent ValueAsIRefreshSingleComponent()
		{
			return this.Value<IRefreshSingleComponent>().Value;
		}

		// Token: 0x0602AB61 RID: 174945 RVA: 0x005D2930 File Offset: 0x005D0B30
		public IRotatorComponent2 ValueAsIRotatorComponent2()
		{
			return this.Value<IRotatorComponent2>().Value;
		}

		// Token: 0x0602AB62 RID: 174946 RVA: 0x005D294C File Offset: 0x005D0B4C
		public ISphereFactoryComponent ValueAsISphereFactoryComponent()
		{
			return this.Value<ISphereFactoryComponent>().Value;
		}

		// Token: 0x0602AB63 RID: 174947 RVA: 0x005D2968 File Offset: 0x005D0B68
		public ISpringComponent ValueAsISpringComponent()
		{
			return this.Value<ISpringComponent>().Value;
		}

		// Token: 0x0602AB64 RID: 174948 RVA: 0x005D2984 File Offset: 0x005D0B84
		public ITrampleUe5Component ValueAsITrampleUe5Component()
		{
			return this.Value<ITrampleUe5Component>().Value;
		}

		// Token: 0x0602AB65 RID: 174949 RVA: 0x005D29A0 File Offset: 0x005D0BA0
		public IUndergroundComponent ValueAsIUndergroundComponent()
		{
			return this.Value<IUndergroundComponent>().Value;
		}

		// Token: 0x0602AB66 RID: 174950 RVA: 0x005D29BC File Offset: 0x005D0BBC
		public IGrabComponent ValueAsIGrabComponent()
		{
			return this.Value<IGrabComponent>().Value;
		}

		// Token: 0x0602AB67 RID: 174951 RVA: 0x005D29D8 File Offset: 0x005D0BD8
		public IInteractComponent ValueAsIInteractComponent()
		{
			return this.Value<IInteractComponent>().Value;
		}

		// Token: 0x0602AB68 RID: 174952 RVA: 0x005D29F4 File Offset: 0x005D0BF4
		public IVarComponent ValueAsIVarComponent()
		{
			return this.Value<IVarComponent>().Value;
		}

		// Token: 0x0602AB69 RID: 174953 RVA: 0x005D2A10 File Offset: 0x005D0C10
		public IPatrol ValueAsIPatrol()
		{
			return this.Value<IPatrol>().Value;
		}

		// Token: 0x0602AB6A RID: 174954 RVA: 0x005D2A2C File Offset: 0x005D0C2C
		public IAiComponent ValueAsIAiComponent()
		{
			return this.Value<IAiComponent>().Value;
		}

		// Token: 0x0602AB6B RID: 174955 RVA: 0x005D2A48 File Offset: 0x005D0C48
		public IAttributeComponent ValueAsIAttributeComponent()
		{
			return this.Value<IAttributeComponent>().Value;
		}

		// Token: 0x0602AB6C RID: 174956 RVA: 0x005D2A64 File Offset: 0x005D0C64
		public IEditCustomAoiComponent ValueAsIEditCustomAoiComponent()
		{
			return this.Value<IEditCustomAoiComponent>().Value;
		}

		// Token: 0x0602AB6D RID: 174957 RVA: 0x005D2A80 File Offset: 0x005D0C80
		public IBaseInfoComponent ValueAsIBaseInfoComponent()
		{
			return this.Value<IBaseInfoComponent>().Value;
		}

		// Token: 0x0602AB6E RID: 174958 RVA: 0x005D2A9C File Offset: 0x005D0C9C
		public IRewardComponent ValueAsIRewardComponent()
		{
			return this.Value<IRewardComponent>().Value;
		}

		// Token: 0x0602AB6F RID: 174959 RVA: 0x005D2AB8 File Offset: 0x005D0CB8
		public IDynamicEntityRewardComponent ValueAsIDynamicEntityRewardComponent()
		{
			return this.Value<IDynamicEntityRewardComponent>().Value;
		}

		// Token: 0x0602AB70 RID: 174960 RVA: 0x005D2AD4 File Offset: 0x005D0CD4
		public IIndependentSystemRewardComponent ValueAsIIndependentSystemRewardComponent()
		{
			return this.Value<IIndependentSystemRewardComponent>().Value;
		}

		// Token: 0x0602AB71 RID: 174961 RVA: 0x005D2AF0 File Offset: 0x005D0CF0
		public IRefreshComponent ValueAsIRefreshComponent()
		{
			return this.Value<IRefreshComponent>().Value;
		}

		// Token: 0x0602AB72 RID: 174962 RVA: 0x005D2B0C File Offset: 0x005D0D0C
		public IRefreshGroupComponent ValueAsIRefreshGroupComponent()
		{
			return this.Value<IRefreshGroupComponent>().Value;
		}

		// Token: 0x0602AB73 RID: 174963 RVA: 0x005D2B28 File Offset: 0x005D0D28
		public IEntityBatchRefreshComponent ValueAsIEntityBatchRefreshComponent()
		{
			return this.Value<IEntityBatchRefreshComponent>().Value;
		}

		// Token: 0x0602AB74 RID: 174964 RVA: 0x005D2B44 File Offset: 0x005D0D44
		public ITreasureBoxComponent ValueAsITreasureBoxComponent()
		{
			return this.Value<ITreasureBoxComponent>().Value;
		}

		// Token: 0x0602AB75 RID: 174965 RVA: 0x005D2B60 File Offset: 0x005D0D60
		public ITriggerComponent ValueAsITriggerComponent()
		{
			return this.Value<ITriggerComponent>().Value;
		}

		// Token: 0x0602AB76 RID: 174966 RVA: 0x005D2B7C File Offset: 0x005D0D7C
		public IEntityStateComponent ValueAsIEntityStateComponent()
		{
			return this.Value<IEntityStateComponent>().Value;
		}

		// Token: 0x0602AB77 RID: 174967 RVA: 0x005D2B98 File Offset: 0x005D0D98
		public ISceneItemAttributeComponent ValueAsISceneItemAttributeComponent()
		{
			return this.Value<ISceneItemAttributeComponent>().Value;
		}

		// Token: 0x0602AB78 RID: 174968 RVA: 0x005D2BB4 File Offset: 0x005D0DB4
		public IEntityAudioComponent ValueAsIEntityAudioComponent()
		{
			return this.Value<IEntityAudioComponent>().Value;
		}

		// Token: 0x0602AB79 RID: 174969 RVA: 0x005D2BD0 File Offset: 0x005D0DD0
		public IEntityStateAudioComponent ValueAsIEntityStateAudioComponent()
		{
			return this.Value<IEntityStateAudioComponent>().Value;
		}

		// Token: 0x0602AB7A RID: 174970 RVA: 0x005D2BEC File Offset: 0x005D0DEC
		public IEntityCustomAudioComponent ValueAsIEntityCustomAudioComponent()
		{
			return this.Value<IEntityCustomAudioComponent>().Value;
		}

		// Token: 0x0602AB7B RID: 174971 RVA: 0x005D2C08 File Offset: 0x005D0E08
		public ITrampleComponent ValueAsITrampleComponent()
		{
			return this.Value<ITrampleComponent>().Value;
		}

		// Token: 0x0602AB7C RID: 174972 RVA: 0x005D2C24 File Offset: 0x005D0E24
		public IEntityGroupComponent ValueAsIEntityGroupComponent()
		{
			return this.Value<IEntityGroupComponent>().Value;
		}

		// Token: 0x0602AB7D RID: 174973 RVA: 0x005D2C40 File Offset: 0x005D0E40
		public IHookLockPoint ValueAsIHookLockPoint()
		{
			return this.Value<IHookLockPoint>().Value;
		}

		// Token: 0x0602AB7E RID: 174974 RVA: 0x005D2C5C File Offset: 0x005D0E5C
		public IRoleMotionInteractComponent ValueAsIRoleMotionInteractComponent()
		{
			return this.Value<IRoleMotionInteractComponent>().Value;
		}

		// Token: 0x0602AB7F RID: 174975 RVA: 0x005D2C78 File Offset: 0x005D0E78
		public IHookFetchComponent ValueAsIHookFetchComponent()
		{
			return this.Value<IHookFetchComponent>().Value;
		}

		// Token: 0x0602AB80 RID: 174976 RVA: 0x005D2C94 File Offset: 0x005D0E94
		public IItemFoundation ValueAsIItemFoundation()
		{
			return this.Value<IItemFoundation>().Value;
		}

		// Token: 0x0602AB81 RID: 174977 RVA: 0x005D2CB0 File Offset: 0x005D0EB0
		public IResetEntitiesPosComponent ValueAsIResetEntitiesPosComponent()
		{
			return this.Value<IResetEntitiesPosComponent>().Value;
		}

		// Token: 0x0602AB82 RID: 174978 RVA: 0x005D2CCC File Offset: 0x005D0ECC
		public IResetSelfPosComponent ValueAsIResetSelfPosComponent()
		{
			return this.Value<IResetSelfPosComponent>().Value;
		}

		// Token: 0x0602AB83 RID: 174979 RVA: 0x005D2CE8 File Offset: 0x005D0EE8
		public ICollectComponent ValueAsICollectComponent()
		{
			return this.Value<ICollectComponent>().Value;
		}

		// Token: 0x0602AB84 RID: 174980 RVA: 0x005D2D04 File Offset: 0x005D0F04
		public ITeleControl2 ValueAsITeleControl2()
		{
			return this.Value<ITeleControl2>().Value;
		}

		// Token: 0x0602AB85 RID: 174981 RVA: 0x005D2D20 File Offset: 0x005D0F20
		public IItemFoundation2 ValueAsIItemFoundation2()
		{
			return this.Value<IItemFoundation2>().Value;
		}

		// Token: 0x0602AB86 RID: 174982 RVA: 0x005D2D3C File Offset: 0x005D0F3C
		public IPullingFoundation ValueAsIPullingFoundation()
		{
			return this.Value<IPullingFoundation>().Value;
		}

		// Token: 0x0602AB87 RID: 174983 RVA: 0x005D2D58 File Offset: 0x005D0F58
		public ILevelPlayComponent ValueAsILevelPlayComponent()
		{
			return this.Value<ILevelPlayComponent>().Value;
		}

		// Token: 0x0602AB88 RID: 174984 RVA: 0x005D2D74 File Offset: 0x005D0F74
		public IDynamicLevelPlayComponent ValueAsIDynamicLevelPlayComponent()
		{
			return this.Value<IDynamicLevelPlayComponent>().Value;
		}

		// Token: 0x0602AB89 RID: 174985 RVA: 0x005D2D90 File Offset: 0x005D0F90
		public IVisionComponent ValueAsIVisionComponent()
		{
			return this.Value<IVisionComponent>().Value;
		}

		// Token: 0x0602AB8A RID: 174986 RVA: 0x005D2DAC File Offset: 0x005D0FAC
		public IVisionCaptureComponent ValueAsIVisionCaptureComponent()
		{
			return this.Value<IVisionCaptureComponent>().Value;
		}

		// Token: 0x0602AB8B RID: 174987 RVA: 0x005D2DC8 File Offset: 0x005D0FC8
		public IAdsorbComponent ValueAsIAdsorbComponent()
		{
			return this.Value<IAdsorbComponent>().Value;
		}

		// Token: 0x0602AB8C RID: 174988 RVA: 0x005D2DE4 File Offset: 0x005D0FE4
		public ITeleportComponent ValueAsITeleportComponent()
		{
			return this.Value<ITeleportComponent>().Value;
		}

		// Token: 0x0602AB8D RID: 174989 RVA: 0x005D2E00 File Offset: 0x005D1000
		public ISpawnMonsterComponent ValueAsISpawnMonsterComponent()
		{
			return this.Value<ISpawnMonsterComponent>().Value;
		}

		// Token: 0x0602AB8E RID: 174990 RVA: 0x005D2E1C File Offset: 0x005D101C
		public IHitComponentBase ValueAsIHitComponentBase()
		{
			return this.Value<IHitComponentBase>().Value;
		}

		// Token: 0x0602AB8F RID: 174991 RVA: 0x005D2E38 File Offset: 0x005D1038
		public IDestructibleItem ValueAsIDestructibleItem()
		{
			return this.Value<IDestructibleItem>().Value;
		}

		// Token: 0x0602AB90 RID: 174992 RVA: 0x005D2E54 File Offset: 0x005D1054
		public ITargetGearComponent ValueAsITargetGearComponent()
		{
			return this.Value<ITargetGearComponent>().Value;
		}

		// Token: 0x0602AB91 RID: 174993 RVA: 0x005D2E70 File Offset: 0x005D1070
		public IProgressBarControlComponent ValueAsIProgressBarControlComponent()
		{
			return this.Value<IProgressBarControlComponent>().Value;
		}

		// Token: 0x0602AB92 RID: 174994 RVA: 0x005D2E8C File Offset: 0x005D108C
		public IHitComponent ValueAsIHitComponent()
		{
			return this.Value<IHitComponent>().Value;
		}

		// Token: 0x0602AB93 RID: 174995 RVA: 0x005D2EA8 File Offset: 0x005D10A8
		public ITargetGearGroupComponent ValueAsITargetGearGroupComponent()
		{
			return this.Value<ITargetGearGroupComponent>().Value;
		}

		// Token: 0x0602AB94 RID: 174996 RVA: 0x005D2EC4 File Offset: 0x005D10C4
		public INpcPerformComponent ValueAsINpcPerformComponent()
		{
			return this.Value<INpcPerformComponent>().Value;
		}

		// Token: 0x0602AB95 RID: 174997 RVA: 0x005D2EE0 File Offset: 0x005D10E0
		public IInteractGearComponent ValueAsIInteractGearComponent()
		{
			return this.Value<IInteractGearComponent>().Value;
		}

		// Token: 0x0602AB96 RID: 174998 RVA: 0x005D2EFC File Offset: 0x005D10FC
		public ILiftComponent ValueAsILiftComponent()
		{
			return this.Value<ILiftComponent>().Value;
		}

		// Token: 0x0602AB97 RID: 174999 RVA: 0x005D2F18 File Offset: 0x005D1118
		public IConveyorBeltComponent ValueAsIConveyorBeltComponent()
		{
			return this.Value<IConveyorBeltComponent>().Value;
		}

		// Token: 0x0602AB98 RID: 175000 RVA: 0x005D2F34 File Offset: 0x005D1134
		public IFollowTrackComponent ValueAsIFollowTrackComponent()
		{
			return this.Value<IFollowTrackComponent>().Value;
		}

		// Token: 0x0602AB99 RID: 175001 RVA: 0x005D2F50 File Offset: 0x005D1150
		public ISceneItemLifeCycleComponent ValueAsISceneItemLifeCycleComponent()
		{
			return this.Value<ISceneItemLifeCycleComponent>().Value;
		}

		// Token: 0x0602AB9A RID: 175002 RVA: 0x005D2F6C File Offset: 0x005D116C
		public IFightInteractComponent ValueAsIFightInteractComponent()
		{
			return this.Value<IFightInteractComponent>().Value;
		}

		// Token: 0x0602AB9B RID: 175003 RVA: 0x005D2F88 File Offset: 0x005D1188
		public IBubbleComponent ValueAsIBubbleComponent()
		{
			return this.Value<IBubbleComponent>().Value;
		}

		// Token: 0x0602AB9C RID: 175004 RVA: 0x005D2FA4 File Offset: 0x005D11A4
		public INearbyTrackingComponent ValueAsINearbyTrackingComponent()
		{
			return this.Value<INearbyTrackingComponent>().Value;
		}

		// Token: 0x0602AB9D RID: 175005 RVA: 0x005D2FC0 File Offset: 0x005D11C0
		public IEntityPackageComponent ValueAsIEntityPackageComponent()
		{
			return this.Value<IEntityPackageComponent>().Value;
		}

		// Token: 0x0602AB9E RID: 175006 RVA: 0x005D2FDC File Offset: 0x005D11DC
		public ISkyboxComponent ValueAsISkyboxComponent()
		{
			return this.Value<ISkyboxComponent>().Value;
		}

		// Token: 0x0602AB9F RID: 175007 RVA: 0x005D2FF8 File Offset: 0x005D11F8
		public IStateHintComponent ValueAsIStateHintComponent()
		{
			return this.Value<IStateHintComponent>().Value;
		}

		// Token: 0x0602ABA0 RID: 175008 RVA: 0x005D3014 File Offset: 0x005D1214
		public IEntityVisibleComponent ValueAsIEntityVisibleComponent()
		{
			return this.Value<IEntityVisibleComponent>().Value;
		}

		// Token: 0x0602ABA1 RID: 175009 RVA: 0x005D3030 File Offset: 0x005D1230
		public ICombinedVisibleGroupComponent ValueAsICombinedVisibleGroupComponent()
		{
			return this.Value<ICombinedVisibleGroupComponent>().Value;
		}

		// Token: 0x0602ABA2 RID: 175010 RVA: 0x005D304C File Offset: 0x005D124C
		public IWeaponComponent ValueAsIWeaponComponent()
		{
			return this.Value<IWeaponComponent>().Value;
		}

		// Token: 0x0602ABA3 RID: 175011 RVA: 0x005D3068 File Offset: 0x005D1268
		public IDungeonEntryComponent ValueAsIDungeonEntryComponent()
		{
			return this.Value<IDungeonEntryComponent>().Value;
		}

		// Token: 0x0602ABA4 RID: 175012 RVA: 0x005D3084 File Offset: 0x005D1284
		public IResurrectionComponent ValueAsIResurrectionComponent()
		{
			return this.Value<IResurrectionComponent>().Value;
		}

		// Token: 0x0602ABA5 RID: 175013 RVA: 0x005D30A0 File Offset: 0x005D12A0
		public IBuffProducerComponent ValueAsIBuffProducerComponent()
		{
			return this.Value<IBuffProducerComponent>().Value;
		}

		// Token: 0x0602ABA6 RID: 175014 RVA: 0x005D30BC File Offset: 0x005D12BC
		public IBuffConsumerComponent ValueAsIBuffConsumerComponent()
		{
			return this.Value<IBuffConsumerComponent>().Value;
		}

		// Token: 0x0602ABA7 RID: 175015 RVA: 0x005D30D8 File Offset: 0x005D12D8
		public IGuideLineCreatorComponent ValueAsIGuideLineCreatorComponent()
		{
			return this.Value<IGuideLineCreatorComponent>().Value;
		}

		// Token: 0x0602ABA8 RID: 175016 RVA: 0x005D30F4 File Offset: 0x005D12F4
		public IInteractAudioComponent ValueAsIInteractAudioComponent()
		{
			return this.Value<IInteractAudioComponent>().Value;
		}

		// Token: 0x0602ABA9 RID: 175017 RVA: 0x005D3110 File Offset: 0x005D1310
		public IDropComponent ValueAsIDropComponent()
		{
			return this.Value<IDropComponent>().Value;
		}

		// Token: 0x0602ABAA RID: 175018 RVA: 0x005D312C File Offset: 0x005D132C
		public IVisionItemComponent ValueAsIVisionItemComponent()
		{
			return this.Value<IVisionItemComponent>().Value;
		}

		// Token: 0x0602ABAB RID: 175019 RVA: 0x005D3148 File Offset: 0x005D1348
		public IAdviseItemComponent ValueAsIAdviseItemComponent()
		{
			return this.Value<IAdviseItemComponent>().Value;
		}

		// Token: 0x0602ABAC RID: 175020 RVA: 0x005D3164 File Offset: 0x005D1364
		public IMonsterComponent ValueAsIMonsterComponent()
		{
			return this.Value<IMonsterComponent>().Value;
		}

		// Token: 0x0602ABAD RID: 175021 RVA: 0x005D3180 File Offset: 0x005D1380
		public ICombatComponent ValueAsICombatComponent()
		{
			return this.Value<ICombatComponent>().Value;
		}

		// Token: 0x0602ABAE RID: 175022 RVA: 0x005D319C File Offset: 0x005D139C
		public IEntityListComponent ValueAsIEntityListComponent()
		{
			return this.Value<IEntityListComponent>().Value;
		}

		// Token: 0x0602ABAF RID: 175023 RVA: 0x005D31B8 File Offset: 0x005D13B8
		public IAnimalComponent ValueAsIAnimalComponent()
		{
			return this.Value<IAnimalComponent>().Value;
		}

		// Token: 0x0602ABB0 RID: 175024 RVA: 0x005D31D4 File Offset: 0x005D13D4
		public ISceneItemMovementComponent ValueAsISceneItemMovementComponent()
		{
			return this.Value<ISceneItemMovementComponent>().Value;
		}

		// Token: 0x0602ABB1 RID: 175025 RVA: 0x005D31F0 File Offset: 0x005D13F0
		public IRangeComponent ValueAsIRangeComponent()
		{
			return this.Value<IRangeComponent>().Value;
		}

		// Token: 0x0602ABB2 RID: 175026 RVA: 0x005D320C File Offset: 0x005D140C
		public IExtraRangeComponent ValueAsIExtraRangeComponent()
		{
			return this.Value<IExtraRangeComponent>().Value;
		}

		// Token: 0x0602ABB3 RID: 175027 RVA: 0x005D3228 File Offset: 0x005D1428
		public ITimelineTrackControlComponent ValueAsITimelineTrackControlComponent()
		{
			return this.Value<ITimelineTrackControlComponent>().Value;
		}

		// Token: 0x0602ABB4 RID: 175028 RVA: 0x005D3244 File Offset: 0x005D1444
		public ISplineComponent ValueAsISplineComponent()
		{
			return this.Value<ISplineComponent>().Value;
		}

		// Token: 0x0602ABB5 RID: 175029 RVA: 0x005D3260 File Offset: 0x005D1460
		public IAirWallSpawnerComponent ValueAsIAirWallSpawnerComponent()
		{
			return this.Value<IAirWallSpawnerComponent>().Value;
		}

		// Token: 0x0602ABB6 RID: 175030 RVA: 0x005D327C File Offset: 0x005D147C
		public ISceneActorRefComponent ValueAsISceneActorRefComponent()
		{
			return this.Value<ISceneActorRefComponent>().Value;
		}

		// Token: 0x0602ABB7 RID: 175031 RVA: 0x005D3298 File Offset: 0x005D1498
		public ISceneBulletComponent ValueAsISceneBulletComponent()
		{
			return this.Value<ISceneBulletComponent>().Value;
		}

		// Token: 0x0602ABB8 RID: 175032 RVA: 0x005D32B4 File Offset: 0x005D14B4
		public ITurntableControlComponent ValueAsITurntableControlComponent()
		{
			return this.Value<ITurntableControlComponent>().Value;
		}

		// Token: 0x0602ABB9 RID: 175033 RVA: 0x005D32D0 File Offset: 0x005D14D0
		public IConditionListenerComponent ValueAsIConditionListenerComponent()
		{
			return this.Value<IConditionListenerComponent>().Value;
		}

		// Token: 0x0602ABBA RID: 175034 RVA: 0x005D32EC File Offset: 0x005D14EC
		public IAttachTargetComponent ValueAsIAttachTargetComponent()
		{
			return this.Value<IAttachTargetComponent>().Value;
		}

		// Token: 0x0602ABBB RID: 175035 RVA: 0x005D3308 File Offset: 0x005D1508
		public IReboundComponent ValueAsIReboundComponent()
		{
			return this.Value<IReboundComponent>().Value;
		}

		// Token: 0x0602ABBC RID: 175036 RVA: 0x005D3324 File Offset: 0x005D1524
		public IJigsawItem ValueAsIJigsawItem()
		{
			return this.Value<IJigsawItem>().Value;
		}

		// Token: 0x0602ABBD RID: 175037 RVA: 0x005D3340 File Offset: 0x005D1540
		public IJigsawFoundation ValueAsIJigsawFoundation()
		{
			return this.Value<IJigsawFoundation>().Value;
		}

		// Token: 0x0602ABBE RID: 175038 RVA: 0x005D335C File Offset: 0x005D155C
		public ILevelAIComponent ValueAsILevelAIComponent()
		{
			return this.Value<ILevelAIComponent>().Value;
		}

		// Token: 0x0602ABBF RID: 175039 RVA: 0x005D3378 File Offset: 0x005D1578
		public ILevitateMagnetComponent ValueAsILevitateMagnetComponent()
		{
			return this.Value<ILevitateMagnetComponent>().Value;
		}

		// Token: 0x0602ABC0 RID: 175040 RVA: 0x005D3394 File Offset: 0x005D1594
		public IPhotoTargetComponent ValueAsIPhotoTargetComponent()
		{
			return this.Value<IPhotoTargetComponent>().Value;
		}

		// Token: 0x0602ABC1 RID: 175041 RVA: 0x005D33B0 File Offset: 0x005D15B0
		public IAiAlertNotifyComponent ValueAsIAiAlertNotifyComponent()
		{
			return this.Value<IAiAlertNotifyComponent>().Value;
		}

		// Token: 0x0602ABC2 RID: 175042 RVA: 0x005D33CC File Offset: 0x005D15CC
		public IMonsterGachaItemComponent ValueAsIMonsterGachaItemComponent()
		{
			return this.Value<IMonsterGachaItemComponent>().Value;
		}

		// Token: 0x0602ABC3 RID: 175043 RVA: 0x005D33E8 File Offset: 0x005D15E8
		public IMonsterGachaBaseComponent ValueAsIMonsterGachaBaseComponent()
		{
			return this.Value<IMonsterGachaBaseComponent>().Value;
		}

		// Token: 0x0602ABC4 RID: 175044 RVA: 0x005D3404 File Offset: 0x005D1604
		public IDynamicTeleportComponent ValueAsIDynamicTeleportComponent()
		{
			return this.Value<IDynamicTeleportComponent>().Value;
		}

		// Token: 0x0602ABC5 RID: 175045 RVA: 0x005D3420 File Offset: 0x005D1620
		public IExploreSkillInteractComponent ValueAsIExploreSkillInteractComponent()
		{
			return this.Value<IExploreSkillInteractComponent>().Value;
		}

		// Token: 0x0602ABC6 RID: 175046 RVA: 0x005D343C File Offset: 0x005D163C
		public IExploreSkillInteractGroupComponent ValueAsIExploreSkillInteractGroupComponent()
		{
			return this.Value<IExploreSkillInteractGroupComponent>().Value;
		}

		// Token: 0x0602ABC7 RID: 175047 RVA: 0x005D3458 File Offset: 0x005D1658
		public IFanComponent ValueAsIFanComponent()
		{
			return this.Value<IFanComponent>().Value;
		}

		// Token: 0x0602ABC8 RID: 175048 RVA: 0x005D3474 File Offset: 0x005D1674
		public IPasserbyNpcSpawnComponent ValueAsIPasserbyNpcSpawnComponent()
		{
			return this.Value<IPasserbyNpcSpawnComponent>().Value;
		}

		// Token: 0x0602ABC9 RID: 175049 RVA: 0x005D3490 File Offset: 0x005D1690
		public IModelComponent ValueAsIModelComponent()
		{
			return this.Value<IModelComponent>().Value;
		}

		// Token: 0x0602ABCA RID: 175050 RVA: 0x005D34AC File Offset: 0x005D16AC
		public IEntityBundleComponent ValueAsIEntityBundleComponent()
		{
			return this.Value<IEntityBundleComponent>().Value;
		}

		// Token: 0x0602ABCB RID: 175051 RVA: 0x005D34C8 File Offset: 0x005D16C8
		public IBeamCastComponent ValueAsIBeamCastComponent()
		{
			return this.Value<IBeamCastComponent>().Value;
		}

		// Token: 0x0602ABCC RID: 175052 RVA: 0x005D34E4 File Offset: 0x005D16E4
		public IBeamReceiveComponent ValueAsIBeamReceiveComponent()
		{
			return this.Value<IBeamReceiveComponent>().Value;
		}

		// Token: 0x0602ABCD RID: 175053 RVA: 0x005D3500 File Offset: 0x005D1700
		public ITimeStopComponent ValueAsITimeStopComponent()
		{
			return this.Value<ITimeStopComponent>().Value;
		}

		// Token: 0x0602ABCE RID: 175054 RVA: 0x005D351C File Offset: 0x005D171C
		public IPortalComponent ValueAsIPortalComponent()
		{
			return this.Value<IPortalComponent>().Value;
		}

		// Token: 0x0602ABCF RID: 175055 RVA: 0x005D3538 File Offset: 0x005D1738
		public IDynamicPortalCreatorComponent ValueAsIDynamicPortalCreatorComponent()
		{
			return this.Value<IDynamicPortalCreatorComponent>().Value;
		}

		// Token: 0x0602ABD0 RID: 175056 RVA: 0x005D3554 File Offset: 0x005D1754
		public INoRenderPortalComponent ValueAsINoRenderPortalComponent()
		{
			return this.Value<INoRenderPortalComponent>().Value;
		}

		// Token: 0x0602ABD1 RID: 175057 RVA: 0x005D3570 File Offset: 0x005D1770
		public IEffectAreaComponent ValueAsIEffectAreaComponent()
		{
			return this.Value<IEffectAreaComponent>().Value;
		}

		// Token: 0x0602ABD2 RID: 175058 RVA: 0x005D358C File Offset: 0x005D178C
		public IPhysicsConstraintComponent ValueAsIPhysicsConstraintComponent()
		{
			return this.Value<IPhysicsConstraintComponent>().Value;
		}

		// Token: 0x0602ABD3 RID: 175059 RVA: 0x005D35A8 File Offset: 0x005D17A8
		public IFollowDecorationComponent ValueAsIFollowDecorationComponent()
		{
			return this.Value<IFollowDecorationComponent>().Value;
		}

		// Token: 0x0602ABD4 RID: 175060 RVA: 0x005D35C4 File Offset: 0x005D17C4
		public IFollowShooterComponent ValueAsIFollowShooterComponent()
		{
			return this.Value<IFollowShooterComponent>().Value;
		}

		// Token: 0x0602ABD5 RID: 175061 RVA: 0x005D35E0 File Offset: 0x005D17E0
		public IConnectorComponent ValueAsIConnectorComponent()
		{
			return this.Value<IConnectorComponent>().Value;
		}

		// Token: 0x0602ABD6 RID: 175062 RVA: 0x005D35FC File Offset: 0x005D17FC
		public ISceneTextComponent ValueAsISceneTextComponent()
		{
			return this.Value<ISceneTextComponent>().Value;
		}

		// Token: 0x0602ABD7 RID: 175063 RVA: 0x005D3618 File Offset: 0x005D1818
		public INavMeshComponent ValueAsINavMeshComponent()
		{
			return this.Value<INavMeshComponent>().Value;
		}

		// Token: 0x0602ABD8 RID: 175064 RVA: 0x005D3634 File Offset: 0x005D1834
		public ICharacterConnectorComponent ValueAsICharacterConnectorComponent()
		{
			return this.Value<ICharacterConnectorComponent>().Value;
		}

		// Token: 0x0602ABD9 RID: 175065 RVA: 0x005D3650 File Offset: 0x005D1850
		public IAiGearStrategyComponent ValueAsIAiGearStrategyComponent()
		{
			return this.Value<IAiGearStrategyComponent>().Value;
		}

		// Token: 0x0602ABDA RID: 175066 RVA: 0x005D366C File Offset: 0x005D186C
		public IPickInteractComponent ValueAsIPickInteractComponent()
		{
			return this.Value<IPickInteractComponent>().Value;
		}

		// Token: 0x0602ABDB RID: 175067 RVA: 0x005D3688 File Offset: 0x005D1888
		public IChessmanComponent ValueAsIChessmanComponent()
		{
			return this.Value<IChessmanComponent>().Value;
		}

		// Token: 0x0602ABDC RID: 175068 RVA: 0x005D36A4 File Offset: 0x005D18A4
		public IClientTriggerComponent ValueAsIClientTriggerComponent()
		{
			return this.Value<IClientTriggerComponent>().Value;
		}

		// Token: 0x0602ABDD RID: 175069 RVA: 0x005D36C0 File Offset: 0x005D18C0
		public ILocationSafetyComponent ValueAsILocationSafetyComponent()
		{
			return this.Value<ILocationSafetyComponent>().Value;
		}

		// Token: 0x0602ABDE RID: 175070 RVA: 0x005D36DC File Offset: 0x005D18DC
		public IBatchBulletCasterComponent ValueAsIBatchBulletCasterComponent()
		{
			return this.Value<IBatchBulletCasterComponent>().Value;
		}

		// Token: 0x0602ABDF RID: 175071 RVA: 0x005D36F8 File Offset: 0x005D18F8
		public IVehicleComponent ValueAsIVehicleComponent()
		{
			return this.Value<IVehicleComponent>().Value;
		}

		// Token: 0x0602ABE0 RID: 175072 RVA: 0x005D3714 File Offset: 0x005D1914
		public IEnrichmentAreaComponent ValueAsIEnrichmentAreaComponent()
		{
			return this.Value<IEnrichmentAreaComponent>().Value;
		}

		// Token: 0x0602ABE1 RID: 175073 RVA: 0x005D3730 File Offset: 0x005D1930
		public IMonitorComponent ValueAsIMonitorComponent()
		{
			return this.Value<IMonitorComponent>().Value;
		}

		// Token: 0x0602ABE2 RID: 175074 RVA: 0x005D374C File Offset: 0x005D194C
		public IGroupAiComponent ValueAsIGroupAiComponent()
		{
			return this.Value<IGroupAiComponent>().Value;
		}

		// Token: 0x0602ABE3 RID: 175075 RVA: 0x005D3768 File Offset: 0x005D1968
		public IInhalationAbilityComponent ValueAsIInhalationAbilityComponent()
		{
			return this.Value<IInhalationAbilityComponent>().Value;
		}

		// Token: 0x0602ABE4 RID: 175076 RVA: 0x005D3784 File Offset: 0x005D1984
		public IInhaledItemComponent ValueAsIInhaledItemComponent()
		{
			return this.Value<IInhaledItemComponent>().Value;
		}

		// Token: 0x0602ABE5 RID: 175077 RVA: 0x005D37A0 File Offset: 0x005D19A0
		public IAirPassageComponent ValueAsIAirPassageComponent()
		{
			return this.Value<IAirPassageComponent>().Value;
		}

		// Token: 0x0602ABE6 RID: 175078 RVA: 0x005D37BC File Offset: 0x005D19BC
		public IRenderSpecifiedRangeComponent ValueAsIRenderSpecifiedRangeComponent()
		{
			return this.Value<IRenderSpecifiedRangeComponent>().Value;
		}

		// Token: 0x0602ABE7 RID: 175079 RVA: 0x005D37D8 File Offset: 0x005D19D8
		public ILevelPrefabPerformComponent ValueAsILevelPrefabPerformComponent()
		{
			return this.Value<ILevelPrefabPerformComponent>().Value;
		}

		// Token: 0x0602ABE8 RID: 175080 RVA: 0x005D37F4 File Offset: 0x005D19F4
		public ISceneItemAiComponent ValueAsISceneItemAiComponent()
		{
			return this.Value<ISceneItemAiComponent>().Value;
		}

		// Token: 0x0602ABE9 RID: 175081 RVA: 0x005D3810 File Offset: 0x005D1A10
		public IGravityFlipComponent ValueAsIGravityFlipComponent()
		{
			return this.Value<IGravityFlipComponent>().Value;
		}

		// Token: 0x0602ABEA RID: 175082 RVA: 0x005D382C File Offset: 0x005D1A2C
		public ILevelSequenceFrameEventComponent ValueAsILevelSequenceFrameEventComponent()
		{
			return this.Value<ILevelSequenceFrameEventComponent>().Value;
		}

		// Token: 0x0602ABEB RID: 175083 RVA: 0x005D3848 File Offset: 0x005D1A48
		public ILevelQteComponent ValueAsILevelQteComponent()
		{
			return this.Value<ILevelQteComponent>().Value;
		}

		// Token: 0x0602ABEC RID: 175084 RVA: 0x005D3864 File Offset: 0x005D1A64
		public IWalkingPatternComponent ValueAsIWalkingPatternComponent()
		{
			return this.Value<IWalkingPatternComponent>().Value;
		}

		// Token: 0x0602ABED RID: 175085 RVA: 0x005D3880 File Offset: 0x005D1A80
		public ILifePointCenterComponent ValueAsILifePointCenterComponent()
		{
			return this.Value<ILifePointCenterComponent>().Value;
		}

		// Token: 0x0602ABEE RID: 175086 RVA: 0x005D389C File Offset: 0x005D1A9C
		public IHackManagementComponent ValueAsIHackManagementComponent()
		{
			return this.Value<IHackManagementComponent>().Value;
		}

		// Token: 0x0602ABEF RID: 175087 RVA: 0x005D38B8 File Offset: 0x005D1AB8
		public IClientConditionListenerComponent ValueAsIClientConditionListenerComponent()
		{
			return this.Value<IClientConditionListenerComponent>().Value;
		}

		// Token: 0x0602ABF0 RID: 175088 RVA: 0x005D38D4 File Offset: 0x005D1AD4
		public ITemplateEntitySpawnerComponent ValueAsITemplateEntitySpawnerComponent()
		{
			return this.Value<ITemplateEntitySpawnerComponent>().Value;
		}

		// Token: 0x0602ABF1 RID: 175089 RVA: 0x005D38F0 File Offset: 0x005D1AF0
		public IWindSourceComponent ValueAsIWindSourceComponent()
		{
			return this.Value<IWindSourceComponent>().Value;
		}

		// Token: 0x0602ABF2 RID: 175090 RVA: 0x005D390C File Offset: 0x005D1B0C
		public ISlideRailComponent ValueAsISlideRailComponent()
		{
			return this.Value<ISlideRailComponent>().Value;
		}

		// Token: 0x0602ABF3 RID: 175091 RVA: 0x005D3928 File Offset: 0x005D1B28
		public ISlidePerformComponent ValueAsISlidePerformComponent()
		{
			return this.Value<ISlidePerformComponent>().Value;
		}

		// Token: 0x0602ABF4 RID: 175092 RVA: 0x005D3944 File Offset: 0x005D1B44
		public IRollBlockComponent ValueAsIRollBlockComponent()
		{
			return this.Value<IRollBlockComponent>().Value;
		}

		// Token: 0x0602ABF5 RID: 175093 RVA: 0x005D3960 File Offset: 0x005D1B60
		public IRollBlockFloorComponent ValueAsIRollBlockFloorComponent()
		{
			return this.Value<IRollBlockFloorComponent>().Value;
		}

		// Token: 0x0602ABF6 RID: 175094 RVA: 0x005D397C File Offset: 0x005D1B7C
		public IRollBlockItemComponent ValueAsIRollBlockItemComponent()
		{
			return this.Value<IRollBlockItemComponent>().Value;
		}

		// Token: 0x0602ABF7 RID: 175095 RVA: 0x005D3998 File Offset: 0x005D1B98
		public ICurveControlComponent ValueAsICurveControlComponent()
		{
			return this.Value<ICurveControlComponent>().Value;
		}

		// Token: 0x0602ABF8 RID: 175096 RVA: 0x005D39B4 File Offset: 0x005D1BB4
		public ISimpleCombatComponent ValueAsISimpleCombatComponent()
		{
			return this.Value<ISimpleCombatComponent>().Value;
		}

		// Token: 0x0602ABF9 RID: 175097 RVA: 0x005D39D0 File Offset: 0x005D1BD0
		public IGridObjectComponent ValueAsIGridObjectComponent()
		{
			return this.Value<IGridObjectComponent>().Value;
		}

		// Token: 0x0602ABFA RID: 175098 RVA: 0x005D39EC File Offset: 0x005D1BEC
		public IGodKingFrequencyControllerComponent ValueAsIGodKingFrequencyControllerComponent()
		{
			return this.Value<IGodKingFrequencyControllerComponent>().Value;
		}

		// Token: 0x0602ABFB RID: 175099 RVA: 0x005D3A08 File Offset: 0x005D1C08
		public IPerformanceOptimizationComponent ValueAsIPerformanceOptimizationComponent()
		{
			return this.Value<IPerformanceOptimizationComponent>().Value;
		}

		// Token: 0x0602ABFC RID: 175100 RVA: 0x005D3A24 File Offset: 0x005D1C24
		public ISceneItemEventListenerComponent ValueAsISceneItemEventListenerComponent()
		{
			return this.Value<ISceneItemEventListenerComponent>().Value;
		}

		// Token: 0x0602ABFD RID: 175101 RVA: 0x005D3A40 File Offset: 0x005D1C40
		public IDynamicSpawnMonsterPointComponent ValueAsIDynamicSpawnMonsterPointComponent()
		{
			return this.Value<IDynamicSpawnMonsterPointComponent>().Value;
		}

		// Token: 0x0602ABFE RID: 175102 RVA: 0x005D3A5C File Offset: 0x005D1C5C
		public IDynamicSpawnMonsterComponent ValueAsIDynamicSpawnMonsterComponent()
		{
			return this.Value<IDynamicSpawnMonsterComponent>().Value;
		}

		// Token: 0x0602ABFF RID: 175103 RVA: 0x005D3A78 File Offset: 0x005D1C78
		public ISunSpiritCollectComponent ValueAsISunSpiritCollectComponent()
		{
			return this.Value<ISunSpiritCollectComponent>().Value;
		}

		// Token: 0x0602AC00 RID: 175104 RVA: 0x005D3A94 File Offset: 0x005D1C94
		public ISunSpiritLauncherComponent ValueAsISunSpiritLauncherComponent()
		{
			return this.Value<ISunSpiritLauncherComponent>().Value;
		}

		// Token: 0x0602AC01 RID: 175105 RVA: 0x005D3AB0 File Offset: 0x005D1CB0
		public ISunSpiritGearComponent ValueAsISunSpiritGearComponent()
		{
			return this.Value<ISunSpiritGearComponent>().Value;
		}

		// Token: 0x0602AC02 RID: 175106 RVA: 0x005D3ACC File Offset: 0x005D1CCC
		public IMotorSlideComponent ValueAsIMotorSlideComponent()
		{
			return this.Value<IMotorSlideComponent>().Value;
		}

		// Token: 0x0602AC03 RID: 175107 RVA: 0x005D3AE8 File Offset: 0x005D1CE8
		public IProceduralVisualComponent ValueAsIProceduralVisualComponent()
		{
			return this.Value<IProceduralVisualComponent>().Value;
		}

		// Token: 0x0602AC04 RID: 175108 RVA: 0x005D3B04 File Offset: 0x005D1D04
		public IRoadNetworkNavigationComponent ValueAsIRoadNetworkNavigationComponent()
		{
			return this.Value<IRoadNetworkNavigationComponent>().Value;
		}

		// Token: 0x0602AC05 RID: 175109 RVA: 0x005D3B20 File Offset: 0x005D1D20
		public IFurnitureSlotComponent ValueAsIFurnitureSlotComponent()
		{
			return this.Value<IFurnitureSlotComponent>().Value;
		}

		// Token: 0x0602AC06 RID: 175110 RVA: 0x005D3B3C File Offset: 0x005D1D3C
		public IVisionDisplayComponent ValueAsIVisionDisplayComponent()
		{
			return this.Value<IVisionDisplayComponent>().Value;
		}

		// Token: 0x0602AC07 RID: 175111 RVA: 0x005D3B58 File Offset: 0x005D1D58
		public ISystemModuleDataSyncComponent ValueAsISystemModuleDataSyncComponent()
		{
			return this.Value<ISystemModuleDataSyncComponent>().Value;
		}

		// Token: 0x0602AC08 RID: 175112 RVA: 0x005D3B74 File Offset: 0x005D1D74
		public IExhibitComponent ValueAsIExhibitComponent()
		{
			return this.Value<IExhibitComponent>().Value;
		}

		// Token: 0x0602AC09 RID: 175113 RVA: 0x005D3B90 File Offset: 0x005D1D90
		public ITimeScheduleComponent ValueAsITimeScheduleComponent()
		{
			return this.Value<ITimeScheduleComponent>().Value;
		}

		// Token: 0x0602AC0A RID: 175114 RVA: 0x005D3BAC File Offset: 0x005D1DAC
		public IProjectorComponent ValueAsIProjectorComponent()
		{
			return this.Value<IProjectorComponent>().Value;
		}

		// Token: 0x0602AC0B RID: 175115 RVA: 0x005D3BC8 File Offset: 0x005D1DC8
		public IProceduralMaterialComponent ValueAsIProceduralMaterialComponent()
		{
			return this.Value<IProceduralMaterialComponent>().Value;
		}

		// Token: 0x0602AC0C RID: 175116 RVA: 0x005D3BE4 File Offset: 0x005D1DE4
		public IGameplayDataPersistenceComponent ValueAsIGameplayDataPersistenceComponent()
		{
			return this.Value<IGameplayDataPersistenceComponent>().Value;
		}

		// Token: 0x0602AC0D RID: 175117 RVA: 0x005D3C00 File Offset: 0x005D1E00
		public IFlowerPollutionComponent ValueAsIFlowerPollutionComponent()
		{
			return this.Value<IFlowerPollutionComponent>().Value;
		}

		// Token: 0x0602AC0E RID: 175118 RVA: 0x005D3C1C File Offset: 0x005D1E1C
		public IQuickHackComponent ValueAsIQuickHackComponent()
		{
			return this.Value<IQuickHackComponent>().Value;
		}

		// Token: 0x0602AC0F RID: 175119 RVA: 0x005D3C38 File Offset: 0x005D1E38
		public IDollGrabMachineComponent ValueAsIDollGrabMachineComponent()
		{
			return this.Value<IDollGrabMachineComponent>().Value;
		}

		// Token: 0x0602AC10 RID: 175120 RVA: 0x005D3C54 File Offset: 0x005D1E54
		public IDollGrabShowcaseComponent ValueAsIDollGrabShowcaseComponent()
		{
			return this.Value<IDollGrabShowcaseComponent>().Value;
		}

		// Token: 0x0602AC11 RID: 175121 RVA: 0x005D3C70 File Offset: 0x005D1E70
		public IWuWaGoComponent ValueAsIWuWaGoComponent()
		{
			return this.Value<IWuWaGoComponent>().Value;
		}

		// Token: 0x0602AC12 RID: 175122 RVA: 0x005D3C8C File Offset: 0x005D1E8C
		public IDragActorPlayComponent ValueAsIDragActorPlayComponent()
		{
			return this.Value<IDragActorPlayComponent>().Value;
		}

		// Token: 0x0602AC13 RID: 175123 RVA: 0x005D3CA8 File Offset: 0x005D1EA8
		public IPathDrivenActorSpawnerComponent ValueAsIPathDrivenActorSpawnerComponent()
		{
			return this.Value<IPathDrivenActorSpawnerComponent>().Value;
		}

		// Token: 0x0602AC14 RID: 175124 RVA: 0x005D3CC4 File Offset: 0x005D1EC4
		public IElementalHolderComponent ValueAsIElementalHolderComponent()
		{
			return this.Value<IElementalHolderComponent>().Value;
		}

		// Token: 0x0602AC15 RID: 175125 RVA: 0x005D3CE0 File Offset: 0x005D1EE0
		public IElementalEffectComponent ValueAsIElementalEffectComponent()
		{
			return this.Value<IElementalEffectComponent>().Value;
		}

		// Token: 0x0602AC16 RID: 175126 RVA: 0x005D3CFC File Offset: 0x005D1EFC
		public IElementalBoxFoundationComponent ValueAsIElementalBoxFoundationComponent()
		{
			return this.Value<IElementalBoxFoundationComponent>().Value;
		}

		// Token: 0x0602AC17 RID: 175127 RVA: 0x005D3D18 File Offset: 0x005D1F18
		public IElementalWellComponent ValueAsIElementalWellComponent()
		{
			return this.Value<IElementalWellComponent>().Value;
		}

		// Token: 0x0602AC18 RID: 175128 RVA: 0x005D3D34 File Offset: 0x005D1F34
		public IStreamingSourceTriggerPointComponent ValueAsIStreamingSourceTriggerPointComponent()
		{
			return this.Value<IStreamingSourceTriggerPointComponent>().Value;
		}

		// Token: 0x0602AC19 RID: 175129 RVA: 0x005D3D50 File Offset: 0x005D1F50
		public IGraph3dComponent ValueAsIGraph3dComponent()
		{
			return this.Value<IGraph3dComponent>().Value;
		}

		// Token: 0x0602AC1A RID: 175130 RVA: 0x005D3D6C File Offset: 0x005D1F6C
		public IGraph3dEffectComponent ValueAsIGraph3dEffectComponent()
		{
			return this.Value<IGraph3dEffectComponent>().Value;
		}

		// Token: 0x0602AC1B RID: 175131 RVA: 0x005D3D88 File Offset: 0x005D1F88
		public INoiseRemovalComponent ValueAsINoiseRemovalComponent()
		{
			return this.Value<INoiseRemovalComponent>().Value;
		}

		// Token: 0x0602AC1C RID: 175132 RVA: 0x005D3DA4 File Offset: 0x005D1FA4
		public IFrequencyPaintComponent ValueAsIFrequencyPaintComponent()
		{
			return this.Value<IFrequencyPaintComponent>().Value;
		}

		// Token: 0x0602AC1D RID: 175133 RVA: 0x005D3DC0 File Offset: 0x005D1FC0
		public ITurntableConnectorComponent ValueAsITurntableConnectorComponent()
		{
			return this.Value<ITurntableConnectorComponent>().Value;
		}

		// Token: 0x0602AC1E RID: 175134 RVA: 0x005D3DDB File Offset: 0x005D1FDB
		public static Offset<TComponentData> CreateTComponentData(FlatBufferBuilder builder, StringOffset keyOffset = default(StringOffset), IComponentBase_Union value_type = IComponentBase_Union.NONE, int valueOffset = 0)
		{
			builder.StartTable(3);
			TComponentData.AddValue(builder, valueOffset);
			TComponentData.AddKey(builder, keyOffset);
			TComponentData.AddValueType(builder, value_type);
			return TComponentData.EndTComponentData(builder);
		}

		// Token: 0x0602AC1F RID: 175135 RVA: 0x005D3DFF File Offset: 0x005D1FFF
		public static void StartTComponentData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602AC20 RID: 175136 RVA: 0x005D3E08 File Offset: 0x005D2008
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0602AC21 RID: 175137 RVA: 0x005D3E18 File Offset: 0x005D2018
		public static void AddValueType(FlatBufferBuilder builder, IComponentBase_Union valueType)
		{
			builder.AddByte(1, (byte)valueType, 0);
		}

		// Token: 0x0602AC22 RID: 175138 RVA: 0x005D3E23 File Offset: 0x005D2023
		public static void AddValue(FlatBufferBuilder builder, int valueOffset)
		{
			builder.AddOffset(2, valueOffset, 0);
		}

		// Token: 0x0602AC23 RID: 175139 RVA: 0x005D3E2E File Offset: 0x005D202E
		public static Offset<TComponentData> EndTComponentData(FlatBufferBuilder builder)
		{
			return new Offset<TComponentData>(builder.EndTable());
		}

		// Token: 0x0602AC24 RID: 175140 RVA: 0x005D3E3C File Offset: 0x005D203C
		public TComponentDataT UnPack()
		{
			TComponentDataT tcomponentDataT = new TComponentDataT();
			this.UnPackTo(tcomponentDataT);
			return tcomponentDataT;
		}

		// Token: 0x0602AC25 RID: 175141 RVA: 0x005D3E58 File Offset: 0x005D2058
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
			case IComponentBase_Union.IFrequencyPaintComponent:
				_o.Value.Value = ((this.Value<IFrequencyPaintComponent>() != null) ? this.Value<IFrequencyPaintComponent>().Value.UnPack() : null);
				return;
			case IComponentBase_Union.ITurntableConnectorComponent:
				_o.Value.Value = ((this.Value<ITurntableConnectorComponent>() != null) ? this.Value<ITurntableConnectorComponent>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602AC26 RID: 175142 RVA: 0x005D74F8 File Offset: 0x005D56F8
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

		// Token: 0x040100AF RID: 65711
		private Table __p;
	}
}
