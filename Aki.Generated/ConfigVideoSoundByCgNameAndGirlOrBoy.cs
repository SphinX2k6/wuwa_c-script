using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4C RID: 2892
	public class ConfigVideoSoundByCgNameAndGirlOrBoy : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043DC RID: 17372 RVA: 0x001DCC15 File Offset: 0x001DAE15
		static ConfigVideoSoundByCgNameAndGirlOrBoy()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoSoundByCgNameAndGirlOrBoy.CreateStaticDefaultValue), new Action(ConfigVideoSoundByCgNameAndGirlOrBoy.ResetStaticDefaultValue));
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x001DCC34 File Offset: 0x001DAE34
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

		// Token: 0x060043DE RID: 17374 RVA: 0x001DCCB3 File Offset: 0x001DAEB3
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoSoundByCgNameAndGirlOrBoy.LogPair = null;
			ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId = 0;
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x001DCCC1 File Offset: 0x001DAEC1
		public static void Init()
		{
			ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId = ConfigCommon.InitDataStatement(ConfigVideoSoundByCgNameAndGirlOrBoy.HandleId, "db_cgvedio.db", "select BinData from `VideoSound` where CgName=? AND GirlOrBoy=?");
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x001DCCDC File Offset: 0x001DAEDC
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

		// Token: 0x04004EFA RID: 20218
		private const string DB = "db_cgvedio.db";

		// Token: 0x04004EFB RID: 20219
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x04004EFC RID: 20220
		private const string TABLE = "VideoSound";

		// Token: 0x04004EFD RID: 20221
		private const string COMMAND = "select BinData from `VideoSound` where CgName=? AND GirlOrBoy=?";

		// Token: 0x04004EFE RID: 20222
		private const string KEY_PREFIX = "VideoSoundByCgNameAndGirlOrBoy";

		// Token: 0x04004EFF RID: 20223
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F00 RID: 20224
		private static int HandleId;
	}
}
