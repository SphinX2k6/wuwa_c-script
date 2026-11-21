using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DE RID: 734
	public class ConfigFilterSeniorSettingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001139 RID: 4409 RVA: 0x000BE50B File Offset: 0x000BC70B
		static ConfigFilterSeniorSettingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSeniorSettingById.CreateStaticDefaultValue), new Action(ConfigFilterSeniorSettingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x000BE52C File Offset: 0x000BC72C
		public static void CreateStaticDefaultValue()
		{
			ConfigFilterSeniorSettingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFilterSeniorSettingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "FilterSeniorSetting"),
				new ValueTuple<string, object>("语句", "select BinData from `FilterSeniorSetting` where Id=?")
			});
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x000BE5AB File Offset: 0x000BC7AB
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSeniorSettingById.LogPair = null;
			ConfigFilterSeniorSettingById.HandleId = 0;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000BE5B9 File Offset: 0x000BC7B9
		public static void Init()
		{
			ConfigFilterSeniorSettingById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSeniorSettingById.HandleId, "db_menu.db", "select BinData from `FilterSeniorSetting` where Id=?");
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x000BE5D4 File Offset: 0x000BC7D4
		public static FilterSeniorSetting? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFilterSeniorSettingById.HandleId, ConfigFilterSeniorSettingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterSeniorSettingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FilterSeniorSetting?(FilterSeniorSetting.GetRootAsFilterSeniorSetting(configBuffer));
				}
			}
			ConfigFilterSeniorSettingById.LogPair.Clear();
			ConfigFilterSeniorSettingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFilterSeniorSettingById.HandleId, 1, p0Id, ConfigFilterSeniorSettingById.LogPair) || ConfigCommon.Step(ConfigFilterSeniorSettingById.HandleId, true, ConfigFilterSeniorSettingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFilterSeniorSettingById.HandleId, ConfigFilterSeniorSettingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFilterSeniorSettingById.HandleId, 0, ConfigFilterSeniorSettingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFilterSeniorSettingById.HandleId, ConfigFilterSeniorSettingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FilterSeniorSetting rootAsFilterSeniorSetting = FilterSeniorSetting.GetRootAsFilterSeniorSetting(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FilterSeniorSettingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFilterSeniorSettingById.HandleId, ConfigFilterSeniorSettingById.LogPair);
			return new FilterSeniorSetting?(rootAsFilterSeniorSetting);
		}

		// Token: 0x040013F6 RID: 5110
		private const string DB = "db_menu.db";

		// Token: 0x040013F7 RID: 5111
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040013F8 RID: 5112
		private const string TABLE = "FilterSeniorSetting";

		// Token: 0x040013F9 RID: 5113
		private const string COMMAND = "select BinData from `FilterSeniorSetting` where Id=?";

		// Token: 0x040013FA RID: 5114
		private const string KEY_PREFIX = "FilterSeniorSettingById";

		// Token: 0x040013FB RID: 5115
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013FC RID: 5116
		private static int HandleId;
	}
}
