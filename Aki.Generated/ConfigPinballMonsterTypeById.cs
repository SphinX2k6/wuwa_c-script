using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073D RID: 1853
	public class ConfigPinballMonsterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B7E RID: 11134 RVA: 0x00152BAC File Offset: 0x00150DAC
		static ConfigPinballMonsterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterTypeById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x00152BCC File Offset: 0x00150DCC
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonsterType"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonsterType` where Id=?")
			});
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x00152C4B File Offset: 0x00150E4B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterTypeById.LogPair = null;
			ConfigPinballMonsterTypeById.HandleId = 0;
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x00152C59 File Offset: 0x00150E59
		public static void Init()
		{
			ConfigPinballMonsterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterTypeById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterType` where Id=?");
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x00152C74 File Offset: 0x00150E74
		public static PinballMonsterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterTypeById.HandleId, ConfigPinballMonsterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballMonsterType?(PinballMonsterType.GetRootAsPinballMonsterType(configBuffer));
				}
			}
			ConfigPinballMonsterTypeById.LogPair.Clear();
			ConfigPinballMonsterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballMonsterTypeById.HandleId, 1, p0Id, ConfigPinballMonsterTypeById.LogPair) || ConfigCommon.Step(ConfigPinballMonsterTypeById.HandleId, true, ConfigPinballMonsterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballMonsterTypeById.HandleId, ConfigPinballMonsterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterTypeById.HandleId, 0, ConfigPinballMonsterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballMonsterTypeById.HandleId, ConfigPinballMonsterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballMonsterType rootAsPinballMonsterType = PinballMonsterType.GetRootAsPinballMonsterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballMonsterTypeById.HandleId, ConfigPinballMonsterTypeById.LogPair);
			return new PinballMonsterType?(rootAsPinballMonsterType);
		}

		// Token: 0x04003291 RID: 12945
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003292 RID: 12946
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x04003293 RID: 12947
		private const string TABLE = "PinballMonsterType";

		// Token: 0x04003294 RID: 12948
		private const string COMMAND = "select BinData from `PinballMonsterType` where Id=?";

		// Token: 0x04003295 RID: 12949
		private const string KEY_PREFIX = "PinballMonsterTypeById";

		// Token: 0x04003296 RID: 12950
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003297 RID: 12951
		private static int HandleId;
	}
}
