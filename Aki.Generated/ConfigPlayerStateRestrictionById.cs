using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075C RID: 1884
	public class ConfigPlayerStateRestrictionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C39 RID: 11321 RVA: 0x00157024 File Offset: 0x00155224
		static ConfigPlayerStateRestrictionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerStateRestrictionById.CreateStaticDefaultValue), new Action(ConfigPlayerStateRestrictionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00157044 File Offset: 0x00155244
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerStateRestrictionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerStateRestrictionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_playerstaterestriction.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/w.玩家状态限制/*.csv*"),
				new ValueTuple<string, object>("表名", "PlayerStateRestriction"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerStateRestriction` where Id=?")
			});
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x001570C3 File Offset: 0x001552C3
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerStateRestrictionById.LogPair = null;
			ConfigPlayerStateRestrictionById.HandleId = 0;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x001570D1 File Offset: 0x001552D1
		public static void Init()
		{
			ConfigPlayerStateRestrictionById.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerStateRestrictionById.HandleId, "db_playerstaterestriction.db", "select BinData from `PlayerStateRestriction` where Id=?");
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x001570EC File Offset: 0x001552EC
		public static PlayerStateRestriction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerStateRestrictionById.HandleId, ConfigPlayerStateRestrictionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerStateRestrictionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlayerStateRestriction?(PlayerStateRestriction.GetRootAsPlayerStateRestriction(configBuffer));
				}
			}
			ConfigPlayerStateRestrictionById.LogPair.Clear();
			ConfigPlayerStateRestrictionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPlayerStateRestrictionById.HandleId, 1, p0Id, ConfigPlayerStateRestrictionById.LogPair) || ConfigCommon.Step(ConfigPlayerStateRestrictionById.HandleId, true, ConfigPlayerStateRestrictionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlayerStateRestrictionById.HandleId, ConfigPlayerStateRestrictionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerStateRestrictionById.HandleId, 0, ConfigPlayerStateRestrictionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlayerStateRestrictionById.HandleId, ConfigPlayerStateRestrictionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlayerStateRestriction rootAsPlayerStateRestriction = PlayerStateRestriction.GetRootAsPlayerStateRestriction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerStateRestrictionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlayerStateRestrictionById.HandleId, ConfigPlayerStateRestrictionById.LogPair);
			return new PlayerStateRestriction?(rootAsPlayerStateRestriction);
		}

		// Token: 0x0400336A RID: 13162
		private const string DB = "db_playerstaterestriction.db";

		// Token: 0x0400336B RID: 13163
		private const string FILE = "k.可视化编辑/c.Csv/w.玩家状态限制/*.csv*";

		// Token: 0x0400336C RID: 13164
		private const string TABLE = "PlayerStateRestriction";

		// Token: 0x0400336D RID: 13165
		private const string COMMAND = "select BinData from `PlayerStateRestriction` where Id=?";

		// Token: 0x0400336E RID: 13166
		private const string KEY_PREFIX = "PlayerStateRestrictionById";

		// Token: 0x0400336F RID: 13167
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003370 RID: 13168
		private static int HandleId;
	}
}
