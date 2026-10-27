using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A75 RID: 2677
	public class ConfigVideoDataByCgNameAndGirlOrBoy : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ED2 RID: 16082 RVA: 0x001BD403 File Offset: 0x001BB603
		static ConfigVideoDataByCgNameAndGirlOrBoy()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigVideoDataByCgNameAndGirlOrBoy.CreateStaticDefaultValue), new Action(ConfigVideoDataByCgNameAndGirlOrBoy.ResetStaticDefaultValue));
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x001BD424 File Offset: 0x001BB624
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

		// Token: 0x06003ED4 RID: 16084 RVA: 0x001BD4A3 File Offset: 0x001BB6A3
		public static void ResetStaticDefaultValue()
		{
			ConfigVideoDataByCgNameAndGirlOrBoy.LogPair = null;
			ConfigVideoDataByCgNameAndGirlOrBoy.HandleId = 0;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x001BD4B1 File Offset: 0x001BB6B1
		public static void Init()
		{
			ConfigVideoDataByCgNameAndGirlOrBoy.HandleId = ConfigCommon.InitDataStatement(ConfigVideoDataByCgNameAndGirlOrBoy.HandleId, "db_cgvedio.db", "select BinData from `VideoData` where CgName=? AND GirlOrBoy=?");
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x001BD4CC File Offset: 0x001BB6CC
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

		// Token: 0x04004919 RID: 18713
		private const string DB = "db_cgvedio.db";

		// Token: 0x0400491A RID: 18714
		private const string FILE = "g.过场cg.xlsx";

		// Token: 0x0400491B RID: 18715
		private const string TABLE = "VideoData";

		// Token: 0x0400491C RID: 18716
		private const string COMMAND = "select BinData from `VideoData` where CgName=? AND GirlOrBoy=?";

		// Token: 0x0400491D RID: 18717
		private const string KEY_PREFIX = "VideoDataByCgNameAndGirlOrBoy";

		// Token: 0x0400491E RID: 18718
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400491F RID: 18719
		private static int HandleId;
	}
}
