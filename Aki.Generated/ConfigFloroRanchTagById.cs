using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033D RID: 829
	public class ConfigFloroRanchTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001373 RID: 4979 RVA: 0x000CAD97 File Offset: 0x000C8F97
		static ConfigFloroRanchTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTagById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x000CADB8 File Offset: 0x000C8FB8
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchtag.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_词条.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTag"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTag` where Id=?")
			});
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x000CAE37 File Offset: 0x000C9037
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTagById.LogPair = null;
			ConfigFloroRanchTagById.HandleId = 0;
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x000CAE45 File Offset: 0x000C9045
		public static void Init()
		{
			ConfigFloroRanchTagById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTagById.HandleId, "db_flororanchtag.db", "select BinData from `FloroRanchTag` where Id=?");
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x000CAE60 File Offset: 0x000C9060
		public static FloroRanchTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTagById.HandleId, ConfigFloroRanchTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchTag?(FloroRanchTag.GetRootAsFloroRanchTag(configBuffer));
				}
			}
			ConfigFloroRanchTagById.LogPair.Clear();
			ConfigFloroRanchTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchTagById.HandleId, 1, p0Id, ConfigFloroRanchTagById.LogPair) || ConfigCommon.Step(ConfigFloroRanchTagById.HandleId, true, ConfigFloroRanchTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchTagById.HandleId, ConfigFloroRanchTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTagById.HandleId, 0, ConfigFloroRanchTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchTagById.HandleId, ConfigFloroRanchTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchTag rootAsFloroRanchTag = FloroRanchTag.GetRootAsFloroRanchTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchTagById.HandleId, ConfigFloroRanchTagById.LogPair);
			return new FloroRanchTag?(rootAsFloroRanchTag);
		}

		// Token: 0x0400168F RID: 5775
		private const string DB = "db_flororanchtag.db";

		// Token: 0x04001690 RID: 5776
		private const string FILE = "f.弗洛洛牧场_词条.xlsx";

		// Token: 0x04001691 RID: 5777
		private const string TABLE = "FloroRanchTag";

		// Token: 0x04001692 RID: 5778
		private const string COMMAND = "select BinData from `FloroRanchTag` where Id=?";

		// Token: 0x04001693 RID: 5779
		private const string KEY_PREFIX = "FloroRanchTagById";

		// Token: 0x04001694 RID: 5780
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001695 RID: 5781
		private static int HandleId;
	}
}
