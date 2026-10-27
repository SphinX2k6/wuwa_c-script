using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using UnrealEngine;

// Token: 0x02000220 RID: 544
[GeneratePropertyAccessMethod(true)]
public class CameraSpecialGameplayController : CameraControllerBase
{
	// Token: 0x06002152 RID: 8530 RVA: 0x000BFF1B File Offset: 0x000BE11B
	[NullableContext(1)]
	public CameraSpecialGameplayController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x06002153 RID: 8531 RVA: 0x000BFF24 File Offset: 0x000BE124
	[NullableContext(1)]
	public override string Name()
	{
		return "SpecialGameplayController";
	}

	// Token: 0x06002154 RID: 8532 RVA: 0x000BFF2B File Offset: 0x000BE12B
	protected override void OnInit()
	{
		base.Lock(this);
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x000BFF34 File Offset: 0x000BE134
	protected override void UpdateInternal(float deltaTime)
	{
		ISpecialGameplayCamera currentGameplay = this.CurrentGameplay;
		if (currentGameplay == null)
		{
			return;
		}
		currentGameplay.Update(deltaTime);
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x000BFF48 File Offset: 0x000BE148
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

	// Token: 0x06002157 RID: 8535 RVA: 0x000C0030 File Offset: 0x000BE230
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

	// Token: 0x06002158 RID: 8536 RVA: 0x000C00E0 File Offset: 0x000BE2E0
	public bool CheckIsInSpecialGameplay(int gameplayId)
	{
		int? currentGameplayId = this.CurrentGameplayId;
		return currentGameplayId.GetValueOrDefault() == gameplayId & currentGameplayId != null;
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x000C0108 File Offset: 0x000BE308
	[NullableContext(1)]
	[return: Nullable(2)]
	public T GetCurrentGameplay<T>() where T : class, ISpecialGameplayCamera
	{
		return this.CurrentGameplay as T;
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x000C011A File Offset: 0x000BE31A
	[NullableContext(1)]
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x000C0124 File Offset: 0x000BE324
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

	// Token: 0x0600215C RID: 8540 RVA: 0x000C0188 File Offset: 0x000BE388
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

	// Token: 0x0600215D RID: 8541 RVA: 0x000C01ED File Offset: 0x000BE3ED
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraSpecialGameplayController.<MemberIter>d__14 <MemberIter>d__ = new CameraSpecialGameplayController.<MemberIter>d__14(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040015F5 RID: 5621
	[Nullable(2)]
	public ACameraActor CameraActor;

	// Token: 0x040015F6 RID: 5622
	[Nullable(2)]
	private ISpecialGameplayCamera CurrentGameplay;

	// Token: 0x040015F7 RID: 5623
	private int? CurrentGameplayId;
}
