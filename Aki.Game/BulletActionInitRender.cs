using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Render;
using UnrealEngine;

// Token: 0x02002D93 RID: 11667
public class BulletActionInitRender : BulletActionBase
{
	// Token: 0x06018833 RID: 100403 RVA: 0x00641D89 File Offset: 0x0063FF89
	public BulletActionInitRender(EBulletAction type) : base(type)
	{
	}

	// Token: 0x06018834 RID: 100404 RVA: 0x00641D94 File Offset: 0x0063FF94
	protected override void OnExecute()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		if (bulletDataMain.Logic.InteractWithAirWall)
		{
			this.AirWallEffect = new SceneObjectAirWallEffect();
			this.AirWallEffect.Start(this.BulletInfo.CollisionInfo.CollisionComponent);
			SceneInteractionManager.Get().RegisterAirWallEffectObject(this.AirWallEffect);
		}
		FName attackerCameraShakeOnStart = bulletDataMain.Render.AttackerCameraShakeOnStart;
		if (attackerCameraShakeOnStart != FName.NAME_None)
		{
			EntityHandle attackerHandle = this.BulletInfo.AttackerHandle;
			if (attackerHandle != null && attackerHandle.Valid && CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(this.BulletInfo.AttackerHandle) && this.BulletInfo.IsAutonomousProxy && BulletUtil.IsPlayerOrSummons(this.BulletInfo))
			{
				ResourceSystem.Instance.LoadAsync<UClass>(attackerCameraShakeOnStart.ToString(), delegate([Nullable(2)] UClass shakeType, string _)
				{
					FVectorDouble value = Global.CharacterCameraManager.D_GetCameraLocation();
					CameraController.Instance.PlayWorldCameraShake(shakeType, new FVectorDouble?(value), 0f, 100f, 1f, false, "MainCamera");
				}, 100, "js_undefined");
			}
		}
	}

	// Token: 0x06018835 RID: 100405 RVA: 0x00641E90 File Offset: 0x00640090
	public float GetSize()
	{
		if (this.BulletInfo.BulletDataMain.Base.Shape == EBulletShape.Cube)
		{
			return (float)Math.Max(this.BulletInfo.Size.X, this.BulletInfo.Size.Y);
		}
		return (float)this.BulletInfo.Size.X;
	}

	// Token: 0x06018836 RID: 100406 RVA: 0x00641EEC File Offset: 0x006400EC
	public override void Clear()
	{
		base.Clear();
		if (this.AirWallEffect != null)
		{
			SceneInteractionManager.Get().UnregisterAirWallEffectObject(this.AirWallEffect);
			this.AirWallEffect = null;
		}
	}

	// Token: 0x0400B5D2 RID: 46546
	[Nullable(2)]
	private SceneObjectAirWallEffect AirWallEffect;
}
