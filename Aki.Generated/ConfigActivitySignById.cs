using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000050 RID: 80
	public class ConfigActivitySignById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001E0 RID: 480 RVA: 0x00064510 File Offset: 0x00062710
		static ConfigActivitySignById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivitySignById.CreateStaticDefaultValue), new Action(ConfigActivitySignById.ResetStaticDefaultValue));
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00064530 File Offset: 0x00062730
		public static void CreateStaticDefaultValue()
		{
			ConfigActivitySignById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivitySignById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sevendaysign.db"),
				new ValueTuple<string, object>("文件", "q.七天签到.xlsx"),
				new ValueTuple<string, object>("表名", "ActivitySign"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivitySign` where Id=?")
			});
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000645AF File Offset: 0x000627AF
		public static void ResetStaticDefaultValue()
		{
			ConfigActivitySignById.LogPair = null;
			ConfigActivitySignById.HandleId = 0;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000645BD File Offset: 0x000627BD
		public static void Init()
		{
			ConfigActivitySignById.HandleId = ConfigCommon.InitDataStatement(ConfigActivitySignById.HandleId, "db_sevendaysign.db", "select BinData from `ActivitySign` where Id=?");
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000645D8 File Offset: 0x000627D8
		public static ActivitySign? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivitySignById.HandleId, ConfigActivitySignById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivitySignById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivitySign?(ActivitySign.GetRootAsActivitySign(configBuffer));
				}
			}
			ConfigActivitySignById.LogPair.Clear();
			ConfigActivitySignById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivitySignById.HandleId, 1, p0Id, ConfigActivitySignById.LogPair) || ConfigCommon.Step(ConfigActivitySignById.HandleId, true, ConfigActivitySignById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivitySignById.HandleId, ConfigActivitySignById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivitySignById.HandleId, 0, ConfigActivitySignById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivitySignById.HandleId, ConfigActivitySignById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivitySign rootAsActivitySign = ActivitySign.GetRootAsActivitySign(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivitySignById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivitySignById.HandleId, ConfigActivitySignById.LogPair);
			return new ActivitySign?(rootAsActivitySign);
		}

		// Token: 0x04000214 RID: 532
		private const string DB = "db_sevendaysign.db";

		// Token: 0x04000215 RID: 533
		private const string FILE = "q.七天签到.xlsx";

		// Token: 0x04000216 RID: 534
		private const string TABLE = "ActivitySign";

		// Token: 0x04000217 RID: 535
		private const string COMMAND = "select BinData from `ActivitySign` where Id=?";

		// Token: 0x04000218 RID: 536
		private const string KEY_PREFIX = "ActivitySignById";

		// Token: 0x04000219 RID: 537
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400021A RID: 538
		private static int HandleId;
	}
}
