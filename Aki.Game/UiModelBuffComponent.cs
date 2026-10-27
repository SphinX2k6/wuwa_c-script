using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002C84 RID: 11396
[NullableContext(1)]
[Nullable(0)]
public class UiModelBuffComponent : UiModelComponentBase
{
	// Token: 0x06017CD8 RID: 97496 RVA: 0x0060DBBA File Offset: 0x0060BDBA
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.EffectComponent = base.Owner.CheckGetComponent<UiModelEffectComponent>();
		this.RenderingMaterialComponent = base.Owner.CheckGetComponent<UiModelRenderingMaterialComponent>();
	}

	// Token: 0x06017CD9 RID: 97497 RVA: 0x0060DBEF File Offset: 0x0060BDEF
	protected override void OnEnd()
	{
		this.RemoveAllBuffId();
	}

	// Token: 0x06017CDA RID: 97498 RVA: 0x0060DBF8 File Offset: 0x0060BDF8
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

	// Token: 0x06017CDB RID: 97499 RVA: 0x0060DC90 File Offset: 0x0060BE90
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

	// Token: 0x06017CDC RID: 97500 RVA: 0x0060DCE4 File Offset: 0x0060BEE4
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

	// Token: 0x06017CDD RID: 97501 RVA: 0x0060DD1C File Offset: 0x0060BF1C
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

	// Token: 0x06017CDE RID: 97502 RVA: 0x0060DF34 File Offset: 0x0060C134
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

	// Token: 0x06017CDF RID: 97503 RVA: 0x0060DF88 File Offset: 0x0060C188
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

	// Token: 0x06017CE0 RID: 97504 RVA: 0x0060E064 File Offset: 0x0060C264
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

	// Token: 0x0400B165 RID: 45413
	[Nullable(2)]
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B166 RID: 45414
	[Nullable(2)]
	private UiModelEffectComponent EffectComponent;

	// Token: 0x0400B167 RID: 45415
	[Nullable(2)]
	private UiModelRenderingMaterialComponent RenderingMaterialComponent;

	// Token: 0x0400B168 RID: 45416
	protected readonly Dictionary<long, BuffHandle> BuffToHandlesMap = new Dictionary<long, BuffHandle>();

	// Token: 0x0400B169 RID: 45417
	protected readonly global::Vector CacheLocation = global::Vector.Create();

	// Token: 0x0400B16A RID: 45418
	protected readonly Rotator CacheRotator = Rotator.Create();

	// Token: 0x0400B16B RID: 45419
	protected readonly global::Vector CacheScale = global::Vector.Create();

	// Token: 0x0400B16C RID: 45420
	protected readonly Transform CacheTransform = Transform.Create();
}
