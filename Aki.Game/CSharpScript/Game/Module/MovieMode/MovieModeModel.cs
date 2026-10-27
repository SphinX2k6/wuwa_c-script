using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200538D RID: 21389
	[NullableContext(1)]
	[Nullable(0)]
	public class MovieModeModel : ModelBase
	{
		// Token: 0x06036A37 RID: 223799 RVA: 0x00CEE907 File Offset: 0x00CECB07
		protected override bool OnInit()
		{
			this.InitParameters();
			return true;
		}

		// Token: 0x06036A38 RID: 223800 RVA: 0x00CEE910 File Offset: 0x00CECB10
		private void InitParameters()
		{
			this.MovieModeHideUiTimeThreshold = ConfigCommonParamById.GetIntConfig("MovieModeHideUiTimeThreshold").GetValueOrDefault(1);
			this.MovieModeHideUiTimeThreshold *= 1000;
		}

		// Token: 0x06036A39 RID: 223801 RVA: 0x00CEE948 File Offset: 0x00CECB48
		public void FreezeUi(string reason)
		{
			this.FreezeReason.Add(reason);
		}

		// Token: 0x06036A3A RID: 223802 RVA: 0x00CEE957 File Offset: 0x00CECB57
		public void UnFreezeUi(string reason)
		{
			this.FreezeReason.Remove(reason);
		}

		// Token: 0x1700839F RID: 33695
		// (get) Token: 0x06036A3B RID: 223803 RVA: 0x00CEE966 File Offset: 0x00CECB66
		public bool IsFreezingUi
		{
			get
			{
				return this.FreezeReason.Count > 0;
			}
		}

		// Token: 0x06036A3C RID: 223804 RVA: 0x00CEE976 File Offset: 0x00CECB76
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x170083A0 RID: 33696
		// (get) Token: 0x06036A3D RID: 223805 RVA: 0x00CEE979 File Offset: 0x00CECB79
		public static MovieModeModel Instance
		{
			get
			{
				return MovieModeModel._Instance;
			}
		}

		// Token: 0x06036A3E RID: 223806 RVA: 0x00CEE980 File Offset: 0x00CECB80
		public static MovieModeModel GetOrCreateInstance()
		{
			if (MovieModeModel._Instance == null)
			{
				MovieModeModel.CreateInstance();
			}
			return MovieModeModel._Instance;
		}

		// Token: 0x06036A3F RID: 223807 RVA: 0x00CEE994 File Offset: 0x00CECB94
		public static bool CreateInstance()
		{
			if (MovieModeModel._Instance != null)
			{
				return true;
			}
			MovieModeModel._Instance = new MovieModeModel();
			return true;
		}

		// Token: 0x06036A40 RID: 223808 RVA: 0x00CEE9AA File Offset: 0x00CECBAA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036A41 RID: 223809 RVA: 0x00CEE9AC File Offset: 0x00CECBAC
		public static void ResetStaticDefaultValue()
		{
			MovieModeModel._Instance = null;
		}

		// Token: 0x06036A42 RID: 223810 RVA: 0x00CEE9B4 File Offset: 0x00CECBB4
		static MovieModeModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MovieModeModel.CreateStaticDefaultValue), new Action(MovieModeModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401CDF5 RID: 118261
		public int MovieModeHideUiTimeThreshold;

		// Token: 0x0401CDF6 RID: 118262
		private readonly HashSet<string> FreezeReason = new HashSet<string>();

		// Token: 0x0401CDF7 RID: 118263
		[Nullable(2)]
		private static MovieModeModel _Instance;
	}
}
