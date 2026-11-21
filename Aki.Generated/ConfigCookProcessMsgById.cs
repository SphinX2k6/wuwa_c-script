using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B4 RID: 436
	public class ConfigCookProcessMsgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A3B RID: 2619 RVA: 0x00096DC0 File Offset: 0x00094FC0
		static ConfigCookProcessMsgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookProcessMsgById.CreateStaticDefaultValue), new Action(ConfigCookProcessMsgById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00096DE0 File Offset: 0x00094FE0
		public static void CreateStaticDefaultValue()
		{
			ConfigCookProcessMsgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookProcessMsgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookProcessMsg"),
				new ValueTuple<string, object>("语句", "select BinData from `CookProcessMsg` where Id=?")
			});
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00096E5F File Offset: 0x0009505F
		public static void ResetStaticDefaultValue()
		{
			ConfigCookProcessMsgById.LogPair = null;
			ConfigCookProcessMsgById.HandleId = 0;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00096E6D File Offset: 0x0009506D
		public static void Init()
		{
			ConfigCookProcessMsgById.HandleId = ConfigCommon.InitDataStatement(ConfigCookProcessMsgById.HandleId, "db_cook.db", "select BinData from `CookProcessMsg` where Id=?");
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00096E88 File Offset: 0x00095088
		public static CookProcessMsg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookProcessMsgById.HandleId, ConfigCookProcessMsgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookProcessMsgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookProcessMsg?(CookProcessMsg.GetRootAsCookProcessMsg(configBuffer));
				}
			}
			ConfigCookProcessMsgById.LogPair.Clear();
			ConfigCookProcessMsgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCookProcessMsgById.HandleId, 1, p0Id, ConfigCookProcessMsgById.LogPair) || ConfigCommon.Step(ConfigCookProcessMsgById.HandleId, true, ConfigCookProcessMsgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookProcessMsgById.HandleId, ConfigCookProcessMsgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookProcessMsgById.HandleId, 0, ConfigCookProcessMsgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookProcessMsgById.HandleId, ConfigCookProcessMsgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookProcessMsg rootAsCookProcessMsg = CookProcessMsg.GetRootAsCookProcessMsg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookProcessMsgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookProcessMsgById.HandleId, ConfigCookProcessMsgById.LogPair);
			return new CookProcessMsg?(rootAsCookProcessMsg);
		}

		// Token: 0x04000BD0 RID: 3024
		private const string DB = "db_cook.db";

		// Token: 0x04000BD1 RID: 3025
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000BD2 RID: 3026
		private const string TABLE = "CookProcessMsg";

		// Token: 0x04000BD3 RID: 3027
		private const string COMMAND = "select BinData from `CookProcessMsg` where Id=?";

		// Token: 0x04000BD4 RID: 3028
		private const string KEY_PREFIX = "CookProcessMsgById";

		// Token: 0x04000BD5 RID: 3029
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BD6 RID: 3030
		private static int HandleId;
	}
}
