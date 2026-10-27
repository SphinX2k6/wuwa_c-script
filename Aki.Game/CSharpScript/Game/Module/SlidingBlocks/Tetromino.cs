using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02004B87 RID: 19335
	[NullableContext(1)]
	[Nullable(0)]
	public class Tetromino
	{
		// Token: 0x17007C46 RID: 31814
		// (get) Token: 0x060321B7 RID: 205239 RVA: 0x00BA2EA8 File Offset: 0x00BA10A8
		public Dictionary<string, Mino> MinoDataMap { get; } = new Dictionary<string, Mino>();

		// Token: 0x17007C47 RID: 31815
		// (get) Token: 0x060321B8 RID: 205240 RVA: 0x00BA2EB0 File Offset: 0x00BA10B0
		public Transform OriginTransform
		{
			get
			{
				return SlidingBlocksModel.Instance.GameData.OriginTransform;
			}
		}

		// Token: 0x17007C48 RID: 31816
		// (get) Token: 0x060321B9 RID: 205241 RVA: 0x00BA2EC1 File Offset: 0x00BA10C1
		// (set) Token: 0x060321BA RID: 205242 RVA: 0x00BA2EC9 File Offset: 0x00BA10C9
		public float RemainAimTime { get; private set; }

		// Token: 0x17007C49 RID: 31817
		// (get) Token: 0x060321BB RID: 205243 RVA: 0x00BA2ED2 File Offset: 0x00BA10D2
		// (set) Token: 0x060321BC RID: 205244 RVA: 0x00BA2EDA File Offset: 0x00BA10DA
		public SlidingBlocksDefine.ETetrominoRotateState RotateState { get; private set; }

		// Token: 0x17007C4A RID: 31818
		// (get) Token: 0x060321BD RID: 205245 RVA: 0x00BA2EE3 File Offset: 0x00BA10E3
		// (set) Token: 0x060321BE RID: 205246 RVA: 0x00BA2EEB File Offset: 0x00BA10EB
		[Nullable(2)]
		public Mino GeometricCenterMino { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x060321BF RID: 205247 RVA: 0x00BA2EF4 File Offset: 0x00BA10F4
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

		// Token: 0x060321C0 RID: 205248 RVA: 0x00BA2FB0 File Offset: 0x00BA11B0
		public void Clear()
		{
			foreach (Mino mino in this.MinoDataMap.Values)
			{
				SlidingBlocksUtil.DestroyCube(mino.CubeActor);
			}
			this.MinoDataMap.Clear();
			this.GeometricCenterMino = null;
		}

		// Token: 0x060321C1 RID: 205249 RVA: 0x00BA3020 File Offset: 0x00BA1220
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

		// Token: 0x060321C2 RID: 205250 RVA: 0x00BA30FC File Offset: 0x00BA12FC
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

		// Token: 0x060321C3 RID: 205251 RVA: 0x00BA31A0 File Offset: 0x00BA13A0
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

		// Token: 0x060321C4 RID: 205252 RVA: 0x00BA32A8 File Offset: 0x00BA14A8
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

		// Token: 0x060321C5 RID: 205253 RVA: 0x00BA3374 File Offset: 0x00BA1574
		private UniTask CreateAndPlaySpawnEffect()
		{
			Tetromino.<CreateAndPlaySpawnEffect>d__41 <CreateAndPlaySpawnEffect>d__;
			<CreateAndPlaySpawnEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateAndPlaySpawnEffect>d__.<>4__this = this;
			<CreateAndPlaySpawnEffect>d__.<>1__state = -1;
			<CreateAndPlaySpawnEffect>d__.<>t__builder.Start<Tetromino.<CreateAndPlaySpawnEffect>d__41>(ref <CreateAndPlaySpawnEffect>d__);
			return <CreateAndPlaySpawnEffect>d__.<>t__builder.Task;
		}

		// Token: 0x060321C6 RID: 205254 RVA: 0x00BA33B8 File Offset: 0x00BA15B8
		private void CreateTrailEffect()
		{
			string moveTrailEffectPath = SlidingBlocksGlobal.GetMoveTrailEffectPath(SlidingBlocksModel.Instance.GameData.PlayMode);
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(this.OriginTransform.ToUeTransform());
			this.MoveTrailEffectHandle = instance.SpawnEffect(world, ftransformDouble, moveTrailEffectPath, "Tetromino.Init", null, EEffectType.Scene, null, null, null, false, false);
			EffectSystem.Instance.RegisterCustomCheckOwnerFunc(this.MoveTrailEffectHandle, (int _) => this.State >= ETetrominoState.PlayLockEffect);
		}

		// Token: 0x060321C7 RID: 205255 RVA: 0x00BA342C File Offset: 0x00BA162C
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

		// Token: 0x060321C8 RID: 205256 RVA: 0x00BA35A4 File Offset: 0x00BA17A4
		public void OnTick(float delta, SlidingBlocksGameData gameData)
		{
			this.UpdateByState(delta, gameData);
		}

		// Token: 0x060321C9 RID: 205257 RVA: 0x00BA35B0 File Offset: 0x00BA17B0
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

		// Token: 0x060321CA RID: 205258 RVA: 0x00BA3657 File Offset: 0x00BA1857
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

		// Token: 0x060321CB RID: 205259 RVA: 0x00BA3698 File Offset: 0x00BA1898
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

		// Token: 0x060321CC RID: 205260 RVA: 0x00BA3763 File Offset: 0x00BA1963
		public void SkipAimingStage()
		{
			this.SetState(ETetrominoState.InitFallData);
		}

		// Token: 0x060321CD RID: 205261 RVA: 0x00BA376C File Offset: 0x00BA196C
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

		// Token: 0x060321CE RID: 205262 RVA: 0x00BA379C File Offset: 0x00BA199C
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

		// Token: 0x060321CF RID: 205263 RVA: 0x00BA3878 File Offset: 0x00BA1A78
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

		// Token: 0x060321D0 RID: 205264 RVA: 0x00BA38E4 File Offset: 0x00BA1AE4
		private double UpdateFallSpeed(float delta)
		{
			if (this.FallAcceleration == 0f)
			{
				return (double)this.InitFallSpeed;
			}
			this.CurFallSpeed += (double)(delta * this.FallAcceleration) * TimeUtil.Instance.Millisecond;
			return this.CurFallSpeed;
		}

		// Token: 0x060321D1 RID: 205265 RVA: 0x00BA3924 File Offset: 0x00BA1B24
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

		// Token: 0x060321D2 RID: 205266 RVA: 0x00BA3970 File Offset: 0x00BA1B70
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

		// Token: 0x060321D3 RID: 205267 RVA: 0x00BA39C3 File Offset: 0x00BA1BC3
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

		// Token: 0x060321D4 RID: 205268 RVA: 0x00BA39FE File Offset: 0x00BA1BFE
		private bool CheckCanMoveByMoveStep(double x, double y)
		{
			return (x != 0.0 || y != 0.0) && this.CheckCanMove(this.AnchorCoord.X + x, this.AnchorCoord.Y + y) == SlidingBlocksDefine.ECheckCanMoveResult.None;
		}

		// Token: 0x060321D5 RID: 205269 RVA: 0x00BA3A40 File Offset: 0x00BA1C40
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

		// Token: 0x060321D6 RID: 205270 RVA: 0x00BA3B10 File Offset: 0x00BA1D10
		private void UpdateTetrominoWorldLocation()
		{
			foreach (Mino mino in this.MinoDataMap.Values)
			{
				this.GetMinoCoordInGrid(mino.Coord.X, mino.Coord.Y, this.TempMinoCoord, null, null);
				this.UpdateMinoWorldLocation(mino, this.TempMinoCoord.X, this.TempMinoCoord.Y);
			}
		}

		// Token: 0x060321D7 RID: 205271 RVA: 0x00BA3BB4 File Offset: 0x00BA1DB4
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

		// Token: 0x060321D8 RID: 205272 RVA: 0x00BA3C40 File Offset: 0x00BA1E40
		[return: Nullable(2)]
		private Mino GetNextStepOverlapPlayerMino(Vector2D playerCoord, double nextStepAnchorCoordX, double nextStepAnchorCoordY)
		{
			foreach (Mino mino in from kv in this.MinoDataMap
			select kv.Value)
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

		// Token: 0x060321D9 RID: 205273 RVA: 0x00BA3D18 File Offset: 0x00BA1F18
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

		// Token: 0x060321DA RID: 205274 RVA: 0x00BA3EB0 File Offset: 0x00BA20B0
		private bool CheckCanRotate()
		{
			return this.TetrominoType != SlidingBlocksDefine.ETetrominoType.O块;
		}

		// Token: 0x060321DB RID: 205275 RVA: 0x00BA3EC0 File Offset: 0x00BA20C0
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

		// Token: 0x060321DC RID: 205276 RVA: 0x00BA3F68 File Offset: 0x00BA2168
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

		// Token: 0x060321DD RID: 205277 RVA: 0x00BA3FF6 File Offset: 0x00BA21F6
		private static void RotateWithLocalCoord(double localCoordX, double localCoordY, Vector2D outVec, bool bClockwise = true)
		{
			if (bClockwise)
			{
				outVec.Set(-localCoordY, localCoordX);
				return;
			}
			outVec.Set(localCoordY, -localCoordX);
		}

		// Token: 0x060321DE RID: 205278 RVA: 0x00BA4010 File Offset: 0x00BA2210
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

		// Token: 0x060321DF RID: 205279 RVA: 0x00BA4208 File Offset: 0x00BA2408
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

		// Token: 0x060321E0 RID: 205280 RVA: 0x00BA42E0 File Offset: 0x00BA24E0
		private bool KickWall(double? anchorCoordX = null, double? anchorCoordY = null)
		{
			this.CalculateKickWallMoveOffset(this.CacheVector2D, anchorCoordX, anchorCoordY);
			return this.MoveByStep(this.CacheVector2D.X, this.CacheVector2D.Y);
		}

		// Token: 0x060321E1 RID: 205281 RVA: 0x00BA430C File Offset: 0x00BA250C
		public void GetMinoCoordInGrid(double minoLocalCoordX, double minoLocalCoordY, Vector2D outVec, double? anchorCoordX = null, double? anchorCoordY = null)
		{
			double num = anchorCoordX ?? this.AnchorCoord.X;
			double num2 = anchorCoordY ?? this.AnchorCoord.Y;
			outVec.Set(num + minoLocalCoordX, num2 + minoLocalCoordY);
		}

		// Token: 0x060321E2 RID: 205282 RVA: 0x00BA4367 File Offset: 0x00BA2567
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

		// Token: 0x060321E3 RID: 205283 RVA: 0x00BA43A1 File Offset: 0x00BA25A1
		public ETetrominoState GetState()
		{
			return this.State;
		}

		// Token: 0x060321E4 RID: 205284 RVA: 0x00BA43A9 File Offset: 0x00BA25A9
		public void SetState(ETetrominoState value)
		{
			this.State = value;
		}

		// Token: 0x0401AB2D RID: 109357
		private ETetrominoState State;

		// Token: 0x0401AB2E RID: 109358
		private SlidingBlocksDefine.ETetrominoBorad BoardType;

		// Token: 0x0401AB30 RID: 109360
		public readonly Vector2D AnchorCoord = Vector2D.Create();

		// Token: 0x0401AB31 RID: 109361
		public readonly Vector2D AnchorLocalCoord = Vector2D.Create();

		// Token: 0x0401AB32 RID: 109362
		public readonly Vector2D GeometricConfigCoord = Vector2D.Create();

		// Token: 0x0401AB33 RID: 109363
		private double AnchorFallingTargetCoordY;

		// Token: 0x0401AB34 RID: 109364
		private double CurFallSpeed;

		// Token: 0x0401AB35 RID: 109365
		private int MoveTrailEffectHandle;

		// Token: 0x0401AB36 RID: 109366
		private bool ExecutedFallFinished;

		// Token: 0x0401AB37 RID: 109367
		private readonly Vector2D TempMinoCoord = Vector2D.Create();

		// Token: 0x0401AB38 RID: 109368
		private readonly Dictionary<string, Mino> TempMinoDataMap = new Dictionary<string, Mino>();

		// Token: 0x0401AB39 RID: 109369
		private readonly Vector CacheVector = Vector.Create();

		// Token: 0x0401AB3A RID: 109370
		private readonly Vector2D CacheVector2D = Vector2D.Create();

		// Token: 0x0401AB3E RID: 109374
		public readonly SlidingBlocksDefine.ETetrominoType TetrominoType;

		// Token: 0x0401AB3F RID: 109375
		private readonly SlidingBlocksDefine.ETetrominoRotateState InitRotateState;

		// Token: 0x0401AB40 RID: 109376
		private readonly float InitFallSpeed;

		// Token: 0x0401AB41 RID: 109377
		private readonly float FallAcceleration;

		// Token: 0x0401AB42 RID: 109378
		private readonly ETetrominoState InitState;
	}
}
