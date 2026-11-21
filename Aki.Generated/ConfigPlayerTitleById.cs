using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200075E RID: 1886
	public class ConfigPlayerTitleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C45 RID: 11333 RVA: 0x001573FF File Offset: 0x001555FF
		static ConfigPlayerTitleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayerTitleById.CreateStaticDefaultValue), new Action(ConfigPlayerTitleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00157420 File Offset: 0x00155620
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

		// Token: 0x06002C47 RID: 11335 RVA: 0x0015749F File Offset: 0x0015569F
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayerTitleById.LogPair = null;
			ConfigPlayerTitleById.HandleId = 0;
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x001574AD File Offset: 0x001556AD
		public static void Init()
		{
			ConfigPlayerTitleById.HandleId = ConfigCommon.InitDataStatement(ConfigPlayerTitleById.HandleId, "db_personaltitle.db", "select BinData from `PlayerTitle` where Id=?");
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x001574C8 File Offset: 0x001556C8
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

		// Token: 0x04003378 RID: 13176
		private const string DB = "db_personaltitle.db";

		// Token: 0x04003379 RID: 13177
		private const string FILE = "c.称号.xlsx";

		// Token: 0x0400337A RID: 13178
		private const string TABLE = "PlayerTitle";

		// Token: 0x0400337B RID: 13179
		private const string COMMAND = "select BinData from `PlayerTitle` where Id=?";

		// Token: 0x0400337C RID: 13180
		private const string KEY_PREFIX = "PlayerTitleById";

		// Token: 0x0400337D RID: 13181
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400337E RID: 13182
		private static int HandleId;
	}
}
