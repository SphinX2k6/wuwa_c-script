using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000797 RID: 1943
	public class ConfigQuickHackDeviceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D9C RID: 11676 RVA: 0x0015AED3 File Offset: 0x001590D3
		static ConfigQuickHackDeviceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQuickHackDeviceById.CreateStaticDefaultValue), new Action(ConfigQuickHackDeviceById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x0015AEF4 File Offset: 0x001590F4
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

		// Token: 0x06002D9E RID: 11678 RVA: 0x0015AF73 File Offset: 0x00159173
		public static void ResetStaticDefaultValue()
		{
			ConfigQuickHackDeviceById.LogPair = null;
			ConfigQuickHackDeviceById.HandleId = 0;
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x0015AF81 File Offset: 0x00159181
		public static void Init()
		{
			ConfigQuickHackDeviceById.HandleId = ConfigCommon.InitDataStatement(ConfigQuickHackDeviceById.HandleId, "db_quickhack.db", "select BinData from `QuickHackDevice` where Id = ?");
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x0015AF9C File Offset: 0x0015919C
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

		// Token: 0x04003507 RID: 13575
		private const string DB = "db_quickhack.db";

		// Token: 0x04003508 RID: 13576
		private const string FILE = "k.快速破解.xlsx";

		// Token: 0x04003509 RID: 13577
		private const string TABLE = "QuickHackDevice";

		// Token: 0x0400350A RID: 13578
		private const string COMMAND = "select BinData from `QuickHackDevice` where Id = ?";

		// Token: 0x0400350B RID: 13579
		private const string KEY_PREFIX = "QuickHackDeviceById";

		// Token: 0x0400350C RID: 13580
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400350D RID: 13581
		private static int HandleId;
	}
}
