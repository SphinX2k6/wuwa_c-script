using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using UnrealEngine;

// Token: 0x02000224 RID: 548
[GeneratePropertyAccessMethod(true, true, null)]
public class CameraSpecialGameplayController : CameraControllerBase
{
	// Token: 0x06002200 RID: 8704 RVA: 0x000C723B File Offset: 0x000C543B
	[NullableContext(1)]
	public CameraSpecialGameplayController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000C7244 File Offset: 0x000C5444
	[NullableContext(1)]
	public override string Name()
	{
		return "SpecialGameplayController";
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000C724B File Offset: 0x000C544B
	protected override void OnInit()
	{
		base.Lock(this);
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000C7254 File Offset: 0x000C5454
	protected override void UpdateInternal(float deltaTime)
	{
		ISpecialGameplayCamera currentGameplay = this.CurrentGameplay;
		if (currentGameplay == null)
		{
			return;
		}
		currentGameplay.Update(deltaTime);
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000C7268 File Offset: 0x000C5468
	[NullableContext(2)]
	public void EnterSpecialGameplayController(int gameplayId, float blendInTime = 0f, EViewTargetBlendFunction blendFunction = EViewTargetBlendFunction.VTBlend_Linear, TsBaseCharacter character = null, PhotoCameraType? defaultPhotoMode = null, PhotoCameraLensState pendingPhotoLens = null)
	{
		if (this.CameraActor == null)
		{
			this.CameraActor = CameraController.Instance.SpawnCameraActor();
		}
		CameraController.Instance.SetViewTarget(this.CameraActor, "EnterSpecialGameplayController", blendInTime, blendFunction, 0f, new bool?(false), new bool?(false), this.Camera.CameraModel.CameraName, null, null);
		if (SpecialGameplayCamera.GameplayMap.ContainsKey(gameplayId))
		{
			this.CurrentGameplay = SpecialGameplayCamera.GameplayMap[gameplayId]();
			this.CurrentGameplayId = new int?(gameplayId);
			if (gameplayId == 4)
			{
				PhotoCamera photoCamera = (PhotoCamera)this.CurrentGameplay;
				if (character != null)
				{
					photoCamera.SetCharacter(character);
				}
				if (defaultPhotoMode != null)
				{
					photoCamera.SetDefaultMode(defaultPhotoMode.Value);
				}
				photoCamera.SetPendingLens(pendingPhotoLens);
			}
			this.CurrentGameplay.OnInit(this.CameraActor, base.CameraModel);
		}
		base.Unlock(this);
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000C7350 File Offset: 0x000C5550
	public void ExitSpecialGameplayController(float blendOutTime = 0f)
	{
		if (this.Camera.CameraActor.IsValid())
		{
			CameraController.Instance.SetViewTarget(this.Camera.CameraActor, "ExitSpecialGameplayController", blendOutTime, EViewTargetBlendFunction.VTBlend_Linear, 0f, new bool?(false), new bool?(false), this.Camera.CameraModel.CameraName, null, null);
		}
		if (this.CameraActor != null)
		{
			ActorSystem.Instance.Put("CameraSpecialGameplayController.ExitSpecialGameplayController", this.CameraActor, null);
			this.CameraActor = null;
		}
		ISpecialGameplayCamera currentGameplay = this.CurrentGameplay;
		if (currentGameplay != null)
		{
			currentGameplay.OnDestroy();
		}
		this.CurrentGameplay = null;
		this.CurrentGameplayId = null;
		base.Lock(this);
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000C7400 File Offset: 0x000C5600
	public bool CheckIsInSpecialGameplay(int gameplayId)
	{
		int? currentGameplayId = this.CurrentGameplayId;
		return currentGameplayId.GetValueOrDefault() == gameplayId & currentGameplayId != null;
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x000C7428 File Offset: 0x000C5628
	[NullableContext(1)]
	[return: Nullable(2)]
	public T GetCurrentGameplay<T>() where T : class, ISpecialGameplayCamera
	{
		return this.CurrentGameplay as T;
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000C743A File Offset: 0x000C563A
	[NullableContext(1)]
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x000C7444 File Offset: 0x000C5644
	public override bool TryGetMember(string key, out object value)
	{
		if (key == "CameraActor")
		{
			value = this.CameraActor;
			return true;
		}
		if (key == "CurrentGameplay")
		{
			value = this.CurrentGameplay;
			return true;
		}
		if (!(key == "CurrentGameplayId"))
		{
			return base.TryGetMember(key, out value);
		}
		value = this.CurrentGameplayId;
		return true;
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x000C74A8 File Offset: 0x000C56A8
	public override void SetMember(string key, object value)
	{
		if (key == "CameraActor")
		{
			this.CameraActor = (ACameraActor)value;
			return;
		}
		if (key == "CurrentGameplay")
		{
			this.CurrentGameplay = (ISpecialGameplayCamera)value;
			return;
		}
		if (!(key == "CurrentGameplayId"))
		{
			base.SetMember(key, value);
			return;
		}
		this.CurrentGameplayId = (int?)value;
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x000C750D File Offset: 0x000C570D
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraSpecialGameplayController.<MemberIter>d__14 <MemberIter>d__ = new CameraSpecialGameplayController.<MemberIter>d__14(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x04001637 RID: 5687
	[Nullable(2)]
	public ACameraActor CameraActor;

	// Token: 0x04001638 RID: 5688
	[Nullable(2)]
	private ISpecialGameplayCamera CurrentGameplay;

	// Token: 0x04001639 RID: 5689
	private int? CurrentGameplayId;
}
