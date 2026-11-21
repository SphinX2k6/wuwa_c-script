using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C3E RID: 15422
	[NullableContext(2)]
	[Nullable(0)]
	public class SeamlessTravelPostProcess
	{
		// Token: 0x170050A7 RID: 20647
		// (get) Token: 0x0602781F RID: 161823 RVA: 0x00B14B00 File Offset: 0x00B12D00
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x170050A8 RID: 20648
		// (get) Token: 0x06027820 RID: 161824 RVA: 0x00B14B08 File Offset: 0x00B12D08
		public bool IsActive
		{
			get
			{
				return this.CurrentBlendStatus > SeamlessTravelPostProcess.EPostProcessBlendStatus.FullHide;
			}
		}

		// Token: 0x06027821 RID: 161825 RVA: 0x00B14B14 File Offset: 0x00B12D14
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

		// Token: 0x06027822 RID: 161826 RVA: 0x00B14BF8 File Offset: 0x00B12DF8
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

		// Token: 0x06027823 RID: 161827 RVA: 0x00B14D1C File Offset: 0x00B12F1C
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

		// Token: 0x06027824 RID: 161828 RVA: 0x00B14ED4 File Offset: 0x00B130D4
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

		// Token: 0x06027825 RID: 161829 RVA: 0x00B14F6E File Offset: 0x00B1316E
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

		// Token: 0x06027826 RID: 161830 RVA: 0x00B14FA5 File Offset: 0x00B131A5
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

		// Token: 0x06027827 RID: 161831 RVA: 0x00B14FDC File Offset: 0x00B131DC
		[NullableContext(1)]
		public TArray<AActor> GetSeamlessTravelActors(TArray<AActor> arr)
		{
			if (this.PostProcessVolume != null)
			{
				arr.Add(this.PostProcessVolume);
			}
			return arr;
		}

		// Token: 0x040158A9 RID: 88233
		private const int DEFAULT_TRANSITION_POSTPROCESS_PRIORITY = 9999;

		// Token: 0x040158AA RID: 88234
		private CharacterActorComponent ActorComp;

		// Token: 0x040158AB RID: 88235
		private SeamlessTravelContext Context;

		// Token: 0x040158AC RID: 88236
		private AKuroPostProcessVolume PostProcessVolume;

		// Token: 0x040158AD RID: 88237
		private string TransitionWeatherDaPath;

		// Token: 0x040158AE RID: 88238
		private bool IsInitInternal;

		// Token: 0x040158AF RID: 88239
		public SeamlessTravelPostProcess.EPostProcessBlendStatus CurrentBlendStatus;

		// Token: 0x040158B0 RID: 88240
		private float BlendInTimeMs;

		// Token: 0x040158B1 RID: 88241
		private float BlendOutTimeMs;

		// Token: 0x040158B2 RID: 88242
		private Action<bool> BlendInCallback;

		// Token: 0x040158B3 RID: 88243
		private Action<bool> BlendOutCallback;

		// Token: 0x02009855 RID: 38997
		[NullableContext(0)]
		public enum EPostProcessBlendStatus
		{
			// Token: 0x0402F83D RID: 194621
			FullHide,
			// Token: 0x0402F83E RID: 194622
			FullShow,
			// Token: 0x0402F83F RID: 194623
			BlendIn,
			// Token: 0x0402F840 RID: 194624
			BlendOut
		}
	}
}
