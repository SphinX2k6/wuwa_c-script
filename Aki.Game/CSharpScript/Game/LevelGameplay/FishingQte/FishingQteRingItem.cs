using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FBA RID: 24506
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingQteRingItem : UiPanelBase
	{
		// Token: 0x0603AE31 RID: 241201 RVA: 0x010A3C68 File Offset: 0x010A1E68
		public void Init(IFishingQteConfig config, FishingQteGameInfo gameInfo)
		{
			this.GameInfo = gameInfo;
			this.RingConfig = config;
			this.RingInfo = gameInfo.GetRingInfo();
			float num = this.RingConfig.HiddenInterval[0];
			float num2 = this.RingConfig.HiddenInterval[1];
			float num3 = 2f * num + num2;
			if (num3 > 0f)
			{
				this.PeriodAlphaTotalTime = num3;
			}
		}

		// Token: 0x0603AE32 RID: 241202 RVA: 0x010A3CCC File Offset: 0x010A1ECC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AE33 RID: 241203 RVA: 0x010A3D78 File Offset: 0x010A1F78
		protected override UniTask OnBeforeStartAsync()
		{
			FishingQteRingItem.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingQteRingItem.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE34 RID: 241204 RVA: 0x010A3DBB File Offset: 0x010A1FBB
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603AE35 RID: 241205 RVA: 0x010A3DCE File Offset: 0x010A1FCE
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603AE36 RID: 241206 RVA: 0x010A3DE8 File Offset: 0x010A1FE8
		public void InitRing()
		{
			this.RingInfo.ClearValidAreas();
			UniTask.Create(delegate()
			{
				FishingQteRingItem.<<InitRing>b__20_0>d <<InitRing>b__20_0>d;
				<<InitRing>b__20_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<InitRing>b__20_0>d.<>4__this = this;
				<<InitRing>b__20_0>d.<>1__state = -1;
				<<InitRing>b__20_0>d.<>t__builder.Start<FishingQteRingItem.<<InitRing>b__20_0>d>(ref <<InitRing>b__20_0>d);
				return <<InitRing>b__20_0>d.<>t__builder.Task;
			});
			this.RingQte.InitAllQteAreas();
			float cursorSpeed = this.GameInfo.CursorSpeed;
			float ringSpeed = this.GameInfo.RingSpeed;
			if (cursorSpeed > 0f && ringSpeed > 0f)
			{
				Log.Instance.Error(ELogModule.SceneGameplay, ELogAuthor.YYZ, "[FishingQte] 速度配置错误,同时存在指针速度和转盘速度", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.UpdateRotateMode((cursorSpeed > 0f) ? EFishingRotateMode.Arrow : EFishingRotateMode.Ring);
		}

		// Token: 0x0603AE37 RID: 241207 RVA: 0x010A3E74 File Offset: 0x010A2074
		[NullableContext(2)]
		public void OnAreaClick(EFishingAreaType areaType, ContinuousRingArea area)
		{
			switch (areaType)
			{
			case EFishingAreaType.BlankArea:
				this.RingBg.PlayAnim("Fail");
				this.RingQte.PlayAnim("Fail");
				return;
			case EFishingAreaType.QteArea:
				this.RingQte.PlayAnim("Success");
				this.PeriodAlphaCurrentTime = 0f;
				return;
			case EFishingAreaType.PerfectArea:
				this.RingQte.PlayAnim("PerfectQte");
				this.PeriodAlphaCurrentTime = 0f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0603AE38 RID: 241208 RVA: 0x010A3EEC File Offset: 0x010A20EC
		public void OnArrowStayAreaUpdate(int relativeValidAreaIndex)
		{
			List<RingArea> validAreas = this.RingInfo.GetValidAreas();
			if (relativeValidAreaIndex < 0 || relativeValidAreaIndex >= validAreas.Count)
			{
				return;
			}
			RingArea ringArea = validAreas[relativeValidAreaIndex];
			this.ArrowActiveStartYawAngle = (float)(-(float)Math.Max(ringArea.StartCellIndex - 1, 0) * 10);
			this.ArrowActiveEndYawAngle = (float)(-(float)ringArea.EndCellIndex * 10);
			if (this.ArrowActiveEndYawAngle >= this.ArrowActiveStartYawAngle)
			{
				this.ArrowActiveEndYawAngle -= 360f;
			}
			EArrowDirection arrowDirection = ringArea.ArrowDirection;
			if (arrowDirection != EArrowDirection.Clockwise)
			{
				if (arrowDirection == EArrowDirection.Anticlockwise)
				{
					this.CurrentRotator.Yaw = this.ArrowActiveEndYawAngle;
				}
			}
			else
			{
				this.CurrentRotator.Yaw = this.ArrowActiveStartYawAngle;
			}
			UUIItem arrow = this.Arrow;
			if (arrow == null)
			{
				return;
			}
			FRotator frotator = this.CurrentRotator.ToUeRotator();
			arrow.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0603AE39 RID: 241209 RVA: 0x010A3FB8 File Offset: 0x010A21B8
		public void OnTick(float delta)
		{
			if (this.GameInfo.IsGamePause())
			{
				return;
			}
			float cursorSpeed = this.GameInfo.CursorSpeed;
			float ringSpeed = this.GameInfo.RingSpeed;
			float cursorSpeed2 = (this.RotateMode == EFishingRotateMode.Arrow) ? cursorSpeed : ringSpeed;
			int direction = (this.RingInfo.ArrowDirection == EArrowDirection.Clockwise) ? -1 : 1;
			float deltaSecond = delta / 1000f;
			this.CurrentRotator.Yaw = this.GetRotatorYaw(direction, cursorSpeed2, deltaSecond);
			EFishingRotateMode rotateMode = this.RotateMode;
			if (rotateMode != EFishingRotateMode.Arrow)
			{
				if (rotateMode == EFishingRotateMode.Ring)
				{
					UUIItem rootItem = this.RingQte.GetRootItem();
					FRotator frotator = this.CurrentRotator.ToUeRotator();
					rootItem.SetUIRelativeRotation(frotator);
					this.RingInfo.CurrentArrowStayCellIndex = 36 - this.GetCurrentArrowStayCellIndex() + 1;
				}
			}
			else
			{
				UUIItem arrow = this.Arrow;
				if (arrow != null)
				{
					FRotator frotator = this.CurrentRotator.ToUeRotator();
					arrow.SetUIRelativeRotation(frotator);
				}
				this.RingInfo.CurrentArrowStayCellIndex = this.GetCurrentArrowStayCellIndex();
			}
			if (this.PeriodAlphaTotalTime > 0f)
			{
				float alphaInAlphaPeriod = this.GetAlphaInAlphaPeriod(this.PeriodAlphaCurrentTime);
				foreach (int continuousIndex in this.RingInfo.GetQteAreas().Keys)
				{
					this.RingQte.GetQteAreaTexture(continuousIndex).SetAlpha(alphaInAlphaPeriod);
				}
				foreach (int continuousIndex2 in this.RingInfo.GetPerfectAreas().Keys)
				{
					this.RingQte.GetPerfectAreaTexture(continuousIndex2).SetAlpha(alphaInAlphaPeriod);
				}
				this.PeriodAlphaCurrentTime += delta;
				if (this.PeriodAlphaCurrentTime >= this.PeriodAlphaTotalTime)
				{
					this.PeriodAlphaCurrentTime = 0f;
				}
			}
		}

		// Token: 0x0603AE3A RID: 241210 RVA: 0x010A41A4 File Offset: 0x010A23A4
		private float GetRotatorYaw(int direction, float cursorSpeed, float deltaSecond)
		{
			float num = this.CurrentRotator.Yaw;
			if (this.RingInfo.IsWholeRing)
			{
				num += (float)direction * (cursorSpeed * deltaSecond);
			}
			else
			{
				num += (float)direction * (cursorSpeed * deltaSecond);
				if (num < this.ArrowActiveEndYawAngle)
				{
					num = this.ArrowActiveEndYawAngle + 1f;
					this.RingInfo.OnArrowDirectionReverse();
				}
				if (num > this.ArrowActiveStartYawAngle)
				{
					num = this.ArrowActiveStartYawAngle;
					this.RingInfo.OnArrowDirectionReverse();
				}
			}
			if (num > 0f)
			{
				num -= 360f;
			}
			return num % 720f;
		}

		// Token: 0x0603AE3B RID: 241211 RVA: 0x010A4231 File Offset: 0x010A2431
		private int GetCurrentArrowStayCellIndex()
		{
			return (int)Math.Floor((double)(Math.Abs(this.CurrentRotator.Yaw) % 360f / 10f)) + 1;
		}

		// Token: 0x0603AE3C RID: 241212 RVA: 0x010A4258 File Offset: 0x010A2458
		private float GetAlphaInAlphaPeriod(float currentTime)
		{
			float num = this.RingConfig.HiddenInterval[0];
			float num2 = this.RingConfig.HiddenInterval[1];
			float num3 = this.RingConfig.HiddenInterval[2];
			float num4 = (num2 - num3) / 2f;
			if (currentTime < num)
			{
				return 1f;
			}
			if (currentTime < num + num4)
			{
				return 1f - (currentTime - num) / num4;
			}
			if (currentTime < num + num4 + num3)
			{
				return 0f;
			}
			if (currentTime < num + num2)
			{
				return (currentTime - num - num4 - num3) / num4;
			}
			return 1f;
		}

		// Token: 0x0603AE3D RID: 241213 RVA: 0x010A42E4 File Offset: 0x010A24E4
		private void UpdateRotateMode(EFishingRotateMode mode)
		{
			this.RotateMode = mode;
			if (mode != EFishingRotateMode.Arrow && mode == EFishingRotateMode.Ring)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_ControlPointLock");
				base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
				UUIItem rootItem = this.RingQte.GetRootItem();
				FRotator frotator = Rotator.Create().ToUeRotator();
				rootItem.SetUIRelativeRotation(frotator);
			}
		}

		// Token: 0x0603AE3E RID: 241214 RVA: 0x010A4344 File Offset: 0x010A2544
		public void SpawnContinuousArea(int continuousIndex, EFishingAreaType type = EFishingAreaType.QteArea)
		{
			this.RingQte.SpawnContinuousArea(continuousIndex, type);
		}

		// Token: 0x0401EF53 RID: 126803
		private const float YAW_MAX_ANGLE = 720f;

		// Token: 0x0401EF54 RID: 126804
		protected IFishingQteConfig RingConfig;

		// Token: 0x0401EF55 RID: 126805
		protected FishingQteGameInfo GameInfo;

		// Token: 0x0401EF56 RID: 126806
		protected FishingQteRingInfo RingInfo;

		// Token: 0x0401EF57 RID: 126807
		[Nullable(2)]
		protected FishingQteRingBgItem RingBg;

		// Token: 0x0401EF58 RID: 126808
		[Nullable(2)]
		protected FishingQteRingQteItem RingQte;

		// Token: 0x0401EF59 RID: 126809
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401EF5A RID: 126810
		[Nullable(2)]
		private UUIItem Arrow;

		// Token: 0x0401EF5B RID: 126811
		private Rotator CurrentRotator = Rotator.Create();

		// Token: 0x0401EF5C RID: 126812
		private float ArrowActiveStartYawAngle;

		// Token: 0x0401EF5D RID: 126813
		private float ArrowActiveEndYawAngle;

		// Token: 0x0401EF5E RID: 126814
		protected float PeriodAlphaTotalTime;

		// Token: 0x0401EF5F RID: 126815
		protected float PeriodAlphaCurrentTime;

		// Token: 0x0401EF60 RID: 126816
		protected EFishingRotateMode RotateMode;

		// Token: 0x0200B8D9 RID: 47321
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040390DC RID: 233692
			public const int Arrow = 0;

			// Token: 0x040390DD RID: 233693
			public const int RingBg = 1;

			// Token: 0x040390DE RID: 233694
			public const int RingQte = 2;

			// Token: 0x040390DF RID: 233695
			public const int TexArrow = 3;
		}
	}
}
