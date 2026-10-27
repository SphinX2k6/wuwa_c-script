using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000744 RID: 1860
	public class ConfigPlayerStateRestrictionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BA9 RID: 11177 RVA: 0x001505A8 File Offset: 0x0014E7A8
		static ConfigPlayerStateRestrictionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerStateRestrictionById.CreateStaticDefaultValue), new Action(ConfigPlayerStateRestrictionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x001505C8 File Offset: 0x0014E7C8
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

		// Token: 0x06002BAB RID: 11179 RVA: 0x00150647 File Offset: 0x0014E847
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerStateRestrictionById.LogPair = null;
			ConfigPlayerStateRestrictionById.HandleId = 0;
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00150655 File Offset: 0x0014E855
		public static void Init()
		{
			ConfigPlayerStateRestrictionById.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerStateRestrictionById.HandleId, "db_playerstaterestriction.db", "select BinData from `PlayerStateRestriction` where Id=?");
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00150670 File Offset: 0x0014E870
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

		// Token: 0x040032C2 RID: 12994
		private const string DB = "db_playerstaterestriction.db";

		// Token: 0x040032C3 RID: 12995
		private const string FILE = "k.可视化编辑/c.Csv/w.玩家状态限制/*.csv*";

		// Token: 0x040032C4 RID: 12996
		private const string TABLE = "PlayerStateRestriction";

		// Token: 0x040032C5 RID: 12997
		private const string COMMAND = "select BinData from `PlayerStateRestriction` where Id=?";

		// Token: 0x040032C6 RID: 12998
		private const string KEY_PREFIX = "PlayerStateRestrictionById";

		// Token: 0x040032C7 RID: 12999
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032C8 RID: 13000
		private static int HandleId;
	}
}
