using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Game.LevelGamePlay.ElementalCasket.ElementalField;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x0200602D RID: 24621
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemElementalFieldActorController : IElementalFieldCameraBlockTarget
	{
		// Token: 0x0603B1F3 RID: 242163 RVA: 0x010B7C38 File Offset: 0x010B5E38
		public SceneItemElementalFieldActorController(string actorKey, List<int> entityPbDataIds)
		{
			this.ActorKey = actorKey;
			this.EntityPbDataIds = entityPbDataIds.GetRange(0, entityPbDataIds.Count);
			EventSystem.Instance.Add(EEventName.OnSceneItemElementalFieldReady, new Action<int>(this.OnFieldComponentReady));
		}

		// Token: 0x0603B1F4 RID: 242164 RVA: 0x010B7CA2 File Offset: 0x010B5EA2
		private void OnFieldComponentReady(int pbDataId)
		{
			if (!this.EntityPbDataIds.Contains(pbDataId))
			{
				return;
			}
			this.TrySubscribeAll();
		}

		// Token: 0x0603B1F5 RID: 242165 RVA: 0x010B7CBC File Offset: 0x010B5EBC
		public void OnActorReady(AActor actor)
		{
			UStaticMeshComponent ustaticMeshComponent = actor.GetComponentByClass(UStaticMeshComponent.StaticClass()) as UStaticMeshComponent;
			if (ustaticMeshComponent == null || !ustaticMeshComponent.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[SceneItemElementalFieldActorController]Actor缺少StaticMeshComponent";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actorKey", this.ActorKey);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.MeshComponent = ustaticMeshComponent;
			this.MeshComponent.SetCollisionProfileName(FNameUtil.GetDynamicFName("Custom").Value, true);
			this.InitCameraBlock();
			this.TrySubscribeAll();
		}

		// Token: 0x0603B1F6 RID: 242166 RVA: 0x010B7D4E File Offset: 0x010B5F4E
		private void InitCameraBlock()
		{
			this.CameraBlockApplied = false;
			this.ApplyCameraBlockInternal(false);
			ElementalFieldCameraBlockController.Instance.RegisterTarget(this);
		}

		// Token: 0x0603B1F7 RID: 242167 RVA: 0x010B7D6A File Offset: 0x010B5F6A
		public bool ApplyCameraBlock(bool block)
		{
			if (this.CameraBlockApplied == block)
			{
				UStaticMeshComponent meshComponent = this.MeshComponent;
				return meshComponent != null && meshComponent.IsValid();
			}
			if (!this.ApplyCameraBlockInternal(block))
			{
				return false;
			}
			this.CameraBlockApplied = block;
			return true;
		}

		// Token: 0x0603B1F8 RID: 242168 RVA: 0x010B7D9A File Offset: 0x010B5F9A
		private bool ApplyCameraBlockInternal(bool block)
		{
			UStaticMeshComponent meshComponent = this.MeshComponent;
			if (meshComponent == null || !meshComponent.IsValid())
			{
				return false;
			}
			this.MeshComponent.SetCollisionResponseToChannel(ElementalCasketDefine.elementalFieldCameraBlockChannel, block ? ECollisionResponse.ECR_Block : ECollisionResponse.ECR_Ignore);
			return true;
		}

		// Token: 0x0603B1F9 RID: 242169 RVA: 0x010B7DD0 File Offset: 0x010B5FD0
		public void TrySubscribeAll()
		{
			ElementalCasketModel.Instance.ElementalFieldAllControllers.Add(this);
			foreach (int num in this.EntityPbDataIds)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
				WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
				if (worldEntity != null)
				{
					SceneItemElementalFieldComponent sceneItemElementalFieldComponent = worldEntity.CheckGetComponent<SceneItemElementalFieldComponent>();
					if (sceneItemElementalFieldComponent == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.LevelPlay;
						ELogAuthor author = ELogAuthor.XDW;
						string message = "[SceneItemElementalFieldActorController]Entity缺少SceneItemElementalFieldComponent";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pbDataId", num);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else if (!this.SubscribedComponents.Contains(sceneItemElementalFieldComponent))
					{
						this.SubscribedComponents.Add(sceneItemElementalFieldComponent);
						EventSystem.Instance.AddWithTarget(sceneItemElementalFieldComponent, EEventName.OnSceneItemElementalFieldSnapshotChange, new Action<ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>>(this.OnSnapshotChange));
					}
				}
			}
			this.Refresh();
		}

		// Token: 0x0603B1FA RID: 242170 RVA: 0x010B7EC8 File Offset: 0x010B60C8
		private void UnsubscribeAll()
		{
			foreach (SceneItemElementalFieldComponent target in this.SubscribedComponents)
			{
				EventSystem.Instance.RemoveWithTarget(target, EEventName.OnSceneItemElementalFieldSnapshotChange, new Action<ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>>(this.OnSnapshotChange));
			}
			this.SubscribedComponents.Clear();
		}

		// Token: 0x0603B1FB RID: 242171 RVA: 0x010B7F3C File Offset: 0x010B613C
		[NullableContext(2)]
		private void OnSnapshotChange(ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType> snapshot)
		{
			this.Refresh();
		}

		// Token: 0x0603B1FC RID: 242172 RVA: 0x010B7F44 File Offset: 0x010B6144
		public void Destroy()
		{
			ElementalCasketModel.Instance.ElementalFieldAllControllers.Remove(this);
			EventSystem.Instance.Remove(EEventName.OnSceneItemElementalFieldReady, new Action<int>(this.OnFieldComponentReady));
			this.UnsubscribeAll();
			ElementalFieldCameraBlockController.Instance.UnregisterTarget(this);
			this.CameraBlockApplied = false;
			this.MeshComponent = null;
		}

		// Token: 0x0603B1FD RID: 242173 RVA: 0x010B7FA0 File Offset: 0x010B61A0
		private unsafe bool CheckComponent(string paramName, object value)
		{
			UStaticMeshComponent meshComponent = this.MeshComponent;
			if (meshComponent == null || !meshComponent.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[SceneItemElementalFieldActorController]MeshComponent无效";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actorKey", this.ActorKey);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("paramName", paramName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("value", value);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			return true;
		}

		// Token: 0x0603B1FE RID: 242174 RVA: 0x010B8038 File Offset: 0x010B6238
		private void SetScalarParam(string paramName, float value)
		{
			if (!this.CheckComponent(paramName, value))
			{
				return;
			}
			FName? dynamicFName = FNameUtil.GetDynamicFName(paramName);
			this.MeshComponent.SetScalarParameterValueOnMaterials(dynamicFName ?? FNameUtil.NONE, value);
		}

		// Token: 0x0603B1FF RID: 242175 RVA: 0x010B8084 File Offset: 0x010B6284
		private void SetVectorParam(string paramName, FVector value)
		{
			if (!this.CheckComponent(paramName, value))
			{
				return;
			}
			FName? dynamicFName = FNameUtil.GetDynamicFName(paramName);
			this.MeshComponent.SetVectorParameterValueOnMaterials(dynamicFName ?? FNameUtil.NONE, value);
		}

		// Token: 0x0603B200 RID: 242176 RVA: 0x010B80D0 File Offset: 0x010B62D0
		private void Refresh()
		{
			UStaticMeshComponent meshComponent = this.MeshComponent;
			if (meshComponent == null || !meshComponent.IsValid())
			{
				return;
			}
			if (this.MeshComponent.GetCollisionResponseToChannel(KuroCollisionChannel.PawnPlayer) != ECollisionResponse.ECR_Block)
			{
				this.MeshComponent.SetCollisionResponseToChannel(KuroCollisionChannel.PawnPlayer, ECollisionResponse.ECR_Block);
			}
			if (this.MeshComponent.GetCollisionObjectType() != ElementalCasketModel.Instance.FireElementalFieldBlockTarget.TargetChannel)
			{
				this.MeshComponent.SetCollisionObjectType(ElementalCasketModel.Instance.FireElementalFieldBlockTarget.TargetChannel);
			}
			if (this.MeshComponent.GetCollisionResponseToChannel(ElementalCasketDefine.coneTraceCollisionChannel) == ECollisionResponse.ECR_Block)
			{
				this.MeshComponent.SetCollisionResponseToChannel(ElementalCasketDefine.coneTraceCollisionChannel, ECollisionResponse.ECR_Ignore);
			}
			if (this.MeshComponent.GetCollisionEnabled() != ECollisionEnabled.QueryOnly)
			{
				this.MeshComponent.SetCollisionEnabled(ECollisionEnabled.QueryOnly);
			}
			if (!this.MeshComponent.GetGenerateOverlapEvents())
			{
				this.MeshComponent.SetGenerateOverlapEvents(true);
			}
			List<ISceneItemElementalFieldSphereSnapshot> list = new List<ISceneItemElementalFieldSphereSnapshot>();
			ISceneItemElementalFieldConeSnapshot sceneItemElementalFieldConeSnapshot = null;
			foreach (SceneItemElementalFieldComponent sceneItemElementalFieldComponent in this.SubscribedComponents)
			{
				ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType> snapshot = sceneItemElementalFieldComponent.GetSnapshot();
				if (snapshot != null && snapshot.Enabled)
				{
					if (snapshot.ShapeType == ESceneItemElementalFieldShapeType.Sphere)
					{
						if (list.Count < 2)
						{
							list.Add((ISceneItemElementalFieldSphereSnapshot)snapshot);
						}
					}
					else if (snapshot.ShapeType == ESceneItemElementalFieldShapeType.Cone && sceneItemElementalFieldConeSnapshot == null)
					{
						sceneItemElementalFieldConeSnapshot = (ISceneItemElementalFieldConeSnapshot)snapshot;
					}
				}
			}
			this.ApplyParams(list, sceneItemElementalFieldConeSnapshot);
		}

		// Token: 0x0603B201 RID: 242177 RVA: 0x010B8268 File Offset: 0x010B6468
		private void ApplyParams(List<ISceneItemElementalFieldSphereSnapshot> spheres, [Nullable(2)] ISceneItemElementalFieldConeSnapshot cone)
		{
			for (int i = 0; i < 2; i++)
			{
				ISceneItemElementalFieldSphereSnapshot sceneItemElementalFieldSphereSnapshot = (i < spheres.Count) ? spheres[i] : null;
				if (sceneItemElementalFieldSphereSnapshot != null)
				{
					this.SetScalarParam(ElementalCasketDefine.PARAM_SPHERE_ENABLE[i], 1f);
					this.SetScalarParam(ElementalCasketDefine.PARAM_SPHERE_RADIUS[i], (float)sceneItemElementalFieldSphereSnapshot.SphereRadius);
					this.SetVectorParam(ElementalCasketDefine.PARAM_SPHERE_CENTER[i], sceneItemElementalFieldSphereSnapshot.Center.ToVector());
				}
				else
				{
					this.SetScalarParam(ElementalCasketDefine.PARAM_SPHERE_ENABLE[i], 0f);
				}
			}
			if (cone != null)
			{
				this.SetScalarParam("InfluenceCone_Enable", 1f);
				this.SetScalarParam("InfluenceCone_HalfAngle", (float)cone.ConeHalfAngle);
				this.SetScalarParam("Range", (float)cone.ConeHeight);
				this.SetVectorParam("LightPos", cone.Center.ToVector());
				this.SetVectorParam("LightDir", cone.ConeAxis);
				return;
			}
			this.SetScalarParam("InfluenceCone_Enable", 0f);
		}

		// Token: 0x0401F19A RID: 127386
		private readonly string ActorKey = "";

		// Token: 0x0401F19B RID: 127387
		private readonly List<int> EntityPbDataIds = new List<int>();

		// Token: 0x0401F19C RID: 127388
		[Nullable(2)]
		private UStaticMeshComponent MeshComponent;

		// Token: 0x0401F19D RID: 127389
		private readonly HashSet<SceneItemElementalFieldComponent> SubscribedComponents = new HashSet<SceneItemElementalFieldComponent>();

		// Token: 0x0401F19E RID: 127390
		private bool CameraBlockApplied;
	}
}
