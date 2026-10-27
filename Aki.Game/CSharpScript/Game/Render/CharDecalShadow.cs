using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.DecalShadow;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x0200459E RID: 17822
	[NullableContext(1)]
	[Nullable(0)]
	public class CharDecalShadow : CharRenderBase, IStaticVariableResetter
	{
		// Token: 0x0602DF32 RID: 188210 RVA: 0x00A915B4 File Offset: 0x00A8F7B4
		public static void OnSetDecalShadowEnabled(int enable)
		{
			if (enable > 0)
			{
				using (HashSet<CharDecalShadow>.Enumerator enumerator = CharDecalShadow.ComponentsSet.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						CharDecalShadow charDecalShadow = enumerator.Current;
						charDecalShadow.EnableDecalShadow();
					}
					return;
				}
			}
			foreach (CharDecalShadow charDecalShadow2 in CharDecalShadow.ComponentsSet)
			{
				charDecalShadow2.DisableDecalShadow();
			}
		}

		// Token: 0x0602DF33 RID: 188211 RVA: 0x00A91648 File Offset: 0x00A8F848
		public override void Start()
		{
			this.CachedOwner = base.GetRenderingComponent().GetOwner();
			this.Config = base.GetRenderingComponent().DecalShadowConfig;
			if (this.Config == null)
			{
				this.Config = RenderDataManager.Instance.GetGlobalDecalShadowConfig();
			}
			if (this.Config == null)
			{
				return;
			}
			this.CollectPrimitives();
			CharDecalShadow.ComponentsSet.Add(this);
			if (!CharDecalShadow.GlobalEventRegistered)
			{
				EventSystem instance = EventSystem.Instance;
				EEventName name = EEventName.SetDecalShadowEnabled;
				Action<int> handle;
				if ((handle = CharDecalShadow.<>O.<0>__OnSetDecalShadowEnabled) == null)
				{
					handle = (CharDecalShadow.<>O.<0>__OnSetDecalShadowEnabled = new Action<int>(CharDecalShadow.OnSetDecalShadowEnabled));
				}
				instance.Add(name, handle);
				CharDecalShadow.GlobalEventRegistered = true;
			}
			base.OnInitSuccess();
		}

		// Token: 0x0602DF34 RID: 188212 RVA: 0x00A916E8 File Offset: 0x00A8F8E8
		public override void Destroy()
		{
			AActor decalShadowActor = this.DecalShadowActor;
			if (decalShadowActor != null)
			{
				decalShadowActor.K2_DestroyActor();
			}
			CharDecalShadow.ComponentsSet.Remove(this);
			this.PrimitiveComponents.Clear();
			this.DecalShadowActor = null;
			this.DecalShadowComponent = null;
			this.DynamicDecalShadowMaterial = null;
		}

		// Token: 0x0602DF35 RID: 188213 RVA: 0x00A91728 File Offset: 0x00A8F928
		private void CollectPrimitives()
		{
			TArray<UActorComponent> tarray = this.CachedOwner.K2_GetComponentsByClass(UPrimitiveComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				UPrimitiveComponent uprimitiveComponent = tarray.Get(i) as UPrimitiveComponent;
				if (uprimitiveComponent != null && uprimitiveComponent.CastShadow)
				{
					this.PrimitiveComponents[uprimitiveComponent.GetName()] = uprimitiveComponent;
				}
			}
		}

		// Token: 0x0602DF36 RID: 188214 RVA: 0x00A91788 File Offset: 0x00A8F988
		public void AddPrimitiveComponent(string name, UPrimitiveComponent comp)
		{
			this.RemovePrimitiveComponent(name);
			if (!comp.IsValid() || !comp.CastShadow)
			{
				return;
			}
			this.PrimitiveComponents[name] = comp;
			if (!this.RealTimeShadowEnabled)
			{
				comp.CastShadow = false;
			}
		}

		// Token: 0x0602DF37 RID: 188215 RVA: 0x00A917C0 File Offset: 0x00A8F9C0
		public void RemovePrimitiveComponent(string name)
		{
			UPrimitiveComponent uprimitiveComponent;
			if (this.PrimitiveComponents.TryGetValue(name, out uprimitiveComponent))
			{
				this.PrimitiveComponents.Remove(name);
				if (uprimitiveComponent.IsValid())
				{
					uprimitiveComponent.CastShadow = true;
				}
			}
		}

		// Token: 0x0602DF38 RID: 188216 RVA: 0x00A917F9 File Offset: 0x00A8F9F9
		public void EnableDecalShadow()
		{
			if (this.DecalShadowEnabled)
			{
				return;
			}
			if (this.Config == null)
			{
				return;
			}
			this.DecalShadowEnabled = true;
			if (this.ShouldCastShadow)
			{
				this.UpdateDecalShadow(true);
			}
		}

		// Token: 0x0602DF39 RID: 188217 RVA: 0x00A91823 File Offset: 0x00A8FA23
		public void DisableDecalShadow()
		{
			if (!this.DecalShadowEnabled)
			{
				return;
			}
			this.DecalShadowEnabled = false;
			if (this.ShouldCastShadow)
			{
				this.UpdateDecalShadow(false);
			}
		}

		// Token: 0x0602DF3A RID: 188218 RVA: 0x00A91844 File Offset: 0x00A8FA44
		public void UpdateDecalShadow(bool visible)
		{
			if (visible)
			{
				PDA_DecalShadowConfig_C config = this.Config;
				if (config == null)
				{
					return;
				}
				AActor cachedOwner = this.CachedOwner;
				UCapsuleComponent ucapsuleComponent = cachedOwner.GetComponentByClass(UCapsuleComponent.StaticClass()) as UCapsuleComponent;
				if (ucapsuleComponent == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Render;
					ELogAuthor author = ELogAuthor.LSY;
					string message = "Decal Shadow找不到胶囊体";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor: ", cachedOwner);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				if (this.DecalShadowActor == null)
				{
					this.DecalShadowActor = ActorSystem.Instance.Spawn(AActor.StaticClass(), new FTransformDouble(), this.CachedOwner);
					AActor decalShadowActor = this.DecalShadowActor;
					TSubclassOf<UActorComponent> @class = UDecalComponent.StaticClass();
					bool bManualAttachment = false;
					FTransform ftransform = new FTransform();
					this.DecalShadowComponent = (decalShadowActor.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as UDecalComponent);
					AttachToActorController.Instance.AttachToActor(this.DecalShadowActor, this.CachedOwner, EDetachType.DestroyExternal, "CharDecalShadow.EnableDecalShadow", null, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true, false, false, false);
					AActor decalShadowActor2 = this.DecalShadowActor;
					FVector fvector = new FVector(0f, -90f, 0f);
					decalShadowActor2.K2_SetActorRotation(FRotator.MakeFromEuler(fvector), true);
					FHitResult fhitResult = new FHitResult();
					this.DecalShadowActor.D_K2_SetActorRelativeLocation(new FVectorDouble(0.0, 0.0, (double)(-(double)ucapsuleComponent.CapsuleHalfHeight)), false, ref fhitResult, true);
					this.SetDecalShadowConfig(config, ucapsuleComponent.CapsuleRadius, ucapsuleComponent.CapsuleHalfHeight);
				}
				else
				{
					this.DecalShadowComponent.SetVisibility(true, false);
					if (!Info.Instance.IsGameRunning())
					{
						this.SetDecalShadowConfig(config, ucapsuleComponent.CapsuleRadius, ucapsuleComponent.CapsuleHalfHeight);
					}
				}
			}
			else
			{
				UDecalComponent decalShadowComponent = this.DecalShadowComponent;
				if (decalShadowComponent != null)
				{
					decalShadowComponent.SetVisibility(false, false);
				}
			}
			this.SetDecalShadowOpacity(this.ShadowOpacity);
		}

		// Token: 0x0602DF3B RID: 188219 RVA: 0x00A919FA File Offset: 0x00A8FBFA
		public void EnableRealTimeShadow()
		{
			if (this.RealTimeShadowEnabled)
			{
				return;
			}
			this.RealTimeShadowEnabled = true;
			if (this.ShouldCastShadow)
			{
				this.UpdateRealTimeShadow(true);
			}
		}

		// Token: 0x0602DF3C RID: 188220 RVA: 0x00A91A1B File Offset: 0x00A8FC1B
		public void DisableRealTimeShadow()
		{
			if (!this.RealTimeShadowEnabled)
			{
				return;
			}
			this.RealTimeShadowEnabled = false;
			if (this.ShouldCastShadow)
			{
				this.UpdateRealTimeShadow(false);
			}
		}

		// Token: 0x0602DF3D RID: 188221 RVA: 0x00A91A3C File Offset: 0x00A8FC3C
		public void UpdateRealTimeShadow(bool visible)
		{
			if (visible)
			{
				foreach (UPrimitiveComponent uprimitiveComponent in this.PrimitiveComponents.Values)
				{
					uprimitiveComponent.SetCastShadow(true);
					uprimitiveComponent.ForceCastShadowInRayTracing = true;
				}
				CharBodyEffect charBodyEffect = base.GetRenderingComponent().GetComponent(9) as CharBodyEffect;
				if (charBodyEffect != null)
				{
					charBodyEffect.SetCastShadow(true);
				}
			}
			else
			{
				foreach (UPrimitiveComponent uprimitiveComponent2 in this.PrimitiveComponents.Values)
				{
					uprimitiveComponent2.SetCastShadow(false);
					uprimitiveComponent2.ForceCastShadowInRayTracing = false;
				}
				CharBodyEffect charBodyEffect2 = base.GetRenderingComponent().GetComponent(9) as CharBodyEffect;
				if (charBodyEffect2 != null)
				{
					charBodyEffect2.SetCastShadow(false);
				}
			}
			this.SetRealTimeShadowOpacity(this.ShadowOpacity);
		}

		// Token: 0x0602DF3E RID: 188222 RVA: 0x00A91B30 File Offset: 0x00A8FD30
		public void DisableAllShadow()
		{
			this.DisableDecalShadow();
			this.DisableRealTimeShadow();
		}

		// Token: 0x0602DF3F RID: 188223 RVA: 0x00A91B40 File Offset: 0x00A8FD40
		public unsafe void SetShouldCastShadow(bool castShadow)
		{
			if (castShadow == this.ShouldCastShadow)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderCharacter;
			ELogAuthor author = ELogAuthor.LSY;
			string message = "CharDecalShadow SetShouldCastShadow";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("castShadow", castShadow);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "name";
			CharRenderingComponent renderingComponent = base.GetRenderingComponent();
			ptr = new ValueTuple<string, object>(item, (renderingComponent != null) ? renderingComponent.GetCachedOwnerName() : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.ShouldCastShadow = castShadow;
			if (castShadow)
			{
				this.UpdateDecalShadow(this.DecalShadowEnabled);
				this.UpdateRealTimeShadow(this.RealTimeShadowEnabled);
				return;
			}
			this.UpdateDecalShadow(false);
			this.UpdateRealTimeShadow(false);
		}

		// Token: 0x0602DF40 RID: 188224 RVA: 0x00A91BF4 File Offset: 0x00A8FDF4
		public void SetDecalShadowOpacity(float opacity)
		{
			this.ShadowOpacity = opacity;
			if (this.DecalShadowComponent == null || !this.DecalShadowComponent.IsValid())
			{
				return;
			}
			if (this.DecalShadowEnabled && this.ShouldCastShadow)
			{
				if ((double)opacity < 0.0001)
				{
					this.DecalShadowComponent.SetVisibility(false, false);
					return;
				}
				this.DecalShadowComponent.SetVisibility(true, false);
				this.DynamicDecalShadowMaterial.SetScalarParameterValue(new FName("Opacity"), opacity);
			}
		}

		// Token: 0x0602DF41 RID: 188225 RVA: 0x00A91C6C File Offset: 0x00A8FE6C
		public void SetRealTimeShadowOpacity(float opacity)
		{
			this.ShadowOpacity = opacity;
			if (this.RealTimeShadowEnabled)
			{
				ECharacterRenderingType? renderType = base.GetRenderingComponent().RenderType;
				ECharacterRenderingType echaracterRenderingType = ECharacterRenderingType.Npc;
				if ((renderType.GetValueOrDefault() == echaracterRenderingType & renderType != null) && this.ShouldCastShadow)
				{
					bool flag = opacity > CharDecalShadow.OpacityThresholdToDisableShadow;
					foreach (UPrimitiveComponent uprimitiveComponent in this.PrimitiveComponents.Values)
					{
						uprimitiveComponent.SetCastShadow(flag);
						uprimitiveComponent.ForceCastShadowInRayTracing = flag;
					}
				}
			}
		}

		// Token: 0x0602DF42 RID: 188226 RVA: 0x00A91D0C File Offset: 0x00A8FF0C
		private void SetDecalShadowConfig(PDA_DecalShadowConfig_C config, float capsuleRadius, float capsuleHalfHeight)
		{
			if (this.DecalShadowComponent == null)
			{
				return;
			}
			this.DecalShadowComponent.ZFadingFactor = config.ZDistanceFadeFactor;
			this.DecalShadowComponent.ZFadingPower = config.ZDistanceFadePower;
			this.DynamicDecalShadowMaterial = UKismetMaterialLibrary.CreateDynamicMaterialInstance(this.DecalShadowComponent, config.DecalShadowMaterial, default(FName), EMIDCreationFlags.None);
			this.DecalShadowComponent.SetDecalMaterial(this.DynamicDecalShadowMaterial);
			double num = 25.0 * (double)config.DecalBoxScaleHori;
			float num2 = capsuleHalfHeight * config.DecalBoxScaleVerti;
			this.DecalShadowComponent.D_SetWorldScale3D(new FVectorDouble((double)num2, num, num));
		}

		// Token: 0x0602DF43 RID: 188227 RVA: 0x00A91DA5 File Offset: 0x00A8FFA5
		public override string GetStatName()
		{
			return "CharDecalShadow";
		}

		// Token: 0x0602DF44 RID: 188228 RVA: 0x00A91DAC File Offset: 0x00A8FFAC
		public override int GetComponentId()
		{
			return 10;
		}

		// Token: 0x0602DF45 RID: 188229 RVA: 0x00A91DB0 File Offset: 0x00A8FFB0
		static CharDecalShadow()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharDecalShadow.CreateStaticDefaultValue), new Action(CharDecalShadow.ResetStaticDefaultValue));
		}

		// Token: 0x0602DF46 RID: 188230 RVA: 0x00A91DDF File Offset: 0x00A8FFDF
		public static void CreateStaticDefaultValue()
		{
			CharDecalShadow.ComponentsSet = new HashSet<CharDecalShadow>();
			CharDecalShadow.GlobalEventRegistered = false;
		}

		// Token: 0x0602DF47 RID: 188231 RVA: 0x00A91DF1 File Offset: 0x00A8FFF1
		public static void ResetStaticDefaultValue()
		{
			CharDecalShadow.ComponentsSet = null;
			CharDecalShadow.GlobalEventRegistered = false;
		}

		// Token: 0x04018884 RID: 100484
		private static bool GlobalEventRegistered = false;

		// Token: 0x04018885 RID: 100485
		private static HashSet<CharDecalShadow> ComponentsSet;

		// Token: 0x04018886 RID: 100486
		private bool ShouldCastShadow = true;

		// Token: 0x04018887 RID: 100487
		private bool DecalShadowEnabled;

		// Token: 0x04018888 RID: 100488
		private bool RealTimeShadowEnabled = true;

		// Token: 0x04018889 RID: 100489
		[Nullable(2)]
		private AActor CachedOwner;

		// Token: 0x0401888A RID: 100490
		[Nullable(2)]
		private PDA_DecalShadowConfig_C Config;

		// Token: 0x0401888B RID: 100491
		private readonly Dictionary<string, UPrimitiveComponent> PrimitiveComponents = new Dictionary<string, UPrimitiveComponent>();

		// Token: 0x0401888C RID: 100492
		[Nullable(2)]
		private AActor DecalShadowActor;

		// Token: 0x0401888D RID: 100493
		[Nullable(2)]
		private UDecalComponent DecalShadowComponent;

		// Token: 0x0401888E RID: 100494
		[Nullable(2)]
		private UMaterialInstanceDynamic DynamicDecalShadowMaterial;

		// Token: 0x0401888F RID: 100495
		private float ShadowOpacity = 1f;

		// Token: 0x04018890 RID: 100496
		private static readonly float OpacityThresholdToDisableShadow = 0.2f;

		// Token: 0x0200A830 RID: 43056
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403336F RID: 209775
			[Nullable(0)]
			public static Action<int> <0>__OnSetDecalShadowEnabled;
		}
	}
}
