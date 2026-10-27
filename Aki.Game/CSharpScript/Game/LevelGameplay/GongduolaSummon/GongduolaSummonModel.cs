using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.SummonGongduola;

namespace CSharpScript.Game.LevelGamePlay.GongduolaSummon
{
	// Token: 0x02006E21 RID: 28193
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GongduolaSummonModel : ModelBase
	{
		// Token: 0x06044BB9 RID: 281529 RVA: 0x010F70FF File Offset: 0x010F52FF
		protected override bool OnInit()
		{
			ResourceSystem.Instance.LoadAsync<BP_SummonGongduolaConfig_C>(this.ConfigDaPath, delegate([Nullable(2)] BP_SummonGongduolaConfig_C result, string _)
			{
				if (result == null || !result.IsValid())
				{
					Log.Instance.Error(ELogModule.SummonGongduola, ELogAuthor.CH, "[GongduolaSummonModel] Load Config DA Failed", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.SummonConfig = result;
				this.IsLoaded = true;
			}, 100, "js_undefined");
			return true;
		}

		// Token: 0x170099FE RID: 39422
		// (get) Token: 0x06044BBA RID: 281530 RVA: 0x010F7126 File Offset: 0x010F5326
		public static GongduolaSummonModel Instance
		{
			get
			{
				return GongduolaSummonModel._Instance;
			}
		}

		// Token: 0x06044BBB RID: 281531 RVA: 0x010F712D File Offset: 0x010F532D
		public static GongduolaSummonModel GetOrCreateInstance()
		{
			if (GongduolaSummonModel._Instance == null)
			{
				GongduolaSummonModel.CreateInstance();
			}
			return GongduolaSummonModel._Instance;
		}

		// Token: 0x06044BBC RID: 281532 RVA: 0x010F7141 File Offset: 0x010F5341
		public static bool CreateInstance()
		{
			if (GongduolaSummonModel._Instance != null)
			{
				return true;
			}
			GongduolaSummonModel._Instance = new GongduolaSummonModel();
			return true;
		}

		// Token: 0x06044BBD RID: 281533 RVA: 0x010F7157 File Offset: 0x010F5357
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044BBE RID: 281534 RVA: 0x010F7159 File Offset: 0x010F5359
		public static void ResetStaticDefaultValue()
		{
			GongduolaSummonModel._Instance = null;
		}

		// Token: 0x06044BBF RID: 281535 RVA: 0x010F7161 File Offset: 0x010F5361
		static GongduolaSummonModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GongduolaSummonModel.CreateStaticDefaultValue), new Action(GongduolaSummonModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023C0E RID: 146446
		public readonly string CancelSummonAmPath = "/Game/Aki/Character/NPC/AlienNPC/Level_B/SB1Gongduola3/BaseAnim/AM_CancelSummon.AM_CancelSummon";

		// Token: 0x04023C0F RID: 146447
		public readonly string SummonAmPath = "/Game/Aki/Character/NPC/AlienNPC/Level_B/SB1Gongduola3/BaseAnim/AM_Summon.AM_Summon";

		// Token: 0x04023C10 RID: 146448
		private readonly string ConfigDaPath = "/Game/Aki/Data/Level/SummonGongduola/DA_SummonGongduolaConfig.DA_SummonGongduolaConfig";

		// Token: 0x04023C11 RID: 146449
		[Nullable(2)]
		public BaseActorComponent SummonedActorComp;

		// Token: 0x04023C12 RID: 146450
		[Nullable(2)]
		public Vector SummonLocation;

		// Token: 0x04023C13 RID: 146451
		[Nullable(2)]
		public Rotator SummonRotation;

		// Token: 0x04023C14 RID: 146452
		[Nullable(2)]
		public Vector SummonGravityDir;

		// Token: 0x04023C15 RID: 146453
		[Nullable(2)]
		public BP_SummonGongduolaConfig_C SummonConfig;

		// Token: 0x04023C16 RID: 146454
		public readonly string BanInputReason = "SummonGongduola Ban Input";

		// Token: 0x04023C17 RID: 146455
		public bool IsLoaded;

		// Token: 0x04023C18 RID: 146456
		[Nullable(2)]
		private static GongduolaSummonModel _Instance;
	}
}
