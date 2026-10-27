using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F4 RID: 756
	public class ConfigFlagAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011BD RID: 4541 RVA: 0x000BDC40 File Offset: 0x000BBE40
		static ConfigFlagAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagAreaById.CreateStaticDefaultValue), new Action(ConfigFlagAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000BDC60 File Offset: 0x000BBE60
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FlagArea"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagArea` where Id=?")
			});
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x000BDCDF File Offset: 0x000BBEDF
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagAreaById.LogPair = null;
			ConfigFlagAreaById.HandleId = 0;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000BDCED File Offset: 0x000BBEED
		public static void Init()
		{
			ConfigFlagAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagAreaById.HandleId, "db_moraleplay.db", "select BinData from `FlagArea` where Id=?");
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000BDD08 File Offset: 0x000BBF08
		public static FlagArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagAreaById.HandleId, ConfigFlagAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagArea?(FlagArea.GetRootAsFlagArea(configBuffer));
				}
			}
			ConfigFlagAreaById.LogPair.Clear();
			ConfigFlagAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagAreaById.HandleId, 1, p0Id, ConfigFlagAreaById.LogPair) || ConfigCommon.Step(ConfigFlagAreaById.HandleId, true, ConfigFlagAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagAreaById.HandleId, ConfigFlagAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagAreaById.HandleId, 0, ConfigFlagAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagAreaById.HandleId, ConfigFlagAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagArea rootAsFlagArea = FlagArea.GetRootAsFlagArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagAreaById.HandleId, ConfigFlagAreaById.LogPair);
			return new FlagArea?(rootAsFlagArea);
		}

		// Token: 0x04001490 RID: 5264
		private const string DB = "db_moraleplay.db";

		// Token: 0x04001491 RID: 5265
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04001492 RID: 5266
		private const string TABLE = "FlagArea";

		// Token: 0x04001493 RID: 5267
		private const string COMMAND = "select BinData from `FlagArea` where Id=?";

		// Token: 0x04001494 RID: 5268
		private const string KEY_PREFIX = "FlagAreaById";

		// Token: 0x04001495 RID: 5269
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001496 RID: 5270
		private static int HandleId;
	}
}
