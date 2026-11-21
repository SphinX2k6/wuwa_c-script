using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075B RID: 1883
	public class ConfigPlayerHeadReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C33 RID: 11315 RVA: 0x00156DDB File Offset: 0x00154FDB
		static ConfigPlayerHeadReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerHeadReById.CreateStaticDefaultValue), new Action(ConfigPlayerHeadReById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x00156DFC File Offset: 0x00154FFC
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

		// Token: 0x06002C35 RID: 11317 RVA: 0x00156E7B File Offset: 0x0015507B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerHeadReById.LogPair = null;
			ConfigPlayerHeadReById.HandleId = 0;
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x00156E89 File Offset: 0x00155089
		public static void Init()
		{
			ConfigPlayerHeadReById.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerHeadReById.HandleId, "db_playerhead.db", "select BinData from `PlayerHeadRe` where Id=?");
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00156EA4 File Offset: 0x001550A4
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

		// Token: 0x04003363 RID: 13155
		private const string DB = "db_playerhead.db";

		// Token: 0x04003364 RID: 13156
		private const string FILE = "w.玩家头像.xlsx";

		// Token: 0x04003365 RID: 13157
		private const string TABLE = "PlayerHeadRe";

		// Token: 0x04003366 RID: 13158
		private const string COMMAND = "select BinData from `PlayerHeadRe` where Id=?";

		// Token: 0x04003367 RID: 13159
		private const string KEY_PREFIX = "PlayerHeadReById";

		// Token: 0x04003368 RID: 13160
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003369 RID: 13161
		private static int HandleId;
	}
}
