using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02005B44 RID: 23364
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class AudioConfig : ConfigBase
	{
		// Token: 0x0603B278 RID: 242296 RVA: 0x00E1B033 File Offset: 0x00E19233
		public Audio? GetAudioPath(string name)
		{
			return ConfigAudioById.GetConfig(name, true);
		}

		// Token: 0x0603B279 RID: 242297 RVA: 0x00E1B03C File Offset: 0x00E1923C
		public MapAudio? GetMapConfig(int mapId)
		{
			return ConfigMapAudioById.GetConfig(mapId, true);
		}

		// Token: 0x0603B27A RID: 242298 RVA: 0x00E1B045 File Offset: 0x00E19245
		public RoleSkinAudio? GetRoleConfig(int roleId)
		{
			return ConfigRoleSkinAudioById.GetConfig(roleId, true);
		}

		// Token: 0x0603B27B RID: 242299 RVA: 0x00E1B050 File Offset: 0x00E19250
		public RoleInfoAudio? GetRoleInfoConfig(int roleId)
		{
			if (this.RoleInfoAudioList == null)
			{
				this.RoleInfoAudioList = new List<int>();
				IReadOnlyList<RoleInfoAudio> configList = ConfigRoleInfoAudioAll.GetConfigList(true);
				if (configList != null)
				{
					foreach (RoleInfoAudio roleInfoAudio in configList)
					{
						this.RoleInfoAudioList.Add(roleInfoAudio.RoleId);
					}
				}
			}
			if (this.RoleInfoAudioList.Contains(roleId))
			{
				return ConfigRoleInfoAudioByRoleId.GetConfig(roleId, true);
			}
			return null;
		}

		// Token: 0x17008C9B RID: 35995
		// (get) Token: 0x0603B27C RID: 242300 RVA: 0x00E1B0E0 File Offset: 0x00E192E0
		public static AudioConfig Instance
		{
			get
			{
				return AudioConfig._Instance;
			}
		}

		// Token: 0x0603B27D RID: 242301 RVA: 0x00E1B0E7 File Offset: 0x00E192E7
		public static AudioConfig GetOrCreateInstance()
		{
			if (AudioConfig._Instance == null)
			{
				AudioConfig.CreateInstance();
			}
			return AudioConfig._Instance;
		}

		// Token: 0x0603B27E RID: 242302 RVA: 0x00E1B0FB File Offset: 0x00E192FB
		public static bool CreateInstance()
		{
			if (AudioConfig._Instance != null)
			{
				return true;
			}
			AudioConfig._Instance = new AudioConfig();
			return true;
		}

		// Token: 0x0603B27F RID: 242303 RVA: 0x00E1B111 File Offset: 0x00E19311
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B280 RID: 242304 RVA: 0x00E1B113 File Offset: 0x00E19313
		public static void ResetStaticDefaultValue()
		{
			AudioConfig._Instance = null;
		}

		// Token: 0x0603B281 RID: 242305 RVA: 0x00E1B11B File Offset: 0x00E1931B
		static AudioConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AudioConfig.CreateStaticDefaultValue), new Action(AudioConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401ED53 RID: 126291
		[Nullable(2)]
		private List<int> RoleInfoAudioList;

		// Token: 0x0401ED54 RID: 126292
		[Nullable(2)]
		private static AudioConfig _Instance;
	}
}
