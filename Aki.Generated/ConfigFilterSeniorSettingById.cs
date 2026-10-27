using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002C9 RID: 713
	public class ConfigFilterSeniorSettingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010BB RID: 4283 RVA: 0x000B7FFF File Offset: 0x000B61FF
		static ConfigFilterSeniorSettingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFilterSeniorSettingById.CreateStaticDefaultValue), new Action(ConfigFilterSeniorSettingById.ResetStaticDefaultValue));
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x000B8020 File Offset: 0x000B6220
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

		// Token: 0x060010BD RID: 4285 RVA: 0x000B809F File Offset: 0x000B629F
		public static void ResetStaticDefaultValue()
		{
			ConfigFilterSeniorSettingById.LogPair = null;
			ConfigFilterSeniorSettingById.HandleId = 0;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000B80AD File Offset: 0x000B62AD
		public static void Init()
		{
			ConfigFilterSeniorSettingById.HandleId = ConfigCommon.InitDataStatement(ConfigFilterSeniorSettingById.HandleId, "db_menu.db", "select BinData from `FilterSeniorSetting` where Id=?");
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x000B80C8 File Offset: 0x000B62C8
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

		// Token: 0x04001363 RID: 4963
		private const string DB = "db_menu.db";

		// Token: 0x04001364 RID: 4964
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04001365 RID: 4965
		private const string TABLE = "FilterSeniorSetting";

		// Token: 0x04001366 RID: 4966
		private const string COMMAND = "select BinData from `FilterSeniorSetting` where Id=?";

		// Token: 0x04001367 RID: 4967
		private const string KEY_PREFIX = "FilterSeniorSettingById";

		// Token: 0x04001368 RID: 4968
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001369 RID: 4969
		private static int HandleId;
	}
}
