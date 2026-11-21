using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002E0 RID: 736
	public class ConfigFilterSettingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001145 RID: 4421 RVA: 0x000BE8E7 File Offset: 0x000BCAE7
		static ConfigFilterSettingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSettingById.CreateStaticDefaultValue), new Action(ConfigFilterSettingById.ResetStaticDefaultValue));
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000BE908 File Offset: 0x000BCB08
		public static void CreateStaticDefaultValue()
		{
			ConfigFilterSettingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFilterSettingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "FilterSetting"),
				new ValueTuple<string, object>("语句", "select BinData from `FilterSetting` where Id=?")
			});
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x000BE987 File Offset: 0x000BCB87
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSettingById.LogPair = null;
			ConfigFilterSettingById.HandleId = 0;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x000BE995 File Offset: 0x000BCB95
		public static void Init()
		{
			ConfigFilterSettingById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSettingById.HandleId, "db_menu.db", "select BinData from `FilterSetting` where Id=?");
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000BE9B0 File Offset: 0x000BCBB0
		public static FilterSetting? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFilterSettingById.HandleId, ConfigFilterSettingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterSettingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FilterSetting?(FilterSetting.GetRootAsFilterSetting(configBuffer));
				}
			}
			ConfigFilterSettingById.LogPair.Clear();
			ConfigFilterSettingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFilterSettingById.HandleId, 1, p0Id, ConfigFilterSettingById.LogPair) || ConfigCommon.Step(ConfigFilterSettingById.HandleId, true, ConfigFilterSettingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFilterSettingById.HandleId, ConfigFilterSettingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFilterSettingById.HandleId, 0, ConfigFilterSettingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFilterSettingById.HandleId, ConfigFilterSettingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FilterSetting rootAsFilterSetting = FilterSetting.GetRootAsFilterSetting(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterSettingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFilterSettingById.HandleId, ConfigFilterSettingById.LogPair);
			return new FilterSetting?(rootAsFilterSetting);
		}

		// Token: 0x04001404 RID: 5124
		private const string DB = "db_menu.db";

		// Token: 0x04001405 RID: 5125
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001406 RID: 5126
		private const string TABLE = "FilterSetting";

		// Token: 0x04001407 RID: 5127
		private const string COMMAND = "select BinData from `FilterSetting` where Id=?";

		// Token: 0x04001408 RID: 5128
		private const string KEY_PREFIX = "FilterSettingById";

		// Token: 0x04001409 RID: 5129
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400140A RID: 5130
		private static int HandleId;
	}
}
