using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200030A RID: 778
	public class ConfigFloroRanchActionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001241 RID: 4673 RVA: 0x000C0C08 File Offset: 0x000BEE08
		static ConfigFloroRanchActionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchActionById.CreateStaticDefaultValue), new Action(ConfigFloroRanchActionById.ResetStaticDefaultValue));
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x000C0C28 File Offset: 0x000BEE28
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchActionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchActionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchaction.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_行为.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchAction"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchAction` where Id=?")
			});
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x000C0CA7 File Offset: 0x000BEEA7
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchActionById.LogPair = null;
			ConfigFloroRanchActionById.HandleId = 0;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x000C0CB5 File Offset: 0x000BEEB5
		public static void Init()
		{
			ConfigFloroRanchActionById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchActionById.HandleId, "db_flororanchaction.db", "select BinData from `FloroRanchAction` where Id=?");
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x000C0CD0 File Offset: 0x000BEED0
		public static FloroRanchAction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchActionById.HandleId, ConfigFloroRanchActionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchAction?(FloroRanchAction.GetRootAsFloroRanchAction(configBuffer));
				}
			}
			ConfigFloroRanchActionById.LogPair.Clear();
			ConfigFloroRanchActionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchActionById.HandleId, 1, p0Id, ConfigFloroRanchActionById.LogPair) || ConfigCommon.Step(ConfigFloroRanchActionById.HandleId, true, ConfigFloroRanchActionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchActionById.HandleId, ConfigFloroRanchActionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchActionById.HandleId, 0, ConfigFloroRanchActionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchActionById.HandleId, ConfigFloroRanchActionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchAction rootAsFloroRanchAction = FloroRanchAction.GetRootAsFloroRanchAction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchActionById.HandleId, ConfigFloroRanchActionById.LogPair);
			return new FloroRanchAction?(rootAsFloroRanchAction);
		}

		// Token: 0x0400152A RID: 5418
		private const string DB = "db_flororanchaction.db";

		// Token: 0x0400152B RID: 5419
		private const string FILE = "f.弗洛洛牧场_行为.xlsx";

		// Token: 0x0400152C RID: 5420
		private const string TABLE = "FloroRanchAction";

		// Token: 0x0400152D RID: 5421
		private const string COMMAND = "select BinData from `FloroRanchAction` where Id=?";

		// Token: 0x0400152E RID: 5422
		private const string KEY_PREFIX = "FloroRanchActionById";

		// Token: 0x0400152F RID: 5423
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001530 RID: 5424
		private static int HandleId;
	}
}
