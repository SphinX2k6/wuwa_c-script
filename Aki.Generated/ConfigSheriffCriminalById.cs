using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000914 RID: 2324
	public class ConfigSheriffCriminalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600368B RID: 13963 RVA: 0x0018DAAC File Offset: 0x0018BCAC
		static ConfigSheriffCriminalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffCriminalById.CreateStaticDefaultValue), new Action(ConfigSheriffCriminalById.ResetStaticDefaultValue));
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x0018DACC File Offset: 0x0018BCCC
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffCriminalById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffCriminalById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffCriminal"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffCriminal` where Id=?")
			});
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x0018DB4B File Offset: 0x0018BD4B
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffCriminalById.LogPair = null;
			ConfigSheriffCriminalById.HandleId = 0;
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x0018DB59 File Offset: 0x0018BD59
		public static void Init()
		{
			ConfigSheriffCriminalById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffCriminalById.HandleId, "db_sheriff.db", "select BinData from `SheriffCriminal` where Id=?");
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x0018DB74 File Offset: 0x0018BD74
		public static SheriffCriminal? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffCriminalById.HandleId, ConfigSheriffCriminalById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffCriminalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffCriminal?(SheriffCriminal.GetRootAsSheriffCriminal(configBuffer));
				}
			}
			ConfigSheriffCriminalById.LogPair.Clear();
			ConfigSheriffCriminalById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffCriminalById.HandleId, 1, p0Id, ConfigSheriffCriminalById.LogPair) || ConfigCommon.Step(ConfigSheriffCriminalById.HandleId, true, ConfigSheriffCriminalById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffCriminalById.HandleId, ConfigSheriffCriminalById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffCriminalById.HandleId, 0, ConfigSheriffCriminalById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffCriminalById.HandleId, ConfigSheriffCriminalById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffCriminal rootAsSheriffCriminal = SheriffCriminal.GetRootAsSheriffCriminal(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffCriminalById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffCriminalById.HandleId, ConfigSheriffCriminalById.LogPair);
			return new SheriffCriminal?(rootAsSheriffCriminal);
		}

		// Token: 0x04003F72 RID: 16242
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F73 RID: 16243
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F74 RID: 16244
		private const string TABLE = "SheriffCriminal";

		// Token: 0x04003F75 RID: 16245
		private const string COMMAND = "select BinData from `SheriffCriminal` where Id=?";

		// Token: 0x04003F76 RID: 16246
		private const string KEY_PREFIX = "SheriffCriminalById";

		// Token: 0x04003F77 RID: 16247
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F78 RID: 16248
		private static int HandleId;
	}
}
