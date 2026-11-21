using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x02006210 RID: 25104
	[NullableContext(1)]
	[Nullable(0)]
	public class SubMeshComponent : EntityComponent
	{
		// Token: 0x0603C599 RID: 247193 RVA: 0x01137004 File Offset: 0x01135204
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.CharActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			CharacterActorComponent charActorComp = this.CharActorComp;
			this.CharRenderComp = ((charActorComp != null) ? charActorComp.Actor.CharRenderingComponent : null);
			return true;
		}

		// Token: 0x0603C59A RID: 247194 RVA: 0x01137051 File Offset: 0x01135251
		protected override bool OnClear()
		{
			this.HideMeshMap.Clear();
			this.HideMeshChildActors.Clear();
			return true;
		}

		// Token: 0x0603C59B RID: 247195 RVA: 0x0113706C File Offset: 0x0113526C
		protected override void OnActivate()
		{
			if (this.ActorComp == null)
			{
				return;
			}
			TArray<UActorComponent> tarray = this.ActorComp.Owner.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
			for (int i = tarray.Num() - 1; i >= 0; i--)
			{
				UActorComponent uactorComponent = tarray.Get(i);
				string name = uactorComponent.GetName();
				if (!SubMeshComponent.standardMeshNames.Contains(name))
				{
					this.SubMeshMap[name] = new SubMeshComponent.SubMeshItem(name, uactorComponent as USkeletalMeshComponent);
				}
			}
		}

		// Token: 0x0603C59C RID: 247196 RVA: 0x011370E4 File Offset: 0x011352E4
		protected override void OnAfterTick(float delta)
		{
			this.DealSubMeshOrder(true);
		}

		// Token: 0x0603C59D RID: 247197 RVA: 0x011370ED File Offset: 0x011352ED
		protected override void OnEnable()
		{
			this.DealSubMeshOrder(false);
		}

		// Token: 0x0603C59E RID: 247198 RVA: 0x011370F8 File Offset: 0x011352F8
		private void DealSubMeshOrder(bool allowEffect = true)
		{
			foreach (KeyValuePair<string, SubMeshComponent.SubMeshOrder> keyValuePair in this.SubMeshOrderMap)
			{
				this.SetSubMeshVisible(keyValuePair.Key, keyValuePair.Value, allowEffect);
			}
			this.SubMeshOrderMap.Clear();
		}

		// Token: 0x0603C59F RID: 247199 RVA: 0x01137164 File Offset: 0x01135364
		protected void SetSubMeshVisible(string meshName, SubMeshComponent.SubMeshOrder order, bool allowEffect = true)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (!this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				return;
			}
			if (subMeshItem.IsFrozen)
			{
				subMeshItem.Unfreeze();
			}
			if (subMeshItem.Visible == order.Visible)
			{
				return;
			}
			this.ApplySubMeshMaterialAndEffect(subMeshItem, order, allowEffect);
			subMeshItem.SetVisible(order.Visible, order.DelayTime);
		}

		// Token: 0x0603C5A0 RID: 247200 RVA: 0x011371BC File Offset: 0x011353BC
		protected void ApplySubMeshMaterialAndEffect(SubMeshComponent.SubMeshItem subMeshItem, SubMeshComponent.SubMeshOrder order, bool allowEffect = true)
		{
			if (subMeshItem.CurrentPdHandle != 0)
			{
				CharRenderingComponent charRenderComp = this.CharRenderComp;
				if (charRenderComp != null)
				{
					charRenderComp.RemoveMaterialControllerData(subMeshItem.CurrentPdHandle);
				}
				subMeshItem.CurrentPdHandle = 0;
			}
			if (allowEffect && order.CharControllerData != null)
			{
				CharRenderingComponent charRenderComp2 = this.CharRenderComp;
				subMeshItem.CurrentPdHandle = ((charRenderComp2 != null) ? charRenderComp2.AddMaterialControllerData(order.CharControllerData) : 0);
			}
			if (subMeshItem.CurrentEffectHandle != 0)
			{
				EffectSystem.Instance.StopEffectById(subMeshItem.CurrentEffectHandle, "SubMesh", true, new bool?(true));
				subMeshItem.CurrentEffectHandle = 0;
			}
			if (allowEffect && order.EffectDataAssetRef != null)
			{
				string text = order.EffectDataAssetRef.ToAssetPathName();
				if (!string.IsNullOrEmpty(text))
				{
					CharacterActorComponent charActorComp = this.CharActorComp;
					string path = ((charActorComp != null) ? charActorComp.GetReplaceEffect(text) : null) ?? text;
					SkeletalMeshEffectContext skeletalMeshEffectContext = new SkeletalMeshEffectContext(new int?(base.Entity.Id), null, false);
					skeletalMeshEffectContext.SkeletalMeshComp = subMeshItem.Mesh;
					EffectSystem instance = EffectSystem.Instance;
					UObject mesh = subMeshItem.Mesh;
					FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble());
					int num = instance.SpawnEffect(mesh, ftransformDouble, path, "SubMeshComponent", skeletalMeshEffectContext, EEffectType.Scene, null, null, null, false, false);
					if (num != 0 && EffectSystem.Instance.IsValid(num))
					{
						OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(num);
						subMeshItem.CurrentEffectHandle = num;
						effectActor.K2_AttachToComponent(subMeshItem.Mesh, new FName?(FNameUtil.NONE), EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false);
						FTransformDouble ftransformDouble2 = new FTransformDouble();
						effectActor.D_K2_SetActorRelativeTransform(ftransformDouble2, false, ref WorldGlobal.SweepHitResult, true);
						EffectSystem.Instance.ForceCheckPendingInit(num);
					}
				}
			}
		}

		// Token: 0x0603C5A1 RID: 247201 RVA: 0x01137337 File Offset: 0x01135537
		public void SetSubMeshOrder(string meshName, bool visible, [Nullable(2)] PD_CharacterControllerData_C charControllerData, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> effectDataAssetRef, float delayTime)
		{
			this.SubMeshOrderMap[meshName] = new SubMeshComponent.SubMeshOrder(visible, charControllerData, effectDataAssetRef, delayTime);
		}

		// Token: 0x0603C5A2 RID: 247202 RVA: 0x01137350 File Offset: 0x01135550
		public void SetSubMeshAttach(string componentName, FName attachName, FTransform transform)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(componentName, out subMeshItem))
			{
				subMeshItem.AttachToNewSocket(attachName, transform);
			}
		}

		// Token: 0x0603C5A3 RID: 247203 RVA: 0x01137378 File Offset: 0x01135578
		public void ResetSubMeshAttach(string componentName)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(componentName, out subMeshItem))
			{
				subMeshItem.ResetAttach();
			}
		}

		// Token: 0x0603C5A4 RID: 247204 RVA: 0x0113739C File Offset: 0x0113559C
		public void FreezeSubMesh(string meshName)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				subMeshItem.FreezeToWorld(true);
			}
		}

		// Token: 0x0603C5A5 RID: 247205 RVA: 0x011373C0 File Offset: 0x011355C0
		public void FreezeSubMeshWithEffect(string meshName, bool visible, [Nullable(2)] PD_CharacterControllerData_C charControllerData, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> effectDataAssetRef)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (!this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				return;
			}
			subMeshItem.FreezeToWorld(visible);
			if (charControllerData != null || effectDataAssetRef != null)
			{
				this.ApplySubMeshMaterialAndEffect(subMeshItem, new SubMeshComponent.SubMeshOrder(visible, charControllerData, effectDataAssetRef, 0f), true);
			}
		}

		// Token: 0x0603C5A6 RID: 247206 RVA: 0x01137408 File Offset: 0x01135608
		public void PlaySubMeshEffectOnly(string meshName, bool visible, [Nullable(2)] PD_CharacterControllerData_C charControllerData, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> effectDataAssetRef)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (!this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				return;
			}
			if (charControllerData != null || effectDataAssetRef != null)
			{
				this.ApplySubMeshMaterialAndEffect(subMeshItem, new SubMeshComponent.SubMeshOrder(visible, charControllerData, effectDataAssetRef, 0f), true);
			}
			subMeshItem.SetVisible(visible, 0f);
		}

		// Token: 0x0603C5A7 RID: 247207 RVA: 0x01137458 File Offset: 0x01135658
		public void SnapshotSubMesh(string meshName)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				subMeshItem.TakeSnapshot();
			}
		}

		// Token: 0x0603C5A8 RID: 247208 RVA: 0x0113747C File Offset: 0x0113567C
		public void UnfreezeSubMesh(string meshName)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				subMeshItem.Unfreeze();
			}
		}

		// Token: 0x0603C5A9 RID: 247209 RVA: 0x011374A0 File Offset: 0x011356A0
		public void ShowSubMeshWithEffect(string meshName, bool visible, [Nullable(2)] PD_CharacterControllerData_C charControllerData, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> effectDataAssetRef)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (!this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				return;
			}
			if (subMeshItem.IsFrozen)
			{
				subMeshItem.Unfreeze();
			}
			if (charControllerData != null || effectDataAssetRef != null)
			{
				this.ApplySubMeshMaterialAndEffect(subMeshItem, new SubMeshComponent.SubMeshOrder(visible, charControllerData, effectDataAssetRef, 0f), true);
			}
			subMeshItem.SetVisible(visible, 0f);
		}

		// Token: 0x0603C5AA RID: 247210 RVA: 0x011374FC File Offset: 0x011356FC
		public int SetHideMesh(UMeshComponent meshComp, bool visible, bool withChild, bool withChildActor, int inputKey = 0)
		{
			int num;
			if (inputKey != 0 && this.HideMeshMap.TryGetValue(meshComp, out num) && num != inputKey)
			{
				return num;
			}
			ValueTuple<bool, List<AActor>> valueTuple;
			if (this.HideMeshChildActors.TryGetValue(meshComp, out valueTuple))
			{
				foreach (AActor aactor in valueTuple.Item2)
				{
					aactor.SetActorHiddenInGame(!valueTuple.Item1);
				}
				this.HideMeshChildActors.Remove(meshComp);
			}
			int nextHideMeshKey = this.NextHideMeshKey;
			this.NextHideMeshKey = nextHideMeshKey + 1;
			int num2 = nextHideMeshKey;
			this.HideMeshMap[meshComp] = num2;
			meshComp.SetVisibility(visible, withChild);
			if (withChildActor)
			{
				bool flag = !visible;
				List<AActor> list = new List<AActor>();
				this.HideMeshChildActors[meshComp] = new ValueTuple<bool, List<AActor>>(flag, list);
				CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
				List<AActor> list2 = new List<AActor>();
				if (component != null && component.Actor.Mesh == meshComp)
				{
					TArray<AActor> tarray = new TArray<AActor>();
					component.Actor.GetAllChildActors(ref tarray, true);
					for (int i = tarray.Num() - 1; i >= 0; i--)
					{
						list2.Add(tarray.Get(i));
					}
				}
				else
				{
					TArray<USceneComponent> attachChildren = meshComp.AttachChildren;
					for (int j = attachChildren.Num() - 1; j >= 0; j--)
					{
						AActor owner = attachChildren.Get(j).GetOwner();
						if (owner != null)
						{
							list2.Add(owner);
						}
					}
				}
				foreach (AActor aactor2 in list2)
				{
					if (aactor2.bHidden != flag)
					{
						list.Add(aactor2);
						aactor2.SetActorHiddenInGame(flag);
					}
				}
			}
			return num2;
		}

		// Token: 0x0603C5AB RID: 247211 RVA: 0x011376DC File Offset: 0x011358DC
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SubMeshComponent subMeshComponent = (SubMeshComponent)componentTemplate;
			if (subMeshComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (subMeshComponent.CharActorComp == null)
			{
				this.CharActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharActorComp), "CharActorComp"))
			{
				return false;
			}
			if (subMeshComponent.CharRenderComp == null)
			{
				this.CharRenderComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharRenderComp), "CharRenderComp"))
			{
				return false;
			}
			if (subMeshComponent.SubMeshMap == null)
			{
				this.SubMeshMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SubMeshMap), "SubMeshMap"))
			{
				return false;
			}
			if (subMeshComponent.SubMeshOrderMap == null)
			{
				this.SubMeshOrderMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SubMeshOrderMap), "SubMeshOrderMap"))
			{
				return false;
			}
			this.NextHideMeshKey = subMeshComponent.NextHideMeshKey;
			return (subMeshComponent.HideMeshMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.HideMeshMap), "HideMeshMap")) && (subMeshComponent.HideMeshChildActors == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.HideMeshChildActors), "HideMeshChildActors"));
		}

		// Token: 0x170071EE RID: 29166
		// (get) Token: 0x0603C5AC RID: 247212 RVA: 0x01137823 File Offset: 0x01135A23
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071EF RID: 29167
		// (get) Token: 0x0603C5AD RID: 247213 RVA: 0x01137826 File Offset: 0x01135A26
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071F0 RID: 29168
		// (get) Token: 0x0603C5AE RID: 247214 RVA: 0x01137829 File Offset: 0x01135A29
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071F1 RID: 29169
		// (get) Token: 0x0603C5AF RID: 247215 RVA: 0x0113782C File Offset: 0x01135A2C
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071F2 RID: 29170
		// (get) Token: 0x0603C5B0 RID: 247216 RVA: 0x0113782F File Offset: 0x01135A2F
		public override bool NeedAfterTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FF34 RID: 130868
		[StaticVariableRuleIgnore]
		private static readonly HashSet<string> standardMeshNames = new HashSet<string>
		{
			"Mesh",
			"Hulu",
			"OtherCase0",
			"WeaponCase0",
			"WeaponCase1"
		};

		// Token: 0x0401FF35 RID: 130869
		[Nullable(2)]
		protected BaseActorComponent ActorComp;

		// Token: 0x0401FF36 RID: 130870
		[Nullable(2)]
		protected CharacterActorComponent CharActorComp;

		// Token: 0x0401FF37 RID: 130871
		[Nullable(2)]
		protected CharRenderingComponent CharRenderComp;

		// Token: 0x0401FF38 RID: 130872
		protected Dictionary<string, SubMeshComponent.SubMeshItem> SubMeshMap = new Dictionary<string, SubMeshComponent.SubMeshItem>();

		// Token: 0x0401FF39 RID: 130873
		protected Dictionary<string, SubMeshComponent.SubMeshOrder> SubMeshOrderMap = new Dictionary<string, SubMeshComponent.SubMeshOrder>();

		// Token: 0x0401FF3A RID: 130874
		private int NextHideMeshKey = 1;

		// Token: 0x0401FF3B RID: 130875
		private readonly Dictionary<UMeshComponent, int> HideMeshMap = new Dictionary<UMeshComponent, int>();

		// Token: 0x0401FF3C RID: 130876
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1,
			1
		})]
		private readonly Dictionary<UMeshComponent, ValueTuple<bool, List<AActor>>> HideMeshChildActors = new Dictionary<UMeshComponent, ValueTuple<bool, List<AActor>>>();

		// Token: 0x0200BA36 RID: 47670
		[Nullable(0)]
		public class SubMeshItem
		{
			// Token: 0x17007A5B RID: 31323
			// (get) Token: 0x0604869B RID: 296603 RVA: 0x01615EF2 File Offset: 0x016140F2
			public bool Visible
			{
				get
				{
					return this.VisibleInternal;
				}
			}

			// Token: 0x0604869C RID: 296604 RVA: 0x01615EFC File Offset: 0x016140FC
			public void SetVisible(bool v, float delay = 0f)
			{
				if (this.VisibleInternal == v)
				{
					return;
				}
				this.VisibleInternal = v;
				if (this.InvisibleTimer != null)
				{
					TimerSystem.Instance.Remove(this.InvisibleTimer);
					this.InvisibleTimer = null;
				}
				if (!this.VisibleInternal && delay > 0f)
				{
					this.InvisibleTimer = TimerSystem.Instance.Delay(new TTimerAction(this.DelayInvisible), delay, null, null, true, 1f);
					return;
				}
				this.Mesh.SetVisibility(v, false);
			}

			// Token: 0x0604869D RID: 296605 RVA: 0x01615F7D File Offset: 0x0161417D
			private void DelayInvisible(float delta)
			{
				this.Mesh.SetVisibility(false, false);
				this.InvisibleTimer = null;
			}

			// Token: 0x17007A5C RID: 31324
			// (get) Token: 0x0604869E RID: 296606 RVA: 0x01615F93 File Offset: 0x01614193
			public bool IsFrozen
			{
				get
				{
					return this.FrozenInternal;
				}
			}

			// Token: 0x0604869F RID: 296607 RVA: 0x01615F9C File Offset: 0x0161419C
			public SubMeshItem(string name, USkeletalMeshComponent mesh)
			{
				this.Name = name;
				this.Mesh = mesh;
				this.VisibleInternal = mesh.bVisible;
				this.OriginAttachComp = mesh.GetAttachParent();
				this.OriginAttachSocketName = mesh.GetAttachSocketName();
				Transform originRelativeTransform = this.OriginRelativeTransform;
				FTransform relativeTransform = mesh.GetRelativeTransform();
				originRelativeTransform.FromUeTransform(relativeTransform);
			}

			// Token: 0x17007A5D RID: 31325
			// (get) Token: 0x060486A0 RID: 296608 RVA: 0x0161600B File Offset: 0x0161420B
			public string Name { get; }

			// Token: 0x17007A5E RID: 31326
			// (get) Token: 0x060486A1 RID: 296609 RVA: 0x01616013 File Offset: 0x01614213
			public USkeletalMeshComponent Mesh { get; }

			// Token: 0x060486A2 RID: 296610 RVA: 0x0161601B File Offset: 0x0161421B
			public void AttachToNewSocket(FName attachName, FTransform transform)
			{
				this.Mesh.K2_AttachToComponent(this.OriginAttachComp, attachName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, true, true);
				this.Mesh.K2_SetRelativeTransform(transform, false, ref WorldGlobal.SweepHitResult, true);
			}

			// Token: 0x060486A3 RID: 296611 RVA: 0x0161604C File Offset: 0x0161424C
			public void ResetAttach()
			{
				this.Mesh.K2_AttachToComponent(this.OriginAttachComp, this.OriginAttachSocketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, true, true);
				USceneComponent mesh = this.Mesh;
				FTransform ftransform = this.OriginRelativeTransform.ToUeTransformOld();
				mesh.K2_SetRelativeTransform(ftransform, false, ref WorldGlobal.SweepHitResult, true);
			}

			// Token: 0x060486A4 RID: 296612 RVA: 0x01616098 File Offset: 0x01614298
			public void TakeSnapshot()
			{
				this.SnapshotWorldTransform = new FTransform?(this.Mesh.K2_GetComponentToWorld());
				UKuroAnimInstance ukuroAnimInstance = this.Mesh.GetAnimInstance() as UKuroAnimInstance;
				if (ukuroAnimInstance != null)
				{
					ukuroAnimInstance.SaveExtraFollowSnapshot();
				}
			}

			// Token: 0x060486A5 RID: 296613 RVA: 0x016160D5 File Offset: 0x016142D5
			public void ClearSnapshot()
			{
				this.SnapshotWorldTransform = null;
			}

			// Token: 0x060486A6 RID: 296614 RVA: 0x016160E4 File Offset: 0x016142E4
			public void FreezeToWorld(bool visible = true)
			{
				if (this.FrozenInternal)
				{
					return;
				}
				UKuroAnimInstance ukuroAnimInstance = this.Mesh.GetAnimInstance() as UKuroAnimInstance;
				if (ukuroAnimInstance != null)
				{
					FTransform ftransform = this.SnapshotWorldTransform ?? this.Mesh.K2_GetComponentToWorld();
					ukuroAnimInstance.FreezeExtraFollowAtWorldTransform(ftransform);
				}
				else
				{
					this.Mesh.K2_DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, true);
					if (this.SnapshotWorldTransform != null)
					{
						USceneComponent mesh = this.Mesh;
						FTransform value = this.SnapshotWorldTransform.Value;
						mesh.K2_SetWorldTransform(value, false, ref WorldGlobal.SweepHitResult, true);
					}
				}
				this.SetVisible(visible, 0f);
				this.FrozenInternal = true;
			}

			// Token: 0x060486A7 RID: 296615 RVA: 0x0161618C File Offset: 0x0161438C
			public void Unfreeze()
			{
				if (!this.FrozenInternal)
				{
					return;
				}
				UKuroAnimInstance ukuroAnimInstance = this.Mesh.GetAnimInstance() as UKuroAnimInstance;
				if (ukuroAnimInstance != null)
				{
					ukuroAnimInstance.UnfreezeExtraFollow();
				}
				this.ResetAttach();
				this.ClearSnapshot();
				this.FrozenInternal = false;
			}

			// Token: 0x04039602 RID: 235010
			protected bool VisibleInternal;

			// Token: 0x04039603 RID: 235011
			[Nullable(2)]
			private TimerHandle InvisibleTimer;

			// Token: 0x04039604 RID: 235012
			public int CurrentPdHandle;

			// Token: 0x04039605 RID: 235013
			public int CurrentEffectHandle;

			// Token: 0x04039606 RID: 235014
			[Nullable(2)]
			private readonly USceneComponent OriginAttachComp;

			// Token: 0x04039607 RID: 235015
			private readonly FName OriginAttachSocketName = FNameUtil.NONE;

			// Token: 0x04039608 RID: 235016
			private readonly Transform OriginRelativeTransform = Transform.Create();

			// Token: 0x04039609 RID: 235017
			private bool FrozenInternal;

			// Token: 0x0403960A RID: 235018
			private FTransform? SnapshotWorldTransform;
		}

		// Token: 0x0200BA37 RID: 47671
		[NullableContext(2)]
		[Nullable(0)]
		public class SubMeshOrder
		{
			// Token: 0x060486A8 RID: 296616 RVA: 0x016161CF File Offset: 0x016143CF
			public SubMeshOrder(bool visible, PD_CharacterControllerData_C charControllerData, [Nullable(new byte[]
			{
				2,
				1
			})] TSoftObjectPtr<UEffectModelBase> effectDataAssetRef, float delayTime)
			{
				this.Visible = visible;
				this.CharControllerData = charControllerData;
				this.EffectDataAssetRef = effectDataAssetRef;
				this.DelayTime = delayTime;
			}

			// Token: 0x17007A5F RID: 31327
			// (get) Token: 0x060486A9 RID: 296617 RVA: 0x016161F4 File Offset: 0x016143F4
			public bool Visible { get; }

			// Token: 0x17007A60 RID: 31328
			// (get) Token: 0x060486AA RID: 296618 RVA: 0x016161FC File Offset: 0x016143FC
			public PD_CharacterControllerData_C CharControllerData { get; }

			// Token: 0x17007A61 RID: 31329
			// (get) Token: 0x060486AB RID: 296619 RVA: 0x01616204 File Offset: 0x01614404
			[Nullable(new byte[]
			{
				2,
				1
			})]
			public TSoftObjectPtr<UEffectModelBase> EffectDataAssetRef { [return: Nullable(new byte[]
			{
				2,
				1
			})] get; }

			// Token: 0x17007A62 RID: 31330
			// (get) Token: 0x060486AC RID: 296620 RVA: 0x0161620C File Offset: 0x0161440C
			public float DelayTime { get; }
		}
	}
}
