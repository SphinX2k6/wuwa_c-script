using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200708F RID: 28815
	[NullableContext(1)]
	[Nullable(0)]
	public class SubMeshComponent : EntityComponent
	{
		// Token: 0x06046357 RID: 287575 RVA: 0x0118DEC0 File Offset: 0x0118C0C0
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.CharActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			CharacterActorComponent charActorComp = this.CharActorComp;
			this.CharRenderComp = ((charActorComp != null) ? charActorComp.Actor.CharRenderingComponent : null);
			return true;
		}

		// Token: 0x06046358 RID: 287576 RVA: 0x0118DF0D File Offset: 0x0118C10D
		protected override bool OnClear()
		{
			this.HideMeshMap.Clear();
			this.HideMeshChildActors.Clear();
			return true;
		}

		// Token: 0x06046359 RID: 287577 RVA: 0x0118DF28 File Offset: 0x0118C128
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

		// Token: 0x0604635A RID: 287578 RVA: 0x0118DFA0 File Offset: 0x0118C1A0
		protected override void OnAfterTick(float delta)
		{
			this.DealSubMeshOrder(true);
		}

		// Token: 0x0604635B RID: 287579 RVA: 0x0118DFA9 File Offset: 0x0118C1A9
		protected override void OnEnable()
		{
			this.DealSubMeshOrder(false);
		}

		// Token: 0x0604635C RID: 287580 RVA: 0x0118DFB4 File Offset: 0x0118C1B4
		private void DealSubMeshOrder(bool allowEffect = true)
		{
			foreach (KeyValuePair<string, SubMeshComponent.SubMeshOrder> keyValuePair in this.SubMeshOrderMap)
			{
				this.SetSubMeshVisible(keyValuePair.Key, keyValuePair.Value, allowEffect);
			}
			this.SubMeshOrderMap.Clear();
		}

		// Token: 0x0604635D RID: 287581 RVA: 0x0118E020 File Offset: 0x0118C220
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

		// Token: 0x0604635E RID: 287582 RVA: 0x0118E078 File Offset: 0x0118C278
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

		// Token: 0x0604635F RID: 287583 RVA: 0x0118E1F3 File Offset: 0x0118C3F3
		public void SetSubMeshOrder(string meshName, bool visible, [Nullable(2)] PD_CharacterControllerData_C charControllerData, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<UEffectModelBase> effectDataAssetRef, float delayTime)
		{
			this.SubMeshOrderMap[meshName] = new SubMeshComponent.SubMeshOrder(visible, charControllerData, effectDataAssetRef, delayTime);
		}

		// Token: 0x06046360 RID: 287584 RVA: 0x0118E20C File Offset: 0x0118C40C
		public void SetSubMeshAttach(string componentName, FName attachName, FTransform transform)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(componentName, out subMeshItem))
			{
				subMeshItem.AttachToNewSocket(attachName, transform);
			}
		}

		// Token: 0x06046361 RID: 287585 RVA: 0x0118E234 File Offset: 0x0118C434
		public void ResetSubMeshAttach(string componentName)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(componentName, out subMeshItem))
			{
				subMeshItem.ResetAttach();
			}
		}

		// Token: 0x06046362 RID: 287586 RVA: 0x0118E258 File Offset: 0x0118C458
		public void FreezeSubMesh(string meshName)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				subMeshItem.FreezeToWorld(true);
			}
		}

		// Token: 0x06046363 RID: 287587 RVA: 0x0118E27C File Offset: 0x0118C47C
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

		// Token: 0x06046364 RID: 287588 RVA: 0x0118E2C4 File Offset: 0x0118C4C4
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

		// Token: 0x06046365 RID: 287589 RVA: 0x0118E314 File Offset: 0x0118C514
		public void SnapshotSubMesh(string meshName)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				subMeshItem.TakeSnapshot();
			}
		}

		// Token: 0x06046366 RID: 287590 RVA: 0x0118E338 File Offset: 0x0118C538
		public void UnfreezeSubMesh(string meshName)
		{
			SubMeshComponent.SubMeshItem subMeshItem;
			if (this.SubMeshMap.TryGetValue(meshName, out subMeshItem))
			{
				subMeshItem.Unfreeze();
			}
		}

		// Token: 0x06046367 RID: 287591 RVA: 0x0118E35C File Offset: 0x0118C55C
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

		// Token: 0x06046368 RID: 287592 RVA: 0x0118E3B8 File Offset: 0x0118C5B8
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

		// Token: 0x06046369 RID: 287593 RVA: 0x0118E598 File Offset: 0x0118C798
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SubMeshComponent subMeshComponent = (SubMeshComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (subMeshComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CharActorComp"))
			{
				if (subMeshComponent.CharActorComp == null)
				{
					this.CharActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.CharActorComp), "CharActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CharRenderComp"))
			{
				if (subMeshComponent.CharRenderComp == null)
				{
					this.CharRenderComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharRenderingComponent>(this.CharRenderComp), "CharRenderComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SubMeshMap"))
			{
				if (subMeshComponent.SubMeshMap == null)
				{
					this.SubMeshMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, SubMeshComponent.SubMeshItem>>(this.SubMeshMap), "SubMeshMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SubMeshOrderMap"))
			{
				if (subMeshComponent.SubMeshOrderMap == null)
				{
					this.SubMeshOrderMap = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, SubMeshComponent.SubMeshOrder>>(this.SubMeshOrderMap), "SubMeshOrderMap"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("NextHideMeshKey"))
			{
				this.NextHideMeshKey = subMeshComponent.NextHideMeshKey;
			}
			return (!base.CanResetComponentProperty("HideMeshMap") || subMeshComponent.HideMeshMap == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<UMeshComponent, int>>(this.HideMeshMap), "HideMeshMap")) && (!base.CanResetComponentProperty("HideMeshChildActors") || subMeshComponent.HideMeshChildActors == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<UMeshComponent, ValueTuple<bool, List<AActor>>>>(this.HideMeshChildActors), "HideMeshChildActors"));
		}

		// Token: 0x04024C79 RID: 150649
		[StaticVariableRuleIgnore]
		private static readonly HashSet<string> standardMeshNames = new HashSet<string>
		{
			"Mesh",
			"Hulu",
			"OtherCase0",
			"WeaponCase0",
			"WeaponCase1"
		};

		// Token: 0x04024C7A RID: 150650
		[Nullable(2)]
		protected BaseActorComponent ActorComp;

		// Token: 0x04024C7B RID: 150651
		[Nullable(2)]
		protected CharacterActorComponent CharActorComp;

		// Token: 0x04024C7C RID: 150652
		[Nullable(2)]
		protected CharRenderingComponent CharRenderComp;

		// Token: 0x04024C7D RID: 150653
		protected Dictionary<string, SubMeshComponent.SubMeshItem> SubMeshMap = new Dictionary<string, SubMeshComponent.SubMeshItem>();

		// Token: 0x04024C7E RID: 150654
		protected Dictionary<string, SubMeshComponent.SubMeshOrder> SubMeshOrderMap = new Dictionary<string, SubMeshComponent.SubMeshOrder>();

		// Token: 0x04024C7F RID: 150655
		private int NextHideMeshKey = 1;

		// Token: 0x04024C80 RID: 150656
		private readonly Dictionary<UMeshComponent, int> HideMeshMap = new Dictionary<UMeshComponent, int>();

		// Token: 0x04024C81 RID: 150657
		[Nullable(new byte[]
		{
			1,
			1,
			0,
			1,
			1
		})]
		private readonly Dictionary<UMeshComponent, ValueTuple<bool, List<AActor>>> HideMeshChildActors = new Dictionary<UMeshComponent, ValueTuple<bool, List<AActor>>>();

		// Token: 0x0200CE44 RID: 52804
		[Nullable(0)]
		public class SubMeshItem
		{
			// Token: 0x1700A2B7 RID: 41655
			// (get) Token: 0x06051E2C RID: 335404 RVA: 0x01640B9A File Offset: 0x0163ED9A
			public bool Visible
			{
				get
				{
					return this.VisibleInternal;
				}
			}

			// Token: 0x06051E2D RID: 335405 RVA: 0x01640BA4 File Offset: 0x0163EDA4
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

			// Token: 0x06051E2E RID: 335406 RVA: 0x01640C25 File Offset: 0x0163EE25
			private void DelayInvisible(float delta)
			{
				this.Mesh.SetVisibility(false, false);
				this.InvisibleTimer = null;
			}

			// Token: 0x1700A2B8 RID: 41656
			// (get) Token: 0x06051E2F RID: 335407 RVA: 0x01640C3B File Offset: 0x0163EE3B
			public bool IsFrozen
			{
				get
				{
					return this.FrozenInternal;
				}
			}

			// Token: 0x06051E30 RID: 335408 RVA: 0x01640C44 File Offset: 0x0163EE44
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

			// Token: 0x1700A2B9 RID: 41657
			// (get) Token: 0x06051E31 RID: 335409 RVA: 0x01640CB3 File Offset: 0x0163EEB3
			public string Name { get; }

			// Token: 0x1700A2BA RID: 41658
			// (get) Token: 0x06051E32 RID: 335410 RVA: 0x01640CBB File Offset: 0x0163EEBB
			public USkeletalMeshComponent Mesh { get; }

			// Token: 0x06051E33 RID: 335411 RVA: 0x01640CC3 File Offset: 0x0163EEC3
			public void AttachToNewSocket(FName attachName, FTransform transform)
			{
				this.Mesh.K2_AttachToComponent(this.OriginAttachComp, attachName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, true, true);
				this.Mesh.K2_SetRelativeTransform(transform, false, ref WorldGlobal.SweepHitResult, true);
			}

			// Token: 0x06051E34 RID: 335412 RVA: 0x01640CF4 File Offset: 0x0163EEF4
			public void ResetAttach()
			{
				this.Mesh.K2_AttachToComponent(this.OriginAttachComp, this.OriginAttachSocketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, true, true);
				USceneComponent mesh = this.Mesh;
				FTransform ftransform = this.OriginRelativeTransform.ToUeTransformOld();
				mesh.K2_SetRelativeTransform(ftransform, false, ref WorldGlobal.SweepHitResult, true);
			}

			// Token: 0x06051E35 RID: 335413 RVA: 0x01640D40 File Offset: 0x0163EF40
			public void TakeSnapshot()
			{
				this.SnapshotWorldTransform = new FTransform?(this.Mesh.K2_GetComponentToWorld());
				UKuroAnimInstance ukuroAnimInstance = this.Mesh.GetAnimInstance() as UKuroAnimInstance;
				if (ukuroAnimInstance != null)
				{
					ukuroAnimInstance.SaveExtraFollowSnapshot();
				}
			}

			// Token: 0x06051E36 RID: 335414 RVA: 0x01640D7D File Offset: 0x0163EF7D
			public void ClearSnapshot()
			{
				this.SnapshotWorldTransform = null;
			}

			// Token: 0x06051E37 RID: 335415 RVA: 0x01640D8C File Offset: 0x0163EF8C
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

			// Token: 0x06051E38 RID: 335416 RVA: 0x01640E34 File Offset: 0x0163F034
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

			// Token: 0x0403E1D2 RID: 254418
			protected bool VisibleInternal;

			// Token: 0x0403E1D3 RID: 254419
			[Nullable(2)]
			private TimerHandle InvisibleTimer;

			// Token: 0x0403E1D4 RID: 254420
			public int CurrentPdHandle;

			// Token: 0x0403E1D5 RID: 254421
			public int CurrentEffectHandle;

			// Token: 0x0403E1D6 RID: 254422
			[Nullable(2)]
			private readonly USceneComponent OriginAttachComp;

			// Token: 0x0403E1D7 RID: 254423
			private readonly FName OriginAttachSocketName = FNameUtil.NONE;

			// Token: 0x0403E1D8 RID: 254424
			private readonly Transform OriginRelativeTransform = Transform.Create();

			// Token: 0x0403E1D9 RID: 254425
			private bool FrozenInternal;

			// Token: 0x0403E1DA RID: 254426
			private FTransform? SnapshotWorldTransform;
		}

		// Token: 0x0200CE45 RID: 52805
		[NullableContext(2)]
		[Nullable(0)]
		public class SubMeshOrder
		{
			// Token: 0x06051E39 RID: 335417 RVA: 0x01640E77 File Offset: 0x0163F077
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

			// Token: 0x1700A2BB RID: 41659
			// (get) Token: 0x06051E3A RID: 335418 RVA: 0x01640E9C File Offset: 0x0163F09C
			public bool Visible { get; }

			// Token: 0x1700A2BC RID: 41660
			// (get) Token: 0x06051E3B RID: 335419 RVA: 0x01640EA4 File Offset: 0x0163F0A4
			public PD_CharacterControllerData_C CharControllerData { get; }

			// Token: 0x1700A2BD RID: 41661
			// (get) Token: 0x06051E3C RID: 335420 RVA: 0x01640EAC File Offset: 0x0163F0AC
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

			// Token: 0x1700A2BE RID: 41662
			// (get) Token: 0x06051E3D RID: 335421 RVA: 0x01640EB4 File Offset: 0x0163F0B4
			public float DelayTime { get; }
		}
	}
}
