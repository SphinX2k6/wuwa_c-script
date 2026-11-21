using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095F RID: 2399
	public class ConfigSheriffCriminalById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600384D RID: 14413 RVA: 0x0019ACCC File Offset: 0x00198ECC
		static ConfigSheriffCriminalById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffCriminalById.CreateStaticDefaultValue), new Action(ConfigSheriffCriminalById.ResetStaticDefaultValue));
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x0019ACEC File Offset: 0x00198EEC
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

		// Token: 0x0600384F RID: 14415 RVA: 0x0019AD6B File Offset: 0x00198F6B
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffCriminalById.LogPair = null;
			ConfigSheriffCriminalById.HandleId = 0;
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x0019AD79 File Offset: 0x00198F79
		public static void Init()
		{
			ConfigSheriffCriminalById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffCriminalById.HandleId, "db_sheriff.db", "select BinData from `SheriffCriminal` where Id=?");
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x0019AD94 File Offset: 0x00198F94
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

		// Token: 0x0400417F RID: 16767
		private const string DB = "db_sheriff.db";

		// Token: 0x04004180 RID: 16768
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04004181 RID: 16769
		private const string TABLE = "SheriffCriminal";

		// Token: 0x04004182 RID: 16770
		private const string COMMAND = "select BinData from `SheriffCriminal` where Id=?";

		// Token: 0x04004183 RID: 16771
		private const string KEY_PREFIX = "SheriffCriminalById";

		// Token: 0x04004184 RID: 16772
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004185 RID: 16773
		private static int HandleId;
	}
}
