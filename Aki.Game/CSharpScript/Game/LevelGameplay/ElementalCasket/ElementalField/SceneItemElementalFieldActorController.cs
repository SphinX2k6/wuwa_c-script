using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006EAD RID: 28333
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemElementalFieldActorController : IElementalFieldCameraBlockTarget
	{
		// Token: 0x06045052 RID: 282706 RVA: 0x0110DB5C File Offset: 0x0110BD5C
		public SceneItemElementalFieldActorController(string actorKey, List<int> entityPbDataIds)
		{
			this.ActorKey = actorKey;
			this.EntityPbDataIds = entityPbDataIds.GetRange(0, entityPbDataIds.Count);
			EventSystem.Instance.Add(EEventName.OnSceneItemElementalFieldReady, new Action<int>(this.OnFieldComponentReady));
		}

		// Token: 0x06045053 RID: 282707 RVA: 0x0110DBC6 File Offset: 0x0110BDC6
		private void OnFieldComponentReady(int pbDataId)
		{
			if (!this.EntityPbDataIds.Contains(pbDataId))
			{
				return;
			}
			this.TrySubscribeAll();
		}

		// Token: 0x06045054 RID: 282708 RVA: 0x0110DBE0 File Offset: 0x0110BDE0
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

		// Token: 0x06045055 RID: 282709 RVA: 0x0110DC72 File Offset: 0x0110BE72
		private void InitCameraBlock()
		{
			this.CameraBlockApplied = false;
			this.ApplyCameraBlockInternal(false);
			ElementalFieldCameraBlockController.Instance.RegisterTarget(this);
		}

		// Token: 0x06045056 RID: 282710 RVA: 0x0110DC8E File Offset: 0x0110BE8E
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

		// Token: 0x06045057 RID: 282711 RVA: 0x0110DCBE File Offset: 0x0110BEBE
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

		// Token: 0x06045058 RID: 282712 RVA: 0x0110DCF4 File Offset: 0x0110BEF4
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

		// Token: 0x06045059 RID: 282713 RVA: 0x0110DDEC File Offset: 0x0110BFEC
		private void UnsubscribeAll()
		{
			foreach (SceneItemElementalFieldComponent target in this.SubscribedComponents)
			{
				EventSystem.Instance.RemoveWithTarget(target, EEventName.OnSceneItemElementalFieldSnapshotChange, new Action<ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>>(this.OnSnapshotChange));
			}
			this.SubscribedComponents.Clear();
		}

		// Token: 0x0604505A RID: 282714 RVA: 0x0110DE60 File Offset: 0x0110C060
		[NullableContext(2)]
		private void OnSnapshotChange(ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType> snapshot)
		{
			this.Refresh();
		}

		// Token: 0x0604505B RID: 282715 RVA: 0x0110DE68 File Offset: 0x0110C068
		public void Destroy()
		{
			ElementalCasketModel.Instance.ElementalFieldAllControllers.Remove(this);
			EventSystem.Instance.Remove(EEventName.OnSceneItemElementalFieldReady, new Action<int>(this.OnFieldComponentReady));
			this.UnsubscribeAll();
			ElementalFieldCameraBlockController.Instance.UnregisterTarget(this);
			this.CameraBlockApplied = false;
			this.MeshComponent = null;
		}

		// Token: 0x0604505C RID: 282716 RVA: 0x0110DEC4 File Offset: 0x0110C0C4
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

		// Token: 0x0604505D RID: 282717 RVA: 0x0110DF5C File Offset: 0x0110C15C
		private void SetScalarParam(string paramName, float value)
		{
			if (!this.CheckComponent(paramName, value))
			{
				return;
			}
			FName? dynamicFName = FNameUtil.GetDynamicFName(paramName);
			this.MeshComponent.SetScalarParameterValueOnMaterials(dynamicFName ?? FNameUtil.NONE, value);
		}

		// Token: 0x0604505E RID: 282718 RVA: 0x0110DFA8 File Offset: 0x0110C1A8
		private void SetVectorParam(string paramName, FVector value)
		{
			if (!this.CheckComponent(paramName, value))
			{
				return;
			}
			FName? dynamicFName = FNameUtil.GetDynamicFName(paramName);
			this.MeshComponent.SetVectorParameterValueOnMaterials(dynamicFName ?? FNameUtil.NONE, value);
		}

		// Token: 0x0604505F RID: 282719 RVA: 0x0110DFF4 File Offset: 0x0110C1F4
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

		// Token: 0x06045060 RID: 282720 RVA: 0x0110E18C File Offset: 0x0110C38C
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

		// Token: 0x04023EE7 RID: 147175
		private readonly string ActorKey = "";

		// Token: 0x04023EE8 RID: 147176
		private readonly List<int> EntityPbDataIds = new List<int>();

		// Token: 0x04023EE9 RID: 147177
		[Nullable(2)]
		private UStaticMeshComponent MeshComponent;

		// Token: 0x04023EEA RID: 147178
		private readonly HashSet<SceneItemElementalFieldComponent> SubscribedComponents = new HashSet<SceneItemElementalFieldComponent>();

		// Token: 0x04023EEB RID: 147179
		private bool CameraBlockApplied;
	}
}
