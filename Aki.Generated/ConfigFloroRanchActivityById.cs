using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030B RID: 779
	public class ConfigFloroRanchActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001247 RID: 4679 RVA: 0x000C0E50 File Offset: 0x000BF050
		static ConfigFloroRanchActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchActivityById.CreateStaticDefaultValue), new Action(ConfigFloroRanchActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x000C0E70 File Offset: 0x000BF070
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchActivity` where Id=?")
			});
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x000C0EEF File Offset: 0x000BF0EF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchActivityById.LogPair = null;
			ConfigFloroRanchActivityById.HandleId = 0;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x000C0EFD File Offset: 0x000BF0FD
		public static void Init()
		{
			ConfigFloroRanchActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchActivityById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchActivity` where Id=?");
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x000C0F18 File Offset: 0x000BF118
		public static FloroRanchActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchActivityById.HandleId, ConfigFloroRanchActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchActivity?(FloroRanchActivity.GetRootAsFloroRanchActivity(configBuffer));
				}
			}
			ConfigFloroRanchActivityById.LogPair.Clear();
			ConfigFloroRanchActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchActivityById.HandleId, 1, p0Id, ConfigFloroRanchActivityById.LogPair) || ConfigCommon.Step(ConfigFloroRanchActivityById.HandleId, true, ConfigFloroRanchActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchActivityById.HandleId, ConfigFloroRanchActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchActivityById.HandleId, 0, ConfigFloroRanchActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchActivityById.HandleId, ConfigFloroRanchActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchActivity rootAsFloroRanchActivity = FloroRanchActivity.GetRootAsFloroRanchActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchActivityById.HandleId, ConfigFloroRanchActivityById.LogPair);
			return new FloroRanchActivity?(rootAsFloroRanchActivity);
		}

		// Token: 0x04001531 RID: 5425
		private const string DB = "db_flororanch.db";

		// Token: 0x04001532 RID: 5426
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001533 RID: 5427
		private const string TABLE = "FloroRanchActivity";

		// Token: 0x04001534 RID: 5428
		private const string COMMAND = "select BinData from `FloroRanchActivity` where Id=?";

		// Token: 0x04001535 RID: 5429
		private const string KEY_PREFIX = "FloroRanchActivityById";

		// Token: 0x04001536 RID: 5430
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001537 RID: 5431
		private static int HandleId;
	}
}
