using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054C RID: 1356
	public class ConfigMonsterDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FD5 RID: 8149 RVA: 0x0010D45F File Offset: 0x0010B65F
		static ConfigMonsterDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDisplayById.CreateStaticDefaultValue), new Action(ConfigMonsterDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x0010D480 File Offset: 0x0010B680
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

		// Token: 0x06001FD7 RID: 8151 RVA: 0x0010D4FF File Offset: 0x0010B6FF
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDisplayById.LogPair = null;
			ConfigMonsterDisplayById.HandleId = 0;
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x0010D50D File Offset: 0x0010B70D
		public static void Init()
		{
			ConfigMonsterDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDisplayById.HandleId, "db_monsterdisplay.db", "select BinData from `MonsterDisplay` where Id=?");
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x0010D528 File Offset: 0x0010B728
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

		// Token: 0x040024F8 RID: 9464
		private const string DB = "db_monsterdisplay.db";

		// Token: 0x040024F9 RID: 9465
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物展示面板/*.csv*";

		// Token: 0x040024FA RID: 9466
		private const string TABLE = "MonsterDisplay";

		// Token: 0x040024FB RID: 9467
		private const string COMMAND = "select BinData from `MonsterDisplay` where Id=?";

		// Token: 0x040024FC RID: 9468
		private const string KEY_PREFIX = "MonsterDisplayById";

		// Token: 0x040024FD RID: 9469
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024FE RID: 9470
		private static int HandleId;
	}
}
