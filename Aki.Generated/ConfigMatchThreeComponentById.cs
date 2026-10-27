using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052D RID: 1325
	public class ConfigMatchThreeComponentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F19 RID: 7961 RVA: 0x00109063 File Offset: 0x00107263
		static ConfigMatchThreeComponentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeComponentById.CreateStaticDefaultValue), new Action(ConfigMatchThreeComponentById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00109084 File Offset: 0x00107284
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeComponentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeComponentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeComponent"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeComponent` where Id=?")
			});
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00109103 File Offset: 0x00107303
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeComponentById.LogPair = null;
			ConfigMatchThreeComponentById.HandleId = 0;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00109111 File Offset: 0x00107311
		public static void Init()
		{
			ConfigMatchThreeComponentById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeComponentById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeComponent` where Id=?");
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0010912C File Offset: 0x0010732C
		public static MatchThreeComponent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeComponentById.HandleId, ConfigMatchThreeComponentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeComponentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeComponent?(MatchThreeComponent.GetRootAsMatchThreeComponent(configBuffer));
				}
			}
			ConfigMatchThreeComponentById.LogPair.Clear();
			ConfigMatchThreeComponentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeComponentById.HandleId, 1, p0Id, ConfigMatchThreeComponentById.LogPair) || ConfigCommon.Step(ConfigMatchThreeComponentById.HandleId, true, ConfigMatchThreeComponentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeComponentById.HandleId, ConfigMatchThreeComponentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeComponentById.HandleId, 0, ConfigMatchThreeComponentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeComponentById.HandleId, ConfigMatchThreeComponentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeComponent rootAsMatchThreeComponent = MatchThreeComponent.GetRootAsMatchThreeComponent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeComponentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeComponentById.HandleId, ConfigMatchThreeComponentById.LogPair);
			return new MatchThreeComponent?(rootAsMatchThreeComponent);
		}

		// Token: 0x0400241F RID: 9247
		private const string DB = "db_matchthree.db";

		// Token: 0x04002420 RID: 9248
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x04002421 RID: 9249
		private const string TABLE = "MatchThreeComponent";

		// Token: 0x04002422 RID: 9250
		private const string COMMAND = "select BinData from `MatchThreeComponent` where Id=?";

		// Token: 0x04002423 RID: 9251
		private const string KEY_PREFIX = "MatchThreeComponentById";

		// Token: 0x04002424 RID: 9252
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002425 RID: 9253
		private static int HandleId;
	}
}
