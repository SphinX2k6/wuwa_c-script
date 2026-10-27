using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000725 RID: 1829
	public class ConfigPinballMonsterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AEE RID: 10990 RVA: 0x0014C130 File Offset: 0x0014A330
		static ConfigPinballMonsterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterTypeById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x0014C150 File Offset: 0x0014A350
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

		// Token: 0x06002AF0 RID: 10992 RVA: 0x0014C1CF File Offset: 0x0014A3CF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterTypeById.LogPair = null;
			ConfigPinballMonsterTypeById.HandleId = 0;
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x0014C1DD File Offset: 0x0014A3DD
		public static void Init()
		{
			ConfigPinballMonsterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterTypeById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterType` where Id=?");
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0014C1F8 File Offset: 0x0014A3F8
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

		// Token: 0x040031E9 RID: 12777
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031EA RID: 12778
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x040031EB RID: 12779
		private const string TABLE = "PinballMonsterType";

		// Token: 0x040031EC RID: 12780
		private const string COMMAND = "select BinData from `PinballMonsterType` where Id=?";

		// Token: 0x040031ED RID: 12781
		private const string KEY_PREFIX = "PinballMonsterTypeById";

		// Token: 0x040031EE RID: 12782
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031EF RID: 12783
		private static int HandleId;
	}
}
