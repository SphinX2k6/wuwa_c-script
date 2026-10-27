using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E8 RID: 2024
	public class ConfigReviveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F82 RID: 12162 RVA: 0x00165CDC File Offset: 0x00163EDC
		static ConfigReviveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigReviveById.CreateStaticDefaultValue), new Action(ConfigReviveById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00165CFC File Offset: 0x00163EFC
		public static void CreateStaticDefaultValue()
		{
			ConfigReviveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigReviveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_revive.db"),
				new ValueTuple<string, object>("文件", "f.复活.xlsx"),
				new ValueTuple<string, object>("表名", "Revive"),
				new ValueTuple<string, object>("语句", "select BinData from `Revive` where id=?")
			});
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00165D7B File Offset: 0x00163F7B
		public static void ResetStaticDefaultValue()
		{
			ConfigReviveById.LogPair = null;
			ConfigReviveById.HandleId = 0;
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00165D89 File Offset: 0x00163F89
		public static void Init()
		{
			ConfigReviveById.HandleId = ConfigCommon.InitDataStatement(ConfigReviveById.HandleId, "db_revive.db", "select BinData from `Revive` where id=?");
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00165DA4 File Offset: 0x00163FA4
		public static Revive? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigReviveById.HandleId, ConfigReviveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ReviveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Revive?(Revive.GetRootAsRevive(configBuffer));
				}
			}
			ConfigReviveById.LogPair.Clear();
			ConfigReviveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigReviveById.HandleId, 1, p0Id, ConfigReviveById.LogPair) || ConfigCommon.Step(ConfigReviveById.HandleId, true, ConfigReviveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigReviveById.HandleId, ConfigReviveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigReviveById.HandleId, 0, ConfigReviveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigReviveById.HandleId, ConfigReviveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Revive rootAsRevive = Revive.GetRootAsRevive(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ReviveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigReviveById.HandleId, ConfigReviveById.LogPair);
			return new Revive?(rootAsRevive);
		}

		// Token: 0x0400373E RID: 14142
		private const string DB = "db_revive.db";

		// Token: 0x0400373F RID: 14143
		private const string FILE = "f.复活.xlsx";

		// Token: 0x04003740 RID: 14144
		private const string TABLE = "Revive";

		// Token: 0x04003741 RID: 14145
		private const string COMMAND = "select BinData from `Revive` where id=?";

		// Token: 0x04003742 RID: 14146
		private const string KEY_PREFIX = "ReviveById";

		// Token: 0x04003743 RID: 14147
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003744 RID: 14148
		private static int HandleId;
	}
}
