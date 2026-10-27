using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CB RID: 715
	public class ConfigFilterSettingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010C7 RID: 4295 RVA: 0x000B83DB File Offset: 0x000B65DB
		static ConfigFilterSettingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSettingById.CreateStaticDefaultValue), new Action(ConfigFilterSettingById.ResetStaticDefaultValue));
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000B83FC File Offset: 0x000B65FC
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

		// Token: 0x060010C9 RID: 4297 RVA: 0x000B847B File Offset: 0x000B667B
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSettingById.LogPair = null;
			ConfigFilterSettingById.HandleId = 0;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x000B8489 File Offset: 0x000B6689
		public static void Init()
		{
			ConfigFilterSettingById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSettingById.HandleId, "db_menu.db", "select BinData from `FilterSetting` where Id=?");
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000B84A4 File Offset: 0x000B66A4
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

		// Token: 0x04001371 RID: 4977
		private const string DB = "db_menu.db";

		// Token: 0x04001372 RID: 4978
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001373 RID: 4979
		private const string TABLE = "FilterSetting";

		// Token: 0x04001374 RID: 4980
		private const string COMMAND = "select BinData from `FilterSetting` where Id=?";

		// Token: 0x04001375 RID: 4981
		private const string KEY_PREFIX = "FilterSettingById";

		// Token: 0x04001376 RID: 4982
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001377 RID: 4983
		private static int HandleId;
	}
}
