using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000328 RID: 808
	public class ConfigFloroRanchTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012F5 RID: 4853 RVA: 0x000C488B File Offset: 0x000C2A8B
		static ConfigFloroRanchTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTagById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTagById.ResetStaticDefaultValue));
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000C48AC File Offset: 0x000C2AAC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchtag.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_词条.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTag"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTag` where Id=?")
			});
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000C492B File Offset: 0x000C2B2B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTagById.LogPair = null;
			ConfigFloroRanchTagById.HandleId = 0;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000C4939 File Offset: 0x000C2B39
		public static void Init()
		{
			ConfigFloroRanchTagById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTagById.HandleId, "db_flororanchtag.db", "select BinData from `FloroRanchTag` where Id=?");
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000C4954 File Offset: 0x000C2B54
		public static FloroRanchTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTagById.HandleId, ConfigFloroRanchTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchTag?(FloroRanchTag.GetRootAsFloroRanchTag(configBuffer));
				}
			}
			ConfigFloroRanchTagById.LogPair.Clear();
			ConfigFloroRanchTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchTagById.HandleId, 1, p0Id, ConfigFloroRanchTagById.LogPair) || ConfigCommon.Step(ConfigFloroRanchTagById.HandleId, true, ConfigFloroRanchTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchTagById.HandleId, ConfigFloroRanchTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTagById.HandleId, 0, ConfigFloroRanchTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchTagById.HandleId, ConfigFloroRanchTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchTag rootAsFloroRanchTag = FloroRanchTag.GetRootAsFloroRanchTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchTagById.HandleId, ConfigFloroRanchTagById.LogPair);
			return new FloroRanchTag?(rootAsFloroRanchTag);
		}

		// Token: 0x040015FC RID: 5628
		private const string DB = "db_flororanchtag.db";

		// Token: 0x040015FD RID: 5629
		private const string FILE = "f.弗洛洛牧场_词条.xlsx";

		// Token: 0x040015FE RID: 5630
		private const string TABLE = "FloroRanchTag";

		// Token: 0x040015FF RID: 5631
		private const string COMMAND = "select BinData from `FloroRanchTag` where Id=?";

		// Token: 0x04001600 RID: 5632
		private const string KEY_PREFIX = "FloroRanchTagById";

		// Token: 0x04001601 RID: 5633
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001602 RID: 5634
		private static int HandleId;
	}
}
