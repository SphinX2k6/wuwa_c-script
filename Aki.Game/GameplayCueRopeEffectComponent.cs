using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002FD0 RID: 12240
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueRopeEffectComponent : GameplayCueBase
{
	// Token: 0x06019F28 RID: 106280 RVA: 0x006C9E55 File Offset: 0x006C8055
	protected override void OnInit()
	{
	}

	// Token: 0x06019F29 RID: 106281 RVA: 0x006C9E58 File Offset: 0x006C8058
	protected override void OnTick(float delta)
	{
		URopeEffectComponent ropeEffectComponent = this.RopeEffectComponent;
		ARopeEffectSplineActor aropeEffectSplineActor = (ropeEffectComponent != null) ? ropeEffectComponent.GetRopeActor() : null;
		if (aropeEffectSplineActor == null)
		{
			return;
		}
		bool bHidden = this.ActorInternal.bHidden;
		bool flag = bHidden;
		bool? lastHidden = this.LastHidden;
		if (!(flag == lastHidden.GetValueOrDefault() & lastHidden != null))
		{
			this.LastHidden = new bool?(bHidden);
			aropeEffectSplineActor.SetActorHiddenInGame(bHidden);
		}
	}

	// Token: 0x06019F2A RID: 106282 RVA: 0x006C9EB8 File Offset: 0x006C80B8
	protected override void OnCreate()
	{
		if (this.ActorInternal == null || this.ActorInternal.Mesh == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "创建切片绳索失败：目标角色无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		URopeEffectComponent uropeEffectComponent = this.ActorInternal.GetComponentByClass(URopeEffectComponent.StaticClass()) as URopeEffectComponent;
		if (uropeEffectComponent != null)
		{
			uropeEffectComponent.DestroyRope();
			this.ActorInternal.K2_DestroyComponent(uropeEffectComponent);
		}
		AActor actorInternal = this.ActorInternal;
		TSubclassOf<UActorComponent> @class = URopeEffectComponent.StaticClass();
		bool bManualAttachment = false;
		FTransform ftransform = new FTransform();
		this.RopeEffectComponent = (actorInternal.AddComponentByClass(@class, bManualAttachment, ftransform, false, default(FName)) as URopeEffectComponent);
		if (this.RopeEffectComponent == null)
		{
			Log.Instance.Error(ELogModule.Battle, ELogAuthor.TSL, "创建切片绳索失败：AddComponentByClass 返回空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.RopeEffectComponent.bAutoFindSkeletalMesh = true;
		this.IsActive = true;
		this.LoadGeneration++;
		this.LoadRopeDataAsset();
	}

	// Token: 0x06019F2B RID: 106283 RVA: 0x006C9FA8 File Offset: 0x006C81A8
	protected override void OnDestroy()
	{
		this.IsActive = false;
		this.LoadGeneration++;
		if (this.RopeEffectComponent != null)
		{
			this.RopeEffectComponent.DestroyRope();
			this.RopeEffectComponent.RopeDataAsset = null;
			if (this.ActorInternal != null)
			{
				this.ActorInternal.K2_DestroyComponent(this.RopeEffectComponent);
			}
		}
		this.RopeEffectComponent = null;
		this.LastHidden = null;
	}

	// Token: 0x06019F2C RID: 106284 RVA: 0x006CA015 File Offset: 0x006C8215
	public new static bool IsSingleInstance()
	{
		return false;
	}

	// Token: 0x06019F2D RID: 106285 RVA: 0x006CA018 File Offset: 0x006C8218
	private unsafe void LoadRopeDataAsset()
	{
		URopeEffectComponent comp = this.RopeEffectComponent;
		if (comp == null)
		{
			return;
		}
		int generation = this.LoadGeneration;
		string path = "/Game/Aki/Render/RuntimeBP/RopeEffectComponent/DA/RopeDA.RopeDA";
		ResourceSystem.Instance.LoadAsync<URopeEffectDataAsset>(path, delegate([Nullable(2)] URopeEffectDataAsset dataAsset, string _)
		{
			if (generation != this.LoadGeneration || !this.IsActive)
			{
				return;
			}
			if (dataAsset == null || !dataAsset.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.TSL;
				string message = "切片绳索 DataAsset 加载无效";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", this.BuffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Path", path);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			if (!comp.IsValid() || comp != this.RopeEffectComponent)
			{
				return;
			}
			comp.RopeDataAsset = dataAsset;
			if (!comp.GenerateSlicedRopes())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Battle;
				ELogAuthor author2 = ELogAuthor.TSL;
				string message2 = "切片绳索生成失败";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("BuffId", this.BuffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Target", this.ActorInternal);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("DA", path);
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				return;
			}
			ARopeEffectSplineActor ropeActor = comp.GetRopeActor();
			if (ropeActor != null)
			{
				this.LoadAndApplyNiagaraAsset(ropeActor, generation);
			}
		}, 100, "js_undefined");
	}

	// Token: 0x06019F2E RID: 106286 RVA: 0x006CA084 File Offset: 0x006C8284
	private unsafe void LoadAndApplyNiagaraAsset(ARopeEffectSplineActor ropeActor, int generation)
	{
		string niagaraPath = base.GetPath();
		if (string.IsNullOrEmpty(niagaraPath))
		{
			return;
		}
		ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(niagaraPath, delegate([Nullable(2)] UNiagaraSystem effectObject, string _)
		{
			if (generation != this.LoadGeneration || !this.IsActive)
			{
				return;
			}
			if (effectObject != null && effectObject.IsValid())
			{
				ARopeEffectSplineActor ropeActor2 = ropeActor;
				if (ropeActor2 != null && ropeActor2.IsValid())
				{
					ropeActor.SetRopeNiagaraAsset(effectObject);
					return;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.TSL;
			string message = "挂载 RopeNiagara 失败：资源或 RopeActor 无效";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BuffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Target", this.ActorInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Path", niagaraPath);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}, 100, "js_undefined");
	}

	// Token: 0x0400C467 RID: 50279
	[Nullable(2)]
	private URopeEffectComponent RopeEffectComponent;

	// Token: 0x0400C468 RID: 50280
	private bool? LastHidden;

	// Token: 0x0400C469 RID: 50281
	private int LoadGeneration;

	// Token: 0x0400C46A RID: 50282
	private const string DEFAULT_ROPE_DATA_ASSET_PATH = "/Game/Aki/Render/RuntimeBP/RopeEffectComponent/DA/RopeDA.RopeDA";
}
