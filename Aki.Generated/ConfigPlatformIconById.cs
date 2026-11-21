using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000756 RID: 1878
	public class ConfigPlatformIconById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C14 RID: 11284 RVA: 0x001562AB File Offset: 0x001544AB
		static ConfigPlatformIconById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlatformIconById.CreateStaticDefaultValue), new Action(ConfigPlatformIconById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x001562CC File Offset: 0x001544CC
		public static void CreateStaticDefaultValue()
		{
			ConfigPlatformIconById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlatformIconById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformicon.db"),
				new ValueTuple<string, object>("文件", "d.多端图标.xlsx"),
				new ValueTuple<string, object>("表名", "PlatformIcon"),
				new ValueTuple<string, object>("语句", "select BinData from `PlatformIcon` where Id=?")
			});
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x0015634B File Offset: 0x0015454B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlatformIconById.LogPair = null;
			ConfigPlatformIconById.HandleId = 0;
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x00156359 File Offset: 0x00154559
		public static void Init()
		{
			ConfigPlatformIconById.HandleId = ConfigCommon.InitDataStatement(ConfigPlatformIconById.HandleId, "db_platformicon.db", "select BinData from `PlatformIcon` where Id=?");
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00156374 File Offset: 0x00154574
		public static PlatformIcon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlatformIconById.HandleId, ConfigPlatformIconById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlatformIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlatformIcon?(PlatformIcon.GetRootAsPlatformIcon(configBuffer));
				}
			}
			ConfigPlatformIconById.LogPair.Clear();
			ConfigPlatformIconById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPlatformIconById.HandleId, 1, p0Id, ConfigPlatformIconById.LogPair) || ConfigCommon.Step(ConfigPlatformIconById.HandleId, true, ConfigPlatformIconById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlatformIconById.HandleId, ConfigPlatformIconById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlatformIconById.HandleId, 0, ConfigPlatformIconById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlatformIconById.HandleId, ConfigPlatformIconById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlatformIcon rootAsPlatformIcon = PlatformIcon.GetRootAsPlatformIcon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlatformIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlatformIconById.HandleId, ConfigPlatformIconById.LogPair);
			return new PlatformIcon?(rootAsPlatformIcon);
		}

		// Token: 0x04003340 RID: 13120
		private const string DB = "db_platformicon.db";

		// Token: 0x04003341 RID: 13121
		private const string FILE = "d.多端图标.xlsx";

		// Token: 0x04003342 RID: 13122
		private const string TABLE = "PlatformIcon";

		// Token: 0x04003343 RID: 13123
		private const string COMMAND = "select BinData from `PlatformIcon` where Id=?";

		// Token: 0x04003344 RID: 13124
		private const string KEY_PREFIX = "PlatformIconById";

		// Token: 0x04003345 RID: 13125
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003346 RID: 13126
		private static int HandleId;
	}
}
