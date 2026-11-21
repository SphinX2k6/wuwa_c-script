using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000562 RID: 1378
	public class ConfigMonsterDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002059 RID: 8281 RVA: 0x00113BB3 File Offset: 0x00111DB3
		static ConfigMonsterDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDisplayById.CreateStaticDefaultValue), new Action(ConfigMonsterDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00113BD4 File Offset: 0x00111DD4
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterDisplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterDisplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monsterdisplay.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.怪物展示面板/*.csv*"),
				new ValueTuple<string, object>("表名", "MonsterDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterDisplay` where Id=?")
			});
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x00113C53 File Offset: 0x00111E53
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDisplayById.LogPair = null;
			ConfigMonsterDisplayById.HandleId = 0;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x00113C61 File Offset: 0x00111E61
		public static void Init()
		{
			ConfigMonsterDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDisplayById.HandleId, "db_monsterdisplay.db", "select BinData from `MonsterDisplay` where Id=?");
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00113C7C File Offset: 0x00111E7C
		public static MonsterDisplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterDisplayById.HandleId, ConfigMonsterDisplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterDisplay?(MonsterDisplay.GetRootAsMonsterDisplay(configBuffer));
				}
			}
			ConfigMonsterDisplayById.LogPair.Clear();
			ConfigMonsterDisplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterDisplayById.HandleId, 1, p0Id, ConfigMonsterDisplayById.LogPair) || ConfigCommon.Step(ConfigMonsterDisplayById.HandleId, true, ConfigMonsterDisplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterDisplayById.HandleId, ConfigMonsterDisplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterDisplayById.HandleId, 0, ConfigMonsterDisplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterDisplayById.HandleId, ConfigMonsterDisplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterDisplay rootAsMonsterDisplay = MonsterDisplay.GetRootAsMonsterDisplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterDisplayById.HandleId, ConfigMonsterDisplayById.LogPair);
			return new MonsterDisplay?(rootAsMonsterDisplay);
		}

		// Token: 0x04002592 RID: 9618
		private const string DB = "db_monsterdisplay.db";

		// Token: 0x04002593 RID: 9619
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物展示面板/*.csv*";

		// Token: 0x04002594 RID: 9620
		private const string TABLE = "MonsterDisplay";

		// Token: 0x04002595 RID: 9621
		private const string COMMAND = "select BinData from `MonsterDisplay` where Id=?";

		// Token: 0x04002596 RID: 9622
		private const string KEY_PREFIX = "MonsterDisplayById";

		// Token: 0x04002597 RID: 9623
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002598 RID: 9624
		private static int HandleId;
	}
}
