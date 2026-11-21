using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073B RID: 1851
	public class ConfigPinballMonsterRiskTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B72 RID: 11122 RVA: 0x0015271C File Offset: 0x0015091C
		static ConfigPinballMonsterRiskTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterRiskTypeById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterRiskTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0015273C File Offset: 0x0015093C
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterRiskTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterRiskTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonsterRiskType"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonsterRiskType` where Id=?")
			});
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x001527BB File Offset: 0x001509BB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterRiskTypeById.LogPair = null;
			ConfigPinballMonsterRiskTypeById.HandleId = 0;
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x001527C9 File Offset: 0x001509C9
		public static void Init()
		{
			ConfigPinballMonsterRiskTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterRiskTypeById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterRiskType` where Id=?");
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x001527E4 File Offset: 0x001509E4
		public static PinballMonsterRiskType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterRiskTypeById.HandleId, ConfigPinballMonsterRiskTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterRiskTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballMonsterRiskType?(PinballMonsterRiskType.GetRootAsPinballMonsterRiskType(configBuffer));
				}
			}
			ConfigPinballMonsterRiskTypeById.LogPair.Clear();
			ConfigPinballMonsterRiskTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballMonsterRiskTypeById.HandleId, 1, p0Id, ConfigPinballMonsterRiskTypeById.LogPair) || ConfigCommon.Step(ConfigPinballMonsterRiskTypeById.HandleId, true, ConfigPinballMonsterRiskTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballMonsterRiskTypeById.HandleId, ConfigPinballMonsterRiskTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterRiskTypeById.HandleId, 0, ConfigPinballMonsterRiskTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballMonsterRiskTypeById.HandleId, ConfigPinballMonsterRiskTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballMonsterRiskType rootAsPinballMonsterRiskType = PinballMonsterRiskType.GetRootAsPinballMonsterRiskType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterRiskTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballMonsterRiskTypeById.HandleId, ConfigPinballMonsterRiskTypeById.LogPair);
			return new PinballMonsterRiskType?(rootAsPinballMonsterRiskType);
		}

		// Token: 0x04003283 RID: 12931
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003284 RID: 12932
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x04003285 RID: 12933
		private const string TABLE = "PinballMonsterRiskType";

		// Token: 0x04003286 RID: 12934
		private const string COMMAND = "select BinData from `PinballMonsterRiskType` where Id=?";

		// Token: 0x04003287 RID: 12935
		private const string KEY_PREFIX = "PinballMonsterRiskTypeById";

		// Token: 0x04003288 RID: 12936
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003289 RID: 12937
		private static int HandleId;
	}
}
