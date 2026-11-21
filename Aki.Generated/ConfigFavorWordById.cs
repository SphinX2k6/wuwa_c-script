using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CE RID: 718
	public class ConfigFavorWordById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x000BC3C8 File Offset: 0x000BA5C8
		static ConfigFavorWordById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorWordById.CreateStaticDefaultValue), new Action(ConfigFavorWordById.ResetStaticDefaultValue));
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x000BC3E8 File Offset: 0x000BA5E8
		public static void CreateStaticDefaultValue()
		{
			ConfigFavorWordById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFavorWordById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_favor.db"),
				new ValueTuple<string, object>("文件", "h.好感度.xlsx"),
				new ValueTuple<string, object>("表名", "FavorWord"),
				new ValueTuple<string, object>("语句", "select BinData from `FavorWord` where Id=?")
			});
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x000BC467 File Offset: 0x000BA667
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorWordById.LogPair = null;
			ConfigFavorWordById.HandleId = 0;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x000BC475 File Offset: 0x000BA675
		public static void Init()
		{
			ConfigFavorWordById.HandleId = ConfigCommon.InitDataStatement(ConfigFavorWordById.HandleId, "db_favor.db", "select BinData from `FavorWord` where Id=?");
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x000BC490 File Offset: 0x000BA690
		public static FavorWord? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFavorWordById.HandleId, ConfigFavorWordById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorWordById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FavorWord?(FavorWord.GetRootAsFavorWord(configBuffer));
				}
			}
			ConfigFavorWordById.LogPair.Clear();
			ConfigFavorWordById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFavorWordById.HandleId, 1, p0Id, ConfigFavorWordById.LogPair) || ConfigCommon.Step(ConfigFavorWordById.HandleId, true, ConfigFavorWordById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFavorWordById.HandleId, ConfigFavorWordById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFavorWordById.HandleId, 0, ConfigFavorWordById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFavorWordById.HandleId, ConfigFavorWordById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FavorWord rootAsFavorWord = FavorWord.GetRootAsFavorWord(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorWordById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFavorWordById.HandleId, ConfigFavorWordById.LogPair);
			return new FavorWord?(rootAsFavorWord);
		}

		// Token: 0x04001386 RID: 4998
		private const string DB = "db_favor.db";

		// Token: 0x04001387 RID: 4999
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x04001388 RID: 5000
		private const string TABLE = "FavorWord";

		// Token: 0x04001389 RID: 5001
		private const string COMMAND = "select BinData from `FavorWord` where Id=?";

		// Token: 0x0400138A RID: 5002
		private const string KEY_PREFIX = "FavorWordById";

		// Token: 0x0400138B RID: 5003
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400138C RID: 5004
		private static int HandleId;
	}
}
