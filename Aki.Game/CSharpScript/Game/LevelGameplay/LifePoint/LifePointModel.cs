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
	// Token: 0x02006ACB RID: 27339
	[NullableContext(1)]
	[Nullable(0)]
	public class LifePointModel : ModelBase
	{
		// Token: 0x06043EDA RID: 278234 RVA: 0x010A7B46 File Offset: 0x010A5D46
		public string GetText(EPieceColorType color)
		{
			return this.ColorMap[color][4];
		}

		// Token: 0x06043EDB RID: 278235 RVA: 0x010A7B56 File Offset: 0x010A5D56
		public string GetColorHex(EPieceColorType color)
		{
			return this.ColorMap[color][0];
		}

		// Token: 0x06043EDC RID: 278236 RVA: 0x010A7B66 File Offset: 0x010A5D66
		public string GetFramePath(EPieceColorType color)
		{
			return this.ColorMap[color][1];
		}

		// Token: 0x06043EDD RID: 278237 RVA: 0x010A7B78 File Offset: 0x010A5D78
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

		// Token: 0x06043EDE RID: 278238 RVA: 0x010A7D74 File Offset: 0x010A5F74
		protected override bool OnClear()
		{
			this.ColorMap.Clear();
			this.GridTextureMap.Clear();
			this.HitGridTextureMap.Clear();
			this.DirectionParam.Clear();
			return true;
		}

		// Token: 0x06043EDF RID: 278239 RVA: 0x010A7DA3 File Offset: 0x010A5FA3
		public float CalcCountDownTime(int order)
		{
			return (float)((double)this.AnimParam.MaxTime * (-(float)Math.Exp((double)((float)(-(float)order) * this.AnimParam.AccelerationRes)) + 1.0) + (double)(this.AnimParam.MinInterval * (float)order));
		}

		// Token: 0x06043EE0 RID: 278240 RVA: 0x010A7DE4 File Offset: 0x010A5FE4
		public float CalPlayRate(float time)
		{
			return MathUtils.Instance.Clamp((this.AnimParam.GridMinRate + (this.AnimParam.GridMaxRate - this.AnimParam.GridMinRate) * time) / this.AnimParam.GridAccelerationTime, this.AnimParam.GridMinRate, this.AnimParam.GridMaxRate);
		}

		// Token: 0x06043EE1 RID: 278241 RVA: 0x010A7E44 File Offset: 0x010A6044
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

		// Token: 0x06043EE2 RID: 278242 RVA: 0x010A7EBC File Offset: 0x010A60BC
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

		// Token: 0x06043EE3 RID: 278243 RVA: 0x010A7F0F File Offset: 0x010A610F
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

		// Token: 0x06043EE4 RID: 278244 RVA: 0x010A7F4E File Offset: 0x010A614E
		public void AddStep()
		{
			LevelGeneralNetworks.RequestEntitySendEvent(this.Entity.GetComponent<CreatureDataComponent>().GetCreatureDataId(), "LifePointPaint");
		}

		// Token: 0x06043EE5 RID: 278245 RVA: 0x010A7F6C File Offset: 0x010A616C
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

		// Token: 0x17009978 RID: 39288
		// (get) Token: 0x06043EE6 RID: 278246 RVA: 0x010A8002 File Offset: 0x010A6202
		public static LifePointModel Instance
		{
			get
			{
				return LifePointModel._Instance;
			}
		}

		// Token: 0x06043EE7 RID: 278247 RVA: 0x010A8009 File Offset: 0x010A6209
		public static LifePointModel GetOrCreateInstance()
		{
			if (LifePointModel._Instance == null)
			{
				LifePointModel.CreateInstance();
			}
			return LifePointModel._Instance;
		}

		// Token: 0x06043EE8 RID: 278248 RVA: 0x010A801D File Offset: 0x010A621D
		public static bool CreateInstance()
		{
			if (LifePointModel._Instance != null)
			{
				return true;
			}
			LifePointModel._Instance = new LifePointModel();
			return true;
		}

		// Token: 0x06043EE9 RID: 278249 RVA: 0x010A8033 File Offset: 0x010A6233
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043EEA RID: 278250 RVA: 0x010A8035 File Offset: 0x010A6235
		public static void ResetStaticDefaultValue()
		{
			LifePointModel._Instance = null;
		}

		// Token: 0x06043EEB RID: 278251 RVA: 0x010A803D File Offset: 0x010A623D
		static LifePointModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LifePointModel.CreateStaticDefaultValue), new Action(LifePointModel.ResetStaticDefaultValue));
		}

		// Token: 0x040237F7 RID: 145399
		public bool IsDataInit;

		// Token: 0x040237F8 RID: 145400
		[Nullable(2)]
		public ILifePoint Config;

		// Token: 0x040237F9 RID: 145401
		private readonly Dictionary<EPieceColorType, string[]> ColorMap = new Dictionary<EPieceColorType, string[]>();

		// Token: 0x040237FA RID: 145402
		public Dictionary<EPieceColorType, UTexture2D> GridTextureMap = new Dictionary<EPieceColorType, UTexture2D>();

		// Token: 0x040237FB RID: 145403
		public Dictionary<EPieceColorType, UTexture2D> HitGridTextureMap = new Dictionary<EPieceColorType, UTexture2D>();

		// Token: 0x040237FC RID: 145404
		public Dictionary<EDirection, float> DirectionParam = new Dictionary<EDirection, float>();

		// Token: 0x040237FD RID: 145405
		public FName ParamName = new FName("LocalFadeInoutRotate");

		// Token: 0x040237FE RID: 145406
		public FColor InitColor = FColor.FromHex("FFFF00FF");

		// Token: 0x040237FF RID: 145407
		public AnimParam AnimParam = new AnimParam();

		// Token: 0x04023800 RID: 145408
		public string AudioEvent = "play_interact_life_point_click";

		// Token: 0x04023801 RID: 145409
		public string RtpcCount = "mini_game_lifepoint_spreads_counting";

		// Token: 0x04023802 RID: 145410
		public string RtpcGrids = "mini_game_lifepoint_spreading_grids";

		// Token: 0x04023803 RID: 145411
		public string RtpcSpeed = "mini_game_lifepoint_spreading_speed";

		// Token: 0x04023804 RID: 145412
		public Dictionary<int, float[]> AudioMap = new Dictionary<int, float[]>();

		// Token: 0x04023805 RID: 145413
		public FColor DangerStepColor = FColor.FromHex("FF7D6EFF");

		// Token: 0x04023806 RID: 145414
		public FColor NormalStepColor = FColor.FromHex("FFCB3FFF");

		// Token: 0x04023807 RID: 145415
		[Nullable(2)]
		private Entity Entity;

		// Token: 0x04023808 RID: 145416
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ILifePointMaxStepRewardRuleItem[] BonusRules;

		// Token: 0x04023809 RID: 145417
		[Nullable(2)]
		private static LifePointModel _Instance;
	}
}
