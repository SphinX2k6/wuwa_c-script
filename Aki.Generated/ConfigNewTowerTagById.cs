using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060F RID: 1551
	public class ConfigNewTowerTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600246A RID: 9322 RVA: 0x0012779F File Offset: 0x0012599F
		static ConfigNewTowerTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerTagById.CreateStaticDefaultValue), new Action(ConfigNewTowerTagById.ResetStaticDefaultValue));
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x001277C0 File Offset: 0x001259C0
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

		// Token: 0x0600246C RID: 9324 RVA: 0x0012783F File Offset: 0x00125A3F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerTagById.LogPair = null;
			ConfigNewTowerTagById.HandleId = 0;
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0012784D File Offset: 0x00125A4D
		public static void Init()
		{
			ConfigNewTowerTagById.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerTagById.HandleId, "db_newtower.db", "select BinData from `NewTowerTag` where Id=?");
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x00127868 File Offset: 0x00125A68
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

		// Token: 0x04002A4F RID: 10831
		private const string DB = "db_newtower.db";

		// Token: 0x04002A50 RID: 10832
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x04002A51 RID: 10833
		private const string TABLE = "NewTowerTag";

		// Token: 0x04002A52 RID: 10834
		private const string COMMAND = "select BinData from `NewTowerTag` where Id=?";

		// Token: 0x04002A53 RID: 10835
		private const string KEY_PREFIX = "NewTowerTagById";

		// Token: 0x04002A54 RID: 10836
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A55 RID: 10837
		private static int HandleId;
	}
}
