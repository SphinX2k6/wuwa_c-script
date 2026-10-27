using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A70 RID: 2672
	public class ConfigUniversalActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EB4 RID: 16052 RVA: 0x001BC910 File Offset: 0x001BAB10
		static ConfigUniversalActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUniversalActivityById.CreateStaticDefaultValue), new Action(ConfigUniversalActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x001BC930 File Offset: 0x001BAB30
		public static void CreateStaticDefaultValue()
		{
			ConfigUniversalActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUniversalActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "t.通用活动.xlsx"),
				new ValueTuple<string, object>("表名", "UniversalActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `UniversalActivity` where Id=?")
			});
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x001BC9AF File Offset: 0x001BABAF
		public static void ResetStaticDefaultValue()
		{
			ConfigUniversalActivityById.LogPair = null;
			ConfigUniversalActivityById.HandleId = 0;
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x001BC9BD File Offset: 0x001BABBD
		public static void Init()
		{
			ConfigUniversalActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigUniversalActivityById.HandleId, "db_activity.db", "select BinData from `UniversalActivity` where Id=?");
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x001BC9D8 File Offset: 0x001BABD8
		public static UniversalActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUniversalActivityById.HandleId, ConfigUniversalActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UniversalActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new UniversalActivity?(UniversalActivity.GetRootAsUniversalActivity(configBuffer));
				}
			}
			ConfigUniversalActivityById.LogPair.Clear();
			ConfigUniversalActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigUniversalActivityById.HandleId, 1, p0Id, ConfigUniversalActivityById.LogPair) || ConfigCommon.Step(ConfigUniversalActivityById.HandleId, true, ConfigUniversalActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUniversalActivityById.HandleId, ConfigUniversalActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUniversalActivityById.HandleId, 0, ConfigUniversalActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUniversalActivityById.HandleId, ConfigUniversalActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UniversalActivity rootAsUniversalActivity = UniversalActivity.GetRootAsUniversalActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UniversalActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUniversalActivityById.HandleId, ConfigUniversalActivityById.LogPair);
			return new UniversalActivity?(rootAsUniversalActivity);
		}

		// Token: 0x040048F6 RID: 18678
		private const string DB = "db_activity.db";

		// Token: 0x040048F7 RID: 18679
		private const string FILE = "t.通用活动.xlsx";

		// Token: 0x040048F8 RID: 18680
		private const string TABLE = "UniversalActivity";

		// Token: 0x040048F9 RID: 18681
		private const string COMMAND = "select BinData from `UniversalActivity` where Id=?";

		// Token: 0x040048FA RID: 18682
		private const string KEY_PREFIX = "UniversalActivityById";

		// Token: 0x040048FB RID: 18683
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048FC RID: 18684
		private static int HandleId;
	}
}
