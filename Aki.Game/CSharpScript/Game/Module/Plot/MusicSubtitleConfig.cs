using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FA2 RID: 16290
	[NullableContext(1)]
	[Nullable(0)]
	public class MusicSubtitleConfig : ConfigBase
	{
		// Token: 0x06029350 RID: 168784 RVA: 0x00B922FC File Offset: 0x00B904FC
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06029351 RID: 168785 RVA: 0x00B922FF File Offset: 0x00B904FF
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06029352 RID: 168786 RVA: 0x00B92302 File Offset: 0x00B90502
		[return: Nullable(2)]
		public IReadOnlyList<MusicSubTitle> GetMusicSubtitle(string id)
		{
			return ConfigMusicSubTitleBySubtitleGroupTag.GetConfigList(id, true);
		}

		// Token: 0x1700536F RID: 21359
		// (get) Token: 0x06029353 RID: 168787 RVA: 0x00B9230B File Offset: 0x00B9050B
		public static MusicSubtitleConfig Instance
		{
			get
			{
				return MusicSubtitleConfig._Instance;
			}
		}

		// Token: 0x06029354 RID: 168788 RVA: 0x00B92312 File Offset: 0x00B90512
		public static MusicSubtitleConfig GetOrCreateInstance()
		{
			if (MusicSubtitleConfig._Instance == null)
			{
				MusicSubtitleConfig.CreateInstance();
			}
			return MusicSubtitleConfig._Instance;
		}

		// Token: 0x06029355 RID: 168789 RVA: 0x00B92326 File Offset: 0x00B90526
		public static bool CreateInstance()
		{
			if (MusicSubtitleConfig._Instance != null)
			{
				return true;
			}
			MusicSubtitleConfig._Instance = new MusicSubtitleConfig();
			return true;
		}

		// Token: 0x06029356 RID: 168790 RVA: 0x00B9233C File Offset: 0x00B9053C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06029357 RID: 168791 RVA: 0x00B9233E File Offset: 0x00B9053E
		public static void ResetStaticDefaultValue()
		{
			MusicSubtitleConfig._Instance = null;
		}

		// Token: 0x06029358 RID: 168792 RVA: 0x00B92346 File Offset: 0x00B90546
		static MusicSubtitleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicSubtitleConfig.CreateStaticDefaultValue), new Action(MusicSubtitleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040166F0 RID: 91888
		[Nullable(2)]
		private static MusicSubtitleConfig _Instance;
	}
}
