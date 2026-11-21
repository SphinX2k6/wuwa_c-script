using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LifePoint
{
	// Token: 0x02005C43 RID: 23619
	[NullableContext(1)]
	[Nullable(0)]
	public class LifePointModel : ModelBase
	{
		// Token: 0x0603A023 RID: 237603 RVA: 0x010511F6 File Offset: 0x0104F3F6
		public string GetText(EPieceColorType color)
		{
			return this.ColorMap[color][4];
		}

		// Token: 0x0603A024 RID: 237604 RVA: 0x01051206 File Offset: 0x0104F406
		public string GetColorHex(EPieceColorType color)
		{
			return this.ColorMap[color][0];
		}

		// Token: 0x0603A025 RID: 237605 RVA: 0x01051216 File Offset: 0x0104F416
		public string GetFramePath(EPieceColorType color)
		{
			return this.ColorMap[color][1];
		}

		// Token: 0x0603A026 RID: 237606 RVA: 0x01051228 File Offset: 0x0104F428
		protected override bool OnInit()
		{
			this.ColorMap[EPieceColorType.Blue] = new string[]
			{
				"77CBFFFF",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_LeftPointFrmBlie.T_LeftPointFrmBlie",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_BgTextureBlueNor.T_BgTextureBlueNor",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_BgTextureBlue.T_BgTextureBlue",
				"LifePlay_Blue_Text"
			};
			this.ColorMap[EPieceColorType.Red] = new string[]
			{
				"FF8E90FF",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_LeftPointFrmRed.T_LeftPointFrmRed",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_BgTextureRedNor.T_BgTextureRedNor",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_BgTextureRed.T_BgTextureRed",
				"LifePlay_Red_Text"
			};
			this.ColorMap[EPieceColorType.Yellow] = new string[]
			{
				"FFCE89FF",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_LeftPointFrmYellow.T_LeftPointFrmYellow",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_BgTextureYellowNor.T_BgTextureYellowNor",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_BgTextureYellow.T_BgTextureYellow",
				"LifePlay_Yellow_Text"
			};
			this.ColorMap[EPieceColorType.Green] = new string[]
			{
				"ACFFB6FF",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_LeftPointFrmGreen.T_LeftPointFrmGreen",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_BgTextureGreenNor.T_BgTextureGreenNor",
				"/Game/Aki/UI/UIResources/UiLevel/Image/LifePoint/T_BgTextureGreen.T_BgTextureGreen",
				"LifePlay_Green_Text"
			};
			this.DirectionParam[EDirection.Center] = -1f;
			this.DirectionParam[EDirection.Down] = 0.75f;
			this.DirectionParam[EDirection.Left] = 0.5f;
			this.DirectionParam[EDirection.Up] = 0.25f;
			this.DirectionParam[EDirection.Right] = 0f;
			this.AnimParam.MaxTime = (float)ConfigCommonParamById.GetIntConfig("LifePoint_MaxTime").Value;
			this.AnimParam.AccelerationRes = ConfigCommonParamById.GetFloatConfig("LifePoint_AccelerationResis").Value;
			this.AnimParam.MinInterval = (float)ConfigCommonParamById.GetIntConfig("LifePoint_MinInterval").Value;
			this.AnimParam.GridMinRate = ConfigCommonParamById.GetFloatConfig("LifePoint_GridMinSpeed").Value;
			this.AnimParam.GridMaxRate = ConfigCommonParamById.GetFloatConfig("LifePoint_GridMaxSpeed").Value;
			this.AnimParam.GridAccelerationTime = (float)ConfigCommonParamById.GetIntConfig("LifePoint_GridDuration").Value;
			return true;
		}

		// Token: 0x0603A027 RID: 237607 RVA: 0x01051424 File Offset: 0x0104F624
		protected override bool OnClear()
		{
			this.ColorMap.Clear();
			this.GridTextureMap.Clear();
			this.HitGridTextureMap.Clear();
			this.DirectionParam.Clear();
			return true;
		}

		// Token: 0x0603A028 RID: 237608 RVA: 0x01051453 File Offset: 0x0104F653
		public float CalcCountDownTime(int order)
		{
			return (float)((double)this.AnimParam.MaxTime * (-(float)Math.Exp((double)((float)(-(float)order) * this.AnimParam.AccelerationRes)) + 1.0) + (double)(this.AnimParam.MinInterval * (float)order));
		}

		// Token: 0x0603A029 RID: 237609 RVA: 0x01051494 File Offset: 0x0104F694
		public float CalPlayRate(float time)
		{
			return MathUtils.Instance.Clamp((this.AnimParam.GridMinRate + (this.AnimParam.GridMaxRate - this.AnimParam.GridMinRate) * time) / this.AnimParam.GridAccelerationTime, this.AnimParam.GridMinRate, this.AnimParam.GridMaxRate);
		}

		// Token: 0x0603A02A RID: 237610 RVA: 0x010514F4 File Offset: 0x0104F6F4
		public float BlendDirectionParam(float a1, EDirection a2Direction)
		{
			if (a1 < 0f)
			{
				return a1;
			}
			float num = this.DirectionParam[a2Direction];
			if (Math.Abs(a1 - num) == 0.5f)
			{
				return a1;
			}
			float num2;
			if (Math.Abs(a1 - num) > 0.5f)
			{
				num2 = (a1 + num - 1f) / 2f;
			}
			else
			{
				num2 = (a1 + num) / 2f;
			}
			if (num2 < 0f)
			{
				num2 += 1f;
			}
			return num2;
		}

		// Token: 0x0603A02B RID: 237611 RVA: 0x0105156C File Offset: 0x0104F76C
		public UniTask LoadDataAsync(ILifePoint config, int entityId)
		{
			LifePointModel.<LoadDataAsync>d__26 <LoadDataAsync>d__;
			<LoadDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadDataAsync>d__.<>4__this = this;
			<LoadDataAsync>d__.config = config;
			<LoadDataAsync>d__.entityId = entityId;
			<LoadDataAsync>d__.<>1__state = -1;
			<LoadDataAsync>d__.<>t__builder.Start<LifePointModel.<LoadDataAsync>d__26>(ref <LoadDataAsync>d__);
			return <LoadDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A02C RID: 237612 RVA: 0x010515BF File Offset: 0x0104F7BF
		public void UnloadData()
		{
			this.Entity = null;
			this.Config = null;
			this.GridTextureMap.Clear();
			this.HitGridTextureMap.Clear();
			this.IsDataInit = false;
			this.AudioMap.Clear();
			this.BonusRules = null;
		}

		// Token: 0x0603A02D RID: 237613 RVA: 0x010515FE File Offset: 0x0104F7FE
		public void AddStep()
		{
			LevelGeneralNetworks.RequestEntitySendEvent(this.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId(), "LifePointPaint");
		}

		// Token: 0x0603A02E RID: 237614 RVA: 0x0105161C File Offset: 0x0104F81C
		public int GetStepBonus()
		{
			if (this.BonusRules == null)
			{
				return 0;
			}
			VarDefinePb entityVar = this.Entity.GetComponent<CreatureDataComponent>().GetEntityVar("染色次数");
			long? num = (entityVar != null) ? new long?(entityVar.Int) : null;
			if (num == null)
			{
				return 0;
			}
			long num2 = MathUtils.Instance.LongToNumber(num.Value);
			foreach (ILifePointMaxStepRewardRuleItem lifePointMaxStepRewardRuleItem in this.BonusRules)
			{
				if (num2 >= (long)lifePointMaxStepRewardRuleItem.PaintCount)
				{
					return lifePointMaxStepRewardRuleItem.AddStep;
				}
			}
			return 0;
		}

		// Token: 0x17006E7B RID: 28283
		// (get) Token: 0x0603A02F RID: 237615 RVA: 0x010516B2 File Offset: 0x0104F8B2
		public static LifePointModel Instance
		{
			get
			{
				return LifePointModel._Instance;
			}
		}

		// Token: 0x0603A030 RID: 237616 RVA: 0x010516B9 File Offset: 0x0104F8B9
		public static LifePointModel GetOrCreateInstance()
		{
			if (LifePointModel._Instance == null)
			{
				LifePointModel.CreateInstance();
			}
			return LifePointModel._Instance;
		}

		// Token: 0x0603A031 RID: 237617 RVA: 0x010516CD File Offset: 0x0104F8CD
		public static bool CreateInstance()
		{
			if (LifePointModel._Instance != null)
			{
				return true;
			}
			LifePointModel._Instance = new LifePointModel();
			return true;
		}

		// Token: 0x0603A032 RID: 237618 RVA: 0x010516E3 File Offset: 0x0104F8E3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A033 RID: 237619 RVA: 0x010516E5 File Offset: 0x0104F8E5
		public static void ResetStaticDefaultValue()
		{
			LifePointModel._Instance = null;
		}

		// Token: 0x0603A034 RID: 237620 RVA: 0x010516ED File Offset: 0x0104F8ED
		static LifePointModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LifePointModel.CreateStaticDefaultValue), new Action(LifePointModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EA97 RID: 125591
		public bool IsDataInit;

		// Token: 0x0401EA98 RID: 125592
		[Nullable(2)]
		public ILifePoint Config;

		// Token: 0x0401EA99 RID: 125593
		private readonly Dictionary<EPieceColorType, string[]> ColorMap = new Dictionary<EPieceColorType, string[]>();

		// Token: 0x0401EA9A RID: 125594
		public Dictionary<EPieceColorType, UTexture2D> GridTextureMap = new Dictionary<EPieceColorType, UTexture2D>();

		// Token: 0x0401EA9B RID: 125595
		public Dictionary<EPieceColorType, UTexture2D> HitGridTextureMap = new Dictionary<EPieceColorType, UTexture2D>();

		// Token: 0x0401EA9C RID: 125596
		public Dictionary<EDirection, float> DirectionParam = new Dictionary<EDirection, float>();

		// Token: 0x0401EA9D RID: 125597
		public FName ParamName = new FName("LocalFadeInoutRotate");

		// Token: 0x0401EA9E RID: 125598
		public FColor InitColor = FColor.FromHex("FFFF00FF");

		// Token: 0x0401EA9F RID: 125599
		public AnimParam AnimParam = new AnimParam();

		// Token: 0x0401EAA0 RID: 125600
		public string AudioEvent = "play_interact_life_point_click";

		// Token: 0x0401EAA1 RID: 125601
		public string RtpcCount = "mini_game_lifepoint_spreads_counting";

		// Token: 0x0401EAA2 RID: 125602
		public string RtpcGrids = "mini_game_lifepoint_spreading_grids";

		// Token: 0x0401EAA3 RID: 125603
		public string RtpcSpeed = "mini_game_lifepoint_spreading_speed";

		// Token: 0x0401EAA4 RID: 125604
		public Dictionary<int, float[]> AudioMap = new Dictionary<int, float[]>();

		// Token: 0x0401EAA5 RID: 125605
		public FColor DangerStepColor = FColor.FromHex("FF7D6EFF");

		// Token: 0x0401EAA6 RID: 125606
		public FColor NormalStepColor = FColor.FromHex("FFCB3FFF");

		// Token: 0x0401EAA7 RID: 125607
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x0401EAA8 RID: 125608
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ILifePointMaxStepRewardRuleItem[] BonusRules;

		// Token: 0x0401EAA9 RID: 125609
		[Nullable(2)]
		private static LifePointModel _Instance;
	}
}
