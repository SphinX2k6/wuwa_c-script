using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Common
{
	// Token: 0x02004B25 RID: 19237
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class AudioConfig : ConfigBase
	{
		// Token: 0x060301EA RID: 197098 RVA: 0x00D6BCD3 File Offset: 0x00D69ED3
		public Audio? GetAudioPath(string name)
		{
			return ConfigAudioById.GetConfig(name, true);
		}

		// Token: 0x060301EB RID: 197099 RVA: 0x00D6BCDC File Offset: 0x00D69EDC
		public MapAudio? GetMapConfig(int mapId)
		{
			return ConfigMapAudioById.GetConfig(mapId, true);
		}

		// Token: 0x060301EC RID: 197100 RVA: 0x00D6BCE5 File Offset: 0x00D69EE5
		public RoleSkinAudio? GetRoleConfig(int roleId)
		{
			return ConfigRoleSkinAudioById.GetConfig(roleId, true);
		}

		// Token: 0x060301ED RID: 197101 RVA: 0x00D6BCF0 File Offset: 0x00D69EF0
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

		// Token: 0x17006075 RID: 24693
		// (get) Token: 0x060301EE RID: 197102 RVA: 0x00D6BD80 File Offset: 0x00D69F80
		public static AudioConfig Instance
		{
			get
			{
				return AudioConfig._Instance;
			}
		}

		// Token: 0x060301EF RID: 197103 RVA: 0x00D6BD87 File Offset: 0x00D69F87
		public static AudioConfig GetOrCreateInstance()
		{
			if (AudioConfig._Instance == null)
			{
				AudioConfig.CreateInstance();
			}
			return AudioConfig._Instance;
		}

		// Token: 0x060301F0 RID: 197104 RVA: 0x00D6BD9B File Offset: 0x00D69F9B
		public static bool CreateInstance()
		{
			if (AudioConfig._Instance != null)
			{
				return true;
			}
			AudioConfig._Instance = new AudioConfig();
			return true;
		}

		// Token: 0x060301F1 RID: 197105 RVA: 0x00D6BDB1 File Offset: 0x00D69FB1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060301F2 RID: 197106 RVA: 0x00D6BDB3 File Offset: 0x00D69FB3
		public static void ResetStaticDefaultValue()
		{
			AudioConfig._Instance = null;
		}

		// Token: 0x060301F3 RID: 197107 RVA: 0x00D6BDBB File Offset: 0x00D69FBB
		static AudioConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AudioConfig.CreateStaticDefaultValue), new Action(AudioConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401980F RID: 104463
		[Nullable(2)]
		private List<int> RoleInfoAudioList;

		// Token: 0x04019810 RID: 104464
		[Nullable(2)]
		private static AudioConfig _Instance;
	}
}
