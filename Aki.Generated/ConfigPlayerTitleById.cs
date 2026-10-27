using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000746 RID: 1862
	public class ConfigPlayerTitleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BB5 RID: 11189 RVA: 0x00150983 File Offset: 0x0014EB83
		static ConfigPlayerTitleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerTitleById.CreateStaticDefaultValue), new Action(ConfigPlayerTitleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x001509A4 File Offset: 0x0014EBA4
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayerTitleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayerTitleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_personaltitle.db"),
				new ValueTuple<string, object>("文件", "c.称号.xlsx"),
				new ValueTuple<string, object>("表名", "PlayerTitle"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayerTitle` where Id=?")
			});
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00150A23 File Offset: 0x0014EC23
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerTitleById.LogPair = null;
			ConfigPlayerTitleById.HandleId = 0;
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00150A31 File Offset: 0x0014EC31
		public static void Init()
		{
			ConfigPlayerTitleById.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerTitleById.HandleId, "db_personaltitle.db", "select BinData from `PlayerTitle` where Id=?");
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x00150A4C File Offset: 0x0014EC4C
		public static PlayerTitle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayerTitleById.HandleId, ConfigPlayerTitleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerTitleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlayerTitle?(PlayerTitle.GetRootAsPlayerTitle(configBuffer));
				}
			}
			ConfigPlayerTitleById.LogPair.Clear();
			ConfigPlayerTitleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPlayerTitleById.HandleId, 1, p0Id, ConfigPlayerTitleById.LogPair) || ConfigCommon.Step(ConfigPlayerTitleById.HandleId, true, ConfigPlayerTitleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlayerTitleById.HandleId, ConfigPlayerTitleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayerTitleById.HandleId, 0, ConfigPlayerTitleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlayerTitleById.HandleId, ConfigPlayerTitleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlayerTitle rootAsPlayerTitle = PlayerTitle.GetRootAsPlayerTitle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlayerTitleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlayerTitleById.HandleId, ConfigPlayerTitleById.LogPair);
			return new PlayerTitle?(rootAsPlayerTitle);
		}

		// Token: 0x040032D0 RID: 13008
		private const string DB = "db_personaltitle.db";

		// Token: 0x040032D1 RID: 13009
		private const string FILE = "c.称号.xlsx";

		// Token: 0x040032D2 RID: 13010
		private const string TABLE = "PlayerTitle";

		// Token: 0x040032D3 RID: 13011
		private const string COMMAND = "select BinData from `PlayerTitle` where Id=?";

		// Token: 0x040032D4 RID: 13012
		private const string KEY_PREFIX = "PlayerTitleById";

		// Token: 0x040032D5 RID: 13013
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032D6 RID: 13014
		private static int HandleId;
	}
}
