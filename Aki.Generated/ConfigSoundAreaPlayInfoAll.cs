using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000964 RID: 2404
	public class ConfigSoundAreaPlayInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600386C RID: 14444 RVA: 0x00198949 File Offset: 0x00196B49
		static ConfigSoundAreaPlayInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoundAreaPlayInfoAll.CreateStaticDefaultValue), new Action(ConfigSoundAreaPlayInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x00198968 File Offset: 0x00196B68
		public static void CreateStaticDefaultValue()
		{
			ConfigSoundAreaPlayInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSoundAreaPlayInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_soundareaplayinfo.db"),
				new ValueTuple<string, object>("文件", "w.无音区玩法信息.xlsx"),
				new ValueTuple<string, object>("表名", "SoundAreaPlayInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `SoundAreaPlayInfo`")
			});
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x001989E7 File Offset: 0x00196BE7
		public static void ResetStaticDefaultValue()
		{
			ConfigSoundAreaPlayInfoAll.LogPair = null;
			ConfigSoundAreaPlayInfoAll.HandleId = 0;
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x001989F5 File Offset: 0x00196BF5
		public static void Init()
		{
			ConfigSoundAreaPlayInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigSoundAreaPlayInfoAll.HandleId, "db_soundareaplayinfo.db", "select BinData from `SoundAreaPlayInfo`");
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00198A10 File Offset: 0x00196C10
		[NullableContext(2)]
		public static IReadOnlyList<SoundAreaPlayInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSoundAreaPlayInfoAll.HandleId, ConfigSoundAreaPlayInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SoundAreaPlayInfo> readOnlyList = (IReadOnlyList<SoundAreaPlayInfo>)ConfigCommon.GetConfig("SoundAreaPlayInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SoundAreaPlayInfo> list = new List<SoundAreaPlayInfo>();
			while (ConfigCommon.Step(ConfigSoundAreaPlayInfoAll.HandleId, false, ConfigSoundAreaPlayInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSoundAreaPlayInfoAll.HandleId, 0, ConfigSoundAreaPlayInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSoundAreaPlayInfoAll.HandleId, ConfigSoundAreaPlayInfoAll.LogPair);
					return null;
				}
				SoundAreaPlayInfo rootAsSoundAreaPlayInfo = SoundAreaPlayInfo.GetRootAsSoundAreaPlayInfo(new ByteBuffer(item2));
				list.Add(rootAsSoundAreaPlayInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SoundAreaPlayInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSoundAreaPlayInfoAll.HandleId, ConfigSoundAreaPlayInfoAll.LogPair);
			return list;
		}

		// Token: 0x040041A2 RID: 16802
		private const string DB = "db_soundareaplayinfo.db";

		// Token: 0x040041A3 RID: 16803
		private const string FILE = "w.无音区玩法信息.xlsx";

		// Token: 0x040041A4 RID: 16804
		private const string TABLE = "SoundAreaPlayInfo";

		// Token: 0x040041A5 RID: 16805
		private const string COMMAND = "select BinData from `SoundAreaPlayInfo`";

		// Token: 0x040041A6 RID: 16806
		private const string KEY_PREFIX = "SoundAreaPlayInfoAll";

		// Token: 0x040041A7 RID: 16807
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041A8 RID: 16808
		private static int HandleId;
	}
}
