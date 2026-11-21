using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4A RID: 2890
	public class ConfigVideoDataByCgNameAndGirlOrBoy : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043D0 RID: 17360 RVA: 0x001DC797 File Offset: 0x001DA997
		static ConfigVideoDataByCgNameAndGirlOrBoy()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoDataByCgNameAndGirlOrBoy.CreateStaticDefaultValue), new Action(ConfigVideoDataByCgNameAndGirlOrBoy.ResetStaticDefaultValue));
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x001DC7B8 File Offset: 0x001DA9B8
		public static void CreateStaticDefaultValue()
		{
			ConfigVideoDataByCgNameAndGirlOrBoy.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigVideoDataByCgNameAndGirlOrBoy.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cgvedio.db"),
				new ValueTuple<string, object>("文件", "g.过场cg.xlsx"),
				new ValueTuple<string, object>("表名", "VideoData"),
				new ValueTuple<string, object>("语句", "select BinData from `VideoData` where CgName=? AND GirlOrBoy=?")
			});
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x001DC837 File Offset: 0x001DAA37
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoDataByCgNameAndGirlOrBoy.LogPair = null;
			ConfigVideoDataByCgNameAndGirlOrBoy.HandleId = 0;
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x001DC845 File Offset: 0x001DAA45
		public static void Init()
		{
			ConfigVideoDataByCgNameAndGirlOrBoy.HandleId = ConfigCommon.InitDataStatement(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, "db_cgvedio.db", "select BinData from `VideoData` where CgName=? AND GirlOrBoy=?");
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x001DC860 File Offset: 0x001DAA60
		public static VideoData? GetConfig(string p0CgName, int p1GirlOrBoy, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, ConfigVideoDataByCgNameAndGirlOrBoy.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("VideoDataByCgNameAndGirlOrBoy");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0CgName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GirlOrBoy);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new VideoData?(VideoData.GetRootAsVideoData(configBuffer));
				}
			}
			ConfigVideoDataByCgNameAndGirlOrBoy.LogPair.Clear();
			ConfigVideoDataByCgNameAndGirlOrBoy.LogPair.Add(new ValueTuple<string, object>("CgName", p0CgName));
			ConfigVideoDataByCgNameAndGirlOrBoy.LogPair.Add(new ValueTuple<string, object>("GirlOrBoy", p1GirlOrBoy));
			if (!ConfigCommon.BindString(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, 1, p0CgName, ConfigVideoDataByCgNameAndGirlOrBoy.LogPair) || !ConfigCommon.BindInt(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, 2, p1GirlOrBoy, ConfigVideoDataByCgNameAndGirlOrBoy.LogPair) || ConfigCommon.Step(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, true, ConfigVideoDataByCgNameAndGirlOrBoy.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, ConfigVideoDataByCgNameAndGirlOrBoy.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, 0, ConfigVideoDataByCgNameAndGirlOrBoy.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, ConfigVideoDataByCgNameAndGirlOrBoy.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			VideoData rootAsVideoData = VideoData.GetRootAsVideoData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("VideoDataByCgNameAndGirlOrBoy");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0CgName);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1GirlOrBoy);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, ConfigVideoDataByCgNameAndGirlOrBoy.LogPair);
			return new VideoData?(rootAsVideoData);
		}

		// Token: 0x04004EEC RID: 20204
		private const string DB = "db_cgvedio.db";

		// Token: 0x04004EED RID: 20205
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x04004EEE RID: 20206
		private const string TABLE = "VideoData";

		// Token: 0x04004EEF RID: 20207
		private const string COMMAND = "select BinData from `VideoData` where CgName=? AND GirlOrBoy=?";

		// Token: 0x04004EF0 RID: 20208
		private const string KEY_PREFIX = "VideoDataByCgNameAndGirlOrBoy";

		// Token: 0x04004EF1 RID: 20209
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EF2 RID: 20210
		private static int HandleId;
	}
}
