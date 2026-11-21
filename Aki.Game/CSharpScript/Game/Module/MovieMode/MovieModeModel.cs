using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004370 RID: 17264
	[NullableContext(1)]
	[Nullable(0)]
	public class MovieModeModel : ModelBase
	{
		// Token: 0x0602B97D RID: 178557 RVA: 0x00C3D82F File Offset: 0x00C3BA2F
		protected override bool OnInit()
		{
			this.InitParameters();
			return true;
		}

		// Token: 0x0602B97E RID: 178558 RVA: 0x00C3D838 File Offset: 0x00C3BA38
		private void InitParameters()
		{
			this.MovieModeHideUiTimeThreshold = ConfigCommonParamById.GetIntConfig("MovieModeHideUiTimeThreshold").GetValueOrDefault(1);
			this.MovieModeHideUiTimeThreshold *= 1000;
		}

		// Token: 0x0602B97F RID: 178559 RVA: 0x00C3D870 File Offset: 0x00C3BA70
		public void FreezeUi(string reason)
		{
			this.FreezeReason.Add(reason);
		}

		// Token: 0x0602B980 RID: 178560 RVA: 0x00C3D87F File Offset: 0x00C3BA7F
		public void UnFreezeUi(string reason)
		{
			this.FreezeReason.Remove(reason);
		}

		// Token: 0x1700576B RID: 22379
		// (get) Token: 0x0602B981 RID: 178561 RVA: 0x00C3D88E File Offset: 0x00C3BA8E
		public bool IsFreezingUi
		{
			get
			{
				return this.FreezeReason.Count > 0;
			}
		}

		// Token: 0x0602B982 RID: 178562 RVA: 0x00C3D89E File Offset: 0x00C3BA9E
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x1700576C RID: 22380
		// (get) Token: 0x0602B983 RID: 178563 RVA: 0x00C3D8A1 File Offset: 0x00C3BAA1
		public static MovieModeModel Instance
		{
			get
			{
				return MovieModeModel._Instance;
			}
		}

		// Token: 0x0602B984 RID: 178564 RVA: 0x00C3D8A8 File Offset: 0x00C3BAA8
		public static MovieModeModel GetOrCreateInstance()
		{
			if (MovieModeModel._Instance == null)
			{
				MovieModeModel.CreateInstance();
			}
			return MovieModeModel._Instance;
		}

		// Token: 0x0602B985 RID: 178565 RVA: 0x00C3D8BC File Offset: 0x00C3BABC
		public static bool CreateInstance()
		{
			if (MovieModeModel._Instance != null)
			{
				return true;
			}
			MovieModeModel._Instance = new MovieModeModel();
			return true;
		}

		// Token: 0x0602B986 RID: 178566 RVA: 0x00C3D8D2 File Offset: 0x00C3BAD2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602B987 RID: 178567 RVA: 0x00C3D8D4 File Offset: 0x00C3BAD4
		public static void ResetStaticDefaultValue()
		{
			MovieModeModel._Instance = null;
		}

		// Token: 0x0602B988 RID: 178568 RVA: 0x00C3D8DC File Offset: 0x00C3BADC
		static MovieModeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MovieModeModel.CreateStaticDefaultValue), new Action(MovieModeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401788D RID: 96397
		public int MovieModeHideUiTimeThreshold;

		// Token: 0x0401788E RID: 96398
		private readonly HashSet<string> FreezeReason = new HashSet<string>();

		// Token: 0x0401788F RID: 96399
		[Nullable(2)]
		private static MovieModeModel _Instance;
	}
}
