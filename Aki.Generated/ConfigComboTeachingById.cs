using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000180 RID: 384
	public class ConfigComboTeachingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x0008C508 File Offset: 0x0008A708
		static ConfigComboTeachingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigComboTeachingById.CreateStaticDefaultValue), new Action(ConfigComboTeachingById.ResetStaticDefaultValue));
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0008C528 File Offset: 0x0008A728
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

		// Token: 0x06000903 RID: 2307 RVA: 0x0008C5A7 File Offset: 0x0008A7A7
		public static void ResetStaticDefaultValue()
		{
			ConfigComboTeachingById.LogPair = null;
			ConfigComboTeachingById.HandleId = 0;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0008C5B5 File Offset: 0x0008A7B5
		public static void Init()
		{
			ConfigComboTeachingById.HandleId = ConfigCommon.InitDataStatement(ConfigComboTeachingById.HandleId, "db_combo_teaching.db", "select BinData from `ComboTeaching` where Id=?");
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0008C5D0 File Offset: 0x0008A7D0
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

		// Token: 0x04000A64 RID: 2660
		private const string DB = "db_combo_teaching.db";

		// Token: 0x04000A65 RID: 2661
		private const string FILE = "j.角色出招教学.xlsx";

		// Token: 0x04000A66 RID: 2662
		private const string TABLE = "ComboTeaching";

		// Token: 0x04000A67 RID: 2663
		private const string COMMAND = "select BinData from `ComboTeaching` where Id=?";

		// Token: 0x04000A68 RID: 2664
		private const string KEY_PREFIX = "ComboTeachingById";

		// Token: 0x04000A69 RID: 2665
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A6A RID: 2666
		private static int HandleId;
	}
}
