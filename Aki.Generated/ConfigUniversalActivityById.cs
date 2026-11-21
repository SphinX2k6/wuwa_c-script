using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B45 RID: 2885
	public class ConfigUniversalActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043B2 RID: 17330 RVA: 0x001DBCA4 File Offset: 0x001D9EA4
		static ConfigUniversalActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUniversalActivityById.CreateStaticDefaultValue), new Action(ConfigUniversalActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x001DBCC4 File Offset: 0x001D9EC4
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

		// Token: 0x060043B4 RID: 17332 RVA: 0x001DBD43 File Offset: 0x001D9F43
		public static void ResetStaticDefaultValue()
		{
			ConfigUniversalActivityById.LogPair = null;
			ConfigUniversalActivityById.HandleId = 0;
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x001DBD51 File Offset: 0x001D9F51
		public static void Init()
		{
			ConfigUniversalActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigUniversalActivityById.HandleId, "db_activity.db", "select BinData from `UniversalActivity` where Id=?");
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x001DBD6C File Offset: 0x001D9F6C
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

		// Token: 0x04004EC9 RID: 20169
		private const string DB = "db_activity.db";

		// Token: 0x04004ECA RID: 20170
		private const string FILE = "t.通用活动.xlsx";

		// Token: 0x04004ECB RID: 20171
		private const string TABLE = "UniversalActivity";

		// Token: 0x04004ECC RID: 20172
		private const string COMMAND = "select BinData from `UniversalActivity` where Id=?";

		// Token: 0x04004ECD RID: 20173
		private const string KEY_PREFIX = "UniversalActivityById";

		// Token: 0x04004ECE RID: 20174
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004ECF RID: 20175
		private static int HandleId;
	}
}
