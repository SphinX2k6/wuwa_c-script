using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025A RID: 602
	public class ConfigEffectSpecDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E20 RID: 3616 RVA: 0x000A956D File Offset: 0x000A776D
		static ConfigEffectSpecDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEffectSpecDataById.CreateStaticDefaultValue), new Action(ConfigEffectSpecDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x000A958C File Offset: 0x000A778C
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

		// Token: 0x06000E22 RID: 3618 RVA: 0x000A960B File Offset: 0x000A780B
		public static void ResetStaticDefaultValue()
		{
			ConfigEffectSpecDataById.LogPair = null;
			ConfigEffectSpecDataById.HandleId = 0;
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x000A9619 File Offset: 0x000A7819
		public static void Init()
		{
			ConfigEffectSpecDataById.HandleId = ConfigCommon.InitDataStatement(ConfigEffectSpecDataById.HandleId, "db_effectspec.db", "select BinData from `EffectSpecData` where Id=?");
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000A9634 File Offset: 0x000A7834
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

		// Token: 0x0400105A RID: 4186
		private const string DB = "db_effectspec.db";

		// Token: 0x0400105B RID: 4187
		private const string FILE = "UniverseEditor/EffectSpec.csv";

		// Token: 0x0400105C RID: 4188
		private const string TABLE = "EffectSpecData";

		// Token: 0x0400105D RID: 4189
		private const string COMMAND = "select BinData from `EffectSpecData` where Id=?";

		// Token: 0x0400105E RID: 4190
		private const string KEY_PREFIX = "EffectSpecDataById";

		// Token: 0x0400105F RID: 4191
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001060 RID: 4192
		private static int HandleId;
	}
}
