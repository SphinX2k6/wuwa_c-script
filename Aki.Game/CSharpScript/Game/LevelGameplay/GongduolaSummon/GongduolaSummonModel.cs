using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.SummonGongduola;

namespace CSharpScript.Game.LevelGamePlay.GongduolaSummon
{
	// Token: 0x02005FA1 RID: 24481
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GongduolaSummonModel : ModelBase
	{
		// Token: 0x0603AD22 RID: 240930 RVA: 0x010A163B File Offset: 0x0109F83B
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

		// Token: 0x17006F01 RID: 28417
		// (get) Token: 0x0603AD23 RID: 240931 RVA: 0x010A1662 File Offset: 0x0109F862
		public static GongduolaSummonModel Instance
		{
			get
			{
				return GongduolaSummonModel._Instance;
			}
		}

		// Token: 0x0603AD24 RID: 240932 RVA: 0x010A1669 File Offset: 0x0109F869
		public static GongduolaSummonModel GetOrCreateInstance()
		{
			if (GongduolaSummonModel._Instance == null)
			{
				GongduolaSummonModel.CreateInstance();
			}
			return GongduolaSummonModel._Instance;
		}

		// Token: 0x0603AD25 RID: 240933 RVA: 0x010A167D File Offset: 0x0109F87D
		public static bool CreateInstance()
		{
			if (GongduolaSummonModel._Instance != null)
			{
				return true;
			}
			GongduolaSummonModel._Instance = new GongduolaSummonModel();
			return true;
		}

		// Token: 0x0603AD26 RID: 240934 RVA: 0x010A1693 File Offset: 0x0109F893
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AD27 RID: 240935 RVA: 0x010A1695 File Offset: 0x0109F895
		public static void ResetStaticDefaultValue()
		{
			GongduolaSummonModel._Instance = null;
		}

		// Token: 0x0603AD28 RID: 240936 RVA: 0x010A169D File Offset: 0x0109F89D
		static GongduolaSummonModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GongduolaSummonModel.CreateStaticDefaultValue), new Action(GongduolaSummonModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EEB1 RID: 126641
		public readonly string CancelSummonAmPath = "/Game/Aki/Character/NPC/AlienNPC/Level_B/SB1Gongduola3/BaseAnim/AM_CancelSummon.AM_CancelSummon";

		// Token: 0x0401EEB2 RID: 126642
		public readonly string SummonAmPath = "/Game/Aki/Character/NPC/AlienNPC/Level_B/SB1Gongduola3/BaseAnim/AM_Summon.AM_Summon";

		// Token: 0x0401EEB3 RID: 126643
		private readonly string ConfigDaPath = "/Game/Aki/Data/Level/SummonGongduola/DA_SummonGongduolaConfig.DA_SummonGongduolaConfig";

		// Token: 0x0401EEB4 RID: 126644
		[Nullable(2)]
		public BaseActorComponent SummonedActorComp;

		// Token: 0x0401EEB5 RID: 126645
		[Nullable(2)]
		public Vector SummonLocation;

		// Token: 0x0401EEB6 RID: 126646
		[Nullable(2)]
		public Rotator SummonRotation;

		// Token: 0x0401EEB7 RID: 126647
		[Nullable(2)]
		public Vector SummonGravityDir;

		// Token: 0x0401EEB8 RID: 126648
		[Nullable(2)]
		public BP_SummonGongduolaConfig_C SummonConfig;

		// Token: 0x0401EEB9 RID: 126649
		public readonly string BanInputReason = "SummonGongduola Ban Input";

		// Token: 0x0401EEBA RID: 126650
		public bool IsLoaded;

		// Token: 0x0401EEBB RID: 126651
		[Nullable(2)]
		private static GongduolaSummonModel _Instance;
	}
}
