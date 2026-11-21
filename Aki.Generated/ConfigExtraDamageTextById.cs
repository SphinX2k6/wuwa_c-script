using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BD RID: 701
	public class ConfigExtraDamageTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001073 RID: 4211 RVA: 0x000B9F05 File Offset: 0x000B8105
		static ConfigExtraDamageTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExtraDamageTextById.CreateStaticDefaultValue), new Action(ConfigExtraDamageTextById.ResetStaticDefaultValue));
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x000B9F24 File Offset: 0x000B8124
		public static void CreateStaticDefaultValue()
		{
			ConfigExtraDamageTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExtraDamageTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_damage_text.db"),
				new ValueTuple<string, object>("文件", "s.伤害飘字.xlsx"),
				new ValueTuple<string, object>("表名", "ExtraDamageText"),
				new ValueTuple<string, object>("语句", "select BinData from `ExtraDamageText` where Id=?")
			});
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x000B9FA3 File Offset: 0x000B81A3
		public static void ResetStaticDefaultValue()
		{
			ConfigExtraDamageTextById.LogPair = null;
			ConfigExtraDamageTextById.HandleId = 0;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x000B9FB1 File Offset: 0x000B81B1
		public static void Init()
		{
			ConfigExtraDamageTextById.HandleId = ConfigCommon.InitDataStatement(ConfigExtraDamageTextById.HandleId, "db_damage_text.db", "select BinData from `ExtraDamageText` where Id=?");
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000B9FCC File Offset: 0x000B81CC
		public static ExtraDamageText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExtraDamageTextById.HandleId, ConfigExtraDamageTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExtraDamageTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExtraDamageText?(ExtraDamageText.GetRootAsExtraDamageText(configBuffer));
				}
			}
			ConfigExtraDamageTextById.LogPair.Clear();
			ConfigExtraDamageTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExtraDamageTextById.HandleId, 1, p0Id, ConfigExtraDamageTextById.LogPair) || ConfigCommon.Step(ConfigExtraDamageTextById.HandleId, true, ConfigExtraDamageTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExtraDamageTextById.HandleId, ConfigExtraDamageTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExtraDamageTextById.HandleId, 0, ConfigExtraDamageTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExtraDamageTextById.HandleId, ConfigExtraDamageTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExtraDamageText rootAsExtraDamageText = ExtraDamageText.GetRootAsExtraDamageText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExtraDamageTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExtraDamageTextById.HandleId, ConfigExtraDamageTextById.LogPair);
			return new ExtraDamageText?(rootAsExtraDamageText);
		}

		// Token: 0x0400130F RID: 4879
		private const string DB = "db_damage_text.db";

		// Token: 0x04001310 RID: 4880
		private const string FILE = "s.伤害飘字.xlsx";

		// Token: 0x04001311 RID: 4881
		private const string TABLE = "ExtraDamageText";

		// Token: 0x04001312 RID: 4882
		private const string COMMAND = "select BinData from `ExtraDamageText` where Id=?";

		// Token: 0x04001313 RID: 4883
		private const string KEY_PREFIX = "ExtraDamageTextById";

		// Token: 0x04001314 RID: 4884
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001315 RID: 4885
		private static int HandleId;
	}
}
