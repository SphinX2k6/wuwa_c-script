using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Render;
using UnrealEngine;

// Token: 0x020022ED RID: 8941
public class BulletActionInitRender : BulletActionBase
{
	// Token: 0x060160D7 RID: 90327 RVA: 0x00667B45 File Offset: 0x00665D45
	public BulletActionInitRender(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060160D8 RID: 90328 RVA: 0x00667B50 File Offset: 0x00665D50
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
					CameraController.Instance.PlayWorldCameraShake(new TSubclassOf<UCameraShakeBase>?(shakeType), new FVectorDouble?(value), 0f, 100f, 1f, false, "MainCamera");
				}, 100, "js_undefined");
			}
		}
	}

	// Token: 0x060160D9 RID: 90329 RVA: 0x00667C4C File Offset: 0x00665E4C
	public float GetSize()
	{
		if (this.BulletInfo.BulletDataMain.Base.Shape == EBulletShape.Cube)
		{
			return (float)Math.Max(this.BulletInfo.Size.X, this.BulletInfo.Size.Y);
		}
		return (float)this.BulletInfo.Size.X;
	}

	// Token: 0x060160DA RID: 90330 RVA: 0x00667CA8 File Offset: 0x00665EA8
	public override void Clear()
	{
		base.Clear();
		if (this.AirWallEffect != null)
		{
			SceneInteractionManager.Get().UnregisterAirWallEffectObject(this.AirWallEffect);
			this.AirWallEffect = null;
		}
	}

	// Token: 0x0400B948 RID: 47432
	[Nullable(2)]
	private SceneObjectAirWallEffect AirWallEffect;
}
