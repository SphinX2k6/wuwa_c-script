using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000320 RID: 800
	public class ConfigFloroRanchActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012C5 RID: 4805 RVA: 0x000C735C File Offset: 0x000C555C
		static ConfigFloroRanchActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchActivityById.CreateStaticDefaultValue), new Action(ConfigFloroRanchActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000C737C File Offset: 0x000C557C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchActivity` where Id=?")
			});
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000C73FB File Offset: 0x000C55FB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchActivityById.LogPair = null;
			ConfigFloroRanchActivityById.HandleId = 0;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000C7409 File Offset: 0x000C5609
		public static void Init()
		{
			ConfigFloroRanchActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchActivityById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchActivity` where Id=?");
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x000C7424 File Offset: 0x000C5624
		public static FloroRanchActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchActivityById.HandleId, ConfigFloroRanchActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchActivity?(FloroRanchActivity.GetRootAsFloroRanchActivity(configBuffer));
				}
			}
			ConfigFloroRanchActivityById.LogPair.Clear();
			ConfigFloroRanchActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchActivityById.HandleId, 1, p0Id, ConfigFloroRanchActivityById.LogPair) || ConfigCommon.Step(ConfigFloroRanchActivityById.HandleId, true, ConfigFloroRanchActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchActivityById.HandleId, ConfigFloroRanchActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchActivityById.HandleId, 0, ConfigFloroRanchActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchActivityById.HandleId, ConfigFloroRanchActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchActivity rootAsFloroRanchActivity = FloroRanchActivity.GetRootAsFloroRanchActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchActivityById.HandleId, ConfigFloroRanchActivityById.LogPair);
			return new FloroRanchActivity?(rootAsFloroRanchActivity);
		}

		// Token: 0x040015C4 RID: 5572
		private const string DB = "db_flororanch.db";

		// Token: 0x040015C5 RID: 5573
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015C6 RID: 5574
		private const string TABLE = "FloroRanchActivity";

		// Token: 0x040015C7 RID: 5575
		private const string COMMAND = "select BinData from `FloroRanchActivity` where Id=?";

		// Token: 0x040015C8 RID: 5576
		private const string KEY_PREFIX = "FloroRanchActivityById";

		// Token: 0x040015C9 RID: 5577
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015CA RID: 5578
		private static int HandleId;
	}
}
