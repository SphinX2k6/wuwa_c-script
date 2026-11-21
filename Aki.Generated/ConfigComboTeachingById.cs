using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000192 RID: 402
	public class ConfigComboTeachingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600096D RID: 2413 RVA: 0x00092440 File Offset: 0x00090640
		static ConfigComboTeachingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigComboTeachingById.CreateStaticDefaultValue), new Action(ConfigComboTeachingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00092460 File Offset: 0x00090660
		public static void CreateStaticDefaultValue()
		{
			ConfigComboTeachingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigComboTeachingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_combo_teaching.db"),
				new ValueTuple<string, object>("文件", "j.角色出招教学.xlsx"),
				new ValueTuple<string, object>("表名", "ComboTeaching"),
				new ValueTuple<string, object>("语句", "select BinData from `ComboTeaching` where Id=?")
			});
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000924DF File Offset: 0x000906DF
		public static void ResetStaticDefaultValue()
		{
			ConfigComboTeachingById.LogPair = null;
			ConfigComboTeachingById.HandleId = 0;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000924ED File Offset: 0x000906ED
		public static void Init()
		{
			ConfigComboTeachingById.HandleId = ConfigCommon.InitDataStatement(ConfigComboTeachingById.HandleId, "db_combo_teaching.db", "select BinData from `ComboTeaching` where Id=?");
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00092508 File Offset: 0x00090708
		public static ComboTeaching? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigComboTeachingById.HandleId, ConfigComboTeachingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ComboTeachingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ComboTeaching?(ComboTeaching.GetRootAsComboTeaching(configBuffer));
				}
			}
			ConfigComboTeachingById.LogPair.Clear();
			ConfigComboTeachingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigComboTeachingById.HandleId, 1, p0Id, ConfigComboTeachingById.LogPair) || ConfigCommon.Step(ConfigComboTeachingById.HandleId, true, ConfigComboTeachingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigComboTeachingById.HandleId, ConfigComboTeachingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigComboTeachingById.HandleId, 0, ConfigComboTeachingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigComboTeachingById.HandleId, ConfigComboTeachingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ComboTeaching rootAsComboTeaching = ComboTeaching.GetRootAsComboTeaching(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ComboTeachingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigComboTeachingById.HandleId, ConfigComboTeachingById.LogPair);
			return new ComboTeaching?(rootAsComboTeaching);
		}

		// Token: 0x04000AE2 RID: 2786
		private const string DB = "db_combo_teaching.db";

		// Token: 0x04000AE3 RID: 2787
		private const string FILE = "j.角色出招教学.xlsx";

		// Token: 0x04000AE4 RID: 2788
		private const string TABLE = "ComboTeaching";

		// Token: 0x04000AE5 RID: 2789
		private const string COMMAND = "select BinData from `ComboTeaching` where Id=?";

		// Token: 0x04000AE6 RID: 2790
		private const string KEY_PREFIX = "ComboTeachingById";

		// Token: 0x04000AE7 RID: 2791
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AE8 RID: 2792
		private static int HandleId;
	}
}
