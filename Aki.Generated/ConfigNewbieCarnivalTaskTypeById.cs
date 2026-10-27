using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E5 RID: 1509
	public class ConfigNewbieCarnivalTaskTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600236D RID: 9069 RVA: 0x00121DFB File Offset: 0x0011FFFB
		static ConfigNewbieCarnivalTaskTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalTaskTypeById.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalTaskTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x00121E1C File Offset: 0x0012001C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCarnivalTaskTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecarnival.db"),
				new ValueTuple<string, object>("文件", "x.新手嘉年华.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCarnivalTaskType"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCarnivalTaskType` where Id=?")
			});
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00121E9B File Offset: 0x0012009B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskTypeById.LogPair = null;
			ConfigNewbieCarnivalTaskTypeById.HandleId = 0;
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00121EA9 File Offset: 0x001200A9
		public static void Init()
		{
			ConfigNewbieCarnivalTaskTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalTaskTypeById.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalTaskType` where Id=?");
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00121EC4 File Offset: 0x001200C4
		public static NewbieCarnivalTaskType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCarnivalTaskTypeById.HandleId, ConfigNewbieCarnivalTaskTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieCarnivalTaskType?(NewbieCarnivalTaskType.GetRootAsNewbieCarnivalTaskType(configBuffer));
				}
			}
			ConfigNewbieCarnivalTaskTypeById.LogPair.Clear();
			ConfigNewbieCarnivalTaskTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewbieCarnivalTaskTypeById.HandleId, 1, p0Id, ConfigNewbieCarnivalTaskTypeById.LogPair) || ConfigCommon.Step(ConfigNewbieCarnivalTaskTypeById.HandleId, true, ConfigNewbieCarnivalTaskTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalTaskTypeById.HandleId, ConfigNewbieCarnivalTaskTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCarnivalTaskTypeById.HandleId, 0, ConfigNewbieCarnivalTaskTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalTaskTypeById.HandleId, ConfigNewbieCarnivalTaskTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieCarnivalTaskType rootAsNewbieCarnivalTaskType = NewbieCarnivalTaskType.GetRootAsNewbieCarnivalTaskType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieCarnivalTaskTypeById.HandleId, ConfigNewbieCarnivalTaskTypeById.LogPair);
			return new NewbieCarnivalTaskType?(rootAsNewbieCarnivalTaskType);
		}

		// Token: 0x04002929 RID: 10537
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x0400292A RID: 10538
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x0400292B RID: 10539
		private const string TABLE = "NewbieCarnivalTaskType";

		// Token: 0x0400292C RID: 10540
		private const string COMMAND = "select BinData from `NewbieCarnivalTaskType` where Id=?";

		// Token: 0x0400292D RID: 10541
		private const string KEY_PREFIX = "NewbieCarnivalTaskTypeById";

		// Token: 0x0400292E RID: 10542
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400292F RID: 10543
		private static int HandleId;
	}
}
