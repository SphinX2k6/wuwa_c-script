using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B1 RID: 1969
	public class ConfigQuickHackDeviceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E38 RID: 11832 RVA: 0x00161DDF File Offset: 0x0015FFDF
		static ConfigQuickHackDeviceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuickHackDeviceById.CreateStaticDefaultValue), new Action(ConfigQuickHackDeviceById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x00161E00 File Offset: 0x00160000
		public static void CreateStaticDefaultValue()
		{
			ConfigQuickHackDeviceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQuickHackDeviceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_quickhack.db"),
				new ValueTuple<string, object>("文件", "k.快速破解.xlsx"),
				new ValueTuple<string, object>("表名", "QuickHackDevice"),
				new ValueTuple<string, object>("语句", "select BinData from `QuickHackDevice` where Id = ?")
			});
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00161E7F File Offset: 0x0016007F
		public static void ResetStaticDefaultValue()
		{
			ConfigQuickHackDeviceById.LogPair = null;
			ConfigQuickHackDeviceById.HandleId = 0;
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00161E8D File Offset: 0x0016008D
		public static void Init()
		{
			ConfigQuickHackDeviceById.HandleId = ConfigCommon.InitDataStatement(ConfigQuickHackDeviceById.HandleId, "db_quickhack.db", "select BinData from `QuickHackDevice` where Id = ?");
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00161EA8 File Offset: 0x001600A8
		public static QuickHackDevice? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQuickHackDeviceById.HandleId, ConfigQuickHackDeviceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuickHackDeviceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QuickHackDevice?(QuickHackDevice.GetRootAsQuickHackDevice(configBuffer));
				}
			}
			ConfigQuickHackDeviceById.LogPair.Clear();
			ConfigQuickHackDeviceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQuickHackDeviceById.HandleId, 1, p0Id, ConfigQuickHackDeviceById.LogPair) || ConfigCommon.Step(ConfigQuickHackDeviceById.HandleId, true, ConfigQuickHackDeviceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQuickHackDeviceById.HandleId, ConfigQuickHackDeviceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQuickHackDeviceById.HandleId, 0, ConfigQuickHackDeviceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQuickHackDeviceById.HandleId, ConfigQuickHackDeviceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QuickHackDevice rootAsQuickHackDevice = QuickHackDevice.GetRootAsQuickHackDevice(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QuickHackDeviceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQuickHackDeviceById.HandleId, ConfigQuickHackDeviceById.LogPair);
			return new QuickHackDevice?(rootAsQuickHackDevice);
		}

		// Token: 0x040035BD RID: 13757
		private const string DB = "db_quickhack.db";

		// Token: 0x040035BE RID: 13758
		private const string FILE = "k.快速破解.xlsx";

		// Token: 0x040035BF RID: 13759
		private const string TABLE = "QuickHackDevice";

		// Token: 0x040035C0 RID: 13760
		private const string COMMAND = "select BinData from `QuickHackDevice` where Id = ?";

		// Token: 0x040035C1 RID: 13761
		private const string KEY_PREFIX = "QuickHackDeviceById";

		// Token: 0x040035C2 RID: 13762
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035C3 RID: 13763
		private static int HandleId;
	}
}
