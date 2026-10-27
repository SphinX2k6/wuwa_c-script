using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SubLevelLoading
{
	// Token: 0x02004B76 RID: 19318
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class SubLevelLoadingModel : ModelBase
	{
		// Token: 0x17007C2B RID: 31787
		// (get) Token: 0x060320D4 RID: 205012 RVA: 0x00B9F05D File Offset: 0x00B9D25D
		// (set) Token: 0x060320D5 RID: 205013 RVA: 0x00B9F065 File Offset: 0x00B9D265
		public EScreenEffectType ScreenEffect
		{
			get
			{
				return this.ScreenEffectInternal;
			}
			set
			{
				this.ScreenEffectInternal = value;
			}
		}

		// Token: 0x17007C2C RID: 31788
		// (get) Token: 0x060320D7 RID: 205015 RVA: 0x00B9F077 File Offset: 0x00B9D277
		// (set) Token: 0x060320D6 RID: 205014 RVA: 0x00B9F06E File Offset: 0x00B9D26E
		public GameModePromise LoadSubLevelPromise
		{
			get
			{
				return this.LoadSubLevelPromiseInternal;
			}
			set
			{
				this.LoadSubLevelPromiseInternal = value;
			}
		}

		// Token: 0x060320D8 RID: 205016 RVA: 0x00B9F07F File Offset: 0x00B9D27F
		protected override bool OnLeaveLevel()
		{
			return true;
		}

		// Token: 0x060320D9 RID: 205017 RVA: 0x00B9F082 File Offset: 0x00B9D282
		protected override bool OnClear()
		{
			this.ScreenEffectInternal = EScreenEffectType.ScreenEffectNone;
			LoadingModel.Instance.ScreenEffect = new EScreenEffectType?(EScreenEffectType.ScreenEffectNone);
			this.LoadSubLevelPromiseInternal = null;
			return true;
		}

		// Token: 0x17007C2D RID: 31789
		// (get) Token: 0x060320DA RID: 205018 RVA: 0x00B9F0A3 File Offset: 0x00B9D2A3
		[Nullable(1)]
		public static SubLevelLoadingModel Instance
		{
			[NullableContext(1)]
			get
			{
				return SubLevelLoadingModel._Instance;
			}
		}

		// Token: 0x060320DB RID: 205019 RVA: 0x00B9F0AA File Offset: 0x00B9D2AA
		[NullableContext(1)]
		public static SubLevelLoadingModel GetOrCreateInstance()
		{
			if (SubLevelLoadingModel._Instance == null)
			{
				SubLevelLoadingModel.CreateInstance();
			}
			return SubLevelLoadingModel._Instance;
		}

		// Token: 0x060320DC RID: 205020 RVA: 0x00B9F0BE File Offset: 0x00B9D2BE
		public static bool CreateInstance()
		{
			if (SubLevelLoadingModel._Instance != null)
			{
				return true;
			}
			SubLevelLoadingModel._Instance = new SubLevelLoadingModel();
			return true;
		}

		// Token: 0x060320DD RID: 205021 RVA: 0x00B9F0D4 File Offset: 0x00B9D2D4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060320DE RID: 205022 RVA: 0x00B9F0D6 File Offset: 0x00B9D2D6
		public static void ResetStaticDefaultValue()
		{
			SubLevelLoadingModel._Instance = null;
		}

		// Token: 0x060320DF RID: 205023 RVA: 0x00B9F0DE File Offset: 0x00B9D2DE
		static SubLevelLoadingModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SubLevelLoadingModel.CreateStaticDefaultValue), new Action(SubLevelLoadingModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401AAC0 RID: 109248
		private EScreenEffectType ScreenEffectInternal;

		// Token: 0x0401AAC1 RID: 109249
		private GameModePromise LoadSubLevelPromiseInternal;

		// Token: 0x0401AAC2 RID: 109250
		private static SubLevelLoadingModel _Instance;
	}
}
