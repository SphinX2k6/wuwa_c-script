using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034CC RID: 13516
	[NullableContext(1)]
	[Nullable(0)]
	public class CharMaterialContainerV2 : CharRenderBase
	{
		// Token: 0x06022662 RID: 140898 RVA: 0x009BF028 File Offset: 0x009BD228
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

		// Token: 0x06022663 RID: 140899 RVA: 0x009BF1E8 File Offset: 0x009BD3E8
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

		// Token: 0x06022664 RID: 140900 RVA: 0x009BF2D8 File Offset: 0x009BD4D8
		public void UpdateEffectsOnly()
		{
			this.ControllerComponent.MarkForceUpdateAllOnce();
			this.ControllerComponent.UpdateEffects();
		}

		// Token: 0x06022665 RID: 140901 RVA: 0x009BF2F0 File Offset: 0x009BD4F0
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

		// Token: 0x06022666 RID: 140902 RVA: 0x009BF314 File Offset: 0x009BD514
		public void AddSkeletalComponent(USkeletalMeshComponent skeletalComp, string skelName, bool useEmptyMaterial = false)
		{
			this.ControllerComponent.AddSkeletalMeshComponent(skeletalComp, new FName(skelName), useEmptyMaterial);
		}

		// Token: 0x06022667 RID: 140903 RVA: 0x009BF329 File Offset: 0x009BD529
		[return: Nullable(2)]
		public USkeletalMeshComponent GetSkeletalComponent(string skelName)
		{
			return this.ControllerComponent.GetRegisteredSkeletalMeshComponent(new FName(skelName));
		}

		// Token: 0x06022668 RID: 140904 RVA: 0x009BF33C File Offset: 0x009BD53C
		public FName GetSkeletalMeshComponentBodyName(USkeletalMeshComponent skeletalComp)
		{
			return this.ControllerComponent.GetSkeletalMeshComponentBodyName(skeletalComp);
		}

		// Token: 0x06022669 RID: 140905 RVA: 0x009BF34A File Offset: 0x009BD54A
		public void RemoveSkeletalComponent(string bodyName)
		{
			this.ControllerComponent.RemoveSkeletalMeshComponent(new FName(bodyName));
		}

		// Token: 0x0602266A RID: 140906 RVA: 0x009BF35D File Offset: 0x009BD55D
		public int AddEffect(UKuroMaterialControllerDataAsset dataAsset, bool needLoop, bool paused, [Nullable(2)] USkeletalMeshComponent animObject = null, bool hiddenAfterEffect = false)
		{
			return this.ControllerComponent.AddEffect_Ex(dataAsset, needLoop, paused, animObject, hiddenAfterEffect, -1);
		}

		// Token: 0x0602266B RID: 140907 RVA: 0x009BF372 File Offset: 0x009BD572
		public void SetEffectLoop(int handle, bool needLoop)
		{
			this.ControllerComponent.SetHandleLoop(handle, needLoop, true, -1);
		}

		// Token: 0x0602266C RID: 140908 RVA: 0x009BF383 File Offset: 0x009BD583
		public void SetEffectPause(int handle, bool paused)
		{
			this.ControllerComponent.SetHandlePause(handle, paused);
		}

		// Token: 0x0602266D RID: 140909 RVA: 0x009BF392 File Offset: 0x009BD592
		public void SetEffectProgress(int handle, float progress)
		{
			this.ControllerComponent.SeekHandleFactor(handle, progress);
		}

		// Token: 0x0602266E RID: 140910 RVA: 0x009BF3A4 File Offset: 0x009BD5A4
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

		// Token: 0x0602266F RID: 140911 RVA: 0x009BF40C File Offset: 0x009BD60C
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

		// Token: 0x06022670 RID: 140912 RVA: 0x009BF488 File Offset: 0x009BD688
		public override void OnResetRenderState()
		{
			this.ControllerComponent.RemoveAllEffects(-1);
			this.ControllerComponent.UpdateEffects();
		}

		// Token: 0x06022671 RID: 140913 RVA: 0x009BF4A1 File Offset: 0x009BD6A1
		public void SetFloatUpdateParamPermanent(FName name, float value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.AddFloatUpdateParamPermanent(name, value, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x06022672 RID: 140914 RVA: 0x009BF4BC File Offset: 0x009BD6BC
		public void AddFloatUpdateParamPermanentByIndex(FName name, float value, FName bodyName, int materialIndex)
		{
			this.ControllerComponent.AddFloatUpdateParamPermanentByIndex(name, value, bodyName, materialIndex);
		}

		// Token: 0x06022673 RID: 140915 RVA: 0x009BF4CE File Offset: 0x009BD6CE
		public void SetColorUpdateParamPermanent(FName name, FLinearColor value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.AddColorUpdateParamPermanent(name, value, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x06022674 RID: 140916 RVA: 0x009BF4E9 File Offset: 0x009BD6E9
		public void SetTextureUpdateParamPermanent(FName name, UTexture value, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.AddTextureUpdateParamPermanent(name, value, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x06022675 RID: 140917 RVA: 0x009BF504 File Offset: 0x009BD704
		public void RemoveFloatUpdateParamPermanent(FName name, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.RemoveFloatUpdateParamPermanent(name, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x06022676 RID: 140918 RVA: 0x009BF51D File Offset: 0x009BD71D
		public void RemoveColorUpdateParamPermanent(FName name, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.RemoveColorUpdateParamPermanent(name, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x06022677 RID: 140919 RVA: 0x009BF536 File Offset: 0x009BD736
		public void RemoveTextureUpdateParamPermanent(FName name, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.RemoveTextureUpdateParamPermanent(name, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x06022678 RID: 140920 RVA: 0x009BF54F File Offset: 0x009BD74F
		public void SetExternalMaterialReplace(UMaterialInterface material, EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.SetExternalMaterialReplace(material, bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x06022679 RID: 140921 RVA: 0x009BF568 File Offset: 0x009BD768
		public void SetExternalMaterialReplaceByIndex(UMaterialInterface material, FName bodyName, int materialIndex)
		{
			this.ControllerComponent.SetExternalMaterialReplaceByIndex(material, bodyName, materialIndex);
		}

		// Token: 0x0602267A RID: 140922 RVA: 0x009BF578 File Offset: 0x009BD778
		public void RemoveExternalMaterialReplace(EKuroCharBodySpecifiedType bodyType, EKuroCharSlotSpecifiedType slotType, EKuroCharMeshPart? meshPart = null)
		{
			this.ControllerComponent.RemoveExternalMaterialReplace(bodyType, slotType, meshPart.GetValueOrDefault(EKuroCharMeshPart.ECharacterMeshPart_Max));
		}

		// Token: 0x0602267B RID: 140923 RVA: 0x009BF590 File Offset: 0x009BD790
		public void RemoveExternalMaterialReplaceByIndex(FName bodyName, int materialIndex)
		{
			this.ControllerComponent.RemoveExternalMaterialReplaceByIndex(bodyName, materialIndex);
		}

		// Token: 0x0602267C RID: 140924 RVA: 0x009BF59F File Offset: 0x009BD79F
		public void AddAlphaTestCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.AddExternalAlphaTestRefCount(bodyType);
		}

		// Token: 0x0602267D RID: 140925 RVA: 0x009BF5AD File Offset: 0x009BD7AD
		public void AddOutlineStencilTestCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.AddExternalOutlineStencilTestRefCount(bodyType);
		}

		// Token: 0x0602267E RID: 140926 RVA: 0x009BF5BB File Offset: 0x009BD7BB
		public void AddBattleCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.AddExternalBattleRefCount(bodyType);
		}

		// Token: 0x0602267F RID: 140927 RVA: 0x009BF5C9 File Offset: 0x009BD7C9
		public void AddBattleMaskCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.AddExternalBattleMaskRefCount(bodyType);
		}

		// Token: 0x06022680 RID: 140928 RVA: 0x009BF5D7 File Offset: 0x009BD7D7
		public void RemoveAlphaTestCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.RemoveExternalAlphaTestRefCount(bodyType);
		}

		// Token: 0x06022681 RID: 140929 RVA: 0x009BF5E5 File Offset: 0x009BD7E5
		public void RemoveOutlineStencilTestCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.RemoveExternalOutlineStencilTestRefCount(bodyType);
		}

		// Token: 0x06022682 RID: 140930 RVA: 0x009BF5F3 File Offset: 0x009BD7F3
		public void RemoveBattleCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.RemoveExternalBattleRefCount(bodyType);
		}

		// Token: 0x06022683 RID: 140931 RVA: 0x009BF601 File Offset: 0x009BD801
		public void RemoveBattleMaskCount(EKuroCharBodySpecifiedType bodyType)
		{
			this.ControllerComponent.RemoveExternalBattleMaskRefCount(bodyType);
		}

		// Token: 0x06022684 RID: 140932 RVA: 0x009BF60F File Offset: 0x009BD80F
		public void SetNoWater(bool value)
		{
			this.ControllerComponent.SetAllBodyNoWater(value);
		}

		// Token: 0x06022685 RID: 140933 RVA: 0x009BF61D File Offset: 0x009BD81D
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

		// Token: 0x06022686 RID: 140934 RVA: 0x009BF64E File Offset: 0x009BD84E
		public void RemoveEffectFinishCallback(Action<int> callback)
		{
			if (this.OnEffectFinishCallbackSet == null)
			{
				return;
			}
			this.OnEffectFinishCallbackSet.Remove(callback);
		}

		// Token: 0x06022687 RID: 140935 RVA: 0x009BF666 File Offset: 0x009BD866
		public bool GetAnyUnloopEffect()
		{
			return this.ControllerComponent.GetAnyUnloopEffect();
		}

		// Token: 0x06022688 RID: 140936 RVA: 0x009BF674 File Offset: 0x009BD874
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

		// Token: 0x06022689 RID: 140937 RVA: 0x009BF82E File Offset: 0x009BDA2E
		public override void Destroy()
		{
		}

		// Token: 0x0602268A RID: 140938 RVA: 0x009BF830 File Offset: 0x009BDA30
		public override string GetStatName()
		{
			return "CharMaterialContainerV2";
		}

		// Token: 0x0602268B RID: 140939 RVA: 0x009BF837 File Offset: 0x009BDA37
		public override int GetComponentId()
		{
			return 13;
		}

		// Token: 0x04012EE7 RID: 77543
		[Nullable(2)]
		private UKuroMaterialControllerComponent ControllerComponent;

		// Token: 0x04012EE8 RID: 77544
		[Nullable(2)]
		private Stat StatTick;

		// Token: 0x04012EE9 RID: 77545
		[Nullable(2)]
		private Stat StatUpdateEffectOnly;

		// Token: 0x04012EEA RID: 77546
		public string IdentifyName = string.Empty;

		// Token: 0x04012EEB RID: 77547
		[Nullable(2)]
		private CharBodyEffect BodyEffect;

		// Token: 0x04012EEC RID: 77548
		public string[] MeshPartHeadNamesArray = new string[]
		{
			"Bangs",
			"Hair",
			"Head",
			"Face",
			"Eye"
		};

		// Token: 0x04012EED RID: 77549
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private HashSet<Action<int>> OnEffectFinishCallbackSet;
	}
}
