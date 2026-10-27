using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000276 RID: 630
	public class ConfigEntityAudioConfigByIdWithZero : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EC9 RID: 3785 RVA: 0x000AD015 File Offset: 0x000AB215
		static ConfigEntityAudioConfigByIdWithZero()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityAudioConfigByIdWithZero.CreateStaticDefaultValue), new Action(ConfigEntityAudioConfigByIdWithZero.ResetStaticDefaultValue));
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x000AD034 File Offset: 0x000AB234
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

		// Token: 0x06000ECB RID: 3787 RVA: 0x000AD0B3 File Offset: 0x000AB2B3
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityAudioConfigByIdWithZero.LogPair = null;
			ConfigEntityAudioConfigByIdWithZero.HandleId = 0;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000AD0C1 File Offset: 0x000AB2C1
		public static void Init()
		{
			ConfigEntityAudioConfigByIdWithZero.HandleId = ConfigCommon.InitDataStatement(ConfigEntityAudioConfigByIdWithZero.HandleId, "db_entity_audio.db", "select BinData from `EntityAudioConfig` where id=0 AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) >0;");
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000AD0DC File Offset: 0x000AB2DC
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

		// Token: 0x0400111E RID: 4382
		private const string DB = "db_entity_audio.db";

		// Token: 0x0400111F RID: 4383
		private const string FILE = "y.音频组件配置.xlsx";

		// Token: 0x04001120 RID: 4384
		private const string TABLE = "EntityAudioConfig";

		// Token: 0x04001121 RID: 4385
		private const string COMMAND = "select BinData from `EntityAudioConfig` where id=0 AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) <= 0 OR id = ? AND (SELECT count(0) from `EntityAudioConfig` WHERE id = ?) >0;";

		// Token: 0x04001122 RID: 4386
		private const string KEY_PREFIX = "EntityAudioConfigByIdWithZero";

		// Token: 0x04001123 RID: 4387
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001124 RID: 4388
		private static int HandleId;
	}
}
