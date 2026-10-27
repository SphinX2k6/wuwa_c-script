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
	// Token: 0x02006F65 RID: 28517
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class LevelAimLineController : ControllerBase
	{
		// Token: 0x060455EA RID: 284138 RVA: 0x0112BF14 File Offset: 0x0112A114
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

		// Token: 0x060455EB RID: 284139 RVA: 0x0112BFA4 File Offset: 0x0112A1A4
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

		// Token: 0x060455EC RID: 284140 RVA: 0x0112C044 File Offset: 0x0112A244
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

		// Token: 0x060455ED RID: 284141 RVA: 0x0112C118 File Offset: 0x0112A318
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

		// Token: 0x060455EE RID: 284142 RVA: 0x0112C184 File Offset: 0x0112A384
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
				FSplinePoint value2 = new FSplinePoint((float)i, vector2.ToUeVectorOld(), points[(i == 0) ? i : (i - 1)].ToUeVectorOld(), points[(i == points.Count - 1) ? i : (i + 1)].ToUeVectorOld(), Rotator.ZeroRotator, Vector.OneVector, value);
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

		// Token: 0x060455EF RID: 284143 RVA: 0x0112C2C0 File Offset: 0x0112A4C0
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

		// Token: 0x060455F0 RID: 284144 RVA: 0x0112C340 File Offset: 0x0112A540
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

		// Token: 0x060455F1 RID: 284145 RVA: 0x0112C6D8 File Offset: 0x0112A8D8
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

		// Token: 0x060455F2 RID: 284146 RVA: 0x0112C7A8 File Offset: 0x0112A9A8
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

		// Token: 0x17009B61 RID: 39777
		// (get) Token: 0x060455F3 RID: 284147 RVA: 0x0112C872 File Offset: 0x0112AA72
		public static LevelAimLineController Instance
		{
			get
			{
				return LevelAimLineController._Instance;
			}
		}

		// Token: 0x060455F4 RID: 284148 RVA: 0x0112C879 File Offset: 0x0112AA79
		public static LevelAimLineController GetOrCreateInstance()
		{
			if (LevelAimLineController._Instance == null)
			{
				LevelAimLineController.CreateInstance();
			}
			return LevelAimLineController._Instance;
		}

		// Token: 0x060455F5 RID: 284149 RVA: 0x0112C88D File Offset: 0x0112AA8D
		public static bool CreateInstance()
		{
			if (LevelAimLineController._Instance != null)
			{
				return true;
			}
			LevelAimLineController._Instance = new LevelAimLineController();
			return true;
		}

		// Token: 0x060455F6 RID: 284150 RVA: 0x0112C8A3 File Offset: 0x0112AAA3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060455F7 RID: 284151 RVA: 0x0112C8A5 File Offset: 0x0112AAA5
		public static void ResetStaticDefaultValue()
		{
			LevelAimLineController._Instance = null;
		}

		// Token: 0x060455F8 RID: 284152 RVA: 0x0112C8AD File Offset: 0x0112AAAD
		static LevelAimLineController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelAimLineController.CreateStaticDefaultValue), new Action(LevelAimLineController.ResetStaticDefaultValue));
		}

		// Token: 0x04024309 RID: 148233
		private const int UPDATE_MESH_INTERVAL = 1000;

		// Token: 0x0402430A RID: 148234
		private const string DATA_PATH = "/Game/Aki/Effect/MaterialController/ItemMaterial/DA_Fx_ActorItem_Scanning.DA_Fx_ActorItem_Scanning";

		// Token: 0x0402430B RID: 148235
		private readonly FName sightingTag = new FName("Manipulate_Targeted");

		// Token: 0x0402430C RID: 148236
		[Nullable(2)]
		private BP_Miaozhunxian_C Actor;

		// Token: 0x0402430D RID: 148237
		[Nullable(2)]
		private USplineComponent SplineComp;

		// Token: 0x0402430E RID: 148238
		private int? InstructionEffect;

		// Token: 0x0402430F RID: 148239
		private bool IsPlaying;

		// Token: 0x04024310 RID: 148240
		private bool IsShowMesh;

		// Token: 0x04024311 RID: 148241
		private double LastTraceTime;

		// Token: 0x04024312 RID: 148242
		[Nullable(2)]
		private BP_Miaozhunxian_Bullet_C BulletActor;

		// Token: 0x04024313 RID: 148243
		private List<AActor> ModifyMatActors = new List<AActor>();

		// Token: 0x04024314 RID: 148244
		private List<AActor> NeedModifyMatActors = new List<AActor>();

		// Token: 0x04024315 RID: 148245
		private readonly Dictionary<AActor, int> ActorMatDataHandleMap = new Dictionary<AActor, int>();

		// Token: 0x04024316 RID: 148246
		private List<EntityHandle> AddTagEntities = new List<EntityHandle>();

		// Token: 0x04024317 RID: 148247
		private List<EntityHandle> NeedAddTagEntities = new List<EntityHandle>();

		// Token: 0x04024318 RID: 148248
		[Nullable(2)]
		private ItemMaterialControllerActorData MatData;

		// Token: 0x04024319 RID: 148249
		[Nullable(2)]
		private static LevelAimLineController _Instance;
	}
}
