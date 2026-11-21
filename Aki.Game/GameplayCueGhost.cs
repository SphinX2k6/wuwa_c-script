using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002515 RID: 9493
public class GameplayCueGhost : GameplayCueBase
{
	// Token: 0x060177C8 RID: 96200 RVA: 0x006EE370 File Offset: 0x006EC570
	protected override void OnInit()
	{
		int parametersLength = this.CueConfig.ParametersLength;
		if (parametersLength > 0)
		{
			this.SpawnRate = float.Parse(this.CueConfig.Parameters(0));
		}
		if (parametersLength > 1)
		{
			this.GhostLifeTime = float.Parse(this.CueConfig.Parameters(1));
		}
		if (parametersLength > 2)
		{
			this.UseSpawnRate = (this.CueConfig.Parameters(2) == "1");
		}
		if (parametersLength > 3)
		{
			this.SpawnInterval = float.Parse(this.CueConfig.Parameters(3));
		}
	}

	// Token: 0x060177C9 RID: 96201 RVA: 0x006EE3F8 File Offset: 0x006EC5F8
	protected unsafe override void OnCreate()
	{
		if (this.IsInstant)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "瞬间型Buff不支持配置残影特效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BuffId", this.BuffId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		Transform transform = Transform.Create();
		transform.SetLocation(this.ActorInternal.D_K2_GetActorLocation());
		EffectSystem instance2 = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(transform.ToUeTransform());
		this.EffectViewHandle = instance2.SpawnEffect(world, ftransformDouble, base.GetPath(), "[GameplayCueGhost.OnCreate]", this.CreateEffectContext(), EEffectType.Fight, null, null, null, false, false);
		this.EffectTimeScaleType = this.GetEffectTimeScaleType();
		this.CueComp.AddCueEffectToSet(this.EffectViewHandle, this.EffectTimeScaleType, (ECueHideRule)this.CueConfig.HideRule);
	}

	// Token: 0x060177CA RID: 96202 RVA: 0x006EE500 File Offset: 0x006EC700
	protected override void OnDestroy()
	{
		if (this.EffectViewHandle != 0 && EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectViewHandle, "[GameplayCueGhost.OnDestroy]", false, null);
			this.EffectViewHandle = 0;
		}
	}

	// Token: 0x060177CB RID: 96203 RVA: 0x006EE550 File Offset: 0x006EC750
	[NullableContext(1)]
	private EffectRuntimeGhostEffectContext CreateEffectContext()
	{
		return new EffectRuntimeGhostEffectContext(null, null, false)
		{
			SkeletalMeshComp = this.ActorInternal.Mesh,
			EntityId = new int?(this.EntityHandle.Id),
			SpawnRate = this.SpawnRate,
			UseSpawnRate = this.UseSpawnRate,
			SpawnInterval = this.SpawnInterval,
			GhostLifeTime = this.GhostLifeTime,
			SourceObject = this.ActorInternal
		};
	}

	// Token: 0x060177CC RID: 96204 RVA: 0x006EE5D0 File Offset: 0x006EC7D0
	private ETimeScaleType GetEffectTimeScaleType()
	{
		if (this.BuffHandleId <= 0)
		{
			return ETimeScaleType.FollowEntity;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		BaseBuffComponent baseBuffComponent = (entity != null) ? entity.GetComponent<BaseBuffComponent>() : null;
		IActiveBuff activeBuff = (baseBuffComponent != null) ? baseBuffComponent.GetBuffByHandle(this.BuffHandleId) : null;
		if (activeBuff == null)
		{
			return ETimeScaleType.FollowEntity;
		}
		Entity instigator = activeBuff.GetInstigator();
		bool? flag;
		if (instigator == null)
		{
			flag = null;
		}
		else
		{
			CreatureDataComponent component = instigator.GetComponent<CreatureDataComponent>();
			flag = ((component != null) ? new bool?(component.IsRole()) : null);
		}
		bool? flag2 = flag;
		if (!flag2.GetValueOrDefault())
		{
			return ETimeScaleType.FollowEntity;
		}
		return ETimeScaleType.ImmuneForeverTimeScale;
	}

	// Token: 0x0400C7CF RID: 51151
	private int EffectViewHandle;

	// Token: 0x0400C7D0 RID: 51152
	private ETimeScaleType EffectTimeScaleType;

	// Token: 0x0400C7D1 RID: 51153
	private float SpawnRate = 20f;

	// Token: 0x0400C7D2 RID: 51154
	private float GhostLifeTime = 0.25f;

	// Token: 0x0400C7D3 RID: 51155
	private bool UseSpawnRate = true;

	// Token: 0x0400C7D4 RID: 51156
	private float SpawnInterval = -1f;
}
