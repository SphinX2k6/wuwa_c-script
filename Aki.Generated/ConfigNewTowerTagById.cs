using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000627 RID: 1575
	public class ConfigNewTowerTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024FA RID: 9466 RVA: 0x0012E21B File Offset: 0x0012C41B
		static ConfigNewTowerTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerTagById.CreateStaticDefaultValue), new Action(ConfigNewTowerTagById.ResetStaticDefaultValue));
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x0012E23C File Offset: 0x0012C43C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerTag"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerTag` where Id=?")
			});
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0012E2BB File Offset: 0x0012C4BB
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerTagById.LogPair = null;
			ConfigNewTowerTagById.HandleId = 0;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x0012E2C9 File Offset: 0x0012C4C9
		public static void Init()
		{
			ConfigNewTowerTagById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerTagById.HandleId, "db_newtower.db", "select BinData from `NewTowerTag` where Id=?");
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0012E2E4 File Offset: 0x0012C4E4
		public static NewTowerTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerTagById.HandleId, ConfigNewTowerTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerTag?(NewTowerTag.GetRootAsNewTowerTag(configBuffer));
				}
			}
			ConfigNewTowerTagById.LogPair.Clear();
			ConfigNewTowerTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewTowerTagById.HandleId, 1, p0Id, ConfigNewTowerTagById.LogPair) || ConfigCommon.Step(ConfigNewTowerTagById.HandleId, true, ConfigNewTowerTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerTagById.HandleId, ConfigNewTowerTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerTagById.HandleId, 0, ConfigNewTowerTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerTagById.HandleId, ConfigNewTowerTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerTag rootAsNewTowerTag = NewTowerTag.GetRootAsNewTowerTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerTagById.HandleId, ConfigNewTowerTagById.LogPair);
			return new NewTowerTag?(rootAsNewTowerTag);
		}

		// Token: 0x04002AF7 RID: 10999
		private const string DB = "db_newtower.db";

		// Token: 0x04002AF8 RID: 11000
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002AF9 RID: 11001
		private const string TABLE = "NewTowerTag";

		// Token: 0x04002AFA RID: 11002
		private const string COMMAND = "select BinData from `NewTowerTag` where Id=?";

		// Token: 0x04002AFB RID: 11003
		private const string KEY_PREFIX = "NewTowerTagById";

		// Token: 0x04002AFC RID: 11004
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AFD RID: 11005
		private static int HandleId;
	}
}
