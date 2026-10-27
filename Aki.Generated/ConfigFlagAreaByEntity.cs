using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F3 RID: 755
	public class ConfigFlagAreaByEntity : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011B7 RID: 4535 RVA: 0x000BD9F7 File Offset: 0x000BBBF7
		static ConfigFlagAreaByEntity()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagAreaByEntity.CreateStaticDefaultValue), new Action(ConfigFlagAreaByEntity.ResetStaticDefaultValue));
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x000BDA18 File Offset: 0x000BBC18
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

		// Token: 0x060011B9 RID: 4537 RVA: 0x000BDA97 File Offset: 0x000BBC97
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagAreaByEntity.LogPair = null;
			ConfigFlagAreaByEntity.HandleId = 0;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x000BDAA5 File Offset: 0x000BBCA5
		public static void Init()
		{
			ConfigFlagAreaByEntity.HandleId = ConfigCommon.InitDataStatement(ConfigFlagAreaByEntity.HandleId, "db_moraleplay.db", "select BinData from `FlagArea` where FlagEntityId=?");
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x000BDAC0 File Offset: 0x000BBCC0
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

		// Token: 0x04001489 RID: 5257
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400148A RID: 5258
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400148B RID: 5259
		private const string TABLE = "FlagArea";

		// Token: 0x0400148C RID: 5260
		private const string COMMAND = "select BinData from `FlagArea` where FlagEntityId=?";

		// Token: 0x0400148D RID: 5261
		private const string KEY_PREFIX = "FlagAreaByEntity";

		// Token: 0x0400148E RID: 5262
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400148F RID: 5263
		private static int HandleId;
	}
}
