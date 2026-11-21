using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x020060DA RID: 24794
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedRingItem : UiPanelBase
	{
		// Token: 0x1700709D RID: 28829
		// (get) Token: 0x0603B72B RID: 243499 RVA: 0x010D2C30 File Offset: 0x010D0E30
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public OneOf<BrokenRockRing, BrokenRockRingConfig> Config
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return this.RingConfig;
			}
		}

		// Token: 0x0603B72C RID: 243500 RVA: 0x010D2C38 File Offset: 0x010D0E38
		public BigStuffedRingItem(int id, AActor actor)
		{
			this.Id = id;
			this.MyRootActor = actor;
			this.RingConfig = BigStuffedDollModel.Instance.GetRingConfig(id);
			if (!this.RingConfig.HasValue)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[BigStuffedDoll]环配置找不到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.RingConfig.IsT1)
			{
				this.IsWholeRing = (this.RingConfig.AsT1.InvalidBoxLength == 0);
			}
			else if (this.RingConfig.IsT2)
			{
				this.IsWholeRing = (this.RingConfig.AsT2.InvalidBox.Count == 0);
			}
			EArrowDirection arrowDirection = EArrowDirection.Clockwise;
			if (this.RingConfig.IsT1)
			{
				arrowDirection = (this.RingConfig.AsT1.IsAnticlockwise ? EArrowDirection.Anticlockwise : EArrowDirection.Clockwise);
			}
			else if (this.RingConfig.IsT2)
			{
				arrowDirection = (this.RingConfig.AsT2.IsAnticlockwise ? EArrowDirection.Anticlockwise : EArrowDirection.Clockwise);
			}
			this.RingInfo = BigStuffedDollModel.Instance.GameInfo.AddRingInfo(id, arrowDirection);
			this.RingBg = new BigStuffedRingBgItem(this.Id, this.RingConfig, this.RingInfo);
			this.RingSpecialArea = new BigStuffedRingSpecialAreaItem(this.Id, this.RingConfig, this.RingInfo);
			this.RingLight = new BigStuffedRingLightItem(this.Id, this.RingConfig);
		}

		// Token: 0x0603B72D RID: 243501 RVA: 0x010D2DCC File Offset: 0x010D0FCC
		public BigStuffedRingItem(int id, AActor actor, [Nullable(2)] BrokenRockRingConfig config)
		{
			this.Id = id;
			this.MyRootActor = actor;
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[BigStuffedDoll]环配置找不到";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsWholeRing = (config.InvalidBox.Count == 0);
			EArrowDirection arrowDirection = config.IsAnticlockwise ? EArrowDirection.Anticlockwise : EArrowDirection.Clockwise;
			this.RingInfo = BigStuffedDollModel.Instance.GameInfo.AddRingInfo(id, arrowDirection);
			this.RingBg = new BigStuffedRingBgItem(this.Id, config, this.RingInfo);
			this.RingSpecialArea = new BigStuffedRingSpecialAreaItem(this.Id, config, this.RingInfo);
			this.RingLight = new BigStuffedRingLightItem(this.Id, config);
		}

		// Token: 0x0603B72E RID: 243502 RVA: 0x010D2EC0 File Offset: 0x010D10C0
		public UniTask InitAsync()
		{
			BigStuffedRingItem.<InitAsync>d__31 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<BigStuffedRingItem.<InitAsync>d__31>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B72F RID: 243503 RVA: 0x010D2F04 File Offset: 0x010D1104
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B730 RID: 243504 RVA: 0x010D2FF4 File Offset: 0x010D11F4
		protected override UniTask OnBeforeStartAsync()
		{
			BigStuffedRingItem.<OnBeforeStartAsync>d__33 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BigStuffedRingItem.<OnBeforeStartAsync>d__33>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B731 RID: 243505 RVA: 0x010D3037 File Offset: 0x010D1237
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603B732 RID: 243506 RVA: 0x010D3054 File Offset: 0x010D1254
		[NullableContext(2)]
		public void OnAreaClick(EAreaType areaType, ContinuousArea area)
		{
			this.CurrentAreaType = areaType;
			this.CurrentContinuousIndex = ((area != null) ? area.ContinuousIndex : -1);
			string text = null;
			string text2 = null;
			switch (areaType)
			{
			case EAreaType.BlankArea:
				text = "Miss";
				break;
			case EAreaType.GoodArea:
				text = "Press01";
				text2 = "Light01";
				break;
			case EAreaType.PerfectArea:
			case EAreaType.BonusArea:
				text = "Press02";
				text2 = "Light02";
				break;
			}
			this.LevelSequencePlayer.StopCurrentSequence(true, true);
			if (text != null)
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName(text, false, null, false);
			}
			if (text2 != null)
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName(text2, false, null, false);
			}
		}

		// Token: 0x0603B733 RID: 243507 RVA: 0x010D30FC File Offset: 0x010D12FC
		private void OnSequenceStart(string sequenceName)
		{
			if (sequenceName == "Miss" || sequenceName == "Press01" || sequenceName == "Press02")
			{
				EventSystem.Instance.Emit<int, EAreaType, int>(EEventName.OnBigStuffedDollRingItemSequencePlayStart, this.Id, this.CurrentAreaType, this.CurrentContinuousIndex);
			}
		}

		// Token: 0x0603B734 RID: 243508 RVA: 0x010D3154 File Offset: 0x010D1354
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Miss" || sequenceName == "Press01" || sequenceName == "Press02")
			{
				EventSystem.Instance.Emit<int, EAreaType, int>(EEventName.OnBigStuffedDollRingItemSequencePlayEnd, this.Id, this.CurrentAreaType, this.CurrentContinuousIndex);
			}
		}

		// Token: 0x0603B735 RID: 243509 RVA: 0x010D31AC File Offset: 0x010D13AC
		public void OnArrowEnter()
		{
			this.IsArrowStayHere = true;
			UUIItem arrow = this.Arrow;
			if (arrow != null)
			{
				arrow.SetUIActive(true);
			}
			this.LevelSequencePlayer.StopCurrentSequence(true, true);
			if (!this.InitAnimPlay)
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
				this.InitAnimPlay = true;
				return;
			}
			this.LevelSequencePlayer.PlayLevelSequenceByName("In", false, null, false);
		}

		// Token: 0x0603B736 RID: 243510 RVA: 0x010D3228 File Offset: 0x010D1428
		public void OnArrowExit()
		{
			this.IsArrowStayHere = false;
			UUIItem arrow = this.Arrow;
			if (arrow != null)
			{
				arrow.SetUIActive(false);
			}
			this.LevelSequencePlayer.StopCurrentSequence(true, true);
			if (!this.InitAnimPlay)
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Start02", false, null, false);
				this.InitAnimPlay = true;
				return;
			}
			this.LevelSequencePlayer.PlayLevelSequenceByName("Out", false, null, false);
		}

		// Token: 0x0603B737 RID: 243511 RVA: 0x010D32A4 File Offset: 0x010D14A4
		public void OnArrowStayAreaUpdate(int relativeValidAreaIndex)
		{
			if (!this.IsArrowStayHere)
			{
				return;
			}
			List<Area> validAreas = this.RingInfo.GetValidAreas();
			if (validAreas == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneGameplay;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "[BigStuffedDoll]初始化Arrow时：找不到有效区域";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", this.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (relativeValidAreaIndex >= 0)
			{
				int? num = (validAreas != null) ? new int?(validAreas.Count) : null;
				if (!(relativeValidAreaIndex >= num.GetValueOrDefault() & num != null))
				{
					Area area = validAreas[relativeValidAreaIndex];
					this.ArrowActiveStartYawAngle = (float)(-(float)Math.Max(area.StartCellIndex - 1, 0)) * 10f;
					this.ArrowActiveEndYawAngle = (float)(-(float)area.EndCellIndex) * 10f;
					if (this.ArrowActiveEndYawAngle >= this.ArrowActiveStartYawAngle)
					{
						this.ArrowActiveEndYawAngle -= 360f;
					}
					EArrowDirection arrowDirection = area.ArrowDirection;
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
					return;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneGameplay;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "[BigStuffedDoll]初始化Arrow时：相对有效区域索引越界";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("relativeValidAreaIndex", relativeValidAreaIndex);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x0603B738 RID: 243512 RVA: 0x010D3410 File Offset: 0x010D1610
		public void OnTick(float delta)
		{
			BigStuffedDollModel instance = BigStuffedDollModel.Instance;
			if (!this.IsArrowStayHere || this.RingConfig == null)
			{
				return;
			}
			if (instance.GetGameStage() != EGameStage.GamePlaying)
			{
				return;
			}
			int arrowSpeed = instance.GetArrowSpeed(new OneOf<BrokenRockRing, BrokenRockRingConfig>?(this.RingConfig));
			if (arrowSpeed == 0)
			{
				return;
			}
			int num = -1;
			EArrowDirection currentArrowDirection = instance.CurrentArrowDirection;
			if (currentArrowDirection != EArrowDirection.Clockwise)
			{
				if (currentArrowDirection == EArrowDirection.Anticlockwise)
				{
					num = 1;
				}
			}
			else
			{
				num = -1;
			}
			float num2 = delta / 1000f;
			float num3 = this.CurrentRotator.Yaw;
			if (this.IsWholeRing)
			{
				num3 = this.CurrentRotator.Yaw + (float)num * ((float)arrowSpeed * num2);
			}
			else
			{
				num3 = this.CurrentRotator.Yaw + (float)num * ((float)arrowSpeed * num2);
				if (num3 < this.ArrowActiveEndYawAngle)
				{
					num3 = this.ArrowActiveEndYawAngle;
					instance.ArrowDirectionReverse();
				}
				if (num3 > this.ArrowActiveStartYawAngle)
				{
					num3 = this.ArrowActiveStartYawAngle;
					instance.ArrowDirectionReverse();
				}
			}
			this.CurrentRotator.Yaw = num3;
			UUIItem arrow = this.Arrow;
			if (arrow == null)
			{
				return;
			}
			FRotator frotator = this.CurrentRotator.ToUeRotator();
			arrow.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0603B739 RID: 243513 RVA: 0x010D351F File Offset: 0x010D171F
		public void SpawnContinuousArea(int continuousIndex)
		{
			this.RingSpecialArea.SpawnSingleContinuousArea(continuousIndex);
		}

		// Token: 0x0603B73A RID: 243514 RVA: 0x010D352D File Offset: 0x010D172D
		public int GetCurrentArrowStayCellIndex()
		{
			if (!this.IsArrowStayHere)
			{
				return 0;
			}
			return (int)Math.Floor((double)(Math.Abs(this.CurrentRotator.Yaw) % 360f / 10f)) + 1;
		}

		// Token: 0x0401F56B RID: 128363
		private const string BLANK_QTE_ANIM = "Miss";

		// Token: 0x0401F56C RID: 128364
		private const string GOODAREA_QTE_ANIM = "Press01";

		// Token: 0x0401F56D RID: 128365
		private const string BONUSAREA_QTE_ANIM = "Press02";

		// Token: 0x0401F56E RID: 128366
		private const string SWITCH_IN_CURRENT = "In";

		// Token: 0x0401F56F RID: 128367
		private const string SWITCH_OUT_CURRENT = "Out";

		// Token: 0x0401F570 RID: 128368
		private const string CURRENT_RING_SHOW = "Start01";

		// Token: 0x0401F571 RID: 128369
		private const string NOT_CURRENT_RING_SHOW = "Start02";

		// Token: 0x0401F572 RID: 128370
		private const string COMMON_LIGHT = "Light01";

		// Token: 0x0401F573 RID: 128371
		private const string PERFECT_LIGHT = "Light02";

		// Token: 0x0401F574 RID: 128372
		public readonly int Id = -1;

		// Token: 0x0401F575 RID: 128373
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private readonly OneOf<BrokenRockRing, BrokenRockRingConfig> RingConfig;

		// Token: 0x0401F576 RID: 128374
		[Nullable(2)]
		private readonly BigStuffedRingInfo RingInfo;

		// Token: 0x0401F577 RID: 128375
		[Nullable(2)]
		private readonly AActor MyRootActor;

		// Token: 0x0401F578 RID: 128376
		[Nullable(2)]
		private readonly BigStuffedRingBgItem RingBg;

		// Token: 0x0401F579 RID: 128377
		[Nullable(2)]
		private readonly BigStuffedRingSpecialAreaItem RingSpecialArea;

		// Token: 0x0401F57A RID: 128378
		[Nullable(2)]
		private readonly BigStuffedRingLightItem RingLight;

		// Token: 0x0401F57B RID: 128379
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F57C RID: 128380
		[Nullable(2)]
		private UUIItem Arrow;

		// Token: 0x0401F57D RID: 128381
		private bool IsArrowStayHere;

		// Token: 0x0401F57E RID: 128382
		private readonly Rotator CurrentRotator = Rotator.Create();

		// Token: 0x0401F57F RID: 128383
		private float ArrowActiveStartYawAngle;

		// Token: 0x0401F580 RID: 128384
		private float ArrowActiveEndYawAngle;

		// Token: 0x0401F581 RID: 128385
		private readonly bool IsWholeRing;

		// Token: 0x0401F582 RID: 128386
		private bool InitAnimPlay;

		// Token: 0x0401F583 RID: 128387
		private EAreaType CurrentAreaType;

		// Token: 0x0401F584 RID: 128388
		private int CurrentContinuousIndex = -1;

		// Token: 0x0200B982 RID: 47490
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x04039333 RID: 234291
			public const int FlagCurrentTexture = 0;

			// Token: 0x04039334 RID: 234292
			public const int ContentRoot = 1;

			// Token: 0x04039335 RID: 234293
			public const int Arrow = 2;

			// Token: 0x04039336 RID: 234294
			public const int RingBg = 3;

			// Token: 0x04039337 RID: 234295
			public const int RingSpecialArea = 4;

			// Token: 0x04039338 RID: 234296
			public const int RingLight = 5;
		}
	}
}
