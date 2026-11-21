using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x020021DD RID: 8669
[NullableContext(1)]
[Nullable(0)]
public class UiModelBuffComponent : UiModelComponentBase
{
	// Token: 0x0601554B RID: 87371 RVA: 0x00633682 File Offset: 0x00631882
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.EffectComponent = base.Owner.CheckGetComponent<UiModelEffectComponent>();
		this.RenderingMaterialComponent = base.Owner.CheckGetComponent<UiModelRenderingMaterialComponent>();
	}

	// Token: 0x0601554C RID: 87372 RVA: 0x006336B7 File Offset: 0x006318B7
	protected override void OnEnd()
	{
		this.RemoveAllBuffId();
	}

	// Token: 0x0601554D RID: 87373 RVA: 0x006336C0 File Offset: 0x006318C0
	public void AddBuffByBuffId(long buffId)
	{
		if (this.BuffToHandlesMap.ContainsKey(buffId))
		{
			return;
		}
		Buff? config = ConfigBuffById.GetConfig(buffId, true);
		if (config == null)
		{
			return;
		}
		long[] array = config.Value.GameplayCueIds();
		if (array.Length == 0)
		{
			return;
		}
		BuffHandle buffHandle = new BuffHandle();
		long[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			GameplayCue? config2 = ConfigGameplayCueById.GetConfig(array2[i], true);
			if (config2 != null)
			{
				this.ApplyCueConfig(config.Value, config2.Value, buffHandle);
			}
		}
		this.BuffToHandlesMap[buffId] = buffHandle;
	}

	// Token: 0x0601554E RID: 87374 RVA: 0x00633758 File Offset: 0x00631958
	private void ApplyCueConfig(Buff buffConfig, GameplayCue cueConfig, BuffHandle buffHandle)
	{
		ECueType cueType = (ECueType)cueConfig.CueType;
		if (cueType != ECueType.Effect)
		{
			if (cueType != ECueType.Material)
			{
				return;
			}
			int num = this.AddMaterialControllerByCueConfig(cueConfig);
			if (num > 0)
			{
				buffHandle.MaterialHandleSet.Add(num);
			}
		}
		else
		{
			int num2 = this.PlayEffectByConfig(buffConfig, cueConfig);
			if (num2 > 0)
			{
				buffHandle.EffectHandleSet.Add(num2);
				return;
			}
		}
	}

	// Token: 0x0601554F RID: 87375 RVA: 0x006337AC File Offset: 0x006319AC
	public int AddMaterialControllerByCueConfig(GameplayCue config)
	{
		string path = config.Path;
		if (StringUtils.IsBlank(path))
		{
			return 0;
		}
		if (this.RenderingMaterialComponent == null)
		{
			return 0;
		}
		return this.RenderingMaterialComponent.AddRenderingMaterialByPath(path);
	}

	// Token: 0x06015550 RID: 87376 RVA: 0x006337E4 File Offset: 0x006319E4
	public int PlayEffectByConfig(Buff buffConfig, GameplayCue cueConfig)
	{
		float buffDuration = 0f;
		if (buffConfig.DurationPolicy == 2 && buffConfig.DurationMagnitudeLength > 0)
		{
			buffDuration = buffConfig.DurationMagnitude(0);
		}
		UiModelEffectPlayContext uiModelEffectPlayContext = new UiModelEffectPlayContext();
		uiModelEffectPlayContext.Reset();
		uiModelEffectPlayContext.EffectPath = cueConfig.Path;
		uiModelEffectPlayContext.AttachTargetComponent = this.ActorComponent.MainMeshComponent;
		uiModelEffectPlayContext.LocationRule = (EAttachmentRule)cueConfig.LocRule;
		uiModelEffectPlayContext.RotationRule = (EAttachmentRule)cueConfig.RotaRule;
		uiModelEffectPlayContext.ScaleRule = (EAttachmentRule)cueConfig.SclRule;
		Aki.Config.Vector? location = cueConfig.Location;
		if (location != null)
		{
			Aki.Config.Vector value = location.Value;
			this.CacheLocation.Set((double)value.X, (double)value.Y, (double)value.Z);
			this.CacheTransform.SetLocation(this.CacheLocation);
		}
		Aki.Config.Vector? rotation = cueConfig.Rotation;
		if (rotation != null)
		{
			Aki.Config.Vector value2 = rotation.Value;
			this.CacheRotator.Set(value2.X, value2.Y, value2.Z);
			this.CacheTransform.SetRotation(this.CacheRotator.Quaternion(null));
		}
		Aki.Config.Vector? scale = cueConfig.Scale;
		if (scale != null)
		{
			Aki.Config.Vector value3 = scale.Value;
			this.CacheScale.Set((double)value3.X, (double)value3.Y, (double)value3.Z);
			this.CacheTransform.SetScale3D(this.CacheScale);
		}
		uiModelEffectPlayContext.Transform = this.CacheTransform.ToUeTransform();
		uiModelEffectPlayContext.SocketName = (FNameUtil.GetDynamicFName(cueConfig.Socket) ?? FNameUtil.EMPTY);
		if (buffDuration > 0f)
		{
			uiModelEffectPlayContext.Callback = delegate(ELoadEffectResult result, int handle)
			{
				if (result == ELoadEffectResult.Success)
				{
					float interval = buffDuration * (float)TimeUtil.Instance.InverseMillisecond;
					TimerSystem.Instance.Delay(delegate(float _)
					{
						this.StopEffectByCueEndRule(handle, (ECueEndRule)cueConfig.EndRule);
					}, interval, null, null, true, 1f);
				}
			};
		}
		return this.EffectComponent.PlayEffectByContext(uiModelEffectPlayContext);
	}

	// Token: 0x06015551 RID: 87377 RVA: 0x006339FC File Offset: 0x00631BFC
	public void StopEffectByCueEndRule(int effectHandle, ECueEndRule endRule)
	{
		bool bFastStop = false;
		if (EffectSystem.Instance.IsValid(effectHandle))
		{
			switch (endRule)
			{
			case ECueEndRule.Recycle:
				bFastStop = true;
				break;
			case ECueEndRule.End:
				bFastStop = false;
				break;
			case ECueEndRule.Continue:
				EffectSystem.Instance.FreezeHandle(effectHandle, false, false);
				bFastStop = false;
				break;
			}
			this.EffectComponent.StopEffect(effectHandle, bFastStop);
		}
	}

	// Token: 0x06015552 RID: 87378 RVA: 0x00633A50 File Offset: 0x00631C50
	public void RemoveBuffByBuffId(long buffId)
	{
		BuffHandle buffHandle;
		if (!this.BuffToHandlesMap.TryGetValue(buffId, out buffHandle))
		{
			return;
		}
		foreach (int effectHandle in buffHandle.EffectHandleSet)
		{
			this.EffectComponent.StopEffect(effectHandle, true);
		}
		buffHandle.EffectHandleSet.Clear();
		foreach (int materialId in buffHandle.MaterialHandleSet)
		{
			UiModelRenderingMaterialComponent renderingMaterialComponent = this.RenderingMaterialComponent;
			if (renderingMaterialComponent != null)
			{
				renderingMaterialComponent.RemoveRenderingMaterial(materialId);
			}
		}
		buffHandle.MaterialHandleSet.Clear();
		this.BuffToHandlesMap.Remove(buffId);
	}

	// Token: 0x06015553 RID: 87379 RVA: 0x00633B2C File Offset: 0x00631D2C
	public void RemoveAllBuffId()
	{
		if (this.BuffToHandlesMap.Count == 0)
		{
			return;
		}
		foreach (long buffId in new List<long>(this.BuffToHandlesMap.Keys))
		{
			this.RemoveBuffByBuffId(buffId);
		}
		this.BuffToHandlesMap.Clear();
	}

	// Token: 0x0400B4D0 RID: 46288
	[Nullable(2)]
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B4D1 RID: 46289
	[Nullable(2)]
	private UiModelEffectComponent EffectComponent;

	// Token: 0x0400B4D2 RID: 46290
	[Nullable(2)]
	private UiModelRenderingMaterialComponent RenderingMaterialComponent;

	// Token: 0x0400B4D3 RID: 46291
	protected readonly Dictionary<long, BuffHandle> BuffToHandlesMap = new Dictionary<long, BuffHandle>();

	// Token: 0x0400B4D4 RID: 46292
	protected readonly global::Vector CacheLocation = global::Vector.Create();

	// Token: 0x0400B4D5 RID: 46293
	protected readonly Rotator CacheRotator = Rotator.Create();

	// Token: 0x0400B4D6 RID: 46294
	protected readonly global::Vector CacheScale = global::Vector.Create();

	// Token: 0x0400B4D7 RID: 46295
	protected readonly Transform CacheTransform = Transform.Create();
}
