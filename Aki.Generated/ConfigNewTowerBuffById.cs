using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000613 RID: 1555
	public class ConfigNewTowerBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002482 RID: 9346 RVA: 0x0012B748 File Offset: 0x00129948
		static ConfigNewTowerBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerBuffById.CreateStaticDefaultValue), new Action(ConfigNewTowerBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0012B768 File Offset: 0x00129968
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

		// Token: 0x06002484 RID: 9348 RVA: 0x0012B7E7 File Offset: 0x001299E7
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerBuffById.LogPair = null;
			ConfigNewTowerBuffById.HandleId = 0;
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0012B7F5 File Offset: 0x001299F5
		public static void Init()
		{
			ConfigNewTowerBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerBuffById.HandleId, "db_newtower.db", "select BinData from `NewTowerBuff` where Id=?");
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0012B810 File Offset: 0x00129A10
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

		// Token: 0x04002A6B RID: 10859
		private const string DB = "db_newtower.db";

		// Token: 0x04002A6C RID: 10860
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A6D RID: 10861
		private const string TABLE = "NewTowerBuff";

		// Token: 0x04002A6E RID: 10862
		private const string COMMAND = "select BinData from `NewTowerBuff` where Id=?";

		// Token: 0x04002A6F RID: 10863
		private const string KEY_PREFIX = "NewTowerBuffById";

		// Token: 0x04002A70 RID: 10864
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A71 RID: 10865
		private static int HandleId;
	}
}
