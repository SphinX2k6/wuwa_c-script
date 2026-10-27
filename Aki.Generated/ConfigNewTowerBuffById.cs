using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FB RID: 1531
	public class ConfigNewTowerBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023F2 RID: 9202 RVA: 0x00124CCC File Offset: 0x00122ECC
		static ConfigNewTowerBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerBuffById.CreateStaticDefaultValue), new Action(ConfigNewTowerBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00124CEC File Offset: 0x00122EEC
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerBuff` where Id=?")
			});
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00124D6B File Offset: 0x00122F6B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerBuffById.LogPair = null;
			ConfigNewTowerBuffById.HandleId = 0;
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00124D79 File Offset: 0x00122F79
		public static void Init()
		{
			ConfigNewTowerBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerBuffById.HandleId, "db_newtower.db", "select BinData from `NewTowerBuff` where Id=?");
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00124D94 File Offset: 0x00122F94
		public static NewTowerBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerBuffById.HandleId, ConfigNewTowerBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerBuff?(NewTowerBuff.GetRootAsNewTowerBuff(configBuffer));
				}
			}
			ConfigNewTowerBuffById.LogPair.Clear();
			ConfigNewTowerBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerBuffById.HandleId, 1, p0Id, ConfigNewTowerBuffById.LogPair) || ConfigCommon.Step(ConfigNewTowerBuffById.HandleId, true, ConfigNewTowerBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerBuffById.HandleId, ConfigNewTowerBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerBuffById.HandleId, 0, ConfigNewTowerBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerBuffById.HandleId, ConfigNewTowerBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerBuff rootAsNewTowerBuff = NewTowerBuff.GetRootAsNewTowerBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerBuffById.HandleId, ConfigNewTowerBuffById.LogPair);
			return new NewTowerBuff?(rootAsNewTowerBuff);
		}

		// Token: 0x040029C3 RID: 10691
		private const string DB = "db_newtower.db";

		// Token: 0x040029C4 RID: 10692
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029C5 RID: 10693
		private const string TABLE = "NewTowerBuff";

		// Token: 0x040029C6 RID: 10694
		private const string COMMAND = "select BinData from `NewTowerBuff` where Id=?";

		// Token: 0x040029C7 RID: 10695
		private const string KEY_PREFIX = "NewTowerBuffById";

		// Token: 0x040029C8 RID: 10696
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029C9 RID: 10697
		private static int HandleId;
	}
}
