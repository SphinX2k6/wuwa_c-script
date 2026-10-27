using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FD8 RID: 20440
	[NullableContext(1)]
	[Nullable(0)]
	public class MusicSubtitleConfig : ConfigBase
	{
		// Token: 0x060344CB RID: 214219 RVA: 0x00C485A0 File Offset: 0x00C467A0
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x060344CC RID: 214220 RVA: 0x00C485A3 File Offset: 0x00C467A3
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x060344CD RID: 214221 RVA: 0x00C485A6 File Offset: 0x00C467A6
		[return: Nullable(2)]
		public IReadOnlyList<MusicSubTitle> GetMusicSubtitle(string id)
		{
			return ConfigMusicSubTitleBySubtitleGroupTag.GetConfigList(id, true);
		}

		// Token: 0x17007FBB RID: 32699
		// (get) Token: 0x060344CE RID: 214222 RVA: 0x00C485AF File Offset: 0x00C467AF
		public static MusicSubtitleConfig Instance
		{
			get
			{
				return MusicSubtitleConfig._Instance;
			}
		}

		// Token: 0x060344CF RID: 214223 RVA: 0x00C485B6 File Offset: 0x00C467B6
		public static MusicSubtitleConfig GetOrCreateInstance()
		{
			if (MusicSubtitleConfig._Instance == null)
			{
				MusicSubtitleConfig.CreateInstance();
			}
			return MusicSubtitleConfig._Instance;
		}

		// Token: 0x060344D0 RID: 214224 RVA: 0x00C485CA File Offset: 0x00C467CA
		public static bool CreateInstance()
		{
			if (MusicSubtitleConfig._Instance != null)
			{
				return true;
			}
			MusicSubtitleConfig._Instance = new MusicSubtitleConfig();
			return true;
		}

		// Token: 0x060344D1 RID: 214225 RVA: 0x00C485E0 File Offset: 0x00C467E0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060344D2 RID: 214226 RVA: 0x00C485E2 File Offset: 0x00C467E2
		public static void ResetStaticDefaultValue()
		{
			MusicSubtitleConfig._Instance = null;
		}

		// Token: 0x060344D3 RID: 214227 RVA: 0x00C485EA File Offset: 0x00C467EA
		static MusicSubtitleConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicSubtitleConfig.CreateStaticDefaultValue), new Action(MusicSubtitleConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401BD15 RID: 113941
		[Nullable(2)]
		private static MusicSubtitleConfig _Instance;
	}
}
