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
	// Token: 0x020034C6 RID: 13510
	[NullableContext(1)]
	[Nullable(0)]
	public class CharDecalShadow : CharRenderBase, IStaticVariableResetter
	{
		// Token: 0x0602261C RID: 140828 RVA: 0x009BD7D4 File Offset: 0x009BB9D4
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

		// Token: 0x0602261D RID: 140829 RVA: 0x009BD868 File Offset: 0x009BBA68
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

		// Token: 0x0602261E RID: 140830 RVA: 0x009BD908 File Offset: 0x009BBB08
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

		// Token: 0x0602261F RID: 140831 RVA: 0x009BD948 File Offset: 0x009BBB48
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

		// Token: 0x06022620 RID: 140832 RVA: 0x009BD9A8 File Offset: 0x009BBBA8
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

		// Token: 0x06022621 RID: 140833 RVA: 0x009BD9E0 File Offset: 0x009BBBE0
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

		// Token: 0x06022622 RID: 140834 RVA: 0x009BDA19 File Offset: 0x009BBC19
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

		// Token: 0x06022623 RID: 140835 RVA: 0x009BDA43 File Offset: 0x009BBC43
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

		// Token: 0x06022624 RID: 140836 RVA: 0x009BDA64 File Offset: 0x009BBC64
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

		// Token: 0x06022625 RID: 140837 RVA: 0x009BDC1A File Offset: 0x009BBE1A
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

		// Token: 0x06022626 RID: 140838 RVA: 0x009BDC3B File Offset: 0x009BBE3B
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

		// Token: 0x06022627 RID: 140839 RVA: 0x009BDC5C File Offset: 0x009BBE5C
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

		// Token: 0x06022628 RID: 140840 RVA: 0x009BDD50 File Offset: 0x009BBF50
		public void DisableAllShadow()
		{
			this.DisableDecalShadow();
			this.DisableRealTimeShadow();
		}

		// Token: 0x06022629 RID: 140841 RVA: 0x009BDD60 File Offset: 0x009BBF60
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

		// Token: 0x0602262A RID: 140842 RVA: 0x009BDE14 File Offset: 0x009BC014
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

		// Token: 0x0602262B RID: 140843 RVA: 0x009BDE8C File Offset: 0x009BC08C
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

		// Token: 0x0602262C RID: 140844 RVA: 0x009BDF2C File Offset: 0x009BC12C
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

		// Token: 0x0602262D RID: 140845 RVA: 0x009BDFC5 File Offset: 0x009BC1C5
		public override string GetStatName()
		{
			return "CharDecalShadow";
		}

		// Token: 0x0602262E RID: 140846 RVA: 0x009BDFCC File Offset: 0x009BC1CC
		public override int GetComponentId()
		{
			return 10;
		}

		// Token: 0x0602262F RID: 140847 RVA: 0x009BDFD0 File Offset: 0x009BC1D0
		static CharDecalShadow()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharDecalShadow.CreateStaticDefaultValue), new Action(CharDecalShadow.ResetStaticDefaultValue));
		}

		// Token: 0x06022630 RID: 140848 RVA: 0x009BDFFF File Offset: 0x009BC1FF
		public static void CreateStaticDefaultValue()
		{
			CharDecalShadow.ComponentsSet = new HashSet<CharDecalShadow>();
			CharDecalShadow.GlobalEventRegistered = false;
		}

		// Token: 0x06022631 RID: 140849 RVA: 0x009BE011 File Offset: 0x009BC211
		public static void ResetStaticDefaultValue()
		{
			CharDecalShadow.ComponentsSet = null;
			CharDecalShadow.GlobalEventRegistered = false;
		}

		// Token: 0x04012EBF RID: 77503
		private static bool GlobalEventRegistered = false;

		// Token: 0x04012EC0 RID: 77504
		private static HashSet<CharDecalShadow> ComponentsSet;

		// Token: 0x04012EC1 RID: 77505
		private bool ShouldCastShadow = true;

		// Token: 0x04012EC2 RID: 77506
		private bool DecalShadowEnabled;

		// Token: 0x04012EC3 RID: 77507
		private bool RealTimeShadowEnabled = true;

		// Token: 0x04012EC4 RID: 77508
		[Nullable(2)]
		private AActor CachedOwner;

		// Token: 0x04012EC5 RID: 77509
		[Nullable(2)]
		private PDA_DecalShadowConfig_C Config;

		// Token: 0x04012EC6 RID: 77510
		private readonly Dictionary<string, UPrimitiveComponent> PrimitiveComponents = new Dictionary<string, UPrimitiveComponent>();

		// Token: 0x04012EC7 RID: 77511
		[Nullable(2)]
		private AActor DecalShadowActor;

		// Token: 0x04012EC8 RID: 77512
		[Nullable(2)]
		private UDecalComponent DecalShadowComponent;

		// Token: 0x04012EC9 RID: 77513
		[Nullable(2)]
		private UMaterialInstanceDynamic DynamicDecalShadowMaterial;

		// Token: 0x04012ECA RID: 77514
		private float ShadowOpacity = 1f;

		// Token: 0x04012ECB RID: 77515
		private static readonly float OpacityThresholdToDisableShadow = 0.2f;

		// Token: 0x020091E7 RID: 37351
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0402DAFB RID: 187131
			[Nullable(0)]
			public static Action<int> <0>__OnSetDecalShadowEnabled;
		}
	}
}
