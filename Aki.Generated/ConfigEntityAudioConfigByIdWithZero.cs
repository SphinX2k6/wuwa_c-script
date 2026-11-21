using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028A RID: 650
	public class ConfigEntityAudioConfigByIdWithZero : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x000B32D9 File Offset: 0x000B14D9
		static ConfigEntityAudioConfigByIdWithZero()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityAudioConfigByIdWithZero.CreateStaticDefaultValue), new Action(ConfigEntityAudioConfigByIdWithZero.ResetStaticDefaultValue));
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x000B32F8 File Offset: 0x000B14F8
		public static void CreateStaticDefaultValue()
		{
			ConfigEntityAudioConfigByIdWithZero.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntityAudioConfigByIdWithZero.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entity_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "EntityAudioConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EntityAudioConfig` where id=0 AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) >0;")
			});
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x000B3377 File Offset: 0x000B1577
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityAudioConfigByIdWithZero.LogPair = null;
			ConfigEntityAudioConfigByIdWithZero.HandleId = 0;
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000B3385 File Offset: 0x000B1585
		public static void Init()
		{
			ConfigEntityAudioConfigByIdWithZero.HandleId = ConfigCommon.InitDataStatement(ConfigEntityAudioConfigByIdWithZero.HandleId, "db_entity_audio.db", "select BinData from `EntityAudioConfig` where id=0 AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) >0;");
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x000B33A0 File Offset: 0x000B15A0
		public static EntityAudioConfig? GetConfig(string p0Id, string p1Id, string p2Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntityAudioConfigByIdWithZero.HandleId, ConfigEntityAudioConfigByIdWithZero.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("EntityAudioConfigByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntityAudioConfig?(EntityAudioConfig.GetRootAsEntityAudioConfig(configBuffer));
				}
			}
			ConfigEntityAudioConfigByIdWithZero.LogPair.Clear();
			ConfigEntityAudioConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			ConfigEntityAudioConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p1Id));
			ConfigEntityAudioConfigByIdWithZero.LogPair.Add(new ValueTuple<string, object>("Id", p2Id));
			if (!ConfigCommon.BindString(ConfigEntityAudioConfigByIdWithZero.HandleId, 1, p0Id, ConfigEntityAudioConfigByIdWithZero.LogPair) || !ConfigCommon.BindString(ConfigEntityAudioConfigByIdWithZero.HandleId, 2, p1Id, ConfigEntityAudioConfigByIdWithZero.LogPair) || !ConfigCommon.BindString(ConfigEntityAudioConfigByIdWithZero.HandleId, 3, p2Id, ConfigEntityAudioConfigByIdWithZero.LogPair) || ConfigCommon.Step(ConfigEntityAudioConfigByIdWithZero.HandleId, true, ConfigEntityAudioConfigByIdWithZero.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntityAudioConfigByIdWithZero.HandleId, ConfigEntityAudioConfigByIdWithZero.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntityAudioConfigByIdWithZero.HandleId, 0, ConfigEntityAudioConfigByIdWithZero.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntityAudioConfigByIdWithZero.HandleId, ConfigEntityAudioConfigByIdWithZero.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntityAudioConfig rootAsEntityAudioConfig = EntityAudioConfig.GetRootAsEntityAudioConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3, 4);
				defaultInterpolatedStringHandler.AppendFormatted("EntityAudioConfigByIdWithZero");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p0Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p1Id);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted(p2Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntityAudioConfigByIdWithZero.HandleId, ConfigEntityAudioConfigByIdWithZero.LogPair);
			return new EntityAudioConfig?(rootAsEntityAudioConfig);
		}

		// Token: 0x040011AA RID: 4522
		private const string DB = "db_entity_audio.db";

		// Token: 0x040011AB RID: 4523
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x040011AC RID: 4524
		private const string TABLE = "EntityAudioConfig";

		// Token: 0x040011AD RID: 4525
		private const string COMMAND = "select BinData from `EntityAudioConfig` where id=0 AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) >0;";

		// Token: 0x040011AE RID: 4526
		private const string KEY_PREFIX = "EntityAudioConfigByIdWithZero";

		// Token: 0x040011AF RID: 4527
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011B0 RID: 4528
		private static int HandleId;
	}
}
