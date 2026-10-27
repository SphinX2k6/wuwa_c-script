using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A77 RID: 2679
	public class ConfigVideoSoundByCgNameAndGirlOrBoy : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EDE RID: 16094 RVA: 0x001BD881 File Offset: 0x001BBA81
		static ConfigVideoSoundByCgNameAndGirlOrBoy()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoSoundByCgNameAndGirlOrBoy.CreateStaticDefaultValue), new Action(ConfigVideoSoundByCgNameAndGirlOrBoy.ResetStaticDefaultValue));
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x001BD8A0 File Offset: 0x001BBAA0
		public static void CreateStaticDefaultValue()
		{
			ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cgvedio.db"),
				new ValueTuple<string, object>("文件", "g.过场cg.xlsx"),
				new ValueTuple<string, object>("表名", "VideoSound"),
				new ValueTuple<string, object>("语句", "select BinData from `VideoSound` where CgName=? AND GirlOrBoy=?")
			});
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x001BD91F File Offset: 0x001BBB1F
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair = null;
			ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId = 0;
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x001BD92D File Offset: 0x001BBB2D
		public static void Init()
		{
			ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId = ConfigCommon.InitDataStatement(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, "db_cgvedio.db", "select BinData from `VideoSound` where CgName=? AND GirlOrBoy=?");
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x001BD948 File Offset: 0x001BBB48
		[return: Nullable(2)]
		public static IReadOnlyList<VideoSound> GetConfigList(string p0CgName, int p1GirlOrBoy, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("VideoSoundByCgNameAndGirlOrBoy");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0CgName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GirlOrBoy);
				IReadOnlyList<VideoSound> readOnlyList = (IReadOnlyList<VideoSound>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair.Clear();
			ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair.Add(new ValueTuple<string, object>("CgName", p0CgName));
			ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair.Add(new ValueTuple<string, object>("GirlOrBoy", p1GirlOrBoy));
			if (!ConfigCommon.BindString(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, 1, p0CgName, ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair) || !ConfigCommon.BindInt(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, 2, p1GirlOrBoy, ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair))
			{
				ConfigCommon.Reset(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair);
				return null;
			}
			List<VideoSound> list = new List<VideoSound>();
			while (ConfigCommon.Step(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, false, ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, 0, ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair);
					return null;
				}
				VideoSound rootAsVideoSound = VideoSound.GetRootAsVideoSound(new ByteBuffer(item2));
				list.Add(rootAsVideoSound);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("VideoSoundByCgNameAndGirlOrBoy");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0CgName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GirlOrBoy);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair);
			return list;
		}

		// Token: 0x04004927 RID: 18727
		private const string DB = "db_cgvedio.db";

		// Token: 0x04004928 RID: 18728
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x04004929 RID: 18729
		private const string TABLE = "VideoSound";

		// Token: 0x0400492A RID: 18730
		private const string COMMAND = "select BinData from `VideoSound` where CgName=? AND GirlOrBoy=?";

		// Token: 0x0400492B RID: 18731
		private const string KEY_PREFIX = "VideoSoundByCgNameAndGirlOrBoy";

		// Token: 0x0400492C RID: 18732
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400492D RID: 18733
		private static int HandleId;
	}
}
