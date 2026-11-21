using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B3 RID: 435
	public class ConfigCookProcessedById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A35 RID: 2613 RVA: 0x00096B77 File Offset: 0x00094D77
		static ConfigCookProcessedById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookProcessedById.CreateStaticDefaultValue), new Action(ConfigCookProcessedById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00096B98 File Offset: 0x00094D98
		public static void CreateStaticDefaultValue()
		{
			ConfigCookProcessedById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookProcessedById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookProcessed"),
				new ValueTuple<string, object>("语句", "select BinData from `CookProcessed` where Id=?")
			});
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00096C17 File Offset: 0x00094E17
		public static void ResetStaticDefaultValue()
		{
			ConfigCookProcessedById.LogPair = null;
			ConfigCookProcessedById.HandleId = 0;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00096C25 File Offset: 0x00094E25
		public static void Init()
		{
			ConfigCookProcessedById.HandleId = ConfigCommon.InitDataStatement(ConfigCookProcessedById.HandleId, "db_cook.db", "select BinData from `CookProcessed` where Id=?");
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00096C40 File Offset: 0x00094E40
		public static CookProcessed? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookProcessedById.HandleId, ConfigCookProcessedById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookProcessedById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookProcessed?(CookProcessed.GetRootAsCookProcessed(configBuffer));
				}
			}
			ConfigCookProcessedById.LogPair.Clear();
			ConfigCookProcessedById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCookProcessedById.HandleId, 1, p0Id, ConfigCookProcessedById.LogPair) || ConfigCommon.Step(ConfigCookProcessedById.HandleId, true, ConfigCookProcessedById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookProcessedById.HandleId, ConfigCookProcessedById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookProcessedById.HandleId, 0, ConfigCookProcessedById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookProcessedById.HandleId, ConfigCookProcessedById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookProcessed rootAsCookProcessed = CookProcessed.GetRootAsCookProcessed(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookProcessedById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookProcessedById.HandleId, ConfigCookProcessedById.LogPair);
			return new CookProcessed?(rootAsCookProcessed);
		}

		// Token: 0x04000BC9 RID: 3017
		private const string DB = "db_cook.db";

		// Token: 0x04000BCA RID: 3018
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000BCB RID: 3019
		private const string TABLE = "CookProcessed";

		// Token: 0x04000BCC RID: 3020
		private const string COMMAND = "select BinData from `CookProcessed` where Id=?";

		// Token: 0x04000BCD RID: 3021
		private const string KEY_PREFIX = "CookProcessedById";

		// Token: 0x04000BCE RID: 3022
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BCF RID: 3023
		private static int HandleId;
	}
}
