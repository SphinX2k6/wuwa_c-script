using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B31 RID: 15153
	[NullableContext(1)]
	[Nullable(0)]
	public class Tetromino
	{
		// Token: 0x17004FF0 RID: 20464
		// (get) Token: 0x06026F47 RID: 159559 RVA: 0x00AE700C File Offset: 0x00AE520C
		public Dictionary<string, Mino> MinoDataMap { get; } = new Dictionary<string, Mino>();

		// Token: 0x17004FF1 RID: 20465
		// (get) Token: 0x06026F48 RID: 159560 RVA: 0x00AE7014 File Offset: 0x00AE5214
		public Transform OriginTransform
		{
			get
			{
				return SlidingBlocksModel.Instance.GameData.OriginTransform;
			}
		}

		// Token: 0x17004FF2 RID: 20466
		// (get) Token: 0x06026F49 RID: 159561 RVA: 0x00AE7025 File Offset: 0x00AE5225
		// (set) Token: 0x06026F4A RID: 159562 RVA: 0x00AE702D File Offset: 0x00AE522D
		public float RemainAimTime { get; private set; }

		// Token: 0x17004FF3 RID: 20467
		// (get) Token: 0x06026F4B RID: 159563 RVA: 0x00AE7036 File Offset: 0x00AE5236
		// (set) Token: 0x06026F4C RID: 159564 RVA: 0x00AE703E File Offset: 0x00AE523E
		public SlidingBlocksDefine.ETetrominoRotateState RotateState { get; private set; }

		// Token: 0x17004FF4 RID: 20468
		// (get) Token: 0x06026F4D RID: 159565 RVA: 0x00AE7047 File Offset: 0x00AE5247
		// (set) Token: 0x06026F4E RID: 159566 RVA: 0x00AE704F File Offset: 0x00AE524F
		[Nullable(2)]
		public Mino GeometricCenterMino { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x06026F4F RID: 159567 RVA: 0x00AE7058 File Offset: 0x00AE5258
		public Tetromino(SlidingBlocksDefine.ETetrominoType tetrominoType, SlidingBlocksDefine.ETetrominoBorad boardType, SlidingBlocksDefine.ETetrominoRotateState initRotateState, float initFallSpeed, float fallAcceleration, ETetrominoState initState, float prepareTime)
		{
			this.TetrominoType = tetrominoType;
			this.BoardType = boardType;
			this.InitRotateState = initRotateState;
			this.InitFallSpeed = initFallSpeed;
			this.FallAcceleration = fallAcceleration;
			this.InitState = initState;
			this.RemainAimTime = prepareTime * (float)TimeUtil.Instance.InverseMillisecond;
			this.CurFallSpeed = (double)this.InitFallSpeed;
		}

		// Token: 0x06026F50 RID: 159568 RVA: 0x00AE7114 File Offset: 0x00AE5314
		public void Clear()
		{
			foreach (Mino mino in this.MinoDataMap.Values)
			{
				SlidingBlocksUtil.DestroyCube(mino.CubeActor);
			}
			this.MinoDataMap.Clear();
			this.GeometricCenterMino = null;
		}

		// Token: 0x06026F51 RID: 159569 RVA: 0x00AE7184 File Offset: 0x00AE5384
		public void Init(ITetrisBoard boardConfig, double geometricMinoX, double? geometricMinoY = null)
		{
			this.InitAnchorLocalCoordinate();
			this.InitGeometricConfigCoord();
			this.InitAnchorCoordinate(geometricMinoX, geometricMinoY);
			SlidingBlocksUtil.FillMinoMapByGridConfig(boardConfig.Grids, boardConfig.BoardSize.X, new Action<string, double, double>(this.AddMino));
			while (this.RotateState != this.InitRotateState)
			{
				this.Rotate(false);
			}
			this.KickWall(null, null);
			this.CreateAndPlaySpawnEffect().Forget();
			foreach (KeyValuePair<string, Mino> keyValuePair in this.MinoDataMap)
			{
				keyValuePair.Value.CubeActor.SetActorHiddenInGame(false);
			}
			this.State = this.InitState;
		}

		// Token: 0x06026F52 RID: 159570 RVA: 0x00AE7260 File Offset: 0x00AE5460
		private void InitAnchorLocalCoordinate()
		{
			switch (this.BoardType)
			{
			case SlidingBlocksDefine.ETetrominoBorad.二乘二:
				this.AnchorLocalCoord.Set(1.0, 1.0);
				return;
			case SlidingBlocksDefine.ETetrominoBorad.三乘三:
				this.AnchorLocalCoord.Set(1.5, 1.5);
				return;
			case SlidingBlocksDefine.ETetrominoBorad.四乘四:
				this.AnchorLocalCoord.Set(2.0, 2.0);
				return;
			case SlidingBlocksDefine.ETetrominoBorad.五乘五:
				this.AnchorLocalCoord.Set(2.5, 2.5);
				return;
			default:
				return;
			}
		}

		// Token: 0x06026F53 RID: 159571 RVA: 0x00AE7304 File Offset: 0x00AE5504
		private void InitGeometricConfigCoord()
		{
			switch (this.BoardType)
			{
			case SlidingBlocksDefine.ETetrominoBorad.二乘二:
				this.GeometricConfigCoord.Set(0.0, 1.0);
				break;
			case SlidingBlocksDefine.ETetrominoBorad.三乘三:
				this.GeometricConfigCoord.Set(1.0, 1.0);
				break;
			case SlidingBlocksDefine.ETetrominoBorad.四乘四:
				this.GeometricConfigCoord.Set(1.0, 1.0);
				break;
			case SlidingBlocksDefine.ETetrominoBorad.五乘五:
				this.GeometricConfigCoord.Set(2.0, 2.0);
				break;
			}
			if (this.TetrominoType == SlidingBlocksDefine.ETetrominoType.五连V块)
			{
				this.GeometricConfigCoord.Set(0.0, 2.0);
			}
			this.GeometricConfigCoord.X = SlidingBlocksUtil.ConvertConfigCoordToSmooth(this.GeometricConfigCoord.X);
			this.GeometricConfigCoord.Y = SlidingBlocksUtil.ConvertConfigCoordToSmooth(this.GeometricConfigCoord.Y);
		}

		// Token: 0x06026F54 RID: 159572 RVA: 0x00AE740C File Offset: 0x00AE560C
		private void InitAnchorCoordinate(double geometricMinoX, double? geometricMinoY = null)
		{
			switch (this.BoardType)
			{
			case SlidingBlocksDefine.ETetrominoBorad.二乘二:
				this.AnchorCoord.Set(Math.Ceiling(geometricMinoX), (geometricMinoY != null) ? Math.Ceiling(geometricMinoY.Value) : -1.0);
				return;
			case SlidingBlocksDefine.ETetrominoBorad.三乘三:
				this.AnchorCoord.Set(geometricMinoX, geometricMinoY.GetValueOrDefault(-0.5));
				return;
			case SlidingBlocksDefine.ETetrominoBorad.四乘四:
				this.AnchorCoord.Set(Math.Ceiling(geometricMinoX), (geometricMinoY != null) ? Math.Ceiling(geometricMinoY.Value) : 0.0);
				return;
			case SlidingBlocksDefine.ETetrominoBorad.五乘五:
				this.AnchorCoord.Set(geometricMinoX, geometricMinoY.GetValueOrDefault(-0.5));
				return;
			default:
				return;
			}
		}

		// Token: 0x06026F55 RID: 159573 RVA: 0x00AE74D8 File Offset: 0x00AE56D8
		private UniTask CreateAndPlaySpawnEffect()
		{
			Tetromino.<CreateAndPlaySpawnEffect>d__41 <CreateAndPlaySpawnEffect>d__;
			<CreateAndPlaySpawnEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAndPlaySpawnEffect>d__.<>4__this = this;
			<CreateAndPlaySpawnEffect>d__.<>1__state = -1;
			<CreateAndPlaySpawnEffect>d__.<>t__builder.Start<Tetromino.<CreateAndPlaySpawnEffect>d__41>(ref <CreateAndPlaySpawnEffect>d__);
			return <CreateAndPlaySpawnEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06026F56 RID: 159574 RVA: 0x00AE751C File Offset: 0x00AE571C
		private void CreateTrailEffect()
		{
			string moveTrailEffectPath = SlidingBlocksGlobal.GetMoveTrailEffectPath(SlidingBlocksModel.Instance.GameData.PlayMode);
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.OriginTransform.ToUeTransform());
			this.MoveTrailEffectHandle = instance.SpawnEffect(world, ftransformDouble, moveTrailEffectPath, "Tetromino.Init", null, EEffectType.Scene, null, null, null, false, false);
			EffectSystem.Instance.RegisterCustomCheckOwnerFunc(this.MoveTrailEffectHandle, (int _) => this.State >= ETetrominoState.PlayLockEffect);
		}

		// Token: 0x06026F57 RID: 159575 RVA: 0x00AE7590 File Offset: 0x00AE5790
		private unsafe void AddMino(string styleName, double x, double y)
		{
			double num = x - this.AnchorLocalCoord.X;
			double num2 = y - this.AnchorLocalCoord.Y;
			SlidingBlocksModel instance = SlidingBlocksModel.Instance;
			this.GetMinoCoordInGrid(num, num2, this.CacheVector2D, null, null);
			AActor aactor = SlidingBlocksUtil.CreateDynamicCube(styleName, this.CacheVector2D.X, this.CacheVector2D.Y, this.OriginTransform, instance.BoxMeshCache);
			if (aactor == null || !aactor.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SlidingBlocks;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "Tetromino.AddMino：创建cubeActor失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("styleName", styleName);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item = "coord";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 2);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted<double>(num);
				defaultInterpolatedStringHandler.AppendLiteral(",");
				defaultInterpolatedStringHandler.AppendFormatted<double>(num2);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
				instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			aactor.SetActorHiddenInGame(true);
			Mino mino = new Mino(styleName, Vector2D.Create(num, num2), aactor, SlidingBlocksDefine.EMinoParent.Tetromino);
			this.MinoDataMap.Add(SlidingBlocksUtil.GetCoordKey(num, num2), mino);
			if (this.GeometricConfigCoord.X == x && this.GeometricConfigCoord.Y == y)
			{
				this.GeometricCenterMino = mino;
			}
		}

		// Token: 0x06026F58 RID: 159576 RVA: 0x00AE7708 File Offset: 0x00AE5908
		public void OnTick(float delta, SlidingBlocksGameData gameData)
		{
			this.UpdateByState(delta, gameData);
		}

		// Token: 0x06026F59 RID: 159577 RVA: 0x00AE7714 File Offset: 0x00AE5914
		private void UpdateByState(float delta, SlidingBlocksGameData gameData)
		{
			switch (this.State)
			{
			case ETetrominoState.Init:
			case ETetrominoState.WaitFallingEvent:
			case ETetrominoState.Lock:
				break;
			case ETetrominoState.Aiming:
				this.UpdateAiming(delta, gameData);
				return;
			case ETetrominoState.InitFallData:
				gameData.Score += Math.Floor((double)this.RemainAimTime * TimeUtil.Instance.Millisecond);
				this.InitFallData(this.AnchorCoord.Y + 1.0);
				SlidingBlocksController.OpenAudio(gameData.AudioData.TetrominoStartFallAudio);
				return;
			case ETetrominoState.Falling:
				this.UpdateFalling(delta, gameData);
				return;
			case ETetrominoState.PlayLockEffect:
				this.OnFallingFinished(gameData).Forget();
				break;
			default:
				return;
			}
		}

		// Token: 0x06026F5A RID: 159578 RVA: 0x00AE77BB File Offset: 0x00AE59BB
		private void UpdateAiming(float delta, SlidingBlocksGameData gameData)
		{
			this.UpdateCoordByPlayer(gameData);
			if (gameData.IsProcessLineClear)
			{
				return;
			}
			this.RemainAimTime -= delta;
			if (this.RemainAimTime > 0f)
			{
				return;
			}
			this.RemainAimTime = 0f;
			this.SetState(ETetrominoState.InitFallData);
		}

		// Token: 0x06026F5B RID: 159579 RVA: 0x00AE77FC File Offset: 0x00AE59FC
		private void UpdateCoordByPlayer(SlidingBlocksGameData gameData)
		{
			double num = SlidingBlocksUtil.StandardSmoothCoordToCellCenter(gameData.PlayerCoord.X);
			Mino geometricCenterMino = this.GeometricCenterMino;
			Vector2D vector2D = (geometricCenterMino != null) ? geometricCenterMino.Coord : null;
			if (vector2D != null)
			{
				this.GetMinoCoordInGrid(vector2D.X, vector2D.Y, this.CacheVector2D, null, null);
			}
			double num2 = num - this.CacheVector2D.X;
			double value = this.AnchorCoord.X + num2;
			this.CalculateKickWallMoveOffset(this.CacheVector2D, new double?(value), new double?(this.AnchorCoord.Y));
			if (this.MoveByStep(num2 + this.CacheVector2D.X, this.CacheVector2D.Y))
			{
				SlidingBlocksController.OpenAudio(gameData.AudioData.RotateAudio);
			}
		}

		// Token: 0x06026F5C RID: 159580 RVA: 0x00AE78C7 File Offset: 0x00AE5AC7
		public void SkipAimingStage()
		{
			this.SetState(ETetrominoState.InitFallData);
		}

		// Token: 0x06026F5D RID: 159581 RVA: 0x00AE78D0 File Offset: 0x00AE5AD0
		private bool InitFallData(double nextStep)
		{
			if (this.CheckCanMove(this.AnchorCoord.X, nextStep) != SlidingBlocksDefine.ECheckCanMoveResult.None)
			{
				this.SetState(ETetrominoState.PlayLockEffect);
				return false;
			}
			this.AnchorFallingTargetCoordY = nextStep;
			this.SetState(ETetrominoState.Falling);
			return true;
		}

		// Token: 0x06026F5E RID: 159582 RVA: 0x00AE7900 File Offset: 0x00AE5B00
		private void UpdateFalling(float delta, SlidingBlocksGameData gameData)
		{
			double num = MathCommon.Clamp(this.UpdateFallSpeed(delta) * (double)delta * TimeUtil.Instance.Millisecond, 0.0, 1.0);
			double num2 = this.AnchorCoord.Y + num;
			if (num2 < this.AnchorFallingTargetCoordY)
			{
				if (this.CheckSqueezePlayer(gameData.PlayerCoord, this.AnchorCoord.X, this.AnchorFallingTargetCoordY))
				{
					EventSystem.Instance.Emit(EEventName.SlidingBlockSqueezePlayer);
				}
				this.AnchorCoord.Y = num2;
			}
			else
			{
				double anchorFallingTargetCoordY = this.AnchorFallingTargetCoordY;
				this.AnchorCoord.Y = ((!this.InitFallData(this.AnchorFallingTargetCoordY + 1.0)) ? anchorFallingTargetCoordY : num2);
			}
			this.UpdateTetrominoWorldLocation();
			this.UpdateTrailEffectPosition();
			if (this.State == ETetrominoState.PlayLockEffect)
			{
				this.UpdateByState(delta, gameData);
			}
		}

		// Token: 0x06026F5F RID: 159583 RVA: 0x00AE79DC File Offset: 0x00AE5BDC
		private void UpdateTrailEffectPosition()
		{
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.MoveTrailEffectHandle);
			if (!effectActor.IsValid())
			{
				return;
			}
			SlidingBlocksUtil.GetWorldLocationByCoord(this.AnchorCoord.X, this.AnchorCoord.Y, this.OriginTransform, this.CacheVector);
			OneOf<KuroEffectActorHandle, AActor> self = effectActor;
			FVectorDouble fvectorDouble = this.CacheVector.ToUeVector(false);
			self.D_K2_SetActorLocation(fvectorDouble, false, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06026F60 RID: 159584 RVA: 0x00AE7A48 File Offset: 0x00AE5C48
		private double UpdateFallSpeed(float delta)
		{
			if (this.FallAcceleration == 0f)
			{
				return (double)this.InitFallSpeed;
			}
			this.CurFallSpeed += (double)(delta * this.FallAcceleration) * TimeUtil.Instance.Millisecond;
			return this.CurFallSpeed;
		}

		// Token: 0x06026F61 RID: 159585 RVA: 0x00AE7A88 File Offset: 0x00AE5C88
		private UniTask OnFallingFinished(SlidingBlocksGameData gameData)
		{
			Tetromino.<OnFallingFinished>d__53 <OnFallingFinished>d__;
			<OnFallingFinished>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnFallingFinished>d__.<>4__this = this;
			<OnFallingFinished>d__.gameData = gameData;
			<OnFallingFinished>d__.<>1__state = -1;
			<OnFallingFinished>d__.<>t__builder.Start<Tetromino.<OnFallingFinished>d__53>(ref <OnFallingFinished>d__);
			return <OnFallingFinished>d__.<>t__builder.Task;
		}

		// Token: 0x06026F62 RID: 159586 RVA: 0x00AE7AD4 File Offset: 0x00AE5CD4
		private static UniTask CheckAndSpawnLockEffect(SlidingBlocksGameData gameData, double x, double y)
		{
			Tetromino.<CheckAndSpawnLockEffect>d__54 <CheckAndSpawnLockEffect>d__;
			<CheckAndSpawnLockEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckAndSpawnLockEffect>d__.gameData = gameData;
			<CheckAndSpawnLockEffect>d__.x = x;
			<CheckAndSpawnLockEffect>d__.y = y;
			<CheckAndSpawnLockEffect>d__.<>1__state = -1;
			<CheckAndSpawnLockEffect>d__.<>t__builder.Start<Tetromino.<CheckAndSpawnLockEffect>d__54>(ref <CheckAndSpawnLockEffect>d__);
			return <CheckAndSpawnLockEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06026F63 RID: 159587 RVA: 0x00AE7B27 File Offset: 0x00AE5D27
		private bool MoveByStep(double x, double y)
		{
			if (!this.CheckCanMoveByMoveStep(x, y))
			{
				return false;
			}
			this.AnchorCoord.X += x;
			this.AnchorCoord.Y += y;
			this.UpdateTetrominoWorldLocation();
			return true;
		}

		// Token: 0x06026F64 RID: 159588 RVA: 0x00AE7B62 File Offset: 0x00AE5D62
		private bool CheckCanMoveByMoveStep(double x, double y)
		{
			return (x != 0.0 || y != 0.0) && this.CheckCanMove(this.AnchorCoord.X + x, this.AnchorCoord.Y + y) == SlidingBlocksDefine.ECheckCanMoveResult.None;
		}

		// Token: 0x06026F65 RID: 159589 RVA: 0x00AE7BA4 File Offset: 0x00AE5DA4
		private SlidingBlocksDefine.ECheckCanMoveResult CheckCanMove(double anchorCoordX, double anchorCoordY)
		{
			SlidingBlocksModel instance = SlidingBlocksModel.Instance;
			foreach (Mino mino in this.MinoDataMap.Values)
			{
				this.GetMinoCoordInGrid(mino.Coord.X, mino.Coord.Y, this.TempMinoCoord, new double?(anchorCoordX), new double?(anchorCoordY));
				if (instance.CheckBeyondGrid(this.TempMinoCoord.X, this.TempMinoCoord.Y))
				{
					return SlidingBlocksDefine.ECheckCanMoveResult.BeyondGrid;
				}
				if (instance.CheckGridOccupied(this.TempMinoCoord.X, this.TempMinoCoord.Y))
				{
					return SlidingBlocksDefine.ECheckCanMoveResult.Occupation;
				}
			}
			return SlidingBlocksDefine.ECheckCanMoveResult.None;
		}

		// Token: 0x06026F66 RID: 159590 RVA: 0x00AE7C74 File Offset: 0x00AE5E74
		private void UpdateTetrominoWorldLocation()
		{
			foreach (Mino mino in this.MinoDataMap.Values)
			{
				this.GetMinoCoordInGrid(mino.Coord.X, mino.Coord.Y, this.TempMinoCoord, null, null);
				this.UpdateMinoWorldLocation(mino, this.TempMinoCoord.X, this.TempMinoCoord.Y);
			}
		}

		// Token: 0x06026F67 RID: 159591 RVA: 0x00AE7D18 File Offset: 0x00AE5F18
		private bool CheckSqueezePlayer(Vector2D playerCoord, double nextStepAnchorCoordX, double nextStepAnchorCoordY)
		{
			Mino nextStepOverlapPlayerMino = this.GetNextStepOverlapPlayerMino(playerCoord, nextStepAnchorCoordX, nextStepAnchorCoordY);
			if (SlidingBlocksModel.Instance.CheckGridOccupiedUnderPlayer())
			{
				return nextStepOverlapPlayerMino != null;
			}
			if (nextStepOverlapPlayerMino == null)
			{
				return false;
			}
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			object obj;
			if (getCurrentEntity == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				obj = ((entity != null) ? entity.GetComponent(typeof(CharacterClimbComponent)) : null);
			}
			CharacterClimbComponent characterClimbComponent = obj as CharacterClimbComponent;
			if (characterClimbComponent == null)
			{
				return false;
			}
			CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbState tsClimbState = characterClimbComponent.GetTsClimbState();
			EClimbState eclimbState = (tsClimbState != null) ? tsClimbState.攀爬状态 : EClimbState.无;
			if (eclimbState != EClimbState.攀爬中 && eclimbState != EClimbState.进入攀爬)
			{
				return false;
			}
			characterClimbComponent.ClimbPress(false);
			return false;
		}

		// Token: 0x06026F68 RID: 159592 RVA: 0x00AE7DA4 File Offset: 0x00AE5FA4
		[return: Nullable(2)]
		private Mino GetNextStepOverlapPlayerMino(Vector2D playerCoord, double nextStepAnchorCoordX, double nextStepAnchorCoordY)
		{
			foreach (Mino mino in this.MinoDataMap.Values)
			{
				this.GetMinoCoordInGrid(mino.Coord.X, mino.Coord.Y, this.TempMinoCoord, new double?(nextStepAnchorCoordX), new double?(nextStepAnchorCoordY));
				this.TempMinoCoord.Set(this.TempMinoCoord.X, this.TempMinoCoord.Y);
				if (playerCoord.Equals(this.TempMinoCoord, 9.999999747378752E-05))
				{
					return mino;
				}
			}
			return null;
		}

		// Token: 0x06026F69 RID: 159593 RVA: 0x00AE7E64 File Offset: 0x00AE6064
		public bool Rotate(bool bKickWall = true)
		{
			bool flag = this.CheckCanRotate();
			if (flag)
			{
				this.TempMinoDataMap.Clear();
				foreach (Mino mino in this.MinoDataMap.Values)
				{
					this.GetMinoAfterRotateOffset(mino, this.TempMinoCoord);
					mino.Coord.Set(this.TempMinoCoord.X, this.TempMinoCoord.Y);
					string coordKey = SlidingBlocksUtil.GetCoordKey(this.TempMinoCoord.X, this.TempMinoCoord.Y);
					this.TempMinoDataMap[coordKey] = mino;
				}
				this.MinoDataMap.Clear();
				foreach (KeyValuePair<string, Mino> keyValuePair in this.TempMinoDataMap)
				{
					string text;
					Mino mino2;
					keyValuePair.Deconstruct(out text, out mino2);
					string key = text;
					Mino mino3 = mino2;
					this.MinoDataMap.Add(key, mino3);
					this.GetMinoCoordInGrid(mino3.Coord.X, mino3.Coord.Y, this.TempMinoCoord, null, null);
				}
				if (bKickWall)
				{
					this.KickWall(null, null);
				}
				this.UpdateTetrominoWorldLocation();
			}
			this.RotateState = (this.RotateState + 1) % (SlidingBlocksDefine.ETetrominoRotateState)4;
			return flag;
		}

		// Token: 0x06026F6A RID: 159594 RVA: 0x00AE7FFC File Offset: 0x00AE61FC
		private bool CheckCanRotate()
		{
			return this.TetrominoType != SlidingBlocksDefine.ETetrominoType.O块;
		}

		// Token: 0x06026F6B RID: 159595 RVA: 0x00AE800C File Offset: 0x00AE620C
		public void GetMinoAfterRotateOffset(Mino minoData, Vector2D @out)
		{
			if (this.TetrominoType == SlidingBlocksDefine.ETetrominoType.I块)
			{
				this.GetOffsetBeforeRotateForI(this.CacheVector2D);
				double localCoordX = minoData.Coord.X - this.CacheVector2D.X;
				double localCoordY = minoData.Coord.Y - this.CacheVector2D.Y;
				Tetromino.RotateWithLocalCoord(localCoordX, localCoordY, @out, true);
				Tetromino.RotateWithLocalCoord(this.CacheVector2D.X, this.CacheVector2D.Y, this.CacheVector2D, true);
				@out.AdditionEqual(this.CacheVector2D);
				return;
			}
			Tetromino.RotateWithLocalCoord(minoData.Coord.X, minoData.Coord.Y, @out, true);
		}

		// Token: 0x06026F6C RID: 159596 RVA: 0x00AE80B4 File Offset: 0x00AE62B4
		private void GetOffsetBeforeRotateForI(Vector2D outVec)
		{
			switch (this.RotateState)
			{
			case SlidingBlocksDefine.ETetrominoRotateState.角度0:
				outVec.Set(0.0, 0.5);
				return;
			case SlidingBlocksDefine.ETetrominoRotateState.角度90:
				outVec.Set(-0.5, 0.0);
				return;
			case SlidingBlocksDefine.ETetrominoRotateState.角度180:
				outVec.Set(0.0, -0.5);
				return;
			case SlidingBlocksDefine.ETetrominoRotateState.角度270:
				outVec.Set(0.5, 0.0);
				return;
			default:
				return;
			}
		}

		// Token: 0x06026F6D RID: 159597 RVA: 0x00AE8142 File Offset: 0x00AE6342
		private static void RotateWithLocalCoord(double localCoordX, double localCoordY, Vector2D outVec, bool bClockwise = true)
		{
			if (bClockwise)
			{
				outVec.Set(-localCoordY, localCoordX);
				return;
			}
			outVec.Set(localCoordY, -localCoordX);
		}

		// Token: 0x06026F6E RID: 159598 RVA: 0x00AE815C File Offset: 0x00AE635C
		private void CalculateKickWallMoveOffset(Vector2D @out, double? anchorCoordX = null, double? anchorCoordY = null)
		{
			Bp_Tetris_C setting = SlidingBlocksGlobal.Setting;
			SlidingBlocksGameData gameData = SlidingBlocksModel.Instance.GameData;
			double gridMinX = gameData.GridMinX;
			double gridMaxX = gameData.GridMaxX;
			double num = gameData.GridMinY;
			double num2 = (double)setting.PrepareAreaMaxY - 0.5;
			bool flag = gameData.PlayMode == ETetrisPlayMode.MainLine;
			if (flag)
			{
				num = 0.5;
				num2 = gameData.GridSize.Y - 0.5;
			}
			double num3 = 0.0;
			double num4 = 0.0;
			foreach (KeyValuePair<string, Mino> keyValuePair in this.MinoDataMap)
			{
				string text;
				Mino mino;
				keyValuePair.Deconstruct(out text, out mino);
				Mino mino2 = mino;
				this.GetMinoCoordInGrid(mino2.Coord.X, mino2.Coord.Y, this.TempMinoCoord, anchorCoordX, anchorCoordY);
				double num5 = 0.0;
				if (this.TempMinoCoord.X < gridMinX)
				{
					num5 = gridMinX - this.TempMinoCoord.X;
				}
				else if (this.TempMinoCoord.X > gridMaxX)
				{
					num5 = gridMaxX - this.TempMinoCoord.X;
				}
				if (Math.Abs(num5) > Math.Abs(num3))
				{
					num3 = num5;
				}
				double num6 = 0.0;
				if (this.TempMinoCoord.Y < num)
				{
					num6 = num - this.TempMinoCoord.Y;
				}
				else if (this.TempMinoCoord.Y > num2)
				{
					num6 = num2 - this.TempMinoCoord.Y;
				}
				if (Math.Abs(num6) > Math.Abs(num4))
				{
					num4 = num6;
				}
			}
			@out.Set(num3, num4);
			if (!flag)
			{
				double num7 = this.AttachBottom(anchorCoordX, anchorCoordY);
				@out.Y += num7;
			}
		}

		// Token: 0x06026F6F RID: 159599 RVA: 0x00AE8354 File Offset: 0x00AE6554
		private double AttachBottom(double? anchorCoordX, double? anchorCoordY)
		{
			Bp_Tetris_C setting = SlidingBlocksGlobal.Setting;
			double num = (double)setting.PrepareAreaMinY + 0.5;
			foreach (KeyValuePair<string, Mino> keyValuePair in this.MinoDataMap)
			{
				string text;
				Mino mino;
				keyValuePair.Deconstruct(out text, out mino);
				Mino mino2 = mino;
				this.GetMinoCoordInGrid(mino2.Coord.X, mino2.Coord.Y, this.TempMinoCoord, anchorCoordX, anchorCoordY);
				if (this.TempMinoCoord.Y > num)
				{
					num = this.TempMinoCoord.Y;
				}
			}
			double num2 = (double)setting.PrepareAreaMaxY - 0.5;
			if (num >= num2)
			{
				return 0.0;
			}
			return num2 - num;
		}

		// Token: 0x06026F70 RID: 159600 RVA: 0x00AE842C File Offset: 0x00AE662C
		private bool KickWall(double? anchorCoordX = null, double? anchorCoordY = null)
		{
			this.CalculateKickWallMoveOffset(this.CacheVector2D, anchorCoordX, anchorCoordY);
			return this.MoveByStep(this.CacheVector2D.X, this.CacheVector2D.Y);
		}

		// Token: 0x06026F71 RID: 159601 RVA: 0x00AE8458 File Offset: 0x00AE6658
		public void GetMinoCoordInGrid(double minoLocalCoordX, double minoLocalCoordY, Vector2D outVec, double? anchorCoordX = null, double? anchorCoordY = null)
		{
			double num = anchorCoordX ?? this.AnchorCoord.X;
			double num2 = anchorCoordY ?? this.AnchorCoord.Y;
			outVec.Set(num + minoLocalCoordX, num2 + minoLocalCoordY);
		}

		// Token: 0x06026F72 RID: 159602 RVA: 0x00AE84B3 File Offset: 0x00AE66B3
		public void UpdateMinoWorldLocation(Mino minoData, double coordX, double coordY)
		{
			SlidingBlocksUtil.GetWorldLocationByCoord(coordX, coordY, this.OriginTransform, this.CacheVector);
			AActor cubeActor = minoData.CubeActor;
			if (cubeActor == null)
			{
				return;
			}
			cubeActor.D_K2_SetActorLocation(this.CacheVector.ToUeVector(false), true, ref WorldGlobal.SweepHitResult, false);
		}

		// Token: 0x06026F73 RID: 159603 RVA: 0x00AE84ED File Offset: 0x00AE66ED
		public ETetrominoState GetState()
		{
			return this.State;
		}

		// Token: 0x06026F74 RID: 159604 RVA: 0x00AE84F5 File Offset: 0x00AE66F5
		public void SetState(ETetrominoState value)
		{
			this.State = value;
		}

		// Token: 0x04015481 RID: 87169
		private ETetrominoState State;

		// Token: 0x04015482 RID: 87170
		private SlidingBlocksDefine.ETetrominoBorad BoardType;

		// Token: 0x04015484 RID: 87172
		public readonly Vector2D AnchorCoord = Vector2D.Create();

		// Token: 0x04015485 RID: 87173
		public readonly Vector2D AnchorLocalCoord = Vector2D.Create();

		// Token: 0x04015486 RID: 87174
		public readonly Vector2D GeometricConfigCoord = Vector2D.Create();

		// Token: 0x04015487 RID: 87175
		private double AnchorFallingTargetCoordY;

		// Token: 0x04015488 RID: 87176
		private double CurFallSpeed;

		// Token: 0x04015489 RID: 87177
		private int MoveTrailEffectHandle;

		// Token: 0x0401548A RID: 87178
		private bool ExecutedFallFinished;

		// Token: 0x0401548B RID: 87179
		private readonly Vector2D TempMinoCoord = Vector2D.Create();

		// Token: 0x0401548C RID: 87180
		private readonly Dictionary<string, Mino> TempMinoDataMap = new Dictionary<string, Mino>();

		// Token: 0x0401548D RID: 87181
		private readonly Vector CacheVector = Vector.Create();

		// Token: 0x0401548E RID: 87182
		private readonly Vector2D CacheVector2D = Vector2D.Create();

		// Token: 0x04015492 RID: 87186
		public readonly SlidingBlocksDefine.ETetrominoType TetrominoType;

		// Token: 0x04015493 RID: 87187
		private readonly SlidingBlocksDefine.ETetrominoRotateState InitRotateState;

		// Token: 0x04015494 RID: 87188
		private readonly float InitFallSpeed;

		// Token: 0x04015495 RID: 87189
		private readonly float FallAcceleration;

		// Token: 0x04015496 RID: 87190
		private readonly ETetrominoState InitState;
	}
}
