using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B9 RID: 697
	public class ConfigFavorWordById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600105B RID: 4187 RVA: 0x000B5EBC File Offset: 0x000B40BC
		static ConfigFavorWordById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorWordById.CreateStaticDefaultValue), new Action(ConfigFavorWordById.ResetStaticDefaultValue));
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x000B5EDC File Offset: 0x000B40DC
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

		// Token: 0x0600105D RID: 4189 RVA: 0x000B5F5B File Offset: 0x000B415B
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorWordById.LogPair = null;
			ConfigFavorWordById.HandleId = 0;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000B5F69 File Offset: 0x000B4169
		public static void Init()
		{
			ConfigFavorWordById.HandleId = ConfigCommon.InitDataStatement(ConfigFavorWordById.HandleId, "db_favor.db", "select BinData from `FavorWord` where Id=?");
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x000B5F84 File Offset: 0x000B4184
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

		// Token: 0x040012F3 RID: 4851
		private const string DB = "db_favor.db";

		// Token: 0x040012F4 RID: 4852
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x040012F5 RID: 4853
		private const string TABLE = "FavorWord";

		// Token: 0x040012F6 RID: 4854
		private const string COMMAND = "select BinData from `FavorWord` where Id=?";

		// Token: 0x040012F7 RID: 4855
		private const string KEY_PREFIX = "FavorWordById";

		// Token: 0x040012F8 RID: 4856
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012F9 RID: 4857
		private static int HandleId;
	}
}
