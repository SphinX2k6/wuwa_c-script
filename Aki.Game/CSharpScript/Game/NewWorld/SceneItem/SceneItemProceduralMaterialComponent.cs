using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200623F RID: 25151
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemProceduralMaterialComponent : EntityComponent
	{
		// Token: 0x0603CA2B RID: 248363 RVA: 0x0116299F File Offset: 0x01160B9F
		public bool HasCustomType(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType type)
		{
			return this.CustomPrimitiveDataConfigs.ContainsKey(type);
		}

		// Token: 0x0603CA2C RID: 248364 RVA: 0x011629B0 File Offset: 0x01160BB0
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			ProceduralMaterialComponent proceduralMaterialComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemProceduralMaterialComponent>() as ProceduralMaterialComponent;
			if (proceduralMaterialComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[ProceduralMaterialComp] 组件配置缺失";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.Config = proceduralMaterialComponent;
			return true;
		}

		// Token: 0x0603CA2D RID: 248365 RVA: 0x01162A38 File Offset: 0x01160C38
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			if (!this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			else
			{
				this.OnSceneInteractionLoadCompleted();
			}
			return true;
		}

		// Token: 0x0603CA2E RID: 248366 RVA: 0x01162A90 File Offset: 0x01160C90
		protected override bool OnEnd()
		{
			if (this.ChildEntityWaitTask != null)
			{
				this.ChildEntityWaitTask.Cancel();
			}
			this.ChildEntityWaitTask = null;
			if (this.MainEntityHandle != null && EventSystem.Instance.HasWithTarget<ERemoveEntityType, EntityHandle>(this.MainEntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnMainEntityRemove)))
			{
				EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(this.MainEntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnMainEntityRemove));
			}
			this.MainEntityHandle = null;
			this.CustomPrimitiveDataConfigs.Clear();
			return true;
		}

		// Token: 0x0603CA2F RID: 248367 RVA: 0x01162B18 File Offset: 0x01160D18
		private void OnSceneInteractionLoadCompleted()
		{
			SceneInteractionActor sceneInteractionActor = this.ActorComp.GetInteractionMainActor() as SceneInteractionActor;
			if (sceneInteractionActor == null)
			{
				return;
			}
			TMap<string, AActor> allActor = sceneInteractionActor.GetAllActor();
			if (allActor == null || allActor.Num() == 0)
			{
				return;
			}
			foreach (ICustomPrimitiveDataConfig customPrimitiveDataConfig in this.Config.ProceduralMaterialConfigs)
			{
				if (customPrimitiveDataConfig.Type == EProceduralMaterialType.CustomPrimitiveData)
				{
					ICustomPrimitiveDataConfig primitiveDataConfig = customPrimitiveDataConfig;
					this.ConstructCustomPrimitiveDataConfig(primitiveDataConfig, allActor, false);
				}
			}
		}

		// Token: 0x0603CA30 RID: 248368 RVA: 0x01162BA8 File Offset: 0x01160DA8
		[NullableContext(1)]
		private unsafe void ConstructCustomPrimitiveDataConfig(ICustomPrimitiveDataConfig primitiveDataConfig, TMap<string, AActor> allRefActors, bool fromOutside = false)
		{
			foreach (ICustomPrimitiveMapping customPrimitiveMapping in primitiveDataConfig.PrimitiveConfigs)
			{
				SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType? ecustomPrimitiveDataSceneItemType = null;
				if (customPrimitiveMapping.KeyPrefix == SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair.ToEnumString())
				{
					ecustomPrimitiveDataSceneItemType = new SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType?(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair);
				}
				if (ecustomPrimitiveDataSceneItemType == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[ProceduralMaterialComp] 不存在的交互物类型，请检查配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "PbDataId";
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("KeyPrefix", customPrimitiveMapping.KeyPrefix);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					if (!this.CustomPrimitiveDataConfigs.ContainsKey(ecustomPrimitiveDataSceneItemType.Value))
					{
						this.CustomPrimitiveDataConfigs[ecustomPrimitiveDataSceneItemType.Value] = new SceneItemProceduralMaterialComponent.CustomPrimitiveDataConfig(ecustomPrimitiveDataSceneItemType.Value);
					}
					SceneItemProceduralMaterialComponent.CustomPrimitiveDataConfig customPrimitiveDataConfig = this.CustomPrimitiveDataConfigs[ecustomPrimitiveDataSceneItemType.Value];
					if (!customPrimitiveDataConfig.IndexList.Contains(customPrimitiveMapping.Index))
					{
						customPrimitiveDataConfig.IndexList.Add(customPrimitiveMapping.Index);
					}
					foreach (KeyValuePair<string, AActor> keyValuePair in allRefActors)
					{
						string text;
						AActor aactor;
						keyValuePair.Deconstruct(out text, out aactor);
						string text2 = text;
						AActor aactor2 = aactor;
						if (aactor2 != null && text2.StartsWith(customPrimitiveMapping.KeyPrefix) && !customPrimitiveDataConfig.ReferenceActors.Contains(aactor2))
						{
							customPrimitiveDataConfig.ReferenceActors.Add(aactor2);
						}
					}
				}
			}
			if (primitiveDataConfig.IsChildEffective.GetValueOrDefault() && !fromOutside)
			{
				this.ConnectChildEntity();
			}
		}

		// Token: 0x0603CA31 RID: 248369 RVA: 0x01162DC4 File Offset: 0x01160FC4
		private void ConnectChildEntity()
		{
			SceneItemProceduralMaterialComponent.<>c__DisplayClass14_0 CS$<>8__locals1 = new SceneItemProceduralMaterialComponent.<>c__DisplayClass14_0();
			CS$<>8__locals1.<>4__this = this;
			SceneItemProceduralMaterialComponent.<>c__DisplayClass14_0 CS$<>8__locals2 = CS$<>8__locals1;
			CreatureDataComponent creatureDataComp = this.CreatureDataComp;
			List<int> childEntityIds;
			if (creatureDataComp == null)
			{
				childEntityIds = null;
			}
			else
			{
				BaseInfoComponent baseInfo = creatureDataComp.GetBaseInfo();
				childEntityIds = ((baseInfo != null) ? baseInfo.ChildEntityIds : null);
			}
			CS$<>8__locals2.childEntityIds = childEntityIds;
			if (CS$<>8__locals1.childEntityIds == null)
			{
				return;
			}
			if (this.ChildEntityWaitTask != null)
			{
				this.ChildEntityWaitTask.Cancel();
				this.ChildEntityWaitTask = null;
			}
			this.ChildEntityWaitTask = WaitEntityTask.CreateWithPbDataId("LevelConditionListenerCheckEntityHasSceneItemAttributeTag", CS$<>8__locals1.childEntityIds, delegate(bool? result)
			{
				if (!result.GetValueOrDefault())
				{
					return;
				}
				CS$<>8__locals1.<>4__this.ChildEntityWaitTask = null;
				foreach (int pbDataId in CS$<>8__locals1.childEntityIds)
				{
					EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
					if (entityByPbDataId == null || entityByPbDataId.Entity == null)
					{
						break;
					}
					SceneItemProceduralMaterialComponent component = entityByPbDataId.Entity.GetComponent<SceneItemProceduralMaterialComponent>();
					if (component == null)
					{
						break;
					}
					component.ConstructCustomPrimitiveDataConfigByMainEntity(CS$<>8__locals1.<>4__this.CreatureDataComp.GetPbDataId());
				}
			}, 60000, true, false);
		}

		// Token: 0x0603CA32 RID: 248370 RVA: 0x01162E50 File Offset: 0x01161050
		public void SetCustomPrimitiveData(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType type, float value)
		{
			SceneItemProceduralMaterialComponent.CustomPrimitiveDataConfig customPrimitiveDataConfig;
			this.CustomPrimitiveDataConfigs.TryGetValue(type, out customPrimitiveDataConfig);
			if (customPrimitiveDataConfig == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[ProceduralMaterialComp] 没有记录该类型交互物的数据，请检查配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			foreach (AActor aactor in customPrimitiveDataConfig.ReferenceActors)
			{
				if (aactor != null && aactor.IsValid())
				{
					TArray<UActorComponent> tarray = aactor.K2_GetComponentsByClass(UStaticMeshComponent.StaticClass());
					if (tarray.Num() != 0)
					{
						for (int i = 0; i < tarray.Num(); i++)
						{
							UStaticMeshComponent ustaticMeshComponent = tarray.Get(i) as UStaticMeshComponent;
							if (ustaticMeshComponent != null)
							{
								foreach (int dataIndex in customPrimitiveDataConfig.IndexList)
								{
									ustaticMeshComponent.SetDefaultCustomPrimitiveDataFloat(dataIndex, value);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0603CA33 RID: 248371 RVA: 0x01162F80 File Offset: 0x01161180
		public void ConstructCustomPrimitiveDataConfigByMainEntity(int mainEntityId)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(mainEntityId);
			if (entityByPbDataId == null || entityByPbDataId.Entity == null)
			{
				return;
			}
			this.MainEntityHandle = entityByPbDataId;
			SceneItemActorComponent component = entityByPbDataId.Entity.GetComponent<SceneItemActorComponent>();
			if (component == null)
			{
				return;
			}
			SceneInteractionActor sceneInteractionActor = component.GetInteractionMainActor() as SceneInteractionActor;
			if (sceneInteractionActor == null)
			{
				return;
			}
			TMap<string, AActor> allActor = sceneInteractionActor.GetAllActor();
			if (allActor == null)
			{
				return;
			}
			foreach (ICustomPrimitiveDataConfig customPrimitiveDataConfig in this.Config.ProceduralMaterialConfigs)
			{
				if (customPrimitiveDataConfig.Type == EProceduralMaterialType.CustomPrimitiveData)
				{
					ICustomPrimitiveDataConfig primitiveDataConfig = customPrimitiveDataConfig;
					this.ConstructCustomPrimitiveDataConfig(primitiveDataConfig, allActor, false);
				}
			}
			if (!EventSystem.Instance.HasWithTarget<ERemoveEntityType, EntityHandle>(entityByPbDataId, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnMainEntityRemove)))
			{
				EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(entityByPbDataId, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnMainEntityRemove));
			}
		}

		// Token: 0x0603CA34 RID: 248372 RVA: 0x01163070 File Offset: 0x01161270
		[NullableContext(1)]
		private void OnMainEntityRemove(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (handle != this.MainEntityHandle)
			{
				return;
			}
			this.MainEntityHandle = null;
			this.CustomPrimitiveDataConfigs.Clear();
			EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnMainEntityRemove));
		}

		// Token: 0x0603CA35 RID: 248373 RVA: 0x011630AC File Offset: 0x011612AC
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemProceduralMaterialComponent sceneItemProceduralMaterialComponent = (SceneItemProceduralMaterialComponent)componentTemplate;
			if (sceneItemProceduralMaterialComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemProceduralMaterialComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemProceduralMaterialComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemProceduralMaterialComponent.ChildEntityWaitTask == null)
			{
				this.ChildEntityWaitTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChildEntityWaitTask), "ChildEntityWaitTask"))
			{
				return false;
			}
			if (sceneItemProceduralMaterialComponent.MainEntityHandle == null)
			{
				this.MainEntityHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MainEntityHandle), "MainEntityHandle"))
			{
				return false;
			}
			return sceneItemProceduralMaterialComponent.CustomPrimitiveDataConfigs == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.CustomPrimitiveDataConfigs), "CustomPrimitiveDataConfigs");
		}

		// Token: 0x170072AF RID: 29359
		// (get) Token: 0x0603CA36 RID: 248374 RVA: 0x011631C5 File Offset: 0x011613C5
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170072B0 RID: 29360
		// (get) Token: 0x0603CA37 RID: 248375 RVA: 0x011631C8 File Offset: 0x011613C8
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402024D RID: 131661
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0402024E RID: 131662
		private SceneItemActorComponent ActorComp;

		// Token: 0x0402024F RID: 131663
		private ProceduralMaterialComponent Config;

		// Token: 0x04020250 RID: 131664
		private WaitEntityTask ChildEntityWaitTask;

		// Token: 0x04020251 RID: 131665
		private EntityHandle MainEntityHandle;

		// Token: 0x04020252 RID: 131666
		[Nullable(1)]
		private readonly Dictionary<SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType, SceneItemProceduralMaterialComponent.CustomPrimitiveDataConfig> CustomPrimitiveDataConfigs = new Dictionary<SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType, SceneItemProceduralMaterialComponent.CustomPrimitiveDataConfig>();

		// Token: 0x0200BA73 RID: 47731
		[NullableContext(0)]
		[EnumExtensions]
		public enum ECustomPrimitiveDataSceneItemType
		{
			// Token: 0x040396E8 RID: 235240
			Chair
		}

		// Token: 0x0200BA74 RID: 47732
		[NullableContext(1)]
		[Nullable(0)]
		private class CustomPrimitiveDataConfig
		{
			// Token: 0x06048764 RID: 296804 RVA: 0x0161860C File Offset: 0x0161680C
			public CustomPrimitiveDataConfig(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType type)
			{
				this.Type = type;
			}

			// Token: 0x040396E9 RID: 235241
			public SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType Type;

			// Token: 0x040396EA RID: 235242
			public List<int> IndexList = new List<int>();

			// Token: 0x040396EB RID: 235243
			public List<AActor> ReferenceActors = new List<AActor>();
		}
	}
}
