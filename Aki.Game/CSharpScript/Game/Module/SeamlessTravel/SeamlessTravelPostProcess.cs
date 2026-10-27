using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02004C8D RID: 19597
	[NullableContext(2)]
	[Nullable(0)]
	public class SeamlessTravelPostProcess
	{
		// Token: 0x17007CFD RID: 31997
		// (get) Token: 0x06032A6C RID: 207468 RVA: 0x00BCFE9C File Offset: 0x00BCE09C
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x17007CFE RID: 31998
		// (get) Token: 0x06032A6D RID: 207469 RVA: 0x00BCFEA4 File Offset: 0x00BCE0A4
		public bool IsActive
		{
			get
			{
				return this.CurrentBlendStatus > SeamlessTravelPostProcess.EPostProcessBlendStatus.FullHide;
			}
		}

		// Token: 0x06032A6E RID: 207470 RVA: 0x00BCFEB0 File Offset: 0x00BCE0B0
		[NullableContext(1)]
		public void Init(SeamlessTravelContext config, Action<bool> callback)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			this.ActorComp = ((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null);
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[无缝传送PPV]初始化失败，无效的ActorComp";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.CurrentBlendStatus = SeamlessTravelPostProcess.EPostProcessBlendStatus.FullHide;
			this.Context = config;
			if (this.IsInit)
			{
				callback(true);
				return;
			}
			this.BlendInTimeMs = this.Context.EffectExpandTime * 1000f;
			this.BlendOutTimeMs = this.Context.EffectCollapseTime * 1000f;
			this.TransitionWeatherDaPath = this.Context.TransitionWeatherDaPath;
			this.CreatePPV(delegate(bool result)
			{
				this.IsInitInternal = true;
				callback(result);
			});
		}

		// Token: 0x06032A6F RID: 207471 RVA: 0x00BCFF94 File Offset: 0x00BCE194
		[NullableContext(1)]
		private unsafe void CreatePPV(Action<bool> callback)
		{
			ActorSystem instance = ActorSystem.Instance;
			UClassStackOnlyPtr ueClassPtr = AKuroPostProcessVolume.StaticClass();
			CharacterActorComponent actorComp = this.ActorComp;
			this.PostProcessVolume = (instance.Get(ueClassPtr, (actorComp != null) ? actorComp.ActorTransform : MathUtils.Instance.DefaultTransformDouble, null, true) as AKuroPostProcessVolume);
			if (!this.PostProcessVolume.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.Teleport;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[无缝传送PPV] 创建PPV失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				callback(false);
				return;
			}
			this.PostProcessVolume.BlendWeight = 0f;
			this.PostProcessVolume.bUnbound = true;
			this.PostProcessVolume.bEnabled = false;
			this.PostProcessVolume.Priority = 9999f;
			UKuroRenderingRuntimeBPPluginBPLibrary.MarkWorldPostProcessPriorityDirty(this.PostProcessVolume);
			if (string.IsNullOrEmpty(this.TransitionWeatherDaPath))
			{
				callback(true);
				return;
			}
			ResourceSystem.Instance.LoadAsync<UKuroWeatherDataAsset>(this.TransitionWeatherDaPath, delegate([Nullable(2)] UKuroWeatherDataAsset res, string path)
			{
				if (res == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module2 = ELogModule.Teleport;
					ELogAuthor author2 = ELogAuthor.ZYL;
					string message2 = "[无缝传送PPV] 加载DA失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", path);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
					instance3.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					callback(false);
					return;
				}
				AKuroPostProcessVolume postProcessVolume = this.PostProcessVolume;
				if (postProcessVolume != null)
				{
					postProcessVolume.SetWeatherDataAsset(res);
				}
				callback(true);
			}, ResourceSystem.EResourceLoadPriority.Default, "SeamlessTravel.PostProcess");
		}

		// Token: 0x06032A70 RID: 207472 RVA: 0x00BD00B8 File Offset: 0x00BCE2B8
		public void Tick(float delta)
		{
			if (this.IsInit)
			{
				AKuroPostProcessVolume postProcessVolume = this.PostProcessVolume;
				if (postProcessVolume != null && postProcessVolume.IsValid())
				{
					if (!this.IsActive)
					{
						return;
					}
					if (this.ActorComp == null)
					{
						return;
					}
					float blendWeight = this.PostProcessVolume.BlendWeight;
					SeamlessTravelPostProcess.EPostProcessBlendStatus currentBlendStatus = this.CurrentBlendStatus;
					if (currentBlendStatus != SeamlessTravelPostProcess.EPostProcessBlendStatus.BlendIn)
					{
						if (currentBlendStatus != SeamlessTravelPostProcess.EPostProcessBlendStatus.BlendOut)
						{
							return;
						}
						this.PostProcessVolume.BlendWeight = MathUtils.Instance.Clamp(blendWeight - delta / this.BlendOutTimeMs, 0f, 1f);
						this.PostProcessVolume.D_K2_SetActorLocation(this.ActorComp.ActorLocation, false, ref WorldGlobal.SweepHitResult, true);
						this.PostProcessVolume.bEnabled = (this.PostProcessVolume.BlendWeight > 0f);
						this.PostProcessVolume.PostModify();
						if (blendWeight != 0f && this.PostProcessVolume.BlendWeight == 0f)
						{
							Action<bool> blendOutCallback = this.BlendOutCallback;
							this.BlendOutCallback = null;
							this.CurrentBlendStatus = SeamlessTravelPostProcess.EPostProcessBlendStatus.FullHide;
							if (blendOutCallback == null)
							{
								return;
							}
							blendOutCallback(true);
						}
					}
					else
					{
						this.PostProcessVolume.BlendWeight = MathUtils.Instance.Clamp(blendWeight + delta / this.BlendInTimeMs, 0f, 1f);
						this.PostProcessVolume.D_K2_SetActorLocation(this.ActorComp.ActorLocation, false, ref WorldGlobal.SweepHitResult, true);
						this.PostProcessVolume.bEnabled = (this.PostProcessVolume.BlendWeight > 0f);
						this.PostProcessVolume.PostModify();
						if (blendWeight != 1f && this.PostProcessVolume.BlendWeight == 1f)
						{
							Action<bool> blendInCallback = this.BlendInCallback;
							this.BlendInCallback = null;
							this.CurrentBlendStatus = SeamlessTravelPostProcess.EPostProcessBlendStatus.FullShow;
							if (blendInCallback == null)
							{
								return;
							}
							blendInCallback(true);
							return;
						}
					}
					return;
				}
			}
		}

		// Token: 0x06032A71 RID: 207473 RVA: 0x00BD0270 File Offset: 0x00BCE470
		public void Destroy()
		{
			AKuroPostProcessVolume postProcessVolume = this.PostProcessVolume;
			if (postProcessVolume != null && postProcessVolume.IsValid())
			{
				this.PostProcessVolume.BlendWeight = 0f;
				this.PostProcessVolume.bUnbound = false;
				this.PostProcessVolume.bEnabled = false;
				this.PostProcessVolume.Priority = 0f;
				ActorSystem.Instance.Put("SeamlessTravelPostProcess.Destroy", this.PostProcessVolume, null);
			}
			this.PostProcessVolume = null;
			this.ActorComp = null;
			this.Context = null;
			this.CurrentBlendStatus = SeamlessTravelPostProcess.EPostProcessBlendStatus.FullHide;
			this.BlendInCallback = null;
			this.BlendOutCallback = null;
		}

		// Token: 0x06032A72 RID: 207474 RVA: 0x00BD030A File Offset: 0x00BCE50A
		[NullableContext(1)]
		public void AppearEffect(Action<bool> callback)
		{
			if (this.IsInit)
			{
				AKuroPostProcessVolume postProcessVolume = this.PostProcessVolume;
				if (postProcessVolume != null && postProcessVolume.IsValid())
				{
					this.BlendInCallback = callback;
					this.CurrentBlendStatus = SeamlessTravelPostProcess.EPostProcessBlendStatus.BlendIn;
					return;
				}
			}
			callback(false);
		}

		// Token: 0x06032A73 RID: 207475 RVA: 0x00BD0341 File Offset: 0x00BCE541
		[NullableContext(1)]
		public void DisappearEffect(Action<bool> callback)
		{
			if (this.IsInit)
			{
				AKuroPostProcessVolume postProcessVolume = this.PostProcessVolume;
				if (postProcessVolume != null && postProcessVolume.IsValid())
				{
					this.BlendOutCallback = callback;
					this.CurrentBlendStatus = SeamlessTravelPostProcess.EPostProcessBlendStatus.BlendOut;
					return;
				}
			}
			callback(false);
		}

		// Token: 0x06032A74 RID: 207476 RVA: 0x00BD0378 File Offset: 0x00BCE578
		[NullableContext(1)]
		public TArray<AActor> GetSeamlessTravelActors(TArray<AActor> arr)
		{
			if (this.PostProcessVolume != null)
			{
				arr.Add(this.PostProcessVolume);
			}
			return arr;
		}

		// Token: 0x0401AF4C RID: 110412
		private const int DEFAULT_TRANSITION_POSTPROCESS_PRIORITY = 9999;

		// Token: 0x0401AF4D RID: 110413
		private CharacterActorComponent ActorComp;

		// Token: 0x0401AF4E RID: 110414
		private SeamlessTravelContext Context;

		// Token: 0x0401AF4F RID: 110415
		private AKuroPostProcessVolume PostProcessVolume;

		// Token: 0x0401AF50 RID: 110416
		private string TransitionWeatherDaPath;

		// Token: 0x0401AF51 RID: 110417
		private bool IsInitInternal;

		// Token: 0x0401AF52 RID: 110418
		public SeamlessTravelPostProcess.EPostProcessBlendStatus CurrentBlendStatus;

		// Token: 0x0401AF53 RID: 110419
		private float BlendInTimeMs;

		// Token: 0x0401AF54 RID: 110420
		private float BlendOutTimeMs;

		// Token: 0x0401AF55 RID: 110421
		private Action<bool> BlendInCallback;

		// Token: 0x0401AF56 RID: 110422
		private Action<bool> BlendOutCallback;

		// Token: 0x0200AE37 RID: 44599
		[NullableContext(0)]
		public enum EPostProcessBlendStatus
		{
			// Token: 0x04034E98 RID: 216728
			FullHide,
			// Token: 0x04034E99 RID: 216729
			FullShow,
			// Token: 0x04034E9A RID: 216730
			BlendIn,
			// Token: 0x04034E9B RID: 216731
			BlendOut
		}
	}
}
