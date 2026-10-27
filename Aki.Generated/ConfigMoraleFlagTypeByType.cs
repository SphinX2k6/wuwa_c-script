using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000564 RID: 1380
	public class ConfigMoraleFlagTypeByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002065 RID: 8293 RVA: 0x00110898 File Offset: 0x0010EA98
		static ConfigMoraleFlagTypeByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleFlagTypeByType.CreateStaticDefaultValue), new Action(ConfigMoraleFlagTypeByType.ResetStaticDefaultValue));
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x001108B8 File Offset: 0x0010EAB8
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleFlagTypeByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleFlagTypeByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleFlagType"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleFlagType` where TypeId=?")
			});
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00110937 File Offset: 0x0010EB37
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleFlagTypeByType.LogPair = null;
			ConfigMoraleFlagTypeByType.HandleId = 0;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00110945 File Offset: 0x0010EB45
		public static void Init()
		{
			ConfigMoraleFlagTypeByType.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleFlagTypeByType.HandleId, "db_moraleplay.db", "select BinData from `MoraleFlagType` where TypeId=?");
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x00110960 File Offset: 0x0010EB60
		public static MoraleFlagType? GetConfig(int p0TypeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleFlagTypeByType.HandleId, ConfigMoraleFlagTypeByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleFlagTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleFlagType?(MoraleFlagType.GetRootAsMoraleFlagType(configBuffer));
				}
			}
			ConfigMoraleFlagTypeByType.LogPair.Clear();
			ConfigMoraleFlagTypeByType.LogPair.Add(new ValueTuple<string, object>("TypeId", p0TypeId));
			if (!ConfigCommon.BindInt(ConfigMoraleFlagTypeByType.HandleId, 1, p0TypeId, ConfigMoraleFlagTypeByType.LogPair) || ConfigCommon.Step(ConfigMoraleFlagTypeByType.HandleId, true, ConfigMoraleFlagTypeByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleFlagTypeByType.HandleId, ConfigMoraleFlagTypeByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleFlagTypeByType.HandleId, 0, ConfigMoraleFlagTypeByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleFlagTypeByType.HandleId, ConfigMoraleFlagTypeByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleFlagType rootAsMoraleFlagType = MoraleFlagType.GetRootAsMoraleFlagType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleFlagTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleFlagTypeByType.HandleId, ConfigMoraleFlagTypeByType.LogPair);
			return new MoraleFlagType?(rootAsMoraleFlagType);
		}

		// Token: 0x040025A0 RID: 9632
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025A1 RID: 9633
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025A2 RID: 9634
		private const string TABLE = "MoraleFlagType";

		// Token: 0x040025A3 RID: 9635
		private const string COMMAND = "select BinData from `MoraleFlagType` where TypeId=?";

		// Token: 0x040025A4 RID: 9636
		private const string KEY_PREFIX = "MoraleFlagTypeByType";

		// Token: 0x040025A5 RID: 9637
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025A6 RID: 9638
		private static int HandleId;
	}
}
