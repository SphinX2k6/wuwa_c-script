using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000556 RID: 1366
	public class ConfigMonsterInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002011 RID: 8209 RVA: 0x0010E96D File Offset: 0x0010CB6D
		static ConfigMonsterInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterInfoById.CreateStaticDefaultValue), new Action(ConfigMonsterInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0010E98C File Offset: 0x0010CB8C
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monster_info.db"),
				new ValueTuple<string, object>("文件", "g.怪物信息.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterInfo` where Id=?")
			});
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0010EA0B File Offset: 0x0010CC0B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterInfoById.LogPair = null;
			ConfigMonsterInfoById.HandleId = 0;
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0010EA19 File Offset: 0x0010CC19
		public static void Init()
		{
			ConfigMonsterInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterInfoById.HandleId, "db_monster_info.db", "select BinData from `MonsterInfo` where Id=?");
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0010EA34 File Offset: 0x0010CC34
		public static MonsterInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterInfoById.HandleId, ConfigMonsterInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MonsterInfo?(MonsterInfo.GetRootAsMonsterInfo(configBuffer));
				}
			}
			ConfigMonsterInfoById.LogPair.Clear();
			ConfigMonsterInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMonsterInfoById.HandleId, 1, p0Id, ConfigMonsterInfoById.LogPair) || ConfigCommon.Step(ConfigMonsterInfoById.HandleId, true, ConfigMonsterInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMonsterInfoById.HandleId, ConfigMonsterInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterInfoById.HandleId, 0, ConfigMonsterInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMonsterInfoById.HandleId, ConfigMonsterInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MonsterInfo rootAsMonsterInfo = MonsterInfo.GetRootAsMonsterInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMonsterInfoById.HandleId, ConfigMonsterInfoById.LogPair);
			return new MonsterInfo?(rootAsMonsterInfo);
		}

		// Token: 0x0400253E RID: 9534
		private const string DB = "db_monster_info.db";

		// Token: 0x0400253F RID: 9535
		private const string FILE = "g.怪物信息.xlsx";

		// Token: 0x04002540 RID: 9536
		private const string TABLE = "MonsterInfo";

		// Token: 0x04002541 RID: 9537
		private const string COMMAND = "select BinData from `MonsterInfo` where Id=?";

		// Token: 0x04002542 RID: 9538
		private const string KEY_PREFIX = "MonsterInfoById";

		// Token: 0x04002543 RID: 9539
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002544 RID: 9540
		private static int HandleId;
	}
}
