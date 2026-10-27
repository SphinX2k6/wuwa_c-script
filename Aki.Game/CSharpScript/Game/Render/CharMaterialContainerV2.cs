using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045A4 RID: 17828
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialContainerV2 : CharRenderBase
	{
		// Token: 0x0602DF78 RID: 188280 RVA: 0x00A92E08 File Offset: 0x00A91008
		public override void Start()
		{
			AActor cachedOwner = base.GetRenderingComponent().GetCachedOwner();
			ECharacterRenderingType? renderType = base.GetRenderingComponent().RenderType;
			if (cachedOwner == null)
			{
				return;
			}
			this.ControllerComponent = (cachedOwner.GetComponentByClass(UKuroMaterialControllerComponent.StaticClass()) as UKuroMaterialControllerComponent);
			ECharacterRenderingType? echaracterRenderingType;
			ECharacterRenderingType echaracterRenderingType2;
			if (this.ControllerComponent == null)
			{
				AActor aactor = cachedOwner;
				TSubclassOf<UActorComponent> @class = UKuroMaterialControllerComponent.StaticClass();
				bool bManualAttachment = false;
				FTransform ftransform = new FTransform();
				this.ControllerComponent = (aactor.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UKuroMaterialControllerComponent);
				echaracterRenderingType = renderType;
				echaracterRenderingType2 = ECharacterRenderingType.Sequence;
				if (!(echaracterRenderingType.GetValueOrDefault() == echaracterRenderingType2 & echaracterRenderingType != null))
				{
					echaracterRenderingType = renderType;
					echaracterRenderingType2 = ECharacterRenderingType.Default;
					if (!(echaracterRenderingType.GetValueOrDefault() == echaracterRenderingType2 & echaracterRenderingType != null))
					{
						this.ControllerComponent.SetInitTakeOver(true);
						goto IL_C1;
					}
				}
				this.ControllerComponent.SetInitTakeOver(false);
				IL_C1:
				this.ControllerComponent.InitFromOwner();
			}
			echaracterRenderingType = renderType;
			echaracterRenderingType2 = ECharacterRenderingType.LocalPlayer;
			if (echaracterRenderingType.GetValueOrDefault() == echaracterRenderingType2 & echaracterRenderingType != null)
			{
				this.ControllerComponent.SetToonCustomStencilValue(1);
			}
			this.IdentifyName = cachedOwner.GetClass().GetName();
			USkeletalMeshComponent registeredSkeletalMeshComponent = this.ControllerComponent.GetRegisteredSkeletalMeshComponent(new FName("CharacterMesh0"));
			USkeletalMesh uskeletalMesh = (registeredSkeletalMeshComponent != null) ? registeredSkeletalMeshComponent.SkeletalMesh : null;
			if (uskeletalMesh != null)
			{
				this.IdentifyName = this.IdentifyName + "_" + uskeletalMesh.GetName();
			}
			this.BodyEffect = (base.GetRenderingComponent().GetComponent(9) as CharBodyEffect);
			this.StatTick = Stat.CreateNoFlameGraph("CharMaterialContainerV2_Tick_" + this.IdentifyName, "", "");
			this.StatUpdateEffectOnly = Stat.CreateNoFlameGraph("CharMaterialContainerV2_UpdateEffectOnly_" + this.IdentifyName, "", "");
			base.OnInitSuccess();
		}

		// Token: 0x0602DF79 RID: 188281 RVA: 0x00A92FC8 File Offset: 0x00A911C8
		public override void Update()
		{
			LogicalTimeDilationOut logicalTimeDilationOut = new LogicalTimeDilationOut
			{
				LogicalTimeDilation = 1f
			};
			float timeDilation = this.RenderComponent.GetTimeDilation(logicalTimeDilationOut);
			this.ControllerComponent.ManualTick(base.GetDeltaTime() * timeDilation, false, false, logicalTimeDilationOut.LogicalTimeDilation);
			this.ControllerComponent.UpdateEffects();
			this.ControllerComponent.SetUpdateForce(false);
			TArray<int> tarray = this.ControllerComponent.RemoveDeadEffects();
			if (this.OnEffectFinishCallbackSet != null)
			{
				for (int i = 0; i < tarray.Num(); i++)
				{
					foreach (Action<int> action in this.OnEffectFinishCallbackSet)
					{
						action(tarray.Get(i));
					}
				}
			}
			if (this.BodyEffect != null)
			{
				float bodyOpacity = this.ControllerComponent.GetBodyOpacity();
				this.BodyEffect.SetOpacity(bodyOpacity, ECharBodyEffectOpacityType.Effect);
			}
		}

		// Token: 0x0602DF7A RID: 188282 RVA: 0x00A930B8 File Offset: 0x00A912B8
		public void UpdateEffectsOnly()
		{
			this.ControllerComponent.MarkForceUpdateAllOnce();
			this.ControllerComponent.UpdateEffects();
		}

		// Token: 0x0602DF7B RID: 188283 RVA: 0x00A930D0 File Offset: 0x00A912D0
		public void ForceUpdateOnce()
		{
			UKuroMaterialControllerComponent controllerComponent = this.ControllerComponent;
			if (controllerComponent != null)
			{
				controllerComponent.MarkForceUpdateAllOnce();
			}
			UKuroMaterialControllerComponent controllerComponent2 = this.ControllerComponent;
			if (controllerComponent2 == null)
			{
				return;
			}
			controllerComponent2.SetUpdateForce(true);
		}

		// Token: 0x0602DF7C RID: 188284 RVA: 0x00A930F4 File Offset: 0x00A912F4
		public void AddSkeletalComponent(USkeletalMeshComponent skeletalComp, string skelName, bool useEmptyMaterial = false)
		{
			this.ControllerComponent.AddSkeletalMeshComponent(skeletalComp, new FName(skelName), useEmptyMaterial);
		}

		// Token: 0x0602DF7D RID: 188285 RVA: 0x00A93109 File Offset: 0x00A91309
		[return: Nullable(2)]
		public USkeletalMeshComponent GetSkeletalComponent(string skelName)
		{
			return this.ControllerComponent.GetRegisteredSkeletalMeshComponent(new FName(skelName));
		}

		// Token: 0x0602DF7E RID: 188286 RVA: 0x00A9311C File Offset: 0x00A9131C
		public FName GetSkeletalMeshComponentBodyName(USkeletalMeshComponent skeletalComp)
		{
			return this.ControllerComponent.GetSkeletalMeshComponentBodyName(skeletalComp);
		}

		// Token: 0x0602DF7F RID: 188287 RVA: 0x00A9312A File Offset: 0x00A9132A
		public void RemoveSkeletalComponent(string bodyName)
		{
			this.ControllerComponent.RemoveSkeletalMeshComponent(new FName(bodyName));
		}

		// Token: 0x0602DF80 RID: 188288 RVA: 0x00A9313D File Offset: 0x00A9133D
		public int AddEffect(UKuroMaterialControllerDataAsset dataAsset, bool needLoop, bool paused, [Nullable(2)] USkeletalMeshComponent animObject = null, bool hiddenAfterEffect = false)
		{
			return this.ControllerComponent.AddEffect_Ex(dataAsset, needLoop, paused, animObject, hiddenAfterEffect, -1);
		}

		// Token: 0x0602DF81 RID: 188289 RVA: 0x00A93152 File Offset: 0x00A91352
		public void SetEffectLoop(int handle, bool needLoop)
		{
			this.ControllerComponent.SetHandleLoop(handle, needLoop, true, -1);
		}

		// Token: 0x0602DF82 RID: 188290 RVA: 0x00A93163 File Offset: 0x00A91363
		public void SetEffectPause(int handle, bool paused)
		{
			this.ControllerComponent.SetHandlePause(handle, paused);
		}

		// Token: 0x0602DF83 RID: 188291 RVA: 0x00A93172 File Offset: 0x00A91372
		public void SetEffectProgress(int handle, float progress)
		{
			this.ControllerComponent.SeekHandleFactor(handle, progress);
		}

		// Token: 0x0602DF84 RID: 188292 RVA: 0x00A93184 File Offset: 0x00A91384
		public void RemoveEffect(int handle)
		{
			this.ControllerComponent.RemoveEffect(handle, -1);
			if (this.OnEffectFinishCallbackSet != null)
			{
				foreach (Action<int> action in this.OnEffectFinishCallbackSet)
				{
					action(handle);
				}
			}
		}

		// Token: 0x0602DF85 RID: 188293 RVA: 0x00A931EC File Offset: 0x00A913EC
		public void RemoveAllUnloopedEffects()
		{
			TArray<int> tarray = this.ControllerComponent.RemoveAllUnloopedEffects();
			if (this.OnEffectFinishCallbackSet != null)
			{
				for (int i = 0; i < tarray.Num(); i++)
				{
					foreach (Action<int> action in this.OnEffectFinishCallbackSet)
					{
						action(tarray.Get(i));
					}
				}
			}
		}

		// Token: 0x0602DF86 RID: 188294 RVA: 0x00A93268 File Offset: 0x00A91468
		public override void OnResetRenderState()
		{
			this.ControllerComponent.RemoveAllEffects(-1);
			this.ControllerComponent.UpdateEffects();
		}

		// Token: 0x0602DF87 RID: 188295 RVA: 0x00A93281 File Offset: 0x00A91481
		public void SetFloatUpdateParamPermanent(FName name, float value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.AddFloatUpdateParamPermanent(name, value, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602DF88 RID: 188296 RVA: 0x00A9329C File Offset: 0x00A9149C
		public void AddFloatUpdateParamPermanentByIndex(FName name, float value, FName bodyName, int materialIndex)
		{
			this.ControllerComponent.AddFloatUpdateParamPermanentByIndex(name, value, bodyName, materialIndex);
		}

		// Token: 0x0602DF89 RID: 188297 RVA: 0x00A932AE File Offset: 0x00A914AE
		public void SetColorUpdateParamPermanent(FName name, FLinearColor value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.AddColorUpdateParamPermanent(name, value, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602DF8A RID: 188298 RVA: 0x00A932C9 File Offset: 0x00A914C9
		public void SetTextureUpdateParamPermanent(FName name, UTexture value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.AddTextureUpdateParamPermanent(name, value, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602DF8B RID: 188299 RVA: 0x00A932E4 File Offset: 0x00A914E4
		public void RemoveFloatUpdateParamPermanent(FName name, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.RemoveFloatUpdateParamPermanent(name, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602DF8C RID: 188300 RVA: 0x00A932FD File Offset: 0x00A914FD
		public void RemoveColorUpdateParamPermanent(FName name, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.RemoveColorUpdateParamPermanent(name, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602DF8D RID: 188301 RVA: 0x00A93316 File Offset: 0x00A91516
		public void RemoveTextureUpdateParamPermanent(FName name, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.RemoveTextureUpdateParamPermanent(name, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602DF8E RID: 188302 RVA: 0x00A9332F File Offset: 0x00A9152F
		public void SetExternalMaterialReplace(UMaterialInterface material, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.SetExternalMaterialReplace(material, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602DF8F RID: 188303 RVA: 0x00A93348 File Offset: 0x00A91548
		public void SetExternalMaterialReplaceByIndex(UMaterialInterface material, FName bodyName, int materialIndex)
		{
			this.ControllerComponent.SetExternalMaterialReplaceByIndex(material, bodyName, materialIndex);
		}

		// Token: 0x0602DF90 RID: 188304 RVA: 0x00A93358 File Offset: 0x00A91558
		public void RemoveExternalMaterialReplace(EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.RemoveExternalMaterialReplace(bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602DF91 RID: 188305 RVA: 0x00A93370 File Offset: 0x00A91570
		public void RemoveExternalMaterialReplaceByIndex(FName bodyName, int materialIndex)
		{
			this.ControllerComponent.RemoveExternalMaterialReplaceByIndex(bodyName, materialIndex);
		}

		// Token: 0x0602DF92 RID: 188306 RVA: 0x00A9337F File Offset: 0x00A9157F
		public void AddAlphaTestCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.AddExternalAlphaTestRefCount(bodyType);
		}

		// Token: 0x0602DF93 RID: 188307 RVA: 0x00A9338D File Offset: 0x00A9158D
		public void AddOutlineStencilTestCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.AddExternalOutlineStencilTestRefCount(bodyType);
		}

		// Token: 0x0602DF94 RID: 188308 RVA: 0x00A9339B File Offset: 0x00A9159B
		public void AddBattleCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.AddExternalBattleRefCount(bodyType);
		}

		// Token: 0x0602DF95 RID: 188309 RVA: 0x00A933A9 File Offset: 0x00A915A9
		public void AddBattleMaskCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.AddExternalBattleMaskRefCount(bodyType);
		}

		// Token: 0x0602DF96 RID: 188310 RVA: 0x00A933B7 File Offset: 0x00A915B7
		public void RemoveAlphaTestCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.RemoveExternalAlphaTestRefCount(bodyType);
		}

		// Token: 0x0602DF97 RID: 188311 RVA: 0x00A933C5 File Offset: 0x00A915C5
		public void RemoveOutlineStencilTestCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.RemoveExternalOutlineStencilTestRefCount(bodyType);
		}

		// Token: 0x0602DF98 RID: 188312 RVA: 0x00A933D3 File Offset: 0x00A915D3
		public void RemoveBattleCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.RemoveExternalBattleRefCount(bodyType);
		}

		// Token: 0x0602DF99 RID: 188313 RVA: 0x00A933E1 File Offset: 0x00A915E1
		public void RemoveBattleMaskCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.RemoveExternalBattleMaskRefCount(bodyType);
		}

		// Token: 0x0602DF9A RID: 188314 RVA: 0x00A933EF File Offset: 0x00A915EF
		public void SetNoWater(bool value)
		{
			this.ControllerComponent.SetAllBodyNoWater(value);
		}

		// Token: 0x0602DF9B RID: 188315 RVA: 0x00A933FD File Offset: 0x00A915FD
		public void AddEffectFinishCallback(Action<int> callback)
		{
			if (this.OnEffectFinishCallbackSet == null)
			{
				this.OnEffectFinishCallbackSet = new HashSet<Action<int>>();
			}
			if (this.OnEffectFinishCallbackSet.Contains(callback))
			{
				return;
			}
			this.OnEffectFinishCallbackSet.Add(callback);
		}

		// Token: 0x0602DF9C RID: 188316 RVA: 0x00A9342E File Offset: 0x00A9162E
		public void RemoveEffectFinishCallback(Action<int> callback)
		{
			if (this.OnEffectFinishCallbackSet == null)
			{
				return;
			}
			this.OnEffectFinishCallbackSet.Remove(callback);
		}

		// Token: 0x0602DF9D RID: 188317 RVA: 0x00A93446 File Offset: 0x00A91646
		public bool GetAnyUnloopEffect()
		{
			return this.ControllerComponent.GetAnyUnloopEffect();
		}

		// Token: 0x0602DF9E RID: 188318 RVA: 0x00A93454 File Offset: 0x00A91654
		public void EnableTickGetHeadPosInAllMeshes(bool enable)
		{
			TArray<FName> allRegisteredBodyNames = this.ControllerComponent.GetAllRegisteredBodyNames();
			int num = allRegisteredBodyNames.Num();
			for (int i = 0; i < num; i++)
			{
				FName bodyName = allRegisteredBodyNames.Get(i);
				USkeletalMeshComponent registeredSkeletalMeshComponent = this.ControllerComponent.GetRegisteredSkeletalMeshComponent(bodyName);
				string text = (registeredSkeletalMeshComponent != null) ? registeredSkeletalMeshComponent.GetAttachSocketName().ToString() : null;
				if (text != null && (text.Contains("Head") || text.Contains("Hair") || text.Contains("Neck")))
				{
					if (enable)
					{
						UKuroMaterialControllerComponent controllerComponent = this.ControllerComponent;
						if (controllerComponent != null)
						{
							controllerComponent.AddFloatUpdateParamPermanentCustom(RenderConfig.DitherUseInRayTracing, 0f, bodyName, EKuroCharSlotSpecifiedType.All, "");
						}
					}
					else
					{
						UKuroMaterialControllerComponent controllerComponent2 = this.ControllerComponent;
						if (controllerComponent2 != null)
						{
							controllerComponent2.RemoveFloatUpdateParamPermanentCustom(RenderConfig.DitherUseInRayTracing, bodyName, EKuroCharSlotSpecifiedType.All, "");
						}
					}
				}
				else if (enable)
				{
					if (registeredSkeletalMeshComponent != null)
					{
						registeredSkeletalMeshComponent.EnableTickGetHeadBonePos(enable);
					}
					UKuroMaterialControllerComponent controllerComponent3 = this.ControllerComponent;
					if (controllerComponent3 != null)
					{
						controllerComponent3.AddFloatUpdateParamPermanentCustom(RenderConfig.UseHeadMaskHideEffect, 1f, bodyName, EKuroCharSlotSpecifiedType.All, "");
					}
					UKuroMaterialControllerComponent controllerComponent4 = this.ControllerComponent;
					if (controllerComponent4 != null)
					{
						controllerComponent4.AddFloatUpdateParamPermanentCustom(RenderConfig.DitherUseInRayTracing, 0f, bodyName, EKuroCharSlotSpecifiedType.All, "");
					}
					foreach (string customPartName in this.MeshPartHeadNamesArray)
					{
						UKuroMaterialControllerComponent controllerComponent5 = this.ControllerComponent;
						if (controllerComponent5 != null)
						{
							controllerComponent5.AddFloatUpdateParamPermanentCustom(RenderConfig.UseHeadMaskHideEffect, 0f, bodyName, EKuroCharSlotSpecifiedType.All, customPartName);
						}
					}
				}
				else
				{
					UKuroMaterialControllerComponent controllerComponent6 = this.ControllerComponent;
					if (controllerComponent6 != null)
					{
						controllerComponent6.RemoveFloatUpdateParamPermanentCustom(RenderConfig.UseHeadMaskHideEffect, bodyName, EKuroCharSlotSpecifiedType.All, "");
					}
					UKuroMaterialControllerComponent controllerComponent7 = this.ControllerComponent;
					if (controllerComponent7 != null)
					{
						controllerComponent7.RemoveFloatUpdateParamPermanentCustom(RenderConfig.DitherUseInRayTracing, bodyName, EKuroCharSlotSpecifiedType.All, "");
					}
				}
			}
		}

		// Token: 0x0602DF9F RID: 188319 RVA: 0x00A9360E File Offset: 0x00A9180E
		public override void Destroy()
		{
		}

		// Token: 0x0602DFA0 RID: 188320 RVA: 0x00A93610 File Offset: 0x00A91810
		public override string GetStatName()
		{
			return "CharMaterialContainerV2";
		}

		// Token: 0x0602DFA1 RID: 188321 RVA: 0x00A93617 File Offset: 0x00A91817
		public override int GetComponentId()
		{
			return 13;
		}

		// Token: 0x040188AC RID: 100524
		[Nullable(2)]
		private UKuroMaterialControllerComponent ControllerComponent;

		// Token: 0x040188AD RID: 100525
		[Nullable(2)]
		private Stat StatTick;

		// Token: 0x040188AE RID: 100526
		[Nullable(2)]
		private Stat StatUpdateEffectOnly;

		// Token: 0x040188AF RID: 100527
		public string IdentifyName = string.Empty;

		// Token: 0x040188B0 RID: 100528
		[Nullable(2)]
		private CharBodyEffect BodyEffect;

		// Token: 0x040188B1 RID: 100529
		public string[] MeshPartHeadNamesArray = new string[]
		{
			"Bangs",
			"Hair",
			"Head",
			"Face",
			"Eye"
		};

		// Token: 0x040188B2 RID: 100530
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private HashSet<Action<int>> OnEffectFinishCallbackSet;
	}
}
