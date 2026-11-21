using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004E8 RID: 1256
	public class ConfigLifeMaxCustomizationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D7B RID: 7547 RVA: 0x001034A5 File Offset: 0x001016A5
		static ConfigLifeMaxCustomizationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifeMaxCustomizationById.CreateStaticDefaultValue), new Action(ConfigLifeMaxCustomizationById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x001034C4 File Offset: 0x001016C4
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

		// Token: 0x06001D7D RID: 7549 RVA: 0x00103543 File Offset: 0x00101743
		public static void ResetStaticDefaultValue()
		{
			ConfigLifeMaxCustomizationById.LogPair = null;
			ConfigLifeMaxCustomizationById.HandleId = 0;
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00103551 File Offset: 0x00101751
		public static void Init()
		{
			ConfigLifeMaxCustomizationById.HandleId = ConfigCommon.InitDataStatement(ConfigLifeMaxCustomizationById.HandleId, "db_property.db", "select BinData from `LifeMaxCustomization` where Id = ?");
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x0010356C File Offset: 0x0010176C
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

		// Token: 0x0400223C RID: 8764
		private const string DB = "db_property.db";

		// Token: 0x0400223D RID: 8765
		private const string FILE = "s.属性.xlsx";

		// Token: 0x0400223E RID: 8766
		private const string TABLE = "LifeMaxCustomization";

		// Token: 0x0400223F RID: 8767
		private const string COMMAND = "select BinData from `LifeMaxCustomization` where Id = ?";

		// Token: 0x04002240 RID: 8768
		private const string KEY_PREFIX = "LifeMaxCustomizationById";

		// Token: 0x04002241 RID: 8769
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002242 RID: 8770
		private static int HandleId;
	}
}
