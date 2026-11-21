using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061A RID: 1562
	public class ConfigNewTowerParamByCycleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024AC RID: 9388 RVA: 0x0012C65B File Offset: 0x0012A85B
		static ConfigNewTowerParamByCycleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerParamByCycleId.CreateStaticDefaultValue), new Action(ConfigNewTowerParamByCycleId.ResetStaticDefaultValue));
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0012C67C File Offset: 0x0012A87C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerParamByCycleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerParamByCycleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerParam"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerParam` where CycleId=?")
			});
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0012C6FB File Offset: 0x0012A8FB
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerParamByCycleId.LogPair = null;
			ConfigNewTowerParamByCycleId.HandleId = 0;
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0012C709 File Offset: 0x0012A909
		public static void Init()
		{
			ConfigNewTowerParamByCycleId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerParamByCycleId.HandleId, "db_newtower.db", "select BinData from `NewTowerParam` where CycleId=?");
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0012C724 File Offset: 0x0012A924
		public static NewTowerParam? GetConfig(int p0CycleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerParamByCycleId.HandleId, ConfigNewTowerParamByCycleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerParamByCycleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CycleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerParam?(NewTowerParam.GetRootAsNewTowerParam(configBuffer));
				}
			}
			ConfigNewTowerParamByCycleId.LogPair.Clear();
			ConfigNewTowerParamByCycleId.LogPair.Add(new ValueTuple<string, object>("CycleId", p0CycleId));
			if (!ConfigCommon.BindInt(ConfigNewTowerParamByCycleId.HandleId, 1, p0CycleId, ConfigNewTowerParamByCycleId.LogPair) || ConfigCommon.Step(ConfigNewTowerParamByCycleId.HandleId, true, ConfigNewTowerParamByCycleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerParamByCycleId.HandleId, ConfigNewTowerParamByCycleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerParamByCycleId.HandleId, 0, ConfigNewTowerParamByCycleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerParamByCycleId.HandleId, ConfigNewTowerParamByCycleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerParam rootAsNewTowerParam = NewTowerParam.GetRootAsNewTowerParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerParamByCycleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CycleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerParamByCycleId.HandleId, ConfigNewTowerParamByCycleId.LogPair);
			return new NewTowerParam?(rootAsNewTowerParam);
		}

		// Token: 0x04002A9C RID: 10908
		private const string DB = "db_newtower.db";

		// Token: 0x04002A9D RID: 10909
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A9E RID: 10910
		private const string TABLE = "NewTowerParam";

		// Token: 0x04002A9F RID: 10911
		private const string COMMAND = "select BinData from `NewTowerParam` where CycleId=?";

		// Token: 0x04002AA0 RID: 10912
		private const string KEY_PREFIX = "NewTowerParamByCycleId";

		// Token: 0x04002AA1 RID: 10913
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AA2 RID: 10914
		private static int HandleId;
	}
}
