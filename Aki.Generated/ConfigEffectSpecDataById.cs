using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026E RID: 622
	public class ConfigEffectSpecDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E98 RID: 3736 RVA: 0x000AF831 File Offset: 0x000ADA31
		static ConfigEffectSpecDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectSpecDataById.CreateStaticDefaultValue), new Action(ConfigEffectSpecDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x000AF850 File Offset: 0x000ADA50
		public static void CreateStaticDefaultValue()
		{
			ConfigEffectSpecDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEffectSpecDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_effectspec.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/EffectSpec.csv"),
				new ValueTuple<string, object>("表名", "EffectSpecData"),
				new ValueTuple<string, object>("语句", "select BinData from `EffectSpecData` where Id=?")
			});
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x000AF8CF File Offset: 0x000ADACF
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectSpecDataById.LogPair = null;
			ConfigEffectSpecDataById.HandleId = 0;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000AF8DD File Offset: 0x000ADADD
		public static void Init()
		{
			ConfigEffectSpecDataById.HandleId = ConfigCommon.InitDataStatement(ConfigEffectSpecDataById.HandleId, "db_effectspec.db", "select BinData from `EffectSpecData` where Id=?");
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x000AF8F8 File Offset: 0x000ADAF8
		public static EffectSpecData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEffectSpecDataById.HandleId, ConfigEffectSpecDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EffectSpecDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EffectSpecData?(EffectSpecData.GetRootAsEffectSpecData(configBuffer));
				}
			}
			ConfigEffectSpecDataById.LogPair.Clear();
			ConfigEffectSpecDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEffectSpecDataById.HandleId, 1, p0Id, ConfigEffectSpecDataById.LogPair) || ConfigCommon.Step(ConfigEffectSpecDataById.HandleId, true, ConfigEffectSpecDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEffectSpecDataById.HandleId, ConfigEffectSpecDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEffectSpecDataById.HandleId, 0, ConfigEffectSpecDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEffectSpecDataById.HandleId, ConfigEffectSpecDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EffectSpecData rootAsEffectSpecData = EffectSpecData.GetRootAsEffectSpecData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EffectSpecDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEffectSpecDataById.HandleId, ConfigEffectSpecDataById.LogPair);
			return new EffectSpecData?(rootAsEffectSpecData);
		}

		// Token: 0x040010E6 RID: 4326
		private const string DB = "db_effectspec.db";

		// Token: 0x040010E7 RID: 4327
		private const string FILE = "UniverseEditor/EffectSpec.csv";

		// Token: 0x040010E8 RID: 4328
		private const string TABLE = "EffectSpecData";

		// Token: 0x040010E9 RID: 4329
		private const string COMMAND = "select BinData from `EffectSpecData` where Id=?";

		// Token: 0x040010EA RID: 4330
		private const string KEY_PREFIX = "EffectSpecDataById";

		// Token: 0x040010EB RID: 4331
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010EC RID: 4332
		private static int HandleId;
	}
}
