using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A95 RID: 2709
	public class ConfigWeekCardContentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F93 RID: 16275 RVA: 0x001C1E7B File Offset: 0x001C007B
		static ConfigWeekCardContentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeekCardContentById.CreateStaticDefaultValue), new Action(ConfigWeekCardContentById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F94 RID: 16276 RVA: 0x001C1E9C File Offset: 0x001C009C
		public static void CreateStaticDefaultValue()
		{
			ConfigWeekCardContentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeekCardContentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weekcard.db"),
				new ValueTuple<string, object>("文件", "z.周卡.xlsx"),
				new ValueTuple<string, object>("表名", "WeekCardContent"),
				new ValueTuple<string, object>("语句", "select BinData from `WeekCardContent` where Id=?")
			});
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x001C1F1B File Offset: 0x001C011B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeekCardContentById.LogPair = null;
			ConfigWeekCardContentById.HandleId = 0;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x001C1F29 File Offset: 0x001C0129
		public static void Init()
		{
			ConfigWeekCardContentById.HandleId = ConfigCommon.InitDataStatement(ConfigWeekCardContentById.HandleId, "db_weekcard.db", "select BinData from `WeekCardContent` where Id=?");
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x001C1F44 File Offset: 0x001C0144
		public static WeekCardContent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeekCardContentById.HandleId, ConfigWeekCardContentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeekCardContent?(WeekCardContent.GetRootAsWeekCardContent(configBuffer));
				}
			}
			ConfigWeekCardContentById.LogPair.Clear();
			ConfigWeekCardContentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeekCardContentById.HandleId, 1, p0Id, ConfigWeekCardContentById.LogPair) || ConfigCommon.Step(ConfigWeekCardContentById.HandleId, true, ConfigWeekCardContentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeekCardContentById.HandleId, ConfigWeekCardContentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeekCardContentById.HandleId, 0, ConfigWeekCardContentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeekCardContentById.HandleId, ConfigWeekCardContentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeekCardContent rootAsWeekCardContent = WeekCardContent.GetRootAsWeekCardContent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeekCardContentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeekCardContentById.HandleId, ConfigWeekCardContentById.LogPair);
			return new WeekCardContent?(rootAsWeekCardContent);
		}

		// Token: 0x040049F9 RID: 18937
		private const string DB = "db_weekcard.db";

		// Token: 0x040049FA RID: 18938
		private const string FILE = "z.周卡.xlsx";

		// Token: 0x040049FB RID: 18939
		private const string TABLE = "WeekCardContent";

		// Token: 0x040049FC RID: 18940
		private const string COMMAND = "select BinData from `WeekCardContent` where Id=?";

		// Token: 0x040049FD RID: 18941
		private const string KEY_PREFIX = "WeekCardContentById";

		// Token: 0x040049FE RID: 18942
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049FF RID: 18943
		private static int HandleId;
	}
}
