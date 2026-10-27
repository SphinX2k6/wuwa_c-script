using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D2 RID: 1234
	public class ConfigLifeMaxCustomizationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CF7 RID: 7415 RVA: 0x000FCD51 File Offset: 0x000FAF51
		static ConfigLifeMaxCustomizationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifeMaxCustomizationById.CreateStaticDefaultValue), new Action(ConfigLifeMaxCustomizationById.ResetStaticDefaultValue));
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000FCD70 File Offset: 0x000FAF70
		public static void CreateStaticDefaultValue()
		{
			ConfigLifeMaxCustomizationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLifeMaxCustomizationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_property.db"),
				new ValueTuple<string, object>("文件", "s.属性.xlsx"),
				new ValueTuple<string, object>("表名", "LifeMaxCustomization"),
				new ValueTuple<string, object>("语句", "select BinData from `LifeMaxCustomization` where Id = ?")
			});
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000FCDEF File Offset: 0x000FAFEF
		public static void ResetStaticDefaultValue()
		{
			ConfigLifeMaxCustomizationById.LogPair = null;
			ConfigLifeMaxCustomizationById.HandleId = 0;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000FCDFD File Offset: 0x000FAFFD
		public static void Init()
		{
			ConfigLifeMaxCustomizationById.HandleId = ConfigCommon.InitDataStatement(ConfigLifeMaxCustomizationById.HandleId, "db_property.db", "select BinData from `LifeMaxCustomization` where Id = ?");
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000FCE18 File Offset: 0x000FB018
		public static LifeMaxCustomization? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLifeMaxCustomizationById.HandleId, ConfigLifeMaxCustomizationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifeMaxCustomizationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LifeMaxCustomization?(LifeMaxCustomization.GetRootAsLifeMaxCustomization(configBuffer));
				}
			}
			ConfigLifeMaxCustomizationById.LogPair.Clear();
			ConfigLifeMaxCustomizationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLifeMaxCustomizationById.HandleId, 1, p0Id, ConfigLifeMaxCustomizationById.LogPair) || ConfigCommon.Step(ConfigLifeMaxCustomizationById.HandleId, true, ConfigLifeMaxCustomizationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLifeMaxCustomizationById.HandleId, ConfigLifeMaxCustomizationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLifeMaxCustomizationById.HandleId, 0, ConfigLifeMaxCustomizationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLifeMaxCustomizationById.HandleId, ConfigLifeMaxCustomizationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LifeMaxCustomization rootAsLifeMaxCustomization = LifeMaxCustomization.GetRootAsLifeMaxCustomization(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifeMaxCustomizationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLifeMaxCustomizationById.HandleId, ConfigLifeMaxCustomizationById.LogPair);
			return new LifeMaxCustomization?(rootAsLifeMaxCustomization);
		}

		// Token: 0x040021A2 RID: 8610
		private const string DB = "db_property.db";

		// Token: 0x040021A3 RID: 8611
		private const string FILE = "s.属性.xlsx";

		// Token: 0x040021A4 RID: 8612
		private const string TABLE = "LifeMaxCustomization";

		// Token: 0x040021A5 RID: 8613
		private const string COMMAND = "select BinData from `LifeMaxCustomization` where Id = ?";

		// Token: 0x040021A6 RID: 8614
		private const string KEY_PREFIX = "LifeMaxCustomizationById";

		// Token: 0x040021A7 RID: 8615
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021A8 RID: 8616
		private static int HandleId;
	}
}
