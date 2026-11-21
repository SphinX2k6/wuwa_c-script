using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000308 RID: 776
	public class ConfigFlagAreaByEntity : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001235 RID: 4661 RVA: 0x000C3F03 File Offset: 0x000C2103
		static ConfigFlagAreaByEntity()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagAreaByEntity.CreateStaticDefaultValue), new Action(ConfigFlagAreaByEntity.ResetStaticDefaultValue));
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000C3F24 File Offset: 0x000C2124
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagAreaByEntity.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagAreaByEntity.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FlagArea"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagArea` where FlagEntityId=?")
			});
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000C3FA3 File Offset: 0x000C21A3
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagAreaByEntity.LogPair = null;
			ConfigFlagAreaByEntity.HandleId = 0;
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000C3FB1 File Offset: 0x000C21B1
		public static void Init()
		{
			ConfigFlagAreaByEntity.HandleId = ConfigCommon.InitDataStatement(ConfigFlagAreaByEntity.HandleId, "db_moraleplay.db", "select BinData from `FlagArea` where FlagEntityId=?");
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000C3FCC File Offset: 0x000C21CC
		public static FlagArea? GetConfig(int p0FlagEntityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagAreaByEntity.HandleId, ConfigFlagAreaByEntity.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagAreaByEntity");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FlagEntityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagArea?(FlagArea.GetRootAsFlagArea(configBuffer));
				}
			}
			ConfigFlagAreaByEntity.LogPair.Clear();
			ConfigFlagAreaByEntity.LogPair.Add(new ValueTuple<string, object>("FlagEntityId", p0FlagEntityId));
			if (!ConfigCommon.BindInt(ConfigFlagAreaByEntity.HandleId, 1, p0FlagEntityId, ConfigFlagAreaByEntity.LogPair) || ConfigCommon.Step(ConfigFlagAreaByEntity.HandleId, true, ConfigFlagAreaByEntity.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagAreaByEntity.HandleId, ConfigFlagAreaByEntity.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagAreaByEntity.HandleId, 0, ConfigFlagAreaByEntity.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagAreaByEntity.HandleId, ConfigFlagAreaByEntity.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagArea rootAsFlagArea = FlagArea.GetRootAsFlagArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagAreaByEntity");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FlagEntityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagAreaByEntity.HandleId, ConfigFlagAreaByEntity.LogPair);
			return new FlagArea?(rootAsFlagArea);
		}

		// Token: 0x0400151C RID: 5404
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400151D RID: 5405
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400151E RID: 5406
		private const string TABLE = "FlagArea";

		// Token: 0x0400151F RID: 5407
		private const string COMMAND = "select BinData from `FlagArea` where FlagEntityId=?";

		// Token: 0x04001520 RID: 5408
		private const string KEY_PREFIX = "FlagAreaByEntity";

		// Token: 0x04001521 RID: 5409
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001522 RID: 5410
		private static int HandleId;
	}
}
