using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085A RID: 2138
	public class ConfigRogueResTalentTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600322E RID: 12846 RVA: 0x001752CF File Offset: 0x001734CF
		static ConfigRogueResTalentTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTalentTreeById.CreateStaticDefaultValue), new Action(ConfigRogueResTalentTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x001752F0 File Offset: 0x001734F0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResTalentTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResTalentTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTalentTree` where Id=?")
			});
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x0017536F File Offset: 0x0017356F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTalentTreeById.LogPair = null;
			ConfigRogueResTalentTreeById.HandleId = 0;
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x0017537D File Offset: 0x0017357D
		public static void Init()
		{
			ConfigRogueResTalentTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTalentTreeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTalentTree` where Id=?");
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x00175398 File Offset: 0x00173598
		public static RogueResTalentTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResTalentTreeById.HandleId, ConfigRogueResTalentTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResTalentTree?(RogueResTalentTree.GetRootAsRogueResTalentTree(configBuffer));
				}
			}
			ConfigRogueResTalentTreeById.LogPair.Clear();
			ConfigRogueResTalentTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResTalentTreeById.HandleId, 1, p0Id, ConfigRogueResTalentTreeById.LogPair) || ConfigCommon.Step(ConfigRogueResTalentTreeById.HandleId, true, ConfigRogueResTalentTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResTalentTreeById.HandleId, ConfigRogueResTalentTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResTalentTreeById.HandleId, 0, ConfigRogueResTalentTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResTalentTreeById.HandleId, ConfigRogueResTalentTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResTalentTree rootAsRogueResTalentTree = RogueResTalentTree.GetRootAsRogueResTalentTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResTalentTreeById.HandleId, ConfigRogueResTalentTreeById.LogPair);
			return new RogueResTalentTree?(rootAsRogueResTalentTree);
		}

		// Token: 0x04003A5C RID: 14940
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A5D RID: 14941
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A5E RID: 14942
		private const string TABLE = "RogueResTalentTree";

		// Token: 0x04003A5F RID: 14943
		private const string COMMAND = "select BinData from `RogueResTalentTree` where Id=?";

		// Token: 0x04003A60 RID: 14944
		private const string KEY_PREFIX = "RogueResTalentTreeById";

		// Token: 0x04003A61 RID: 14945
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A62 RID: 14946
		private static int HandleId;
	}
}
