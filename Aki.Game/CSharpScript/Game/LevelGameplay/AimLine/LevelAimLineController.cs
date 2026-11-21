using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.PathLine;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem.Model;
using CSharpScript.Game.Render;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.AimLine
{
	// Token: 0x020060E6 RID: 24806
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class LevelAimLineController : ControllerBase
	{
		// Token: 0x0603B798 RID: 243608 RVA: 0x010D5CF4 File Offset: 0x010D3EF4
		protected override bool OnInit()
		{
			ResourceSystem.Instance.LoadTypeAsync("BP_Miaozhunxian_C", delegate
			{
				this.Actor = (ActorSystem.Instance.Get(BP_Miaozhunxian_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_Miaozhunxian_C);
				if (this.Actor != null && this.Actor.IsValid())
				{
					this.SplineComp = (this.Actor.GetComponentByClass(USplineComponent.StaticClass()) as USplineComponent);
					this.Actor.Init();
				}
			}, "js_undefined");
			ResourceSystem.Instance.LoadTypeAsync("BP_Miaozhunxian_Bullet_C", delegate
			{
				this.BulletActor = (ActorSystem.Instance.Get(BP_Miaozhunxian_Bullet_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_Miaozhunxian_Bullet_C);
				if (this.BulletActor != null && this.BulletActor.IsValid())
				{
					this.BulletActor.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.BeginOverlap));
				}
			}, "js_undefined");
			ResourceSystem.Instance.LoadAsync<ItemMaterialControllerActorData>("/Game/Aki/Effect/MaterialController/ItemMaterial/DA_Fx_ActorItem_Scanning.DA_Fx_ActorItem_Scanning", delegate([Nullable(2)] ItemMaterialControllerActorData asset, string _)
			{
				this.MatData = asset;
			}, 100, "js_undefined");
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x0603B799 RID: 243609 RVA: 0x010D5D84 File Offset: 0x010D3F84
		protected override bool OnClear()
		{
			if (this.Actor != null && this.Actor.IsValid())
			{
				ActorSystem.Instance.Put("LevelAimLineController.OnClear1", this.Actor, null);
			}
			if (this.BulletActor != null && this.BulletActor.IsValid())
			{
				ActorSystem.Instance.Put("LevelAimLineController.OnClear2", this.BulletActor, null);
			}
			if (EventSystem.Instance.Has(EEventName.WorldDone, new Action(this.OnWorldDone)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			}
			return true;
		}

		// Token: 0x0603B79A RID: 243610 RVA: 0x010D5E24 File Offset: 0x010D4024
		[NullableContext(2)]
		public bool PlayEffect(string effectPath = null)
		{
			if (this.IsPlaying)
			{
				return false;
			}
			this.IsPlaying = true;
			if (string.IsNullOrEmpty(effectPath))
			{
				this.IsShowMesh = true;
				this.Actor.ShowMesh();
			}
			else
			{
				EffectSystem instance = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(MathUtils.Instance.DefaultTransformDouble);
				this.InstructionEffect = new int?(instance.SpawnEffect(world, ftransformDouble, effectPath, "[LevelAimLineController.PlayEffect]", new EffectContext(null, this.Actor, false), EEffectType.Scene, null, null, null, false, false));
				if (!EffectSystem.Instance.IsValid(this.InstructionEffect.GetValueOrDefault()))
				{
					return false;
				}
				OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.InstructionEffect.Value);
				AActor actor = this.Actor;
				FName? fname = null;
				effectActor.K2_AttachToActor(actor, fname, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
			}
			return true;
		}

		// Token: 0x0603B79B RID: 243611 RVA: 0x010D5EF8 File Offset: 0x010D40F8
		public bool StopEffect()
		{
			if (!this.IsPlaying)
			{
				return false;
			}
			this.IsPlaying = false;
			if (this.IsShowMesh)
			{
				this.Actor.HideMesh();
			}
			else
			{
				EffectSystem.Instance.StopEffectById(this.InstructionEffect.GetValueOrDefault(), "[LevelAimLineController.StopEffect]", true, null);
				this.InstructionEffect = null;
			}
			this.ClearTagOrMat();
			return true;
		}

		// Token: 0x0603B79C RID: 243612 RVA: 0x010D5F64 File Offset: 0x010D4164
		public bool UpdatePoints(List<Vector> points, EAimLineType type)
		{
			if (points == null || points.Count <= 0)
			{
				return false;
			}
			Vector vector = points[0];
			Vector vector2 = Vector.Create();
			this.Actor.D_K2_SetActorLocation(vector.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, true);
			TArray<FSplinePoint> tarray = new TArray<FSplinePoint>();
			ESplinePointType value;
			if (type == EAimLineType.Line)
			{
				value = ESplinePointType.Linear;
			}
			else
			{
				value = ESplinePointType.Curve;
			}
			for (int i = 0; i < points.Count; i++)
			{
				points[i].Subtraction(vector, vector2);
				FSplinePoint value2 = new FSplinePoint
				{
					InputKey = (float)i,
					Position = vector2.ToUeVectorOld(),
					ArriveTangent = points[(i == 0) ? i : (i - 1)].ToUeVectorOld(),
					LeaveTangent = points[(i == points.Count - 1) ? i : (i + 1)].ToUeVectorOld(),
					Scale = Vector.OneVector,
					Type = value
				};
				tarray.Add(value2);
			}
			this.SplineComp.ClearSplinePoints(true);
			this.SplineComp.AddPoints(tarray, true);
			this.SplineComp.UpdateSpline();
			this.Actor.UpdateMesh();
			if (Time.Instance.WorldTime - this.LastTraceTime > 1000.0)
			{
				this.LastTraceTime = Time.Instance.WorldTime;
				this.CheckCollision();
			}
			return true;
		}

		// Token: 0x0603B79D RID: 243613 RVA: 0x010D60C4 File Offset: 0x010D42C4
		[NullableContext(2)]
		private void BeginOverlap(AActor overlappedActor, AActor otherActor)
		{
			if (otherActor.Tags.Contains(this.sightingTag))
			{
				if (!this.NeedModifyMatActors.Contains(otherActor))
				{
					this.NeedModifyMatActors.Add(otherActor);
				}
				return;
			}
			EntityHandle entityByActor = SceneInteractionModel.Instance.GetEntityByActor(otherActor, false);
			if (entityByActor != null)
			{
				SceneItemHitComponent component = entityByActor.Entity.GetComponent<SceneItemHitComponent>();
				if (component != null && component.Valid && !this.NeedAddTagEntities.Contains(entityByActor))
				{
					this.NeedAddTagEntities.Add(entityByActor);
				}
			}
		}

		// Token: 0x0603B79E RID: 243614 RVA: 0x010D6144 File Offset: 0x010D4344
		private void CheckCollision()
		{
			this.BulletActor.D_K2_SetActorLocation(this.Actor.D_K2_GetActorLocation(), true, ref WorldGlobal.SweepHitResult, false);
			float num = this.SplineComp.GetSplineLength() / (this.Actor.SamplingNum - 1f);
			int num2 = 0;
			while ((float)num2 < this.Actor.SamplingNum)
			{
				FVectorDouble newLocation = this.SplineComp.D_GetLocationAtDistanceAlongSpline((float)(num2 + 1) * num, ESplineCoordinateSpace.World);
				this.BulletActor.D_K2_SetActorLocation(newLocation, true, ref WorldGlobal.SweepHitResult, false);
				num2++;
			}
			List<AActor> list = new List<AActor>();
			foreach (AActor item in this.ModifyMatActors)
			{
				if (!this.NeedModifyMatActors.Contains(item))
				{
					list.Add(item);
				}
			}
			foreach (AActor key in list)
			{
				int handle;
				if (this.ActorMatDataHandleMap.TryGetValue(key, out handle))
				{
					ItemMaterialManager.Instance.DisableActorData(handle);
					this.ActorMatDataHandleMap.Remove(key);
				}
			}
			List<AActor> list2 = new List<AActor>();
			foreach (AActor item2 in this.NeedModifyMatActors)
			{
				if (!this.ModifyMatActors.Contains(item2))
				{
					list2.Add(item2);
				}
			}
			foreach (AActor aactor in list2)
			{
				int value = ItemMaterialManager.Instance.AddMaterialData(aactor, this.MatData);
				this.ActorMatDataHandleMap[aactor] = value;
			}
			this.ModifyMatActors = this.NeedModifyMatActors;
			this.NeedModifyMatActors = new List<AActor>();
			List<EntityHandle> list3 = new List<EntityHandle>();
			foreach (EntityHandle item3 in this.AddTagEntities)
			{
				if (!this.NeedAddTagEntities.Contains(item3))
				{
					list3.Add(item3);
				}
			}
			foreach (EntityHandle entityHandle in list3)
			{
				if (entityHandle != null && entityHandle.Valid)
				{
					entityHandle.Entity.GetComponent<SceneItemPropertyComponent>().SetIsBeingTargeted(false);
				}
			}
			List<EntityHandle> list4 = new List<EntityHandle>();
			foreach (EntityHandle item4 in this.NeedAddTagEntities)
			{
				if (!this.AddTagEntities.Contains(item4))
				{
					list4.Add(item4);
				}
			}
			foreach (EntityHandle entityHandle2 in list4)
			{
				if (entityHandle2 != null && entityHandle2.Valid)
				{
					entityHandle2.Entity.GetComponent<SceneItemPropertyComponent>().SetIsBeingTargeted(true);
				}
			}
			this.AddTagEntities = this.NeedAddTagEntities;
			this.NeedAddTagEntities = new List<EntityHandle>();
		}

		// Token: 0x0603B79F RID: 243615 RVA: 0x010D64DC File Offset: 0x010D46DC
		private void ClearTagOrMat()
		{
			foreach (EntityHandle entityHandle in this.AddTagEntities)
			{
				if (entityHandle != null && entityHandle.Valid)
				{
					entityHandle.Entity.GetComponent<SceneItemPropertyComponent>().SetIsBeingTargeted(false);
				}
			}
			foreach (AActor key in this.ModifyMatActors)
			{
				int handle;
				if (this.ActorMatDataHandleMap.TryGetValue(key, out handle))
				{
					ItemMaterialManager.Instance.DisableActorData(handle);
					this.ActorMatDataHandleMap.Remove(key);
				}
			}
		}

		// Token: 0x0603B7A0 RID: 243616 RVA: 0x010D65AC File Offset: 0x010D47AC
		private void OnWorldDone()
		{
			if (this.Actor == null || !this.Actor.IsValid())
			{
				this.Actor = (ActorSystem.Instance.Get(BP_Miaozhunxian_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_Miaozhunxian_C);
				this.SplineComp = (this.Actor.GetComponentByClass(USplineComponent.StaticClass()) as USplineComponent);
				this.Actor.Init();
			}
			if (this.BulletActor == null || !this.BulletActor.IsValid())
			{
				this.BulletActor = (ActorSystem.Instance.Get(BP_Miaozhunxian_Bullet_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_Miaozhunxian_Bullet_C);
				this.BulletActor.OnActorBeginOverlap.Add(new Action<AActor, AActor>(this.BeginOverlap));
			}
		}

		// Token: 0x170070A0 RID: 28832
		// (get) Token: 0x0603B7A1 RID: 243617 RVA: 0x010D6676 File Offset: 0x010D4876
		public static LevelAimLineController Instance
		{
			get
			{
				return LevelAimLineController._Instance;
			}
		}

		// Token: 0x0603B7A2 RID: 243618 RVA: 0x010D667D File Offset: 0x010D487D
		public static LevelAimLineController GetOrCreateInstance()
		{
			if (LevelAimLineController._Instance == null)
			{
				LevelAimLineController.CreateInstance();
			}
			return LevelAimLineController._Instance;
		}

		// Token: 0x0603B7A3 RID: 243619 RVA: 0x010D6691 File Offset: 0x010D4891
		public static bool CreateInstance()
		{
			if (LevelAimLineController._Instance != null)
			{
				return true;
			}
			LevelAimLineController._Instance = new LevelAimLineController();
			return true;
		}

		// Token: 0x0603B7A4 RID: 243620 RVA: 0x010D66A7 File Offset: 0x010D48A7
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B7A5 RID: 243621 RVA: 0x010D66A9 File Offset: 0x010D48A9
		public static void ResetStaticDefaultValue()
		{
			LevelAimLineController._Instance = null;
		}

		// Token: 0x0603B7A6 RID: 243622 RVA: 0x010D66B1 File Offset: 0x010D48B1
		static LevelAimLineController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelAimLineController.CreateStaticDefaultValue), new Action(LevelAimLineController.ResetStaticDefaultValue));
		}

		// Token: 0x0401F5BE RID: 128446
		private const int UPDATE_MESH_INTERVAL = 1000;

		// Token: 0x0401F5BF RID: 128447
		private const string DATA_PATH = "/Game/Aki/Effect/MaterialController/ItemMaterial/DA_Fx_ActorItem_Scanning.DA_Fx_ActorItem_Scanning";

		// Token: 0x0401F5C0 RID: 128448
		private readonly FName sightingTag = new FName("Manipulate_Targeted");

		// Token: 0x0401F5C1 RID: 128449
		[Nullable(2)]
		private BP_Miaozhunxian_C Actor;

		// Token: 0x0401F5C2 RID: 128450
		[Nullable(2)]
		private USplineComponent SplineComp;

		// Token: 0x0401F5C3 RID: 128451
		private int? InstructionEffect;

		// Token: 0x0401F5C4 RID: 128452
		private bool IsPlaying;

		// Token: 0x0401F5C5 RID: 128453
		private bool IsShowMesh;

		// Token: 0x0401F5C6 RID: 128454
		private double LastTraceTime;

		// Token: 0x0401F5C7 RID: 128455
		[Nullable(2)]
		private BP_Miaozhunxian_Bullet_C BulletActor;

		// Token: 0x0401F5C8 RID: 128456
		private List<AActor> ModifyMatActors = new List<AActor>();

		// Token: 0x0401F5C9 RID: 128457
		private List<AActor> NeedModifyMatActors = new List<AActor>();

		// Token: 0x0401F5CA RID: 128458
		private readonly Dictionary<AActor, int> ActorMatDataHandleMap = new Dictionary<AActor, int>();

		// Token: 0x0401F5CB RID: 128459
		private List<EntityHandle> AddTagEntities = new List<EntityHandle>();

		// Token: 0x0401F5CC RID: 128460
		private List<EntityHandle> NeedAddTagEntities = new List<EntityHandle>();

		// Token: 0x0401F5CD RID: 128461
		[Nullable(2)]
		private ItemMaterialControllerActorData MatData;

		// Token: 0x0401F5CE RID: 128462
		[Nullable(2)]
		private static LevelAimLineController _Instance;
	}
}
