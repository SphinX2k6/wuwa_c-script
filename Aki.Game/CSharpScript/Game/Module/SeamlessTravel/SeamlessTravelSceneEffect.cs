using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02004C8E RID: 19598
	[NullableContext(1)]
	[Nullable(0)]
	public class SeamlessTravelSceneEffect
	{
		// Token: 0x17007CFF RID: 31999
		// (get) Token: 0x06032A76 RID: 207478 RVA: 0x00BD0397 File Offset: 0x00BCE597
		public bool IsInit
		{
			get
			{
				return this.IsInitInternal;
			}
		}

		// Token: 0x06032A77 RID: 207479 RVA: 0x00BD03A0 File Offset: 0x00BCE5A0
		public void Init(SeamlessTravelContext config, Action<bool> callback)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			this.ActorComp = ((baseCharacter != null) ? baseCharacter.CharacterActorComponent : null);
			if (this.ActorComp == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SeamlessTravel;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[SeamlessTravelSceneEffect]初始化失败，无效的ActorComp";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Context = config;
			if (this.IsInit)
			{
				callback(true);
				return;
			}
			UKuroRenderingRuntimeBPPluginBPLibrary.StartSceneColorShotBeforeTonemap(EKuroCaptureSceneColorType.KCSCT_Default);
			this.EffectDaPath = this.Context.SceneEffectDaPath;
			this.LoadEffectAsset(delegate(bool result)
			{
				this.IsInitInternal = true;
				callback(result);
			});
		}

		// Token: 0x06032A78 RID: 207480 RVA: 0x00BD0454 File Offset: 0x00BCE654
		private unsafe void LoadEffectAsset(Action<bool> callback)
		{
			if (string.IsNullOrEmpty(this.EffectDaPath))
			{
				callback(true);
				return;
			}
			ResourceSystem.Instance.LoadAsync<UEffectModelBase>(this.EffectDaPath, delegate([Nullable(2)] UEffectModelBase effectDaAsset, string path)
			{
				if (effectDaAsset == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SeamlessTravel;
					ELogAuthor author = ELogAuthor.ZYL;
					string message = "[SeamlessTravelSceneEffect] 加载DA失败";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", path);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActorName", Global.BaseCharacter);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					callback(false);
					return;
				}
				this.EffectDaAsset = effectDaAsset;
				float num = Math.Max(this.Context.EffectExpandTime, this.EffectDaAsset.StartTime);
				float num2 = Math.Max(this.Context.EffectCollapseTime, this.EffectDaAsset.EndTime);
				this.EffectStartTimeMs = num * 1000f;
				this.EffectEndTimeMs = num2 * 1000f;
				callback(true);
			}, 100, "SeamlessTravel.SceneEffect");
		}

		// Token: 0x06032A79 RID: 207481 RVA: 0x00BD04B3 File Offset: 0x00BCE6B3
		public void Tick(float delta)
		{
		}

		// Token: 0x06032A7A RID: 207482 RVA: 0x00BD04B8 File Offset: 0x00BCE6B8
		public void Destroy()
		{
			if (this.EffectHandle != null && EffectSystem.Instance.IsValid(this.EffectHandle.Value))
			{
				EffectSystem.Instance.StopEffectById(this.EffectHandle.Value, "[SeamlessTravelSceneEffect] DisappearEffect", true, null);
			}
			this.EffectActor = null;
			this.EffectHandle = null;
			this.EffectDaAsset = null;
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.KuroCaptureSceneColor.Release", null);
		}

		// Token: 0x06032A7B RID: 207483 RVA: 0x00BD0538 File Offset: 0x00BCE738
		public void AppearEffect(Action<bool> callback)
		{
			if (this.IsInit)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				bool flag;
				if (actorComp == null)
				{
					flag = true;
				}
				else
				{
					TsBaseCharacter actor = actorComp.Actor;
					flag = !((actor != null) ? new bool?(actor.IsValid()) : null).GetValueOrDefault();
				}
				if (!flag)
				{
					UEffectModelBase effectDaAsset = this.EffectDaAsset;
					if (effectDaAsset == null || !effectDaAsset.IsValid())
					{
						callback(false);
						return;
					}
					EffectSystem instance = EffectSystem.Instance;
					UObject world = GlobalData.World;
					FTransformDouble? ftransformDouble = new FTransformDouble?(this.ActorComp.ActorTransform);
					TTimerAction <>9__1;
					this.EffectHandle = new int?(instance.SpawnEffect(world, ftransformDouble, this.EffectDaPath, "[SeamlessTravelSceneEffect] AppearEffect", new EffectContext(null, this.ActorComp.Actor, false), EEffectType.Fight, null, null, delegate(int handle)
					{
						AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(handle);
						if (sureEffectActor == null || !sureEffectActor.IsValid())
						{
							callback(false);
							return;
						}
						UKuroRenderingRuntimeBPPluginBPLibrary.StopSceneColorShotBeforeTonemap(EKuroCaptureSceneColorType.KCSCT_Default, 0f);
						CharacterActorComponent actorComp2 = this.ActorComp;
						if (actorComp2 != null && actorComp2.Actor.IsValid())
						{
							sureEffectActor.K2_AttachToActor(this.ActorComp.Actor, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
						}
						this.EffectActor = sureEffectActor;
						if (this.EffectStartTimeMs < 20f)
						{
							callback(true);
							return;
						}
						TimerSystemInstance instance2 = TimerSystem.Instance;
						TTimerAction action;
						if ((action = <>9__1) == null)
						{
							action = (<>9__1 = delegate(float _)
							{
								callback(true);
							});
						}
						instance2.Delay(action, this.EffectStartTimeMs, null, null, true, 1f);
					}, false, false));
					return;
				}
			}
			callback(false);
		}

		// Token: 0x06032A7C RID: 207484 RVA: 0x00BD0630 File Offset: 0x00BCE830
		public void DisappearEffect(Action<bool> callback)
		{
			if (!this.IsInit)
			{
				callback(false);
				return;
			}
			if (this.EffectHandle == null || !EffectSystem.Instance.IsValid(this.EffectHandle.Value))
			{
				this.EffectActor = null;
				this.EffectHandle = null;
				callback(true);
				return;
			}
			EffectSystem.Instance.StopEffectById(this.EffectHandle.Value, "[SeamlessTravelSceneEffect] DisappearEffect", false, null);
			this.EffectActor = null;
			this.EffectHandle = null;
			if (this.EffectEndTimeMs < 20f)
			{
				callback(true);
				return;
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				callback(true);
			}, this.EffectEndTimeMs, null, null, true, 1f);
		}

		// Token: 0x06032A7D RID: 207485 RVA: 0x00BD071A File Offset: 0x00BCE91A
		public TArray<AActor> GetSeamlessTravelActors(TArray<AActor> arr)
		{
			if (this.EffectActor != null)
			{
				arr.Add(this.EffectActor);
			}
			return arr;
		}

		// Token: 0x0401AF57 RID: 110423
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x0401AF58 RID: 110424
		[Nullable(2)]
		private SeamlessTravelContext Context;

		// Token: 0x0401AF59 RID: 110425
		[Nullable(2)]
		private string EffectDaPath;

		// Token: 0x0401AF5A RID: 110426
		[Nullable(2)]
		private UEffectModelBase EffectDaAsset;

		// Token: 0x0401AF5B RID: 110427
		private int? EffectHandle;

		// Token: 0x0401AF5C RID: 110428
		[Nullable(2)]
		private AActor EffectActor;

		// Token: 0x0401AF5D RID: 110429
		private bool IsInitInternal;

		// Token: 0x0401AF5E RID: 110430
		private float EffectStartTimeMs;

		// Token: 0x0401AF5F RID: 110431
		private float EffectEndTimeMs;
	}
}
