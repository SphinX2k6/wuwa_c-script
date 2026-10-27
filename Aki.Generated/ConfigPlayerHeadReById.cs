using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000743 RID: 1859
	public class ConfigPlayerHeadReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BA3 RID: 11171 RVA: 0x0015035F File Offset: 0x0014E55F
		static ConfigPlayerHeadReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerHeadReById.CreateStaticDefaultValue), new Action(ConfigPlayerHeadReById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00150380 File Offset: 0x0014E580
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerHeadReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerHeadReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_playerhead.db"),
				new ValueTuple<string, object>("文件", "w.玩家头像.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerHeadRe"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerHeadRe` where Id=?")
			});
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x001503FF File Offset: 0x0014E5FF
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerHeadReById.LogPair = null;
			ConfigPlayerHeadReById.HandleId = 0;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x0015040D File Offset: 0x0014E60D
		public static void Init()
		{
			ConfigPlayerHeadReById.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerHeadReById.HandleId, "db_playerhead.db", "select BinData from `PlayerHeadRe` where Id=?");
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00150428 File Offset: 0x0014E628
		public static PlayerHeadRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerHeadReById.HandleId, ConfigPlayerHeadReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerHeadReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlayerHeadRe?(PlayerHeadRe.GetRootAsPlayerHeadRe(configBuffer));
				}
			}
			ConfigPlayerHeadReById.LogPair.Clear();
			ConfigPlayerHeadReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPlayerHeadReById.HandleId, 1, p0Id, ConfigPlayerHeadReById.LogPair) || ConfigCommon.Step(ConfigPlayerHeadReById.HandleId, true, ConfigPlayerHeadReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlayerHeadReById.HandleId, ConfigPlayerHeadReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerHeadReById.HandleId, 0, ConfigPlayerHeadReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlayerHeadReById.HandleId, ConfigPlayerHeadReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlayerHeadRe rootAsPlayerHeadRe = PlayerHeadRe.GetRootAsPlayerHeadRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerHeadReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlayerHeadReById.HandleId, ConfigPlayerHeadReById.LogPair);
			return new PlayerHeadRe?(rootAsPlayerHeadRe);
		}

		// Token: 0x040032BB RID: 12987
		private const string DB = "db_playerhead.db";

		// Token: 0x040032BC RID: 12988
		private const string FILE = "w.玩家头像.xlsx";

		// Token: 0x040032BD RID: 12989
		private const string TABLE = "PlayerHeadRe";

		// Token: 0x040032BE RID: 12990
		private const string COMMAND = "select BinData from `PlayerHeadRe` where Id=?";

		// Token: 0x040032BF RID: 12991
		private const string KEY_PREFIX = "PlayerHeadReById";

		// Token: 0x040032C0 RID: 12992
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032C1 RID: 12993
		private static int HandleId;
	}
}
